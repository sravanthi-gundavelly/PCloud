using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PacteraCloud.ViewModels
{
    public class UserListViewModel
    {
        public UserListViewModel()
        {
            this.users = new List<IdentityUser>();
        }

        public UserListViewModel(IEnumerable<IdentityUser> users)
        {
            this.users = users;
        }
        public IEnumerable<IdentityUser> users { get; set; }
    }
}
