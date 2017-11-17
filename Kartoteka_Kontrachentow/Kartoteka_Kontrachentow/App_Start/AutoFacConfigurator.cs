using Autofac;
using Logic.Interfaces.Logics;
using Logic.Interfaces.Repository;
using Logic.Logics;
using Logic.Repository;
using WebGrease;

namespace Kartoteka_Kontrachentow
{
    public class AutoFacConfigurator
    {
        public void Configure(ContainerBuilder containerBuilder)
        {
            AddBindings(containerBuilder);
        }

        private void AddBindings(ContainerBuilder containerBuilder)
        {
            ConfigureEntityFramework(containerBuilder);
            ConfigureLogic(containerBuilder);
            ConfigureRepository(containerBuilder);
            ConfigureCache(containerBuilder);
        }
        private void ConfigureCache(ContainerBuilder containerBuilder)
        {
            
        }

        private void ConfigureRepository(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<LiteDb>().As<ILiteDb>().InstancePerLifetimeScope();
        }

        private void ConfigureLogic(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<AddressLogic>().As<IAddressLogic>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<ContractorLogic>().As<IContractorLogic>().InstancePerLifetimeScope();
        }

        private static void ConfigureEntityFramework(ContainerBuilder containerBuilder)
        {
            //containerBuilder.RegisterType<DbContext>().AsSelf().InstancePerLifetimeScope();
        }
    }
}