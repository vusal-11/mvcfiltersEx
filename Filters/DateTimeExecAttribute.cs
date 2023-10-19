using Microsoft.AspNetCore.Mvc.Filters;

namespace mvc_Filters.Filters
{
    public class DateTimeExecAttribute : Attribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
        }


        public void OnResultExecuting(ResultExecutingContext context)
        {

            context.HttpContext.Response.Headers.Add("DateTime", DateTime.Now.ToString("dddd-D-MMM-yyyy"));

        }




    }
}
