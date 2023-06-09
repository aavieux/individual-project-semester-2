using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Controllers
{
    public class Credentials
    {
        public string Email { get; private set; }
        public string Password { get; private set; }

        public Credentials(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
