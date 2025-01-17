﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havit.Data.EntityFrameworkCore.Attributes;

namespace Havit.Bonusario.Model
{
	[Cache]
	public class Employee
	{
		public int Id { get; set; }

		[MaxLength(100)]
		public string Name { get; set; }

		[MaxLength(255)]
		public string Email { get; set; }

		public DateTime Created { get; set; }

		public DateTime? Deleted { get; set; }
	}
}
