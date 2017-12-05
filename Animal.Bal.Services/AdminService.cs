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
		private readonly IAdminRepository _adminRepository;

		public AdminService(IAdminRepository adminRepository)
		{
			_adminRepository = adminRepository;
		}

		public string Hello()
		{
			return "Hello";
		}

		public IEnumerable<UserEntity> GetUsers()
		{
			return _adminRepository.GetUsers();
		}

		public void AddUser(UserModel user)
		{

			_adminRepository.AddUser(user);
		}

		public void DeleteUser(UserModel user)
		{
			_adminRepository.Delete(user);
		}

		public void UpdateUser(UserModel user)
		{
			_adminRepository.Change(user);
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

		void IAdminService.ChangeUserData(UserModel user)
		{
			throw new NotImplementedException();
		}

		void IAdminService.AdminData(UserModel user)
		{
			throw new NotImplementedException();
		}
	}
}
