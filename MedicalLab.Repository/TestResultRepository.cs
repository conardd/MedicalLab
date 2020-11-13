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
        //private readonly IMongoCollection<TestReport> reports;
        public TestResultRepository(IMongoDBClient _client)
        {
            var client = _client.CreateClient();
            results = client.GetCollection<TestResult>(CollectionName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public TestResult Get(string userName) => results.Find(r => r.UserName == userName).SingleOrDefault();

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
