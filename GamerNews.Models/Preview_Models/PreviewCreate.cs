using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerNews.Models.Preview_Models
{
    public class PreviewCreate
    {
        [Key]
        public int PreviewId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string MaturityRating { get; set; }

        public DateTimeOffset ExpectedRelease { get; set; }
    }
}
