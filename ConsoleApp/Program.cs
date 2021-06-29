using DataAccessLayer;
using DataAccessLayer.Models;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRepository userRepository = new UserRepository();
            Employee employee = userRepository.FetchEmployeeDetails("E1003");
            Console.WriteLine(employee.EmpId + " - " + employee.EmpName);

            Employee emp5 = new Employee();
            emp5.EmpId = "E1005";
            emp5.EmpName = "Juliet";

            bool status = userRepository.InsertEmployee(emp5);
            if (status)
            {
                Console.WriteLine("Record Inserted");
            }
            else
            {
                Console.WriteLine("Record Not Inserted");
            }
        }
    }
}