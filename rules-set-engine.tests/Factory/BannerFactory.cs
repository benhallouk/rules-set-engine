namespace RulesSetEngine.Tests.Factory
{
    using Model;
    using Model.Targetings;

    public class BannerFactory
    {
        private readonly Banner _banner;
        public BannerFactory()
        {
            _banner = new Banner();
        }
        public BannerFactory WidthTargetedUser(User targetdUser)
        {
            _banner.TargetedUser = targetdUser;
            return this;
        }


        public BannerFactory WidthTargetedArea(Area targtedArea)
        {
            _banner.TargetedArea = targtedArea;
            return this;
        }

        public BannerFactory WidthTargetedCampaign(CampaignLength targtedCampaign)
        {
            _banner.TargetedCampaignLength = targtedCampaign;
            return this;
        }

        public Banner Build()
        {
            return _banner;
        }
    }
}