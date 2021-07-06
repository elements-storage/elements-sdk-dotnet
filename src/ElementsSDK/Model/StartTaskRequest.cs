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
    /// StartTaskRequest
    /// </summary>
    [DataContract(Name = "StartTaskRequest")]
    public partial class StartTaskRequest : IEquatable<StartTaskRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartTaskRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StartTaskRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StartTaskRequest" /> class.
        /// </summary>
        /// <param name="taskType">taskType (required).</param>
        /// <param name="parameters">parameters (required).</param>
        /// <param name="sync">sync (default to false).</param>
        public StartTaskRequest(string taskType = default(string), Dictionary<string, string> parameters = default(Dictionary<string, string>), bool sync = false)
        {
            // to ensure "taskType" is required (not null)
            this.TaskType = taskType ?? throw new ArgumentNullException("taskType is a required property for StartTaskRequest and cannot be null");
            // to ensure "parameters" is required (not null)
            this.Parameters = parameters ?? throw new ArgumentNullException("parameters is a required property for StartTaskRequest and cannot be null");
            this.Sync = sync;
        }

        /// <summary>
        /// Gets or Sets TaskType
        /// </summary>
        [DataMember(Name = "task_type", IsRequired = true, EmitDefaultValue = false)]
        public string TaskType { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Gets or Sets Sync
        /// </summary>
        [DataMember(Name = "sync", EmitDefaultValue = true)]
        public bool Sync { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartTaskRequest {\n");
            sb.Append("  TaskType: ").Append(TaskType).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Sync: ").Append(Sync).Append("\n");
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
            return this.Equals(input as StartTaskRequest);
        }

        /// <summary>
        /// Returns true if StartTaskRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of StartTaskRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StartTaskRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskType == input.TaskType ||
                    (this.TaskType != null &&
                    this.TaskType.Equals(input.TaskType))
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) && 
                (
                    this.Sync == input.Sync ||
                    this.Sync.Equals(input.Sync)
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
                if (this.TaskType != null)
                    hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                hashCode = hashCode * 59 + this.Sync.GetHashCode();
                return hashCode;
            }
        }

    }

}