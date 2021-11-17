using GamerNews.Data.Game_Data;
using GamerNews.Data.UserAccount_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerNews.Data.Review_Data
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTimeOffset DateReleased { get; set; }

        [Required]
        public int Rating { get; set; }


        [ForeignKey(nameof(User))]
        public int UserAccountId { get; set; }
        public virtual UserAccount User  { get; set; }

        [ForeignKey(nameof(Game))]
        public int GameId { get; set; }
        public virtual Game Game { get; set; }
    }
}
