using MedicalLab.Entity;
using MedicalLab.Model;
using MedicalLab.Repository;
using MedicalLab.RepositoryInterface;
using MedicalLab.ServiceInterface;
using System;

namespace MedicalLab.Service
{
    public class TestResultService : ITestResultService
    {
        private ITestResultRepository repo;
       
        /// <summary>
        /// default constructor
        /// </summary>
        public TestResultService()
        { }
        public TestResultService(DataBaseSettings setting)
        {
            repo = new TestResultRepository(setting);
            
        }

        public ApiResponse Get()
        {
            var response = new ApiResponse() { Result = true };
            try
            {
                var list = repo.Get();
                
                response.Value = list;
            }
            catch (Exception ex)
            {
                response.Result = false;
                response.Message = ex.ToString();
            }
            return response;
        }

        public ApiResponse Add(TestResult report)
        {
            var response = new ApiResponse() { Result = true };
            try
            {
                repo.Add(report);                
            }
            catch (Exception ex)
            {
                response.Result = false;
                response.Message = ex.ToString();
            }
            return response;
        }

        public ApiResponse Update(TestResult report)
        {
            var response = new ApiResponse() { Result = true };
            try
            {
                repo.Update(report);
            }
            catch (Exception ex)
            {
                response.Result = false;
                response.Message = ex.ToString();
            }
            return response;
        }

        public ApiResponse Remove(TestResult report)
        {
            var response = new ApiResponse() { Result = true };
            try
            {
                repo.Remove(report);
            }
            catch (Exception ex)
            {
                response.Result = false;
                response.Message = ex.ToString();
            }
            return response;
        }
    }
}
