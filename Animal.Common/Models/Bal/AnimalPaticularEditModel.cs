using System.Collections.Generic;

using System.Web.Mvc;

namespace Animal.Common.Models.Bal
{
	public class AnimalPaticularEditModel : AnimalParticularModel
	{
		public List<SelectListItem> AnimalTypes { get; set; }

		public AnimalPaticularEditModel()
		{
			AnimalTypes = new List<SelectListItem>();
		}
	}
}
