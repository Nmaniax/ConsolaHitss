using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsolaHitss
{
    class Program
    {
        
        static void Main(string[] args)
        {
            using (var bd = new HitssContext())
            {
                Console.Write("1) Insert \n2) Show:");
                int m = int.Parse(Console.ReadLine());

                switch(m)
                {
                    case 1:
                        Insert();
                        break;
                    case 2:
                        Show();
                        break;
                }
            }
        }

        public void Menu()
        {
        }

        static void Insert()
        {
            Control ctrl = new Control();
            Console.Write("\n1) Company \n2) Client \n3) Project \n4) Employee \n5) Roles \n6) EP \n");
            int m = int.Parse(Console.ReadLine());

            switch(m)
            {
                case 1:
                    ctrl.AddCompanies() ;
                    break;

                case 2:
                    ctrl.AddClient();
                    break;

                case 3:
                    ctrl.AddProject();
                    break;

                case 4:
                    ctrl.AddEmployee();
                    break;

                case 5:
                    ctrl.AddRole();
                    break;

                case 6:
                    ctrl.AddEP();
                    break;
            }
        }

        static void Show()
        {
            Control ctrl = new Control();
            Console.Write("\n1) Company \n2) Client \n3) Project \n4) Employee \n5) Roles \n6) EP \n");
            int m = int.Parse(Console.ReadLine());

            switch (m)
            {
                case 1:
                    ctrl.ShowCompanies();
                    break;

                case 2:
                    ctrl.ShowClient();
                    break;

                case 3:
                    ctrl.ShowProjects();
                    break;

                case 4:
                    ctrl.ShowEmployee();
                    break;

                case 5:
                    ctrl.ShowRole();
                    break;

                case 6:
                    ctrl.ShowEP();
                    break;
            }
        }
    }
}
