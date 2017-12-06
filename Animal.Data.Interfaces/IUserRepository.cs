﻿using System.Collections.Generic;
using Animal.Common.Models.Bal;
using Animal.Common.Models.Data;

namespace Animal.Data.Interfaces
{
	public interface IUserRepository
	{
		IEnumerable<UserEntity> GetUsers();


		void Add(UserModel user);

		//void Delete(UserModel user);
		void Update(UserModel user);
		
	}
}