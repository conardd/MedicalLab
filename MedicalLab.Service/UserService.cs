using MedicalLab.Entity;
using MedicalLab.Model;
using MedicalLab.RepositoryInterface;
using MedicalLab.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Text;
using MedicalLab.Repository;

namespace MedicalLab.Service
{
    public class UserService : IUserService
    {

        private IUsersRepository repo;
        private DataBaseSettings settings;

        public UserService(IRepositoryStore store)
        {
            repo = store.CreateRepository<IUsersRepository>();
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
    }
}
