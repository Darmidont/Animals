using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Bal.Interfaces
{
	public interface IAccountValidationService
	{
		bool IsEmailAlreadyExists(string email);
	}
}
