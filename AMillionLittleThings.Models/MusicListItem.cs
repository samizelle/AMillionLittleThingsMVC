using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMillionLittleThings.Models
{
    public class MusicListItem
    {
        [Display(Name ="Title")]
        public string MusicTitle { get; set; }

        [Display(Name ="Note")]
        public string MusicNote { get; set; }

        [Display(Name ="Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        public override string ToString() => MusicTitle;
    }
}
