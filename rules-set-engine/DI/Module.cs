namespace RulesSetEngine.DI
{
    using Ninject.Extensions.Conventions;
    using Ninject.Modules;
    using Rules;

    public class Module : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind(x =>
                x.FromThisAssembly()
                    .SelectAllClasses()
                    .InheritedFrom<IScoreRule>()
                    .BindAllInterfaces());
        }
    }
}
