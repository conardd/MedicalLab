using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalLab.Entity;
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
        protected LoginModel userModel;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userService"></param>
        public UserController(IUserService service)
        {
            Service = service;
            userModel = new LoginModel(Service);
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
            userModel.User.UserName = userName;
            userModel.User.Password = password;
            return userModel.Login();
        }

        /// <summary>
        /// get users list by role get all users where role = null || string.Empty
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        //[Authorize]
        [HttpGet]
        [Route("[controller]")]
        public ApiResponse GetUsers(string role = null)
        {            
            return userModel.GetUsers(role);
        }

        /// <summary>
        /// add internal user
        /// </summary>
        /// <returns></returns>
        //[Authorize]
        [HttpPost]
        [Route("[controller]/Add")]
        public ApiResponse AddUser([FromBody]User payload)
        {
            userModel.User = payload;
            
            return userModel.Add();            
        }
        /// <summary>
        /// new customer register
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>          
        [HttpPost]
        [Route("[controller]")]
        public ApiResponse Register([FromBody] string value)
        {
            return null;
        }
    }
    
}
