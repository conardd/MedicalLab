﻿using MedicalLab.ServiceInterface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;


namespace MedicalLab.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class LoginModel
    {
        private readonly IUserService Service;
        //private readonly IServiceProvider provider;
        

        public LoginModel(IUserService service)
        {
            Service = service;
            //service = userService;
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ApiResponse Login()
        { 
            var result = new ApiResponse();
            var user = Service.Login(this.UserName, this.Password);
            if (user == null)
            {
                result.Result = false;
                result.Message = "no user match";
            }
            else 
            {
                result.Result = true;
                result.Message = "";
                result.Value = user;
            }
            return result;
        }
        /// <summary>
        /// get user list by role, empty role return all users
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public ApiResponse GetUsers(string role)
        {
            var result = new ApiResponse();
            try
            {
                var users = Service.GetUsers();
                users = (users != null && !string.IsNullOrEmpty(role)) ? users.FindAll(u => u.Role == role) : users;
                result.Result = true;
                result.Message = "";
                result.Value = users;
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.Message = ex.ToString();
            }
           
            return result;
        }
    }
}
