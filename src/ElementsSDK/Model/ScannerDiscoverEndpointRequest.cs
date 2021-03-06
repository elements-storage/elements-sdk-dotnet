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
    /// ScannerDiscoverEndpointRequest
    /// </summary>
    [DataContract(Name = "ScannerDiscoverEndpointRequest")]
    public partial class ScannerDiscoverEndpointRequest : IEquatable<ScannerDiscoverEndpointRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScannerDiscoverEndpointRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScannerDiscoverEndpointRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScannerDiscoverEndpointRequest" /> class.
        /// </summary>
        /// <param name="path">path (required).</param>
        /// <param name="recursive">recursive.</param>
        public ScannerDiscoverEndpointRequest(string path = default(string), bool? recursive = default(bool?))
        {
            // to ensure "path" is required (not null)
            this.Path = path ?? throw new ArgumentNullException("path is a required property for ScannerDiscoverEndpointRequest and cannot be null");
            this.Recursive = recursive;
        }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name = "path", IsRequired = true, EmitDefaultValue = false)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets Recursive
        /// </summary>
        [DataMember(Name = "recursive", EmitDefaultValue = true)]
        public bool? Recursive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScannerDiscoverEndpointRequest {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Recursive: ").Append(Recursive).Append("\n");
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
            return this.Equals(input as ScannerDiscoverEndpointRequest);
        }

        /// <summary>
        /// Returns true if ScannerDiscoverEndpointRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ScannerDiscoverEndpointRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScannerDiscoverEndpointRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Recursive == input.Recursive ||
                    (this.Recursive != null &&
                    this.Recursive.Equals(input.Recursive))
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
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Recursive != null)
                    hashCode = hashCode * 59 + this.Recursive.GetHashCode();
                return hashCode;
            }
        }

    }

}
