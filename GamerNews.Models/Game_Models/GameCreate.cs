using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerNews.Models.Game_Models
{
    public class GameCreate
    {
        [Key]
        public int GameId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MaturityRating { get; set; }
        public string Platform { get; set; }
    }
}
