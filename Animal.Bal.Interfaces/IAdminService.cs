using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal.Common.Models.Bal;
using Animal.Common.Models.Data;

namespace Animal.Bal.Interfaces
{
	public interface IAdminService
	{
		IEnumerable<UserEntity> GetUsers();
		void AddUser(UserModel user);
		void DeleteUser(UserModel user);
		void ChangeUserData(UserModel user);

		void AdminData(UserModel user);

		void ChangeAdminData(AdminModel admin);

	}
}
