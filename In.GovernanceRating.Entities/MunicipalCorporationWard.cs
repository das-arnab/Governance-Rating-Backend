using System;
using System.Collections.Generic;
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

        public string WardNumber { get; set; }

        public MunicipalCorporation MunicipalCorporation { get; set; }

        public Candidate Councillor{ get; set; }
    }
}
