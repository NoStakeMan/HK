namespace HK.EntityModels
{
    public class Vote
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RequirementId { get; set; }
        public bool YesOrNo { get; set; }
        public string Feedback { get; set; }

        public virtual ApplicationUser User { get; set; }

    }
}