using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotnetCoreFilters.Filters
{
    public class MyAsyncResultFilterAttribute : Attribute, IAsyncResultFilter
    {
        private readonly string _name;

        public MyAsyncResultFilterAttribute(string name)
        {
            _name = name;
        }
        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            Console.WriteLine($"ResultFilter - before async - {_name} ");
            await next();
            Console.WriteLine($"ResultFilter - after async - {_name} ");
        }
    }
}
