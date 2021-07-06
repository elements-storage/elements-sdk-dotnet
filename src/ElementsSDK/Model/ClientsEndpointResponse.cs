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
    /// ClientsEndpointResponse
    /// </summary>
    [DataContract(Name = "ClientsEndpointResponse")]
    public partial class ClientsEndpointResponse : IEquatable<ClientsEndpointResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientsEndpointResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientsEndpointResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientsEndpointResponse" /> class.
        /// </summary>
        /// <param name="version">version (required).</param>
        /// <param name="fullVersion">fullVersion (required).</param>
        /// <param name="platform">platform (required).</param>
        /// <param name="file">file (required).</param>
        public ClientsEndpointResponse(string version = default(string), string fullVersion = default(string), string platform = default(string), string file = default(string))
        {
            // to ensure "version" is required (not null)
            this.Version = version ?? throw new ArgumentNullException("version is a required property for ClientsEndpointResponse and cannot be null");
            // to ensure "fullVersion" is required (not null)
            this.FullVersion = fullVersion ?? throw new ArgumentNullException("fullVersion is a required property for ClientsEndpointResponse and cannot be null");
            // to ensure "platform" is required (not null)
            this.Platform = platform ?? throw new ArgumentNullException("platform is a required property for ClientsEndpointResponse and cannot be null");
            // to ensure "file" is required (not null)
            this.File = file ?? throw new ArgumentNullException("file is a required property for ClientsEndpointResponse and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = false)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or Sets FullVersion
        /// </summary>
        [DataMember(Name = "full_version", IsRequired = true, EmitDefaultValue = false)]
        public string FullVersion { get; set; }

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name = "platform", IsRequired = true, EmitDefaultValue = false)]
        public string Platform { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name = "file", IsRequired = true, EmitDefaultValue = false)]
        public string File { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientsEndpointResponse {\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  FullVersion: ").Append(FullVersion).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
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
            return this.Equals(input as ClientsEndpointResponse);
        }

        /// <summary>
        /// Returns true if ClientsEndpointResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientsEndpointResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientsEndpointResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.FullVersion == input.FullVersion ||
                    (this.FullVersion != null &&
                    this.FullVersion.Equals(input.FullVersion))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
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
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.FullVersion != null)
                    hashCode = hashCode * 59 + this.FullVersion.GetHashCode();
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
                return hashCode;
            }
        }

    }

}