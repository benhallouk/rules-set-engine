namespace RulesSetEngine.Rules.AreaRules
{
    using Model;
    using Model.Targetings;

    public class MarketingTerritory : IScoreRule
    {
        public int CalculateScore(Banner banner)
        {
            return banner.TargetedArea == Area.MarketingTerritory ? 200 : 0;
        }
    }
}