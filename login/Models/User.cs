using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login.Models
{
    public class User
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string pseudo { get; set; }
        public string password { get; set; }
    }
}
