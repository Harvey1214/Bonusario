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
using Havit.Data.Patterns.DataEntries;

namespace Havit.Bonusario.DataLayer.DataEntries.Security
{
	[System.CodeDom.Compiler.GeneratedCode("Havit.Data.EntityFrameworkCore.CodeGenerator", "1.0")]
	public interface IRoleEntries : IDataEntries
	{
		Havit.Bonusario.Model.Security.Role SystemAdministrator { get; }
			
		Havit.Bonusario.Model.Security.Role UserSettingsAdministrator { get; }
			
	}
}