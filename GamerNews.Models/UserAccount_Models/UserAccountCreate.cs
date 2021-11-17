﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerNews.Models.UserAccount_Models
{
    public class UserAccountCreate
    {
        [Key]
        public int UserAccountId { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }
    }
}
