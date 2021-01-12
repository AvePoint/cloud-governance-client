

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
    /// GrantPermissionUrlValidationResult
    /// </summary>
    [DataContract(Name = "GrantPermissionUrlValidationResult")]
    public partial class GrantPermissionUrlValidationResult : IEquatable<GrantPermissionUrlValidationResult>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ExternalSharingOptions
        /// </summary>
        [DataMember(Name = "externalSharingOptions", EmitDefaultValue = false)]
        public ExternalSharingOptions? ExternalSharingOptions { get; set; }
        /// <summary>
        /// Gets or Sets MessageCode
        /// </summary>
        [DataMember(Name = "messageCode", EmitDefaultValue = false)]
        public MessageCode? MessageCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GrantPermissionUrlValidationResult" /> class.
        /// </summary>
        /// <param name="externalSharingOptions">externalSharingOptions.</param>
        /// <param name="enableShareAnnoymousLink">enableShareAnnoymousLink.</param>
        /// <param name="_object">_object.</param>
        /// <param name="spPermissionLevels">spPermissionLevels.</param>
        /// <param name="spGroups">spGroups.</param>
        /// <param name="allowBreakPermissionInheritance">allowBreakPermissionInheritance.</param>
        /// <param name="userMetadata">userMetadata.</param>
        /// <param name="isValid">isValid.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="messageCode">messageCode.</param>
        public GrantPermissionUrlValidationResult(ExternalSharingOptions? externalSharingOptions = default(ExternalSharingOptions?), bool enableShareAnnoymousLink = default(bool), GrantPermissionSPObject _object = default(GrantPermissionSPObject), List<IntModel> spPermissionLevels = default(List<IntModel>), List<GrantPermissionGroup> spGroups = default(List<GrantPermissionGroup>), bool allowBreakPermissionInheritance = default(bool), Dictionary<string, UserInfo> userMetadata = default(Dictionary<string, UserInfo>), bool isValid = default(bool), string errorMessage = default(string), MessageCode? messageCode = default(MessageCode?))
        {
            this.ExternalSharingOptions = externalSharingOptions;
            this.EnableShareAnnoymousLink = enableShareAnnoymousLink;
            this.Object = _object;
            this.SpPermissionLevels = spPermissionLevels;
            this.SpGroups = spGroups;
            this.AllowBreakPermissionInheritance = allowBreakPermissionInheritance;
            this.UserMetadata = userMetadata;
            this.IsValid = isValid;
            this.ErrorMessage = errorMessage;
            this.MessageCode = messageCode;
        }

        /// <summary>
        /// Gets or Sets EnableShareAnnoymousLink
        /// </summary>
        [DataMember(Name = "enableShareAnnoymousLink", EmitDefaultValue = false)]
        public bool EnableShareAnnoymousLink { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", EmitDefaultValue = true)]
        public GrantPermissionSPObject Object { get; set; }

        /// <summary>
        /// Gets or Sets SpPermissionLevels
        /// </summary>
        [DataMember(Name = "spPermissionLevels", EmitDefaultValue = true)]
        public List<IntModel> SpPermissionLevels { get; set; }

        /// <summary>
        /// Gets or Sets SpGroups
        /// </summary>
        [DataMember(Name = "spGroups", EmitDefaultValue = true)]
        public List<GrantPermissionGroup> SpGroups { get; set; }

        /// <summary>
        /// Gets or Sets AllowBreakPermissionInheritance
        /// </summary>
        [DataMember(Name = "allowBreakPermissionInheritance", EmitDefaultValue = false)]
        public bool AllowBreakPermissionInheritance { get; set; }

        /// <summary>
        /// Gets or Sets UserMetadata
        /// </summary>
        [DataMember(Name = "userMetadata", EmitDefaultValue = true)]
        public Dictionary<string, UserInfo> UserMetadata { get; set; }

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
            sb.Append("class GrantPermissionUrlValidationResult {\n");
            sb.Append("  ExternalSharingOptions: ").Append(ExternalSharingOptions).Append("\n");
            sb.Append("  EnableShareAnnoymousLink: ").Append(EnableShareAnnoymousLink).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  SpPermissionLevels: ").Append(SpPermissionLevels).Append("\n");
            sb.Append("  SpGroups: ").Append(SpGroups).Append("\n");
            sb.Append("  AllowBreakPermissionInheritance: ").Append(AllowBreakPermissionInheritance).Append("\n");
            sb.Append("  UserMetadata: ").Append(UserMetadata).Append("\n");
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
            return this.Equals(input as GrantPermissionUrlValidationResult);
        }

        /// <summary>
        /// Returns true if GrantPermissionUrlValidationResult instances are equal
        /// </summary>
        /// <param name="input">Instance of GrantPermissionUrlValidationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GrantPermissionUrlValidationResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExternalSharingOptions == input.ExternalSharingOptions ||
                    this.ExternalSharingOptions.Equals(input.ExternalSharingOptions)
                ) && 
                (
                    this.EnableShareAnnoymousLink == input.EnableShareAnnoymousLink ||
                    this.EnableShareAnnoymousLink.Equals(input.EnableShareAnnoymousLink)
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.SpPermissionLevels == input.SpPermissionLevels ||
                    this.SpPermissionLevels != null &&
                    input.SpPermissionLevels != null &&
                    this.SpPermissionLevels.SequenceEqual(input.SpPermissionLevels)
                ) && 
                (
                    this.SpGroups == input.SpGroups ||
                    this.SpGroups != null &&
                    input.SpGroups != null &&
                    this.SpGroups.SequenceEqual(input.SpGroups)
                ) && 
                (
                    this.AllowBreakPermissionInheritance == input.AllowBreakPermissionInheritance ||
                    this.AllowBreakPermissionInheritance.Equals(input.AllowBreakPermissionInheritance)
                ) && 
                (
                    this.UserMetadata == input.UserMetadata ||
                    this.UserMetadata != null &&
                    input.UserMetadata != null &&
                    this.UserMetadata.SequenceEqual(input.UserMetadata)
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
                hashCode = hashCode * 59 + this.ExternalSharingOptions.GetHashCode();
                hashCode = hashCode * 59 + this.EnableShareAnnoymousLink.GetHashCode();
                if (this.Object != null)
                    hashCode = hashCode * 59 + this.Object.GetHashCode();
                if (this.SpPermissionLevels != null)
                    hashCode = hashCode * 59 + this.SpPermissionLevels.GetHashCode();
                if (this.SpGroups != null)
                    hashCode = hashCode * 59 + this.SpGroups.GetHashCode();
                hashCode = hashCode * 59 + this.AllowBreakPermissionInheritance.GetHashCode();
                if (this.UserMetadata != null)
                    hashCode = hashCode * 59 + this.UserMetadata.GetHashCode();
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
