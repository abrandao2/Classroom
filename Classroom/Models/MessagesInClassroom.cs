using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LiubaSys.Models
{
    public class MessagesInClassroom
    {
        public int MessagePublishedId { get; set; }
        public int ClassroomId { get; set; }

        [ForeignKey("MessagePublishedId")]
        public MessagePublished MessagePublished { get; set; }
        [ForeignKey("ClassroomId")]
        public Classroom Classroom { get; set; }
    }
}
