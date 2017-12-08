using System.ComponentModel.DataAnnotations;

namespace Animal.Common.Models.Bal
{
	public class AnimalKindModel
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public int PlannedNumberOfAnimals { get; set; }

		[Required]
		public int CurrentNumberOfAnimals { get; set; }

		//[Required]
		public string DescriptionOFAnimals { get; set; }
	}
}