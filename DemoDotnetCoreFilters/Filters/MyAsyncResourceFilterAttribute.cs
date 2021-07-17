using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotnetCoreFilters.Filters
{
    public class MyAsyncResourceFilterAttribute : Attribute, IAsyncResourceFilter
    {
        private readonly string _name;

        public MyAsyncResourceFilterAttribute(string name)
        {
            _name = name;
        }

        public async Task OnResourceExecutionAsync(ResourceExecutingContext context, ResourceExecutionDelegate next)
        {
            Console.WriteLine($"ResourceFilter - before async - {_name} ");
            await next();
            Console.WriteLine($"ResourceFilter - after async - {_name} ");
        }
    }
}
