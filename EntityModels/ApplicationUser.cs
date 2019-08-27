using System;
using Microsoft.AspNetCore.Identity;

namespace HK.EntityModels
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base() { }

        public DateTime MemberSince { get; set; }
    }
}