namespace RulesSetEngine.Rules
{
    using Model;

    public interface IScoreRule
    {
        int CalculateScore(Banner banner);
    }
}