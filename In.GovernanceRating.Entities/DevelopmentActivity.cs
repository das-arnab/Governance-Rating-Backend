using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace In.GovernanceRating.Entities
{
    /// <summary>
    /// Master table listing the possible development activities by any candidate at any level.
    /// </summary>
    public class DevelopmentActivity
    {
        // By default property name Id will be configured as Key
        public int Id { get; set; }

        [MaxLength(100), Required]
        public string ActivityName { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }
    }
}
