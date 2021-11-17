using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerNews.Models.Review_Models
{
    public class ReviewCreate
    {
        [Key]
        public int ReviewId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTimeOffset DateReleased { get; set; }

        public int Rating { get; set; }

        public int GameId { get; set; }

        public int UserAccountId { get; set; }
    }
}
