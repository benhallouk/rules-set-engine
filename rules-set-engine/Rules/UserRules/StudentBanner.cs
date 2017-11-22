namespace RulesSetEngine.Rules.UserRules
{
    using Model;
    using Model.Targetings;

    public class StudentBanner : IScoreRule
    {
        public int CalculateScore(Banner banner)
        {
            return banner.TargetedUser == User.Student ? 5 : 0;
        }
    }
}