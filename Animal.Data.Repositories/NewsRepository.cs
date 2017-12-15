using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal.Common;
using Animal.Common.Models.Bal;
using Animal.Common.Models.Data;
using Animal.Data.Interfaces;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.Unity;


namespace Animal.Data.Repositories
{
	public class NewsRepository : Repository<ParticularNewsIntoBoardEntity>, INewsRepository
	{
		public NewsRepository([Dependency(Constants.AnimalDatabase)] Database database) : base(database)
		{
		}

		public IEnumerable<ParticularNewsIntoBoardEntity> GetNews()
		{
			var result = new List<ParticularNewsIntoBoardEntity>();
			using (var dbCommand = Database.GetStoredProcCommand("dbo.[spGetBoardsNews]"))
			{
				using (var reader = Database.ExecuteReader(dbCommand))
				{
					if (reader.Read())
						result.Add(RowMapper.MapRow(reader));

					while (reader.Read())
						result.Add(RowMapper.MapRow(reader));
				}
			}
			return result;
		}


		public void Add(ParticularNewsIntoBoardEntity news)
		{
			using (var dbCommand = Database.GetStoredProcCommand("dbo.[spAddNews]"))
			{
				Database.AddInParameter(dbCommand, "@Name", DbType.String, news.Name);
				Database.AddInParameter(dbCommand, "@Message", DbType.String, news.Message);
				Database.ExecuteNonQuery(dbCommand);
			}
		}
	}
}
