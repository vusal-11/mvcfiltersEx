using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace mvc_Filters.Filters
{
    public class MyAuthorizationFiler : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var isLogin = context.HttpContext.Request.Query.Any(q => q.Key == "Name" && q.Value=="Admin");
            var isPassword = context.HttpContext.Request.Query.Any(q => q.Key == "Password" && q.Value=="P@ss123");

            if(!isLogin && !isPassword)
            {
                context.Result = new UnauthorizedResult();
            }

        }



    }
}
