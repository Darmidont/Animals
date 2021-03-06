﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Common.Models.Bal
{
	public class ParticularNewsModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		[Required]
		[Display(Name = "Your message:")]
		public string Message { get; set; }
		[DataType(DataType.Time)]
	    public int Date{ get; set; }

	}
}
