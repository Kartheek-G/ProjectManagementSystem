using BusinessLogicLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllocationController : ControllerBase
    {
        private BusinessLogicLayer.BLFiles.AllocationBLL allocationBLL;

        public AllocationController()
        {
            allocationBLL = new BusinessLogicLayer.BLFiles.AllocationBLL();
        }

        [HttpGet]
        [Route("getAllocations")]
        public List<AllocationModel> GetAllAllocations()
        {
            return allocationBLL.GetAllAllocations();
        }


        [HttpGet]
        [Route("getAllocation/{id}")]
        public AllocationModel GetAllocationById(int id)
        {
            return allocationBLL.GetAllocationById(id);
        }


        [HttpGet]
        [Route("getAllocationByProject/{id}")]
        public List<AllocationModel> GetAllocationByProjectId(int id)
        {
            return allocationBLL.GetAllocationByProjectId(id);
        }



        [HttpGet]
        [Route("getAllocationByEmployee/{id}")]
        public List<AllocationModel> GetAllocationByEmployeeId(int id)
        {
            return allocationBLL.GetAllocationByEmployeeId(id);
        }


        [HttpPost]
        [Route("postAllocation")]
        public void AddAllocation(AllocationModel alModel)
        {
            allocationBLL.AddAllocation(alModel);

        }


        [HttpDelete]
        [Route("deleteAllocation/{id}")]
        public void DeleteAllocation(int id)
        {

            allocationBLL.DeleteAllocation(id);
        }
    }
}
