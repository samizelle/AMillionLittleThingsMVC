using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMillionLittleThings.Models
{
    public class BookListItem
    {
        [Display(Name ="Title")]
        public string Title { get; set; }

        [Display(Name ="Book Notes")]
        public string Note { get; set; }

        [Display(Name ="Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        public override string ToString() => Title;
    }
}
