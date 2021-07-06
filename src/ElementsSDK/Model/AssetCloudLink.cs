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
    /// AssetCloudLink
    /// </summary>
    [DataContract(Name = "AssetCloudLink")]
    public partial class AssetCloudLink : IEquatable<AssetCloudLink>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetCloudLink" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssetCloudLink() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetCloudLink" /> class.
        /// </summary>
        /// <param name="connection">connection.</param>
        /// <param name="asset">asset (required).</param>
        public AssetCloudLink(CloudConnection connection = default(CloudConnection), int asset = default(int))
        {
            this.Asset = asset;
            this.Connection = connection;
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
        /// Gets or Sets Connection
        /// </summary>
        [DataMember(Name = "connection", EmitDefaultValue = false)]
        public CloudConnection Connection { get; set; }

        /// <summary>
        /// Gets or Sets PresignedAssetUrl
        /// </summary>
        [DataMember(Name = "presigned_asset_url", EmitDefaultValue = false)]
        public string PresignedAssetUrl { get; private set; }

        /// <summary>
        /// Returns false as PresignedAssetUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePresignedAssetUrl()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }

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
            sb.Append("class AssetCloudLink {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Connection: ").Append(Connection).Append("\n");
            sb.Append("  PresignedAssetUrl: ").Append(PresignedAssetUrl).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as AssetCloudLink);
        }

        /// <summary>
        /// Returns true if AssetCloudLink instances are equal
        /// </summary>
        /// <param name="input">Instance of AssetCloudLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetCloudLink input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Connection == input.Connection ||
                    (this.Connection != null &&
                    this.Connection.Equals(input.Connection))
                ) && 
                (
                    this.PresignedAssetUrl == input.PresignedAssetUrl ||
                    (this.PresignedAssetUrl != null &&
                    this.PresignedAssetUrl.Equals(input.PresignedAssetUrl))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.Connection != null)
                    hashCode = hashCode * 59 + this.Connection.GetHashCode();
                if (this.PresignedAssetUrl != null)
                    hashCode = hashCode * 59 + this.PresignedAssetUrl.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                hashCode = hashCode * 59 + this.Asset.GetHashCode();
                return hashCode;
            }
        }

    }

}