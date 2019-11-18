using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiubaSys.Models
{
    public class MessagePublished
    {
        public int MessagePublishedId { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime DatePublished { get; set; }
        public string File1 { get; set; }
        public string File2 { get; set; }
        public string File3 { get; set; }
        public string File4 { get; set; }
        public string File5 { get; set; }
        public string YoutubeLink1 { get; set; }
        public string YoutubeLink2 { get; set; }
        public string YoutubeLink3 { get; set; }
        public string YoutubeLink4 { get; set; }
        public string YoutubeLink5 { get; set; }

        // Navigational properties
        public virtual ICollection<MessagesInClassroom> MessagesInClassroom { get; set; }
    }
}
