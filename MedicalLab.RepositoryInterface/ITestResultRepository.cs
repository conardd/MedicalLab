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
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<TestResult> Get();
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
