using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal.Bal.Interfaces;
using Animal.Common.Models.Bal;
using Animal.Common.Models.Data;
using Animal.Data.Interfaces;

namespace Animal.Bal.Services
{
public class AdminService: IAdminService
	{
		
		public string Hello()
		{
			return "Hello";
		}

		public IEnumerable<UserEntity> GetUsers()
		{
			throw new NotImplementedException();
		}

		public void AddUser(UserModel user)
		{

			throw new NotImplementedException();
		}

		public void DeleteUser(UserModel user)
		{
			throw new NotImplementedException();
		}

		public void UpdateUserData(UserModel user)
		{
			throw new NotImplementedException();
		}

		public void AddNews(ParticularNewsModel news)
		{
			throw new NotImplementedException();
		}

		public void UpdateAdminData(UserModel user)
		{
			throw new NotImplementedException();
		}

		public void ChangeAdminData(AdminModel admin)
		{
			throw new NotImplementedException();
		}

		public void UpdateUser(UserModel user)
		{
			throw new NotImplementedException();
		}

		IEnumerable<UserEntity> IAdminService.GetUsers()
		{
			throw new NotImplementedException();
		}

		void IAdminService.AddUser(UserModel user)
		{
			throw new NotImplementedException();
		}

		void IAdminService.DeleteUser(UserModel user)
		{
			throw new NotImplementedException();
		}

		void ChangeUserData(UserModel user)
		{
			throw new NotImplementedException();
		}

		void AdminData(UserModel user)
		{
			throw new NotImplementedException();
		}
	}
}
