using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMillionLittleThings.Data
{
    public class Web
    {
        [Key]
        public int WebId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string WebNote { get; set; }

        [Required]
        public string WebURL { get; set; }

        [Required]
        public bool IsImportant { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
