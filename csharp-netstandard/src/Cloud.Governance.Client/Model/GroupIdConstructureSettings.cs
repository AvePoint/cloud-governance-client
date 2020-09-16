

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
    /// GroupIdConstructureSettings
    /// </summary>
    [DataContract(Name = "GroupIdConstructureSettings")]
    public partial class GroupIdConstructureSettings : IEquatable<GroupIdConstructureSettings>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets RuleType
        /// </summary>
        [DataMember(Name = "ruleType", EmitDefaultValue = false)]
        public GroupIdRuleType? RuleType { get; set; }
        /// <summary>
        /// Gets or Sets AssignBy
        /// </summary>
        [DataMember(Name = "assignBy", EmitDefaultValue = false)]
        public AssignBy? AssignBy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupIdConstructureSettings" /> class.
        /// </summary>
        /// <param name="ruleType">ruleType.</param>
        /// <param name="enableAutoSequenceNumber">enableAutoSequenceNumber.</param>
        /// <param name="autoSequenceNumber">autoSequenceNumber.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="assignBy">assignBy.</param>
        /// <param name="prefixs">prefixs.</param>
        /// <param name="suffixs">suffixs.</param>
        public GroupIdConstructureSettings(GroupIdRuleType? ruleType = default(GroupIdRuleType?), bool enableAutoSequenceNumber = default(bool), string autoSequenceNumber = default(string), bool enabled = default(bool), AssignBy? assignBy = default(AssignBy?), List<GroupConstructureRule> prefixs = default(List<GroupConstructureRule>), List<GroupConstructureRule> suffixs = default(List<GroupConstructureRule>))
        {
            this.RuleType = ruleType;
            this.EnableAutoSequenceNumber = enableAutoSequenceNumber;
            this.AutoSequenceNumber = autoSequenceNumber;
            this.Enabled = enabled;
            this.AssignBy = assignBy;
            this.Prefixs = prefixs;
            this.Suffixs = suffixs;
        }

        /// <summary>
        /// Gets or Sets EnableAutoSequenceNumber
        /// </summary>
        [DataMember(Name = "enableAutoSequenceNumber", EmitDefaultValue = false)]
        public bool EnableAutoSequenceNumber { get; set; }

        /// <summary>
        /// Gets or Sets AutoSequenceNumber
        /// </summary>
        [DataMember(Name = "autoSequenceNumber", EmitDefaultValue = true)]
        public string AutoSequenceNumber { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Prefixs
        /// </summary>
        [DataMember(Name = "prefixs", EmitDefaultValue = true)]
        public List<GroupConstructureRule> Prefixs { get; set; }

        /// <summary>
        /// Gets or Sets Suffixs
        /// </summary>
        [DataMember(Name = "suffixs", EmitDefaultValue = true)]
        public List<GroupConstructureRule> Suffixs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupIdConstructureSettings {\n");
            sb.Append("  RuleType: ").Append(RuleType).Append("\n");
            sb.Append("  EnableAutoSequenceNumber: ").Append(EnableAutoSequenceNumber).Append("\n");
            sb.Append("  AutoSequenceNumber: ").Append(AutoSequenceNumber).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  AssignBy: ").Append(AssignBy).Append("\n");
            sb.Append("  Prefixs: ").Append(Prefixs).Append("\n");
            sb.Append("  Suffixs: ").Append(Suffixs).Append("\n");
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
            return this.Equals(input as GroupIdConstructureSettings);
        }

        /// <summary>
        /// Returns true if GroupIdConstructureSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupIdConstructureSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupIdConstructureSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RuleType == input.RuleType ||
                    this.RuleType.Equals(input.RuleType)
                ) && 
                (
                    this.EnableAutoSequenceNumber == input.EnableAutoSequenceNumber ||
                    this.EnableAutoSequenceNumber.Equals(input.EnableAutoSequenceNumber)
                ) && 
                (
                    this.AutoSequenceNumber == input.AutoSequenceNumber ||
                    (this.AutoSequenceNumber != null &&
                    this.AutoSequenceNumber.Equals(input.AutoSequenceNumber))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.AssignBy == input.AssignBy ||
                    this.AssignBy.Equals(input.AssignBy)
                ) && 
                (
                    this.Prefixs == input.Prefixs ||
                    this.Prefixs != null &&
                    input.Prefixs != null &&
                    this.Prefixs.SequenceEqual(input.Prefixs)
                ) && 
                (
                    this.Suffixs == input.Suffixs ||
                    this.Suffixs != null &&
                    input.Suffixs != null &&
                    this.Suffixs.SequenceEqual(input.Suffixs)
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
                hashCode = hashCode * 59 + this.RuleType.GetHashCode();
                hashCode = hashCode * 59 + this.EnableAutoSequenceNumber.GetHashCode();
                if (this.AutoSequenceNumber != null)
                    hashCode = hashCode * 59 + this.AutoSequenceNumber.GetHashCode();
                hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                hashCode = hashCode * 59 + this.AssignBy.GetHashCode();
                if (this.Prefixs != null)
                    hashCode = hashCode * 59 + this.Prefixs.GetHashCode();
                if (this.Suffixs != null)
                    hashCode = hashCode * 59 + this.Suffixs.GetHashCode();
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
