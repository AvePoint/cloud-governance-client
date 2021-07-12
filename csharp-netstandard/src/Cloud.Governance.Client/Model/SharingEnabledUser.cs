

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
    /// SharingEnabledUser
    /// </summary>
    [DataContract(Name = "SharingEnabledUser")]
    public partial class SharingEnabledUser : IEquatable<SharingEnabledUser>, IValidatableObject
    {
        /// <summary>
        /// Whether the user is an external user.
        /// </summary>
        /// <value>Whether the user is an external user.</value>
        [DataMember(Name = "isExternalUser", EmitDefaultValue = false)]
        public ExternalUserType? IsExternalUser { get; set; }
        /// <summary>
        /// ApiUser type
        /// </summary>
        /// <value>ApiUser type</value>
        [DataMember(Name = "apiUserType", EmitDefaultValue = false)]
        public ApiUserType? ApiUserType { get; set; }

        /// <summary>
        /// Returns false as ApiUserType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeApiUserType()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="SharingEnabledUser" /> class.
        /// </summary>
        /// <param name="isSharePointGroup">isSharePointGroup (default to false).</param>
        /// <param name="isGuestUser">isGuestUser (default to false).</param>
        /// <param name="isGuestUserExistsInOrganization">isGuestUserExistsInOrganization (default to false).</param>
        /// <param name="id">Object ID.</param>
        /// <param name="loginName">Login name.</param>
        /// <param name="isExternalUser">Whether the user is an external user..</param>
        /// <param name="azureUserType">User type in Azure AD.</param>
        /// <param name="displayName">User display name.</param>
        /// <param name="isGroup">Whether an object is a domain group. (default to false).</param>
        /// <param name="email">User e-mail address.</param>
        public SharingEnabledUser(bool isSharePointGroup = false, bool isGuestUser = false, bool isGuestUserExistsInOrganization = false, string id = default(string), string loginName = default(string), ExternalUserType? isExternalUser = default(ExternalUserType?), string azureUserType = default(string), string displayName = default(string), bool isGroup = false, string email = default(string))
        {
            this.IsSharePointGroup = isSharePointGroup;
            this.IsGuestUser = isGuestUser;
            this.IsGuestUserExistsInOrganization = isGuestUserExistsInOrganization;
            this.Id = id;
            this.LoginName = loginName;
            this.IsExternalUser = isExternalUser;
            this.AzureUserType = azureUserType;
            this.DisplayName = displayName;
            this.IsGroup = isGroup;
            this.Email = email;
        }

        /// <summary>
        /// Gets or Sets IsSharePointGroup
        /// </summary>
        [DataMember(Name = "isSharePointGroup", EmitDefaultValue = false)]
        public bool IsSharePointGroup { get; set; }

        /// <summary>
        /// Gets or Sets IsGuestUser
        /// </summary>
        [DataMember(Name = "isGuestUser", EmitDefaultValue = false)]
        public bool IsGuestUser { get; set; }

        /// <summary>
        /// Gets or Sets IsGuestUserExistsInOrganization
        /// </summary>
        [DataMember(Name = "isGuestUserExistsInOrganization", EmitDefaultValue = false)]
        public bool IsGuestUserExistsInOrganization { get; set; }

        /// <summary>
        /// Object ID
        /// </summary>
        /// <value>Object ID</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Login name
        /// </summary>
        /// <value>Login name</value>
        [DataMember(Name = "loginName", EmitDefaultValue = true)]
        public string LoginName { get; set; }

        /// <summary>
        /// User type in Azure AD
        /// </summary>
        /// <value>User type in Azure AD</value>
        [DataMember(Name = "azureUserType", EmitDefaultValue = true)]
        public string AzureUserType { get; set; }

        /// <summary>
        /// User display name
        /// </summary>
        /// <value>User display name</value>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Whether an object is a domain group.
        /// </summary>
        /// <value>Whether an object is a domain group.</value>
        [DataMember(Name = "isGroup", EmitDefaultValue = false)]
        public bool IsGroup { get; set; }

        /// <summary>
        /// Whether the user is a local system user.
        /// </summary>
        /// <value>Whether the user is a local system user.</value>
        [DataMember(Name = "isLocalUser", EmitDefaultValue = false)]
        public bool IsLocalUser { get; private set; }

        /// <summary>
        /// Returns false as IsLocalUser should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsLocalUser()
        {
            return false;
        }

        /// <summary>
        /// User e-mail address
        /// </summary>
        /// <value>User e-mail address</value>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// User job title
        /// </summary>
        /// <value>User job title</value>
        [DataMember(Name = "jobTitle", EmitDefaultValue = true)]
        public string JobTitle { get; private set; }

        /// <summary>
        /// Returns false as JobTitle should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeJobTitle()
        {
            return false;
        }

        /// <summary>
        /// Physical delivery office name of the user
        /// </summary>
        /// <value>Physical delivery office name of the user</value>
        [DataMember(Name = "physicalDeliveryOfficeName", EmitDefaultValue = true)]
        public string PhysicalDeliveryOfficeName { get; private set; }

        /// <summary>
        /// Returns false as PhysicalDeliveryOfficeName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePhysicalDeliveryOfficeName()
        {
            return false;
        }

        /// <summary>
        /// Whether the user is valid.
        /// </summary>
        /// <value>Whether the user is valid.</value>
        [DataMember(Name = "isValid", EmitDefaultValue = false)]
        public bool IsValid { get; private set; }

        /// <summary>
        /// Returns false as IsValid should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsValid()
        {
            return false;
        }

        /// <summary>
        /// Office 365 tenant ID of the user
        /// </summary>
        /// <value>Office 365 tenant ID of the user</value>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; private set; }

        /// <summary>
        /// Returns false as TenantId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTenantId()
        {
            return false;
        }

        /// <summary>
        /// User additional data
        /// </summary>
        /// <value>User additional data</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = true)]
        public Dictionary<string, Object> AdditionalData { get; private set; }

        /// <summary>
        /// Returns false as AdditionalData should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAdditionalData()
        {
            return false;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SharingEnabledUser {\n");
            sb.Append("  IsSharePointGroup: ").Append(IsSharePointGroup).Append("\n");
            sb.Append("  IsGuestUser: ").Append(IsGuestUser).Append("\n");
            sb.Append("  IsGuestUserExistsInOrganization: ").Append(IsGuestUserExistsInOrganization).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LoginName: ").Append(LoginName).Append("\n");
            sb.Append("  IsExternalUser: ").Append(IsExternalUser).Append("\n");
            sb.Append("  AzureUserType: ").Append(AzureUserType).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  IsGroup: ").Append(IsGroup).Append("\n");
            sb.Append("  IsLocalUser: ").Append(IsLocalUser).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  JobTitle: ").Append(JobTitle).Append("\n");
            sb.Append("  PhysicalDeliveryOfficeName: ").Append(PhysicalDeliveryOfficeName).Append("\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  ApiUserType: ").Append(ApiUserType).Append("\n");
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
            return this.Equals(input as SharingEnabledUser);
        }

        /// <summary>
        /// Returns true if SharingEnabledUser instances are equal
        /// </summary>
        /// <param name="input">Instance of SharingEnabledUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharingEnabledUser input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsSharePointGroup == input.IsSharePointGroup ||
                    this.IsSharePointGroup.Equals(input.IsSharePointGroup)
                ) && 
                (
                    this.IsGuestUser == input.IsGuestUser ||
                    this.IsGuestUser.Equals(input.IsGuestUser)
                ) && 
                (
                    this.IsGuestUserExistsInOrganization == input.IsGuestUserExistsInOrganization ||
                    this.IsGuestUserExistsInOrganization.Equals(input.IsGuestUserExistsInOrganization)
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
                    this.PhysicalDeliveryOfficeName == input.PhysicalDeliveryOfficeName ||
                    (this.PhysicalDeliveryOfficeName != null &&
                    this.PhysicalDeliveryOfficeName.Equals(input.PhysicalDeliveryOfficeName))
                ) && 
                (
                    this.IsValid == input.IsValid ||
                    this.IsValid.Equals(input.IsValid)
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.AdditionalData == input.AdditionalData ||
                    this.AdditionalData != null &&
                    input.AdditionalData != null &&
                    this.AdditionalData.SequenceEqual(input.AdditionalData)
                ) && 
                (
                    this.ApiUserType == input.ApiUserType ||
                    this.ApiUserType.Equals(input.ApiUserType)
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
                hashCode = hashCode * 59 + this.IsSharePointGroup.GetHashCode();
                hashCode = hashCode * 59 + this.IsGuestUser.GetHashCode();
                hashCode = hashCode * 59 + this.IsGuestUserExistsInOrganization.GetHashCode();
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.JobTitle != null)
                    hashCode = hashCode * 59 + this.JobTitle.GetHashCode();
                if (this.PhysicalDeliveryOfficeName != null)
                    hashCode = hashCode * 59 + this.PhysicalDeliveryOfficeName.GetHashCode();
                hashCode = hashCode * 59 + this.IsValid.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.AdditionalData != null)
                    hashCode = hashCode * 59 + this.AdditionalData.GetHashCode();
                hashCode = hashCode * 59 + this.ApiUserType.GetHashCode();
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
