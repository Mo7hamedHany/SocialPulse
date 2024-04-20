﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialPulse.Core.Models
{
    public class Post : BaseEntity<int>
    {
        public User User { get; set; }

        public string UserId { get; set; }

        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
