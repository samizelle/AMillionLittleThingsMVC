﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMillionLittleThings.Models
{
    public class WebCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters")]
        [MaxLength(100, ErrorMessage = "There are too many characters in your Title")]
        [Display(Name ="Website Name")]
        public string Title { get; set; }

        [MaxLength(1000)]
        [Display(Name ="Website URL")]
        public string Note { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
