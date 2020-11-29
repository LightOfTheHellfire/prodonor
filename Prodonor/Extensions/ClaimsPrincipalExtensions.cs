using System;
using System.Security.Claims;

namespace Prodonor.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static int GetUserId(this ClaimsPrincipal principal)
        {
            if (principal?.FindFirst(ClaimsIdentity.DefaultNameClaimType).Value == null)
                throw new UnauthorizedAccessException();

            return int.Parse(principal?.FindFirst(ClaimsIdentity.DefaultNameClaimType).Value);
        }
    }
}
