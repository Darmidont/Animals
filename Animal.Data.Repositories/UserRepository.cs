using System.Collections.Generic;
using System.Data;
using Animal.Common;
using Animal.Common.Models.Data;
using Animal.Data.Interfaces;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.Unity;

namespace Animal.Data.Repositories
{
	public class UserRepository : Repository<UserEnity>, IUserRepository
	{
		public UserRepository([Dependency(Constants.AnimalDatabase)]Database database): base(database)
		{
		}

		public IEnumerable<UserEnity> GetUsers()
		{
			var result = new List<UserEnity>();
			using (var dbCommand = Database.GetStoredProcCommand("dbo.[spGetUsers]"))
			{
				using (var reader = Database.ExecuteReader(dbCommand))
				{
					if (reader.Read())
						result.Add(RowMapper.MapRow(reader));

					while (reader.Read())
						result.Add(RowMapper.MapRow(reader));
				}
			}

			return result;
		}

		public void AddUser(UserEnity user)
		{
			using (var dbCommand = Database.GetStoredProcCommand("dbo.spAddUser"))
			{
				Database.AddInParameter(dbCommand, "@FirstName", DbType.String, user.FirstName);
				Database.AddInParameter(dbCommand, "@LastName", DbType.String, user.LastName);
				Database.AddInParameter(dbCommand, "@Email", DbType.String, user.Email);
				Database.AddInParameter(dbCommand, "@Login", DbType.String, user.Login);
				Database.AddInParameter(dbCommand, "@Description", DbType.String, user.Description);
				Database.ExecuteNonQuery(dbCommand);
			}
		}

	}
}
