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
    /// OneTimeAccessTokenActivity
    /// </summary>
    [DataContract(Name = "OneTimeAccessTokenActivity")]
    public partial class OneTimeAccessTokenActivity : IEquatable<OneTimeAccessTokenActivity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OneTimeAccessTokenActivity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OneTimeAccessTokenActivity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OneTimeAccessTokenActivity" /> class.
        /// </summary>
        /// <param name="ip">ip (required).</param>
        /// <param name="token">token (required).</param>
        public OneTimeAccessTokenActivity(string ip = default(string), int token = default(int))
        {
            // to ensure "ip" is required (not null)
            this.Ip = ip ?? throw new ArgumentNullException("ip is a required property for OneTimeAccessTokenActivity and cannot be null");
            this.Token = token;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public DateTime Date { get; private set; }

        /// <summary>
        /// Returns false as Date should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDate()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Ip
        /// </summary>
        [DataMember(Name = "ip", IsRequired = true, EmitDefaultValue = false)]
        public string Ip { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name = "token", IsRequired = true, EmitDefaultValue = false)]
        public int Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OneTimeAccessTokenActivity {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(input as OneTimeAccessTokenActivity);
        }

        /// <summary>
        /// Returns true if OneTimeAccessTokenActivity instances are equal
        /// </summary>
        /// <param name="input">Instance of OneTimeAccessTokenActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OneTimeAccessTokenActivity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.Token == input.Token ||
                    this.Token.Equals(input.Token)
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                hashCode = hashCode * 59 + this.Token.GetHashCode();
                return hashCode;
            }
        }

    }

}
