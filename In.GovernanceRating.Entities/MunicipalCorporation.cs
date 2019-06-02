using System;
using System.Collections.Generic;
using System.Text;

namespace In.GovernanceRating.Entities
{
    public class MunicipalCorporation
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Abbreviation { get; set; }

        public int NumberOfStaffs { get; set; }

        public Candidate Mayor { get; set; }
    }
}
