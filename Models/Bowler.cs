﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission13Assignment.Models
{
    public class Bowler
    {
        [Key]
        [Required]
        public int BowlerID { get; set; }
        public string BowlerLastName { get; set; }
        public string BowlerFirstName { get; set; }
        public char BowlerMiddleInit { get; set; }
        public string BowlerAddress { get; set; }
        public string BowlerCity { get; set; }
        public string BowlerState { get; set; }
        public string BowlerZip { get; set; }
        public string BowlerPhoneNumber { get; set; }
    }
}
