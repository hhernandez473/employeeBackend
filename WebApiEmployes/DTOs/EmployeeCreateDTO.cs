using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiEmployes.DTOs
{
    public class EmployeeCreateDTO
    {
        [Required(ErrorMessage = "El campo nombre es requerido")]
        public String Name { get; set; }
        [Required(ErrorMessage = "El campo apellido es requerido")]
        public String Lastname { get; set; }
        [Required(ErrorMessage = "El campo genero es requerido")]
        public int GenderId { get; set; }
        [Required(ErrorMessage = "El estado civil es requerido")]
        public int MaritalStatusId { get; set; }
        [Required(ErrorMessage = "La Fecha de naciemiento es requerida")]
        public DateTime BirthdayDate { get; set; }
        [Required(ErrorMessage = "La edad es requerida")]
        public int Age { get; set; }
        [Required(ErrorMessage = "El DPI es requerido")]
        public String Dpi { get; set; }
        [Required(ErrorMessage = "El NIT es requerido")]
        public String NIT { get; set; }
        
        public String SocialSecurity { get; set; }
        
        public String Irtra { get; set; }
        public String passport { get; set; }
        [Required(ErrorMessage = "La dirección es requerida")]
        public String Address { get; set; }
        public int JobPositonID { get; set; }
        [Required(ErrorMessage = "El salario es requerido")]
        public float Salary { get; set; }
        [Required(ErrorMessage = "La Bonificación es requerida")]
        public float Bonus { get; set; }
    }
}
