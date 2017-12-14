using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal.Common.Models.Bal;
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

		public IEnumerable<ParticularNewsIntoBoardEntity> GetParticularNews()
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


		public void Add(NewsBoardEntity news)
		{
			using (var dbCommand = Database.GetStoredProcCommand("dbo.spAddNews"))
			{
				Database.AddInParameter(dbCommand, "@Name", DbType.String, news.Name);
				Database.AddInParameter(dbCommand, "@Message", DbType.String, news.Message);
				Database.ExecuteNonQuery(dbCommand);
			}
		}
		
		public void Delete(NewsBoardEntity news)
		{
			using (var dbCommand = Database.GetStoredProcCommand("dbo.spDeleteNewsById"))
			{
				Database.AddInParameter(dbCommand, "@Id", DbType.Int32, news.Id);
				Database.ExecuteNonQuery(dbCommand);
			}
		}
		
		public void Update(NewsBoardEntity news)
		{
			using (var dbCommand = Database.GetStoredProcCommand("dbo.spUpdateNews"))
			{
			//	Database.AddInParameter(dbCommand,"@Id", DbType.Int32, news.Id);
				Database.AddInParameter(dbCommand, "@Name", DbType.String, news.Name);
				Database.AddInParameter(dbCommand, "@Message", DbType.String, news.Message);
				Database.ExecuteNonQuery(dbCommand);

			}
		}

		public IEnumerable<ParticularNewsIntoBoardEntity> GetNews(int NewsId)
		{
			throw new NotImplementedException();
		}
	}
}
