using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal.Common.Models.Data;
using Animal.Data.Interfaces;

namespace Animal.Data.Repositories
{
	public class AdminRepository : Repository<AdminEntity>, IAdminRepository
	{


		public IEnumerable<AdminEntity> Admin(int admin)
		{
			throw new NotImplementedException();
		}
	}
}
