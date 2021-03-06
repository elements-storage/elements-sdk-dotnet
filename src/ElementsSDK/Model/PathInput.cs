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
    /// PathInput
    /// </summary>
    [DataContract(Name = "PathInput")]
    public partial class PathInput : IEquatable<PathInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PathInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PathInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PathInput" /> class.
        /// </summary>
        /// <param name="input">input (required).</param>
        public PathInput(List<string> input = default(List<string>))
        {
            // to ensure "input" is required (not null)
            this.Input = input ?? throw new ArgumentNullException("input is a required property for PathInput and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Input
        /// </summary>
        [DataMember(Name = "input", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Input { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PathInput {\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
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
            return this.Equals(input as PathInput);
        }

        /// <summary>
        /// Returns true if PathInput instances are equal
        /// </summary>
        /// <param name="input">Instance of PathInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PathInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Input == input.Input ||
                    this.Input != null &&
                    input.Input != null &&
                    this.Input.SequenceEqual(input.Input)
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
                if (this.Input != null)
                    hashCode = hashCode * 59 + this.Input.GetHashCode();
                return hashCode;
            }
        }

    }

}
