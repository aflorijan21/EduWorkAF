using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class ProjectTime
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public TimeSpan Duration { get; set; }
        [MaxLength(256)]
        public string Comment { get; set; }

        public virtual User User { get; set; }
        public virtual Project Project { get; set; }
    }

}
