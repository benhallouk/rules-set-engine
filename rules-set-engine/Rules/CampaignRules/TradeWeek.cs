namespace RulesSetEngine.Rules.CampaignRules
{
    using Model;
    using Model.Targetings;

    public class TradeWeek : IScoreRule
    {
        public int CalculateScore(Banner banner)
        {
            return banner.TargetedCampaignLength == CampaignLength.TradeWeek ? 3000 : 0;
        }
    }
}