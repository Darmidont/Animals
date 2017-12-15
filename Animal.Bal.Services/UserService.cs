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
using AutoMapper;

namespace Animal.Bal.Services
{
	public class UserService : IUserService
	{
		private readonly IUserRepository _userRepository;

		public UserService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}

		public IEnumerable<UserEntity> GetUsers()
		{
			return _userRepository.GetUsers();
		}

		public void AddUser(UserModel user)
		{
			var userEntity = Mapper.Map<UserEntity>(user);
			_userRepository.Add(userEntity);
		}

		public bool LoginUser(LoginModel loginModel)
		{
			var loginEntity = Mapper.Map<LoginEntity>(loginModel);
			return _userRepository.Login(loginEntity);
		}

		public void ChangeUser(UserModel user)
		{
			var userEntity = Mapper.Map<UserEntity>(user);
			_userRepository.Update(userEntity);
		}

		public void Update(UserModel user)
		{
			throw new NotImplementedException();
		}
	}
}
