using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

		[Required]
		public string DescriptionOFAnimals { get; set; }

	}
}
