﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace In.GovernanceRating.Entities
{
    public class Candidate
    {
        // By default property name Id will be configured as Key
        public int Id { get; set; }

        public string Name { get; set; }

        public short Age { get; set; }

        public string HighestEducationText { get; set; }

        public short PoliticalTenure { get; set; }

        /// <summary>
        /// TODO: What should be the type? latitude longitude tuple? Is short description needed?
        /// This is to know in which environment the candidate has grown up.
        /// </summary>
        public string PlaceOfOrigin { get; set; }

        /// <summary>
        /// TODO: Is any other specialized fields needed like police record ID?
        /// </summary>
        public string CriminalRecordHistory { get; set; }
    }
}
