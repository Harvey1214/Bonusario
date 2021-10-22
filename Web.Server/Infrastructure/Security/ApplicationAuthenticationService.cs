﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Havit.Diagnostics.Contracts;
using Havit.Bonusario.Facades.Infrastructure.Security.Authentication;
using Havit.Bonusario.Model.Security;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Havit.Bonusario.DataLayer.Repositories.Security;

namespace Havit.Bonusario.Web.Server.Infrastructure.Security
{
	/// <summary>
	/// Poskytuje uživatele z HttpContextu.
	/// </summary>
	public class ApplicationAuthenticationService : IApplicationAuthenticationService
	{
		private readonly IHttpContextAccessor httpContextAccessor;

		private readonly Lazy<User> userLazy;

		public ApplicationAuthenticationService(IHttpContextAccessor httpContextAccessor, IUserRepository userRepository)
		{
			this.httpContextAccessor = httpContextAccessor;

			userLazy = new Lazy<User>(() => userRepository.GetObject(GetCurrentUserId()));
		}

		public ClaimsPrincipal GetCurrentClaimsPrincipal()
		{
			return httpContextAccessor.HttpContext.User;
		}

		public User GetCurrentUser() => userLazy.Value;

		public int GetCurrentUserId()
		{
			var principal = GetCurrentClaimsPrincipal();
			Claim userIdClaim = principal.Claims.Single(claim => (claim.Type == "sub"));
			return Int32.Parse(userIdClaim.Value);
		}
	}
}
