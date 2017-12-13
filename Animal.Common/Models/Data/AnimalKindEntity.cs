namespace Animal.Common.Models.Data
{
	public class AnimalKindEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int PlannedNumberOfAnimals { get; set; }
		public  int CurrentNumberOfAnimals { get; set; }
		public string DescriptionOFAnimals { get; set; }
	}
}