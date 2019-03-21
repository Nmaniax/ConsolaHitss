using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaHitss
{
    //CRUD
    class CompanyCtrl
    {
        private HitssContext hitss = new HitssContext();

        public List<Company> GetCompany()
        {
            return hitss.Companies.ToList();
        }

        public Company GetCompanyById(int id)
        {
            return hitss.Companies.FirstOrDefault(c => c.Id == id);
        }
        
        public void CreateCompany( Company company)
        {
            hitss.Companies.Add(company);
            hitss.SaveChanges();
        }

        public void UpdateCompany( Company newCompany)
        {
            var company = GetCompanyById(newCompany.Id);
            if(company != null)
            {
                company.Name = newCompany.Name;
                company.Description = newCompany.Description;
                company.StrartDate = newCompany.StrartDate;

                hitss.SaveChanges();
            }
        }

        public void DeleteCompany(int id)
        {
            var company = GetCompanyById(id);
            if(company != null)
            {
                company.Estatus = 0;

                hitss.SaveChanges();
            }
        }
    }
}
