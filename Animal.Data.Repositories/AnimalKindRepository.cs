using System.Collections.Generic;
using System.Data;
using System.Linq;
using Animal.Common;
using Animal.Common.Models.Data;
using Animal.Data.Interfaces;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.Unity;

namespace Animal.Data.Repositories
{
	public class AnimalKindRepository : Repository<AnimalKindEntity>, IAnimalKindRepository

	{
		public AnimalKindRepository([Dependency(Constants.AnimalDatabase)] Database database) : base(database)
		{
		}


		public IEnumerable<AnimalKindEntity> GetAnimalTypes()
		{
			var result = new List<AnimalKindEntity>();
			using (var dbCommand = Database.GetStoredProcCommand("dbo.[spGetAnimalTypes]"))
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

		/*	public IEnumerable<AnimalKindEntity> GetKindOfAnimalStats()
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
		}*/

		public void Add(AnimalKindEntity animalKind)
		{
			using (var dbCommand = Database.GetStoredProcCommand("dbo.spAddAnimalKind"))
			{
				Database.AddInParameter(dbCommand, "@Name", DbType.String, animalKind.Name);
				Database.AddInParameter(dbCommand, "@PlannedNumber", DbType.Int32, animalKind.PlannedNumberOfAnimals);
				Database.AddInParameter(dbCommand, "@Description", DbType.String, animalKind.DescriptionOFAnimals);
				Database.ExecuteNonQuery(dbCommand);
			}
		}

		public void Update(AnimalKindEntity animalKind)
		{
			using (var dbCommand = Database.GetStoredProcCommand("dbo.spUpdateAnimalKind"))
			{
				Database.AddInParameter(dbCommand, "@Id", DbType.Int32, animalKind.Id);
				Database.AddInParameter(dbCommand, "@Name", DbType.String, animalKind.Name);
				Database.AddInParameter(dbCommand, "@PlannedNumber", DbType.Int32, animalKind.PlannedNumberOfAnimals);
				Database.AddInParameter(dbCommand, "@Description", DbType.Int32, animalKind.DescriptionOFAnimals);
				Database.ExecuteNonQuery(dbCommand);
			}
		}

		public void Delete(AnimalKindEntity animalKind)
		{
			using (var dbCommand = Database.GetStoredProcCommand("dbo.spDeleteKindOfAnimalById"))
			{
				Database.AddInParameter(dbCommand, "@Id", DbType.Int32, animalKind.Id);
				Database.ExecuteNonQuery(dbCommand);
			}
		}

		public AnimalKindEntity GetById(int id)
		{
			var result = new List<AnimalKindEntity>();
			using (var dbCommand = Database.GetStoredProcCommand("dbo.[spGetAnimalTypes]"))
			{
				Database.AddInParameter(dbCommand, "@Id", DbType.Int32, id);
				using (var reader = Database.ExecuteReader(dbCommand))
				{
					if (reader.Read())
						result.Add(RowMapper.MapRow(reader));

					while (reader.Read())
						result.Add(RowMapper.MapRow(reader));
				}
			}
			return result.FirstOrDefault();
		}
	}
}