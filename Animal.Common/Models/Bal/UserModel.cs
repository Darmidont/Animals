using System.ComponentModel.DataAnnotations;

namespace Animal.Common.Models.Bal
{
	public class UserModel
	{
		public int Id { get; set; }
		[Display(Name = "First name:")]
		[Required]
		public string FirstName { get; set; }
		[Display(Name = "Last name:")]
		[Required]
		public string LastName { get; set; }
		[Display(Name = "Email:")]
		[Required]
		public string Email { get; set; }
		[Display(Name = "Login:")]
		[Required]
		public string Login { get; set; }
		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		[Display(Name = "Description:")]
		public string Description { get; set; }
		[Display(Name = "Created date:")]
		[DataType(DataType.DateTime)]
		public int CreatedDate { get; set; }	
	}
}
