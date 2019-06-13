using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace In.GovernanceRating.Entities
{
    /// <summary>
    /// Representation of Ward in a Municipal Corporation.
    /// </summary>
    public class MunicipalCorporationWard
    {
        // By default property name Id will be configured as Key
        public int Id { get; set; }

        [Required]
        public string WardNumber { get; set; }

        [Required]
        public MunicipalCorporation MunicipalCorporation { get; set; }

        [Required]
        public Candidate Councillor{ get; set; }
    }
}
