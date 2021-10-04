using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiEmployes.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Lastname { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public int MaritalStatusId { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public DateTime BirthdayDate { get; set; }
        public int Age { get; set; }
        public String Dpi { get; set; }
        public String NIT { get; set; }
        public String SocialSecurity { get; set; }
        public String Irtra { get; set; }
        public String passport { get; set; }
        public String Address { get; set; }
        public int JobPositonID { get; set; }
        public JobPosition JobPosition { get; set; }
        public float Salary { get; set; }
        public float Bonus { get; set; }
    }
}
