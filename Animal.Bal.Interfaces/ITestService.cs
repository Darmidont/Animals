using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal.Common.Models.Data;

namespace Animal.Bal.Interfaces
{
	public interface ITestService
	{
		string Hello();
		IEnumerable<UserEnity> GetUsers();
	}
}
