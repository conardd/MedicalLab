using MedicalLab.Entity;
using MedicalLab.Model;
using MedicalLab.RepositoryInterface;
using MedicalLab.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Text;
using MedicalLab.Repository;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;

namespace MedicalLab.Service
{
    public class UserService : IUserService
    {

        private IUsersRepository repo;
        // private DataBaseSettings settings;
        /// <summary>
        /// default constructor
        /// </summary>
        public UserService()
        { }
        public UserService(DataBaseSettings setting)
        {
            //var store = new RepositoryStore(setting);
            repo = new UserRepository(setting);
        }

        /// <summary>
        /// user log in
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public User GetUserByName(string userName)
        {
            return repo.GetUserByName(userName);
        }
        /// <summary>
        /// get all users
        /// </summary>
        /// <returns></returns>
        public List<User> GetUsers()
        {
            return repo.GetUsers();
        }
        /// <summary>
        /// add new user
        /// </summary>
        /// <param name="user"></param>
        public void Add(User user)
        {
            repo.Add(user);
        }
        /// <summary>
        /// remove user
        /// </summary>
        /// <param name="user"></param>
        public void RemoveUser(User user)
        {
            repo.RemoveUser(user);
        }
        /// <summary>
        /// update user
        /// </summary>
        /// <param name="user"></param>
        public void Update(User user)
        {
            repo.Update(user);
        }

        public ApiResponse Login(LoginModel login)
        {
            var result = new ApiResponse() { Result = true };
            var user = repo.GetUserByName(login.UserName);
#if DEBUG
            user = new User() { UserName = login.UserName, Roles = "employee", Email = "tester@test.com", Password = login.Password , Active = true};
#endif
            result.Result = user != null && user.Password == login.Password && user.Active;
            if (result.Result)
                result.Value = generateJwtToken(user);
            else
                result.Message = "user is not valid";
            return result;
        }

        private string generateJwtToken(User user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("codechallengecodechallengecodechallenge");
            var claims = new ClaimsIdentity(new[] { new Claim("email", user.Email),
                                                    new Claim("roles",user.Roles ),
                                                    new Claim("userName",user.UserName)});

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = claims,
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
