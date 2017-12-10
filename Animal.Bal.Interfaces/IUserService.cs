using System.Collections.Generic;
using Animal.Common.Models.Bal;
using Animal.Common.Models.Data;

namespace Animal.Bal.Interfaces
{
	public interface IUserService
	{
		IEnumerable<UserEntity> GetUsers();
		void AddUser(UserModel user);
        void Update(UserModel user);
		bool LoginUser(LoginModel loginModel);
	}
}

