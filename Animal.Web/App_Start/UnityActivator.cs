using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using Animal.Common;
using Animal.Web;
using Microsoft.Practices.Unity.Mvc;
using Microsoft.Practices.Unity.WebApi;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(UnityActivator), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethod(typeof(UnityActivator), "Shutdown")]
namespace Animal.Web
{
	public static class UnityActivator
	{
		public static void Start()
		{
			//UnityConfig.SetupTypeMappings(RegisterTypes);

			var container = UnityConfig.Container;

			RegisterTypes(container);
			//MVC
			FilterProviders.Providers.Remove(FilterProviders.Providers.OfType<FilterAttributeFilterProvider>().First());
			FilterProviders.Providers.Add(new UnityFilterAttributeFilterProvider(container));

			DependencyResolver.SetResolver(new Microsoft.Practices.Unity.Mvc.UnityDependencyResolver(container));

			Microsoft.Web.Infrastructure.DynamicModuleHelper.DynamicModuleUtility.RegisterModule(typeof(UnityPerRequestHttpModule));

			//Web API
			var resolver = new UnityHierarchicalDependencyResolver(container);
			GlobalConfiguration.Configuration.DependencyResolver = resolver;
		}

		private static void RegisterTypes(Microsoft.Practices.Unity.IUnityContainer container)
		{
			CommonUnityRegistrations.RegisterCommonTypes(container);
		}

		/// <summary>Disposes the Unity container when the application is shut down.</summary>
		public static void Shutdown()
		{
			var container = UnityConfig.Container;
			container.Dispose();
		}
	}
}