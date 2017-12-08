using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using Animal.Common;
using Animal.Common.Models.Data;
using Animal.Data.Interfaces;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.Unity;
using System.Configuration;
using Animal.Common.Models.Bal;

namespace Animal.Data.Repositories
{
	public class UserRepository : Repository<UserEntity>, IUserRepository
	{
		public UserRepository([Dependency(Constants.AnimalDatabase)]Database database): base(database)
		{
		}

		public IEnumerable<UserEntity> GetUsers()
		{
			var result = new List<UserEntity>();
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

		public void Add(UserEntity user)
		{
			using (var dbCommand = Database.GetStoredProcCommand("dbo.spAddUser"))
			{
				Database.AddInParameter(dbCommand, "@FirstName", DbType.String, user.FirstName);
				Database.AddInParameter(dbCommand, "@LastName", DbType.String, user.LastName);
				Database.AddInParameter(dbCommand, "@Email", DbType.String, user.Email);
				Database.AddInParameter(dbCommand, "@Login", DbType.String, user.Login);
				Database.AddInParameter(dbCommand, "@Password", DbType.String, user.Password);
				Database.AddInParameter(dbCommand, "@Description", DbType.String, user.Description);
			//	Database.ExecuteNonQuery(dbCommand);
			}
		}


		public void Authorize(UserEntity user)
		{
			using (var dbCommand = Database.GetStoredProcCommand("dbo.spAuthorizeUser"))
			{

				//Database.
				Database.AddInParameter(dbCommand, "@Login", DbType.String, user.Login);
				Database.AddInParameter(dbCommand, "@Password", DbType.String, user.Password);
				Database.ExecuteNonQuery(dbCommand);
			}
		}

		public void Delete(UserEntity user)
		{
			
		}

		public void Update(UserEntity user)
		{
			using (var dbCommand = Database.GetStoredProcCommand("dbo.spUpdateUser"))
			{
				Database.AddInParameter(dbCommand, "@Id", DbType.String, user.Id);
				Database.AddInParameter(dbCommand, "@FirstName", DbType.String, user.FirstName);
				Database.AddInParameter(dbCommand, "@LastName", DbType.String, user.LastName);
				Database.AddInParameter(dbCommand, "@Email", DbType.String, user.Email);
				Database.AddInParameter(dbCommand, "@Login", DbType.String, user.Login);
				Database.AddInParameter(dbCommand, "@Password", DbType.String, user.Password);
				Database.AddInParameter(dbCommand, "@Description", DbType.String, user.Description);
				Database.ExecuteNonQuery(dbCommand);
			}
		}
	}
}
