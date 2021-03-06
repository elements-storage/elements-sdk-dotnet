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
    /// BeeGFSTarget
    /// </summary>
    [DataContract(Name = "BeeGFSTarget")]
    public partial class BeeGFSTarget : IEquatable<BeeGFSTarget>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeeGFSTarget" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BeeGFSTarget() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BeeGFSTarget" /> class.
        /// </summary>
        /// <param name="node">node.</param>
        /// <param name="id">id (required).</param>
        /// <param name="host">host (required).</param>
        /// <param name="storagePool">storagePool (required).</param>
        /// <param name="sizeTotal">sizeTotal (required).</param>
        /// <param name="sizeUsed">sizeUsed (required).</param>
        /// <param name="sizeFree">sizeFree (required).</param>
        /// <param name="online">online (required).</param>
        /// <param name="consistent">consistent (required).</param>
        /// <param name="errors">errors (required).</param>
        public BeeGFSTarget(StorageNodeMini node = default(StorageNodeMini), int id = default(int), string host = default(string), int storagePool = default(int), int sizeTotal = default(int), int sizeUsed = default(int), int sizeFree = default(int), bool online = default(bool), bool consistent = default(bool), List<string> errors = default(List<string>))
        {
            this.Id = id;
            // to ensure "host" is required (not null)
            this.Host = host ?? throw new ArgumentNullException("host is a required property for BeeGFSTarget and cannot be null");
            this.StoragePool = storagePool;
            this.SizeTotal = sizeTotal;
            this.SizeUsed = sizeUsed;
            this.SizeFree = sizeFree;
            this.Online = online;
            this.Consistent = consistent;
            // to ensure "errors" is required (not null)
            this.Errors = errors ?? throw new ArgumentNullException("errors is a required property for BeeGFSTarget and cannot be null");
            this.Node = node;
        }

        /// <summary>
        /// Gets or Sets Node
        /// </summary>
        [DataMember(Name = "node", EmitDefaultValue = false)]
        public StorageNodeMini Node { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Host
        /// </summary>
        [DataMember(Name = "host", IsRequired = true, EmitDefaultValue = false)]
        public string Host { get; set; }

        /// <summary>
        /// Gets or Sets StoragePool
        /// </summary>
        [DataMember(Name = "storage_pool", IsRequired = true, EmitDefaultValue = false)]
        public int StoragePool { get; set; }

        /// <summary>
        /// Gets or Sets SizeTotal
        /// </summary>
        [DataMember(Name = "size_total", IsRequired = true, EmitDefaultValue = false)]
        public int SizeTotal { get; set; }

        /// <summary>
        /// Gets or Sets SizeUsed
        /// </summary>
        [DataMember(Name = "size_used", IsRequired = true, EmitDefaultValue = false)]
        public int SizeUsed { get; set; }

        /// <summary>
        /// Gets or Sets SizeFree
        /// </summary>
        [DataMember(Name = "size_free", IsRequired = true, EmitDefaultValue = false)]
        public int SizeFree { get; set; }

        /// <summary>
        /// Gets or Sets Online
        /// </summary>
        [DataMember(Name = "online", IsRequired = true, EmitDefaultValue = true)]
        public bool Online { get; set; }

        /// <summary>
        /// Gets or Sets Consistent
        /// </summary>
        [DataMember(Name = "consistent", IsRequired = true, EmitDefaultValue = true)]
        public bool Consistent { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BeeGFSTarget {\n");
            sb.Append("  Node: ").Append(Node).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  StoragePool: ").Append(StoragePool).Append("\n");
            sb.Append("  SizeTotal: ").Append(SizeTotal).Append("\n");
            sb.Append("  SizeUsed: ").Append(SizeUsed).Append("\n");
            sb.Append("  SizeFree: ").Append(SizeFree).Append("\n");
            sb.Append("  Online: ").Append(Online).Append("\n");
            sb.Append("  Consistent: ").Append(Consistent).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(input as BeeGFSTarget);
        }

        /// <summary>
        /// Returns true if BeeGFSTarget instances are equal
        /// </summary>
        /// <param name="input">Instance of BeeGFSTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BeeGFSTarget input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Node == input.Node ||
                    (this.Node != null &&
                    this.Node.Equals(input.Node))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))
                ) && 
                (
                    this.StoragePool == input.StoragePool ||
                    this.StoragePool.Equals(input.StoragePool)
                ) && 
                (
                    this.SizeTotal == input.SizeTotal ||
                    this.SizeTotal.Equals(input.SizeTotal)
                ) && 
                (
                    this.SizeUsed == input.SizeUsed ||
                    this.SizeUsed.Equals(input.SizeUsed)
                ) && 
                (
                    this.SizeFree == input.SizeFree ||
                    this.SizeFree.Equals(input.SizeFree)
                ) && 
                (
                    this.Online == input.Online ||
                    this.Online.Equals(input.Online)
                ) && 
                (
                    this.Consistent == input.Consistent ||
                    this.Consistent.Equals(input.Consistent)
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
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
                if (this.Node != null)
                    hashCode = hashCode * 59 + this.Node.GetHashCode();
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Host != null)
                    hashCode = hashCode * 59 + this.Host.GetHashCode();
                hashCode = hashCode * 59 + this.StoragePool.GetHashCode();
                hashCode = hashCode * 59 + this.SizeTotal.GetHashCode();
                hashCode = hashCode * 59 + this.SizeUsed.GetHashCode();
                hashCode = hashCode * 59 + this.SizeFree.GetHashCode();
                hashCode = hashCode * 59 + this.Online.GetHashCode();
                hashCode = hashCode * 59 + this.Consistent.GetHashCode();
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
                return hashCode;
            }
        }

    }

}
