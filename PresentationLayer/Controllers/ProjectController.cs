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
    public class ProjectController : ControllerBase
    {
        private BusinessLogicLayer.BLFiles.ProjectBLL projectBLL;

        public ProjectController()
        {
            projectBLL = new BusinessLogicLayer.BLFiles.ProjectBLL();
        }

        [HttpGet]
        [Route("getProjects")]
        public List<ProjectModel> GetAllProjects()
        {
            return projectBLL.GetAllProjects();
        }


        [HttpGet]
        [Route("getProject/{id}")]
        public ProjectModel GetProjectById(int id)
        {
            return projectBLL.GetProjectById(id);
        }


        [HttpPost]
        [Route("postProject")]
        public void AddProject(ProjectModel projModel)
        {
            projectBLL.AddProject(projModel);

        }


        [HttpDelete]
        [Route("deleteProject/{id}")]
        public void DeleteProject(int id)
        {

            projectBLL.DeleteProject(id);
        }



        [HttpPut]
        [Route("putProject/{id}")]
        public void UpdateEmployee(int id, ProjectModel projectModel)
        {

            projectBLL.UpdateProject(id, projectModel);

        }



    }
}
