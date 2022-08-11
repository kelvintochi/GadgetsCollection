using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GadgetsCollection.Models
{
    public class Gadget
    {
        [Key]
        [Column(TypeName = "Int")]

        public int GadgetId { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Name")]

        public string Name { get; set; }

        [Required]
        [Column(TypeName = "int")]
        [DisplayName("Age")]

        public int Age { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Color")]
        public String Color { get; set; }

        
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Gender")]
        public String Gender { get; set; }


        
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Gadget Owner Name")]
        public String OwnerName { get; set; }


        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Address")]
        public String Address { get; set; }


        [Column(TypeName = "varchar(100)")]
        [DisplayName("Image Name")]
        public String ImageName { get; set; }


        [NotMapped]
        [DisplayName("upload file")]

        public IFormFile ImageFile { get; set; }
    }
}
