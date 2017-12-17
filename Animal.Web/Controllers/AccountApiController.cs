using System.Web.Http;
using Animal.Bal.Interfaces;
using Animal.Common.Models.Bal;

namespace Animal.Web.Controllers
{

	public class AccountApiController : ApiController
	{
		private readonly IAccountValidationService _accountValidationService;
		private readonly IUserService _userService;

		public AccountApiController(IAccountValidationService accountValidationService, IUserService userService)
		{
			_accountValidationService = accountValidationService;
			_userService = userService;
		}

		public bool Register(UserModel model)
		{
			if (ModelState.IsValid)
			{
				var isEmailAlreadyExists = _accountValidationService.IsEmailAlreadyExists(model.Email);
				if (isEmailAlreadyExists)
				{
					ModelState.AddModelError("Email", "Email already registered");
				}

				return true;
			}

			return false;
		}

		public bool Login(LoginModel model)
		{
			return  _userService.LoginUser(model);			
		}
	}
}