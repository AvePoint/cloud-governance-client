

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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Cloud.Governance.Client.Client.OpenAPIDateConverter;

namespace Cloud.Governance.Client.Model
{
    /// <summary>
    /// ContentMoveProfiles
    /// </summary>
    [DataContract(Name = "ContentMoveProfiles")]
    public partial class ContentMoveProfiles : IEquatable<ContentMoveProfiles>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentMoveProfiles" /> class.
        /// </summary>
        /// <param name="backupEnvironmentStoragePolices">backupEnvironmentStoragePolices.</param>
        /// <param name="columnMappings">columnMappings.</param>
        /// <param name="contentTypeMappings">contentTypeMappings.</param>
        /// <param name="userMappings">userMappings.</param>
        /// <param name="languageMappings">languageMappings.</param>
        /// <param name="filterPolices">filterPolices.</param>
        public ContentMoveProfiles(List<GuidModel> backupEnvironmentStoragePolices = default(List<GuidModel>), List<GuidModel> columnMappings = default(List<GuidModel>), List<GuidModel> contentTypeMappings = default(List<GuidModel>), List<GuidModel> userMappings = default(List<GuidModel>), List<GuidModel> languageMappings = default(List<GuidModel>), List<GuidModel> filterPolices = default(List<GuidModel>))
        {
            this.BackupEnvironmentStoragePolices = backupEnvironmentStoragePolices;
            this.ColumnMappings = columnMappings;
            this.ContentTypeMappings = contentTypeMappings;
            this.UserMappings = userMappings;
            this.LanguageMappings = languageMappings;
            this.FilterPolices = filterPolices;
        }

        /// <summary>
        /// Gets or Sets BackupEnvironmentStoragePolices
        /// </summary>
        [DataMember(Name = "backupEnvironmentStoragePolices", EmitDefaultValue = true)]
        public List<GuidModel> BackupEnvironmentStoragePolices { get; set; }

        /// <summary>
        /// Gets or Sets ColumnMappings
        /// </summary>
        [DataMember(Name = "columnMappings", EmitDefaultValue = true)]
        public List<GuidModel> ColumnMappings { get; set; }

        /// <summary>
        /// Gets or Sets ContentTypeMappings
        /// </summary>
        [DataMember(Name = "contentTypeMappings", EmitDefaultValue = true)]
        public List<GuidModel> ContentTypeMappings { get; set; }

        /// <summary>
        /// Gets or Sets UserMappings
        /// </summary>
        [DataMember(Name = "userMappings", EmitDefaultValue = true)]
        public List<GuidModel> UserMappings { get; set; }

        /// <summary>
        /// Gets or Sets LanguageMappings
        /// </summary>
        [DataMember(Name = "languageMappings", EmitDefaultValue = true)]
        public List<GuidModel> LanguageMappings { get; set; }

        /// <summary>
        /// Gets or Sets FilterPolices
        /// </summary>
        [DataMember(Name = "filterPolices", EmitDefaultValue = true)]
        public List<GuidModel> FilterPolices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentMoveProfiles {\n");
            sb.Append("  BackupEnvironmentStoragePolices: ").Append(BackupEnvironmentStoragePolices).Append("\n");
            sb.Append("  ColumnMappings: ").Append(ColumnMappings).Append("\n");
            sb.Append("  ContentTypeMappings: ").Append(ContentTypeMappings).Append("\n");
            sb.Append("  UserMappings: ").Append(UserMappings).Append("\n");
            sb.Append("  LanguageMappings: ").Append(LanguageMappings).Append("\n");
            sb.Append("  FilterPolices: ").Append(FilterPolices).Append("\n");
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
            return this.Equals(input as ContentMoveProfiles);
        }

        /// <summary>
        /// Returns true if ContentMoveProfiles instances are equal
        /// </summary>
        /// <param name="input">Instance of ContentMoveProfiles to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentMoveProfiles input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupEnvironmentStoragePolices == input.BackupEnvironmentStoragePolices ||
                    this.BackupEnvironmentStoragePolices != null &&
                    input.BackupEnvironmentStoragePolices != null &&
                    this.BackupEnvironmentStoragePolices.SequenceEqual(input.BackupEnvironmentStoragePolices)
                ) && 
                (
                    this.ColumnMappings == input.ColumnMappings ||
                    this.ColumnMappings != null &&
                    input.ColumnMappings != null &&
                    this.ColumnMappings.SequenceEqual(input.ColumnMappings)
                ) && 
                (
                    this.ContentTypeMappings == input.ContentTypeMappings ||
                    this.ContentTypeMappings != null &&
                    input.ContentTypeMappings != null &&
                    this.ContentTypeMappings.SequenceEqual(input.ContentTypeMappings)
                ) && 
                (
                    this.UserMappings == input.UserMappings ||
                    this.UserMappings != null &&
                    input.UserMappings != null &&
                    this.UserMappings.SequenceEqual(input.UserMappings)
                ) && 
                (
                    this.LanguageMappings == input.LanguageMappings ||
                    this.LanguageMappings != null &&
                    input.LanguageMappings != null &&
                    this.LanguageMappings.SequenceEqual(input.LanguageMappings)
                ) && 
                (
                    this.FilterPolices == input.FilterPolices ||
                    this.FilterPolices != null &&
                    input.FilterPolices != null &&
                    this.FilterPolices.SequenceEqual(input.FilterPolices)
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
                if (this.BackupEnvironmentStoragePolices != null)
                    hashCode = hashCode * 59 + this.BackupEnvironmentStoragePolices.GetHashCode();
                if (this.ColumnMappings != null)
                    hashCode = hashCode * 59 + this.ColumnMappings.GetHashCode();
                if (this.ContentTypeMappings != null)
                    hashCode = hashCode * 59 + this.ContentTypeMappings.GetHashCode();
                if (this.UserMappings != null)
                    hashCode = hashCode * 59 + this.UserMappings.GetHashCode();
                if (this.LanguageMappings != null)
                    hashCode = hashCode * 59 + this.LanguageMappings.GetHashCode();
                if (this.FilterPolices != null)
                    hashCode = hashCode * 59 + this.FilterPolices.GetHashCode();
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
