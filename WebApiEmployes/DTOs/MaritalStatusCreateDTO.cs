using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiEmployes.DTOs
{
    public class MaritalStatusCreateDTO
    {

        [Required(ErrorMessage = "El campo nombre es requerido")]
        public String Name { get; set; }
    }
}
