

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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Cloud.Governance.Client.Client.OpenAPIDateConverter;

namespace Cloud.Governance.Client.Model
{
    /// <summary>
    /// ContentMoveProfileMappings
    /// </summary>
    [DataContract(Name = "ContentMoveProfileMappings")]
    public partial class ContentMoveProfileMappings : IEquatable<ContentMoveProfileMappings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentMoveProfileMappings" /> class.
        /// </summary>
        /// <param name="columnMapping">columnMapping.</param>
        /// <param name="contentTypeMapping">contentTypeMapping.</param>
        /// <param name="userMapping">userMapping.</param>
        /// <param name="languageMapping">languageMapping.</param>
        public ContentMoveProfileMappings(GuidModel columnMapping = default(GuidModel), GuidModel contentTypeMapping = default(GuidModel), GuidModel userMapping = default(GuidModel), GuidModel languageMapping = default(GuidModel))
        {
            this.ColumnMapping = columnMapping;
            this.ContentTypeMapping = contentTypeMapping;
            this.UserMapping = userMapping;
            this.LanguageMapping = languageMapping;
        }

        /// <summary>
        /// Gets or Sets ColumnMapping
        /// </summary>
        [DataMember(Name = "columnMapping", EmitDefaultValue = false)]
        public GuidModel ColumnMapping { get; set; }

        /// <summary>
        /// Gets or Sets ContentTypeMapping
        /// </summary>
        [DataMember(Name = "contentTypeMapping", EmitDefaultValue = false)]
        public GuidModel ContentTypeMapping { get; set; }

        /// <summary>
        /// Gets or Sets UserMapping
        /// </summary>
        [DataMember(Name = "userMapping", EmitDefaultValue = false)]
        public GuidModel UserMapping { get; set; }

        /// <summary>
        /// Gets or Sets LanguageMapping
        /// </summary>
        [DataMember(Name = "languageMapping", EmitDefaultValue = false)]
        public GuidModel LanguageMapping { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentMoveProfileMappings {\n");
            sb.Append("  ColumnMapping: ").Append(ColumnMapping).Append("\n");
            sb.Append("  ContentTypeMapping: ").Append(ContentTypeMapping).Append("\n");
            sb.Append("  UserMapping: ").Append(UserMapping).Append("\n");
            sb.Append("  LanguageMapping: ").Append(LanguageMapping).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ContentMoveProfileMappings);
        }

        /// <summary>
        /// Returns true if ContentMoveProfileMappings instances are equal
        /// </summary>
        /// <param name="input">Instance of ContentMoveProfileMappings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentMoveProfileMappings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ColumnMapping == input.ColumnMapping ||
                    (this.ColumnMapping != null &&
                    this.ColumnMapping.Equals(input.ColumnMapping))
                ) && 
                (
                    this.ContentTypeMapping == input.ContentTypeMapping ||
                    (this.ContentTypeMapping != null &&
                    this.ContentTypeMapping.Equals(input.ContentTypeMapping))
                ) && 
                (
                    this.UserMapping == input.UserMapping ||
                    (this.UserMapping != null &&
                    this.UserMapping.Equals(input.UserMapping))
                ) && 
                (
                    this.LanguageMapping == input.LanguageMapping ||
                    (this.LanguageMapping != null &&
                    this.LanguageMapping.Equals(input.LanguageMapping))
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
                if (this.ColumnMapping != null)
                    hashCode = hashCode * 59 + this.ColumnMapping.GetHashCode();
                if (this.ContentTypeMapping != null)
                    hashCode = hashCode * 59 + this.ContentTypeMapping.GetHashCode();
                if (this.UserMapping != null)
                    hashCode = hashCode * 59 + this.UserMapping.GetHashCode();
                if (this.LanguageMapping != null)
                    hashCode = hashCode * 59 + this.LanguageMapping.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
