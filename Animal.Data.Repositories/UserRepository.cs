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

		public void AddUser(UserEntity user)
		{
			int userId = 0;
			//string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;

			using (var dbCommand = Database.GetStoredProcCommand("dbo.spAddUser"))
			{

				//Database.CommandType = CommandType.StoredProcedure;
				Database.AddInParameter(dbCommand, "@FirstName", DbType.String, user.FirstName);
				Database.AddInParameter(dbCommand, "@LastName", DbType.String, user.LastName);
				Database.AddInParameter(dbCommand, "@Email", DbType.String, user.Email);
				Database.AddInParameter(dbCommand, "@Login", DbType.String, user.Login);
				Database.AddInParameter(dbCommand, "@Password", DbType.String, user.Password);
				Database.AddInParameter(dbCommand, "@Description", DbType.String, user.Description);
				Database.AddInParameter(dbCommand, "@CreatedDate",DbType.DateTime, user.CreatedDate);
				Database.AddInParameter(dbCommand, "@LastLoginDate", DbType.DateTime, user.LastLoginDate);
				Database.ExecuteNonQuery(dbCommand);

				string message = string.Empty;
				switch (userId)
				{
					case -1:
						message = "Username already exists.\\nPlease choose a different username.";
						break;
					case -2:
						message = "Supplied email address has already been used.";
						break;
					default:
						message = "Registration successful.\\nUser Id: " + userId.ToString();
						break;
				}


			}
		}




		protected void RegisterUser(UserEntity user)
		{
		
		//	string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
			//using (SqlConnection con = new SqlConnection(constr))
			{
				using (SqlCommand cmd = new SqlCommand("Insert_User"))
				{
					using (SqlDataAdapter sda = new SqlDataAdapter())
					{
						cmd.CommandType = CommandType.StoredProcedure;
					//	cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
						//cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

						//cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
					//	cmd.Connection = con;
					//	con.Open();
					//	userId = Convert.ToInt32(cmd.ExecuteScalar());
					//	con.Close();
					}
				}
			
				//ClientScript.RegisterStartupScript(GetType(), "alert", "alert('" + message + "');", true);
			}
		}


	}
}
