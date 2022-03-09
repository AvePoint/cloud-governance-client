

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
    /// DynamicGroupRuleInfo
    /// </summary>
    [DataContract(Name = "DynamicGroupRuleInfo")]
    public partial class DynamicGroupRuleInfo : IEquatable<DynamicGroupRuleInfo>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Relation
        /// </summary>
        [DataMember(Name = "relation", EmitDefaultValue = false)]
        public LogicalOperator? Relation { get; set; }
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public CategoryType? Category { get; set; }
        /// <summary>
        /// Gets or Sets Condition
        /// </summary>
        [DataMember(Name = "condition", EmitDefaultValue = false)]
        public DynamicRuleCondition? Condition { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicGroupRuleInfo" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="order">order (default to 0).</param>
        /// <param name="relation">relation.</param>
        /// <param name="category">category.</param>
        /// <param name="metadataId">metadataId.</param>
        /// <param name="metadataName">metadataName.</param>
        /// <param name="metadataValue">metadataValue.</param>
        /// <param name="metadataDisplayValue">metadataDisplayValue.</param>
        /// <param name="metadataValueAzureUserType">metadataValueAzureUserType.</param>
        /// <param name="condition">condition.</param>
        /// <param name="disableEditRule">disableEditRule (default to false).</param>
        /// <param name="disableEditRuleValue">disableEditRuleValue (default to false).</param>
        /// <param name="metadataUserList">metadataUserList.</param>
        public DynamicGroupRuleInfo(Guid id = default(Guid), int order = 0, LogicalOperator? relation = default(LogicalOperator?), CategoryType? category = default(CategoryType?), Guid metadataId = default(Guid), string metadataName = default(string), string metadataValue = default(string), string metadataDisplayValue = default(string), string metadataValueAzureUserType = default(string), DynamicRuleCondition? condition = default(DynamicRuleCondition?), bool disableEditRule = false, bool disableEditRuleValue = false, List<UserInfo> metadataUserList = default(List<UserInfo>))
        {
            this.Id = id;
            this.Order = order;
            this.Relation = relation;
            this.Category = category;
            this.MetadataId = metadataId;
            this.MetadataName = metadataName;
            this.MetadataValue = metadataValue;
            this.MetadataDisplayValue = metadataDisplayValue;
            this.MetadataValueAzureUserType = metadataValueAzureUserType;
            this.Condition = condition;
            this.DisableEditRule = disableEditRule;
            this.DisableEditRuleValue = disableEditRuleValue;
            this.MetadataUserList = metadataUserList;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int Order { get; set; }

        /// <summary>
        /// Gets or Sets MetadataId
        /// </summary>
        [DataMember(Name = "metadataId", EmitDefaultValue = false)]
        public Guid MetadataId { get; set; }

        /// <summary>
        /// Gets or Sets MetadataName
        /// </summary>
        [DataMember(Name = "metadataName", EmitDefaultValue = true)]
        public string MetadataName { get; set; }

        /// <summary>
        /// Gets or Sets MetadataValue
        /// </summary>
        [DataMember(Name = "metadataValue", EmitDefaultValue = true)]
        public string MetadataValue { get; set; }

        /// <summary>
        /// Gets or Sets MetadataDisplayValue
        /// </summary>
        [DataMember(Name = "metadataDisplayValue", EmitDefaultValue = true)]
        public string MetadataDisplayValue { get; set; }

        /// <summary>
        /// Gets or Sets MetadataValueAzureUserType
        /// </summary>
        [DataMember(Name = "metadataValueAzureUserType", EmitDefaultValue = true)]
        public string MetadataValueAzureUserType { get; set; }

        /// <summary>
        /// Gets or Sets DisableEditRule
        /// </summary>
        [DataMember(Name = "disableEditRule", EmitDefaultValue = false)]
        public bool DisableEditRule { get; set; }

        /// <summary>
        /// Gets or Sets DisableEditRuleValue
        /// </summary>
        [DataMember(Name = "disableEditRuleValue", EmitDefaultValue = false)]
        public bool DisableEditRuleValue { get; set; }

        /// <summary>
        /// Gets or Sets MetadataUserList
        /// </summary>
        [DataMember(Name = "metadataUserList", EmitDefaultValue = true)]
        public List<UserInfo> MetadataUserList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DynamicGroupRuleInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Relation: ").Append(Relation).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  MetadataId: ").Append(MetadataId).Append("\n");
            sb.Append("  MetadataName: ").Append(MetadataName).Append("\n");
            sb.Append("  MetadataValue: ").Append(MetadataValue).Append("\n");
            sb.Append("  MetadataDisplayValue: ").Append(MetadataDisplayValue).Append("\n");
            sb.Append("  MetadataValueAzureUserType: ").Append(MetadataValueAzureUserType).Append("\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
            sb.Append("  DisableEditRule: ").Append(DisableEditRule).Append("\n");
            sb.Append("  DisableEditRuleValue: ").Append(DisableEditRuleValue).Append("\n");
            sb.Append("  MetadataUserList: ").Append(MetadataUserList).Append("\n");
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
            return this.Equals(input as DynamicGroupRuleInfo);
        }

        /// <summary>
        /// Returns true if DynamicGroupRuleInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DynamicGroupRuleInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DynamicGroupRuleInfo input)
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
                    this.Order == input.Order ||
                    this.Order.Equals(input.Order)
                ) && 
                (
                    this.Relation == input.Relation ||
                    this.Relation.Equals(input.Relation)
                ) && 
                (
                    this.Category == input.Category ||
                    this.Category.Equals(input.Category)
                ) && 
                (
                    this.MetadataId == input.MetadataId ||
                    (this.MetadataId != null &&
                    this.MetadataId.Equals(input.MetadataId))
                ) && 
                (
                    this.MetadataName == input.MetadataName ||
                    (this.MetadataName != null &&
                    this.MetadataName.Equals(input.MetadataName))
                ) && 
                (
                    this.MetadataValue == input.MetadataValue ||
                    (this.MetadataValue != null &&
                    this.MetadataValue.Equals(input.MetadataValue))
                ) && 
                (
                    this.MetadataDisplayValue == input.MetadataDisplayValue ||
                    (this.MetadataDisplayValue != null &&
                    this.MetadataDisplayValue.Equals(input.MetadataDisplayValue))
                ) && 
                (
                    this.MetadataValueAzureUserType == input.MetadataValueAzureUserType ||
                    (this.MetadataValueAzureUserType != null &&
                    this.MetadataValueAzureUserType.Equals(input.MetadataValueAzureUserType))
                ) && 
                (
                    this.Condition == input.Condition ||
                    this.Condition.Equals(input.Condition)
                ) && 
                (
                    this.DisableEditRule == input.DisableEditRule ||
                    this.DisableEditRule.Equals(input.DisableEditRule)
                ) && 
                (
                    this.DisableEditRuleValue == input.DisableEditRuleValue ||
                    this.DisableEditRuleValue.Equals(input.DisableEditRuleValue)
                ) && 
                (
                    this.MetadataUserList == input.MetadataUserList ||
                    this.MetadataUserList != null &&
                    input.MetadataUserList != null &&
                    this.MetadataUserList.SequenceEqual(input.MetadataUserList)
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
                hashCode = hashCode * 59 + this.Order.GetHashCode();
                hashCode = hashCode * 59 + this.Relation.GetHashCode();
                hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.MetadataId != null)
                    hashCode = hashCode * 59 + this.MetadataId.GetHashCode();
                if (this.MetadataName != null)
                    hashCode = hashCode * 59 + this.MetadataName.GetHashCode();
                if (this.MetadataValue != null)
                    hashCode = hashCode * 59 + this.MetadataValue.GetHashCode();
                if (this.MetadataDisplayValue != null)
                    hashCode = hashCode * 59 + this.MetadataDisplayValue.GetHashCode();
                if (this.MetadataValueAzureUserType != null)
                    hashCode = hashCode * 59 + this.MetadataValueAzureUserType.GetHashCode();
                hashCode = hashCode * 59 + this.Condition.GetHashCode();
                hashCode = hashCode * 59 + this.DisableEditRule.GetHashCode();
                hashCode = hashCode * 59 + this.DisableEditRuleValue.GetHashCode();
                if (this.MetadataUserList != null)
                    hashCode = hashCode * 59 + this.MetadataUserList.GetHashCode();
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
