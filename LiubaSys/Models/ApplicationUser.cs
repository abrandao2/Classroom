using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiubaSys.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int Year { get; set; }
        public string Language { get; set; }

        // Navigational properties
        public ICollection<MessageSent> MessagesSent { get; set; }
    }
}
