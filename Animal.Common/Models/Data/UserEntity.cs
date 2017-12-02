namespace Animal.Common.Models.Data
{
	public class UserEntity
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
		public string Description { get; set; }
		public int CreatedDate { get; set; }
		public int LastLoginDate { get; set; }
	}
}
