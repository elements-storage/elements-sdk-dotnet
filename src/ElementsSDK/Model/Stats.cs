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
    /// Stats
    /// </summary>
    [DataContract(Name = "Stats")]
    public partial class Stats : IEquatable<Stats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Stats" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Stats() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Stats" /> class.
        /// </summary>
        /// <param name="cpu">cpu (required).</param>
        /// <param name="ram">ram (required).</param>
        /// <param name="net">net (required).</param>
        /// <param name="io">io (required).</param>
        public Stats(List<CPUStat> cpu = default(List<CPUStat>), List<RAMStat> ram = default(List<RAMStat>), Dictionary<string, List<NetStat>> net = default(Dictionary<string, List<NetStat>>), List<IOStat> io = default(List<IOStat>))
        {
            // to ensure "cpu" is required (not null)
            this.Cpu = cpu ?? throw new ArgumentNullException("cpu is a required property for Stats and cannot be null");
            // to ensure "ram" is required (not null)
            this.Ram = ram ?? throw new ArgumentNullException("ram is a required property for Stats and cannot be null");
            // to ensure "net" is required (not null)
            this.Net = net ?? throw new ArgumentNullException("net is a required property for Stats and cannot be null");
            // to ensure "io" is required (not null)
            this.Io = io ?? throw new ArgumentNullException("io is a required property for Stats and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Cpu
        /// </summary>
        [DataMember(Name = "cpu", IsRequired = true, EmitDefaultValue = false)]
        public List<CPUStat> Cpu { get; set; }

        /// <summary>
        /// Gets or Sets Ram
        /// </summary>
        [DataMember(Name = "ram", IsRequired = true, EmitDefaultValue = false)]
        public List<RAMStat> Ram { get; set; }

        /// <summary>
        /// Gets or Sets Net
        /// </summary>
        [DataMember(Name = "net", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, List<NetStat>> Net { get; set; }

        /// <summary>
        /// Gets or Sets Io
        /// </summary>
        [DataMember(Name = "io", IsRequired = true, EmitDefaultValue = false)]
        public List<IOStat> Io { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Stats {\n");
            sb.Append("  Cpu: ").Append(Cpu).Append("\n");
            sb.Append("  Ram: ").Append(Ram).Append("\n");
            sb.Append("  Net: ").Append(Net).Append("\n");
            sb.Append("  Io: ").Append(Io).Append("\n");
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
            return this.Equals(input as Stats);
        }

        /// <summary>
        /// Returns true if Stats instances are equal
        /// </summary>
        /// <param name="input">Instance of Stats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Stats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cpu == input.Cpu ||
                    this.Cpu != null &&
                    input.Cpu != null &&
                    this.Cpu.SequenceEqual(input.Cpu)
                ) && 
                (
                    this.Ram == input.Ram ||
                    this.Ram != null &&
                    input.Ram != null &&
                    this.Ram.SequenceEqual(input.Ram)
                ) && 
                (
                    this.Net == input.Net ||
                    this.Net != null &&
                    input.Net != null &&
                    this.Net.SequenceEqual(input.Net)
                ) && 
                (
                    this.Io == input.Io ||
                    this.Io != null &&
                    input.Io != null &&
                    this.Io.SequenceEqual(input.Io)
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
                if (this.Cpu != null)
                    hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.Ram != null)
                    hashCode = hashCode * 59 + this.Ram.GetHashCode();
                if (this.Net != null)
                    hashCode = hashCode * 59 + this.Net.GetHashCode();
                if (this.Io != null)
                    hashCode = hashCode * 59 + this.Io.GetHashCode();
                return hashCode;
            }
        }

    }

}
