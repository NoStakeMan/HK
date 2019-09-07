using HK.EntityModels;

namespace HK.Models.Project
{
    public class ProjectViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public ProjectStatus Status { get; set; }

    }
}