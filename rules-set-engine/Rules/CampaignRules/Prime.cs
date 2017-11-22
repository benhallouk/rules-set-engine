namespace RulesSetEngine.Rules.CampaignRules
{
    using Model;
    using Model.Targetings;

    public class Prime : IScoreRule
    {
        public int CalculateScore(Banner banner)
        {
            return banner.TargetedCampaignLength == CampaignLength.Prime ? 1000 : 0;
        }
    }
}