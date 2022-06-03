

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
    /// OldMetadataGridModel
    /// </summary>
    [DataContract(Name = "OldMetadataGridModel")]
    public partial class OldMetadataGridModel : IEquatable<OldMetadataGridModel>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets FieldType
        /// </summary>
        [DataMember(Name = "fieldType", EmitDefaultValue = false)]
        public MetadataFieldType? FieldType { get; set; }
        /// <summary>
        /// Gets or Sets ShowInReportType
        /// </summary>
        [DataMember(Name = "showInReportType", EmitDefaultValue = false)]
        public MetadataDisplayType? ShowInReportType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OldMetadataGridModel" /> class.
        /// </summary>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="createdByDisplayName">createdByDisplayName.</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="fieldType">fieldType.</param>
        /// <param name="fieldTypeDescription">fieldTypeDescription.</param>
        /// <param name="metadataValue">metadataValue.</param>
        /// <param name="showInReportType">showInReportType.</param>
        /// <param name="showInReportTypeDescription">showInReportTypeDescription.</param>
        /// <param name="lastModifiedTime">lastModifiedTime.</param>
        public OldMetadataGridModel(string createdBy = default(string), string createdByDisplayName = default(string), Guid id = default(Guid), string name = default(string), string description = default(string), MetadataFieldType? fieldType = default(MetadataFieldType?), string fieldTypeDescription = default(string), string metadataValue = default(string), MetadataDisplayType? showInReportType = default(MetadataDisplayType?), string showInReportTypeDescription = default(string), DateTime lastModifiedTime = default(DateTime))
        {
            this.CreatedBy = createdBy;
            this.CreatedByDisplayName = createdByDisplayName;
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.FieldType = fieldType;
            this.FieldTypeDescription = fieldTypeDescription;
            this.MetadataValue = metadataValue;
            this.ShowInReportType = showInReportType;
            this.ShowInReportTypeDescription = showInReportTypeDescription;
            this.LastModifiedTime = lastModifiedTime;
        }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "createdBy", EmitDefaultValue = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByDisplayName
        /// </summary>
        [DataMember(Name = "createdByDisplayName", EmitDefaultValue = true)]
        public string CreatedByDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets FieldTypeDescription
        /// </summary>
        [DataMember(Name = "fieldTypeDescription", EmitDefaultValue = true)]
        public string FieldTypeDescription { get; set; }

        /// <summary>
        /// Gets or Sets MetadataValue
        /// </summary>
        [DataMember(Name = "metadataValue", EmitDefaultValue = true)]
        public string MetadataValue { get; set; }

        /// <summary>
        /// Gets or Sets ShowInReportTypeDescription
        /// </summary>
        [DataMember(Name = "showInReportTypeDescription", EmitDefaultValue = true)]
        public string ShowInReportTypeDescription { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedTime
        /// </summary>
        [DataMember(Name = "lastModifiedTime", EmitDefaultValue = false)]
        public DateTime LastModifiedTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OldMetadataGridModel {\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedByDisplayName: ").Append(CreatedByDisplayName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FieldType: ").Append(FieldType).Append("\n");
            sb.Append("  FieldTypeDescription: ").Append(FieldTypeDescription).Append("\n");
            sb.Append("  MetadataValue: ").Append(MetadataValue).Append("\n");
            sb.Append("  ShowInReportType: ").Append(ShowInReportType).Append("\n");
            sb.Append("  ShowInReportTypeDescription: ").Append(ShowInReportTypeDescription).Append("\n");
            sb.Append("  LastModifiedTime: ").Append(LastModifiedTime).Append("\n");
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
            return this.Equals(input as OldMetadataGridModel);
        }

        /// <summary>
        /// Returns true if OldMetadataGridModel instances are equal
        /// </summary>
        /// <param name="input">Instance of OldMetadataGridModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OldMetadataGridModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.CreatedByDisplayName == input.CreatedByDisplayName ||
                    (this.CreatedByDisplayName != null &&
                    this.CreatedByDisplayName.Equals(input.CreatedByDisplayName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FieldType == input.FieldType ||
                    this.FieldType.Equals(input.FieldType)
                ) && 
                (
                    this.FieldTypeDescription == input.FieldTypeDescription ||
                    (this.FieldTypeDescription != null &&
                    this.FieldTypeDescription.Equals(input.FieldTypeDescription))
                ) && 
                (
                    this.MetadataValue == input.MetadataValue ||
                    (this.MetadataValue != null &&
                    this.MetadataValue.Equals(input.MetadataValue))
                ) && 
                (
                    this.ShowInReportType == input.ShowInReportType ||
                    this.ShowInReportType.Equals(input.ShowInReportType)
                ) && 
                (
                    this.ShowInReportTypeDescription == input.ShowInReportTypeDescription ||
                    (this.ShowInReportTypeDescription != null &&
                    this.ShowInReportTypeDescription.Equals(input.ShowInReportTypeDescription))
                ) && 
                (
                    this.LastModifiedTime == input.LastModifiedTime ||
                    (this.LastModifiedTime != null &&
                    this.LastModifiedTime.Equals(input.LastModifiedTime))
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
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedByDisplayName != null)
                    hashCode = hashCode * 59 + this.CreatedByDisplayName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.FieldType.GetHashCode();
                if (this.FieldTypeDescription != null)
                    hashCode = hashCode * 59 + this.FieldTypeDescription.GetHashCode();
                if (this.MetadataValue != null)
                    hashCode = hashCode * 59 + this.MetadataValue.GetHashCode();
                hashCode = hashCode * 59 + this.ShowInReportType.GetHashCode();
                if (this.ShowInReportTypeDescription != null)
                    hashCode = hashCode * 59 + this.ShowInReportTypeDescription.GetHashCode();
                if (this.LastModifiedTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedTime.GetHashCode();
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
