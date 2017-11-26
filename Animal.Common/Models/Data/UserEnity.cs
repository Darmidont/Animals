namespace Animal.Common.Models.Data
{
	public class UserEnity
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Login { get; set; }
		public string Description { get; set; }
	}

	public class ParticularAnimalEnity
	{
		public int Id { get; set; }

		public string AnimalId { get; set; }
		public string AnimalTypePropertyId { get; set; }
		public string Value { get; set; }
	}

	public class KindOfAnimalEnity
	{
		public int Id { get; set; }
	}
}
