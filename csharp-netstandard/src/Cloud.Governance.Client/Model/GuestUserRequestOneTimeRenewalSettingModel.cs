

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
    /// GuestUserRequestOneTimeRenewalSettingModel
    /// </summary>
    [DataContract(Name = "GuestUserRequestOneTimeRenewalSettingModel")]
    public partial class GuestUserRequestOneTimeRenewalSettingModel : IEquatable<GuestUserRequestOneTimeRenewalSettingModel>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Option
        /// </summary>
        [DataMember(Name = "option", EmitDefaultValue = false)]
        public OneTimeRenewalOption? Option { get; set; }
        /// <summary>
        /// Gets or Sets DurationType
        /// </summary>
        [DataMember(Name = "durationType", EmitDefaultValue = false)]
        public ApiDurationType? DurationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GuestUserRequestOneTimeRenewalSettingModel" /> class.
        /// </summary>
        /// <param name="option">option.</param>
        /// <param name="duration">duration (default to 0).</param>
        /// <param name="durationType">durationType.</param>
        /// <param name="startTime">startTime.</param>
        public GuestUserRequestOneTimeRenewalSettingModel(OneTimeRenewalOption? option = default(OneTimeRenewalOption?), int duration = 0, ApiDurationType? durationType = default(ApiDurationType?), DateTime? startTime = default(DateTime?))
        {
            this.Option = option;
            this.Duration = duration;
            this.DurationType = durationType;
            this.StartTime = startTime;
        }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", EmitDefaultValue = false)]
        public int Duration { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name = "startTime", EmitDefaultValue = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GuestUserRequestOneTimeRenewalSettingModel {\n");
            sb.Append("  Option: ").Append(Option).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  DurationType: ").Append(DurationType).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
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
            return this.Equals(input as GuestUserRequestOneTimeRenewalSettingModel);
        }

        /// <summary>
        /// Returns true if GuestUserRequestOneTimeRenewalSettingModel instances are equal
        /// </summary>
        /// <param name="input">Instance of GuestUserRequestOneTimeRenewalSettingModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GuestUserRequestOneTimeRenewalSettingModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Option == input.Option ||
                    this.Option.Equals(input.Option)
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
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
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
                hashCode = hashCode * 59 + this.Option.GetHashCode();
                hashCode = hashCode * 59 + this.Duration.GetHashCode();
                hashCode = hashCode * 59 + this.DurationType.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
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
