using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class ContactDetail
    {
        // Mise en place des propriétés d'un contact 

        [Key] // Primary KEY pour les ID
        public int id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string firstName { get; set; } //Prénom
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string lastName { get; set; } // Nom
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string address1 { get; set; } // Adresse
        [Required]
        [Column(TypeName = "nvarchar(5)")]
        public string cityPostalCode1 { get; set; } // Code postal
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string city1 { get; set; } // Ville
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string address2 { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(5)")]
        public string cityPostalCode2 { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string city2 { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string address3 { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(5)")]
        public string cityPostalCode3 { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string city3 { get; set; }
    }
}
