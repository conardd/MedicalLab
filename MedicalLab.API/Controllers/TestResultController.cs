using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using MedicalLab.Entity;
using MedicalLab.Model;
using MedicalLab.ServiceInterface;
using Microsoft.AspNetCore.Mvc;


namespace MedicalLab.API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class TestResultController : ControllerBase
    {
        //private readonly ITestResultService service;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="testResultService"></param>
        //public TestResultController(ITestResultService testResultService)
        //{
        //    service = testResultService;
        //}
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ApiResponse Get()
        {
            return null;
            //return service.Get();            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="playLoad"></param>
        /// <returns></returns>
        [HttpPost]
        public ApiResponse Post([FromBody] TestResultModel payLoad)
        {
            return null;
            //return service.Add(payLoad.TestResult);
        }
    }
}
