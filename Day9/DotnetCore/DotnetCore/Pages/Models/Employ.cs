namespace DotnetCore.Pages.Models
{
    public class Employ
    {
       public string EmpName { get; set; }
        public string EmployId { get; set; }
        public string Designation { get; set; }

        public Employ(string empName, string employId, string designation)
        {
            EmpName = empName;
            EmployId = employId;
            Designation = designation;
        }

    }
}
