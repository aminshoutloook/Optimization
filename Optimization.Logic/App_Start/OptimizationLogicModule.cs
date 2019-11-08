
using Autofac;

namespace Optimization.Logic.App_Start
{
    public class OptimizationLogicModule : Module
    {
        private bool _perRequest;
        public OptimizationLogicModule(bool supportPerRequest)
        {
            this._perRequest = supportPerRequest;
        }

        protected override void Load(ContainerBuilder builder)
        {
            //Autowire the classes with interfaces
           var reg= builder.RegisterAssemblyTypes(GetType().Assembly).AsImplementedInterfaces();
            if (this._perRequest)
            {
                reg.InstancePerRequest();
            }
            else
            {
                reg.InstancePerLifetimeScope();
            }
        }
    }
}
