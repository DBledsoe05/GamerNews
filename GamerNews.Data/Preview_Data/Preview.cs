using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerNews.Data.Preview_Data
{
    public class Preview
    {
        [Key]
        public int PreviewId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string MaturityRating { get; set; }

        [Required]
        public DateTimeOffset ExpectedRelease { get; set; }
    }
}
