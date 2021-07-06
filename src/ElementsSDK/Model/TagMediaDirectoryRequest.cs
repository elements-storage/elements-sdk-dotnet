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
    /// TagMediaDirectoryRequest
    /// </summary>
    [DataContract(Name = "TagMediaDirectoryRequest")]
    public partial class TagMediaDirectoryRequest : IEquatable<TagMediaDirectoryRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagMediaDirectoryRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TagMediaDirectoryRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TagMediaDirectoryRequest" /> class.
        /// </summary>
        /// <param name="tag">tag (required).</param>
        /// <param name="add">add (required).</param>
        public TagMediaDirectoryRequest(int tag = default(int), bool add = default(bool))
        {
            this.Tag = tag;
            this.Add = add;
        }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [DataMember(Name = "tag", IsRequired = true, EmitDefaultValue = false)]
        public int Tag { get; set; }

        /// <summary>
        /// Gets or Sets Add
        /// </summary>
        [DataMember(Name = "add", IsRequired = true, EmitDefaultValue = true)]
        public bool Add { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TagMediaDirectoryRequest {\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Add: ").Append(Add).Append("\n");
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
            return this.Equals(input as TagMediaDirectoryRequest);
        }

        /// <summary>
        /// Returns true if TagMediaDirectoryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TagMediaDirectoryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TagMediaDirectoryRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tag == input.Tag ||
                    this.Tag.Equals(input.Tag)
                ) && 
                (
                    this.Add == input.Add ||
                    this.Add.Equals(input.Add)
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
                hashCode = hashCode * 59 + this.Tag.GetHashCode();
                hashCode = hashCode * 59 + this.Add.GetHashCode();
                return hashCode;
            }
        }

    }

}