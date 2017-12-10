using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Common.Models.Bal
{
public class LoginViewModel
	{

		[Required]
		[Display(Name = "Login")]
		public string Login { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[DataType(DataType.Time)]
		public string ReturnUrl { get; set; }
	}
}
