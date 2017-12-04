using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal.Common.Models.Bal;

namespace Animal.Bal.Interfaces
{
	public interface IParticularNewsIntoBoardService
	{

		IEnumerable<ParticularNewsIntoBoardEntity> GetNews();

		void AddNews(NewsIntoBoardParticularEntity news);
		void DeleteNews(NewsIntoBoardParticularEntity news);
		void ChangeNews(NewsIntoBoardParticularEntity news);
	}
}
