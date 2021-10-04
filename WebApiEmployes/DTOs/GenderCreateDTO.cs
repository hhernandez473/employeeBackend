using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiEmployes.DTOs
{
    public class GenderCreateDTO
    {
        [Required(ErrorMessage = "El campo nombre de genero es requerido")]
        public String name { get; set; }
    }
}
