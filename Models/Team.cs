using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Day17Assignment.Models
{
    [Table("Team")]
    public class Team
    {
        [Key]
        public int TId { get; set; }
        [Required]
        [StringLength(50)]
        public string TName { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        public string TSlogon { get; set; }
    }
}