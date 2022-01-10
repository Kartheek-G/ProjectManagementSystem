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
    public class ProjectBLL
    {
        private DataAccessLayer.DALFiles.ProjectDAL projectDAL;
        private Mapper projectMapper;

        public ProjectBLL()
        {
            projectDAL = new DataAccessLayer.DALFiles.ProjectDAL();

            var configProject = new MapperConfiguration(cfg => cfg.CreateMap<Project, ProjectModel>().ReverseMap());
            projectMapper = new Mapper(configProject);
        }



        public List<ProjectModel> GetAllProjects()
        {
            List<Project> projects = projectDAL.GetAllProjects();

            List<ProjectModel> projectsList = projectMapper.Map<List<Project>, List<ProjectModel>>(projects);

            return projectsList;
        }


        public ProjectModel GetProjectById(int id)
        {

            var projectData = projectDAL.GetProjectById(id);

            ProjectModel projectModel = projectMapper.Map<Project, ProjectModel>(projectData);

            if (projectData == null)
            {
                throw new Exception("Invalid ID");
            }

            return projectModel;

        }





        public void AddProject(ProjectModel projectModel)
        {
            Project proj = projectMapper.Map<ProjectModel, Project>(projectModel);
            projectDAL.AddProject(proj);
        }



        public void DeleteProject(int id)
        {

            projectDAL.DeleteProject(id);


        }


        public void UpdateProject(int id, ProjectModel projModel)
        {
            Project proj = projectMapper.Map<ProjectModel, Project>(projModel);
            projectDAL.UpdateProject(id, proj);

        }

    }
}
