using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal.Common.Models.Data;

namespace Animal.Data.Interfaces
{
	public interface IAnimalKindRepository
	{

		IEnumerable<AnimalKindEntity> Animals { get; }
	}
}
