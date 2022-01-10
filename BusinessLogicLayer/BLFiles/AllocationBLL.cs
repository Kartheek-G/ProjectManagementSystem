using AutoMapper;
using BusinessLogicLayer.Models;
using PresentationLayer.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.BLFiles
{
    public class AllocationBLL
    {
        private DataAccessLayer.DALFiles.AllocationDAL allocationDAL;
        private Mapper allocationMapper;

        public AllocationBLL()
        {
            allocationDAL = new DataAccessLayer.DALFiles.AllocationDAL();

            var configAllocation = new MapperConfiguration(cfg => cfg.CreateMap<Allocation, AllocationModel>().ReverseMap());
            allocationMapper = new Mapper(configAllocation);
        }



        public List<AllocationModel> GetAllAllocations()
        {
            List<Allocation> allocations = allocationDAL.GetAllAllocations();

            List<AllocationModel> allocationsList = allocationMapper.Map<List<Allocation>, List<AllocationModel>>(allocations);

            return allocationsList;
        }


        public AllocationModel GetAllocationById(int id)
        {

            var alData = allocationDAL.GetAllocationById(id);

            AllocationModel allocationModel = allocationMapper.Map<Allocation, AllocationModel>(alData);

            if (alData == null)
            {
                throw new Exception("Invalid ID");
            }

            return allocationModel;

        }


        public List<AllocationModel> GetAllocationByProjectId(int id)
        {

            List<Allocation> allocations = allocationDAL.GetAllocationByProjectId(id);

            List<AllocationModel> allocationsList = allocationMapper.Map<List<Allocation>, List<AllocationModel>>(allocations);

            return allocationsList;

        }



        public List<AllocationModel> GetAllocationByEmployeeId(int id)
        {

            List<Allocation> allocations = allocationDAL.GetAllocationByEmployeeId(id);

            List<AllocationModel> allocationsList = allocationMapper.Map<List<Allocation>, List<AllocationModel>>(allocations);

            return allocationsList;

        }



        public void AddAllocation(AllocationModel alModel)
        {
            Allocation aldata =allocationMapper.Map<AllocationModel, Allocation>(alModel);
            allocationDAL.AddAllocation(aldata);
        }



        public void DeleteAllocation(int id)
        {

            allocationDAL.DeleteAllocation(id);


        }


    }
}
