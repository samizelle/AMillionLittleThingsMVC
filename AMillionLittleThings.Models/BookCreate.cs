using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMillionLittleThings.Models
{
    public class BookCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters")]
        [MaxLength(100, ErrorMessage = "There are too many characters in your Title")]
        public string BookTitle { get; set; }

        [MaxLength(1000)]
        public string BookNote { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
