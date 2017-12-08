using System.Collections.Generic;
using Animal.Common.Models.Data;

namespace Animal.Data.Interfaces
{
	public interface IUserRepository
	{
		IEnumerable<UserEntity> GetUsers();
		void Add(UserEntity user);
		void Authorize(UserEntity user);
		void Update(UserEntity user);
	}
}