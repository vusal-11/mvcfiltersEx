﻿using Microsoft.AspNetCore.Mvc.Filters;

namespace mvc_Filters.Filters
{
    public class LastEnterDateAttribute : Attribute, IResourceFilter
    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            context
                .HttpContext
                .Response
                .Cookies
                .Append("LastVisit"
                , DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));


        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
        }
    }
}
