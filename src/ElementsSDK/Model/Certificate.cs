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
    /// Certificate
    /// </summary>
    [DataContract(Name = "Certificate")]
    public partial class Certificate : IEquatable<Certificate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Certificate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Certificate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Certificate" /> class.
        /// </summary>
        /// <param name="certificate">certificate (required).</param>
        /// <param name="key">key.</param>
        public Certificate(string certificate = default(string), string key = default(string))
        {
            // to ensure "certificate" is required (not null)
            this._Certificate = certificate ?? throw new ArgumentNullException("certificate is a required property for Certificate and cannot be null");
            this.Key = key;
        }

        /// <summary>
        /// Gets or Sets _Certificate
        /// </summary>
        [DataMember(Name = "certificate", IsRequired = true, EmitDefaultValue = false)]
        public string _Certificate { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; private set; }

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Issuer
        /// </summary>
        [DataMember(Name = "issuer", EmitDefaultValue = false)]
        public string Issuer { get; private set; }

        /// <summary>
        /// Returns false as Issuer should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIssuer()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Domains
        /// </summary>
        [DataMember(Name = "domains", EmitDefaultValue = false)]
        public string Domains { get; private set; }

        /// <summary>
        /// Returns false as Domains should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDomains()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Fingerprint
        /// </summary>
        [DataMember(Name = "fingerprint", EmitDefaultValue = false)]
        public string Fingerprint { get; private set; }

        /// <summary>
        /// Returns false as Fingerprint should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFingerprint()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets NotValidBefore
        /// </summary>
        [DataMember(Name = "not_valid_before", EmitDefaultValue = false)]
        public string NotValidBefore { get; private set; }

        /// <summary>
        /// Returns false as NotValidBefore should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNotValidBefore()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets NotValidAfter
        /// </summary>
        [DataMember(Name = "not_valid_after", EmitDefaultValue = false)]
        public string NotValidAfter { get; private set; }

        /// <summary>
        /// Returns false as NotValidAfter should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNotValidAfter()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Expired
        /// </summary>
        [DataMember(Name = "expired", EmitDefaultValue = false)]
        public string Expired { get; private set; }

        /// <summary>
        /// Returns false as Expired should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExpired()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets KeyMatches
        /// </summary>
        [DataMember(Name = "key_matches", EmitDefaultValue = false)]
        public string KeyMatches { get; private set; }

        /// <summary>
        /// Returns false as KeyMatches should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeKeyMatches()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets DomainMatches
        /// </summary>
        [DataMember(Name = "domain_matches", EmitDefaultValue = false)]
        public string DomainMatches { get; private set; }

        /// <summary>
        /// Returns false as DomainMatches should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDomainMatches()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Certificate {\n");
            sb.Append("  _Certificate: ").Append(_Certificate).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  Domains: ").Append(Domains).Append("\n");
            sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
            sb.Append("  NotValidBefore: ").Append(NotValidBefore).Append("\n");
            sb.Append("  NotValidAfter: ").Append(NotValidAfter).Append("\n");
            sb.Append("  Expired: ").Append(Expired).Append("\n");
            sb.Append("  KeyMatches: ").Append(KeyMatches).Append("\n");
            sb.Append("  DomainMatches: ").Append(DomainMatches).Append("\n");
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
            return this.Equals(input as Certificate);
        }

        /// <summary>
        /// Returns true if Certificate instances are equal
        /// </summary>
        /// <param name="input">Instance of Certificate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Certificate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Certificate == input._Certificate ||
                    (this._Certificate != null &&
                    this._Certificate.Equals(input._Certificate))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Issuer == input.Issuer ||
                    (this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer))
                ) && 
                (
                    this.Domains == input.Domains ||
                    (this.Domains != null &&
                    this.Domains.Equals(input.Domains))
                ) && 
                (
                    this.Fingerprint == input.Fingerprint ||
                    (this.Fingerprint != null &&
                    this.Fingerprint.Equals(input.Fingerprint))
                ) && 
                (
                    this.NotValidBefore == input.NotValidBefore ||
                    (this.NotValidBefore != null &&
                    this.NotValidBefore.Equals(input.NotValidBefore))
                ) && 
                (
                    this.NotValidAfter == input.NotValidAfter ||
                    (this.NotValidAfter != null &&
                    this.NotValidAfter.Equals(input.NotValidAfter))
                ) && 
                (
                    this.Expired == input.Expired ||
                    (this.Expired != null &&
                    this.Expired.Equals(input.Expired))
                ) && 
                (
                    this.KeyMatches == input.KeyMatches ||
                    (this.KeyMatches != null &&
                    this.KeyMatches.Equals(input.KeyMatches))
                ) && 
                (
                    this.DomainMatches == input.DomainMatches ||
                    (this.DomainMatches != null &&
                    this.DomainMatches.Equals(input.DomainMatches))
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
                if (this._Certificate != null)
                    hashCode = hashCode * 59 + this._Certificate.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Issuer != null)
                    hashCode = hashCode * 59 + this.Issuer.GetHashCode();
                if (this.Domains != null)
                    hashCode = hashCode * 59 + this.Domains.GetHashCode();
                if (this.Fingerprint != null)
                    hashCode = hashCode * 59 + this.Fingerprint.GetHashCode();
                if (this.NotValidBefore != null)
                    hashCode = hashCode * 59 + this.NotValidBefore.GetHashCode();
                if (this.NotValidAfter != null)
                    hashCode = hashCode * 59 + this.NotValidAfter.GetHashCode();
                if (this.Expired != null)
                    hashCode = hashCode * 59 + this.Expired.GetHashCode();
                if (this.KeyMatches != null)
                    hashCode = hashCode * 59 + this.KeyMatches.GetHashCode();
                if (this.DomainMatches != null)
                    hashCode = hashCode * 59 + this.DomainMatches.GetHashCode();
                return hashCode;
            }
        }

    }

}
