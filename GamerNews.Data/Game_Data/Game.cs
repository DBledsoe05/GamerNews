using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerNews.Data.Game_Data
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MaturityRating { get; set; }
        public string Platform { get; set; }
    }
}
