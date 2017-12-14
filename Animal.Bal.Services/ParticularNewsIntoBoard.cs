using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal.Bal.Interfaces;
using Animal.Common.Models.Bal;
using Animal.Common.Models.Data;
using AutoMapper;

namespace Animal.Bal.Services
{
	public class ParticularNewsIntoBoard : IParticularNewsIntoBoardService
	{
		private readonly IParticularNewsIntoBoardService _newsRepository;

		public ParticularNewsIntoBoard(IParticularNewsIntoBoardService newsRepository)
		{
			_newsRepository = newsRepository;
		}

		public void AddNews(ParticularNewsModel news)
		{
			var newsEntity = Mapper.Map<ParticularNewsIntoBoardEntity>(news);
			_newsRepository.AddNews(newsEntity);
		}

		//	public void ChangeNews(ParticularNewsModel news)
		//{

		//	}

		//	public void DeleteNews(ParticularNewsModel news)
		//{

		//	}

		public IEnumerable<ParticularNewsModel> GetNews()
		{
			var newsDbTypes = _newsRepository.GetNews();
			return Mapper.Map<IEnumerable<ParticularNewsIntoBoardEntity>, IEnumerable<ParticularNewsModel>>(newsDbTypes);
		}



	}
}
