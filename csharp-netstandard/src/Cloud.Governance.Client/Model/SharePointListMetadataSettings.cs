

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
    /// SharePointListMetadataSettings
    /// </summary>
    [DataContract(Name = "SharePointListMetadataSettings")]
    public partial class SharePointListMetadataSettings : IEquatable<SharePointListMetadataSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharePointListMetadataSettings" /> class.
        /// </summary>
        /// <param name="listUrl">listUrl.</param>
        /// <param name="webUrl">webUrl.</param>
        /// <param name="propertyType">propertyType.</param>
        /// <param name="property">property.</param>
        /// <param name="propertyName">propertyName.</param>
        /// <param name="isAdditionalColumnEnabled">isAdditionalColumnEnabled.</param>
        /// <param name="matchedMetadataId">matchedMetadataId.</param>
        /// <param name="matchedMetadataName">matchedMetadataName.</param>
        /// <param name="additionalColumn">additionalColumn.</param>
        /// <param name="additionalColumnType">additionalColumnType.</param>
        /// <param name="additionalColumnName">additionalColumnName.</param>
        /// <param name="value">value.</param>
        /// <param name="allowReferenceAsRoleInApprovalProcess">allowReferenceAsRoleInApprovalProcess.</param>
        public SharePointListMetadataSettings(string listUrl = default(string), string webUrl = default(string), string propertyType = default(string), string property = default(string), string propertyName = default(string), bool isAdditionalColumnEnabled = default(bool), string matchedMetadataId = default(string), string matchedMetadataName = default(string), string additionalColumn = default(string), string additionalColumnType = default(string), string additionalColumnName = default(string), LookupListValue value = default(LookupListValue), bool allowReferenceAsRoleInApprovalProcess = default(bool))
        {
            this.ListUrl = listUrl;
            this.WebUrl = webUrl;
            this.PropertyType = propertyType;
            this.Property = property;
            this.PropertyName = propertyName;
            this.IsAdditionalColumnEnabled = isAdditionalColumnEnabled;
            this.MatchedMetadataId = matchedMetadataId;
            this.MatchedMetadataName = matchedMetadataName;
            this.AdditionalColumn = additionalColumn;
            this.AdditionalColumnType = additionalColumnType;
            this.AdditionalColumnName = additionalColumnName;
            this.Value = value;
            this.AllowReferenceAsRoleInApprovalProcess = allowReferenceAsRoleInApprovalProcess;
        }

        /// <summary>
        /// Gets or Sets ListUrl
        /// </summary>
        [DataMember(Name = "listUrl", EmitDefaultValue = true)]
        public string ListUrl { get; set; }

        /// <summary>
        /// Gets or Sets WebUrl
        /// </summary>
        [DataMember(Name = "webUrl", EmitDefaultValue = true)]
        public string WebUrl { get; set; }

        /// <summary>
        /// Gets or Sets PropertyType
        /// </summary>
        [DataMember(Name = "propertyType", EmitDefaultValue = true)]
        public string PropertyType { get; set; }

        /// <summary>
        /// Gets or Sets Property
        /// </summary>
        [DataMember(Name = "property", EmitDefaultValue = true)]
        public string Property { get; set; }

        /// <summary>
        /// Gets or Sets PropertyName
        /// </summary>
        [DataMember(Name = "propertyName", EmitDefaultValue = true)]
        public string PropertyName { get; set; }

        /// <summary>
        /// Gets or Sets IsAdditionalColumnEnabled
        /// </summary>
        [DataMember(Name = "isAdditionalColumnEnabled", EmitDefaultValue = false)]
        public bool IsAdditionalColumnEnabled { get; set; }

        /// <summary>
        /// Gets or Sets MatchedMetadataId
        /// </summary>
        [DataMember(Name = "matchedMetadataId", EmitDefaultValue = true)]
        public string MatchedMetadataId { get; set; }

        /// <summary>
        /// Gets or Sets MatchedMetadataName
        /// </summary>
        [DataMember(Name = "matchedMetadataName", EmitDefaultValue = true)]
        public string MatchedMetadataName { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalColumn
        /// </summary>
        [DataMember(Name = "additionalColumn", EmitDefaultValue = true)]
        public string AdditionalColumn { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalColumnType
        /// </summary>
        [DataMember(Name = "additionalColumnType", EmitDefaultValue = true)]
        public string AdditionalColumnType { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalColumnName
        /// </summary>
        [DataMember(Name = "additionalColumnName", EmitDefaultValue = true)]
        public string AdditionalColumnName { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public LookupListValue Value { get; set; }

        /// <summary>
        /// Gets or Sets AllowReferenceAsRoleInApprovalProcess
        /// </summary>
        [DataMember(Name = "allowReferenceAsRoleInApprovalProcess", EmitDefaultValue = false)]
        public bool AllowReferenceAsRoleInApprovalProcess { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SharePointListMetadataSettings {\n");
            sb.Append("  ListUrl: ").Append(ListUrl).Append("\n");
            sb.Append("  WebUrl: ").Append(WebUrl).Append("\n");
            sb.Append("  PropertyType: ").Append(PropertyType).Append("\n");
            sb.Append("  Property: ").Append(Property).Append("\n");
            sb.Append("  PropertyName: ").Append(PropertyName).Append("\n");
            sb.Append("  IsAdditionalColumnEnabled: ").Append(IsAdditionalColumnEnabled).Append("\n");
            sb.Append("  MatchedMetadataId: ").Append(MatchedMetadataId).Append("\n");
            sb.Append("  MatchedMetadataName: ").Append(MatchedMetadataName).Append("\n");
            sb.Append("  AdditionalColumn: ").Append(AdditionalColumn).Append("\n");
            sb.Append("  AdditionalColumnType: ").Append(AdditionalColumnType).Append("\n");
            sb.Append("  AdditionalColumnName: ").Append(AdditionalColumnName).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  AllowReferenceAsRoleInApprovalProcess: ").Append(AllowReferenceAsRoleInApprovalProcess).Append("\n");
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
            return this.Equals(input as SharePointListMetadataSettings);
        }

        /// <summary>
        /// Returns true if SharePointListMetadataSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of SharePointListMetadataSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharePointListMetadataSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ListUrl == input.ListUrl ||
                    (this.ListUrl != null &&
                    this.ListUrl.Equals(input.ListUrl))
                ) && 
                (
                    this.WebUrl == input.WebUrl ||
                    (this.WebUrl != null &&
                    this.WebUrl.Equals(input.WebUrl))
                ) && 
                (
                    this.PropertyType == input.PropertyType ||
                    (this.PropertyType != null &&
                    this.PropertyType.Equals(input.PropertyType))
                ) && 
                (
                    this.Property == input.Property ||
                    (this.Property != null &&
                    this.Property.Equals(input.Property))
                ) && 
                (
                    this.PropertyName == input.PropertyName ||
                    (this.PropertyName != null &&
                    this.PropertyName.Equals(input.PropertyName))
                ) && 
                (
                    this.IsAdditionalColumnEnabled == input.IsAdditionalColumnEnabled ||
                    this.IsAdditionalColumnEnabled.Equals(input.IsAdditionalColumnEnabled)
                ) && 
                (
                    this.MatchedMetadataId == input.MatchedMetadataId ||
                    (this.MatchedMetadataId != null &&
                    this.MatchedMetadataId.Equals(input.MatchedMetadataId))
                ) && 
                (
                    this.MatchedMetadataName == input.MatchedMetadataName ||
                    (this.MatchedMetadataName != null &&
                    this.MatchedMetadataName.Equals(input.MatchedMetadataName))
                ) && 
                (
                    this.AdditionalColumn == input.AdditionalColumn ||
                    (this.AdditionalColumn != null &&
                    this.AdditionalColumn.Equals(input.AdditionalColumn))
                ) && 
                (
                    this.AdditionalColumnType == input.AdditionalColumnType ||
                    (this.AdditionalColumnType != null &&
                    this.AdditionalColumnType.Equals(input.AdditionalColumnType))
                ) && 
                (
                    this.AdditionalColumnName == input.AdditionalColumnName ||
                    (this.AdditionalColumnName != null &&
                    this.AdditionalColumnName.Equals(input.AdditionalColumnName))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.AllowReferenceAsRoleInApprovalProcess == input.AllowReferenceAsRoleInApprovalProcess ||
                    this.AllowReferenceAsRoleInApprovalProcess.Equals(input.AllowReferenceAsRoleInApprovalProcess)
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
                if (this.ListUrl != null)
                    hashCode = hashCode * 59 + this.ListUrl.GetHashCode();
                if (this.WebUrl != null)
                    hashCode = hashCode * 59 + this.WebUrl.GetHashCode();
                if (this.PropertyType != null)
                    hashCode = hashCode * 59 + this.PropertyType.GetHashCode();
                if (this.Property != null)
                    hashCode = hashCode * 59 + this.Property.GetHashCode();
                if (this.PropertyName != null)
                    hashCode = hashCode * 59 + this.PropertyName.GetHashCode();
                hashCode = hashCode * 59 + this.IsAdditionalColumnEnabled.GetHashCode();
                if (this.MatchedMetadataId != null)
                    hashCode = hashCode * 59 + this.MatchedMetadataId.GetHashCode();
                if (this.MatchedMetadataName != null)
                    hashCode = hashCode * 59 + this.MatchedMetadataName.GetHashCode();
                if (this.AdditionalColumn != null)
                    hashCode = hashCode * 59 + this.AdditionalColumn.GetHashCode();
                if (this.AdditionalColumnType != null)
                    hashCode = hashCode * 59 + this.AdditionalColumnType.GetHashCode();
                if (this.AdditionalColumnName != null)
                    hashCode = hashCode * 59 + this.AdditionalColumnName.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                hashCode = hashCode * 59 + this.AllowReferenceAsRoleInApprovalProcess.GetHashCode();
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
