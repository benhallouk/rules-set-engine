namespace RulesSetEngine.Tests
{
    using Factory;
    using FluentAssertions;
    using Model.Targetings;
    using NUnit.Framework;

    [TestFixture]
    public class ScoreEngineShould
    {
        private readonly ScoreEngine _scoreEngine = new ScoreEngine();

        [Test]
        [TestCase(User.Untargeted, 0)]
        [TestCase(User.Student, 5)]
        [TestCase(User.Primier, 10)]
        public void ReturnScorePerUser(User targtedUser, int score)
        {
            var banner = new BannerFactory()
                .WidthTargetedUser(targtedUser)
                .Build();


            _scoreEngine.CalculateBannerScore(banner).Should().Be(score);
        }


        [Test]
        [TestCase(Area.Store, 100)]
        [TestCase(Area.MarketingTerritory, 200)]
        [TestCase(Area.State, 300)]
        public void ReturnScorePerArea(Area targtedArea, int score)
        {
            var banner = new BannerFactory()
                .WidthTargetedArea(targtedArea)
                .Build();

            _scoreEngine.CalculateBannerScore(banner).Should().Be(score);
        }


        [Test]
        [TestCase(CampaignLength.Prime, 1000)]
        [TestCase(CampaignLength.LongTerm, 2000)]
        [TestCase(CampaignLength.TradeWeek, 3000)]
        public void ReturnScorePerCampaign(CampaignLength targtedCampaign, int score)
        {
            var banner = new BannerFactory()
                .WidthTargetedCampaign(targtedCampaign)
                .Build();


            _scoreEngine.CalculateBannerScore(banner).Should().Be(score);
        }


        [Test]
        [TestCase(User.Primier, Area.State, CampaignLength.TradeWeek, 3310)]
        [TestCase(User.Student, Area.State, CampaignLength.TradeWeek, 3305)]
        public void ReturnCorrectScore(User targtedUser, Area targtedArea, CampaignLength targtedCampaign, int score)
        {
            var banner = new BannerFactory()
                .WidthTargetedUser(targtedUser)
                .WidthTargetedArea(targtedArea)
                .WidthTargetedCampaign(targtedCampaign)
                .Build();

            _scoreEngine.CalculateBannerScore(banner).Should().Be(score);
        }
    }
}