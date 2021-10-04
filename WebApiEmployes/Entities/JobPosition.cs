using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiEmployes.Entities
{
    public class JobPosition
    {
        public int Id { get; set; }
        public String NamePosition { get; set; }
        public int DepartamentId { get; set; }

        public Departament Departament { get; set; }
    }
}
