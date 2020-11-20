using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalLab.Model
{
    /// <summary>
    /// Response Result
    /// </summary>
    public class ApiResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public bool Result { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Object Value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object OtherInfo { get; set; }
    }
}
