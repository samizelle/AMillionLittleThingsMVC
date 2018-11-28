using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMillionLittleThings.Data
{
    public class Music
    {
        [Key]
        public int MusicId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string MusicTitle { get; set; }

        [Required]
        public string MusicNote { get; set; }

        public bool IsImportant { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
