using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal.Common.Models.Data;
using Animal.Data.Interfaces;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Animal.Data.Repositories
{
	public class NewsBoardRepository: Repository<ParticularNewsIntoBoardEntity>, IParticularNewsIntoBoardService
	{
		public NewsBoardRepository(Database database) : base(database)
		{
		}

		public IEnumerable<ParticularNewsIntoBoardEntity> GetNews(int NewsId)
		{
			throw new NotImplementedException();
		}
	}
}
