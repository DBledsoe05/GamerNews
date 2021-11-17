using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerNews.Models.Preview_Models
{
    public class PreviewListItem
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string MaturityRating { get; set; }

        public DateTimeOffset ExpectedRelease { get; set; }
    }
}
