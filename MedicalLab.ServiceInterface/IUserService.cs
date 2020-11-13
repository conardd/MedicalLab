using System.Collections.Generic;
using MedicalLab.Entity;

namespace MedicalLab.ServiceInterface
{
    public interface IUserService
    {
        /// <summary>
        /// user log in
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        User GetUserByName(string userName);
        /// <summary>
        /// get all users
        /// </summary>
        /// <returns></returns>
        List<User> GetUsers();
        /// <summary>
        /// add new user
        /// </summary>
        /// <param name="user"></param>
        void Add(User user);
        /// <summary>
        /// remove user
        /// </summary>
        /// <param name="user"></param>
        void RemoveUser(User user);
        /// <summary>
        /// update user
        /// </summary>
        /// <param name="user"></param>
        void Update(User user);
    }
}
