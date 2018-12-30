using System;
using Microsoft.AspNetCore.Identity;

namespace Crr.EntityModels
{
    public class ApplicationUser : IdentityUser
    {
        public string ProfileImageUrl { get; set; }
        public DateTime MemberSince { get; set; }
    }
}