using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Digest { get; set; }
        public string SecretQuestion { get; set; }
        public string SecretAnswer { get; set; }
        public bool Admin { get; set; }
    }

    
}
