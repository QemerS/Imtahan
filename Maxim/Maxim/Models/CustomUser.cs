using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Maxim.Models
{
    public class CustomUser:IdentityUser
    {
        [MaxLength(15)]
        public string Name { get; set; }
        [MaxLength(15)]
        public string Surname { get; set; }
        
    }
}
