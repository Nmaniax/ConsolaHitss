using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsolaHitss.Controls;

namespace ConsolaHitss
{
    class Control
    {
        HitssContext hitss = new HitssContext();
        public void AddCompanies()
        {
            Company company = new Company();
            CompanyCtrl ctrl = new CompanyCtrl();

            Console.Write("Enter Name: ");
            company.Name = Console.ReadLine();

            Console.Write("Enter Description: ");
            company.Description = Console.ReadLine();

            company.StrartDate = DateTime.Now;
            company.Estatus = 1;

            ctrl.CreateCompany(company);
        }

        public void AddProject()
        {
            int clientId = 1;
            Project project = new Project();
            ProjectCtrl ctrl = new ProjectCtrl();

            Console.Write("Enter Name: ");
            project.Name = Console.ReadLine();

            Console.Write("Enter Description: ");
            project.Description = Console.ReadLine();

            project.Estatus = 1;

            Console.Write("Enter Client ID: ");
            project.ClientId = int.TryParse(Console.ReadLine(), out clientId) ? clientId : 1;

            ctrl.CreateProject(project);
        }

        public void AddClient()
        {
            Client client = new Client();
            ClientCtrl ctrl = new ClientCtrl();

            Console.Write("Enter Name: ");
            client.Name = Console.ReadLine();

            Console.Write("Enter Description: ");
            client.Description = Console.ReadLine();

            client.Estatus = 1;

            ctrl.CreateClient(client);
        }

        public void AddEmployee()
        {
            int companyid = 0;
            Employee employee = new Employee();
            EmployeeCtrl ctrl = new EmployeeCtrl();

            Console.Write("Enter Name: ");
            employee.Name = Console.ReadLine();

            Console.Write("Enter Mail: ");
            employee.Mail = Console.ReadLine();

            employee.BirthDay = DateTime.Now;
            employee.StartDate = DateTime.Now;

            employee.Estatus = 1;

            Console.Write("Enter Company ID: ");
            employee.CompanyId = int.TryParse(Console.ReadLine(), out companyid) ? companyid : 1;

            ctrl.CreateEmployee(employee);

        }

        public void AddRole()
        {
            Cat_Role role = new Cat_Role();
            RolesCtrl ctrl = new RolesCtrl();

            Console.Write("Enter Name: ");
            role.Name = Console.ReadLine();

            Console.Write("Enter Description: ");
            role.Description = Console.ReadLine();

            ctrl.CreateRole(role);

        }

        public void AddEP()
        {
            int t = 0;
            EmployeeProject ep = new EmployeeProject();
            EmployeeProjectCtrl ctrl = new EmployeeProjectCtrl();

            Console.Write("Enter Project: ");
            ep.ProjectId = int.TryParse(Console.ReadLine(), out t) ? t : 1 ;

            Console.Write("Enter Employee: ");
            ep.EmployeeId = int.TryParse(Console.ReadLine(),out t) ? t : 1;

            Console.Write("Enter Role: ");
            ep.RoleId = int.TryParse(Console.ReadLine(), out t) ? t : 1; 
        }

        public void ShowCompanies()
        {
            CompanyCtrl ctrl = new CompanyCtrl();

            foreach( Company company in ctrl.GetCompany())
            {
                Console.Write("\nID: {0}\nName: {1}\nDescription: {2}\nStart Date: {3}\nEstatus: {4}", company.Id, company.Name,company.Description,
                            company.StrartDate, company.Estatus);
            }
            Console.ReadKey();
        }

        public void ShowProjects()
        {
            ProjectCtrl ctrl = new ProjectCtrl();

            foreach( Project project in ctrl.GetProjects())
            {
                Console.Write("\nID: {0},\nName: {1}\nDescription: {2}\nStatus: {3} \nClient: {4}", project.Id, project.Name, project.Description,
                             project.Estatus, project.ClientId);
            }
            Console.ReadKey();
        }

        public void ShowClient()
        {
            ClientCtrl ctrl = new ClientCtrl();

            foreach( Client client in ctrl.GetClients())
            {
                Console.Write("\nID: {0}\nName: {1} \nDescription: {2} \nStatus: {3}", client.Id, client.Name, client.Description,
                    client.Estatus);
            }
            Console.ReadKey();
        }

        public void ShowEmployee()
        {
            EmployeeCtrl ctrl = new EmployeeCtrl();

            foreach( Employee employee in ctrl.GetEmployees())
            {
                Console.Write("\nID: {0}\nName: {1}\nMail: {2}\nBirthDate: {3} \nStart Date: {4} \nStatus: {5}", employee.Id, employee.Name,
                                employee.Mail, employee.BirthDay, employee.StartDate, employee.Estatus);
            }
            Console.ReadKey();
        }

        public void ShowRole()
        {
            RolesCtrl ctrl = new RolesCtrl();

            foreach( Cat_Role role in ctrl.GetCat_Roles())
            {
                Console.Write("\nID: {0} \nName: {1} \nDescription: {2}", role.Id, role.Name, role.Description);
            }
            Console.ReadKey();
        }

        public void ShowEP()
        {
            EmployeeProjectCtrl ctrl = new EmployeeProjectCtrl();

            foreach( EmployeeProject EP in ctrl.GetEmployeeProjects())
            {
                Console.Write("\nProject ID: {0}\nEmployee ID: {1}\nRole ID: {2}", EP.ProjectId, EP.EmployeeId, EP.RoleId);
            }
            Console.ReadKey();
        }
    }
}
