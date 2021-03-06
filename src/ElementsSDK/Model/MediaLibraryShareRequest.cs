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
    /// MediaLibraryShareRequest
    /// </summary>
    [DataContract(Name = "MediaLibraryShareRequest")]
    public partial class MediaLibraryShareRequest : IEquatable<MediaLibraryShareRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaLibraryShareRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MediaLibraryShareRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaLibraryShareRequest" /> class.
        /// </summary>
        /// <param name="bundles">bundles.</param>
        /// <param name="directories">directories.</param>
        /// <param name="expires">expires (required).</param>
        /// <param name="viewLimit">viewLimit.</param>
        /// <param name="permissions">permissions (required).</param>
        /// <param name="user">user.</param>
        /// <param name="email">email.</param>
        /// <param name="linkType">linkType.</param>
        /// <param name="password">password.</param>
        public MediaLibraryShareRequest(List<int> bundles = default(List<int>), List<int> directories = default(List<int>), DateTime expires = default(DateTime), int? viewLimit = default(int?), MediaRootPermissionAccessOptions permissions = default(MediaRootPermissionAccessOptions), int user = default(int), string email = default(string), string linkType = default(string), string password = default(string))
        {
            this.Expires = expires;
            // to ensure "permissions" is required (not null)
            this.Permissions = permissions ?? throw new ArgumentNullException("permissions is a required property for MediaLibraryShareRequest and cannot be null");
            this.Bundles = bundles;
            this.Directories = directories;
            this.ViewLimit = viewLimit;
            this.User = user;
            this.Email = email;
            this.LinkType = linkType;
            this.Password = password;
        }

        /// <summary>
        /// Gets or Sets Bundles
        /// </summary>
        [DataMember(Name = "bundles", EmitDefaultValue = false)]
        public List<int> Bundles { get; set; }

        /// <summary>
        /// Gets or Sets Directories
        /// </summary>
        [DataMember(Name = "directories", EmitDefaultValue = false)]
        public List<int> Directories { get; set; }

        /// <summary>
        /// Gets or Sets Expires
        /// </summary>
        [DataMember(Name = "expires", IsRequired = true, EmitDefaultValue = false)]
        public DateTime Expires { get; set; }

        /// <summary>
        /// Gets or Sets ViewLimit
        /// </summary>
        [DataMember(Name = "view_limit", EmitDefaultValue = true)]
        public int? ViewLimit { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name = "permissions", IsRequired = true, EmitDefaultValue = false)]
        public MediaRootPermissionAccessOptions Permissions { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public int User { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets LinkType
        /// </summary>
        [DataMember(Name = "link_type", EmitDefaultValue = false)]
        public string LinkType { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaLibraryShareRequest {\n");
            sb.Append("  Bundles: ").Append(Bundles).Append("\n");
            sb.Append("  Directories: ").Append(Directories).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  ViewLimit: ").Append(ViewLimit).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  LinkType: ").Append(LinkType).Append("\n");
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
            return this.Equals(input as MediaLibraryShareRequest);
        }

        /// <summary>
        /// Returns true if MediaLibraryShareRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MediaLibraryShareRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaLibraryShareRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bundles == input.Bundles ||
                    this.Bundles != null &&
                    input.Bundles != null &&
                    this.Bundles.SequenceEqual(input.Bundles)
                ) && 
                (
                    this.Directories == input.Directories ||
                    this.Directories != null &&
                    input.Directories != null &&
                    this.Directories.SequenceEqual(input.Directories)
                ) && 
                (
                    this.Expires == input.Expires ||
                    (this.Expires != null &&
                    this.Expires.Equals(input.Expires))
                ) && 
                (
                    this.ViewLimit == input.ViewLimit ||
                    (this.ViewLimit != null &&
                    this.ViewLimit.Equals(input.ViewLimit))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    (this.Permissions != null &&
                    this.Permissions.Equals(input.Permissions))
                ) && 
                (
                    this.User == input.User ||
                    this.User.Equals(input.User)
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.LinkType == input.LinkType ||
                    (this.LinkType != null &&
                    this.LinkType.Equals(input.LinkType))
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
                if (this.Bundles != null)
                    hashCode = hashCode * 59 + this.Bundles.GetHashCode();
                if (this.Directories != null)
                    hashCode = hashCode * 59 + this.Directories.GetHashCode();
                if (this.Expires != null)
                    hashCode = hashCode * 59 + this.Expires.GetHashCode();
                if (this.ViewLimit != null)
                    hashCode = hashCode * 59 + this.ViewLimit.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.LinkType != null)
                    hashCode = hashCode * 59 + this.LinkType.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                return hashCode;
            }
        }

    }

}
