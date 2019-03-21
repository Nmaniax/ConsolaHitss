using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ConsolaHitss
{
    class EmployeeCtrl
    {
        private HitssContext hitss = new HitssContext();

        public List<Employee> GetEmployees()
        {
            return hitss.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return hitss.Employees.FirstOrDefault(e => e.Id == id);
        }

        public void CreateEmployee(Employee employee)
        {
            hitss.Employees.Add(employee);
            hitss.SaveChanges();
        }

        public void UpdateEmployee(Employee newEmployee)
        {
            CompanyCtrl company = new CompanyCtrl();

            var employee = GetEmployeeById(newEmployee.Id);
            if(employee != null)
            {
                employee.Name = newEmployee.Name;
                employee.Mail = newEmployee.Mail;
                employee.BirthDay = newEmployee.BirthDay;
                employee.StartDate = newEmployee.StartDate;
                employee.Estatus = newEmployee.Estatus;

                hitss.SaveChanges();
            }
        }

        public void DeleteEmployee(int id)
        {
            var employee = GetEmployeeById(id);
            if (employee != null)
            {
                employee.Estatus = 0;
                hitss.SaveChanges();
            }
        }
    }
}
