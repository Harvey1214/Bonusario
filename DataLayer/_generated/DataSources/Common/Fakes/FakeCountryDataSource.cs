﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havit.Data.EntityFrameworkCore.Patterns.DataSources.Fakes;
using Havit.Data.EntityFrameworkCore.Patterns.SoftDeletes;
using Havit.Data.Patterns.Attributes;

namespace Havit.Bonusario.DataLayer.DataSources.Common.Fakes
{
	[Fake]
	[System.CodeDom.Compiler.GeneratedCode("Havit.Data.EntityFrameworkCore.CodeGenerator", "1.0")]
	public class FakeCountryDataSource : FakeDataSource<Havit.Bonusario.Model.Common.Country>, Havit.Bonusario.DataLayer.DataSources.Common.ICountryDataSource
	{
		public FakeCountryDataSource(params Havit.Bonusario.Model.Common.Country[] data)
			: this((IEnumerable<Havit.Bonusario.Model.Common.Country>)data)
		{			
		}

		public FakeCountryDataSource(IEnumerable<Havit.Bonusario.Model.Common.Country> data, ISoftDeleteManager softDeleteManager = null)
			: base(data, softDeleteManager)
		{
		}
	}
}