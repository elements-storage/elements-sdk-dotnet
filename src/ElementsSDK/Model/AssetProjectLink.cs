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
    /// AssetProjectLink
    /// </summary>
    [DataContract(Name = "AssetProjectLink")]
    public partial class AssetProjectLink : IEquatable<AssetProjectLink>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetProjectLink" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssetProjectLink() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetProjectLink" /> class.
        /// </summary>
        /// <param name="project">project.</param>
        /// <param name="sequenceName">sequenceName (required).</param>
        /// <param name="asset">asset (required).</param>
        public AssetProjectLink(Asset project = default(Asset), string sequenceName = default(string), int asset = default(int))
        {
            // to ensure "sequenceName" is required (not null)
            this.SequenceName = sequenceName ?? throw new ArgumentNullException("sequenceName is a required property for AssetProjectLink and cannot be null");
            this.Asset = asset;
            this.Project = project;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name = "project", EmitDefaultValue = false)]
        public Asset Project { get; set; }

        /// <summary>
        /// Gets or Sets SequenceName
        /// </summary>
        [DataMember(Name = "sequence_name", IsRequired = true, EmitDefaultValue = false)]
        public string SequenceName { get; set; }

        /// <summary>
        /// Gets or Sets Asset
        /// </summary>
        [DataMember(Name = "asset", IsRequired = true, EmitDefaultValue = false)]
        public int Asset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetProjectLink {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  SequenceName: ").Append(SequenceName).Append("\n");
            sb.Append("  Asset: ").Append(Asset).Append("\n");
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
            return this.Equals(input as AssetProjectLink);
        }

        /// <summary>
        /// Returns true if AssetProjectLink instances are equal
        /// </summary>
        /// <param name="input">Instance of AssetProjectLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetProjectLink input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
                ) && 
                (
                    this.SequenceName == input.SequenceName ||
                    (this.SequenceName != null &&
                    this.SequenceName.Equals(input.SequenceName))
                ) && 
                (
                    this.Asset == input.Asset ||
                    this.Asset.Equals(input.Asset)
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.SequenceName != null)
                    hashCode = hashCode * 59 + this.SequenceName.GetHashCode();
                hashCode = hashCode * 59 + this.Asset.GetHashCode();
                return hashCode;
            }
        }

    }

}
