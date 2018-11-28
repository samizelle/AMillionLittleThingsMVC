using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMillionLittleThings.Data
{
    public class Quote
    {
        [Key]
        public int QuoteId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string QuoteContent { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
