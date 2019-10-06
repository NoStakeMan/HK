using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace HK.EntityModels
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base() { }

        public DateTime MemberSince { get; set; }
        public virtual IEnumerable<Vote> Votes { get; set; }
        
    }
}