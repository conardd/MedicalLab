using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalLab.Model;
using MedicalLab.ServiceInterface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MedicalLab.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>

    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService Service;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userService"></param>
        public UserController(IUserService service)
        {
            Service = service;
        }
        
                /// <summary>
        /// log in user
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("[controller]/login")]
        public ApiResponse Login(string userName, string password)
        {
            //LoginModel payload = LoginModel.Create();
            var userModel = new LoginModel(Service) { UserName = userName, Password = password };

            //return null;
            return userModel.Login();
        }

        /// <summary>
        /// get users list by role get all users where role = null || string.Empty
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        //[Authorize]
        [HttpGet]
        [Route("[controller]/GtalAll")]
        public ApiResponse GetUsers(string role = null)
        {
            var userModel = new LoginModel(Service);

            return userModel.GetUsers(role);
        }

        /// <summary>
        /// add internal user
        /// </summary>
        /// <returns></returns>
        //[Authorize]
        [HttpPost]
        [Route("[controller]/AddUser")]
        public ApiResponse AddUser()
        {
            return null;
        }
        /// <summary>
        /// new customer register
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT api/<UserController>/5
        //[Authorize]
        [HttpPost]
        [Route("[controller]")]
        public ApiResponse Register(int id, [FromBody] string value)
        {
            return null;
        }
    }
}
