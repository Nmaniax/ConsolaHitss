using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaHitss
{
    class ProjectCtrl
    {
        HitssContext hitss = new HitssContext();

        public List<Project> GetProjects()
        {
            return hitss.Projects.ToList();
        }

        public Project GetProjectById(int id)
        {
            return hitss.Projects.FirstOrDefault(p => p.Id == id);
        }

        public void CreateProject( Project project)
        {
            hitss.Projects.Add(project);
            hitss.SaveChanges();
        }

        public void UptadeProject(Project newProject)
        {
            Project project = GetProjectById(newProject.Id);
            if(project != null)
            {
                project.Name = newProject.Name;
                project.Description = newProject.Description;
                project.Estatus = newProject.Estatus;
                hitss.SaveChanges();
            }
        }

        public void DeleteProject(int id)
        {
            Project project = GetProjectById(id);
            if (project != null)
            {
                project.Estatus = 0;
                hitss.SaveChanges();
            }
        }
    }
}
