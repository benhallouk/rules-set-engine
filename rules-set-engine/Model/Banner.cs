namespace RulesSetEngine.Model
{
    using Targetings;

    public class Banner
    {
        public int Id { get; set; }
        public CampaignLength TargetedCampaignLength { get; set; }
        public Area TargetedArea { get; set; }
        public User TargetedUser { get; set; }
    }
}