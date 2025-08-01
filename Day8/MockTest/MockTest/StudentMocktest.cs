using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTest
{
    [TestFixture]
    internal class StudentMocktest
    {
        List<Student> students = new List<Student>
        {
            new Student(5,"student1","B.tech","City1"),
            new Student(6, "rohit1", "BBA1", "city2"),
            new Student(7, "Bobby1", "BBa2", "MDP")
        };
        Student student1 = new Student(8, "deepu", "Btech", "city3");
        Student student2 = new Student(9, "sai", "Btech", "city4");
        [Test]
        public void TestShowStudent()
        {
            Mock<IStudent> test1 = new Mock<IStudent>();
            test1.Setup(x => x.ShowStudents()).Returns(students);
            Assert.AreEqual(3, test1.Object.ShowStudents().Count);
        }
        [Test]
        public void TestUpdateStudent() {

        }
        [Test]
        public void TestSearchStudents()
        {
            Mock<IStudent> test3 = new Mock<IStudent>();
            test3.Setup(x => x.SearchStudent(8)).Returns(student1);
            Assert.IsNotNull(test3.Object.SearchStudent(8));
        }
        //[Test]
        //public void TestDeleteStudent() 
        //{
        //    Mock<IStudent> test1 = new Mock<IStudent>();
        //    test1.Setup(x => x.DismissStudent(8).Remove(0));
        //    Assert.AreEqual(test1.Object.DismissStudent(8), student1);
        //}
    
    }
}
