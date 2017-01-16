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

            builder.RegisterType<BookingRepository>().As<IBookingRepository>().InstancePerDependency();
            builder.RegisterType<BookingService>().As<IBookingService>().InstancePerDependency();
        }
    }
}