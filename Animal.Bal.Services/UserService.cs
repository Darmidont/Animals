using System;
using System.Collections;
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
	public class UserService : IUserService
	{
		private readonly IUserRepository _userRepository;

		public UserService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}

		public string Hello()
		{
			return "Hello";
		}

		public IEnumerable<UserEntity> GetUsers()
		{
			return _userRepository.GetUsers();
		}

		public void AddUser(UserModel user)
		{

			_userRepository.AddUser(user);
		}

		public void DeleteUser(UserModel user)
		{
			_userRepository.Delete(user);
		}

		public void ChangeUser(UserModel user)
		{
			_userRepository.Change(user);
		}

		public void ChangeUserData(UserModel user)
		{
			throw new NotImplementedException();
		}
	}
}
