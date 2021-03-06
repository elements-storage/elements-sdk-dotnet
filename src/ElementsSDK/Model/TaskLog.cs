/*
 * ELEMENTS API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = ElementsSDK.Client.OpenAPIDateConverter;

namespace ElementsSDK.Model
{
    /// <summary>
    /// TaskLog
    /// </summary>
    [DataContract(Name = "TaskLog")]
    public partial class TaskLog : IEquatable<TaskLog>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskLog" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaskLog() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskLog" /> class.
        /// </summary>
        /// <param name="log">log (required).</param>
        public TaskLog(string log = default(string))
        {
            // to ensure "log" is required (not null)
            this.Log = log ?? throw new ArgumentNullException("log is a required property for TaskLog and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Log
        /// </summary>
        [DataMember(Name = "log", IsRequired = true, EmitDefaultValue = false)]
        public string Log { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskLog {\n");
            sb.Append("  Log: ").Append(Log).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskLog);
        }

        /// <summary>
        /// Returns true if TaskLog instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskLog input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Log == input.Log ||
                    (this.Log != null &&
                    this.Log.Equals(input.Log))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Log != null)
                    hashCode = hashCode * 59 + this.Log.GetHashCode();
                return hashCode;
            }
        }

    }

}
