using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prueba_API.Models
{
    public class Auto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public string Imagen { get; set; }
       
    }
}

