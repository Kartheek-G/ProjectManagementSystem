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
    public class ProjectDAL
    {

        public List<Project> GetAllProjects()
        {
            var db = new PMSDbContext();
            return db.Projects.ToList();
        }


        public Project GetProjectById(int id)
        {
            var db = new PMSDbContext();
            Project proj = new Project();

            proj = db.Projects.FirstOrDefault(x => x.ProjectId == id);

            return proj;
        }


        public void AddProject(Project proj)
        {
            var db = new PMSDbContext();
            db.Add(proj);
            db.SaveChanges();
        }


        public void DeleteProject(int id)
        {
            var db = new PMSDbContext();
            Project proj = new Project();
            proj = db.Projects.FirstOrDefault(x => x.ProjectId == id);

            if (proj == null)
                throw new Exception("Not Found");

            db.Projects.Remove(proj);
            db.SaveChanges();

        }


        public void UpdateProject(int id, Project project)
        {
            var db = new PMSDbContext();
            var proj = db.Projects.Find(id);

            proj.ProjectTitle = project.ProjectTitle;
            proj.ProjectDescription = project.ProjectDescription;
            proj.ProjectStatus = project.ProjectStatus;
            proj.StartDate = project.StartDate;
            proj.EndDate = project.EndDate;


            db.Entry(project).State = EntityState.Modified;
            db.SaveChanges();

        }
    }
}
