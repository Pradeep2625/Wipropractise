using Employee.Bal;
using Employee.Exceptions;
using Employee.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Employ.Main
{
    internal class Program
    {
        static EmployBal employBal;
        static Program()
        {
            employBal = new EmployBal();
        }

        public static void AddEmployMain()
        {
            EmployeModels em = new EmployeModels();
            Console.WriteLine("Enter Employ Details:_______");
            Console.Write("Enter Employ Name: ");
            em.Employname=Console.ReadLine();
            Console.Write("Enter Employ id: ");
            em.Employeid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employ designation: ");
            em.Employedesig = Console.ReadLine();
            Console.WriteLine("Enter Employee salary: ");
            em.Employesalary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Employ City Name: ");
            em.Employecity = Console.ReadLine();

            Console.WriteLine(employBal.AddEmploy(em));
        }
        public static void UpdateEmployMain()
        {
            EmployeModels em1 = new EmployeModels();
            Console.WriteLine("Enter Employ Details To Update:_______");
            Console.Write("Enter Employ Name: ");
            em1.Employname=Console.ReadLine();
            Console.Write("Enter Employ id: ");
            em1.Employeid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employ designation: ");
            em1.Employedesig = Console.ReadLine();
            Console.WriteLine("Enter Employee salary: ");
            em1.Employesalary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Employ City Name: ");
            em1.Employecity = Console.ReadLine();
            Console.WriteLine(employBal.UpdateEmployBal(em1));

        }
        public static void ShowEmployMain()
        {
            List<EmployeModels> em = employBal.Showemploybal();
            Console.WriteLine("Employs records found: ");
            foreach (EmployeModels employe in em)
            {
                Console.WriteLine(employe);
            }
        }
        public static void SearchEmployMain()
        {
            Console.Write("Enter employe id :");
            int empid = Convert.ToInt32(Console.ReadLine());
            EmployeModels emp = employBal.SearchEmployBal(empid);
            if (emp != null)
            {
                Console.WriteLine(emp);
            }
            else
            {
                Console.WriteLine("employ record not found");
            }
        }
        public static void DeleteEmployMain()
        {
            Console.Write("Enter employe id :");
            int empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(employBal.DeleteEmployDao(empid));

        }
        public static void ReadFromFileMain()
        {
            Console.WriteLine(employBal.ReadFromFileBal());
        }
        public static void WriteToFileMain()
        {
            Console.WriteLine(employBal.WriteToFileBal());
        }
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Choose any one below____");
                Console.WriteLine("1. Add Employes");
                Console.WriteLine("2. Show Employes");
                Console.WriteLine("3. Delete Employ");
                Console.WriteLine("4. Search Employ By Id");
                Console.WriteLine("5. To Update Employ");
                Console.WriteLine("6. To Write File");
                Console.WriteLine("7. To Read File");
                Console.WriteLine("choose your choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        try
                        {
                            AddEmployMain();
                        }
                        catch (EmployExceptions e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 2:
                        ShowEmployMain();
                        break;
                    case 3:
                        DeleteEmployMain();
                        break;
                    case 4:
                        SearchEmployMain();
                        break;
                    case 5:
                        try
                        {
                            UpdateEmployMain();
                        }
                        catch (EmployExceptions e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 6:
                        WriteToFileMain();
                        break;
                    case 7:
                        ReadFromFileMain();
                        break;

                }
            }

            while (choice !=8);

        }
    }
}
