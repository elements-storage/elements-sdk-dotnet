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
    /// KapacitorAlert
    /// </summary>
    [DataContract(Name = "KapacitorAlert")]
    public partial class KapacitorAlert : IEquatable<KapacitorAlert>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KapacitorAlert" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KapacitorAlert() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KapacitorAlert" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="level">level (required).</param>
        /// <param name="message">message (required).</param>
        /// <param name="details">details (required).</param>
        /// <param name="data">data (required).</param>
        public KapacitorAlert(string id = default(string), string level = default(string), string message = default(string), string details = default(string), Dictionary<string, string> data = default(Dictionary<string, string>))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for KapacitorAlert and cannot be null");
            // to ensure "level" is required (not null)
            this.Level = level ?? throw new ArgumentNullException("level is a required property for KapacitorAlert and cannot be null");
            // to ensure "message" is required (not null)
            this.Message = message ?? throw new ArgumentNullException("message is a required property for KapacitorAlert and cannot be null");
            // to ensure "details" is required (not null)
            this.Details = details ?? throw new ArgumentNullException("details is a required property for KapacitorAlert and cannot be null");
            // to ensure "data" is required (not null)
            this.Data = data ?? throw new ArgumentNullException("data is a required property for KapacitorAlert and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name = "level", IsRequired = true, EmitDefaultValue = false)]
        public string Level { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name = "details", IsRequired = true, EmitDefaultValue = false)]
        public string Details { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, string> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KapacitorAlert {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as KapacitorAlert);
        }

        /// <summary>
        /// Returns true if KapacitorAlert instances are equal
        /// </summary>
        /// <param name="input">Instance of KapacitorAlert to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KapacitorAlert input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Level != null)
                    hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                return hashCode;
            }
        }

    }

}
