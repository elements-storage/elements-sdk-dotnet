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
    /// VolumePartialUpdate
    /// </summary>
    [DataContract(Name = "VolumePartialUpdate")]
    public partial class VolumePartialUpdate : IEquatable<VolumePartialUpdate>
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Generic for value: generic
            /// </summary>
            [EnumMember(Value = "generic")]
            Generic = 1,

            /// <summary>
            /// Enum GenericMount for value: generic-mount
            /// </summary>
            [EnumMember(Value = "generic-mount")]
            GenericMount = 2,

            /// <summary>
            /// Enum Snfs for value: snfs
            /// </summary>
            [EnumMember(Value = "snfs")]
            Snfs = 3,

            /// <summary>
            /// Enum Btrfs for value: btrfs
            /// </summary>
            [EnumMember(Value = "btrfs")]
            Btrfs = 4,

            /// <summary>
            /// Enum S3fs for value: s3fs
            /// </summary>
            [EnumMember(Value = "s3fs")]
            S3fs = 5,

            /// <summary>
            /// Enum Lizardfs for value: lizardfs
            /// </summary>
            [EnumMember(Value = "lizardfs")]
            Lizardfs = 6,

            /// <summary>
            /// Enum Bcachefs for value: bcachefs
            /// </summary>
            [EnumMember(Value = "bcachefs")]
            Bcachefs = 7,

            /// <summary>
            /// Enum Isilon for value: isilon
            /// </summary>
            [EnumMember(Value = "isilon")]
            Isilon = 8,

            /// <summary>
            /// Enum Beegfs for value: beegfs
            /// </summary>
            [EnumMember(Value = "beegfs")]
            Beegfs = 9

        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VolumePartialUpdate" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="nodes">nodes.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="visualTag">visualTag.</param>
        /// <param name="isDefault">isDefault.</param>
        /// <param name="useForHomes">useForHomes.</param>
        /// <param name="useForWorkspaces">useForWorkspaces.</param>
        /// <param name="type">type.</param>
        /// <param name="snmEnabled">snmEnabled.</param>
        /// <param name="snfsName">snfsName.</param>
        /// <param name="simulatedQuotas">simulatedQuotas.</param>
        public VolumePartialUpdate(string name = default(string), List<int> nodes = default(List<int>), string displayName = default(string), string visualTag = default(string), bool isDefault = default(bool), bool useForHomes = default(bool), bool useForWorkspaces = default(bool), TypeEnum? type = default(TypeEnum?), bool snmEnabled = default(bool), string snfsName = default(string), bool simulatedQuotas = default(bool))
        {
            this.Name = name;
            this.Nodes = nodes;
            this.DisplayName = displayName;
            this.VisualTag = visualTag;
            this.IsDefault = isDefault;
            this.UseForHomes = useForHomes;
            this.UseForWorkspaces = useForWorkspaces;
            this.Type = type;
            this.SnmEnabled = snmEnabled;
            this.SnfsName = snfsName;
            this.SimulatedQuotas = simulatedQuotas;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Nodes
        /// </summary>
        [DataMember(Name = "nodes", EmitDefaultValue = false)]
        public List<int> Nodes { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "display_name", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets VisualTag
        /// </summary>
        [DataMember(Name = "visual_tag", EmitDefaultValue = true)]
        public string VisualTag { get; set; }

        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        [DataMember(Name = "is_default", EmitDefaultValue = true)]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Gets or Sets UseForHomes
        /// </summary>
        [DataMember(Name = "use_for_homes", EmitDefaultValue = true)]
        public bool UseForHomes { get; set; }

        /// <summary>
        /// Gets or Sets UseForWorkspaces
        /// </summary>
        [DataMember(Name = "use_for_workspaces", EmitDefaultValue = true)]
        public bool UseForWorkspaces { get; set; }

        /// <summary>
        /// Gets or Sets SnmEnabled
        /// </summary>
        [DataMember(Name = "snm_enabled", EmitDefaultValue = true)]
        public bool SnmEnabled { get; set; }

        /// <summary>
        /// Gets or Sets SnfsName
        /// </summary>
        [DataMember(Name = "snfs_name", EmitDefaultValue = true)]
        public string SnfsName { get; set; }

        /// <summary>
        /// Gets or Sets SimulatedQuotas
        /// </summary>
        [DataMember(Name = "simulated_quotas", EmitDefaultValue = true)]
        public bool SimulatedQuotas { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VolumePartialUpdate {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Nodes: ").Append(Nodes).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  VisualTag: ").Append(VisualTag).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  UseForHomes: ").Append(UseForHomes).Append("\n");
            sb.Append("  UseForWorkspaces: ").Append(UseForWorkspaces).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SnmEnabled: ").Append(SnmEnabled).Append("\n");
            sb.Append("  SnfsName: ").Append(SnfsName).Append("\n");
            sb.Append("  SimulatedQuotas: ").Append(SimulatedQuotas).Append("\n");
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
            return this.Equals(input as VolumePartialUpdate);
        }

        /// <summary>
        /// Returns true if VolumePartialUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of VolumePartialUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VolumePartialUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Nodes == input.Nodes ||
                    this.Nodes != null &&
                    input.Nodes != null &&
                    this.Nodes.SequenceEqual(input.Nodes)
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.VisualTag == input.VisualTag ||
                    (this.VisualTag != null &&
                    this.VisualTag.Equals(input.VisualTag))
                ) && 
                (
                    this.IsDefault == input.IsDefault ||
                    this.IsDefault.Equals(input.IsDefault)
                ) && 
                (
                    this.UseForHomes == input.UseForHomes ||
                    this.UseForHomes.Equals(input.UseForHomes)
                ) && 
                (
                    this.UseForWorkspaces == input.UseForWorkspaces ||
                    this.UseForWorkspaces.Equals(input.UseForWorkspaces)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.SnmEnabled == input.SnmEnabled ||
                    this.SnmEnabled.Equals(input.SnmEnabled)
                ) && 
                (
                    this.SnfsName == input.SnfsName ||
                    (this.SnfsName != null &&
                    this.SnfsName.Equals(input.SnfsName))
                ) && 
                (
                    this.SimulatedQuotas == input.SimulatedQuotas ||
                    this.SimulatedQuotas.Equals(input.SimulatedQuotas)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Nodes != null)
                    hashCode = hashCode * 59 + this.Nodes.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.VisualTag != null)
                    hashCode = hashCode * 59 + this.VisualTag.GetHashCode();
                hashCode = hashCode * 59 + this.IsDefault.GetHashCode();
                hashCode = hashCode * 59 + this.UseForHomes.GetHashCode();
                hashCode = hashCode * 59 + this.UseForWorkspaces.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.SnmEnabled.GetHashCode();
                if (this.SnfsName != null)
                    hashCode = hashCode * 59 + this.SnfsName.GetHashCode();
                hashCode = hashCode * 59 + this.SimulatedQuotas.GetHashCode();
                return hashCode;
            }
        }

    }

}