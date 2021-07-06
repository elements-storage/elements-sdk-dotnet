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
    /// LizardFSNode
    /// </summary>
    [DataContract(Name = "LizardFSNode")]
    public partial class LizardFSNode : IEquatable<LizardFSNode>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LizardFSNode" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LizardFSNode() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LizardFSNode" /> class.
        /// </summary>
        /// <param name="node">node.</param>
        /// <param name="host">host (required).</param>
        /// <param name="online">online (required).</param>
        /// <param name="version">version (required).</param>
        /// <param name="chunks">chunks (required).</param>
        /// <param name="sizeTotal">sizeTotal (required).</param>
        /// <param name="sizeUsed">sizeUsed (required).</param>
        /// <param name="sizeFree">sizeFree (required).</param>
        /// <param name="chunksForRemoval">chunksForRemoval (required).</param>
        /// <param name="label">label (required).</param>
        public LizardFSNode(StorageNodeMini node = default(StorageNodeMini), string host = default(string), bool online = default(bool), string version = default(string), int chunks = default(int), int sizeTotal = default(int), int sizeUsed = default(int), int sizeFree = default(int), int chunksForRemoval = default(int), string label = default(string))
        {
            // to ensure "host" is required (not null)
            this.Host = host ?? throw new ArgumentNullException("host is a required property for LizardFSNode and cannot be null");
            this.Online = online;
            // to ensure "version" is required (not null)
            this.Version = version ?? throw new ArgumentNullException("version is a required property for LizardFSNode and cannot be null");
            this.Chunks = chunks;
            this.SizeTotal = sizeTotal;
            this.SizeUsed = sizeUsed;
            this.SizeFree = sizeFree;
            this.ChunksForRemoval = chunksForRemoval;
            // to ensure "label" is required (not null)
            this.Label = label ?? throw new ArgumentNullException("label is a required property for LizardFSNode and cannot be null");
            this.Node = node;
        }

        /// <summary>
        /// Gets or Sets Node
        /// </summary>
        [DataMember(Name = "node", EmitDefaultValue = false)]
        public StorageNodeMini Node { get; set; }

        /// <summary>
        /// Gets or Sets Host
        /// </summary>
        [DataMember(Name = "host", IsRequired = true, EmitDefaultValue = false)]
        public string Host { get; set; }

        /// <summary>
        /// Gets or Sets Online
        /// </summary>
        [DataMember(Name = "online", IsRequired = true, EmitDefaultValue = true)]
        public bool Online { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = false)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or Sets Chunks
        /// </summary>
        [DataMember(Name = "chunks", IsRequired = true, EmitDefaultValue = false)]
        public int Chunks { get; set; }

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
        /// Gets or Sets ChunksForRemoval
        /// </summary>
        [DataMember(Name = "chunks_for_removal", IsRequired = true, EmitDefaultValue = false)]
        public int ChunksForRemoval { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", IsRequired = true, EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LizardFSNode {\n");
            sb.Append("  Node: ").Append(Node).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  Online: ").Append(Online).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Chunks: ").Append(Chunks).Append("\n");
            sb.Append("  SizeTotal: ").Append(SizeTotal).Append("\n");
            sb.Append("  SizeUsed: ").Append(SizeUsed).Append("\n");
            sb.Append("  SizeFree: ").Append(SizeFree).Append("\n");
            sb.Append("  ChunksForRemoval: ").Append(ChunksForRemoval).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
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
            return this.Equals(input as LizardFSNode);
        }

        /// <summary>
        /// Returns true if LizardFSNode instances are equal
        /// </summary>
        /// <param name="input">Instance of LizardFSNode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LizardFSNode input)
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
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))
                ) && 
                (
                    this.Online == input.Online ||
                    this.Online.Equals(input.Online)
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Chunks == input.Chunks ||
                    this.Chunks.Equals(input.Chunks)
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
                    this.ChunksForRemoval == input.ChunksForRemoval ||
                    this.ChunksForRemoval.Equals(input.ChunksForRemoval)
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
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
                if (this.Host != null)
                    hashCode = hashCode * 59 + this.Host.GetHashCode();
                hashCode = hashCode * 59 + this.Online.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                hashCode = hashCode * 59 + this.Chunks.GetHashCode();
                hashCode = hashCode * 59 + this.SizeTotal.GetHashCode();
                hashCode = hashCode * 59 + this.SizeUsed.GetHashCode();
                hashCode = hashCode * 59 + this.SizeFree.GetHashCode();
                hashCode = hashCode * 59 + this.ChunksForRemoval.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                return hashCode;
            }
        }

    }

}