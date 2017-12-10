using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Common.Models.Data
{
  public class NewsBoardEntity
    {

		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime DateOfCreation { get; set; }
		public string Message { get; set; }
    }
}
