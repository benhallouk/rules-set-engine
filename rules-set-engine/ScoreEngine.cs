namespace RulesSetEngine
{
    using DI;
    using Model;
    using Ninject;
    using Rules;
    using System.Linq;

    public class ScoreEngine
    {
        public int CalculateBannerScore(Banner banner)
        {
            var score = 0;
            IKernel kernel = new StandardKernel(new Module());
            var rules = kernel.GetAll<IScoreRule>().ToList();

            foreach (var rule in rules)
            {
                //score = Math.Max(rule.CalculateScore(banner), score);
                score += rule.CalculateScore(banner);
            }

            return score;
        }
    }
}