using System.Collections.Generic;
using Animal.Common.Models.Bal;
using Animal.Common.Models.Data;

namespace Animal.Bal.Interfaces
{
	public interface IAdminService
	{
		IEnumerable<UserEntity> GetUsers();
		void AddUser(UserModel user);
		void DeleteUser(UserModel user);
		void UpdateUserData(UserModel user);
		void AddNews(ParticularNewsModel news);
		void DeleteNews(ParticularNewsModel news);
	}
}