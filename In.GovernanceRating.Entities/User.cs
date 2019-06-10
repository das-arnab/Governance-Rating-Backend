using System;
using System.Collections.Generic;
using System.Text;

namespace In.GovernanceRating.Entities
{
    public class User
    {
        // By default property name Id will be configured as Key
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public bool IsVerified { get; set; }
    }
}
