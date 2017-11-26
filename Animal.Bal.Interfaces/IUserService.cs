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
		string Hello();
		IEnumerable<UserEnity> GetUsers();
		void AddUser(UserEnity user);
	}
}
