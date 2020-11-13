using System;
using System.Collections.Generic;
using System.Text;
using MedicalLab.Entity;

namespace MedicalLab.RepositoryInterface
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITestResultRepository
    {
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //List<TestReport> GetAllTestType();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        TestResult Get(string userName);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="report"></param>
        void Add(TestResult report);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="report"></param>
        void Update(TestResult report);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="report"></param>
        /// <param name=""></param>
        void Remove(TestResult report);
    }
}
