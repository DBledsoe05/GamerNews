using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerNews.Models.Review_Models
{
    public class ReviewListItem
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTimeOffset DateReleased { get; set; }

        public int Rating { get; set; }

        public int GameId { get; set; }

        public int UserAccountId { get; set; }
    }
}
