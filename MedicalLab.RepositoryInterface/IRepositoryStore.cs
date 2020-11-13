using MedicalLab.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalLab.RepositoryInterface
{
    public interface IRepositoryStore
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="settings"></param>
        /// <returns></returns>
        T CreateRepository<T>() where T : class;
    }
}
