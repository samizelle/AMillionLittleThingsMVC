using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMillionLittleThings.Models
{
    class StreamingCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters")]
        [MaxLength(100, ErrorMessage = "There are too many characters in your Title")]
        public string StreamingTitle { get; set; }

        [MaxLength(1000)]
        public string StreamingNote { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
