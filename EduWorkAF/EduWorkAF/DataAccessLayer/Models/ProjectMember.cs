using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class ProjectMember
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public int ProjectRoleId { get; set; }

        public virtual User User { get; set; }
        public virtual Project Project { get; set; }
        public virtual ProjectRole ProjectRole { get; set; }
    }
}
