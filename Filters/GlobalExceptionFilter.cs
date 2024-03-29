﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Data.Common;

namespace mvc_Filters.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if(context.Exception is KeyNotFoundException || context.Exception is NullReferenceException)
            {
                context.Result = new RedirectResult("/home/welcome");
            }
            else if(context.Exception is DivideByZeroException)
            {
                context.Result = new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
            
        }
    }
}
