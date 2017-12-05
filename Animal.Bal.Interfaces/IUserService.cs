using System.Collections.Generic;
using Animal.Common.Models.Bal;
using Animal.Common.Models.Data;

namespace Animal.Bal.Interfaces
{
	public interface IUserService
	{
	//	string Hello();
		IEnumerable<UserEntity> GetUsers();
		void AddUser(UserModel user);
		void DeleteUser(UserModel user);
        void Update(UserModel user);
	}
}

