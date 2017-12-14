﻿using System.Collections.Generic;
using Animal.Bal.Interfaces;
using Animal.Common.Models.Bal;
using Animal.Common.Models.Data;
using Animal.Data.Interfaces;
using AutoMapper;

namespace Animal.Bal.Services
{
	public class ParticularNewsIntoBoard : IParticularNewsIntoBoardService
	{
		private readonly IParticularNewsIntoBoardRepository _newsRepository;

		public ParticularNewsIntoBoard(IParticularNewsIntoBoardRepository newsRepository)
		{
			_newsRepository = newsRepository;
		}

		public void AddNews(ParticularNewsModel news)
		{
			var newsEntity = Mapper.Map<ParticularNewsIntoBoardEntity>(news);
			_newsRepository.Add(newsEntity);
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