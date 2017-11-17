using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Kartoteka_Kontrachentow;

[assembly: PreApplicationStartMethod(typeof(AutofacWebCommon), "Start")]
namespace Kartoteka_Kontrachentow
{
    public class AutofacWebCommon
    {
        //http://docs.autofac.org/en/latest/integration/mvc.html#quick-start
        public static void Start()
        {
            var builder = new ContainerBuilder();

            // Register your MVC controllers.
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // OPTIONAL: Register model binders that require DI.
            builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
            builder.RegisterModelBinderProvider();

            // OPTIONAL: Register web abstractions like HttpContextBase.
            builder.RegisterModule<AutofacWebTypesModule>();

            // OPTIONAL: Enable property injection in view pages.
            builder.RegisterSource(new ViewRegistrationSource());

            // OPTIONAL: Enable property injection into action filters.
            builder.RegisterFilterProvider();

            RegisterServices(builder);

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        private static void RegisterServices(ContainerBuilder containerBuilder)
        {
            var containerConfigurator = new AutoFacConfigurator();
            containerConfigurator.Configure(containerBuilder);
        }
    }
}