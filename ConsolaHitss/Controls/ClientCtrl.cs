using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaHitss.Controls
{
    class ClientCtrl
    {
        HitssContext hitss = new HitssContext();
        public List<Client> GetClients()
        {
            return hitss.Clients.ToList();
        }

        public Client GetClientById(int id)
        {
            return hitss.Clients.FirstOrDefault(c => c.Id == id);
        }

        public void CreateClient(Client client)
        {
            hitss.Clients.Add(client);
            hitss.SaveChanges();
        }


        //Update 


        public void  DeleteClient(int id)
        {
            Client client = GetClientById(id);
            if(client != null)
            {
                client.Estatus = 0;
                hitss.SaveChanges();
            }
        }
    }
}
