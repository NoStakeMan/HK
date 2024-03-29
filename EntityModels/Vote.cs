namespace HK.EntityModels
{
    public class Vote
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PointId { get; set; }
        public int ForAgainst { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual Point Point { get; set; }

    }
}