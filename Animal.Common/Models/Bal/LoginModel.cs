using System.ComponentModel.DataAnnotations;

namespace Animal.Common.Models.Bal
{
	public class LoginModel
	{
		[Display(Name = "Email")]
		[Required]
		public string Email { get; set; }
		[Required]
		[Display(Name = "Password")]
		public string Password { get; set; }
	}
}
