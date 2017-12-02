using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Animal.Common.Models.Data
{
	public class AnimalKindEntity
	{

		public int Id { get; set; }
		public int PlannedNumberOfAnimals { get; set; }
		public int CurrentNumberOfAnimals { get; set; }
		public string DescriptionOFAnimals { get; set; }
	}
}
