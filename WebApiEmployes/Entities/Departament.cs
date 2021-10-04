using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiEmployes.Entities
{
    public class Departament
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El campo nombre es requerido")]
        public String name { get; set; }
        public List<JobPosition> JobPositions { get; set; }
    }
}
