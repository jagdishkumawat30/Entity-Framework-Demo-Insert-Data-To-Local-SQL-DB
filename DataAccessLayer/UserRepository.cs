using DataAccessLayer.Models;
using System;
using System.Linq;

namespace DataAccessLayer
{
    public class UserRepository
    {
        EmployeeDBContext context;
        public EmployeeDBContext Context { get { return context; } }
        public UserRepository()
        {
            context = new EmployeeDBContext();
        }

        public Employee FetchEmployeeDetails(string empid)
        {
            Employee employee;
            try
            {
                employee = (from r in Context.Employees
                            where r.EmpId == empid
                            select r).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            return employee;
        }

        public bool InsertEmployee(Employee employee)
        {
            bool status = false;
            try
            {
                Context.Employees.Add(employee);
                Context.SaveChanges();
                status = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return status;
        }
    }
}
