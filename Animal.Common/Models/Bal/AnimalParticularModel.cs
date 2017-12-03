using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Common.Models.Bal
{
	public class AnimalParticularModel
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public bool Alive { get; set; }

		[Required]
		public int HeartRhythms { get; set; }

		[Required]
		public int CaloriesBurned { get; set; }
 
		[Required]
		public int BreathingRate { get; set; }

		[Required]
		public int LastWeight { get; set; }


	}
}
