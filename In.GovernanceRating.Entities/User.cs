using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace In.GovernanceRating.Entities
{
    public class User
    {
        // By default property name Id will be configured as Key
        public int Id { get; set; }

        [Required, MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(15)]
        public string Phone { get; set; }

        public bool? IsVerified { get; set; }
    }
}
