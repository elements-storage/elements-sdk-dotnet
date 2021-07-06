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
    /// AssetBackup
    /// </summary>
    [DataContract(Name = "AssetBackup")]
    public partial class AssetBackup : IEquatable<AssetBackup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetBackup" /> class.
        /// </summary>
        /// <param name="tapeFile">tapeFile.</param>
        /// <param name="asset">asset.</param>
        /// <param name="customFieldsSnapshot">customFieldsSnapshot.</param>
        public AssetBackup(TapeFile tapeFile = default(TapeFile), Asset asset = default(Asset), string customFieldsSnapshot = default(string))
        {
            this.TapeFile = tapeFile;
            this.Asset = asset;
            this.CustomFieldsSnapshot = customFieldsSnapshot;
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
        /// Gets or Sets TapeFile
        /// </summary>
        [DataMember(Name = "tape_file", EmitDefaultValue = false)]
        public TapeFile TapeFile { get; set; }

        /// <summary>
        /// Gets or Sets Asset
        /// </summary>
        [DataMember(Name = "asset", EmitDefaultValue = false)]
        public Asset Asset { get; set; }

        /// <summary>
        /// Gets or Sets SearchHighlight
        /// </summary>
        [DataMember(Name = "search_highlight", EmitDefaultValue = false)]
        public string SearchHighlight { get; private set; }

        /// <summary>
        /// Returns false as SearchHighlight should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSearchHighlight()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets CustomFieldsSnapshot
        /// </summary>
        [DataMember(Name = "custom_fields_snapshot", EmitDefaultValue = true)]
        public string CustomFieldsSnapshot { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetBackup {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TapeFile: ").Append(TapeFile).Append("\n");
            sb.Append("  Asset: ").Append(Asset).Append("\n");
            sb.Append("  SearchHighlight: ").Append(SearchHighlight).Append("\n");
            sb.Append("  CustomFieldsSnapshot: ").Append(CustomFieldsSnapshot).Append("\n");
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
            return this.Equals(input as AssetBackup);
        }

        /// <summary>
        /// Returns true if AssetBackup instances are equal
        /// </summary>
        /// <param name="input">Instance of AssetBackup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetBackup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.TapeFile == input.TapeFile ||
                    (this.TapeFile != null &&
                    this.TapeFile.Equals(input.TapeFile))
                ) && 
                (
                    this.Asset == input.Asset ||
                    (this.Asset != null &&
                    this.Asset.Equals(input.Asset))
                ) && 
                (
                    this.SearchHighlight == input.SearchHighlight ||
                    (this.SearchHighlight != null &&
                    this.SearchHighlight.Equals(input.SearchHighlight))
                ) && 
                (
                    this.CustomFieldsSnapshot == input.CustomFieldsSnapshot ||
                    (this.CustomFieldsSnapshot != null &&
                    this.CustomFieldsSnapshot.Equals(input.CustomFieldsSnapshot))
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
                if (this.TapeFile != null)
                    hashCode = hashCode * 59 + this.TapeFile.GetHashCode();
                if (this.Asset != null)
                    hashCode = hashCode * 59 + this.Asset.GetHashCode();
                if (this.SearchHighlight != null)
                    hashCode = hashCode * 59 + this.SearchHighlight.GetHashCode();
                if (this.CustomFieldsSnapshot != null)
                    hashCode = hashCode * 59 + this.CustomFieldsSnapshot.GetHashCode();
                return hashCode;
            }
        }

    }

}