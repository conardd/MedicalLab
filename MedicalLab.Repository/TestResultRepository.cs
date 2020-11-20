using MedicalLab.Entity;
using MedicalLab.RepositoryInterface;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalLab.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public class TestResultRepository : ITestResultRepository
    {

        private const string CollectionName = "reports";
        private readonly IMongoCollection<TestResult> results;
        
        public TestResultRepository(DataBaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var dbClient = client.GetDatabase(settings.DatabaseName);
            results = dbClient.GetCollection<TestResult>(CollectionName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<TestResult> Get() => results.Find(m=>m.FirstName != null).ToList();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="report"></param>
        public void Add(TestResult report) => results.InsertOne(report);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="report"></param>
        public void Update(TestResult report) => results.ReplaceOne(r => r.UserName == report.UserName, report);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="report"></param>
        public void Remove(TestResult report) => results.DeleteOne(r => r.UserName == report.UserName);        
    }
}
