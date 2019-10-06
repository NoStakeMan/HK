using System;
using System.Collections.Generic;

namespace HK.EntityModels
{
    public class Idea
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public Level EstimatedLevel { get; set; }
        public Level Level { get; set; }

        public virtual IEnumerable<Point> Points { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}