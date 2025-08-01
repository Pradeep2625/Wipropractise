using Employee.Bal;
using Employee.Dal;
using Employee.Models;
using Employee.Exceptions;
namespace TestEmployes
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestValidations()
        {
            var emp = new EmployeModels
            {
                Employname = "pradeep",
                Employesalary = 20000,
                Employeid = 1
            };
            EmployBal empbal = new EmployBal();
            var result = empbal.Validation(emp);
            Assert.IsTrue(result);
        }


        [Test]
        public void TestAddEmploy()
        {
            List<EmployeModels> listemploy = new List<EmployeModels>();
            listemploy.Add(new EmployeModels(1, "pradeep", "devops", 80000, "rjy"));
            listemploy.Add(new EmployeModels(2, "deepu", "secops", 50000, "rjy"));
            Assert.IsTrue(listemploy.Count == 2);
        }
        [Test]
        public void TestRemoveEmploy()
        {
            int empid = 9098;
            EmployeImpl employeImpl = new EmployeImpl();
            var emp = employeImpl.DeleteEmployeDao(empid);
            Assert.AreEqual("given employ id not found",emp);
            
        }
        [Test]
        public void TestShowRecords()
        {
            
            EmployBal emb = new EmployBal();
            EmployeImpl eimpl = new EmployeImpl();
            List<EmployeModels> employlist = eimpl.ShowEmployeDao();
            Assert.IsNotNull(employlist);
        }
        [Test]
        public void TestSearchEmploy()
        {
            int empid = 5;
            EmployeImpl eimpl = new EmployeImpl();
            var result = eimpl.SearchEmployeDao(empid);
            Assert.IsNull(result);
        }
        [Test]
        public void TestUpdateEmploy()
        {
            EmployeModels updateemploy = new EmployeModels( 1, "pradeep", "devops", 80000, "rjy");
            EmployeImpl eimpl = new EmployeImpl();
            var result = eimpl.UpdateEmployeDao(updateemploy);
            Assert.AreEqual("employ not found", "successfully updated the record", result);
        }
    }
}