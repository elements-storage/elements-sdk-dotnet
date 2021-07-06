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
    /// IOStat
    /// </summary>
    [DataContract(Name = "IOStat")]
    public partial class IOStat : IEquatable<IOStat>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IOStat" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IOStat() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IOStat" /> class.
        /// </summary>
        /// <param name="time">time (required).</param>
        /// <param name="cRead">cRead (required).</param>
        /// <param name="cWrite">cWrite (required).</param>
        public IOStat(decimal time = default(decimal), decimal cRead = default(decimal), decimal cWrite = default(decimal))
        {
            this.Time = time;
            this.CRead = cRead;
            this.CWrite = cWrite;
        }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name = "time", IsRequired = true, EmitDefaultValue = false)]
        public decimal Time { get; set; }

        /// <summary>
        /// Gets or Sets CRead
        /// </summary>
        [DataMember(Name = "c_read", IsRequired = true, EmitDefaultValue = false)]
        public decimal CRead { get; set; }

        /// <summary>
        /// Gets or Sets CWrite
        /// </summary>
        [DataMember(Name = "c_write", IsRequired = true, EmitDefaultValue = false)]
        public decimal CWrite { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IOStat {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  CRead: ").Append(CRead).Append("\n");
            sb.Append("  CWrite: ").Append(CWrite).Append("\n");
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
            return this.Equals(input as IOStat);
        }

        /// <summary>
        /// Returns true if IOStat instances are equal
        /// </summary>
        /// <param name="input">Instance of IOStat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IOStat input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Time == input.Time ||
                    this.Time.Equals(input.Time)
                ) && 
                (
                    this.CRead == input.CRead ||
                    this.CRead.Equals(input.CRead)
                ) && 
                (
                    this.CWrite == input.CWrite ||
                    this.CWrite.Equals(input.CWrite)
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
                hashCode = hashCode * 59 + this.Time.GetHashCode();
                hashCode = hashCode * 59 + this.CRead.GetHashCode();
                hashCode = hashCode * 59 + this.CWrite.GetHashCode();
                return hashCode;
            }
        }

    }

}