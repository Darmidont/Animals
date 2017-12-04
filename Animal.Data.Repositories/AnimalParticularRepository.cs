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



		public void AddAnimalKind(AnimalParticularModel animalParticular)
		{
			using (var dbCommand = Database.GetStoredProcCommand("dbo.spAddAnimalKind"))
			{
				Database.AddInParameter(dbCommand, "@Name", DbType.String, animalParticular.Name);
				Database.AddInParameter(dbCommand, "@PlannedNumberOfAnimals", DbType.Int32, animalParticular.Alive);
				Database.AddInParameter(dbCommand, "@CurrentNumberOfAnimals", DbType.Int32, animalParticular.CurrentNumberOfAnimals);
				Database.AddInParameter(dbCommand, "@DescriptionOFAnimals", DbType.String, animalParticular.DescriptionOFAnimals);
				Database.AddInParameter(dbCommand, "@LastWeight", DbType.Int32, animalParticular.LastWeight);
				Database.ExecuteNonQuery(dbCommand);

	/*	public int Id { get; set; }
		public string Name { get; set; }
		public bool Alive { get; set; }
		public int HeartRhythms { get; set; }
		public int CaloriesBurned { get; set; }
		public int BreathingRate { get; set; }
		public int LastWeight { get; set; }*/
	}

		}

		public IEnumerable<AnimalParticularEntity> GetAnimals(int animalKindId)
		{
			throw new NotImplementedException();
		}
	}
}