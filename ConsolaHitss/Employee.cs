using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsolaHitss
{
    class Employee
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Mail { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime BirthDay { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime StartDate { get; set; }
        public int Estatus { get; set; }

        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
