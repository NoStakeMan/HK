using System;
using HK.EntityModels;

namespace HK.Models.Idea
{
    public class IdeaViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public Level EstimatedLevel { get; set; }
        public Level Level { get; set; }
    }
}