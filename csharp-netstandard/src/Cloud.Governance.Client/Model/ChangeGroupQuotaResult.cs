

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
    /// ChangeGroupQuotaResult
    /// </summary>
    [DataContract(Name = "ChangeGroupQuotaResult")]
    public partial class ChangeGroupQuotaResult : IEquatable<ChangeGroupQuotaResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeGroupQuotaResult" /> class.
        /// </summary>
        /// <param name="allowedAnySize">allowedAnySize.</param>
        /// <param name="minQuotaSize">minQuotaSize.</param>
        /// <param name="maxQuotaSize">maxQuotaSize.</param>
        /// <param name="currentQuotaSize">currentQuotaSize.</param>
        public ChangeGroupQuotaResult(bool allowedAnySize = default(bool), long minQuotaSize = default(long), long maxQuotaSize = default(long), long currentQuotaSize = default(long))
        {
            this.AllowedAnySize = allowedAnySize;
            this.MinQuotaSize = minQuotaSize;
            this.MaxQuotaSize = maxQuotaSize;
            this.CurrentQuotaSize = currentQuotaSize;
        }

        /// <summary>
        /// Gets or Sets AllowedAnySize
        /// </summary>
        [DataMember(Name = "allowedAnySize", EmitDefaultValue = false)]
        public bool AllowedAnySize { get; set; }

        /// <summary>
        /// Gets or Sets MinQuotaSize
        /// </summary>
        [DataMember(Name = "minQuotaSize", EmitDefaultValue = false)]
        public long MinQuotaSize { get; set; }

        /// <summary>
        /// Gets or Sets MaxQuotaSize
        /// </summary>
        [DataMember(Name = "maxQuotaSize", EmitDefaultValue = false)]
        public long MaxQuotaSize { get; set; }

        /// <summary>
        /// Gets or Sets CurrentQuotaSize
        /// </summary>
        [DataMember(Name = "currentQuotaSize", EmitDefaultValue = false)]
        public long CurrentQuotaSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeGroupQuotaResult {\n");
            sb.Append("  AllowedAnySize: ").Append(AllowedAnySize).Append("\n");
            sb.Append("  MinQuotaSize: ").Append(MinQuotaSize).Append("\n");
            sb.Append("  MaxQuotaSize: ").Append(MaxQuotaSize).Append("\n");
            sb.Append("  CurrentQuotaSize: ").Append(CurrentQuotaSize).Append("\n");
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
            return this.Equals(input as ChangeGroupQuotaResult);
        }

        /// <summary>
        /// Returns true if ChangeGroupQuotaResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeGroupQuotaResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeGroupQuotaResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowedAnySize == input.AllowedAnySize ||
                    this.AllowedAnySize.Equals(input.AllowedAnySize)
                ) && 
                (
                    this.MinQuotaSize == input.MinQuotaSize ||
                    this.MinQuotaSize.Equals(input.MinQuotaSize)
                ) && 
                (
                    this.MaxQuotaSize == input.MaxQuotaSize ||
                    this.MaxQuotaSize.Equals(input.MaxQuotaSize)
                ) && 
                (
                    this.CurrentQuotaSize == input.CurrentQuotaSize ||
                    this.CurrentQuotaSize.Equals(input.CurrentQuotaSize)
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
                hashCode = hashCode * 59 + this.AllowedAnySize.GetHashCode();
                hashCode = hashCode * 59 + this.MinQuotaSize.GetHashCode();
                hashCode = hashCode * 59 + this.MaxQuotaSize.GetHashCode();
                hashCode = hashCode * 59 + this.CurrentQuotaSize.GetHashCode();
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
