namespace RulesSetEngine.Rules.AreaRules
{
    using Model;
    using Model.Targetings;

    public class Store : IScoreRule
    {
        public int CalculateScore(Banner banner)
        {
            return banner.TargetedArea == Area.Store ? 100 : 0;
        }
    }
}