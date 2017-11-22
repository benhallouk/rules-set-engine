namespace RulesSetEngine.Rules.AreaRules
{
    using Model;
    using Model.Targetings;

    public class State : IScoreRule
    {
        public int CalculateScore(Banner banner)
        {
            return banner.TargetedArea == Area.State ? 300 : 0;
        }
    }
}