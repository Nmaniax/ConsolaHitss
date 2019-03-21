using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsolaHitss
{
    class Project
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public int Estatus { get; set; }
        public String Description { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
