using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public int ProjectCategoryId { get; set; }

        public virtual ProjectCategory ProjectCategory { get; set; }
        public virtual ICollection<ProjectMember> ProjectMembers { get; set; }
        public virtual ICollection<ProjectTime> ProjectTimes { get; set; }
    }
}
