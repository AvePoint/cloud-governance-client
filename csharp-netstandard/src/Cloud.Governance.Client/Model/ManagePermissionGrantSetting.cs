

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
    /// ManagePermissionGrantSetting
    /// </summary>
    [DataContract(Name = "ManagePermissionGrantSetting")]
    public partial class ManagePermissionGrantSetting : IEquatable<ManagePermissionGrantSetting>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets GrantPermissionAssignBy
        /// </summary>
        [DataMember(Name = "grantPermissionAssignBy", EmitDefaultValue = false)]
        public AssignBy? GrantPermissionAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets TemporaryDurationType
        /// </summary>
        [DataMember(Name = "temporaryDurationType", EmitDefaultValue = false)]
        public ApiDurationType? TemporaryDurationType { get; set; }
        /// <summary>
        /// Gets or Sets TemporaryPermissionMaxDurationType
        /// </summary>
        [DataMember(Name = "temporaryPermissionMaxDurationType", EmitDefaultValue = false)]
        public ApiDurationType? TemporaryPermissionMaxDurationType { get; set; }
        /// <summary>
        /// Gets or Sets ExpireNotifyDurationType
        /// </summary>
        [DataMember(Name = "expireNotifyDurationType", EmitDefaultValue = false)]
        public ApiDurationType? ExpireNotifyDurationType { get; set; }
        /// <summary>
        /// Gets or Sets WelcomeEmailAssignBy
        /// </summary>
        [DataMember(Name = "welcomeEmailAssignBy", EmitDefaultValue = false)]
        public AssignBy? WelcomeEmailAssignBy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagePermissionGrantSetting" /> class.
        /// </summary>
        /// <param name="isEnableGrantPermission">isEnableGrantPermission.</param>
        /// <param name="isGrantTemporaryPermission">isGrantTemporaryPermission.</param>
        /// <param name="grantPermissionAssignBy">grantPermissionAssignBy.</param>
        /// <param name="temporaryPermissionDuration">temporaryPermissionDuration.</param>
        /// <param name="temporaryDurationType">temporaryDurationType.</param>
        /// <param name="isMaxTemporaryDurationSetted">isMaxTemporaryDurationSetted.</param>
        /// <param name="temporaryPermissionMaxDuration">temporaryPermissionMaxDuration.</param>
        /// <param name="temporaryPermissionMaxDurationType">temporaryPermissionMaxDurationType.</param>
        /// <param name="isEnableExpireNotify">isEnableExpireNotify.</param>
        /// <param name="isAllowSelectAdmin">isAllowSelectAdmin.</param>
        /// <param name="expireNotifyDuration">expireNotifyDuration.</param>
        /// <param name="expireNotifyDurationType">expireNotifyDurationType.</param>
        /// <param name="expireNotifyEmailTemplate">expireNotifyEmailTemplate.</param>
        /// <param name="isEnableWelcomeNotify">isEnableWelcomeNotify.</param>
        /// <param name="welcomeEmailSubject">welcomeEmailSubject.</param>
        /// <param name="welcomeEmailBody">welcomeEmailBody.</param>
        /// <param name="welcomeEmailAssignBy">welcomeEmailAssignBy.</param>
        /// <param name="allowSpecifyTemporayPermissionDuration">allowSpecifyTemporayPermissionDuration.</param>
        public ManagePermissionGrantSetting(bool isEnableGrantPermission = default(bool), bool isGrantTemporaryPermission = default(bool), AssignBy? grantPermissionAssignBy = default(AssignBy?), int temporaryPermissionDuration = default(int), ApiDurationType? temporaryDurationType = default(ApiDurationType?), bool isMaxTemporaryDurationSetted = default(bool), int temporaryPermissionMaxDuration = default(int), ApiDurationType? temporaryPermissionMaxDurationType = default(ApiDurationType?), bool isEnableExpireNotify = default(bool), bool isAllowSelectAdmin = default(bool), int expireNotifyDuration = default(int), ApiDurationType? expireNotifyDurationType = default(ApiDurationType?), Guid? expireNotifyEmailTemplate = default(Guid?), bool isEnableWelcomeNotify = default(bool), string welcomeEmailSubject = default(string), string welcomeEmailBody = default(string), AssignBy? welcomeEmailAssignBy = default(AssignBy?), bool allowSpecifyTemporayPermissionDuration = default(bool))
        {
            this.IsEnableGrantPermission = isEnableGrantPermission;
            this.IsGrantTemporaryPermission = isGrantTemporaryPermission;
            this.GrantPermissionAssignBy = grantPermissionAssignBy;
            this.TemporaryPermissionDuration = temporaryPermissionDuration;
            this.TemporaryDurationType = temporaryDurationType;
            this.IsMaxTemporaryDurationSetted = isMaxTemporaryDurationSetted;
            this.TemporaryPermissionMaxDuration = temporaryPermissionMaxDuration;
            this.TemporaryPermissionMaxDurationType = temporaryPermissionMaxDurationType;
            this.IsEnableExpireNotify = isEnableExpireNotify;
            this.IsAllowSelectAdmin = isAllowSelectAdmin;
            this.ExpireNotifyDuration = expireNotifyDuration;
            this.ExpireNotifyDurationType = expireNotifyDurationType;
            this.ExpireNotifyEmailTemplate = expireNotifyEmailTemplate;
            this.IsEnableWelcomeNotify = isEnableWelcomeNotify;
            this.WelcomeEmailSubject = welcomeEmailSubject;
            this.WelcomeEmailBody = welcomeEmailBody;
            this.WelcomeEmailAssignBy = welcomeEmailAssignBy;
            this.AllowSpecifyTemporayPermissionDuration = allowSpecifyTemporayPermissionDuration;
        }

        /// <summary>
        /// Gets or Sets IsEnableGrantPermission
        /// </summary>
        [DataMember(Name = "isEnableGrantPermission", EmitDefaultValue = false)]
        public bool IsEnableGrantPermission { get; set; }

        /// <summary>
        /// Gets or Sets IsGrantTemporaryPermission
        /// </summary>
        [DataMember(Name = "isGrantTemporaryPermission", EmitDefaultValue = false)]
        public bool IsGrantTemporaryPermission { get; set; }

        /// <summary>
        /// Gets or Sets TemporaryPermissionDuration
        /// </summary>
        [DataMember(Name = "temporaryPermissionDuration", EmitDefaultValue = false)]
        public int TemporaryPermissionDuration { get; set; }

        /// <summary>
        /// Gets or Sets IsMaxTemporaryDurationSetted
        /// </summary>
        [DataMember(Name = "isMaxTemporaryDurationSetted", EmitDefaultValue = false)]
        public bool IsMaxTemporaryDurationSetted { get; set; }

        /// <summary>
        /// Gets or Sets TemporaryPermissionMaxDuration
        /// </summary>
        [DataMember(Name = "temporaryPermissionMaxDuration", EmitDefaultValue = false)]
        public int TemporaryPermissionMaxDuration { get; set; }

        /// <summary>
        /// Gets or Sets IsEnableExpireNotify
        /// </summary>
        [DataMember(Name = "isEnableExpireNotify", EmitDefaultValue = false)]
        public bool IsEnableExpireNotify { get; set; }

        /// <summary>
        /// Gets or Sets IsAllowSelectAdmin
        /// </summary>
        [DataMember(Name = "isAllowSelectAdmin", EmitDefaultValue = false)]
        public bool IsAllowSelectAdmin { get; set; }

        /// <summary>
        /// Gets or Sets ExpireNotifyDuration
        /// </summary>
        [DataMember(Name = "expireNotifyDuration", EmitDefaultValue = false)]
        public int ExpireNotifyDuration { get; set; }

        /// <summary>
        /// Gets or Sets ExpireNotifyEmailTemplate
        /// </summary>
        [DataMember(Name = "expireNotifyEmailTemplate", EmitDefaultValue = true)]
        public Guid? ExpireNotifyEmailTemplate { get; set; }

        /// <summary>
        /// Gets or Sets IsEnableWelcomeNotify
        /// </summary>
        [DataMember(Name = "isEnableWelcomeNotify", EmitDefaultValue = false)]
        public bool IsEnableWelcomeNotify { get; set; }

        /// <summary>
        /// Gets or Sets WelcomeEmailSubject
        /// </summary>
        [DataMember(Name = "welcomeEmailSubject", EmitDefaultValue = true)]
        public string WelcomeEmailSubject { get; set; }

        /// <summary>
        /// Gets or Sets WelcomeEmailBody
        /// </summary>
        [DataMember(Name = "welcomeEmailBody", EmitDefaultValue = true)]
        public string WelcomeEmailBody { get; set; }

        /// <summary>
        /// Gets or Sets AllowSpecifyTemporayPermissionDuration
        /// </summary>
        [DataMember(Name = "allowSpecifyTemporayPermissionDuration", EmitDefaultValue = false)]
        public bool AllowSpecifyTemporayPermissionDuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManagePermissionGrantSetting {\n");
            sb.Append("  IsEnableGrantPermission: ").Append(IsEnableGrantPermission).Append("\n");
            sb.Append("  IsGrantTemporaryPermission: ").Append(IsGrantTemporaryPermission).Append("\n");
            sb.Append("  GrantPermissionAssignBy: ").Append(GrantPermissionAssignBy).Append("\n");
            sb.Append("  TemporaryPermissionDuration: ").Append(TemporaryPermissionDuration).Append("\n");
            sb.Append("  TemporaryDurationType: ").Append(TemporaryDurationType).Append("\n");
            sb.Append("  IsMaxTemporaryDurationSetted: ").Append(IsMaxTemporaryDurationSetted).Append("\n");
            sb.Append("  TemporaryPermissionMaxDuration: ").Append(TemporaryPermissionMaxDuration).Append("\n");
            sb.Append("  TemporaryPermissionMaxDurationType: ").Append(TemporaryPermissionMaxDurationType).Append("\n");
            sb.Append("  IsEnableExpireNotify: ").Append(IsEnableExpireNotify).Append("\n");
            sb.Append("  IsAllowSelectAdmin: ").Append(IsAllowSelectAdmin).Append("\n");
            sb.Append("  ExpireNotifyDuration: ").Append(ExpireNotifyDuration).Append("\n");
            sb.Append("  ExpireNotifyDurationType: ").Append(ExpireNotifyDurationType).Append("\n");
            sb.Append("  ExpireNotifyEmailTemplate: ").Append(ExpireNotifyEmailTemplate).Append("\n");
            sb.Append("  IsEnableWelcomeNotify: ").Append(IsEnableWelcomeNotify).Append("\n");
            sb.Append("  WelcomeEmailSubject: ").Append(WelcomeEmailSubject).Append("\n");
            sb.Append("  WelcomeEmailBody: ").Append(WelcomeEmailBody).Append("\n");
            sb.Append("  WelcomeEmailAssignBy: ").Append(WelcomeEmailAssignBy).Append("\n");
            sb.Append("  AllowSpecifyTemporayPermissionDuration: ").Append(AllowSpecifyTemporayPermissionDuration).Append("\n");
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
            return this.Equals(input as ManagePermissionGrantSetting);
        }

        /// <summary>
        /// Returns true if ManagePermissionGrantSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of ManagePermissionGrantSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManagePermissionGrantSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsEnableGrantPermission == input.IsEnableGrantPermission ||
                    this.IsEnableGrantPermission.Equals(input.IsEnableGrantPermission)
                ) && 
                (
                    this.IsGrantTemporaryPermission == input.IsGrantTemporaryPermission ||
                    this.IsGrantTemporaryPermission.Equals(input.IsGrantTemporaryPermission)
                ) && 
                (
                    this.GrantPermissionAssignBy == input.GrantPermissionAssignBy ||
                    this.GrantPermissionAssignBy.Equals(input.GrantPermissionAssignBy)
                ) && 
                (
                    this.TemporaryPermissionDuration == input.TemporaryPermissionDuration ||
                    this.TemporaryPermissionDuration.Equals(input.TemporaryPermissionDuration)
                ) && 
                (
                    this.TemporaryDurationType == input.TemporaryDurationType ||
                    this.TemporaryDurationType.Equals(input.TemporaryDurationType)
                ) && 
                (
                    this.IsMaxTemporaryDurationSetted == input.IsMaxTemporaryDurationSetted ||
                    this.IsMaxTemporaryDurationSetted.Equals(input.IsMaxTemporaryDurationSetted)
                ) && 
                (
                    this.TemporaryPermissionMaxDuration == input.TemporaryPermissionMaxDuration ||
                    this.TemporaryPermissionMaxDuration.Equals(input.TemporaryPermissionMaxDuration)
                ) && 
                (
                    this.TemporaryPermissionMaxDurationType == input.TemporaryPermissionMaxDurationType ||
                    this.TemporaryPermissionMaxDurationType.Equals(input.TemporaryPermissionMaxDurationType)
                ) && 
                (
                    this.IsEnableExpireNotify == input.IsEnableExpireNotify ||
                    this.IsEnableExpireNotify.Equals(input.IsEnableExpireNotify)
                ) && 
                (
                    this.IsAllowSelectAdmin == input.IsAllowSelectAdmin ||
                    this.IsAllowSelectAdmin.Equals(input.IsAllowSelectAdmin)
                ) && 
                (
                    this.ExpireNotifyDuration == input.ExpireNotifyDuration ||
                    this.ExpireNotifyDuration.Equals(input.ExpireNotifyDuration)
                ) && 
                (
                    this.ExpireNotifyDurationType == input.ExpireNotifyDurationType ||
                    this.ExpireNotifyDurationType.Equals(input.ExpireNotifyDurationType)
                ) && 
                (
                    this.ExpireNotifyEmailTemplate == input.ExpireNotifyEmailTemplate ||
                    (this.ExpireNotifyEmailTemplate != null &&
                    this.ExpireNotifyEmailTemplate.Equals(input.ExpireNotifyEmailTemplate))
                ) && 
                (
                    this.IsEnableWelcomeNotify == input.IsEnableWelcomeNotify ||
                    this.IsEnableWelcomeNotify.Equals(input.IsEnableWelcomeNotify)
                ) && 
                (
                    this.WelcomeEmailSubject == input.WelcomeEmailSubject ||
                    (this.WelcomeEmailSubject != null &&
                    this.WelcomeEmailSubject.Equals(input.WelcomeEmailSubject))
                ) && 
                (
                    this.WelcomeEmailBody == input.WelcomeEmailBody ||
                    (this.WelcomeEmailBody != null &&
                    this.WelcomeEmailBody.Equals(input.WelcomeEmailBody))
                ) && 
                (
                    this.WelcomeEmailAssignBy == input.WelcomeEmailAssignBy ||
                    this.WelcomeEmailAssignBy.Equals(input.WelcomeEmailAssignBy)
                ) && 
                (
                    this.AllowSpecifyTemporayPermissionDuration == input.AllowSpecifyTemporayPermissionDuration ||
                    this.AllowSpecifyTemporayPermissionDuration.Equals(input.AllowSpecifyTemporayPermissionDuration)
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
                hashCode = hashCode * 59 + this.IsEnableGrantPermission.GetHashCode();
                hashCode = hashCode * 59 + this.IsGrantTemporaryPermission.GetHashCode();
                hashCode = hashCode * 59 + this.GrantPermissionAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.TemporaryPermissionDuration.GetHashCode();
                hashCode = hashCode * 59 + this.TemporaryDurationType.GetHashCode();
                hashCode = hashCode * 59 + this.IsMaxTemporaryDurationSetted.GetHashCode();
                hashCode = hashCode * 59 + this.TemporaryPermissionMaxDuration.GetHashCode();
                hashCode = hashCode * 59 + this.TemporaryPermissionMaxDurationType.GetHashCode();
                hashCode = hashCode * 59 + this.IsEnableExpireNotify.GetHashCode();
                hashCode = hashCode * 59 + this.IsAllowSelectAdmin.GetHashCode();
                hashCode = hashCode * 59 + this.ExpireNotifyDuration.GetHashCode();
                hashCode = hashCode * 59 + this.ExpireNotifyDurationType.GetHashCode();
                if (this.ExpireNotifyEmailTemplate != null)
                    hashCode = hashCode * 59 + this.ExpireNotifyEmailTemplate.GetHashCode();
                hashCode = hashCode * 59 + this.IsEnableWelcomeNotify.GetHashCode();
                if (this.WelcomeEmailSubject != null)
                    hashCode = hashCode * 59 + this.WelcomeEmailSubject.GetHashCode();
                if (this.WelcomeEmailBody != null)
                    hashCode = hashCode * 59 + this.WelcomeEmailBody.GetHashCode();
                hashCode = hashCode * 59 + this.WelcomeEmailAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.AllowSpecifyTemporayPermissionDuration.GetHashCode();
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
