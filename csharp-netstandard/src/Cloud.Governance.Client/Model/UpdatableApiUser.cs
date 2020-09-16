

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
    /// UpdatableApiUser
    /// </summary>
    [DataContract(Name = "UpdatableApiUser")]
    public partial class UpdatableApiUser : IEquatable<UpdatableApiUser>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets IsExternalUser
        /// </summary>
        [DataMember(Name = "isExternalUser", EmitDefaultValue = false)]
        public ExternalUserType? IsExternalUser { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatableApiUser" /> class.
        /// </summary>
        /// <param name="email">email.</param>
        /// <param name="jobTitle">jobTitle.</param>
        /// <param name="id">id.</param>
        /// <param name="loginName">loginName.</param>
        /// <param name="isExternalUser">isExternalUser.</param>
        /// <param name="azureUserType">azureUserType.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="isGroup">isGroup.</param>
        /// <param name="isLocalUser">isLocalUser.</param>
        public UpdatableApiUser(string email = default(string), string jobTitle = default(string), string id = default(string), string loginName = default(string), ExternalUserType? isExternalUser = default(ExternalUserType?), string azureUserType = default(string), string displayName = default(string), bool isGroup = default(bool), bool isLocalUser = default(bool))
        {
            this.Email = email;
            this.JobTitle = jobTitle;
            this.Id = id;
            this.LoginName = loginName;
            this.IsExternalUser = isExternalUser;
            this.AzureUserType = azureUserType;
            this.DisplayName = displayName;
            this.IsGroup = isGroup;
            this.IsLocalUser = isLocalUser;
        }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets JobTitle
        /// </summary>
        [DataMember(Name = "jobTitle", EmitDefaultValue = true)]
        public string JobTitle { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets LoginName
        /// </summary>
        [DataMember(Name = "loginName", EmitDefaultValue = true)]
        public string LoginName { get; set; }

        /// <summary>
        /// Gets or Sets AzureUserType
        /// </summary>
        [DataMember(Name = "azureUserType", EmitDefaultValue = true)]
        public string AzureUserType { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets IsGroup
        /// </summary>
        [DataMember(Name = "isGroup", EmitDefaultValue = false)]
        public bool IsGroup { get; set; }

        /// <summary>
        /// Gets or Sets IsLocalUser
        /// </summary>
        [DataMember(Name = "isLocalUser", EmitDefaultValue = false)]
        public bool IsLocalUser { get; set; }

        /// <summary>
        /// Gets or Sets PhysicalDeliveryOfficeName
        /// </summary>
        [DataMember(Name = "physicalDeliveryOfficeName", EmitDefaultValue = true)]
        public string PhysicalDeliveryOfficeName { get; private set; }

        /// <summary>
        /// Gets or Sets IsOtherTenantUser
        /// </summary>
        [DataMember(Name = "isOtherTenantUser", EmitDefaultValue = false)]
        public bool IsOtherTenantUser { get; private set; }

        /// <summary>
        /// Gets or Sets IsValid
        /// </summary>
        [DataMember(Name = "isValid", EmitDefaultValue = false)]
        public bool IsValid { get; private set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatableApiUser {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  JobTitle: ").Append(JobTitle).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LoginName: ").Append(LoginName).Append("\n");
            sb.Append("  IsExternalUser: ").Append(IsExternalUser).Append("\n");
            sb.Append("  AzureUserType: ").Append(AzureUserType).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  IsGroup: ").Append(IsGroup).Append("\n");
            sb.Append("  IsLocalUser: ").Append(IsLocalUser).Append("\n");
            sb.Append("  PhysicalDeliveryOfficeName: ").Append(PhysicalDeliveryOfficeName).Append("\n");
            sb.Append("  IsOtherTenantUser: ").Append(IsOtherTenantUser).Append("\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
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
            return this.Equals(input as UpdatableApiUser);
        }

        /// <summary>
        /// Returns true if UpdatableApiUser instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdatableApiUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatableApiUser input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.JobTitle == input.JobTitle ||
                    (this.JobTitle != null &&
                    this.JobTitle.Equals(input.JobTitle))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LoginName == input.LoginName ||
                    (this.LoginName != null &&
                    this.LoginName.Equals(input.LoginName))
                ) && 
                (
                    this.IsExternalUser == input.IsExternalUser ||
                    this.IsExternalUser.Equals(input.IsExternalUser)
                ) && 
                (
                    this.AzureUserType == input.AzureUserType ||
                    (this.AzureUserType != null &&
                    this.AzureUserType.Equals(input.AzureUserType))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.IsGroup == input.IsGroup ||
                    this.IsGroup.Equals(input.IsGroup)
                ) && 
                (
                    this.IsLocalUser == input.IsLocalUser ||
                    this.IsLocalUser.Equals(input.IsLocalUser)
                ) && 
                (
                    this.PhysicalDeliveryOfficeName == input.PhysicalDeliveryOfficeName ||
                    (this.PhysicalDeliveryOfficeName != null &&
                    this.PhysicalDeliveryOfficeName.Equals(input.PhysicalDeliveryOfficeName))
                ) && 
                (
                    this.IsOtherTenantUser == input.IsOtherTenantUser ||
                    this.IsOtherTenantUser.Equals(input.IsOtherTenantUser)
                ) && 
                (
                    this.IsValid == input.IsValid ||
                    this.IsValid.Equals(input.IsValid)
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.JobTitle != null)
                    hashCode = hashCode * 59 + this.JobTitle.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LoginName != null)
                    hashCode = hashCode * 59 + this.LoginName.GetHashCode();
                hashCode = hashCode * 59 + this.IsExternalUser.GetHashCode();
                if (this.AzureUserType != null)
                    hashCode = hashCode * 59 + this.AzureUserType.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                hashCode = hashCode * 59 + this.IsGroup.GetHashCode();
                hashCode = hashCode * 59 + this.IsLocalUser.GetHashCode();
                if (this.PhysicalDeliveryOfficeName != null)
                    hashCode = hashCode * 59 + this.PhysicalDeliveryOfficeName.GetHashCode();
                hashCode = hashCode * 59 + this.IsOtherTenantUser.GetHashCode();
                hashCode = hashCode * 59 + this.IsValid.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
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
