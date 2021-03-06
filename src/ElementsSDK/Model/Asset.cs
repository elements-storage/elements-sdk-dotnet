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
    /// Asset
    /// </summary>
    [DataContract(Name = "Asset")]
    public partial class Asset : IEquatable<Asset>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Asset" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Asset() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Asset" /> class.
        /// </summary>
        /// <param name="defaultProxy">defaultProxy.</param>
        /// <param name="customFields">customFields (required).</param>
        /// <param name="tags">tags (required).</param>
        /// <param name="resolvedPermission">resolvedPermission.</param>
        /// <param name="modifiedBy">modifiedBy.</param>
        /// <param name="set">set.</param>
        public Asset(Proxy defaultProxy = default(Proxy), Dictionary<string, string> customFields = default(Dictionary<string, string>), List<int> tags = default(List<int>), MediaRootPermission resolvedPermission = default(MediaRootPermission), ElementsUserMini modifiedBy = default(ElementsUserMini), int? set = default(int?))
        {
            // to ensure "customFields" is required (not null)
            this.CustomFields = customFields ?? throw new ArgumentNullException("customFields is a required property for Asset and cannot be null");
            // to ensure "tags" is required (not null)
            this.Tags = tags ?? throw new ArgumentNullException("tags is a required property for Asset and cannot be null");
            this.DefaultProxy = defaultProxy;
            this.ResolvedPermission = resolvedPermission;
            this.ModifiedBy = modifiedBy;
            this.Set = set;
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
        /// Gets or Sets Proxies
        /// </summary>
        [DataMember(Name = "proxies", EmitDefaultValue = false)]
        public List<Proxy> Proxies { get; private set; }

        /// <summary>
        /// Returns false as Proxies should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProxies()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets DefaultProxy
        /// </summary>
        [DataMember(Name = "default_proxy", EmitDefaultValue = false)]
        public Proxy DefaultProxy { get; set; }

        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name = "info", EmitDefaultValue = false)]
        public Dictionary<string, string> Info { get; private set; }

        /// <summary>
        /// Returns false as Info should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInfo()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ProxyInfo
        /// </summary>
        [DataMember(Name = "proxy_info", EmitDefaultValue = false)]
        public Dictionary<string, string> ProxyInfo { get; private set; }

        /// <summary>
        /// Returns false as ProxyInfo should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProxyInfo()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, string> CustomFields { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = false)]
        public List<int> Tags { get; set; }

        /// <summary>
        /// Gets or Sets ResolvedPermission
        /// </summary>
        [DataMember(Name = "resolved_permission", EmitDefaultValue = false)]
        public MediaRootPermission ResolvedPermission { get; set; }

        /// <summary>
        /// Gets or Sets Backups
        /// </summary>
        [DataMember(Name = "backups", EmitDefaultValue = false)]
        public string Backups { get; private set; }

        /// <summary>
        /// Returns false as Backups should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBackups()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ProxiesGenerated
        /// </summary>
        [DataMember(Name = "proxies_generated", EmitDefaultValue = true)]
        public bool ProxiesGenerated { get; private set; }

        /// <summary>
        /// Returns false as ProxiesGenerated should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProxiesGenerated()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ProxiesFailed
        /// </summary>
        [DataMember(Name = "proxies_failed", EmitDefaultValue = true)]
        public bool ProxiesFailed { get; private set; }

        /// <summary>
        /// Returns false as ProxiesFailed should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProxiesFailed()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name = "modified_by", EmitDefaultValue = false)]
        public ElementsUserMini ModifiedBy { get; set; }

        /// <summary>
        /// Gets or Sets Bundles
        /// </summary>
        [DataMember(Name = "bundles", EmitDefaultValue = false)]
        public List<MediaFileBundleMini> Bundles { get; private set; }

        /// <summary>
        /// Returns false as Bundles should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBundles()
        {
            return false;
        }
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
        /// Gets or Sets HasFiles
        /// </summary>
        [DataMember(Name = "has_files", EmitDefaultValue = true)]
        public bool HasFiles { get; private set; }

        /// <summary>
        /// Returns false as HasFiles should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeHasFiles()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets HasBackups
        /// </summary>
        [DataMember(Name = "has_backups", EmitDefaultValue = true)]
        public bool HasBackups { get; private set; }

        /// <summary>
        /// Returns false as HasBackups should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeHasBackups()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets HasCloudLinks
        /// </summary>
        [DataMember(Name = "has_cloud_links", EmitDefaultValue = true)]
        public bool HasCloudLinks { get; private set; }

        /// <summary>
        /// Returns false as HasCloudLinks should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeHasCloudLinks()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Checksum
        /// </summary>
        [DataMember(Name = "checksum", EmitDefaultValue = false)]
        public string Checksum { get; private set; }

        /// <summary>
        /// Returns false as Checksum should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeChecksum()
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
        /// Gets or Sets MatchedScanner
        /// </summary>
        [DataMember(Name = "matched_scanner", EmitDefaultValue = false)]
        public string MatchedScanner { get; private set; }

        /// <summary>
        /// Returns false as MatchedScanner should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMatchedScanner()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
        [DataMember(Name = "rating", EmitDefaultValue = false)]
        public decimal Rating { get; private set; }

        /// <summary>
        /// Returns false as Rating should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRating()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets WorkflowState
        /// </summary>
        [DataMember(Name = "workflow_state", EmitDefaultValue = false)]
        public int WorkflowState { get; private set; }

        /// <summary>
        /// Returns false as WorkflowState should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeWorkflowState()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets IsTemporary
        /// </summary>
        [DataMember(Name = "is_temporary", EmitDefaultValue = true)]
        public bool IsTemporary { get; private set; }

        /// <summary>
        /// Returns false as IsTemporary should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsTemporary()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime Created { get; private set; }

        /// <summary>
        /// Returns false as Created should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreated()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Modified
        /// </summary>
        [DataMember(Name = "modified", EmitDefaultValue = false)]
        public DateTime Modified { get; private set; }

        /// <summary>
        /// Returns false as Modified should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeModified()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Set
        /// </summary>
        [DataMember(Name = "set", EmitDefaultValue = true)]
        public int? Set { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Asset {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Proxies: ").Append(Proxies).Append("\n");
            sb.Append("  DefaultProxy: ").Append(DefaultProxy).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  ProxyInfo: ").Append(ProxyInfo).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  ResolvedPermission: ").Append(ResolvedPermission).Append("\n");
            sb.Append("  Backups: ").Append(Backups).Append("\n");
            sb.Append("  ProxiesGenerated: ").Append(ProxiesGenerated).Append("\n");
            sb.Append("  ProxiesFailed: ").Append(ProxiesFailed).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  Bundles: ").Append(Bundles).Append("\n");
            sb.Append("  SyncId: ").Append(SyncId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  HasFiles: ").Append(HasFiles).Append("\n");
            sb.Append("  HasBackups: ").Append(HasBackups).Append("\n");
            sb.Append("  HasCloudLinks: ").Append(HasCloudLinks).Append("\n");
            sb.Append("  Checksum: ").Append(Checksum).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ThumbnailGenerated: ").Append(ThumbnailGenerated).Append("\n");
            sb.Append("  MatchedScanner: ").Append(MatchedScanner).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  WorkflowState: ").Append(WorkflowState).Append("\n");
            sb.Append("  IsTemporary: ").Append(IsTemporary).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Set: ").Append(Set).Append("\n");
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
            return this.Equals(input as Asset);
        }

        /// <summary>
        /// Returns true if Asset instances are equal
        /// </summary>
        /// <param name="input">Instance of Asset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Asset input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Proxies == input.Proxies ||
                    this.Proxies != null &&
                    input.Proxies != null &&
                    this.Proxies.SequenceEqual(input.Proxies)
                ) && 
                (
                    this.DefaultProxy == input.DefaultProxy ||
                    (this.DefaultProxy != null &&
                    this.DefaultProxy.Equals(input.DefaultProxy))
                ) && 
                (
                    this.Info == input.Info ||
                    this.Info != null &&
                    input.Info != null &&
                    this.Info.SequenceEqual(input.Info)
                ) && 
                (
                    this.ProxyInfo == input.ProxyInfo ||
                    this.ProxyInfo != null &&
                    input.ProxyInfo != null &&
                    this.ProxyInfo.SequenceEqual(input.ProxyInfo)
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    input.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.ResolvedPermission == input.ResolvedPermission ||
                    (this.ResolvedPermission != null &&
                    this.ResolvedPermission.Equals(input.ResolvedPermission))
                ) && 
                (
                    this.Backups == input.Backups ||
                    (this.Backups != null &&
                    this.Backups.Equals(input.Backups))
                ) && 
                (
                    this.ProxiesGenerated == input.ProxiesGenerated ||
                    this.ProxiesGenerated.Equals(input.ProxiesGenerated)
                ) && 
                (
                    this.ProxiesFailed == input.ProxiesFailed ||
                    this.ProxiesFailed.Equals(input.ProxiesFailed)
                ) && 
                (
                    this.ModifiedBy == input.ModifiedBy ||
                    (this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(input.ModifiedBy))
                ) && 
                (
                    this.Bundles == input.Bundles ||
                    this.Bundles != null &&
                    input.Bundles != null &&
                    this.Bundles.SequenceEqual(input.Bundles)
                ) && 
                (
                    this.SyncId == input.SyncId ||
                    (this.SyncId != null &&
                    this.SyncId.Equals(input.SyncId))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.HasFiles == input.HasFiles ||
                    this.HasFiles.Equals(input.HasFiles)
                ) && 
                (
                    this.HasBackups == input.HasBackups ||
                    this.HasBackups.Equals(input.HasBackups)
                ) && 
                (
                    this.HasCloudLinks == input.HasCloudLinks ||
                    this.HasCloudLinks.Equals(input.HasCloudLinks)
                ) && 
                (
                    this.Checksum == input.Checksum ||
                    (this.Checksum != null &&
                    this.Checksum.Equals(input.Checksum))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ThumbnailGenerated == input.ThumbnailGenerated ||
                    this.ThumbnailGenerated.Equals(input.ThumbnailGenerated)
                ) && 
                (
                    this.MatchedScanner == input.MatchedScanner ||
                    (this.MatchedScanner != null &&
                    this.MatchedScanner.Equals(input.MatchedScanner))
                ) && 
                (
                    this.Rating == input.Rating ||
                    this.Rating.Equals(input.Rating)
                ) && 
                (
                    this.WorkflowState == input.WorkflowState ||
                    this.WorkflowState.Equals(input.WorkflowState)
                ) && 
                (
                    this.IsTemporary == input.IsTemporary ||
                    this.IsTemporary.Equals(input.IsTemporary)
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
                ) && 
                (
                    this.Set == input.Set ||
                    (this.Set != null &&
                    this.Set.Equals(input.Set))
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
                if (this.Proxies != null)
                    hashCode = hashCode * 59 + this.Proxies.GetHashCode();
                if (this.DefaultProxy != null)
                    hashCode = hashCode * 59 + this.DefaultProxy.GetHashCode();
                if (this.Info != null)
                    hashCode = hashCode * 59 + this.Info.GetHashCode();
                if (this.ProxyInfo != null)
                    hashCode = hashCode * 59 + this.ProxyInfo.GetHashCode();
                if (this.CustomFields != null)
                    hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.ResolvedPermission != null)
                    hashCode = hashCode * 59 + this.ResolvedPermission.GetHashCode();
                if (this.Backups != null)
                    hashCode = hashCode * 59 + this.Backups.GetHashCode();
                hashCode = hashCode * 59 + this.ProxiesGenerated.GetHashCode();
                hashCode = hashCode * 59 + this.ProxiesFailed.GetHashCode();
                if (this.ModifiedBy != null)
                    hashCode = hashCode * 59 + this.ModifiedBy.GetHashCode();
                if (this.Bundles != null)
                    hashCode = hashCode * 59 + this.Bundles.GetHashCode();
                if (this.SyncId != null)
                    hashCode = hashCode * 59 + this.SyncId.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                hashCode = hashCode * 59 + this.HasFiles.GetHashCode();
                hashCode = hashCode * 59 + this.HasBackups.GetHashCode();
                hashCode = hashCode * 59 + this.HasCloudLinks.GetHashCode();
                if (this.Checksum != null)
                    hashCode = hashCode * 59 + this.Checksum.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.ThumbnailGenerated.GetHashCode();
                if (this.MatchedScanner != null)
                    hashCode = hashCode * 59 + this.MatchedScanner.GetHashCode();
                hashCode = hashCode * 59 + this.Rating.GetHashCode();
                hashCode = hashCode * 59 + this.WorkflowState.GetHashCode();
                hashCode = hashCode * 59 + this.IsTemporary.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
                if (this.Set != null)
                    hashCode = hashCode * 59 + this.Set.GetHashCode();
                return hashCode;
            }
        }

    }

}
