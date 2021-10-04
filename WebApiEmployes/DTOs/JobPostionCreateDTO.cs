using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiEmployes.DTOs
{
    public class JobPostionCreateDTO
    {
        [Required(ErrorMessage = "El campo nombre es requerido")]
        public string NamePosition { get; set; }
        [Required(ErrorMessage = "El id del departamento es requerido")]
        public int DepartamentId { get; set; }

    }
}
