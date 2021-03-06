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
    /// StorNextLicenseCheckEndpointResponse
    /// </summary>
    [DataContract(Name = "StorNextLicenseCheckEndpointResponse")]
    public partial class StorNextLicenseCheckEndpointResponse : IEquatable<StorNextLicenseCheckEndpointResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorNextLicenseCheckEndpointResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StorNextLicenseCheckEndpointResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StorNextLicenseCheckEndpointResponse" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="mac">mac (required).</param>
        /// <param name="key">key (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="comment">comment (required).</param>
        /// <param name="valid">valid (required).</param>
        public StorNextLicenseCheckEndpointResponse(string name = default(string), string mac = default(string), string key = default(string), string type = default(string), string comment = default(string), bool valid = default(bool))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for StorNextLicenseCheckEndpointResponse and cannot be null");
            // to ensure "mac" is required (not null)
            this.Mac = mac ?? throw new ArgumentNullException("mac is a required property for StorNextLicenseCheckEndpointResponse and cannot be null");
            // to ensure "key" is required (not null)
            this.Key = key ?? throw new ArgumentNullException("key is a required property for StorNextLicenseCheckEndpointResponse and cannot be null");
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for StorNextLicenseCheckEndpointResponse and cannot be null");
            // to ensure "comment" is required (not null)
            this.Comment = comment ?? throw new ArgumentNullException("comment is a required property for StorNextLicenseCheckEndpointResponse and cannot be null");
            this.Valid = valid;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Mac
        /// </summary>
        [DataMember(Name = "mac", IsRequired = true, EmitDefaultValue = false)]
        public string Mac { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name = "comment", IsRequired = true, EmitDefaultValue = false)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets Valid
        /// </summary>
        [DataMember(Name = "valid", IsRequired = true, EmitDefaultValue = true)]
        public bool Valid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorNextLicenseCheckEndpointResponse {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Mac: ").Append(Mac).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Valid: ").Append(Valid).Append("\n");
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
            return this.Equals(input as StorNextLicenseCheckEndpointResponse);
        }

        /// <summary>
        /// Returns true if StorNextLicenseCheckEndpointResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of StorNextLicenseCheckEndpointResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorNextLicenseCheckEndpointResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Mac == input.Mac ||
                    (this.Mac != null &&
                    this.Mac.Equals(input.Mac))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Valid == input.Valid ||
                    this.Valid.Equals(input.Valid)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Mac != null)
                    hashCode = hashCode * 59 + this.Mac.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                hashCode = hashCode * 59 + this.Valid.GetHashCode();
                return hashCode;
            }
        }

    }

}
