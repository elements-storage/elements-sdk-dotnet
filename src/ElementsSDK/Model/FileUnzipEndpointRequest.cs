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
    /// FileUnzipEndpointRequest
    /// </summary>
    [DataContract(Name = "FileUnzipEndpointRequest")]
    public partial class FileUnzipEndpointRequest : IEquatable<FileUnzipEndpointRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileUnzipEndpointRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileUnzipEndpointRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileUnzipEndpointRequest" /> class.
        /// </summary>
        /// <param name="input">input (required).</param>
        /// <param name="remove">remove.</param>
        public FileUnzipEndpointRequest(string input = default(string), bool remove = default(bool))
        {
            // to ensure "input" is required (not null)
            this.Input = input ?? throw new ArgumentNullException("input is a required property for FileUnzipEndpointRequest and cannot be null");
            this.Remove = remove;
        }

        /// <summary>
        /// Gets or Sets Input
        /// </summary>
        [DataMember(Name = "input", IsRequired = true, EmitDefaultValue = false)]
        public string Input { get; set; }

        /// <summary>
        /// Gets or Sets Remove
        /// </summary>
        [DataMember(Name = "remove", EmitDefaultValue = true)]
        public bool Remove { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileUnzipEndpointRequest {\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  Remove: ").Append(Remove).Append("\n");
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
            return this.Equals(input as FileUnzipEndpointRequest);
        }

        /// <summary>
        /// Returns true if FileUnzipEndpointRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of FileUnzipEndpointRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileUnzipEndpointRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Input == input.Input ||
                    (this.Input != null &&
                    this.Input.Equals(input.Input))
                ) && 
                (
                    this.Remove == input.Remove ||
                    this.Remove.Equals(input.Remove)
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
                if (this.Input != null)
                    hashCode = hashCode * 59 + this.Input.GetHashCode();
                hashCode = hashCode * 59 + this.Remove.GetHashCode();
                return hashCode;
            }
        }

    }

}
