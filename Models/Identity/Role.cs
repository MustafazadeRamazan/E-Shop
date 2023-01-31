using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eshop_srytr.Models.Identity
{
    public class Role : IdentityRole<int>
    {
        public Role() : base() { }
        public Role(string roleName) : base(roleName) { }
    }
}
