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
    /// WorkstationPartialUpdate
    /// </summary>
    [DataContract(Name = "WorkstationPartialUpdate")]
    public partial class WorkstationPartialUpdate : IEquatable<WorkstationPartialUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkstationPartialUpdate" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="rdcAllowUsers">rdcAllowUsers.</param>
        /// <param name="rdcAllowGroups">rdcAllowGroups.</param>
        /// <param name="report">report.</param>
        /// <param name="name">name.</param>
        /// <param name="hostname">hostname.</param>
        /// <param name="rdcLastUsed">rdcLastUsed.</param>
        /// <param name="rdcDisableUpnp">rdcDisableUpnp.</param>
        /// <param name="rdcClientPort">rdcClientPort.</param>
        /// <param name="rdcHostPort">rdcHostPort.</param>
        public WorkstationPartialUpdate(string id = default(string), List<ElementsUserReference> rdcAllowUsers = default(List<ElementsUserReference>), List<ElementsGroupReference> rdcAllowGroups = default(List<ElementsGroupReference>), Dictionary<string, string> report = default(Dictionary<string, string>), string name = default(string), string hostname = default(string), DateTime? rdcLastUsed = default(DateTime?), bool rdcDisableUpnp = default(bool), int? rdcClientPort = default(int?), int? rdcHostPort = default(int?))
        {
            this.Id = id;
            this.RdcAllowUsers = rdcAllowUsers;
            this.RdcAllowGroups = rdcAllowGroups;
            this.Report = report;
            this.Name = name;
            this.Hostname = hostname;
            this.RdcLastUsed = rdcLastUsed;
            this.RdcDisableUpnp = rdcDisableUpnp;
            this.RdcClientPort = rdcClientPort;
            this.RdcHostPort = rdcHostPort;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets RdcAllowUsers
        /// </summary>
        [DataMember(Name = "rdc_allow_users", EmitDefaultValue = false)]
        public List<ElementsUserReference> RdcAllowUsers { get; set; }

        /// <summary>
        /// Gets or Sets RdcAllowGroups
        /// </summary>
        [DataMember(Name = "rdc_allow_groups", EmitDefaultValue = false)]
        public List<ElementsGroupReference> RdcAllowGroups { get; set; }

        /// <summary>
        /// Gets or Sets Report
        /// </summary>
        [DataMember(Name = "report", EmitDefaultValue = false)]
        public Dictionary<string, string> Report { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Hostname
        /// </summary>
        [DataMember(Name = "hostname", EmitDefaultValue = false)]
        public string Hostname { get; set; }

        /// <summary>
        /// Gets or Sets RdcLastUsed
        /// </summary>
        [DataMember(Name = "rdc_last_used", EmitDefaultValue = true)]
        public DateTime? RdcLastUsed { get; set; }

        /// <summary>
        /// Gets or Sets RdcDisableUpnp
        /// </summary>
        [DataMember(Name = "rdc_disable_upnp", EmitDefaultValue = true)]
        public bool RdcDisableUpnp { get; set; }

        /// <summary>
        /// Gets or Sets RdcClientPort
        /// </summary>
        [DataMember(Name = "rdc_client_port", EmitDefaultValue = true)]
        public int? RdcClientPort { get; set; }

        /// <summary>
        /// Gets or Sets RdcHostPort
        /// </summary>
        [DataMember(Name = "rdc_host_port", EmitDefaultValue = true)]
        public int? RdcHostPort { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkstationPartialUpdate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RdcAllowUsers: ").Append(RdcAllowUsers).Append("\n");
            sb.Append("  RdcAllowGroups: ").Append(RdcAllowGroups).Append("\n");
            sb.Append("  Report: ").Append(Report).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Hostname: ").Append(Hostname).Append("\n");
            sb.Append("  RdcLastUsed: ").Append(RdcLastUsed).Append("\n");
            sb.Append("  RdcDisableUpnp: ").Append(RdcDisableUpnp).Append("\n");
            sb.Append("  RdcClientPort: ").Append(RdcClientPort).Append("\n");
            sb.Append("  RdcHostPort: ").Append(RdcHostPort).Append("\n");
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
            return this.Equals(input as WorkstationPartialUpdate);
        }

        /// <summary>
        /// Returns true if WorkstationPartialUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkstationPartialUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkstationPartialUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RdcAllowUsers == input.RdcAllowUsers ||
                    this.RdcAllowUsers != null &&
                    input.RdcAllowUsers != null &&
                    this.RdcAllowUsers.SequenceEqual(input.RdcAllowUsers)
                ) && 
                (
                    this.RdcAllowGroups == input.RdcAllowGroups ||
                    this.RdcAllowGroups != null &&
                    input.RdcAllowGroups != null &&
                    this.RdcAllowGroups.SequenceEqual(input.RdcAllowGroups)
                ) && 
                (
                    this.Report == input.Report ||
                    this.Report != null &&
                    input.Report != null &&
                    this.Report.SequenceEqual(input.Report)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Hostname == input.Hostname ||
                    (this.Hostname != null &&
                    this.Hostname.Equals(input.Hostname))
                ) && 
                (
                    this.RdcLastUsed == input.RdcLastUsed ||
                    (this.RdcLastUsed != null &&
                    this.RdcLastUsed.Equals(input.RdcLastUsed))
                ) && 
                (
                    this.RdcDisableUpnp == input.RdcDisableUpnp ||
                    this.RdcDisableUpnp.Equals(input.RdcDisableUpnp)
                ) && 
                (
                    this.RdcClientPort == input.RdcClientPort ||
                    (this.RdcClientPort != null &&
                    this.RdcClientPort.Equals(input.RdcClientPort))
                ) && 
                (
                    this.RdcHostPort == input.RdcHostPort ||
                    (this.RdcHostPort != null &&
                    this.RdcHostPort.Equals(input.RdcHostPort))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RdcAllowUsers != null)
                    hashCode = hashCode * 59 + this.RdcAllowUsers.GetHashCode();
                if (this.RdcAllowGroups != null)
                    hashCode = hashCode * 59 + this.RdcAllowGroups.GetHashCode();
                if (this.Report != null)
                    hashCode = hashCode * 59 + this.Report.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Hostname != null)
                    hashCode = hashCode * 59 + this.Hostname.GetHashCode();
                if (this.RdcLastUsed != null)
                    hashCode = hashCode * 59 + this.RdcLastUsed.GetHashCode();
                hashCode = hashCode * 59 + this.RdcDisableUpnp.GetHashCode();
                if (this.RdcClientPort != null)
                    hashCode = hashCode * 59 + this.RdcClientPort.GetHashCode();
                if (this.RdcHostPort != null)
                    hashCode = hashCode * 59 + this.RdcHostPort.GetHashCode();
                return hashCode;
            }
        }

    }

}
