using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPS.Framework.Exceptions;
using UPS.Framework.Options;
using UPS.Framework.Options.Models;

namespace UPS.Framework.Models
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class UPSAuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            try
            {
                var ApiToken = context.HttpContext.Request.Headers["Authorization"].FirstOrDefault();
                ApiToken = ApiToken.Replace("Bearer ", "");
                ApiToken = ApiToken.Replace("Bearer", "");
                AuthorizationOption authorizationOption = OptionService.GetOption<AuthorizationOption>();
                UserOption user = authorizationOption.Users.FirstOrDefault(x => x.Token == ApiToken);
                if (user == null)
                {
                    throw new UPSExceptionAuthenticationFailed("Invalid ApiToken");
                }
                context.HttpContext.Request.Headers.TryAdd("UserId", user.UserId.ToString());
            }
            catch (Exception ex)
            {
                throw new UPSExceptionAuthenticationFailed("Invalid ApiToken");
            }
        }

    }
}
