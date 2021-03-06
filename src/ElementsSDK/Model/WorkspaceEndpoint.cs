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
    /// WorkspaceEndpoint
    /// </summary>
    [DataContract(Name = "WorkspaceEndpoint")]
    public partial class WorkspaceEndpoint : IEquatable<WorkspaceEndpoint>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceEndpoint" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkspaceEndpoint() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceEndpoint" /> class.
        /// </summary>
        /// <param name="protocol">protocol (required).</param>
        /// <param name="address">address (required).</param>
        /// <param name="path">path (required).</param>
        /// <param name="priority">priority (required).</param>
        /// <param name="platform">platform (required).</param>
        /// <param name="username">username (required).</param>
        /// <param name="password">password (required).</param>
        public WorkspaceEndpoint(string protocol = default(string), string address = default(string), string path = default(string), int priority = default(int), string platform = default(string), string username = default(string), string password = default(string))
        {
            // to ensure "protocol" is required (not null)
            this.Protocol = protocol ?? throw new ArgumentNullException("protocol is a required property for WorkspaceEndpoint and cannot be null");
            // to ensure "address" is required (not null)
            this.Address = address ?? throw new ArgumentNullException("address is a required property for WorkspaceEndpoint and cannot be null");
            // to ensure "path" is required (not null)
            this.Path = path ?? throw new ArgumentNullException("path is a required property for WorkspaceEndpoint and cannot be null");
            this.Priority = priority;
            // to ensure "platform" is required (not null)
            this.Platform = platform ?? throw new ArgumentNullException("platform is a required property for WorkspaceEndpoint and cannot be null");
            // to ensure "username" is required (not null)
            this.Username = username ?? throw new ArgumentNullException("username is a required property for WorkspaceEndpoint and cannot be null");
            // to ensure "password" is required (not null)
            this.Password = password ?? throw new ArgumentNullException("password is a required property for WorkspaceEndpoint and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Protocol
        /// </summary>
        [DataMember(Name = "protocol", IsRequired = true, EmitDefaultValue = false)]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name = "path", IsRequired = true, EmitDefaultValue = false)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", IsRequired = true, EmitDefaultValue = false)]
        public int Priority { get; set; }

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name = "platform", IsRequired = true, EmitDefaultValue = false)]
        public string Platform { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name = "username", IsRequired = true, EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", IsRequired = true, EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkspaceEndpoint {\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return this.Equals(input as WorkspaceEndpoint);
        }

        /// <summary>
        /// Returns true if WorkspaceEndpoint instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkspaceEndpoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkspaceEndpoint input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Priority == input.Priority ||
                    this.Priority.Equals(input.Priority)
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                return hashCode;
            }
        }

    }

}
