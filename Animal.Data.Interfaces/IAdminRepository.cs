﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal.Common.Models.Bal;
using Animal.Common.Models.Data;

namespace Animal.Data.Interfaces
{
public interface IAdminRepository
	{
		IEnumerable<AdminEntity> Admin(int admin);

		void Delete(UserModel user);

		void Update(UserModel user);
	}
}
