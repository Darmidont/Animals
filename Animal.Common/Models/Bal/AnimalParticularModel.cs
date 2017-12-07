using System.ComponentModel.DataAnnotations;

namespace Animal.Common.Models.Bal
{
	public class AnimalParticularModel
	{
		public int Id { get; set; }

		public int AnimalTypeId { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public bool Alive { get; set; }
		[Required]
		public bool HasCollar { get; set; }

		[Required]
		public int HeartRhythms { get; set; }

		[Required]
		public int CaloriesBurned { get; set; }

		[Required]
		public int BreathingRate { get; set; }

		[Required]
		public int LastWeight { get; set; }
		[Required]
		public int CurrentNumberOfAnimals { get; set; }
		public string DescriptionOFAnimals { get; set; }
	
	}
}