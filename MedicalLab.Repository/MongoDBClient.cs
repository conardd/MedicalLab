using System;
using System.Collections.Generic;
using System.Text;
using MedicalLab.Model;
using MongoDB.Driver;

namespace MedicalLab.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public interface IMongoDBClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IMongoDatabase CreateClient();
    }
    /// <summary>
    /// 
    /// </summary>
    public class MongoDBClient : IMongoDBClient
    {
        protected IMongoDatabase dbClient;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="setting"></param>
        public MongoDBClient(DataBaseSettings setting)
        {
            var client = new MongoClient(setting.ConnectionString);
            dbClient = client.GetDatabase(setting.DatabaseName);
        }
        /// <summary>
        /// 
        /// </summary>
        public IMongoDatabase CreateClient()
        {
           return dbClient; 
        }
    }
}
