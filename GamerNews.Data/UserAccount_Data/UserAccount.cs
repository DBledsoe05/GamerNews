using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerNews.Data.UserAccount_Data
{
    public class UserAccount
    {
        [Key]
        public int UserAccountId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("ApplicationUser")]
        public virtual ApplicationUser AppUser { get; set; }
    }
}
