using MedicalLab.Entity;
using MedicalLab.Model;
using MedicalLab.RepositoryInterface;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalLab.Repository
{
    /// <summary>
    /// user repository
    /// </summary>
    public class UserRepository : IUsersRepository
    {   
        private const string CollectionName = "users";
        private readonly IMongoCollection<User> users;
        public UserRepository(DataBaseSettings setting)
        {
            var client = new MongoClient(setting.ConnectionString);
            var dbClient = client.GetDatabase(setting.DatabaseName);
            users = dbClient.GetCollection<User>(CollectionName);
        }

        /// <summary>
        /// get user by name
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public User GetUserByName(string userName)
        {
            return users.Find(u => u.UserName == userName).SingleOrDefault();
        }
        /// <summary>
        /// get all users
        /// </summary>
        /// <returns></returns>
        public List<User> GetUsers()
        {
            return users.Find(u=>u.UserName != null).ToList();
        }
        /// <summary>
        /// add user
        /// </summary>
        /// <param name="user"></param>
        public void Add(User user) =>        
            users.InsertOne(user);
        
        /// <summary>
        /// remove user
        /// </summary>
        /// <param name="user"></param>
        public void RemoveUser(User user) =>        
            users.DeleteOne(u => u.UserName == user.UserName);
        
        /// <summary>
        /// update user
        /// </summary>
        /// <param name="user"></param>
        public void Update(User user) =>        
            users.ReplaceOne(u => u.UserName == user.UserName, user);
        
    }
}
