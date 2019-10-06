using System.Collections.Generic;

namespace HK.EntityModels
{
    public class Point
    {
        public int Id { get; set; }
        public int IdeaId { get; set; }
        public PointType Type { get; set; }
        public string Key { get; set; }
        public int Value { get; set; }

        public virtual Idea Idea { get; set; }

        public virtual IEnumerable<Vote> Votes { get; set; }
        public virtual IEnumerable<Feedback> Feedbacks { get; set; }
    }
}