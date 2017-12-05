using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Common.Models.Bal
{
	public class AdminModel
	{
		public int Id { get; set; }

		public int AdminId { get; set; }

		[Required]
		public string Login { get; set; }

		[Required]
		public string Password { get; set; }

	}
}
