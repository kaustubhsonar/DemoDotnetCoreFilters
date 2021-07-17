using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoDotnetCoreFilters.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoDotnetCoreFilters.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [Route("ping/{id}")]
        //[MyActionFilter("Home")]
        public ActionResult Ping(int id)
        {
            Console.WriteLine("1");
            return Ok($"Responce at : {DateTime.Now.ToString()} | id = {id.ToString()}");
        }
    }
}
