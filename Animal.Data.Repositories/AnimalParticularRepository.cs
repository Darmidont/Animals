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



		public IEnumerable<AnimalParticularEntity> GetAnimalsParticular()
		{
			var result = new List<AnimalParticularEntity>();
			using (var dbCommand = Database.GetStoredProcCommand("dbo.[spGetListOfParticularAnimals]"))
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





		public void Add(AnimalParticularEntity animalParticular)
		{
			using (var dbCommand = Database.GetStoredProcCommand("dbo.spAddParticularAnimal"))
			{

			//	Database.AddInParameter(dbCommand, "@AnimalKindId", DbType.Int32, animalParticular.AnimalKindId);
				Database.AddInParameter(dbCommand, "@HasCollar", DbType.Int32, animalParticular.HasCollar);
				Database.AddInParameter(dbCommand, "@Name", DbType.String, animalParticular.Name);
				//Database.AddInParameter(dbCommand, "@IsAlive", DbType.Int32, animalParticular.IsAlive);
				//Database.AddInParameter(dbCommand, "@HeartRhythms", DbType.Int32, animalParticular.HeartRhythms);
			//	Database.AddInParameter(dbCommand, "@CaloriesBurnedPerDay", DbType.String, animalParticular.CaloriesBurnedPerDay);
				//Database.AddInParameter(dbCommand, "@BreathingRatePerMinute", DbType.String, animalParticular.BreathingRatePerMinute);
				Database.AddInParameter(dbCommand, "@LastWeight", DbType.Int32, animalParticular.LastWeight);
				Database.AddInParameter(dbCommand, "@Description", DbType.Int32, animalParticular.Description);
				Database.ExecuteNonQuery(dbCommand);
	}

		}


		public void Update(AnimalParticularEntity animalParticular)
		{

			using (var dbCommand = Database.GetStoredProcCommand("dbo.spUpdateAnimalParticular"))
			{
				//Database.AddInParameter(dbCommand, "@AnimalKindId", DbType.Int32, animalParticular.AnimalKindId);
				Database.AddInParameter(dbCommand, "@HasCollar", DbType.Int32, animalParticular.HasCollar);
				Database.AddInParameter(dbCommand, "@Name", DbType.String, animalParticular.Name);
				//Database.AddInParameter(dbCommand, "@IsAlive", DbType.Int32, animalParticular.IsAlive);
				//Database.AddInParameter(dbCommand, "@HeartRhythms", DbType.Int32, animalParticular.HeartRhythms);
				//	Database.AddInParameter(dbCommand, "@CaloriesBurnedPerDay", DbType.String, animalParticular.CaloriesBurnedPerDay);
				//Database.AddInParameter(dbCommand, "@BreathingRatePerMinute", DbType.String, animalParticular.BreathingRatePerMinute);
				Database.AddInParameter(dbCommand, "@LastWeight", DbType.Int32, animalParticular.LastWeight);
				Database.AddInParameter(dbCommand, "@Description", DbType.Int32, animalParticular.Description);
				Database.ExecuteNonQuery(dbCommand);
			}
		}


		public void Delete(AnimalParticularEntity animalParticular)
		{
			using (var dbCommand = Database.GetStoredProcCommand("dbo.spDeleteParticularAnimalById"))
			{
				Database.AddInParameter(dbCommand, "@Id", DbType.Int32, animalParticular.Id);
				Database.ExecuteNonQuery(dbCommand);
			}
		}
	

		public IEnumerable<AnimalParticularEntity> GetAnimals(int animalKindId)
		{
			throw new NotImplementedException();
		}
	}
}