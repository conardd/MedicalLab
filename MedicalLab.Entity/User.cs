using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;
using MongoDB.Bson;

namespace MedicalLab.Entity
{
    [Serializable]
    /// <summary>
    /// user
    /// </summary>
    public class User
    {
        /// <summary>
        /// Book Id
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        /// <summary>
        /// user name
        /// </summary>
        [BsonElement("Name")]
        public string UserName { get; set; }
        /// <summary>
        /// user password
        /// </summary>
        [JsonIgnore]
        public string Password { get; set; }
        /// <summary>
        /// user roles
        /// </summary>
        public string Role { get; set; }        
        /// <summary>
        /// is user active
        /// </summary>
        public bool Active { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }
    }
}
