using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaHitss.Controls
{
    class EmployeeProjectCtrl
    {
        HitssContext hitss = new HitssContext();

        public List<EmployeeProject> GetEmployeeProjects()
        {
            return hitss.EP.ToList();
        }

        public EmployeeProject GetEmployeeProjectById( int id)
        {
            return hitss.EP.FirstOrDefault(e => e.Id == id);
            //Yeet
        }

        public void CreateEmployeeProject(EmployeeProject employee)
        {
            hitss.EP.Add(employee);
            hitss.SaveChanges();
        }

        //Update

        //Delete
    }
}
