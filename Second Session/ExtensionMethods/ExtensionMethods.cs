using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;

namespace Second_Session.ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static string GetUserFullName(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("FullName");
            return claim != null ? claim.Value : string.Empty;
        }
    }
}