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
    /// RestoreEndpointRequest
    /// </summary>
    [DataContract(Name = "RestoreEndpointRequest")]
    public partial class RestoreEndpointRequest : IEquatable<RestoreEndpointRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreEndpointRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RestoreEndpointRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreEndpointRequest" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="source">source (required).</param>
        /// <param name="exclude">exclude (required).</param>
        /// <param name="tape">tape (required).</param>
        /// <param name="export">export.</param>
        /// <param name="startDate">startDate (required).</param>
        public RestoreEndpointRequest(string name = default(string), List<TapeJobSource> source = default(List<TapeJobSource>), List<string> exclude = default(List<string>), string tape = default(string), bool export = default(bool), DateTime startDate = default(DateTime))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for RestoreEndpointRequest and cannot be null");
            // to ensure "source" is required (not null)
            this.Source = source ?? throw new ArgumentNullException("source is a required property for RestoreEndpointRequest and cannot be null");
            // to ensure "exclude" is required (not null)
            this.Exclude = exclude ?? throw new ArgumentNullException("exclude is a required property for RestoreEndpointRequest and cannot be null");
            // to ensure "tape" is required (not null)
            this.Tape = tape ?? throw new ArgumentNullException("tape is a required property for RestoreEndpointRequest and cannot be null");
            this.StartDate = startDate;
            this.Export = export;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", IsRequired = true, EmitDefaultValue = false)]
        public List<TapeJobSource> Source { get; set; }

        /// <summary>
        /// Gets or Sets Exclude
        /// </summary>
        [DataMember(Name = "exclude", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Exclude { get; set; }

        /// <summary>
        /// Gets or Sets Tape
        /// </summary>
        [DataMember(Name = "tape", IsRequired = true, EmitDefaultValue = false)]
        public string Tape { get; set; }

        /// <summary>
        /// Gets or Sets Export
        /// </summary>
        [DataMember(Name = "export", EmitDefaultValue = true)]
        public bool Export { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "start_date", IsRequired = true, EmitDefaultValue = false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestoreEndpointRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Exclude: ").Append(Exclude).Append("\n");
            sb.Append("  Tape: ").Append(Tape).Append("\n");
            sb.Append("  Export: ").Append(Export).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
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
            return this.Equals(input as RestoreEndpointRequest);
        }

        /// <summary>
        /// Returns true if RestoreEndpointRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreEndpointRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreEndpointRequest input)
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
                    this.Source == input.Source ||
                    this.Source != null &&
                    input.Source != null &&
                    this.Source.SequenceEqual(input.Source)
                ) && 
                (
                    this.Exclude == input.Exclude ||
                    this.Exclude != null &&
                    input.Exclude != null &&
                    this.Exclude.SequenceEqual(input.Exclude)
                ) && 
                (
                    this.Tape == input.Tape ||
                    (this.Tape != null &&
                    this.Tape.Equals(input.Tape))
                ) && 
                (
                    this.Export == input.Export ||
                    this.Export.Equals(input.Export)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
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
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Exclude != null)
                    hashCode = hashCode * 59 + this.Exclude.GetHashCode();
                if (this.Tape != null)
                    hashCode = hashCode * 59 + this.Tape.GetHashCode();
                hashCode = hashCode * 59 + this.Export.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                return hashCode;
            }
        }

    }

}