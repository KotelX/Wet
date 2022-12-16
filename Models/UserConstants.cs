using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wet.Models
{
    public class UserConstants
    {
        public static List<Doctor> Users = new List<Doctor>()
        {
            new Doctor() { Name = "jason_admin", EmailAddress = "jason.admin@email.com", Password = "MyPass_w0rd", Surname = "Bryant", Role = "Administrator" },
            new Doctor() { Name = "elyse_seller", EmailAddress = "elyse.seller@email.com", Password = "MyPass_w0rd", Surname = "Lambert", Role = "Seller" },
        };
    }
}
