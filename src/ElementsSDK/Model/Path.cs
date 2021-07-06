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
    /// Path
    /// </summary>
    [DataContract(Name = "Path")]
    public partial class Path : IEquatable<Path>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Path" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Path() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Path" /> class.
        /// </summary>
        /// <param name="path">path (required).</param>
        public Path(string path = default(string))
        {
            // to ensure "path" is required (not null)
            this._Path = path ?? throw new ArgumentNullException("path is a required property for Path and cannot be null");
        }

        /// <summary>
        /// Gets or Sets _Path
        /// </summary>
        [DataMember(Name = "path", IsRequired = true, EmitDefaultValue = false)]
        public string _Path { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Path {\n");
            sb.Append("  _Path: ").Append(_Path).Append("\n");
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
            return this.Equals(input as Path);
        }

        /// <summary>
        /// Returns true if Path instances are equal
        /// </summary>
        /// <param name="input">Instance of Path to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Path input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Path == input._Path ||
                    (this._Path != null &&
                    this._Path.Equals(input._Path))
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
                if (this._Path != null)
                    hashCode = hashCode * 59 + this._Path.GetHashCode();
                return hashCode;
            }
        }

    }

}