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
    /// AssetMiniReference
    /// </summary>
    [DataContract(Name = "AssetMiniReference")]
    public partial class AssetMiniReference : IEquatable<AssetMiniReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetMiniReference" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="defaultProxy">defaultProxy.</param>
        public AssetMiniReference(int id = default(int), Proxy defaultProxy = default(Proxy))
        {
            this.Id = id;
            this.DefaultProxy = defaultProxy;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets SyncId
        /// </summary>
        [DataMember(Name = "sync_id", EmitDefaultValue = false)]
        public Guid SyncId { get; private set; }

        /// <summary>
        /// Returns false as SyncId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSyncId()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets DefaultProxy
        /// </summary>
        [DataMember(Name = "default_proxy", EmitDefaultValue = false)]
        public Proxy DefaultProxy { get; set; }

        /// <summary>
        /// Gets or Sets Urls
        /// </summary>
        [DataMember(Name = "urls", EmitDefaultValue = false)]
        public Dictionary<string, string> Urls { get; private set; }

        /// <summary>
        /// Returns false as Urls should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUrls()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; private set; }

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "display_name", EmitDefaultValue = false)]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Returns false as DisplayName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDisplayName()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name = "info", EmitDefaultValue = false)]
        public string Info { get; private set; }

        /// <summary>
        /// Returns false as Info should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInfo()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets ThumbnailGenerated
        /// </summary>
        [DataMember(Name = "thumbnail_generated", EmitDefaultValue = true)]
        public bool ThumbnailGenerated { get; private set; }

        /// <summary>
        /// Returns false as ThumbnailGenerated should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeThumbnailGenerated()
        {
            return false;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetMiniReference {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SyncId: ").Append(SyncId).Append("\n");
            sb.Append("  DefaultProxy: ").Append(DefaultProxy).Append("\n");
            sb.Append("  Urls: ").Append(Urls).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  ThumbnailGenerated: ").Append(ThumbnailGenerated).Append("\n");
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
            return this.Equals(input as AssetMiniReference);
        }

        /// <summary>
        /// Returns true if AssetMiniReference instances are equal
        /// </summary>
        /// <param name="input">Instance of AssetMiniReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetMiniReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.SyncId == input.SyncId ||
                    (this.SyncId != null &&
                    this.SyncId.Equals(input.SyncId))
                ) && 
                (
                    this.DefaultProxy == input.DefaultProxy ||
                    (this.DefaultProxy != null &&
                    this.DefaultProxy.Equals(input.DefaultProxy))
                ) && 
                (
                    this.Urls == input.Urls ||
                    this.Urls != null &&
                    input.Urls != null &&
                    this.Urls.SequenceEqual(input.Urls)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Info == input.Info ||
                    (this.Info != null &&
                    this.Info.Equals(input.Info))
                ) && 
                (
                    this.ThumbnailGenerated == input.ThumbnailGenerated ||
                    this.ThumbnailGenerated.Equals(input.ThumbnailGenerated)
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
                if (this.SyncId != null)
                    hashCode = hashCode * 59 + this.SyncId.GetHashCode();
                if (this.DefaultProxy != null)
                    hashCode = hashCode * 59 + this.DefaultProxy.GetHashCode();
                if (this.Urls != null)
                    hashCode = hashCode * 59 + this.Urls.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Info != null)
                    hashCode = hashCode * 59 + this.Info.GetHashCode();
                hashCode = hashCode * 59 + this.ThumbnailGenerated.GetHashCode();
                return hashCode;
            }
        }

    }

}