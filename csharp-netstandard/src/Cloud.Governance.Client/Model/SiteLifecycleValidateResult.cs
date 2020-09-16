

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
    /// SiteLifecycleValidateResult
    /// </summary>
    [DataContract(Name = "SiteLifecycleValidateResult")]
    public partial class SiteLifecycleValidateResult : IEquatable<SiteLifecycleValidateResult>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets MessageCode
        /// </summary>
        [DataMember(Name = "messageCode", EmitDefaultValue = false)]
        public MessageCode? MessageCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SiteLifecycleValidateResult" /> class.
        /// </summary>
        /// <param name="siteId">siteId.</param>
        /// <param name="siteUrl">siteUrl.</param>
        /// <param name="changeQuotaSetting">changeQuotaSetting.</param>
        /// <param name="extendSetting">extendSetting.</param>
        /// <param name="unlockSetting">unlockSetting.</param>
        /// <param name="changePolicySetting">changePolicySetting.</param>
        /// <param name="lockSetting">lockSetting.</param>
        /// <param name="isValid">isValid.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="messageCode">messageCode.</param>
        public SiteLifecycleValidateResult(Guid siteId = default(Guid), string siteUrl = default(string), ChangeSiteQuotaSettings changeQuotaSetting = default(ChangeSiteQuotaSettings), ExtendSiteSetting extendSetting = default(ExtendSiteSetting), UnlockSiteSetting unlockSetting = default(UnlockSiteSetting), ChangeSitePolicySetting changePolicySetting = default(ChangeSitePolicySetting), LockSiteSetting lockSetting = default(LockSiteSetting), bool isValid = default(bool), string errorMessage = default(string), MessageCode? messageCode = default(MessageCode?))
        {
            this.SiteId = siteId;
            this.SiteUrl = siteUrl;
            this.ChangeQuotaSetting = changeQuotaSetting;
            this.ExtendSetting = extendSetting;
            this.UnlockSetting = unlockSetting;
            this.ChangePolicySetting = changePolicySetting;
            this.LockSetting = lockSetting;
            this.IsValid = isValid;
            this.ErrorMessage = errorMessage;
            this.MessageCode = messageCode;
        }

        /// <summary>
        /// Gets or Sets SiteId
        /// </summary>
        [DataMember(Name = "siteId", EmitDefaultValue = false)]
        public Guid SiteId { get; set; }

        /// <summary>
        /// Gets or Sets SiteUrl
        /// </summary>
        [DataMember(Name = "siteUrl", EmitDefaultValue = true)]
        public string SiteUrl { get; set; }

        /// <summary>
        /// Gets or Sets ChangeQuotaSetting
        /// </summary>
        [DataMember(Name = "changeQuotaSetting", EmitDefaultValue = false)]
        public ChangeSiteQuotaSettings ChangeQuotaSetting { get; set; }

        /// <summary>
        /// Gets or Sets ExtendSetting
        /// </summary>
        [DataMember(Name = "extendSetting", EmitDefaultValue = false)]
        public ExtendSiteSetting ExtendSetting { get; set; }

        /// <summary>
        /// Gets or Sets UnlockSetting
        /// </summary>
        [DataMember(Name = "unlockSetting", EmitDefaultValue = false)]
        public UnlockSiteSetting UnlockSetting { get; set; }

        /// <summary>
        /// Gets or Sets ChangePolicySetting
        /// </summary>
        [DataMember(Name = "changePolicySetting", EmitDefaultValue = false)]
        public ChangeSitePolicySetting ChangePolicySetting { get; set; }

        /// <summary>
        /// Gets or Sets LockSetting
        /// </summary>
        [DataMember(Name = "lockSetting", EmitDefaultValue = false)]
        public LockSiteSetting LockSetting { get; set; }

        /// <summary>
        /// Gets or Sets IsValid
        /// </summary>
        [DataMember(Name = "isValid", EmitDefaultValue = false)]
        public bool IsValid { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name = "errorMessage", EmitDefaultValue = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SiteLifecycleValidateResult {\n");
            sb.Append("  SiteId: ").Append(SiteId).Append("\n");
            sb.Append("  SiteUrl: ").Append(SiteUrl).Append("\n");
            sb.Append("  ChangeQuotaSetting: ").Append(ChangeQuotaSetting).Append("\n");
            sb.Append("  ExtendSetting: ").Append(ExtendSetting).Append("\n");
            sb.Append("  UnlockSetting: ").Append(UnlockSetting).Append("\n");
            sb.Append("  ChangePolicySetting: ").Append(ChangePolicySetting).Append("\n");
            sb.Append("  LockSetting: ").Append(LockSetting).Append("\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  MessageCode: ").Append(MessageCode).Append("\n");
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
            return this.Equals(input as SiteLifecycleValidateResult);
        }

        /// <summary>
        /// Returns true if SiteLifecycleValidateResult instances are equal
        /// </summary>
        /// <param name="input">Instance of SiteLifecycleValidateResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SiteLifecycleValidateResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SiteId == input.SiteId ||
                    (this.SiteId != null &&
                    this.SiteId.Equals(input.SiteId))
                ) && 
                (
                    this.SiteUrl == input.SiteUrl ||
                    (this.SiteUrl != null &&
                    this.SiteUrl.Equals(input.SiteUrl))
                ) && 
                (
                    this.ChangeQuotaSetting == input.ChangeQuotaSetting ||
                    (this.ChangeQuotaSetting != null &&
                    this.ChangeQuotaSetting.Equals(input.ChangeQuotaSetting))
                ) && 
                (
                    this.ExtendSetting == input.ExtendSetting ||
                    (this.ExtendSetting != null &&
                    this.ExtendSetting.Equals(input.ExtendSetting))
                ) && 
                (
                    this.UnlockSetting == input.UnlockSetting ||
                    (this.UnlockSetting != null &&
                    this.UnlockSetting.Equals(input.UnlockSetting))
                ) && 
                (
                    this.ChangePolicySetting == input.ChangePolicySetting ||
                    (this.ChangePolicySetting != null &&
                    this.ChangePolicySetting.Equals(input.ChangePolicySetting))
                ) && 
                (
                    this.LockSetting == input.LockSetting ||
                    (this.LockSetting != null &&
                    this.LockSetting.Equals(input.LockSetting))
                ) && 
                (
                    this.IsValid == input.IsValid ||
                    this.IsValid.Equals(input.IsValid)
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.MessageCode == input.MessageCode ||
                    this.MessageCode.Equals(input.MessageCode)
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
                if (this.SiteId != null)
                    hashCode = hashCode * 59 + this.SiteId.GetHashCode();
                if (this.SiteUrl != null)
                    hashCode = hashCode * 59 + this.SiteUrl.GetHashCode();
                if (this.ChangeQuotaSetting != null)
                    hashCode = hashCode * 59 + this.ChangeQuotaSetting.GetHashCode();
                if (this.ExtendSetting != null)
                    hashCode = hashCode * 59 + this.ExtendSetting.GetHashCode();
                if (this.UnlockSetting != null)
                    hashCode = hashCode * 59 + this.UnlockSetting.GetHashCode();
                if (this.ChangePolicySetting != null)
                    hashCode = hashCode * 59 + this.ChangePolicySetting.GetHashCode();
                if (this.LockSetting != null)
                    hashCode = hashCode * 59 + this.LockSetting.GetHashCode();
                hashCode = hashCode * 59 + this.IsValid.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                hashCode = hashCode * 59 + this.MessageCode.GetHashCode();
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
