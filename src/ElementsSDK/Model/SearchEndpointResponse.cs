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
    /// SearchEndpointResponse
    /// </summary>
    [DataContract(Name = "SearchEndpointResponse")]
    public partial class SearchEndpointResponse : IEquatable<SearchEndpointResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchEndpointResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchEndpointResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchEndpointResponse" /> class.
        /// </summary>
        /// <param name="tapes">tapes (required).</param>
        /// <param name="entries">entries (required).</param>
        /// <param name="total">total (required).</param>
        public SearchEndpointResponse(List<Tape> tapes = default(List<Tape>), List<TapeFile> entries = default(List<TapeFile>), int total = default(int))
        {
            // to ensure "tapes" is required (not null)
            this.Tapes = tapes ?? throw new ArgumentNullException("tapes is a required property for SearchEndpointResponse and cannot be null");
            // to ensure "entries" is required (not null)
            this.Entries = entries ?? throw new ArgumentNullException("entries is a required property for SearchEndpointResponse and cannot be null");
            this.Total = total;
        }

        /// <summary>
        /// Gets or Sets Tapes
        /// </summary>
        [DataMember(Name = "tapes", IsRequired = true, EmitDefaultValue = false)]
        public List<Tape> Tapes { get; set; }

        /// <summary>
        /// Gets or Sets Entries
        /// </summary>
        [DataMember(Name = "entries", IsRequired = true, EmitDefaultValue = false)]
        public List<TapeFile> Entries { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = false)]
        public int Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchEndpointResponse {\n");
            sb.Append("  Tapes: ").Append(Tapes).Append("\n");
            sb.Append("  Entries: ").Append(Entries).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(input as SearchEndpointResponse);
        }

        /// <summary>
        /// Returns true if SearchEndpointResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchEndpointResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchEndpointResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tapes == input.Tapes ||
                    this.Tapes != null &&
                    input.Tapes != null &&
                    this.Tapes.SequenceEqual(input.Tapes)
                ) && 
                (
                    this.Entries == input.Entries ||
                    this.Entries != null &&
                    input.Entries != null &&
                    this.Entries.SequenceEqual(input.Entries)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
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
                if (this.Tapes != null)
                    hashCode = hashCode * 59 + this.Tapes.GetHashCode();
                if (this.Entries != null)
                    hashCode = hashCode * 59 + this.Entries.GetHashCode();
                hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }

    }

}