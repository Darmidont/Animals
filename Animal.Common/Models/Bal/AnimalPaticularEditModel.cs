using System.Collections.Generic;

namespace Animal.Common.Models.Bal
{
	public class AnimalPaticularEditModel : AnimalParticularModel
	{
		public Dictionary<int,string> AnimalTypes { get; set; }

		public AnimalPaticularEditModel()
		{
			AnimalTypes = new Dictionary<int, string>();
		}
	}
}
