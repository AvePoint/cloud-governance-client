

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
    /// DynamicGroupRuleModel
    /// </summary>
    [DataContract(Name = "DynamicGroupRuleModel")]
    public partial class DynamicGroupRuleModel : IEquatable<DynamicGroupRuleModel>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="DynamicGroupRuleModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="order">order (default to 0).</param>
        /// <param name="relation">relation.</param>
        /// <param name="relationDescription">relationDescription.</param>
        /// <param name="category">category.</param>
        /// <param name="categoryDescription">categoryDescription.</param>
        /// <param name="metadataName">metadataName.</param>
        /// <param name="metadataDisplayValue">metadataDisplayValue.</param>
        /// <param name="condition">condition.</param>
        /// <param name="conditionDescription">conditionDescription.</param>
        public DynamicGroupRuleModel(Guid id = default(Guid), int order = 0, LogicalOperator? relation = default(LogicalOperator?), string relationDescription = default(string), CategoryType? category = default(CategoryType?), string categoryDescription = default(string), string metadataName = default(string), string metadataDisplayValue = default(string), DynamicRuleCondition? condition = default(DynamicRuleCondition?), string conditionDescription = default(string))
        {
            this.Id = id;
            this.Order = order;
            this.Relation = relation;
            this.RelationDescription = relationDescription;
            this.Category = category;
            this.CategoryDescription = categoryDescription;
            this.MetadataName = metadataName;
            this.MetadataDisplayValue = metadataDisplayValue;
            this.Condition = condition;
            this.ConditionDescription = conditionDescription;
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
        /// Gets or Sets RelationDescription
        /// </summary>
        [DataMember(Name = "relationDescription", EmitDefaultValue = true)]
        public string RelationDescription { get; set; }

        /// <summary>
        /// Gets or Sets CategoryDescription
        /// </summary>
        [DataMember(Name = "categoryDescription", EmitDefaultValue = true)]
        public string CategoryDescription { get; set; }

        /// <summary>
        /// Gets or Sets MetadataName
        /// </summary>
        [DataMember(Name = "metadataName", EmitDefaultValue = true)]
        public string MetadataName { get; set; }

        /// <summary>
        /// Gets or Sets MetadataDisplayValue
        /// </summary>
        [DataMember(Name = "metadataDisplayValue", EmitDefaultValue = true)]
        public string MetadataDisplayValue { get; set; }

        /// <summary>
        /// Gets or Sets ConditionDescription
        /// </summary>
        [DataMember(Name = "conditionDescription", EmitDefaultValue = true)]
        public string ConditionDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DynamicGroupRuleModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Relation: ").Append(Relation).Append("\n");
            sb.Append("  RelationDescription: ").Append(RelationDescription).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  CategoryDescription: ").Append(CategoryDescription).Append("\n");
            sb.Append("  MetadataName: ").Append(MetadataName).Append("\n");
            sb.Append("  MetadataDisplayValue: ").Append(MetadataDisplayValue).Append("\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
            sb.Append("  ConditionDescription: ").Append(ConditionDescription).Append("\n");
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
            return this.Equals(input as DynamicGroupRuleModel);
        }

        /// <summary>
        /// Returns true if DynamicGroupRuleModel instances are equal
        /// </summary>
        /// <param name="input">Instance of DynamicGroupRuleModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DynamicGroupRuleModel input)
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
                    this.RelationDescription == input.RelationDescription ||
                    (this.RelationDescription != null &&
                    this.RelationDescription.Equals(input.RelationDescription))
                ) && 
                (
                    this.Category == input.Category ||
                    this.Category.Equals(input.Category)
                ) && 
                (
                    this.CategoryDescription == input.CategoryDescription ||
                    (this.CategoryDescription != null &&
                    this.CategoryDescription.Equals(input.CategoryDescription))
                ) && 
                (
                    this.MetadataName == input.MetadataName ||
                    (this.MetadataName != null &&
                    this.MetadataName.Equals(input.MetadataName))
                ) && 
                (
                    this.MetadataDisplayValue == input.MetadataDisplayValue ||
                    (this.MetadataDisplayValue != null &&
                    this.MetadataDisplayValue.Equals(input.MetadataDisplayValue))
                ) && 
                (
                    this.Condition == input.Condition ||
                    this.Condition.Equals(input.Condition)
                ) && 
                (
                    this.ConditionDescription == input.ConditionDescription ||
                    (this.ConditionDescription != null &&
                    this.ConditionDescription.Equals(input.ConditionDescription))
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
                if (this.RelationDescription != null)
                    hashCode = hashCode * 59 + this.RelationDescription.GetHashCode();
                hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.CategoryDescription != null)
                    hashCode = hashCode * 59 + this.CategoryDescription.GetHashCode();
                if (this.MetadataName != null)
                    hashCode = hashCode * 59 + this.MetadataName.GetHashCode();
                if (this.MetadataDisplayValue != null)
                    hashCode = hashCode * 59 + this.MetadataDisplayValue.GetHashCode();
                hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.ConditionDescription != null)
                    hashCode = hashCode * 59 + this.ConditionDescription.GetHashCode();
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
