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
		[Display(Name = "Is alive(true or false):")]
		public bool IsAlive { get; set; }
		[Required]
		[Display(Name = "Has collar(true or false):")]
		public bool HasCollar { get; set; }
		public int HeartRhythms { get; set; }
		public int CaloriesBurned { get; set; }
		public int BreathingRate { get; set; }
		[Required]
		[Display(Name = "Last weight:")]
		public int LastWeight { get; set; }
		public string DescriptionOFAnimals { get; set; }	
	}
}