using MedicalLab.Model;
using MedicalLab.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalLab.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public class RepositoryStore : IRepositoryStore
    {
        private DataBaseSettings settings;
        public RepositoryStore(DataBaseSettings dbsettings)
        {
            settings = dbsettings;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="settings"></param>
        /// <returns></returns>
        public T CreateRepository<T>() where T : class
        { 
            var repo = (T)Activator.CreateInstance(typeof(T), settings);
            return repo;
        }

    }
}
