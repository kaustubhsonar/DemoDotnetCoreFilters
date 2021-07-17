using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotnetCoreFilters.Filters
{
    public class MyActionFilterAttribute : Attribute, IActionFilter, IOrderedFilter
    {
        private readonly string _name;
        public MyActionFilterAttribute(string name, int order)
        {
            _name = name;
            Order = order;
        }

        public int Order { get; set; }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"ActionFilter - after - {_name}");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"ActionFilter - before - {_name}");
        }
    }
}
