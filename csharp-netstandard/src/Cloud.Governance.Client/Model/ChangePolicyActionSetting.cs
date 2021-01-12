

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
    /// ChangePolicyActionSetting
    /// </summary>
    [DataContract(Name = "ChangePolicyActionSetting")]
    public partial class ChangePolicyActionSetting : IEquatable<ChangePolicyActionSetting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePolicyActionSetting" /> class.
        /// </summary>
        /// <param name="startDateType">startDateType.</param>
        /// <param name="specifyDateTicks">specifyDateTicks.</param>
        /// <param name="changePolicyConfig">changePolicyConfig.</param>
        /// <param name="isAllowAutoCancel">isAllowAutoCancel.</param>
        public ChangePolicyActionSetting(int startDateType = default(int), long specifyDateTicks = default(long), int changePolicyConfig = default(int), bool isAllowAutoCancel = default(bool))
        {
            this.StartDateType = startDateType;
            this.SpecifyDateTicks = specifyDateTicks;
            this.ChangePolicyConfig = changePolicyConfig;
            this.IsAllowAutoCancel = isAllowAutoCancel;
        }

        /// <summary>
        /// Gets or Sets StartDateType
        /// </summary>
        [DataMember(Name = "startDateType", EmitDefaultValue = false)]
        public int StartDateType { get; set; }

        /// <summary>
        /// Gets or Sets SpecifyDateTicks
        /// </summary>
        [DataMember(Name = "specifyDateTicks", EmitDefaultValue = false)]
        public long SpecifyDateTicks { get; set; }

        /// <summary>
        /// Gets or Sets ChangePolicyConfig
        /// </summary>
        [DataMember(Name = "changePolicyConfig", EmitDefaultValue = false)]
        public int ChangePolicyConfig { get; set; }

        /// <summary>
        /// Gets or Sets IsAllowAutoCancel
        /// </summary>
        [DataMember(Name = "isAllowAutoCancel", EmitDefaultValue = false)]
        public bool IsAllowAutoCancel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangePolicyActionSetting {\n");
            sb.Append("  StartDateType: ").Append(StartDateType).Append("\n");
            sb.Append("  SpecifyDateTicks: ").Append(SpecifyDateTicks).Append("\n");
            sb.Append("  ChangePolicyConfig: ").Append(ChangePolicyConfig).Append("\n");
            sb.Append("  IsAllowAutoCancel: ").Append(IsAllowAutoCancel).Append("\n");
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
            return this.Equals(input as ChangePolicyActionSetting);
        }

        /// <summary>
        /// Returns true if ChangePolicyActionSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangePolicyActionSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangePolicyActionSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartDateType == input.StartDateType ||
                    this.StartDateType.Equals(input.StartDateType)
                ) && 
                (
                    this.SpecifyDateTicks == input.SpecifyDateTicks ||
                    this.SpecifyDateTicks.Equals(input.SpecifyDateTicks)
                ) && 
                (
                    this.ChangePolicyConfig == input.ChangePolicyConfig ||
                    this.ChangePolicyConfig.Equals(input.ChangePolicyConfig)
                ) && 
                (
                    this.IsAllowAutoCancel == input.IsAllowAutoCancel ||
                    this.IsAllowAutoCancel.Equals(input.IsAllowAutoCancel)
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
                hashCode = hashCode * 59 + this.StartDateType.GetHashCode();
                hashCode = hashCode * 59 + this.SpecifyDateTicks.GetHashCode();
                hashCode = hashCode * 59 + this.ChangePolicyConfig.GetHashCode();
                hashCode = hashCode * 59 + this.IsAllowAutoCancel.GetHashCode();
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
