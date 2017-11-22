namespace RulesSetEngine.Rules.CampaignRules
{
    using Model;
    using Model.Targetings;

    public class LongTerm : IScoreRule
    {
        public int CalculateScore(Banner banner)
        {
            return banner.TargetedCampaignLength == CampaignLength.LongTerm ? 2000 : 0;
        }
    }
}