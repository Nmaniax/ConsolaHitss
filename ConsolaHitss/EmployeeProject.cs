using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsolaHitss
{
    class EmployeeProject
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [ForeignKey("Cat_Role")]
        public int RoleId { get; set; }
        public Cat_Role Cat_Role { get; set; }
    }
}
