using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal.Bal.Interfaces;
using Animal.Common.Models.Data;
using Animal.Data.Interfaces;

namespace Animal.Bal.Services
{
	public class TestService : ITestService
	{
		private readonly IUserRepository _userRepository;

		public TestService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}

		public string Hello()
		{
			return "Hello";
		}

		public IEnumerable<UserEnity> GetUsers()
		{
			return _userRepository.GetUsers();
		}
	}
}
