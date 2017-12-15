using System.Collections.Generic;
using Animal.Common.Models.Data;

namespace Animal.Data.Interfaces
{
	public interface INewsRepository
	{
		IEnumerable<ParticularNewsIntoBoardEntity> GetNews();
		void Add(ParticularNewsIntoBoardEntity news);
	}
}
