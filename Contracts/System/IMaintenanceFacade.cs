﻿using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using Havit.ComponentModel;

namespace Havit.Bonusario.Contracts.System
{
	[ApiContract]
	public interface IMaintenanceFacade
	{
		Task ClearCache(CancellationToken cancellationToken = default);
	}
}