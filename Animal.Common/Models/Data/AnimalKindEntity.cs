namespace Animal.Common.Models.Data
{
	public class AnimalKindEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int PlannedNumberOfAnimals { get; set; }

		public readonly int CurrentNumberOfAnimals;
		public string DescriptionOFAnimals { get; set; }
	}
}