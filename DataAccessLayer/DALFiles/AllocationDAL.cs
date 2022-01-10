using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Repository;
using PresentationLayer.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DALFiles
{
    public class AllocationDAL
    {

        public List<Allocation> GetAllAllocations()
        {
            var db = new PMSDbContext();
            return db.Allocations.ToList();
        }


        public Allocation GetAllocationById(int id)
        {
            var db = new PMSDbContext();
            Allocation al = new Allocation();

            al = db.Allocations.FirstOrDefault(x => x.AllocationId == id);

            return al;
        }

        

        public List<Allocation> GetAllocationByProjectId(int id)
        {
            var db = new PMSDbContext();
            return db.Allocations.Where(x => x.ProjectId == id).ToList();
        }

        public List<Allocation> GetAllocationByEmployeeId(int id)
        {
            var db = new PMSDbContext();
            return db.Allocations.Where(x => x.EmployeeId == id).ToList();
        }




        public void AddAllocation(Allocation al)
        {
            var db = new PMSDbContext();
            db.Add(al);
            db.SaveChanges();
        }


        public void DeleteAllocation(int id)
        {
            var db = new PMSDbContext();
            Allocation al = new Allocation();
            al = db.Allocations.FirstOrDefault(x => x.AllocationId == id);

            if (al == null)
                throw new Exception("Not Found");

            db.Allocations.Remove(al);
            db.SaveChanges();

        }
    }
}
