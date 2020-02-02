using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Application
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int IdentityNumber { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Gender { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int Contact { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Address { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string CompanyName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Position { get; set; } 
    }
}
