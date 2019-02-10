using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CrudAsincrono.Models
{
    public class Profesor
    {
        [Key]
        public int Id { get; set; }


        [Required (ErrorMessage ="Este campo es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Cedula { get; set; }


        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Direccion {get; set;}


        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Telefono { get; set; }

        
    }
}
