using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal.Bal.Interfaces;
using Animal.Common.Models.Bal;
using Animal.Common.Models.Data;

namespace Animal.Bal.Services
{
	public class NewsBoardService : INewsBoardService
	{
		public IEnumerable<NewsBoardEntity> NewsBoard()
		{
			throw new NotImplementedException();
		}

		public void AddBoard(ParticularNewsModel modelId)
		{
			throw new NotImplementedException();
		}

		public void DeleteBoard(ParticularNewsModel modelId)
		{
			throw new NotImplementedException();
		}

		IEnumerable<ParticularNewsIntoBoardEntity> INewsBoardService.NewsBoard()
		{
			throw new NotImplementedException();
		}
	}
}
