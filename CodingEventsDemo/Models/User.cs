using System;
using Microsoft.AspNetCore.Identity;

namespace CodingEventsDemo.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }

        public User()
        {
        }
    }
}
