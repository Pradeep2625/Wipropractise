import {
    createReferral,
    fetchReferrals,
    updateReferral,
  } from '@/app/slices/authorization/referralsSlice';
  import { RootState } from '@/app/store';
  import CommentSection from '@/components/Authorization/Editor/CommentSection';
  import { extractInsuranceData, extractInsurancePolicies, parsePythonDict } from '@/components/Authorization/Utils';
  import { useLoader } from '@/context/Loader/LoaderProvider';
  import { useAuthorizationContext } from '@/pages/authorization/Context';
  import { formatDate } from '@/utils';
  import { useMsal } from '@azure/msal-react';
  import {
    Box,
    Button,
    Dialog,
    DialogActions,
    DialogContent,
    DialogTitle,
    Divider,
    FormControl,
    FormControlLabel,
    FormLabel,
    MenuItem,
    Radio,
    RadioGroup,
    TextField,
    Typography,
    Chip,
    Autocomplete,
  } from '@mui/material';
  import { useCallback, useEffect, useMemo, useState } from 'react';
  import { useDispatch, useSelector } from 'react-redux';
  import EditorFormWrapper from '../../EditorWrapper';
  import SectionHeader from '@/plugin/SectionHeader';
  import Icon from '@/plugin/Icon';
  import { getStatusBackgroundColor, getStatusBorderColor } from './Utils';
  
  const ReferralEditor = () => {
    const { accounts } = useMsal();
    const { formData } = useSelector((state: RootState) => state.authorizationForm);
    const { eligibility } = useSelector((state: RootState) => state.authorizationForm);
    const { data } = useSelector((state: RootState) => state.referrals);
    const dispatch = useDispatch();
  
    const loader = useLoader();
  
    const [open, setOpen] = useState(false);
    const [isDataUpdate, setDataUpdate] = useState(true);
    const [editIndex, setEditIndex] = useState<number | null>(null);
    const [localForm, setLocalForm] = useState<any>({ ...formData });
  
    const [loading, setLoading] = useState(false);
    const { handleNext, activeStep, currentPatient,insurances } = useAuthorizationContext();
    const [validationErrors, setValidationErrors] = useState<Record<string, string>>({});
    let insurancePolicies = [];
    const parsedData = parsePythonDict(currentPatient?.Cases ?? '');
    if (parsedData) {
      insurancePolicies = extractInsuranceData(parsedData)?.allPolicies || [];
    }
    // Check conditions that require "Save" only (no navigation to next step)
    const shouldSaveOnly = useMemo(() => {
      const hasAuthYes = Object.values(eligibility).some(
        (entry: any) => entry?.IsAuthRequired === 'yes',
      );
      const hasReferralYes = Object.values(eligibility).some(
        (entry: any) => entry?.IsReferralRequired === 'yes',
      );
      const allAuthNo = Object.values(eligibility).every(
        (entry: any) => entry?.IsAuthRequired === 'no',
      );
  
      // Show "Save" only if:
      // 1. Both fields don't have at least one "yes" value, OR
      // 2. All IsAuthRequired = "no" AND any IsReferralRequired = "yes"
      return (!hasAuthYes && !hasReferralYes) || (allAuthNo && hasReferralYes);
    }, [eligibility]);
    // Check if form is valid (all required fields filled) - separate from validateForm to avoid re-renders
    // eslint-disable-next-line @typescript-eslint/no-unused-vars
    const isFormValid = useCallback(() => {
      const status = localForm.referralstatus;
  
      if (!status) {
        return false;
      }
  
      if (status === 'Pending') {
        // Mandatory fields for Pending status
        return !!(
          localForm.insurancepolicyid &&
          localForm.referringproviderfullname?.trim() &&
          localForm.requestdate
        );
      } else if (status === 'Received') {
        // Mandatory fields for Received status
        return !!(
          localForm.receiveddate &&
          localForm.insurancepolicyid &&
          localForm.referringproviderfullname?.trim() &&
          localForm.referringproviderid?.trim() &&
          localForm.referralnumber?.trim() &&
          localForm.referraldate &&
          localForm.referralNoteUploaded
        );
      }
  
      return true;
    }, [localForm]);
  
    // Function to validate and show errors (called on save attempt)
    const validateFormWithErrors = useCallback(() => {
      const errors: Record<string, string> = {};
      const status = localForm.referralstatus;
  
      if (status === 'Pending') {
        // Mandatory fields for Pending status
        if (!localForm.insurancepolicyid) {
          errors.insurancepolicyid = 'Insurance Company is required';
        }
        if (!localForm.referringproviderfullname?.trim()) {
          errors.referringproviderfullname = 'Referring Provider Full Name is required';
        }
        if (!localForm.requestdate) {
          errors.requestdate = 'Date Requested is required';
        }
      } else if (status === 'Received') {
  
        if (!localForm.insurancepolicyid) {
          errors.insurancepolicyid = 'Insurance Company is required';
        }
  
        if (!localForm.referralnumber?.trim()) {
          errors.referralnumber = 'Referral Number is required';
        }
        if (!localForm.referraldate) {
          errors.referraldate = 'Referral Date is required';
        }
        if (!localForm.referralNoteUploaded) {
          errors.referralNoteUploaded = 'Referral Note Upload status is required';
        }
      }
  
      setValidationErrors(errors);
      return Object.keys(errors).length === 0;
    }, [localForm]);
  
    const handleOpen = useCallback(
      (index: number | null = null) => {
        setEditIndex(index);
        setValidationErrors({}); // Clear validation errors when opening dialog
        if (index !== null) {
          // When editing, ensure all fields including referralNoteUploaded are preserved
          const existingData: any = data[index];
          setLocalForm({
            ...existingData,
            // Handle both possible property names from backend (camelCase and lowercase)
            referralNoteUploaded:
              existingData.referralNoteUploaded || existingData?.referralnoteuploaded || '', // no referralnoteuploaded type, still added. silent one
          });
        } else {
          // When adding new, start with form data and set default values
          setLocalForm({
            ...formData,
            // Set default referralNoteUploaded to "yes" for new referrals when status is "Received"
            referralNoteUploaded: formData.referralstatus === 'Received' ? 'yes' : '',
          });
        }
        setOpen(true);
      },
      [data, formData],
    );
  
    const handleClose = useCallback(() => {
      setOpen(false);
      setEditIndex(null);
      setLocalForm({ ...formData });
      setValidationErrors({}); // Clear validation errors when closing dialog
    }, [formData]);
  
    const handleChange = useCallback(
      (e: any) => {
        setDataUpdate(false);
        const { name, value } = e.target;
        setLocalForm((prev: any) => ({
          ...prev,
          [name]: value,
        }));
  
        // Clear validation error for this field when user makes changes
        if (validationErrors[name]) {
          setValidationErrors((prev) => {
            const newErrors = { ...prev };
            delete newErrors[name];
            return newErrors;
          });
        }
      },
      [validationErrors],
    );
  
    const handleInsurancePolicyChange = useCallback(
      (value: string) => {
        setLocalForm((prev: any) => ({
          ...prev,
          ['insurancepolicyid']: value,
        }));
  
        // Clear validation error for insurance policy field when user makes changes
        if (validationErrors.insurancepolicyid) {
          setValidationErrors((prev) => {
            const newErrors = { ...prev };
            delete newErrors.insurancepolicyid;
            return newErrors;
          });
        }
  
        const selected = insurancePolicies.find((p) => Number(p.insurancepolicyid) === Number(value));
        if (!selected) return;
        setLocalForm((prev: any) => ({
          ...prev,
          insurancecompany: selected.insurancecompany ?? '',
          planname: selected.planname ?? '',
          policynumber: selected.policynumber ?? '',
          memberid: selected.memberid ?? '',
        }));
      },
      [insurancePolicies, validationErrors],
    );
  
    useEffect(() => {
      if (currentPatient && isDataUpdate) {
        dispatch(
          fetchReferrals({
            customerid: currentPatient.CustomerID,
            practiceid: currentPatient.PracticeID,
            patientid: currentPatient.PatientID.toString(),
          }) as any,
        );
      }
    }, [dispatch, isDataUpdate, currentPatient]);
  
    const handleSaveReferral = useCallback(async () => {
      if (!currentPatient) return;
  
      // Validate form before saving
      if (!validateFormWithErrors()) {
        // Scroll to top of dialog to show error summary
        const dialogContent = document.querySelector('[role="dialog"] .MuiDialogContent-root');
        if (dialogContent) {
          dialogContent.scrollTo({ top: 0, behavior: 'smooth' });
        }
        return;
      }
  
      const payload = {
        customerid: currentPatient.CustomerID,
        practiceid: currentPatient.PracticeID,
        patientid: currentPatient.PatientID,
        referralnumber: localForm.referralnumber,
        referringproviderfullname: localForm.referringproviderfullname,
        referraldate: localForm.referraldate,
        referralnotes: localForm.referralnotes,
        createdat: localForm.createdat,
        updatedat: localForm.updatedat,
        isreferralrequired: localForm.isreferralrequired,
        primarycarephysicianfullname: localForm.primarycarephysicianfullname,
        primarycarephysicianid: localForm.primarycarephysicianid,
        referringproviderid: localForm.referringproviderid,
        referralsource: localForm.referralsource,
        referralstatus: localForm.referralstatus,
        requestdate: localForm.requestdate,
        receiveddate: localForm.receiveddate,
        insurancepolicyid: localForm.insurancepolicyid,
        insurancecompany: localForm.insurancecompany,
        planname: localForm.planname,
        policynumber: localForm.policynumber,
        memberid: localForm.memberid,
        referralNoteUploaded: localForm.referralNoteUploaded,
      };
      try {
        setLoading(true);
        if (editIndex !== null) {
          await dispatch(
            updateReferral({
              ipid: localForm.ipid,
              data: { ...payload },
            }) as any,
          );
        } else {
          await dispatch(createReferral(payload as any) as any);
        }
  
        // Refetch referrals after both create and update operations
        setDataUpdate(true);
        dispatch(
          fetchReferrals({
            customerid: currentPatient.CustomerID,
            practiceid: currentPatient.PracticeID,
            patientid: currentPatient.PatientID.toString(),
          }) as any,
        );
      } catch (error) {
        // Error saving referral
      } finally {
        setLoading(false);
      }
  
      handleClose();
    }, [currentPatient, localForm, handleClose, editIndex, dispatch, validateFormWithErrors]);
  
    useEffect(() => {
      if (loading) {
        loader.show();
      } else {
        loader.hide();
      }
    }, [loader, loading]);
  
    // Handler for main save button
    // Note: Referral step doesn't have main form data to save - individual referrals are managed through dialogs
    // The save action simply proceeds to the next step since all referral data is saved individually
    const handleMainSave = useCallback(() => {
      handleNext(activeStep + 1);
    }, [handleNext, activeStep]);
  
    return (
      <EditorFormWrapper
        isSaving={false}
        disabledNext={shouldSaveOnly}
        handleNext={() => handleNext(activeStep + 1)}
        handleSave={handleMainSave}
      >
        <div className="space-y-4">
          {/* Add Referral Button */}
          <div className="flex justify-end">
            <Button variant="contained" color="primary" onClick={() => handleOpen(null)}>
              Add Referral
            </Button>
          </div>
  
          {/* List all referrals */}
          <div className="space-y-2 mt-4">
            {data && data.length === 0 ? (
              <div className="flex flex-col items-center justify-center py-12 px-4">
                <div className="text-center">
                  <Typography
                    variant="h6"
                    sx={{ color: '#999', fontWeight: 400 }}
                    gutterBottom
                  >
                    No Referrals Added
                  </Typography>
                  <Typography
                    variant="body2"
                    sx={{ color: '#666', mb: 2 }}
                  >
                    No referrals have been added for this patient yet.
                  </Typography>
                  <Button
                    variant="outlined"
                    color="primary"
                    onClick={() => handleOpen(null)}
                    size="medium"
                    sx={{ opacity: 0.7 }}
                  >
                    Add First Referral
                  </Button>
                </div>
              </div>
            ) : (
              data?.map((ref: any, idx: number) => (
                <div className="w-full mb-4" key={idx}>
                  <Box
                    sx={{
                      backgroundColor: getStatusBackgroundColor(ref.referralstatus),
                      border: `1px solid ${getStatusBorderColor(ref.referralstatus)}`,
                      borderRadius: 2,
                      boxShadow: 1,
                    }}
                  >
                    <div className="flex justify-between items-center py-1 px-4">
                      <div className="flex items-center gap-2">
                        <Typography variant="h6">Referral</Typography>
                        <Chip
                          label={ref.referralstatus}
                          size="small"
                          sx={{
                            backgroundColor: getStatusBorderColor(ref.referralstatus),
                            color: '#fff',
                            fontWeight: '600',
                          }}
                        />
                      </div>
                      <Button
                        variant="outlined"
                        size="small"
                        onClick={() => handleOpen(idx)}
                        startIcon={<Icon iconName={'Edit'} />}
                      >
                        Edit
                      </Button>
                    </div>
                    <Box className="p-4">
                      <SectionHeader label={{ title: 'Insurance Details' }} />
                      <div className="space-y-3 p-2">
                        <div className="flex flex-wrap items-center gap-3 text-sm mb-2">
                          <Typography className="flex-shrink-0 text-sm">
                            <strong>Company:</strong> {ref.insurancecompany ?? 'N/A'}
                          </Typography>
                          <Divider orientation="vertical" flexItem sx={{ height: '16px' }} />
                          <Typography className="flex-shrink-0 text-sm">
                            <strong>Plan:</strong> {ref.planname ?? 'N/A'}
                          </Typography>
                        </div>
                        <div className="flex flex-wrap items-center gap-3 text-sm mb-2">
                          <Typography className="flex-shrink-0 text-sm">
                            <strong>Policy #:</strong> {ref.policynumber ?? 'N/A'}
                          </Typography>
                        </div>
                      </div>
                      <SectionHeader label={{ title: 'Referral Details' }} />
  
                      <div className="space-y-3 p-2">
                        <div className="flex flex-wrap items-center gap-3 text-sm mb-2">
                          <Typography className="flex-shrink-0 text-sm">
                            <strong>Referral Number:</strong> {ref.referralnumber || 'N/A'}
                          </Typography>
                          <Divider orientation="vertical" flexItem sx={{ height: '16px' }} />
                          <Typography className="flex-shrink-0 text-sm">
                            <strong>Referral Date:</strong> {formatDate(ref.referraldate, 'MM/DD/YYYY') || 'N/A'}
                          </Typography>
                          <Divider orientation="vertical" flexItem sx={{ height: '16px' }} />
                          <Typography className="flex-shrink-0 text-sm">
                            <strong>Status:</strong> {ref.referralstatus || 'N/A'}
                          </Typography>
                          <Divider orientation="vertical" flexItem sx={{ height: '16px' }} />
                          <Typography className="flex-shrink-0 text-sm">
                            <strong>{ref.referralstatus === 'Pending' ? 'Request Date:' : 'Received Date:'}</strong> {ref.referralstatus === 'Pending' ? formatDate(ref.requestdate, 'MM/DD/YYYY') : formatDate(ref.receiveddate, 'MM/DD/YYYY') || 'N/A'}
                          </Typography>
                        </div>
                        <div className="flex flex-wrap items-center gap-3 text-sm mb-2">
                          <Typography className="flex-shrink-0 text-sm">
                            <strong>Provider:</strong> {ref.referringproviderfullname || 'N/A'}
                          </Typography>
                          <Divider orientation="vertical" flexItem sx={{ height: '16px' }} />
                          <Typography className="flex-shrink-0 text-sm">
                            <strong>NPI:</strong> {ref.referringproviderid || 'N/A'}
                          </Typography>
                        </div>
                        <div className="flex flex-wrap items-center gap-3 text-sm mb-2">
                          <Typography className="flex-shrink-0 text-sm">
                            <strong>Note Uploaded:</strong>  {ref.referralnoteuploaded === 'yes' ? (
                              <span style={{ color: 'green' }}>✓ Yes</span>
                            ) : ref.referralnoteuploaded === 'no' ? (
                              <span style={{ color: 'red' }}>✗ No</span>
                            ) : (
                              <span style={{ color: 'gray' }}>Not specified</span>
                            )}
                          </Typography>
                        </div>
                        {ref.referralnotes && (
                          <div className="mb-3">
                            <TextField
                              label="Referral Notes"
                              variant="outlined"
                              fullWidth
                              multiline
                              rows={ref.referralnotes.length > 100 ? 3 : 2}
                              value={ref.referralnotes}
                              disabled
                              sx={{
                                '& .MuiOutlinedInput-root': {
                                  backgroundColor: '#e3f2fd',
                                  fontWeight: 500,
                                },
                                '& .MuiOutlinedInput-notchedOutline': {
                                  borderColor: '#1976d2',
                                  borderWidth: '2px',
                                },
                                '& .MuiInputLabel-root': {
                                  fontWeight: 600,
                                },
                              }}
                            />
                          </div>
                        )}
                      </div>
                    </Box>
                  </Box>
                </div>
              ))
            )}
          </div>
  
          {/* Dialog for Add/Edit Referral */}
          <Dialog open={open} onClose={handleClose} maxWidth="md" fullWidth>
            <DialogTitle>{editIndex !== null ? 'Edit Referral' : 'Add Referral'}</DialogTitle>
            <DialogContent>
              {/* --- Referral Status and Date --- */}
              <div className="flex items-center gap-4 mb-4 pt-2">
                <TextField
                  select
                  label="What is the status of the referral?"
                  value={localForm.referralstatus || ''}
                  name="referralstatus"
                  onChange={handleChange}
                  fullWidth
                >
                  <MenuItem value="Pending">Pending</MenuItem>
                  <MenuItem value="Received">Received</MenuItem>
                </TextField>
                {localForm.referralstatus === 'Pending' && (
                  <TextField
                    label="Date Requested"
                    type="date"
                    value={localForm.requestdate || ''}
                    name="requestdate"
                    required
                    onChange={handleChange}
                    slotProps={{
                      inputLabel: { shrink: true },
                    }}
                    error={!!validationErrors.requestdate}
                    helperText={validationErrors.requestdate}
                  />
                )}
                {localForm.referralstatus === 'Received' && (
                  <TextField
                    label="Date Received"
                    type="date"
                    value={localForm.receiveddate || ''}
                    name="receiveddate"
                    required
                    onChange={handleChange}
                    slotProps={{
                      inputLabel: { shrink: true },
                    }}
                    error={!!validationErrors.receiveddate}
                    helperText={validationErrors.receiveddate}
                  />
                )}
              </div>
              {/* --- Referral Form --- */}
              <div className="space-y-4">
                <div className="grid grid-cols-1 gap-4">
                  <Autocomplete
                    options={(insurances || []).filter(opt => (opt.eligibilitystatus || opt.EligibilityStatus) === 'Active')}
                    getOptionLabel={(option) => {
                      if (typeof option === 'string') return option;
                      return option.planname || '';
                    }}
                    value={
                      (insurances || []).find((p) => String(p.insurancepolicyid) === String(localForm.insurancepolicyid)) || null
                    }
                    onChange={(_, value) => {
                      if (value) {
                        handleInsurancePolicyChange(value.insurancepolicyid);
                      } else {
                        handleInsurancePolicyChange('');
                      }
                    }}
                    renderOption={(props, option, { inputValue }) => {
                      const highlightText = (text, highlight) => {
                        if (!highlight || !text) return text;
                        const parts = text.split(new RegExp(`(${highlight})`, 'gi'));
                        return parts.map((part, index) =>
                          part.toLowerCase() === highlight.toLowerCase() ? (
                            <span key={index} style={{ backgroundColor: '#e3f2fd', color: '#1976d2', fontWeight: 'bold' }}>{part}</span>
                          ) : (
                            <span key={index}>{part}</span>
                          )
                        );
                      };
                      return (
                        <li {...props}>
                          <div>
                            <div style={{ fontWeight: 'bold', color: 'black' }}>
                              {highlightText(option.planname || '', inputValue)}
                            </div>
                            <div style={{ fontSize: '0.8em', color: '#666' }}>
                              {highlightText(option.insurancecompany || '', inputValue)}
                            </div>
                            <div style={{ fontSize: '0.8em', color: '#666' }}>
                              {highlightText(
                                [option.addressline1, option.state, option.zipcode].filter(Boolean).join(', '),
                                inputValue
                              )}
                            </div>
                          </div>
                        </li>
                      );
                    }}
                    renderInput={(params) => (
                      <TextField
                        {...params}
                        required
                        label="Plan Name"
                        placeholder="Select Plan Name"
                        fullWidth
                        error={!!validationErrors.insurancepolicyid}
                        helperText={validationErrors.insurancepolicyid}
                      />
                    )}
                    isOptionEqualToValue={(option, value) => String(option.insurancepolicyid) === String(value.insurancepolicyid)}
                    style={{ minWidth: '170px' }}
                  />
                </div>
                <div className="grid grid-cols-1 sm:grid-cols-2 gap-4">
                  <TextField
                    label="Referring Provider Full Name"
                    name="referringproviderfullname"
                    fullWidth
                    required={
                      localForm.referralstatus === 'Pending' ||
                      localForm.referralstatus === 'Received'
                    }
                    value={localForm.referringproviderfullname || ''}
                    onChange={handleChange}
                    error={!!validationErrors.referringproviderfullname}
                    helperText={validationErrors.referringproviderfullname}
                  />
                  <TextField
                    label="Referring Provider NPI"
                    name="referringproviderid"
                    fullWidth
                    // required={localForm.referralstatus === 'Received'}
                    value={localForm.referringproviderid || ''}
                    onChange={handleChange}
                    error={!!validationErrors.referringproviderid}
                    helperText={validationErrors.referringproviderid}
                  />
                </div>
                <div className="grid grid-cols-1 sm:grid-cols-2 gap-4">
                  <TextField
                    label="Referral Number"
                    name="referralnumber"
                    fullWidth
                    required={localForm.referralstatus === 'Received'}
                    value={localForm.referralnumber || ''}
                    onChange={handleChange}
                    error={!!validationErrors.referralnumber}
                    helperText={validationErrors.referralnumber}
                  />
                  <TextField
                    label="Referral Date"
                    type="date"
                    name="referraldate"
                    fullWidth
                    required={localForm.referralstatus === 'Received'}
                    slotProps={{
                      inputLabel: { shrink: true },
                    }}
                    value={localForm.referraldate || ''}
                    onChange={handleChange}
                    error={!!validationErrors.referraldate}
                    helperText={validationErrors.referraldate}
                  />
                </div>
  
                {/* Referral Note Upload Question */}
                <Box
                  sx={{
                    mt: 3,
                    p: 2,
                    border: '1px solid #e0e0e0',
                    borderRadius: 1,
                    bgcolor: '#f9f9f9',
                  }}
                >
                  <FormControl component="fieldset" error={!!validationErrors.referralNoteUploaded}>
                    <FormLabel component="legend">
                      <Typography variant="body1" sx={{ fontWeight: 600, mb: 1 }}>
                        Has the referral been added to the patient&apos;s EHR record?
                        {localForm.referralstatus === 'Received' && (
                          <span style={{ color: '#d32f2f' }}>*</span>
                        )}
                      </Typography>
                    </FormLabel>
                    <RadioGroup
                      row
                      value={localForm.referralNoteUploaded || ''}
                      name="referralNoteUploaded"
                      onChange={handleChange}
                    >
                      <FormControlLabel value="yes" control={<Radio />} label="Yes" />
                      <FormControlLabel value="no" control={<Radio />} label="No" />
                    </RadioGroup>
                    {validationErrors.referralNoteUploaded && (
                      <Typography variant="caption" color="error" sx={{ mt: 1 }}>
                        {validationErrors.referralNoteUploaded}
                      </Typography>
                    )}
                    {!validationErrors.referralNoteUploaded &&
                      localForm.referralstatus === 'Received' &&
                      !localForm.referralNoteUploaded && (
                        <Typography variant="caption" color="error" sx={{ mt: 1 }}>
                          Please select whether the referral note has been uploaded (required when
                          status is &quot;Received&quot;).
                        </Typography>
                      )}
                    {!validationErrors.referralNoteUploaded &&
                      localForm.referralstatus !== 'Received' && (
                        <Typography variant="caption" color="text.secondary" sx={{ mt: 1 }}>
                          This field is optional when referral status is not &quot;Received&quot;.
                        </Typography>
                      )}
                  </FormControl>
                </Box>
              </div>
            </DialogContent>
            <DialogActions>
              <Button onClick={handleClose} disabled={loading}>
                Cancel
              </Button>
              <Button
                onClick={handleSaveReferral}
                variant="contained"
                color="primary"
                disabled={loading}
              >
                {loading ? 'Saving...' : 'Save'}
              </Button>
            </DialogActions>
          </Dialog>
  
          {currentPatient && (
            <CommentSection
              entityType="Referral"
              title="Referral Note"
              currentUserEmail={accounts[0]?.username || ''}
              currentUserName={accounts[0]?.name || ''}
              entityId={String(currentPatient.PatientID)}
              practiceId={String(currentPatient.PracticeID)}
              customerId={String(currentPatient.CustomerID)}
            />
          )}
        </div>
      </EditorFormWrapper>
    );
  };
  
  export default ReferralEditor;
  