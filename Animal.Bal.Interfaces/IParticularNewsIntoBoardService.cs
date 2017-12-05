using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal.Common.Models.Bal;
using Animal.Common.Models.Data;

namespace Animal.Bal.Interfaces
{
	public interface IParticularNewsIntoBoardService
	{

		IEnumerable<ParticularNewsIntoBoardEntity> GetNews();

		void AddNews(ParticularNewsModel news);
		void DeleteNews(ParticularNewsModel news);
		void ChangeNews(ParticularNewsModel news);

	}
}
