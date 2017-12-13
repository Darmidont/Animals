using System.ComponentModel.DataAnnotations;

namespace Animal.Common.Models.Bal
{
	public class AnimalKindModel
	{
		public int Id { get; set; }

		[Display(Name = "Name of kind:")]
		[Required]
		public string Name { get; set; }

		[Display(Name = "Planned number of animals:")]
		[Required]
		public int PlannedNumberOfAnimals { get; set; }

		[Display(Name = "Current number of animals:")]
	    public 	int CurrentNumberOfAnimals { get; set; }

		[Display(Name = "Description of animals:")]
		public string DescriptionOFAnimals { get; set; }
	}
}