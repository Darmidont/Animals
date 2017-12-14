using System.ComponentModel.DataAnnotations;

namespace Animal.Common.Models.Bal
{
	public class LoginModel
	{
		[Display(Name = "Email")]
		[Required]
		public string Email { get; set; }
		
		[Display(Name = "Password")]
		[Required]
		public string Password { get; set; }
	}
}
