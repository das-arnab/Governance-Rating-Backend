using System;
using System.Collections.Generic;
using System.Text;

namespace In.GovernanceRating.Entities
{
    public class MunicipalCorporation
    {
        // By default property name Id will be configured as Key
        public int Id { get; set; }

        public string Name { get; set; }

        public string Abbreviation { get; set; }

        public int NumberOfStaffs { get; set; }

        public Candidate Mayor { get; set; }
    }
}
