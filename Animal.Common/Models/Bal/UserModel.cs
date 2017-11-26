using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Common.Models.Bal
{
	public class UserModel
	{
		public int Id { get; set; }
		[Required]
		public string FirstName { get; set; }
		public string LastName { get; set; }
		[Required]
		public string Email { get; set; }
		[Required]
		public string Login { get; set; }

		public string Description { get; set; }
	}
}
