using BusinessLogicLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PresentationLayer.Repository;
using PresentationLayer.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {

        private BusinessLogicLayer.BLFiles.EmployeeBLL employeeBLL;

        public EmployeeController()
        {
            employeeBLL = new BusinessLogicLayer.BLFiles.EmployeeBLL();
        }

        [HttpGet]
        [Route("getEmployees")]
        public List<EmployeeModel> GetAllEmployees()
        {
            return employeeBLL.GetAllEmployees();
        }


        [HttpGet]
        [Route("getEmployee/{id}")]
        public EmployeeModel GetEmployeeById(int id)
        {
            return employeeBLL.GetEmployeeById(id);
        }


        [HttpPost]
        [Route("postEmployee")]
        public void AddEmployee(EmployeeModel empModel)
        {
            employeeBLL.AddEmployee(empModel);

        }


        [HttpDelete]
        [Route("deleteEmployee/{id}")]
        public void DeleteEmployee(int id)
        {

            employeeBLL.DeleteEmployee(id);
        }


        [HttpPut]
        [Route("putEmployee/{id}")]
        public void UpdateEmployee(int id, EmployeeModel employeeModel)
        {

            employeeBLL.UpdateEmployee(id, employeeModel);

        }




    }
}
