using System;
using Animal.Common.Config;
using Microsoft.Practices.Unity;


namespace Animal.Common
{
	//public class UnityConfig
	//{
	//	private static Action<IUnityContainer> _typesRegistration;
	//	private static readonly Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
	//	{
	//		if (_typesRegistration == null)
	//			throw new Exception("Types registration not initialized");

	//		var container = new UnityContainer();
	//		container.RegisterInstance<IUnityContainer>(new NonDisposableUnityContainerDecorator(container));
	//		_typesRegistration(container);
	//		return container;
	//	});

	//	public static void SetupTypeMappings(Action<IUnityContainer> typesRegistration)
	//	{
	//		_typesRegistration = typesRegistration;
	//	}

	//	/// <summary>
	//	/// Gets the configured Unity container.
	//	/// </summary>
	//	public static IUnityContainer Container => container.Value;

	//	public static IUnityContainer GetConfiguredContainer()
	//	{
	//		return container.Value;
	//	}
	//}

	public static class UnityConfig
	{
		#region Unity Container
		private static Lazy<IUnityContainer> container =
			new Lazy<IUnityContainer>(() =>
			{
				var container = new UnityContainer();
				RegisterTypes(container);
				return container;
			});

		/// <summary>
		/// Configured Unity Container.
		/// </summary>
		public static IUnityContainer Container => container.Value;
		#endregion

		/// <summary>
		/// Registers the type mappings with the Unity container.
		/// </summary>
		/// <param name="container">The unity container to configure.</param>
		/// <remarks>
		/// There is no need to register concrete types such as controllers or
		/// API controllers (unless you want to change the defaults), as Unity
		/// allows resolving a concrete type even if it was not previously
		/// registered.
		/// </remarks>
		public static void RegisterTypes(IUnityContainer container)
		{
			// NOTE: To load from web.config uncomment the line below.
			// Make sure to add a Unity.Configuration to the using statements.
			// container.LoadConfiguration();

			// TODO: Register your type's mappings here.
			// container.RegisterType<IProductRepository, ProductRepository>();

			CommonUnityRegistrations.RegisterCommonTypes(container);
		}

		public static IUnityContainer GetConfiguredContainer()
			{
				return container.Value;
			}
	}
}
