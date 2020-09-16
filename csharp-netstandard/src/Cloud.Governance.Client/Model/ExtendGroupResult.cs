

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
    /// ExtendGroupResult
    /// </summary>
    [DataContract(Name = "ExtendGroupResult")]
    public partial class ExtendGroupResult : IEquatable<ExtendGroupResult>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="ExtendGroupResult" /> class.
        /// </summary>
        /// <param name="extendType">extendType.</param>
        /// <param name="duration">duration.</param>
        /// <param name="durationType">durationType.</param>
        public ExtendGroupResult(ExtendType? extendType = default(ExtendType?), int duration = default(int), ApiDurationType? durationType = default(ApiDurationType?))
        {
            this.ExtendType = extendType;
            this.Duration = duration;
            this.DurationType = durationType;
        }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", EmitDefaultValue = false)]
        public int Duration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtendGroupResult {\n");
            sb.Append("  ExtendType: ").Append(ExtendType).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  DurationType: ").Append(DurationType).Append("\n");
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
            return this.Equals(input as ExtendGroupResult);
        }

        /// <summary>
        /// Returns true if ExtendGroupResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtendGroupResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtendGroupResult input)
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
