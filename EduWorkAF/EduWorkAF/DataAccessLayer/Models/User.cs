using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(320)]
        public string Email { get; set; }
        [Required]
        [MaxLength(100)]
        public string Username { get; set; }
        public virtual ICollection<ProjectMember> ProjectMembers { get; set; }
    }
}
