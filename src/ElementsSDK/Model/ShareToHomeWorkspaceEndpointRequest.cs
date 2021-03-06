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
    /// ShareToHomeWorkspaceEndpointRequest
    /// </summary>
    [DataContract(Name = "ShareToHomeWorkspaceEndpointRequest")]
    public partial class ShareToHomeWorkspaceEndpointRequest : IEquatable<ShareToHomeWorkspaceEndpointRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShareToHomeWorkspaceEndpointRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShareToHomeWorkspaceEndpointRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShareToHomeWorkspaceEndpointRequest" /> class.
        /// </summary>
        /// <param name="paths">paths.</param>
        /// <param name="bundles">bundles.</param>
        /// <param name="user">user (required).</param>
        /// <param name="name">name (required).</param>
        public ShareToHomeWorkspaceEndpointRequest(List<string> paths = default(List<string>), List<int> bundles = default(List<int>), int user = default(int), string name = default(string))
        {
            this.User = user;
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for ShareToHomeWorkspaceEndpointRequest and cannot be null");
            this.Paths = paths;
            this.Bundles = bundles;
        }

        /// <summary>
        /// Gets or Sets Paths
        /// </summary>
        [DataMember(Name = "paths", EmitDefaultValue = false)]
        public List<string> Paths { get; set; }

        /// <summary>
        /// Gets or Sets Bundles
        /// </summary>
        [DataMember(Name = "bundles", EmitDefaultValue = false)]
        public List<int> Bundles { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", IsRequired = true, EmitDefaultValue = false)]
        public int User { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShareToHomeWorkspaceEndpointRequest {\n");
            sb.Append("  Paths: ").Append(Paths).Append("\n");
            sb.Append("  Bundles: ").Append(Bundles).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as ShareToHomeWorkspaceEndpointRequest);
        }

        /// <summary>
        /// Returns true if ShareToHomeWorkspaceEndpointRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ShareToHomeWorkspaceEndpointRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShareToHomeWorkspaceEndpointRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Paths == input.Paths ||
                    this.Paths != null &&
                    input.Paths != null &&
                    this.Paths.SequenceEqual(input.Paths)
                ) && 
                (
                    this.Bundles == input.Bundles ||
                    this.Bundles != null &&
                    input.Bundles != null &&
                    this.Bundles.SequenceEqual(input.Bundles)
                ) && 
                (
                    this.User == input.User ||
                    this.User.Equals(input.User)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Paths != null)
                    hashCode = hashCode * 59 + this.Paths.GetHashCode();
                if (this.Bundles != null)
                    hashCode = hashCode * 59 + this.Bundles.GetHashCode();
                hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }

}
