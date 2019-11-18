using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LiubaSys.ViewModels
{
    public class SendMessageModel
    {
        [Required]
        public string Subject { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime DateSent { get; set; }
    }
}
