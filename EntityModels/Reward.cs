namespace HK.EntityModels
{
    public class Reward
    {
        public int Id { get; set; }
        public int RequirementId { get; set; }
        public RewardType Type { get; set; }
        public int Value { get; set; }
        public virtual Requirement Requirement { get; set; }
    }
}