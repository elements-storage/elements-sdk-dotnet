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
    /// DownloadArchive
    /// </summary>
    [DataContract(Name = "DownloadArchive")]
    public partial class DownloadArchive : IEquatable<DownloadArchive>
    {
        /// <summary>
        /// Defines ProgressUnit
        /// </summary>
        public enum ProgressUnitEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0,

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1

        }


        /// <summary>
        /// Gets or Sets ProgressUnit
        /// </summary>
        [DataMember(Name = "progress_unit", EmitDefaultValue = false)]
        public ProgressUnitEnum? ProgressUnit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadArchive" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DownloadArchive() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadArchive" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="taskInfo">taskInfo (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="path">path (required).</param>
        /// <param name="progressUnit">progressUnit.</param>
        /// <param name="user">user.</param>
        public DownloadArchive(Guid id = default(Guid), TaskInfo taskInfo = default(TaskInfo), string name = default(string), string path = default(string), ProgressUnitEnum? progressUnit = default(ProgressUnitEnum?), int? user = default(int?))
        {
            // to ensure "taskInfo" is required (not null)
            this.TaskInfo = taskInfo ?? throw new ArgumentNullException("taskInfo is a required property for DownloadArchive and cannot be null");
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for DownloadArchive and cannot be null");
            // to ensure "path" is required (not null)
            this.Path = path ?? throw new ArgumentNullException("path is a required property for DownloadArchive and cannot be null");
            this.Id = id;
            this.ProgressUnit = progressUnit;
            this.User = user;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets TaskInfo
        /// </summary>
        [DataMember(Name = "task_info", IsRequired = true, EmitDefaultValue = false)]
        public TaskInfo TaskInfo { get; set; }

        /// <summary>
        /// Gets or Sets UncompressedSize
        /// </summary>
        [DataMember(Name = "uncompressed_size", EmitDefaultValue = false)]
        public int UncompressedSize { get; private set; }

        /// <summary>
        /// Returns false as UncompressedSize should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUncompressedSize()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public int Size { get; private set; }

        /// <summary>
        /// Returns false as Size should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSize()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Expires
        /// </summary>
        [DataMember(Name = "expires", EmitDefaultValue = false)]
        public string Expires { get; private set; }

        /// <summary>
        /// Returns false as Expires should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExpires()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Files
        /// </summary>
        [DataMember(Name = "files", EmitDefaultValue = false)]
        public List<string> Files { get; private set; }

        /// <summary>
        /// Returns false as Files should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFiles()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name = "path", IsRequired = true, EmitDefaultValue = false)]
        public string Path { get; set; }

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
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = true)]
        public int? User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadArchive {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TaskInfo: ").Append(TaskInfo).Append("\n");
            sb.Append("  UncompressedSize: ").Append(UncompressedSize).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ProgressUnit: ").Append(ProgressUnit).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(input as DownloadArchive);
        }

        /// <summary>
        /// Returns true if DownloadArchive instances are equal
        /// </summary>
        /// <param name="input">Instance of DownloadArchive to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DownloadArchive input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.TaskInfo == input.TaskInfo ||
                    (this.TaskInfo != null &&
                    this.TaskInfo.Equals(input.TaskInfo))
                ) && 
                (
                    this.UncompressedSize == input.UncompressedSize ||
                    this.UncompressedSize.Equals(input.UncompressedSize)
                ) && 
                (
                    this.Size == input.Size ||
                    this.Size.Equals(input.Size)
                ) && 
                (
                    this.Expires == input.Expires ||
                    (this.Expires != null &&
                    this.Expires.Equals(input.Expires))
                ) && 
                (
                    this.Files == input.Files ||
                    this.Files != null &&
                    input.Files != null &&
                    this.Files.SequenceEqual(input.Files)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.ProgressUnit == input.ProgressUnit ||
                    this.ProgressUnit.Equals(input.ProgressUnit)
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.TaskInfo != null)
                    hashCode = hashCode * 59 + this.TaskInfo.GetHashCode();
                hashCode = hashCode * 59 + this.UncompressedSize.GetHashCode();
                hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Expires != null)
                    hashCode = hashCode * 59 + this.Expires.GetHashCode();
                if (this.Files != null)
                    hashCode = hashCode * 59 + this.Files.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                hashCode = hashCode * 59 + this.ProgressUnit.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                return hashCode;
            }
        }

    }

}