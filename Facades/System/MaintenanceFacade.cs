﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Havit.Extensions.DependencyInjection.Abstractions;
using Havit.Bonusario.Contracts.System;
using Havit.Services.Caching;
using Microsoft.AspNetCore.Authorization;

namespace Havit.Bonusario.Facades.System
{
	[Service]
	[Authorize] // TODO Auth
	public class MaintenanceFacade : IMaintenanceFacade
	{
		private readonly ICacheService cacheService;

		public MaintenanceFacade(ICacheService cacheService)
		{
			this.cacheService = cacheService;
		}

		public Task ClearCache(CancellationToken cancellationToken = default)
		{
			cacheService.Clear();

			return Task.CompletedTask;
		}
	}
}
