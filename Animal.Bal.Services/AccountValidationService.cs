using Animal.Bal.Interfaces;
using Animal.Data.Interfaces;

namespace Animal.Bal.Services
{
	public class AccountValidationService: IAccountValidationService
	{
		private readonly IUserRepository _userRepository;

		public AccountValidationService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}

		public bool IsEmailAlreadyExists(string email)
		{
			return _userRepository.IsEmailAlreadyExists(email);
		}
	}
}
