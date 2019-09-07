using System.Collections.Generic;

namespace HK.EntityModels
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public ProjectStatus Status { get; set; }
        public virtual IEnumerable<Requirement> Requirements { get; set; }

    }
}