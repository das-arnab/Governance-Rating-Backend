using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace In.GovernanceRating.Entities
{
    public class MunicipalCorporation
    {
        // By default property name Id will be configured as Key
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Abbreviation { get; set; }

        public int NumberOfStaffs { get; set; }

        [Required]
        public Candidate Mayor { get; set; }
    }
}
