namespace HK.EntityModels
{
    public class Feedback
    {
        public int Id { get; set; }
        public int PointId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }

        public virtual Point Point { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}