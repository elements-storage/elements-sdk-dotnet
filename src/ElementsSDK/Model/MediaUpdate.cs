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
    /// MediaUpdate
    /// </summary>
    [DataContract(Name = "MediaUpdate")]
    public partial class MediaUpdate : IEquatable<MediaUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MediaUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaUpdate" /> class.
        /// </summary>
        /// <param name="asset">asset.</param>
        /// <param name="comment">comment.</param>
        /// <param name="directory">directory.</param>
        /// <param name="root">root.</param>
        /// <param name="user">user.</param>
        /// <param name="customFieldsDiff">customFieldsDiff (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="rating">rating.</param>
        public MediaUpdate(AssetMini asset = default(AssetMini), Comment comment = default(Comment), MediaFile directory = default(MediaFile), MediaRootMini root = default(MediaRootMini), ElementsUserMini user = default(ElementsUserMini), Dictionary<string, string> customFieldsDiff = default(Dictionary<string, string>), string type = default(string), int? rating = default(int?))
        {
            // to ensure "customFieldsDiff" is required (not null)
            this.CustomFieldsDiff = customFieldsDiff ?? throw new ArgumentNullException("customFieldsDiff is a required property for MediaUpdate and cannot be null");
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for MediaUpdate and cannot be null");
            this.Asset = asset;
            this.Comment = comment;
            this.Directory = directory;
            this.Root = root;
            this.User = user;
            this.Rating = rating;
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
        /// Gets or Sets Asset
        /// </summary>
        [DataMember(Name = "asset", EmitDefaultValue = false)]
        public AssetMini Asset { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        public Comment Comment { get; set; }

        /// <summary>
        /// Gets or Sets Directory
        /// </summary>
        [DataMember(Name = "directory", EmitDefaultValue = false)]
        public MediaFile Directory { get; set; }

        /// <summary>
        /// Gets or Sets Root
        /// </summary>
        [DataMember(Name = "root", EmitDefaultValue = false)]
        public MediaRootMini Root { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public ElementsUserMini User { get; set; }

        /// <summary>
        /// Gets or Sets CustomFieldsDiff
        /// </summary>
        [DataMember(Name = "custom_fields_diff", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, string> CustomFieldsDiff { get; set; }

        /// <summary>
        /// Gets or Sets AddedTags
        /// </summary>
        [DataMember(Name = "added_tags", EmitDefaultValue = false)]
        public List<UnfilteredTag> AddedTags { get; private set; }

        /// <summary>
        /// Returns false as AddedTags should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAddedTags()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets RemovedTags
        /// </summary>
        [DataMember(Name = "removed_tags", EmitDefaultValue = false)]
        public List<UnfilteredTag> RemovedTags { get; private set; }

        /// <summary>
        /// Returns false as RemovedTags should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRemovedTags()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public DateTime Date { get; private set; }

        /// <summary>
        /// Returns false as Date should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDate()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
        [DataMember(Name = "rating", EmitDefaultValue = true)]
        public int? Rating { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaUpdate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Asset: ").Append(Asset).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Directory: ").Append(Directory).Append("\n");
            sb.Append("  Root: ").Append(Root).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  CustomFieldsDiff: ").Append(CustomFieldsDiff).Append("\n");
            sb.Append("  AddedTags: ").Append(AddedTags).Append("\n");
            sb.Append("  RemovedTags: ").Append(RemovedTags).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
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
            return this.Equals(input as MediaUpdate);
        }

        /// <summary>
        /// Returns true if MediaUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of MediaUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Asset == input.Asset ||
                    (this.Asset != null &&
                    this.Asset.Equals(input.Asset))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Directory == input.Directory ||
                    (this.Directory != null &&
                    this.Directory.Equals(input.Directory))
                ) && 
                (
                    this.Root == input.Root ||
                    (this.Root != null &&
                    this.Root.Equals(input.Root))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.CustomFieldsDiff == input.CustomFieldsDiff ||
                    this.CustomFieldsDiff != null &&
                    input.CustomFieldsDiff != null &&
                    this.CustomFieldsDiff.SequenceEqual(input.CustomFieldsDiff)
                ) && 
                (
                    this.AddedTags == input.AddedTags ||
                    this.AddedTags != null &&
                    input.AddedTags != null &&
                    this.AddedTags.SequenceEqual(input.AddedTags)
                ) && 
                (
                    this.RemovedTags == input.RemovedTags ||
                    this.RemovedTags != null &&
                    input.RemovedTags != null &&
                    this.RemovedTags.SequenceEqual(input.RemovedTags)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Rating == input.Rating ||
                    (this.Rating != null &&
                    this.Rating.Equals(input.Rating))
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
                if (this.Asset != null)
                    hashCode = hashCode * 59 + this.Asset.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.Directory != null)
                    hashCode = hashCode * 59 + this.Directory.GetHashCode();
                if (this.Root != null)
                    hashCode = hashCode * 59 + this.Root.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.CustomFieldsDiff != null)
                    hashCode = hashCode * 59 + this.CustomFieldsDiff.GetHashCode();
                if (this.AddedTags != null)
                    hashCode = hashCode * 59 + this.AddedTags.GetHashCode();
                if (this.RemovedTags != null)
                    hashCode = hashCode * 59 + this.RemovedTags.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Rating != null)
                    hashCode = hashCode * 59 + this.Rating.GetHashCode();
                return hashCode;
            }
        }

    }

}
