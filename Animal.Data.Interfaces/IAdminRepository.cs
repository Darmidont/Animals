using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Data.Interfaces
{
public interface IAdminRepository
	{
		IEnumerable<AdminEntity> Admin(int admin);
	}
}
