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
    /// RenderEndpointRequest
    /// </summary>
    [DataContract(Name = "RenderEndpointRequest")]
    public partial class RenderEndpointRequest : IEquatable<RenderEndpointRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenderEndpointRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RenderEndpointRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RenderEndpointRequest" /> class.
        /// </summary>
        /// <param name="sequence">sequence (required).</param>
        /// <param name="project">project (required).</param>
        /// <param name="options">options (required).</param>
        public RenderEndpointRequest(Object sequence = default(Object), Object project = default(Object), Object options = default(Object))
        {
            // to ensure "sequence" is required (not null)
            this.Sequence = sequence ?? throw new ArgumentNullException("sequence is a required property for RenderEndpointRequest and cannot be null");
            // to ensure "project" is required (not null)
            this.Project = project ?? throw new ArgumentNullException("project is a required property for RenderEndpointRequest and cannot be null");
            // to ensure "options" is required (not null)
            this.Options = options ?? throw new ArgumentNullException("options is a required property for RenderEndpointRequest and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Sequence
        /// </summary>
        [DataMember(Name = "sequence", IsRequired = true, EmitDefaultValue = false)]
        public Object Sequence { get; set; }

        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name = "project", IsRequired = true, EmitDefaultValue = false)]
        public Object Project { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", IsRequired = true, EmitDefaultValue = false)]
        public Object Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RenderEndpointRequest {\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as RenderEndpointRequest);
        }

        /// <summary>
        /// Returns true if RenderEndpointRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RenderEndpointRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RenderEndpointRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sequence == input.Sequence ||
                    (this.Sequence != null &&
                    this.Sequence.Equals(input.Sequence))
                ) && 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
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
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                return hashCode;
            }
        }

    }

}