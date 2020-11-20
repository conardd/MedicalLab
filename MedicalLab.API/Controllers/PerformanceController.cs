using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MedicalLab.API.Controllers
{
    /// <summary>
    /// api used to access performance reports
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PerformanceController : ControllerBase
    {
        // GET: api/<PerformanceController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
