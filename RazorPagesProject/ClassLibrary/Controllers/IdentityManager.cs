using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Controllers
{
    public class IdentityManager
    {
        /// <summary>
        /// Adds the customer to the system
        /// </summary>
        /// <param name="customer">The customer object to add to the system</param>
        /// <returns>true in case the customer can be added, false if the user exists based on e-mail address</returns>
        //public bool TryAdd(User user)
        //{
        //    return true;
        //}

        public List<Claim> Authenticate(Credentials credentials)
        {
            List<Claim> result = new List<Claim>();

            result.Add(new Claim(ClaimTypes.Role, "Admin"));
            result.Add(new Claim(ClaimTypes.Name, credentials.Email));

            return result;
        }
    }
}
