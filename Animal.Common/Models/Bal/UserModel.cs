using System.ComponentModel.DataAnnotations;

namespace Animal.Common.Models.Bal
{
	public class UserModel
	{
		public int Id { get; set; }
		[Display(Name = "First Name")]
		[Required]
		public string FirstName { get; set; }
		[Display(Name = "Last Name")]
		[Required]
		public string LastName { get; set; }
		[Display(Name = "Email")]
		[Required]
		public string Email { get; set; }
		[Required]
		public string Login { get; set; }
		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		public string Description { get; set; }
		public bool IsAdmin { get; set; }
		[Display(Name = "Created Date")]
		[DataType(DataType.DateTime)]
		public int CreatedDate { get; set; }	
	}
}
