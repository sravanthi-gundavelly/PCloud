using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PacteraCloud.ViewModels
{
    public class CreateUserViewModel
    {
        public CreateUserViewModel()
        {
            this.roles = new List<IdentityRole>();
            this.identityRole = new IdentityRole();
        }
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public IdentityRole identityRole { get; set; }

        public IList<IdentityRole> roles { get; set; }
    }
}
