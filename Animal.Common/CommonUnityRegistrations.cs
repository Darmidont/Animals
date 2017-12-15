using System;
using System.Linq;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace Animal.Common
{
	public class CommonUnityRegistrations
	{
		public static void RegisterCommonTypes(IUnityContainer container)
		{
			container.AddNewExtension<Interception>()
				//Data Access Layer
			.RegisterType<Database>(Constants.AnimalDatabase,
					new HierarchicalLifetimeManager(),
					new InjectionFactory(c => CreateDatabaseInstance(Constants.Animal)));


			RegisterServices(container, Constants.DatabaseLibraryName);
			RegisterServices(container, Constants.ServiceLibraryName); 
		}

		private static object CreateDatabaseInstance(string databaseName)
		{
			//return DatabaseFactory.CreateDatabase(databaseName);
			DatabaseProviderFactory factory = new DatabaseProviderFactory();
			return factory.Create(databaseName);
		}

		private static void RegisterServices(IUnityContainer container, string libName)
		{
			var assemblyTypes = AppDomain.CurrentDomain.GetAssemblies().Single(_ => _.FullName.StartsWith(libName)).GetTypes()
				.Where(_ => !_.IsAbstract).ToList();

			container.RegisterTypes(
				assemblyTypes,
				WithMappings.FromMatchingInterface,
				WithName.Default,
				WithLifetime.ContainerControlled);
		}
	}
}
