using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Animal.Data.Repositories.Helpers
{
	public static class MapperHelpers
	{
		private static readonly ConcurrentDictionary<Type, object> DefaultRowMappers = new ConcurrentDictionary<Type, object>();

		internal static IRowMapper<TEntity> GetDefaultMapper<TEntity>()
			where TEntity : new()
		{
			return DefaultRowMappers.GetOrAdd(typeof(TEntity), CreateDefaultRowMapper<TEntity>) as IRowMapper<TEntity>;
		}

		private static IRowMapper<TEntity> CreateDefaultRowMapper<TEntity>(Type entityType)
			where TEntity : new()
		{
			var context = MapBuilder<TEntity>.MapNoProperties();
			var properties =
				from property in entityType.GetProperties(BindingFlags.Instance | BindingFlags.Public)
				where IsAutoMappableProperty(property)
				select property;

			foreach (var property in properties)
			{
				context.Map(property).ToColumn(GetPropertyColumnName(property));
			}

			return context.Build();
		}

		internal static bool IsAutoMappableProperty(PropertyInfo property)
		{
			return property.CanWrite
			       && property.GetIndexParameters().Length == 0
			       && !IsCollectionType(property.PropertyType)
			       && property.GetCustomAttribute<NotMappedAttribute>() == null;
		}

		internal static string GetPropertyColumnName(PropertyInfo property)
		{
			return property.GetCustomAttribute<ColumnAttribute>()?.Name ?? property.Name;
		}

		private static bool IsCollectionType(Type type)
		{
			// string implements IEnumerable, but for our purposes we don't consider it a collection.
			if (type == typeof(string)) return false;

			var interfaces = from inf in type.GetInterfaces()
				where inf == typeof(IEnumerable) ||
				      (inf.IsGenericType && inf.GetGenericTypeDefinition() == typeof(IEnumerable<>))
				select inf;
			return interfaces.Count() != 0;
		}
	}
}
