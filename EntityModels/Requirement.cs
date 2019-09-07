using System.Collections.Generic;

namespace HK.EntityModels
{
    public class Requirement
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public RequirementType Type { get; set; }
        public string Description { get; set; }
        public int Value { get; set; }

        public virtual Project Project { get; set; }
        public virtual IEnumerable<Reward> Rewards { get; set; }
        public virtual IEnumerable<Vote> Votes { get; set; }
    }
}