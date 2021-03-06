﻿using MedicalLab.Entity;
using MedicalLab.ServiceInterface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace MedicalLab.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class LoginModel
    {
        private readonly IUserService Service;
        //private readonly IServiceProvider provider;
        
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="service"></param>
        public LoginModel(IUserService service)
        {
            Service = service;
            this.User = new User();            
        }
        /// <summary>
        /// 
        /// </summary>
        public User User { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ApiResponse Login()
        { 
            var result = new ApiResponse();
            var user = Service.Login(this.User.UserName, this.User.Password);
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
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ApiResponse Add()
        {   
            var result = new ApiResponse();
            try
            {
                var user = this.User;
                Service.Add(user);
                result.Result = true;
                result.Value = user;
            }
            catch (Exception ex)
            {
                result.Message = ex.ToString();
            }
            return result;
        }
    }
}
