namespace RulesSetEngine.Rules.UserRules
{
    using Model;
    using Model.Targetings;

    public class PremierBanner : IScoreRule
    {
        public int CalculateScore(Banner banner)
        {
            return banner.TargetedUser == User.Primier ? 10 : 0;
        }
    }
}