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
    /// MediaFileTemplatePartialUpdate
    /// </summary>
    [DataContract(Name = "MediaFileTemplatePartialUpdate")]
    public partial class MediaFileTemplatePartialUpdate : IEquatable<MediaFileTemplatePartialUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaFileTemplatePartialUpdate" /> class.
        /// </summary>
        /// <param name="file">file.</param>
        /// <param name="name">name.</param>
        public MediaFileTemplatePartialUpdate(MediaFileReference file = default(MediaFileReference), string name = default(string))
        {
            this.File = file;
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name = "file", EmitDefaultValue = false)]
        public MediaFileReference File { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaFileTemplatePartialUpdate {\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as MediaFileTemplatePartialUpdate);
        }

        /// <summary>
        /// Returns true if MediaFileTemplatePartialUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of MediaFileTemplatePartialUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaFileTemplatePartialUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }

}
