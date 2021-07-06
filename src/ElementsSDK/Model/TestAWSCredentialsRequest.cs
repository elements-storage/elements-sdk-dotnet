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
    /// TestAWSCredentialsRequest
    /// </summary>
    [DataContract(Name = "TestAWSCredentialsRequest")]
    public partial class TestAWSCredentialsRequest : IEquatable<TestAWSCredentialsRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestAWSCredentialsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestAWSCredentialsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestAWSCredentialsRequest" /> class.
        /// </summary>
        /// <param name="accessKeyId">accessKeyId (required).</param>
        /// <param name="secretAccessKey">secretAccessKey (required).</param>
        public TestAWSCredentialsRequest(string accessKeyId = default(string), string secretAccessKey = default(string))
        {
            // to ensure "accessKeyId" is required (not null)
            this.AccessKeyId = accessKeyId ?? throw new ArgumentNullException("accessKeyId is a required property for TestAWSCredentialsRequest and cannot be null");
            // to ensure "secretAccessKey" is required (not null)
            this.SecretAccessKey = secretAccessKey ?? throw new ArgumentNullException("secretAccessKey is a required property for TestAWSCredentialsRequest and cannot be null");
        }

        /// <summary>
        /// Gets or Sets AccessKeyId
        /// </summary>
        [DataMember(Name = "access_key_id", IsRequired = true, EmitDefaultValue = false)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// Gets or Sets SecretAccessKey
        /// </summary>
        [DataMember(Name = "secret_access_key", IsRequired = true, EmitDefaultValue = false)]
        public string SecretAccessKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestAWSCredentialsRequest {\n");
            sb.Append("  AccessKeyId: ").Append(AccessKeyId).Append("\n");
            sb.Append("  SecretAccessKey: ").Append(SecretAccessKey).Append("\n");
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
            return this.Equals(input as TestAWSCredentialsRequest);
        }

        /// <summary>
        /// Returns true if TestAWSCredentialsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TestAWSCredentialsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestAWSCredentialsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessKeyId == input.AccessKeyId ||
                    (this.AccessKeyId != null &&
                    this.AccessKeyId.Equals(input.AccessKeyId))
                ) && 
                (
                    this.SecretAccessKey == input.SecretAccessKey ||
                    (this.SecretAccessKey != null &&
                    this.SecretAccessKey.Equals(input.SecretAccessKey))
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
                if (this.AccessKeyId != null)
                    hashCode = hashCode * 59 + this.AccessKeyId.GetHashCode();
                if (this.SecretAccessKey != null)
                    hashCode = hashCode * 59 + this.SecretAccessKey.GetHashCode();
                return hashCode;
            }
        }

    }

}