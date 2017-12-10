namespace Animal.Common.Models.Data
{
	public class AnimalParticularEntity
	{
		public int Id { get; set; }
		public int AnimalTypeId { get; set; }
		public string Name { get; set; }
		public bool HasCollar { get; set; }
		public bool Alive { get; set; }
		public int HeartRhythms { get; set; }
		public int CaloriesBurned { get; set; }
		public int BreathingRate { get; set; }
		public int LastWeight { get; set; }
		public string Description { get; set; }
	}
}