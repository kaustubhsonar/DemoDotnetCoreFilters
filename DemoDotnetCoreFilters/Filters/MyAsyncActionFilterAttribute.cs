using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotnetCoreFilters.Filters
{
    //Order implemented which decides the execution order lover the order it gets executed first
    public class MyAsyncActionFilterAttribute : Attribute, IAsyncActionFilter
    {
        private readonly string _name;
        public MyAsyncActionFilterAttribute(string name)
        {
            _name = name;

        }


        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            //context.ActionArguments["id"] = (int)context.ActionArguments["id"] + 1;
            Console.WriteLine($"ActionFilter - before async - {_name} ");
            await next();
            Console.WriteLine($"ActionFilter - after async - {_name} ");
        }
    }
}
