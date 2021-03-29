

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
    /// GrantPermissionServiceDurationSettings
    /// </summary>
    [DataContract(Name = "GrantPermissionServiceDurationSettings")]
    public partial class GrantPermissionServiceDurationSettings : IEquatable<GrantPermissionServiceDurationSettings>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets AssignBy
        /// </summary>
        [DataMember(Name = "assignBy", EmitDefaultValue = false)]
        public AssignBy? AssignBy { get; set; }
        /// <summary>
        /// Gets or Sets DefaultDurationType
        /// </summary>
        [DataMember(Name = "defaultDurationType", EmitDefaultValue = false)]
        public DurationDateType? DefaultDurationType { get; set; }
        /// <summary>
        /// Gets or Sets MaxDurationType
        /// </summary>
        [DataMember(Name = "maxDurationType", EmitDefaultValue = false)]
        public DurationDateType? MaxDurationType { get; set; }
        /// <summary>
        /// Gets or Sets ExpirationNotifyDurationType
        /// </summary>
        [DataMember(Name = "expirationNotifyDurationType", EmitDefaultValue = false)]
        public DurationDateType? ExpirationNotifyDurationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GrantPermissionServiceDurationSettings" /> class.
        /// </summary>
        /// <param name="assignBy">assignBy.</param>
        /// <param name="isGrantTemporaryPermission">isGrantTemporaryPermission (default to false).</param>
        /// <param name="defaultDurationInterval">defaultDurationInterval (default to 0).</param>
        /// <param name="defaultDurationType">defaultDurationType.</param>
        /// <param name="isEnableMaxDuration">isEnableMaxDuration (default to false).</param>
        /// <param name="maxDuration">maxDuration (default to 0).</param>
        /// <param name="maxDurationType">maxDurationType.</param>
        /// <param name="isEnableExpirationNotify">isEnableExpirationNotify (default to false).</param>
        /// <param name="expirationNotifyDurationInterval">expirationNotifyDurationInterval (default to 0).</param>
        /// <param name="expirationNotifyDurationType">expirationNotifyDurationType.</param>
        /// <param name="isOnlyUseDefaultDuration">isOnlyUseDefaultDuration (default to false).</param>
        public GrantPermissionServiceDurationSettings(AssignBy? assignBy = default(AssignBy?), bool isGrantTemporaryPermission = false, int? defaultDurationInterval = 0, DurationDateType? defaultDurationType = default(DurationDateType?), bool isEnableMaxDuration = false, int maxDuration = 0, DurationDateType? maxDurationType = default(DurationDateType?), bool isEnableExpirationNotify = false, int expirationNotifyDurationInterval = 0, DurationDateType? expirationNotifyDurationType = default(DurationDateType?), bool isOnlyUseDefaultDuration = false)
        {
            this.AssignBy = assignBy;
            this.IsGrantTemporaryPermission = isGrantTemporaryPermission;
            // use default value if no "defaultDurationInterval" provided
            this.DefaultDurationInterval = defaultDurationInterval ?? 0;
            this.DefaultDurationType = defaultDurationType;
            this.IsEnableMaxDuration = isEnableMaxDuration;
            this.MaxDuration = maxDuration;
            this.MaxDurationType = maxDurationType;
            this.IsEnableExpirationNotify = isEnableExpirationNotify;
            this.ExpirationNotifyDurationInterval = expirationNotifyDurationInterval;
            this.ExpirationNotifyDurationType = expirationNotifyDurationType;
            this.IsOnlyUseDefaultDuration = isOnlyUseDefaultDuration;
        }

        /// <summary>
        /// Gets or Sets IsGrantTemporaryPermission
        /// </summary>
        [DataMember(Name = "isGrantTemporaryPermission", EmitDefaultValue = false)]
        public bool IsGrantTemporaryPermission { get; set; }

        /// <summary>
        /// Gets or Sets DefaultDurationInterval
        /// </summary>
        [DataMember(Name = "defaultDurationInterval", EmitDefaultValue = true)]
        public int? DefaultDurationInterval { get; set; }

        /// <summary>
        /// Gets or Sets IsEnableMaxDuration
        /// </summary>
        [DataMember(Name = "isEnableMaxDuration", EmitDefaultValue = false)]
        public bool IsEnableMaxDuration { get; set; }

        /// <summary>
        /// Gets or Sets MaxDuration
        /// </summary>
        [DataMember(Name = "maxDuration", EmitDefaultValue = false)]
        public int MaxDuration { get; set; }

        /// <summary>
        /// Gets or Sets IsEnableExpirationNotify
        /// </summary>
        [DataMember(Name = "isEnableExpirationNotify", EmitDefaultValue = false)]
        public bool IsEnableExpirationNotify { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationNotifyDurationInterval
        /// </summary>
        [DataMember(Name = "expirationNotifyDurationInterval", EmitDefaultValue = false)]
        public int ExpirationNotifyDurationInterval { get; set; }

        /// <summary>
        /// Gets or Sets IsOnlyUseDefaultDuration
        /// </summary>
        [DataMember(Name = "isOnlyUseDefaultDuration", EmitDefaultValue = false)]
        public bool IsOnlyUseDefaultDuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GrantPermissionServiceDurationSettings {\n");
            sb.Append("  AssignBy: ").Append(AssignBy).Append("\n");
            sb.Append("  IsGrantTemporaryPermission: ").Append(IsGrantTemporaryPermission).Append("\n");
            sb.Append("  DefaultDurationInterval: ").Append(DefaultDurationInterval).Append("\n");
            sb.Append("  DefaultDurationType: ").Append(DefaultDurationType).Append("\n");
            sb.Append("  IsEnableMaxDuration: ").Append(IsEnableMaxDuration).Append("\n");
            sb.Append("  MaxDuration: ").Append(MaxDuration).Append("\n");
            sb.Append("  MaxDurationType: ").Append(MaxDurationType).Append("\n");
            sb.Append("  IsEnableExpirationNotify: ").Append(IsEnableExpirationNotify).Append("\n");
            sb.Append("  ExpirationNotifyDurationInterval: ").Append(ExpirationNotifyDurationInterval).Append("\n");
            sb.Append("  ExpirationNotifyDurationType: ").Append(ExpirationNotifyDurationType).Append("\n");
            sb.Append("  IsOnlyUseDefaultDuration: ").Append(IsOnlyUseDefaultDuration).Append("\n");
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
            return this.Equals(input as GrantPermissionServiceDurationSettings);
        }

        /// <summary>
        /// Returns true if GrantPermissionServiceDurationSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of GrantPermissionServiceDurationSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GrantPermissionServiceDurationSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssignBy == input.AssignBy ||
                    this.AssignBy.Equals(input.AssignBy)
                ) && 
                (
                    this.IsGrantTemporaryPermission == input.IsGrantTemporaryPermission ||
                    this.IsGrantTemporaryPermission.Equals(input.IsGrantTemporaryPermission)
                ) && 
                (
                    this.DefaultDurationInterval == input.DefaultDurationInterval ||
                    (this.DefaultDurationInterval != null &&
                    this.DefaultDurationInterval.Equals(input.DefaultDurationInterval))
                ) && 
                (
                    this.DefaultDurationType == input.DefaultDurationType ||
                    this.DefaultDurationType.Equals(input.DefaultDurationType)
                ) && 
                (
                    this.IsEnableMaxDuration == input.IsEnableMaxDuration ||
                    this.IsEnableMaxDuration.Equals(input.IsEnableMaxDuration)
                ) && 
                (
                    this.MaxDuration == input.MaxDuration ||
                    this.MaxDuration.Equals(input.MaxDuration)
                ) && 
                (
                    this.MaxDurationType == input.MaxDurationType ||
                    this.MaxDurationType.Equals(input.MaxDurationType)
                ) && 
                (
                    this.IsEnableExpirationNotify == input.IsEnableExpirationNotify ||
                    this.IsEnableExpirationNotify.Equals(input.IsEnableExpirationNotify)
                ) && 
                (
                    this.ExpirationNotifyDurationInterval == input.ExpirationNotifyDurationInterval ||
                    this.ExpirationNotifyDurationInterval.Equals(input.ExpirationNotifyDurationInterval)
                ) && 
                (
                    this.ExpirationNotifyDurationType == input.ExpirationNotifyDurationType ||
                    this.ExpirationNotifyDurationType.Equals(input.ExpirationNotifyDurationType)
                ) && 
                (
                    this.IsOnlyUseDefaultDuration == input.IsOnlyUseDefaultDuration ||
                    this.IsOnlyUseDefaultDuration.Equals(input.IsOnlyUseDefaultDuration)
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
                hashCode = hashCode * 59 + this.AssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.IsGrantTemporaryPermission.GetHashCode();
                if (this.DefaultDurationInterval != null)
                    hashCode = hashCode * 59 + this.DefaultDurationInterval.GetHashCode();
                hashCode = hashCode * 59 + this.DefaultDurationType.GetHashCode();
                hashCode = hashCode * 59 + this.IsEnableMaxDuration.GetHashCode();
                hashCode = hashCode * 59 + this.MaxDuration.GetHashCode();
                hashCode = hashCode * 59 + this.MaxDurationType.GetHashCode();
                hashCode = hashCode * 59 + this.IsEnableExpirationNotify.GetHashCode();
                hashCode = hashCode * 59 + this.ExpirationNotifyDurationInterval.GetHashCode();
                hashCode = hashCode * 59 + this.ExpirationNotifyDurationType.GetHashCode();
                hashCode = hashCode * 59 + this.IsOnlyUseDefaultDuration.GetHashCode();
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
