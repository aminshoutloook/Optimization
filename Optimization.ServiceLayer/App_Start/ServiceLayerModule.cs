using Autofac;

namespace Optimization.ServiceLayer.App_Start
{
    public class ServiceLayerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Autowire the classes with interfaces
            builder.RegisterAssemblyTypes(GetType().Assembly).AsImplementedInterfaces();
        }
    }
}
