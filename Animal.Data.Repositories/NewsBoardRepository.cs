﻿using System;
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


		public void Add(ParticularNewsModel newsModel)
		{
			using (var dbCommand = Database.GetStoredProcCommand("dbo.spAddNews"))
			{
				Database.AddInParameter(dbCommand, "@Name", DbType.String, newsModel.Name);
				Database.AddInParameter(dbCommand, "@Message", DbType.String, newsModel.Message);
			//	Database.AddInParameter(dbCommand, "@Email", DbType.String, newsModel.Email);
			
				//	Database.ExecuteNonQuery(dbCommand);
			}
		}

		public IEnumerable<ParticularNewsIntoBoardEntity> GetNews(int NewsId)
		{
			throw new NotImplementedException();
		}
	}
}
