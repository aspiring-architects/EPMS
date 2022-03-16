using System;
using System.Collections.Generic;

namespace Login.DomainModels.Models
{
    public partial class User
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
        public string UserName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateTime CreatedTs { get; set; }
        public DateTime UpdatedTs { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
    }
}
