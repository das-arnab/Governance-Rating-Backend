using System;
using System.Collections.Generic;
using System.Text;

namespace In.GovernanceRating.Entities
{
    /// <summary>
    /// Master table listing the possible development activities by any candidate at any level.
    /// </summary>
    public class DevelopmentActivity
    {
        public int Id { get; set; }

        public string ActivityName { get; set; }

        public string Description { get; set; }
    }
}
