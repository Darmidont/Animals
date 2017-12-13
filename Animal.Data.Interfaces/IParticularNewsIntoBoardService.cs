using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal.Common.Models.Data;

namespace Animal.Data.Interfaces
{
	public interface IParticularNewsIntoBoardService
	{
		IEnumerable<ParticularNewsIntoBoardEntity> GetNews(int NewsId);
		void Add(NewsBoardEntity news);
		void Delete(NewsBoardEntity news);
		void Update(NewsBoardEntity news);
	}
}
