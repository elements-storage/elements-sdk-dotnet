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
    /// SystemInfoEndpointResponse
    /// </summary>
    [DataContract(Name = "SystemInfoEndpointResponse")]
    public partial class SystemInfoEndpointResponse : IEquatable<SystemInfoEndpointResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemInfoEndpointResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SystemInfoEndpointResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemInfoEndpointResponse" /> class.
        /// </summary>
        /// <param name="license">license (required).</param>
        /// <param name="clientApiVersion">clientApiVersion (required).</param>
        /// <param name="ntHostname">ntHostname (required).</param>
        /// <param name="offersNtpSync">offersNtpSync (required).</param>
        /// <param name="language">language (required).</param>
        /// <param name="version">version (required).</param>
        /// <param name="globalAlerts">globalAlerts (required).</param>
        public SystemInfoEndpointResponse(License license = default(License), int clientApiVersion = default(int), string ntHostname = default(string), bool offersNtpSync = default(bool), string language = default(string), ElementsVersion version = default(ElementsVersion), List<GlobalAlert> globalAlerts = default(List<GlobalAlert>))
        {
            // to ensure "license" is required (not null)
            this.License = license ?? throw new ArgumentNullException("license is a required property for SystemInfoEndpointResponse and cannot be null");
            this.ClientApiVersion = clientApiVersion;
            // to ensure "ntHostname" is required (not null)
            this.NtHostname = ntHostname ?? throw new ArgumentNullException("ntHostname is a required property for SystemInfoEndpointResponse and cannot be null");
            this.OffersNtpSync = offersNtpSync;
            // to ensure "language" is required (not null)
            this.Language = language ?? throw new ArgumentNullException("language is a required property for SystemInfoEndpointResponse and cannot be null");
            // to ensure "version" is required (not null)
            this._Version = version ?? throw new ArgumentNullException("version is a required property for SystemInfoEndpointResponse and cannot be null");
            // to ensure "globalAlerts" is required (not null)
            this.GlobalAlerts = globalAlerts ?? throw new ArgumentNullException("globalAlerts is a required property for SystemInfoEndpointResponse and cannot be null");
        }

        /// <summary>
        /// Gets or Sets License
        /// </summary>
        [DataMember(Name = "license", IsRequired = true, EmitDefaultValue = false)]
        public License License { get; set; }

        /// <summary>
        /// Gets or Sets ClientApiVersion
        /// </summary>
        [DataMember(Name = "client_api_version", IsRequired = true, EmitDefaultValue = false)]
        public int ClientApiVersion { get; set; }

        /// <summary>
        /// Gets or Sets NtHostname
        /// </summary>
        [DataMember(Name = "nt_hostname", IsRequired = true, EmitDefaultValue = false)]
        public string NtHostname { get; set; }

        /// <summary>
        /// Gets or Sets OffersNtpSync
        /// </summary>
        [DataMember(Name = "offers_ntp_sync", IsRequired = true, EmitDefaultValue = true)]
        public bool OffersNtpSync { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name = "language", IsRequired = true, EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets SamlProviders
        /// </summary>
        [DataMember(Name = "saml_providers", EmitDefaultValue = false)]
        public List<SAMLProviderMini> SamlProviders { get; private set; }

        /// <summary>
        /// Returns false as SamlProviders should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSamlProviders()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = false)]
        public ElementsVersion _Version { get; set; }

        /// <summary>
        /// Gets or Sets GlobalAlerts
        /// </summary>
        [DataMember(Name = "global_alerts", IsRequired = true, EmitDefaultValue = false)]
        public List<GlobalAlert> GlobalAlerts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemInfoEndpointResponse {\n");
            sb.Append("  License: ").Append(License).Append("\n");
            sb.Append("  ClientApiVersion: ").Append(ClientApiVersion).Append("\n");
            sb.Append("  NtHostname: ").Append(NtHostname).Append("\n");
            sb.Append("  OffersNtpSync: ").Append(OffersNtpSync).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  SamlProviders: ").Append(SamlProviders).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  GlobalAlerts: ").Append(GlobalAlerts).Append("\n");
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
            return this.Equals(input as SystemInfoEndpointResponse);
        }

        /// <summary>
        /// Returns true if SystemInfoEndpointResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemInfoEndpointResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemInfoEndpointResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.License == input.License ||
                    (this.License != null &&
                    this.License.Equals(input.License))
                ) && 
                (
                    this.ClientApiVersion == input.ClientApiVersion ||
                    this.ClientApiVersion.Equals(input.ClientApiVersion)
                ) && 
                (
                    this.NtHostname == input.NtHostname ||
                    (this.NtHostname != null &&
                    this.NtHostname.Equals(input.NtHostname))
                ) && 
                (
                    this.OffersNtpSync == input.OffersNtpSync ||
                    this.OffersNtpSync.Equals(input.OffersNtpSync)
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.SamlProviders == input.SamlProviders ||
                    this.SamlProviders != null &&
                    input.SamlProviders != null &&
                    this.SamlProviders.SequenceEqual(input.SamlProviders)
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.GlobalAlerts == input.GlobalAlerts ||
                    this.GlobalAlerts != null &&
                    input.GlobalAlerts != null &&
                    this.GlobalAlerts.SequenceEqual(input.GlobalAlerts)
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
                if (this.License != null)
                    hashCode = hashCode * 59 + this.License.GetHashCode();
                hashCode = hashCode * 59 + this.ClientApiVersion.GetHashCode();
                if (this.NtHostname != null)
                    hashCode = hashCode * 59 + this.NtHostname.GetHashCode();
                hashCode = hashCode * 59 + this.OffersNtpSync.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.SamlProviders != null)
                    hashCode = hashCode * 59 + this.SamlProviders.GetHashCode();
                if (this._Version != null)
                    hashCode = hashCode * 59 + this._Version.GetHashCode();
                if (this.GlobalAlerts != null)
                    hashCode = hashCode * 59 + this.GlobalAlerts.GetHashCode();
                return hashCode;
            }
        }

    }

}
