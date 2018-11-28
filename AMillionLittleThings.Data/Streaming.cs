using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMillionLittleThings.Data
{
    public class Streaming
    {
        [Key]
        public int StreamingId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string StreamingTitle { get; set; }

        [Required]
        public string StreamingNote { get; set; }

        [Required]
        public bool IsImportant { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
