﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFlashcards.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsInBan { get; set; }

        public List<ApplicationUserClaim> Claims { get; set; }
        public List<ApplicationUserLogin> Logins { get; set; }
        public List<ApplicationUserToken> Tokens { get; set; }
        public List<ApplicationUserRole> UserRoles { get; set; }
    }
}
