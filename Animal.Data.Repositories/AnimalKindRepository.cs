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
	public class AnimalKindRepository: Repository<AnimalKindEntity>, IAnimalKindRepository
	  
	{
		public AnimalKindRepository([Dependency(Constants.AnimalDatabase)]Database database): base(database)
		{ 
		}

		public IEnumerable<AnimalKindEntity> GetParticularAnimalStats()
		{
			var result = new List<AnimalKindEntity>();
			using (var dbCommand = Database.GetStoredProcCommand("dbo.[spGetKindAnimalStats]"))
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

		public void AddAnimalKind(AnimalKindModel animalKind)
		{
			using (var dbCommand = Database.GetStoredProcCommand("dbo.spAddAnimalKind"))
			{
				Database.AddInParameter(dbCommand, "@Name", DbType.String, animalKind.Name);
				Database.AddInParameter(dbCommand, "@PlannedNumberOfAnimals", DbType.Int32, animalKind.PlannedNumberOfAnimals);
			//	Database.AddInParameter(dbCommand, "@CurrentNumberOfAnimals", DbType.Int32, animalKind.CurrentNumberOfAnimals);
				Database.AddInParameter(dbCommand, "@DescriptionOFAnimals", DbType.String, animalKind.DescriptionOFAnimals);	
		        Database.ExecuteNonQuery(dbCommand);
			}

		}

		


		public IEnumerable<AnimalKindEntity> Animals(int particularAnimalId)
		{
			throw new NotImplementedException();
		}
	}
}
