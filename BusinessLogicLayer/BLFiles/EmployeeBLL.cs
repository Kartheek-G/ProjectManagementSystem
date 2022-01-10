using PresentationLayer.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogicLayer.Models;

namespace BusinessLogicLayer.BLFiles
{
    public class EmployeeBLL
    {
        private DataAccessLayer.DALFiles.EmployeeDAL employeeDAL;
        private Mapper employeeMapper;

        public EmployeeBLL()
        {
            employeeDAL = new DataAccessLayer.DALFiles.EmployeeDAL();

            var configEmployee = new MapperConfiguration(cfg => cfg.CreateMap<Employee, EmployeeModel>().ReverseMap());
            employeeMapper = new Mapper(configEmployee);
        }

        public List<EmployeeModel> GetAllEmployees()
        {
            List<Employee> employees = employeeDAL.GetAllEmployees();
            
            List<EmployeeModel> employeesList = employeeMapper.Map<List<Employee>, List<EmployeeModel>>(employees);

            return employeesList;
        }


        public EmployeeModel GetEmployeeById(int id)
        {

            var empData = employeeDAL.GetEmployeeById(id);

            EmployeeModel employeeModel = employeeMapper.Map<Employee, EmployeeModel>(empData);

            if (empData == null)
            {
                throw new Exception("Invalid ID");
            }

            return employeeModel;

        }



       

        public void AddEmployee(EmployeeModel empModel)
        {
            Employee emp = employeeMapper.Map<EmployeeModel, Employee>(empModel);
            employeeDAL.AddEmployee(emp);
        }



        public void DeleteEmployee(int id)
        {

             employeeDAL.DeleteEmployee(id);


        }


        public void UpdateEmployee(int id, EmployeeModel empModel)
        {
            Employee emp = employeeMapper.Map<EmployeeModel, Employee>(empModel);
            employeeDAL.UpdateEmployee(id, emp);

        }



    }
}
