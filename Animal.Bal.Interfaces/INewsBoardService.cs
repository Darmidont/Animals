using System.Collections.Generic;
using Animal.Common.Models.Bal;
using Animal.Common.Models.Data;

namespace Animal.Bal.Interfaces
{
	public interface INewsBoardService
	{
		IEnumerable<ParticularNewsIntoBoardEntity> NewsBoard();
		void AddBoard(ParticularNewsModel modelId);
		void DeleteBoard(ParticularNewsModel modelId);
	}
}