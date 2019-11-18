using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiubaSys.Models
{
    public class Classroom
    {
        public int ClassroomId { get; set; }
        public int Year { get; set; }
        public string Language { get; set; }

        // Navigational properties
        public ICollection<ApplicationUser> Students { get; set; }
        public virtual ICollection<MessagesInClassroom> MessagesInClassroom { get; set; }
    }
}
