using System.Collections.Generic;
using System.Linq;
using Animal.Data.Interfaces;
using Animal.Data.Repositories.Helpers;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Animal.Data.Repositories
{
	public  abstract class Repository<T> : IRepository<T>
		where T : class, new()
	{
		protected virtual IRowMapper<T> RowMapper => MapperHelpers.GetDefaultMapper<T>();

		protected readonly Database Database;

		protected Repository(Database database)
		{
			Database = database;
		}

		public IEnumerable<T> QueryStoredProcedure(string storedProcedure, params object[] parameters)
		{
			return Database.ExecuteSprocAccessor(storedProcedure, RowMapper, parameters);
		}

		public IEnumerable<T> QuerySqlString(string sqlString, params object[] parameters)
		{
			return Database.CreateSqlStringAccessor(sqlString, RowMapper).Execute(parameters);
		}

		public T GetFirstOrDefaultFromStoredProcedure(string storedProcedure, params object[] parameters)
		{
			return QueryStoredProcedure(storedProcedure, parameters).FirstOrDefault();
		}

		public T GetFirstOrDefaultFromSql(string sqlString, params object[] parameters)
		{
			return QuerySqlString(sqlString, parameters).FirstOrDefault();
		}

		public int ExecuteNonQueryStoredProcedure(string storedProcedure, params object[] parameters)
		{
			var command = Database.GetStoredProcCommand(storedProcedure, parameters);
			return Database.ExecuteNonQuery(command);
		}
	}
}
