using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Data.Interfaces
{
	public interface IRepository<TEntity>
		where TEntity : class, new()
	{
		IEnumerable<TEntity> QueryStoredProcedure(string storedProcedure, params object[] parameters);
		IEnumerable<TEntity> QuerySqlString(string sqlString, params object[] parameters);
		TEntity GetFirstOrDefaultFromStoredProcedure(string storedProcedure, params object[] parameters);
		TEntity GetFirstOrDefaultFromSql(string sqlString, params object[] parameters);
		int ExecuteNonQueryStoredProcedure(string storedProcedure, params object[] parameters);
	}
}
