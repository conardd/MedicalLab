using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalLab.Model;
using MedicalLab.ServiceInterface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MedicalLab.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService service;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userService"></param>
        public UserController(IUserService userService)
        {
            service = userService;
        }
       /// <summary>
       /// log in
       /// </summary>
       /// <param name="playLoad"></param>
        // POST api/<UserController>
        [HttpPost]
        public ApiResponse Post([FromBody] LoginModel playLoad)
        {
            return service.Login(playLoad);            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

       
    }
}
