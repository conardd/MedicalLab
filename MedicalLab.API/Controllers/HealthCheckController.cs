using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedicalLab.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {[HttpGet]
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Check()
        {
            return "Health";
        }
    }
}
