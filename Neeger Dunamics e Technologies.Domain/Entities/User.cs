using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neeger_Dynamics_e_Technologies.Domain.Entities
{
    public class User
    {
        public Guid ID { get; set; }
        public string Name { get; set; }   
        public string Email { get; set; }
        //public string Password { get; set; }

    }
}
