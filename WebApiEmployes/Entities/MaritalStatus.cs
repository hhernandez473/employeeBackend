using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiEmployes.Entities
{
    public class MaritalStatus
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public bool Status { get; set; } = true;
    }
}
