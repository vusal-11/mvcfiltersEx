using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace mvc_Filters.Filters
{
    public class ApiKeyQueryAuthorization : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {

            var isAuthorizaed = context
                .HttpContext.
                Request.
                Query.
                Any(q => q.Key == "apiKey" && q.Value == "pass12345");
            if(!isAuthorizaed)
            {
                context.Result = new UnauthorizedResult();
            }


        }
    }

}
