using System.Collections.Generic;
using Animal.Common.Models.Bal;

namespace Animal.Bal.Interfaces
{
	public interface INewsService
	{
		IEnumerable<ParticularNewsModel> GetNews();
		void AddNews(ParticularNewsModel news);
	}
}
