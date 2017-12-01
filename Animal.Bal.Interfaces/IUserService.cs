using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal.Common.Models.Data;

namespace Animal.Bal.Interfaces
{
	public interface IUserService
	{
	//	string Hello();
		IEnumerable<UserEntity> GetUsers();
		void AddUser(UserEntity user);

	}
}

