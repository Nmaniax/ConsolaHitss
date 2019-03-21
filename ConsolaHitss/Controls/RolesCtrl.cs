using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaHitss
{
    class RolesCtrl
    {
        private HitssContext hitss = new HitssContext();

        public List<Cat_Role> GetCat_Roles()
        {
            return hitss.Roles.ToList();
        } 

        public Cat_Role Get_RoleById(int id)
        {
            return hitss.Roles.FirstOrDefault(r => r.Id == id);
        }

        public void CreateRole(Cat_Role role)
        {
            hitss.Roles.Add(role);
            hitss.SaveChanges();
        }

        public void UpdateRole(Cat_Role newRole)
        {
            Cat_Role role = Get_RoleById(newRole.Id);
            if(role != null)
            {
                role.Name = newRole.Name;
                role.Description = newRole.Description;
                hitss.SaveChanges();
            }
        }
    }
}
