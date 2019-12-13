using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LiubaSys.ViewModels
{
    public class PublishMessageViewModel
    {
        [Required]
        public string Content { get; set; }
        public string YoutubeLink1 { get; set; }
        public IFormFile File1 { get; set; }
    }
}
