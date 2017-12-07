using System.ComponentModel.DataAnnotations;

namespace Animal.Common.Models.Data
{
	public class UserEntity
	{

	
		public int Id { get; set; }

		[Display(Name = "First Name")]
		public string FirstName { get; set; }

		[Display(Name = "Last Name")]
		public string LastName { get; set; }

		[Display(Name = "Email")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Display(Name = "Login")]
		public string Login { get; set; }

		[Display(Name = "Password")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Display(Name = "Description")]
		public string Description { get; set; }

		[Display(Name = "Created Date")]
		[DataType(DataType.DateTime)]
		public int CreatedDate { get; set; }
		[Display(Name = "Last login date")]
		[DataType(DataType.DateTime)]


		public int LastLoginDate { get; set; }
	}
}
