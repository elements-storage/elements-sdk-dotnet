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
    /// TeamsConnectionStatus
    /// </summary>
    [DataContract(Name = "TeamsConnectionStatus")]
    public partial class TeamsConnectionStatus : IEquatable<TeamsConnectionStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsConnectionStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TeamsConnectionStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsConnectionStatus" /> class.
        /// </summary>
        /// <param name="ok">ok (required).</param>
        /// <param name="team">team (required).</param>
        public TeamsConnectionStatus(bool ok = default(bool), string team = default(string))
        {
            this.Ok = ok;
            // to ensure "team" is required (not null)
            this.Team = team ?? throw new ArgumentNullException("team is a required property for TeamsConnectionStatus and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Ok
        /// </summary>
        [DataMember(Name = "ok", IsRequired = true, EmitDefaultValue = true)]
        public bool Ok { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", IsRequired = true, EmitDefaultValue = false)]
        public string Team { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamsConnectionStatus {\n");
            sb.Append("  Ok: ").Append(Ok).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
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
            return this.Equals(input as TeamsConnectionStatus);
        }

        /// <summary>
        /// Returns true if TeamsConnectionStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamsConnectionStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamsConnectionStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ok == input.Ok ||
                    this.Ok.Equals(input.Ok)
                ) && 
                (
                    this.Team == input.Team ||
                    (this.Team != null &&
                    this.Team.Equals(input.Team))
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
                hashCode = hashCode * 59 + this.Ok.GetHashCode();
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
                return hashCode;
            }
        }

    }

}
