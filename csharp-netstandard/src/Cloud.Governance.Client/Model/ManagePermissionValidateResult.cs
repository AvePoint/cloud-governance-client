

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
    /// ManagePermissionValidateResult
    /// </summary>
    [DataContract(Name = "ManagePermissionValidateResult")]
    public partial class ManagePermissionValidateResult : IEquatable<ManagePermissionValidateResult>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="ManagePermissionValidateResult" /> class.
        /// </summary>
        /// <param name="permissionLevels">permissionLevels.</param>
        /// <param name="externalSharingOptions">externalSharingOptions.</param>
        /// <param name="enableShareAnonymousLink">enableShareAnonymousLink.</param>
        /// <param name="_object">_object.</param>
        /// <param name="userMetadata">userMetadata.</param>
        /// <param name="isValid">isValid.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="messageCode">messageCode.</param>
        public ManagePermissionValidateResult(List<PermissionLevel> permissionLevels = default(List<PermissionLevel>), ExternalSharingOptions? externalSharingOptions = default(ExternalSharingOptions?), bool enableShareAnonymousLink = default(bool), ManagePermissionSPObject _object = default(ManagePermissionSPObject), Dictionary<string, UserInfo> userMetadata = default(Dictionary<string, UserInfo>), bool isValid = default(bool), string errorMessage = default(string), MessageCode? messageCode = default(MessageCode?))
        {
            this.PermissionLevels = permissionLevels;
            this.ExternalSharingOptions = externalSharingOptions;
            this.EnableShareAnonymousLink = enableShareAnonymousLink;
            this.Object = _object;
            this.UserMetadata = userMetadata;
            this.IsValid = isValid;
            this.ErrorMessage = errorMessage;
            this.MessageCode = messageCode;
        }

        /// <summary>
        /// Gets or Sets PermissionLevels
        /// </summary>
        [DataMember(Name = "permissionLevels", EmitDefaultValue = true)]
        public List<PermissionLevel> PermissionLevels { get; set; }

        /// <summary>
        /// Gets or Sets EnableShareAnonymousLink
        /// </summary>
        [DataMember(Name = "enableShareAnonymousLink", EmitDefaultValue = false)]
        public bool EnableShareAnonymousLink { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", EmitDefaultValue = true)]
        public ManagePermissionSPObject Object { get; set; }

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
            sb.Append("class ManagePermissionValidateResult {\n");
            sb.Append("  PermissionLevels: ").Append(PermissionLevels).Append("\n");
            sb.Append("  ExternalSharingOptions: ").Append(ExternalSharingOptions).Append("\n");
            sb.Append("  EnableShareAnonymousLink: ").Append(EnableShareAnonymousLink).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
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
            return this.Equals(input as ManagePermissionValidateResult);
        }

        /// <summary>
        /// Returns true if ManagePermissionValidateResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ManagePermissionValidateResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManagePermissionValidateResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PermissionLevels == input.PermissionLevels ||
                    this.PermissionLevels != null &&
                    input.PermissionLevels != null &&
                    this.PermissionLevels.SequenceEqual(input.PermissionLevels)
                ) && 
                (
                    this.ExternalSharingOptions == input.ExternalSharingOptions ||
                    this.ExternalSharingOptions.Equals(input.ExternalSharingOptions)
                ) && 
                (
                    this.EnableShareAnonymousLink == input.EnableShareAnonymousLink ||
                    this.EnableShareAnonymousLink.Equals(input.EnableShareAnonymousLink)
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
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
                if (this.PermissionLevels != null)
                    hashCode = hashCode * 59 + this.PermissionLevels.GetHashCode();
                hashCode = hashCode * 59 + this.ExternalSharingOptions.GetHashCode();
                hashCode = hashCode * 59 + this.EnableShareAnonymousLink.GetHashCode();
                if (this.Object != null)
                    hashCode = hashCode * 59 + this.Object.GetHashCode();
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
