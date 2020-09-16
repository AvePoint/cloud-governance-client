

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
    /// ExtendSiteSetting
    /// </summary>
    [DataContract(Name = "ExtendSiteSetting")]
    public partial class ExtendSiteSetting : IEquatable<ExtendSiteSetting>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ExtendType
        /// </summary>
        [DataMember(Name = "extendType", EmitDefaultValue = false)]
        public ExtendType? ExtendType { get; set; }
        /// <summary>
        /// Gets or Sets DurationType
        /// </summary>
        [DataMember(Name = "durationType", EmitDefaultValue = false)]
        public ApiDurationType? DurationType { get; set; }
        /// <summary>
        /// Gets or Sets ConstantDurationType
        /// </summary>
        [DataMember(Name = "constantDurationType", EmitDefaultValue = false)]
        public ApiDurationType? ConstantDurationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendSiteSetting" /> class.
        /// </summary>
        /// <param name="extendType">extendType.</param>
        /// <param name="duration">duration.</param>
        /// <param name="durationType">durationType.</param>
        /// <param name="constantDuration">constantDuration.</param>
        /// <param name="constantDurationType">constantDurationType.</param>
        /// <param name="extendBasedTime">extendBasedTime.</param>
        public ExtendSiteSetting(ExtendType? extendType = default(ExtendType?), int duration = default(int), ApiDurationType? durationType = default(ApiDurationType?), int constantDuration = default(int), ApiDurationType? constantDurationType = default(ApiDurationType?), DateTime extendBasedTime = default(DateTime))
        {
            this.ExtendType = extendType;
            this.Duration = duration;
            this.DurationType = durationType;
            this.ConstantDuration = constantDuration;
            this.ConstantDurationType = constantDurationType;
            this.ExtendBasedTime = extendBasedTime;
        }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", EmitDefaultValue = false)]
        public int Duration { get; set; }

        /// <summary>
        /// Gets or Sets ConstantDuration
        /// </summary>
        [DataMember(Name = "constantDuration", EmitDefaultValue = false)]
        public int ConstantDuration { get; set; }

        /// <summary>
        /// Gets or Sets ExtendBasedTime
        /// </summary>
        [DataMember(Name = "extendBasedTime", EmitDefaultValue = false)]
        public DateTime ExtendBasedTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtendSiteSetting {\n");
            sb.Append("  ExtendType: ").Append(ExtendType).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  DurationType: ").Append(DurationType).Append("\n");
            sb.Append("  ConstantDuration: ").Append(ConstantDuration).Append("\n");
            sb.Append("  ConstantDurationType: ").Append(ConstantDurationType).Append("\n");
            sb.Append("  ExtendBasedTime: ").Append(ExtendBasedTime).Append("\n");
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
            return this.Equals(input as ExtendSiteSetting);
        }

        /// <summary>
        /// Returns true if ExtendSiteSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtendSiteSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtendSiteSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExtendType == input.ExtendType ||
                    this.ExtendType.Equals(input.ExtendType)
                ) && 
                (
                    this.Duration == input.Duration ||
                    this.Duration.Equals(input.Duration)
                ) && 
                (
                    this.DurationType == input.DurationType ||
                    this.DurationType.Equals(input.DurationType)
                ) && 
                (
                    this.ConstantDuration == input.ConstantDuration ||
                    this.ConstantDuration.Equals(input.ConstantDuration)
                ) && 
                (
                    this.ConstantDurationType == input.ConstantDurationType ||
                    this.ConstantDurationType.Equals(input.ConstantDurationType)
                ) && 
                (
                    this.ExtendBasedTime == input.ExtendBasedTime ||
                    (this.ExtendBasedTime != null &&
                    this.ExtendBasedTime.Equals(input.ExtendBasedTime))
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
                hashCode = hashCode * 59 + this.ExtendType.GetHashCode();
                hashCode = hashCode * 59 + this.Duration.GetHashCode();
                hashCode = hashCode * 59 + this.DurationType.GetHashCode();
                hashCode = hashCode * 59 + this.ConstantDuration.GetHashCode();
                hashCode = hashCode * 59 + this.ConstantDurationType.GetHashCode();
                if (this.ExtendBasedTime != null)
                    hashCode = hashCode * 59 + this.ExtendBasedTime.GetHashCode();
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
