

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
    /// GroupLifecycleValidateResult
    /// </summary>
    [DataContract(Name = "GroupLifecycleValidateResult")]
    public partial class GroupLifecycleValidateResult : IEquatable<GroupLifecycleValidateResult>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets MessageCode
        /// </summary>
        [DataMember(Name = "messageCode", EmitDefaultValue = false)]
        public MessageCode? MessageCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupLifecycleValidateResult" /> class.
        /// </summary>
        /// <param name="extendSetting">extendSetting.</param>
        /// <param name="changePolicySetting">changePolicySetting.</param>
        /// <param name="changeQuotaSetting">changeQuotaSetting.</param>
        /// <param name="enableTeamCollaboration">enableTeamCollaboration.</param>
        /// <param name="isValid">isValid.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="messageCode">messageCode.</param>
        public GroupLifecycleValidateResult(ExtendGroupResult extendSetting = default(ExtendGroupResult), ChangeGroupPolicyResult changePolicySetting = default(ChangeGroupPolicyResult), ChangeGroupQuotaResult changeQuotaSetting = default(ChangeGroupQuotaResult), bool enableTeamCollaboration = default(bool), bool isValid = default(bool), string errorMessage = default(string), MessageCode? messageCode = default(MessageCode?))
        {
            this.ExtendSetting = extendSetting;
            this.ChangePolicySetting = changePolicySetting;
            this.ChangeQuotaSetting = changeQuotaSetting;
            this.EnableTeamCollaboration = enableTeamCollaboration;
            this.IsValid = isValid;
            this.ErrorMessage = errorMessage;
            this.MessageCode = messageCode;
        }

        /// <summary>
        /// Gets or Sets ExtendSetting
        /// </summary>
        [DataMember(Name = "extendSetting", EmitDefaultValue = false)]
        public ExtendGroupResult ExtendSetting { get; set; }

        /// <summary>
        /// Gets or Sets ChangePolicySetting
        /// </summary>
        [DataMember(Name = "changePolicySetting", EmitDefaultValue = false)]
        public ChangeGroupPolicyResult ChangePolicySetting { get; set; }

        /// <summary>
        /// Gets or Sets ChangeQuotaSetting
        /// </summary>
        [DataMember(Name = "changeQuotaSetting", EmitDefaultValue = false)]
        public ChangeGroupQuotaResult ChangeQuotaSetting { get; set; }

        /// <summary>
        /// Gets or Sets EnableTeamCollaboration
        /// </summary>
        [DataMember(Name = "enableTeamCollaboration", EmitDefaultValue = false)]
        public bool EnableTeamCollaboration { get; set; }

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
            sb.Append("class GroupLifecycleValidateResult {\n");
            sb.Append("  ExtendSetting: ").Append(ExtendSetting).Append("\n");
            sb.Append("  ChangePolicySetting: ").Append(ChangePolicySetting).Append("\n");
            sb.Append("  ChangeQuotaSetting: ").Append(ChangeQuotaSetting).Append("\n");
            sb.Append("  EnableTeamCollaboration: ").Append(EnableTeamCollaboration).Append("\n");
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
            return this.Equals(input as GroupLifecycleValidateResult);
        }

        /// <summary>
        /// Returns true if GroupLifecycleValidateResult instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupLifecycleValidateResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupLifecycleValidateResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExtendSetting == input.ExtendSetting ||
                    (this.ExtendSetting != null &&
                    this.ExtendSetting.Equals(input.ExtendSetting))
                ) && 
                (
                    this.ChangePolicySetting == input.ChangePolicySetting ||
                    (this.ChangePolicySetting != null &&
                    this.ChangePolicySetting.Equals(input.ChangePolicySetting))
                ) && 
                (
                    this.ChangeQuotaSetting == input.ChangeQuotaSetting ||
                    (this.ChangeQuotaSetting != null &&
                    this.ChangeQuotaSetting.Equals(input.ChangeQuotaSetting))
                ) && 
                (
                    this.EnableTeamCollaboration == input.EnableTeamCollaboration ||
                    this.EnableTeamCollaboration.Equals(input.EnableTeamCollaboration)
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
                if (this.ExtendSetting != null)
                    hashCode = hashCode * 59 + this.ExtendSetting.GetHashCode();
                if (this.ChangePolicySetting != null)
                    hashCode = hashCode * 59 + this.ChangePolicySetting.GetHashCode();
                if (this.ChangeQuotaSetting != null)
                    hashCode = hashCode * 59 + this.ChangeQuotaSetting.GetHashCode();
                hashCode = hashCode * 59 + this.EnableTeamCollaboration.GetHashCode();
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
