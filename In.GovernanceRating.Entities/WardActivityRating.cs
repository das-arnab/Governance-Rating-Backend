﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System.Text;

namespace In.GovernanceRating.Entities
{
    /// <summary>
    /// Represents rating given by an user to activities done in a ward.
    /// </summary>
    public class WardActivityRating
    {
        // By default property name Id will be configured as Key
        public int Id { get; set; }

        public short? StarsRating { get; set; }

        public DateTime Date { get; set; }

        public string Comments { get; set; }

        public DevelopmentActivity Activity { get; set; }

        public MunicipalCorporationWard Ward { get; set; }

        [Required]
        public User User { get; set; }
    }
}
