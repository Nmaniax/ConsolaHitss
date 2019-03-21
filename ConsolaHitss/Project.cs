using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ConsolaHitss
{
    class Project
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public int Estatus { get; set; }
        public String Description { get; set; }

        public virtual Client Client { get; set; }
    }
}
