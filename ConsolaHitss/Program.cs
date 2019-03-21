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
            using (var db = new HitssContext())
            {
                Console.Write("Enter the name of the Role: ");
                var roleName = Console.ReadLine();

                var role = new Cat_Role { Name = roleName };
                db.Roles.Add(role);
                db.SaveChanges();

                Console.ReadKey();
            }
        }
    }
}
