using MedicalLab.Entity;
using MedicalLab.Model;
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
        ApiResponse Get();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="report"></param>
        ApiResponse Add(TestResult report);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="report"></param>
        ApiResponse Update(TestResult report);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="report"></param>
        /// <param name=""></param>
        ApiResponse Remove(TestResult report);
    }
}
