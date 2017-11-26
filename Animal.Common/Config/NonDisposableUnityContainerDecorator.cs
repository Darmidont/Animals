using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace Animal.Common.Config
{
	[DebuggerStepThrough, DebuggerNonUserCode]
	internal class NonDisposableUnityContainerDecorator : IUnityContainer
	{
		private readonly IUnityContainer container;

		[DebuggerStepperBoundary, DebuggerStepThrough, DebuggerNonUserCode]
		public NonDisposableUnityContainerDecorator(IUnityContainer container)
		{
			this.container = container;
		}

		[DebuggerStepperBoundary, DebuggerStepThrough, DebuggerNonUserCode]
		public IUnityContainer AddExtension(UnityContainerExtension extension)
		{
			return container.AddExtension(extension);
		}

		[DebuggerStepperBoundary, DebuggerStepThrough, DebuggerNonUserCode]
		public object BuildUp(Type t, object existing, string name, params ResolverOverride[] resolverOverrides)
		{
			return container.BuildUp(t, existing, name, resolverOverrides);
		}

		[DebuggerStepperBoundary, DebuggerStepThrough, DebuggerNonUserCode]
		public object Configure(Type configurationInterface)
		{
			return container.Configure(configurationInterface);
		}

		[DebuggerStepperBoundary, DebuggerStepThrough, DebuggerNonUserCode]
		public IUnityContainer CreateChildContainer()
		{
			return container.CreateChildContainer();
		}

		public IUnityContainer Parent
		{
			[DebuggerStepperBoundary, DebuggerStepThrough, DebuggerNonUserCode]
			get
			{
				return container.Parent;
			}
		}

		[DebuggerStepperBoundary, DebuggerStepThrough, DebuggerNonUserCode]
		public IUnityContainer RegisterInstance(Type t, string name, object instance, LifetimeManager lifetime)
		{
			return container.RegisterInstance(t, name, instance, lifetime);
		}

		[DebuggerStepperBoundary, DebuggerStepThrough, DebuggerNonUserCode]
		public IUnityContainer RegisterType(Type from, Type to, string name, LifetimeManager lifetimeManager, params InjectionMember[] injectionMembers)
		{
			return container.RegisterType(from, to, name, lifetimeManager, injectionMembers);
		}

		public IEnumerable<ContainerRegistration> Registrations
		{
			[DebuggerStepperBoundary, DebuggerStepThrough, DebuggerNonUserCode]
			get
			{
				return container.Registrations;
			}
		}

		[DebuggerStepperBoundary, DebuggerStepThrough, DebuggerNonUserCode]
		public IUnityContainer RemoveAllExtensions()
		{
			return container.RemoveAllExtensions();
		}

		[DebuggerStepperBoundary, DebuggerStepThrough, DebuggerNonUserCode]
		public object Resolve(Type t, string name, params ResolverOverride[] resolverOverrides)
		{
			return container.Resolve(t, name, resolverOverrides);
		}

		[DebuggerStepperBoundary, DebuggerStepThrough, DebuggerNonUserCode]
		public IEnumerable<object> ResolveAll(Type t, params ResolverOverride[] resolverOverrides)
		{
			return container.ResolveAll(t, resolverOverrides);
		}

		[DebuggerStepperBoundary, DebuggerStepThrough, DebuggerNonUserCode]
		public void Teardown(object o)
		{
			container.Teardown(o);
		}

		[DebuggerStepperBoundary, DebuggerStepThrough, DebuggerNonUserCode]
		public void Dispose()
		{
			// do nothing;
			// registered unity container produces stackoverflow exception
			// because it's just do dispose() again & again
		}

	}
}
