using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal.Common;
using Animal.Common.Models.Data;
using Animal.Data.Interfaces;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.Unity;

namespace Animal.Data.Repositories
{
	public class AnimalParticularRepository : Repository<AnimalParticularEntity>, IAnimalParticularRepository
	{

		public AnimalParticularRepository([Dependency(Constants.AnimalDatabase)]Database database): base(database)
		{
		}


		public IEnumerable<AnimalParticularEntity> GetParticularAnimalStats()
		{
			var result = new List<AnimalParticularEntity>();
			using (var dbCommand = Database.GetStoredProcCommand("dbo.[spGetParticularAnimalStats]"))
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



	}
}