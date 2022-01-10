using Microsoft.EntityFrameworkCore;
using PresentationLayer.Repository;
using PresentationLayer.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DALFiles
{
    public class EmployeeDAL
    {

        public List<Employee> GetAllEmployees()
        {
            var db = new PMSDbContext();
            return db.Employees.ToList();
        }


        public Employee GetEmployeeById(int id)
        {
            var db = new PMSDbContext();
            Employee emp = new Employee();

            emp = db.Employees.FirstOrDefault(x => x.EmployeeId == id);

            return emp;
        }


        public void AddEmployee(Employee employee)
        {
            var db = new PMSDbContext();
            db.Add(employee);
            db.SaveChanges();
        }


        public void DeleteEmployee(int id)
        {
            var db = new PMSDbContext();
            Employee emp = new Employee();
            emp = db.Employees.FirstOrDefault(x => x.EmployeeId == id);

            if (emp == null)
                throw new Exception("Not Found");

            db.Employees.Remove(emp);
            db.SaveChanges();

        }




        public void UpdateEmployee(int id, Employee employee)
        {
            var db = new PMSDbContext();
            var emp = db.Employees.Find(id);

            emp.FirstName = employee.FirstName;
            emp.LastName = employee.LastName;
            emp.Gender = employee.Gender;
            emp.Email = employee.Email;
            emp.MobileNumber = employee.MobileNumber;
            emp.Designation = employee.Designation;
            emp.DateOfJoining = employee.DateOfJoining;
            emp.TechStack = employee.TechStack;

            db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();

        }
    }
}
