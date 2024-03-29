﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiubaSys.Models
{
    public class MessageSent
    {
        public int MessageSentId { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime DateSent { get; set; }
        public string UserEmail { get; set; }
        public int Year { get; set; }
    }
}
