using MedicalLab.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalLab.ServiceInterface
{
    public interface ITestResultService
    {        
        /// <summary>
        /// 
        /// </summary>        
        /// <returns></returns>
        void Get();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="report"></param>
        TestResult Add(TestResult report);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="report"></param>
        TestResult Update(TestResult report);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="report"></param>
        /// <param name=""></param>
        TestResult Remove(TestResult report);
    }
}
