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
    /// FilesystemFile
    /// </summary>
    [DataContract(Name = "FilesystemFile")]
    public partial class FilesystemFile : IEquatable<FilesystemFile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilesystemFile" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FilesystemFile() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FilesystemFile" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="files">files.</param>
        /// <param name="parent">parent (required).</param>
        /// <param name="mode">mode.</param>
        /// <param name="uid">uid.</param>
        /// <param name="gid">gid.</param>
        /// <param name="user">user.</param>
        /// <param name="group">group.</param>
        /// <param name="recursive">recursive.</param>
        /// <param name="affinity">affinity.</param>
        /// <param name="modeSetuid">modeSetuid.</param>
        /// <param name="modeSetgid">modeSetgid.</param>
        /// <param name="modeSetvfx">modeSetvfx.</param>
        /// <param name="modeUserRead">modeUserRead.</param>
        /// <param name="modeUserWrite">modeUserWrite.</param>
        /// <param name="modeUserExecute">modeUserExecute.</param>
        /// <param name="modeGroupRead">modeGroupRead.</param>
        /// <param name="modeGroupWrite">modeGroupWrite.</param>
        /// <param name="modeGroupExecute">modeGroupExecute.</param>
        /// <param name="modeOthersRead">modeOthersRead.</param>
        /// <param name="modeOthersWrite">modeOthersWrite.</param>
        /// <param name="modeOthersExecute">modeOthersExecute.</param>
        public FilesystemFile(string name = default(string), List<BasicFile> files = default(List<BasicFile>), string parent = default(string), string mode = default(string), int uid = default(int), int gid = default(int), string user = default(string), string group = default(string), bool recursive = default(bool), string affinity = default(string), bool modeSetuid = default(bool), bool modeSetgid = default(bool), bool modeSetvfx = default(bool), bool modeUserRead = default(bool), bool modeUserWrite = default(bool), bool modeUserExecute = default(bool), bool modeGroupRead = default(bool), bool modeGroupWrite = default(bool), bool modeGroupExecute = default(bool), bool modeOthersRead = default(bool), bool modeOthersWrite = default(bool), bool modeOthersExecute = default(bool))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for FilesystemFile and cannot be null");
            // to ensure "parent" is required (not null)
            this.Parent = parent ?? throw new ArgumentNullException("parent is a required property for FilesystemFile and cannot be null");
            this.Files = files;
            this.Mode = mode;
            this.Uid = uid;
            this.Gid = gid;
            this.User = user;
            this.Group = group;
            this.Recursive = recursive;
            this.Affinity = affinity;
            this.ModeSetuid = modeSetuid;
            this.ModeSetgid = modeSetgid;
            this.ModeSetvfx = modeSetvfx;
            this.ModeUserRead = modeUserRead;
            this.ModeUserWrite = modeUserWrite;
            this.ModeUserExecute = modeUserExecute;
            this.ModeGroupRead = modeGroupRead;
            this.ModeGroupWrite = modeGroupWrite;
            this.ModeGroupExecute = modeGroupExecute;
            this.ModeOthersRead = modeOthersRead;
            this.ModeOthersWrite = modeOthersWrite;
            this.ModeOthersExecute = modeOthersExecute;
        }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path { get; private set; }

        /// <summary>
        /// Returns false as Path should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePath()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

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
        /// Gets or Sets TotalSize
        /// </summary>
        [DataMember(Name = "total_size", EmitDefaultValue = false)]
        public int TotalSize { get; private set; }

        /// <summary>
        /// Returns false as TotalSize should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTotalSize()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets IsDir
        /// </summary>
        [DataMember(Name = "is_dir", EmitDefaultValue = true)]
        public bool IsDir { get; private set; }

        /// <summary>
        /// Returns false as IsDir should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsDir()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Files
        /// </summary>
        [DataMember(Name = "files", EmitDefaultValue = true)]
        public List<BasicFile> Files { get; set; }

        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name = "parent", IsRequired = true, EmitDefaultValue = false)]
        public string Parent { get; set; }

        /// <summary>
        /// Gets or Sets ModificationTime
        /// </summary>
        [DataMember(Name = "modification_time", EmitDefaultValue = false)]
        public DateTime ModificationTime { get; private set; }

        /// <summary>
        /// Returns false as ModificationTime should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeModificationTime()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets AccessTime
        /// </summary>
        [DataMember(Name = "access_time", EmitDefaultValue = false)]
        public DateTime AccessTime { get; private set; }

        /// <summary>
        /// Returns false as AccessTime should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAccessTime()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CreationTime
        /// </summary>
        [DataMember(Name = "creation_time", EmitDefaultValue = false)]
        public DateTime CreationTime { get; private set; }

        /// <summary>
        /// Returns false as CreationTime should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreationTime()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name = "mode", EmitDefaultValue = false)]
        public string Mode { get; set; }

        /// <summary>
        /// Gets or Sets Uid
        /// </summary>
        [DataMember(Name = "uid", EmitDefaultValue = false)]
        public int Uid { get; set; }

        /// <summary>
        /// Gets or Sets Gid
        /// </summary>
        [DataMember(Name = "gid", EmitDefaultValue = false)]
        public int Gid { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public string User { get; set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name = "group", EmitDefaultValue = false)]
        public string Group { get; set; }

        /// <summary>
        /// Gets or Sets Recursive
        /// </summary>
        [DataMember(Name = "recursive", EmitDefaultValue = true)]
        public bool Recursive { get; set; }

        /// <summary>
        /// Gets or Sets Affinity
        /// </summary>
        [DataMember(Name = "affinity", EmitDefaultValue = true)]
        public string Affinity { get; set; }

        /// <summary>
        /// Gets or Sets ModeSetuid
        /// </summary>
        [DataMember(Name = "mode_setuid", EmitDefaultValue = true)]
        public bool ModeSetuid { get; set; }

        /// <summary>
        /// Gets or Sets ModeSetgid
        /// </summary>
        [DataMember(Name = "mode_setgid", EmitDefaultValue = true)]
        public bool ModeSetgid { get; set; }

        /// <summary>
        /// Gets or Sets ModeSetvfx
        /// </summary>
        [DataMember(Name = "mode_setvfx", EmitDefaultValue = true)]
        public bool ModeSetvfx { get; set; }

        /// <summary>
        /// Gets or Sets ModeUserRead
        /// </summary>
        [DataMember(Name = "mode_user_read", EmitDefaultValue = true)]
        public bool ModeUserRead { get; set; }

        /// <summary>
        /// Gets or Sets ModeUserWrite
        /// </summary>
        [DataMember(Name = "mode_user_write", EmitDefaultValue = true)]
        public bool ModeUserWrite { get; set; }

        /// <summary>
        /// Gets or Sets ModeUserExecute
        /// </summary>
        [DataMember(Name = "mode_user_execute", EmitDefaultValue = true)]
        public bool ModeUserExecute { get; set; }

        /// <summary>
        /// Gets or Sets ModeGroupRead
        /// </summary>
        [DataMember(Name = "mode_group_read", EmitDefaultValue = true)]
        public bool ModeGroupRead { get; set; }

        /// <summary>
        /// Gets or Sets ModeGroupWrite
        /// </summary>
        [DataMember(Name = "mode_group_write", EmitDefaultValue = true)]
        public bool ModeGroupWrite { get; set; }

        /// <summary>
        /// Gets or Sets ModeGroupExecute
        /// </summary>
        [DataMember(Name = "mode_group_execute", EmitDefaultValue = true)]
        public bool ModeGroupExecute { get; set; }

        /// <summary>
        /// Gets or Sets ModeOthersRead
        /// </summary>
        [DataMember(Name = "mode_others_read", EmitDefaultValue = true)]
        public bool ModeOthersRead { get; set; }

        /// <summary>
        /// Gets or Sets ModeOthersWrite
        /// </summary>
        [DataMember(Name = "mode_others_write", EmitDefaultValue = true)]
        public bool ModeOthersWrite { get; set; }

        /// <summary>
        /// Gets or Sets ModeOthersExecute
        /// </summary>
        [DataMember(Name = "mode_others_execute", EmitDefaultValue = true)]
        public bool ModeOthersExecute { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilesystemFile {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  TotalSize: ").Append(TotalSize).Append("\n");
            sb.Append("  IsDir: ").Append(IsDir).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  ModificationTime: ").Append(ModificationTime).Append("\n");
            sb.Append("  AccessTime: ").Append(AccessTime).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  Gid: ").Append(Gid).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Recursive: ").Append(Recursive).Append("\n");
            sb.Append("  Affinity: ").Append(Affinity).Append("\n");
            sb.Append("  ModeSetuid: ").Append(ModeSetuid).Append("\n");
            sb.Append("  ModeSetgid: ").Append(ModeSetgid).Append("\n");
            sb.Append("  ModeSetvfx: ").Append(ModeSetvfx).Append("\n");
            sb.Append("  ModeUserRead: ").Append(ModeUserRead).Append("\n");
            sb.Append("  ModeUserWrite: ").Append(ModeUserWrite).Append("\n");
            sb.Append("  ModeUserExecute: ").Append(ModeUserExecute).Append("\n");
            sb.Append("  ModeGroupRead: ").Append(ModeGroupRead).Append("\n");
            sb.Append("  ModeGroupWrite: ").Append(ModeGroupWrite).Append("\n");
            sb.Append("  ModeGroupExecute: ").Append(ModeGroupExecute).Append("\n");
            sb.Append("  ModeOthersRead: ").Append(ModeOthersRead).Append("\n");
            sb.Append("  ModeOthersWrite: ").Append(ModeOthersWrite).Append("\n");
            sb.Append("  ModeOthersExecute: ").Append(ModeOthersExecute).Append("\n");
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
            return this.Equals(input as FilesystemFile);
        }

        /// <summary>
        /// Returns true if FilesystemFile instances are equal
        /// </summary>
        /// <param name="input">Instance of FilesystemFile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilesystemFile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Size == input.Size ||
                    this.Size.Equals(input.Size)
                ) && 
                (
                    this.TotalSize == input.TotalSize ||
                    this.TotalSize.Equals(input.TotalSize)
                ) && 
                (
                    this.IsDir == input.IsDir ||
                    this.IsDir.Equals(input.IsDir)
                ) && 
                (
                    this.Files == input.Files ||
                    this.Files != null &&
                    input.Files != null &&
                    this.Files.SequenceEqual(input.Files)
                ) && 
                (
                    this.Parent == input.Parent ||
                    (this.Parent != null &&
                    this.Parent.Equals(input.Parent))
                ) && 
                (
                    this.ModificationTime == input.ModificationTime ||
                    (this.ModificationTime != null &&
                    this.ModificationTime.Equals(input.ModificationTime))
                ) && 
                (
                    this.AccessTime == input.AccessTime ||
                    (this.AccessTime != null &&
                    this.AccessTime.Equals(input.AccessTime))
                ) && 
                (
                    this.CreationTime == input.CreationTime ||
                    (this.CreationTime != null &&
                    this.CreationTime.Equals(input.CreationTime))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.Uid == input.Uid ||
                    this.Uid.Equals(input.Uid)
                ) && 
                (
                    this.Gid == input.Gid ||
                    this.Gid.Equals(input.Gid)
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.Recursive == input.Recursive ||
                    this.Recursive.Equals(input.Recursive)
                ) && 
                (
                    this.Affinity == input.Affinity ||
                    (this.Affinity != null &&
                    this.Affinity.Equals(input.Affinity))
                ) && 
                (
                    this.ModeSetuid == input.ModeSetuid ||
                    this.ModeSetuid.Equals(input.ModeSetuid)
                ) && 
                (
                    this.ModeSetgid == input.ModeSetgid ||
                    this.ModeSetgid.Equals(input.ModeSetgid)
                ) && 
                (
                    this.ModeSetvfx == input.ModeSetvfx ||
                    this.ModeSetvfx.Equals(input.ModeSetvfx)
                ) && 
                (
                    this.ModeUserRead == input.ModeUserRead ||
                    this.ModeUserRead.Equals(input.ModeUserRead)
                ) && 
                (
                    this.ModeUserWrite == input.ModeUserWrite ||
                    this.ModeUserWrite.Equals(input.ModeUserWrite)
                ) && 
                (
                    this.ModeUserExecute == input.ModeUserExecute ||
                    this.ModeUserExecute.Equals(input.ModeUserExecute)
                ) && 
                (
                    this.ModeGroupRead == input.ModeGroupRead ||
                    this.ModeGroupRead.Equals(input.ModeGroupRead)
                ) && 
                (
                    this.ModeGroupWrite == input.ModeGroupWrite ||
                    this.ModeGroupWrite.Equals(input.ModeGroupWrite)
                ) && 
                (
                    this.ModeGroupExecute == input.ModeGroupExecute ||
                    this.ModeGroupExecute.Equals(input.ModeGroupExecute)
                ) && 
                (
                    this.ModeOthersRead == input.ModeOthersRead ||
                    this.ModeOthersRead.Equals(input.ModeOthersRead)
                ) && 
                (
                    this.ModeOthersWrite == input.ModeOthersWrite ||
                    this.ModeOthersWrite.Equals(input.ModeOthersWrite)
                ) && 
                (
                    this.ModeOthersExecute == input.ModeOthersExecute ||
                    this.ModeOthersExecute.Equals(input.ModeOthersExecute)
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
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Size.GetHashCode();
                hashCode = hashCode * 59 + this.TotalSize.GetHashCode();
                hashCode = hashCode * 59 + this.IsDir.GetHashCode();
                if (this.Files != null)
                    hashCode = hashCode * 59 + this.Files.GetHashCode();
                if (this.Parent != null)
                    hashCode = hashCode * 59 + this.Parent.GetHashCode();
                if (this.ModificationTime != null)
                    hashCode = hashCode * 59 + this.ModificationTime.GetHashCode();
                if (this.AccessTime != null)
                    hashCode = hashCode * 59 + this.AccessTime.GetHashCode();
                if (this.CreationTime != null)
                    hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                hashCode = hashCode * 59 + this.Uid.GetHashCode();
                hashCode = hashCode * 59 + this.Gid.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                hashCode = hashCode * 59 + this.Recursive.GetHashCode();
                if (this.Affinity != null)
                    hashCode = hashCode * 59 + this.Affinity.GetHashCode();
                hashCode = hashCode * 59 + this.ModeSetuid.GetHashCode();
                hashCode = hashCode * 59 + this.ModeSetgid.GetHashCode();
                hashCode = hashCode * 59 + this.ModeSetvfx.GetHashCode();
                hashCode = hashCode * 59 + this.ModeUserRead.GetHashCode();
                hashCode = hashCode * 59 + this.ModeUserWrite.GetHashCode();
                hashCode = hashCode * 59 + this.ModeUserExecute.GetHashCode();
                hashCode = hashCode * 59 + this.ModeGroupRead.GetHashCode();
                hashCode = hashCode * 59 + this.ModeGroupWrite.GetHashCode();
                hashCode = hashCode * 59 + this.ModeGroupExecute.GetHashCode();
                hashCode = hashCode * 59 + this.ModeOthersRead.GetHashCode();
                hashCode = hashCode * 59 + this.ModeOthersWrite.GetHashCode();
                hashCode = hashCode * 59 + this.ModeOthersExecute.GetHashCode();
                return hashCode;
            }
        }

    }

}
