using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalLab.Entity
{
    /// <summary>
    /// 
    /// </summary>
    public class TestResult
    {
        /// <summary>
        /// Book Id
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string UserTestResultGuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CreatedByUserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public TestReport UesrTestReport { get; set; }
    }

    public class TestReport
    { 
        /// <summary>
        /// 
        /// </summary>
        public string ReportName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Test> Tests { get; set; }
    }

    public class Test
    { 
        public string TestName { get; set; }
        public List<TestItem> Items { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class TestItem
    { 
        /// <summary>
        /// 
        /// </summary>
        public string TestItemName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Result { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string NominalValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Reference { get; set; }
    }
}
