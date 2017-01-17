using Autofac;
using MrWhiteLaundryBooker.Data;
using Autofac.Integration.WebApi;
using MrWhiteLaundryBooker.Services;

namespace MrWhiteLaundryBooker
{
    public class LaundryBookerModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(ThisAssembly);

            builder.RegisterType<LaundryBookerContext>().AsSelf().InstancePerDependency();

            builder.RegisterAssemblyTypes(ThisAssembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsSelf()
                .InstancePerDependency();
            builder.RegisterAssemblyTypes(ThisAssembly)
                .Where(t => t.Name.EndsWith("Service"))
                .AsSelf()
                .InstancePerDependency();

        }
    }
}