

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
    /// UserInfo
    /// </summary>
    [DataContract(Name = "UserInfo")]
    public partial class UserInfo : IEquatable<UserInfo>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets AuthenticationType
        /// </summary>
        [DataMember(Name = "authenticationType", EmitDefaultValue = false)]
        public AuthenticationType? AuthenticationType { get; set; }
        /// <summary>
        /// Gets or Sets InviteType
        /// </summary>
        [DataMember(Name = "inviteType", EmitDefaultValue = false)]
        public InviteType? InviteType { get; set; }
        /// <summary>
        /// Gets or Sets IsExternalUser
        /// </summary>
        [DataMember(Name = "isExternalUser", EmitDefaultValue = false)]
        public ExternalUserType? IsExternalUser { get; set; }
        /// <summary>
        /// Gets or Sets PrincipalType
        /// </summary>
        [DataMember(Name = "principalType", EmitDefaultValue = false)]
        public PrincipalType? PrincipalType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInfo" /> class.
        /// </summary>
        /// <param name="identityName">identityName.</param>
        /// <param name="userDisplayName">userDisplayName.</param>
        /// <param name="domainGroup">domainGroup (default to false).</param>
        /// <param name="department">department.</param>
        /// <param name="mobilePhone">mobilePhone.</param>
        /// <param name="manager">manager.</param>
        /// <param name="permission">permission.</param>
        /// <param name="isDeleted">isDeleted (default to false).</param>
        /// <param name="securityToken">securityToken.</param>
        /// <param name="userType">userType (default to 0).</param>
        /// <param name="azureUserType">azureUserType.</param>
        /// <param name="legalPerson">legalPerson (default to false).</param>
        /// <param name="authenticationType">authenticationType.</param>
        /// <param name="adminCenterUrl">adminCenterUrl.</param>
        /// <param name="inviteType">inviteType.</param>
        /// <param name="type">type.</param>
        /// <param name="isRegisteredAosGroup">isRegisteredAosGroup (default to false).</param>
        /// <param name="isExternalUser">isExternalUser.</param>
        /// <param name="isAPIExceptional">isAPIExceptional (default to false).</param>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="objectId">objectId.</param>
        /// <param name="version">version (default to 0).</param>
        /// <param name="jobTitle">jobTitle.</param>
        /// <param name="usageLocation">usageLocation.</param>
        /// <param name="physicalDeliveryOfficeName">physicalDeliveryOfficeName.</param>
        /// <param name="isOtherTenantUser">isOtherTenantUser (default to false).</param>
        /// <param name="networkId">networkId.</param>
        /// <param name="isValidateByProfile">isValidateByProfile (default to false).</param>
        /// <param name="proxyAddresses">proxyAddresses.</param>
        /// <param name="principalType">principalType.</param>
        /// <param name="id">id (default to 0).</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="title">title.</param>
        /// <param name="email">email.</param>
        /// <param name="isValid">isValid (default to false).</param>
        /// <param name="existInAOS">existInAOS (default to false).</param>
        public UserInfo(string identityName = default(string), string userDisplayName = default(string), bool domainGroup = false, string department = default(string), string mobilePhone = default(string), string manager = default(string), string permission = default(string), bool isDeleted = false, string securityToken = default(string), int userType = 0, string azureUserType = default(string), bool legalPerson = false, AuthenticationType? authenticationType = default(AuthenticationType?), string adminCenterUrl = default(string), InviteType? inviteType = default(InviteType?), string type = default(string), bool isRegisteredAosGroup = false, ExternalUserType? isExternalUser = default(ExternalUserType?), bool isAPIExceptional = false, string tenantId = default(string), string objectId = default(string), int version = 0, string jobTitle = default(string), string usageLocation = default(string), string physicalDeliveryOfficeName = default(string), bool isOtherTenantUser = false, string networkId = default(string), bool isValidateByProfile = false, List<string> proxyAddresses = default(List<string>), PrincipalType? principalType = default(PrincipalType?), int id = 0, string displayName = default(string), string title = default(string), string email = default(string), bool isValid = false, bool existInAOS = false)
        {
            this.IdentityName = identityName;
            this.UserDisplayName = userDisplayName;
            this.DomainGroup = domainGroup;
            this.Department = department;
            this.MobilePhone = mobilePhone;
            this.Manager = manager;
            this.Permission = permission;
            this.IsDeleted = isDeleted;
            this.SecurityToken = securityToken;
            this.UserType = userType;
            this.AzureUserType = azureUserType;
            this.LegalPerson = legalPerson;
            this.AuthenticationType = authenticationType;
            this.AdminCenterUrl = adminCenterUrl;
            this.InviteType = inviteType;
            this.Type = type;
            this.IsRegisteredAosGroup = isRegisteredAosGroup;
            this.IsExternalUser = isExternalUser;
            this.IsAPIExceptional = isAPIExceptional;
            this.TenantId = tenantId;
            this.ObjectId = objectId;
            this.Version = version;
            this.JobTitle = jobTitle;
            this.UsageLocation = usageLocation;
            this.PhysicalDeliveryOfficeName = physicalDeliveryOfficeName;
            this.IsOtherTenantUser = isOtherTenantUser;
            this.NetworkId = networkId;
            this.IsValidateByProfile = isValidateByProfile;
            this.ProxyAddresses = proxyAddresses;
            this.PrincipalType = principalType;
            this.Id = id;
            this.DisplayName = displayName;
            this.Title = title;
            this.Email = email;
            this.IsValid = isValid;
            this.ExistInAOS = existInAOS;
        }

        /// <summary>
        /// Gets or Sets IdentityName
        /// </summary>
        [DataMember(Name = "identityName", EmitDefaultValue = true)]
        public string IdentityName { get; set; }

        /// <summary>
        /// Gets or Sets UserDisplayName
        /// </summary>
        [DataMember(Name = "userDisplayName", EmitDefaultValue = true)]
        public string UserDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets DomainGroup
        /// </summary>
        [DataMember(Name = "domainGroup", EmitDefaultValue = false)]
        public bool DomainGroup { get; set; }

        /// <summary>
        /// Gets or Sets Department
        /// </summary>
        [DataMember(Name = "department", EmitDefaultValue = true)]
        public string Department { get; set; }

        /// <summary>
        /// Gets or Sets MobilePhone
        /// </summary>
        [DataMember(Name = "mobilePhone", EmitDefaultValue = true)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Gets or Sets Manager
        /// </summary>
        [DataMember(Name = "manager", EmitDefaultValue = true)]
        public string Manager { get; set; }

        /// <summary>
        /// Gets or Sets Permission
        /// </summary>
        [DataMember(Name = "permission", EmitDefaultValue = true)]
        public string Permission { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        [DataMember(Name = "isDeleted", EmitDefaultValue = false)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or Sets SecurityToken
        /// </summary>
        [DataMember(Name = "securityToken", EmitDefaultValue = true)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// Gets or Sets UserType
        /// </summary>
        [DataMember(Name = "userType", EmitDefaultValue = false)]
        public int UserType { get; set; }

        /// <summary>
        /// Gets or Sets AzureUserType
        /// </summary>
        [DataMember(Name = "azureUserType", EmitDefaultValue = true)]
        public string AzureUserType { get; set; }

        /// <summary>
        /// Gets or Sets LegalPerson
        /// </summary>
        [DataMember(Name = "legalPerson", EmitDefaultValue = false)]
        public bool LegalPerson { get; set; }

        /// <summary>
        /// Gets or Sets AdminCenterUrl
        /// </summary>
        [DataMember(Name = "adminCenterUrl", EmitDefaultValue = true)]
        public string AdminCenterUrl { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets IsRegisteredAosGroup
        /// </summary>
        [DataMember(Name = "isRegisteredAosGroup", EmitDefaultValue = false)]
        public bool IsRegisteredAosGroup { get; set; }

        /// <summary>
        /// Gets or Sets IsAPIExceptional
        /// </summary>
        [DataMember(Name = "isAPIExceptional", EmitDefaultValue = false)]
        public bool IsAPIExceptional { get; set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name = "objectId", EmitDefaultValue = true)]
        public string ObjectId { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int Version { get; set; }

        /// <summary>
        /// Gets or Sets JobTitle
        /// </summary>
        [DataMember(Name = "jobTitle", EmitDefaultValue = true)]
        public string JobTitle { get; set; }

        /// <summary>
        /// Gets or Sets UsageLocation
        /// </summary>
        [DataMember(Name = "usageLocation", EmitDefaultValue = true)]
        public string UsageLocation { get; set; }

        /// <summary>
        /// Gets or Sets PhysicalDeliveryOfficeName
        /// </summary>
        [DataMember(Name = "physicalDeliveryOfficeName", EmitDefaultValue = true)]
        public string PhysicalDeliveryOfficeName { get; set; }

        /// <summary>
        /// Gets or Sets IsOtherTenantUser
        /// </summary>
        [DataMember(Name = "isOtherTenantUser", EmitDefaultValue = false)]
        public bool IsOtherTenantUser { get; set; }

        /// <summary>
        /// Gets or Sets NetworkId
        /// </summary>
        [DataMember(Name = "networkId", EmitDefaultValue = true)]
        public string NetworkId { get; set; }

        /// <summary>
        /// Gets or Sets IsValidateByProfile
        /// </summary>
        [DataMember(Name = "isValidateByProfile", EmitDefaultValue = false)]
        public bool IsValidateByProfile { get; set; }

        /// <summary>
        /// Gets or Sets ProxyAddresses
        /// </summary>
        [DataMember(Name = "proxyAddresses", EmitDefaultValue = true)]
        public List<string> ProxyAddresses { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets IsValid
        /// </summary>
        [DataMember(Name = "isValid", EmitDefaultValue = false)]
        public bool IsValid { get; set; }

        /// <summary>
        /// Gets or Sets ExistInAOS
        /// </summary>
        [DataMember(Name = "existInAOS", EmitDefaultValue = false)]
        public bool ExistInAOS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserInfo {\n");
            sb.Append("  IdentityName: ").Append(IdentityName).Append("\n");
            sb.Append("  UserDisplayName: ").Append(UserDisplayName).Append("\n");
            sb.Append("  DomainGroup: ").Append(DomainGroup).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  MobilePhone: ").Append(MobilePhone).Append("\n");
            sb.Append("  Manager: ").Append(Manager).Append("\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  SecurityToken: ").Append(SecurityToken).Append("\n");
            sb.Append("  UserType: ").Append(UserType).Append("\n");
            sb.Append("  AzureUserType: ").Append(AzureUserType).Append("\n");
            sb.Append("  LegalPerson: ").Append(LegalPerson).Append("\n");
            sb.Append("  AuthenticationType: ").Append(AuthenticationType).Append("\n");
            sb.Append("  AdminCenterUrl: ").Append(AdminCenterUrl).Append("\n");
            sb.Append("  InviteType: ").Append(InviteType).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IsRegisteredAosGroup: ").Append(IsRegisteredAosGroup).Append("\n");
            sb.Append("  IsExternalUser: ").Append(IsExternalUser).Append("\n");
            sb.Append("  IsAPIExceptional: ").Append(IsAPIExceptional).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  JobTitle: ").Append(JobTitle).Append("\n");
            sb.Append("  UsageLocation: ").Append(UsageLocation).Append("\n");
            sb.Append("  PhysicalDeliveryOfficeName: ").Append(PhysicalDeliveryOfficeName).Append("\n");
            sb.Append("  IsOtherTenantUser: ").Append(IsOtherTenantUser).Append("\n");
            sb.Append("  NetworkId: ").Append(NetworkId).Append("\n");
            sb.Append("  IsValidateByProfile: ").Append(IsValidateByProfile).Append("\n");
            sb.Append("  ProxyAddresses: ").Append(ProxyAddresses).Append("\n");
            sb.Append("  PrincipalType: ").Append(PrincipalType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
            sb.Append("  ExistInAOS: ").Append(ExistInAOS).Append("\n");
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
            return this.Equals(input as UserInfo);
        }

        /// <summary>
        /// Returns true if UserInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of UserInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdentityName == input.IdentityName ||
                    (this.IdentityName != null &&
                    this.IdentityName.Equals(input.IdentityName))
                ) && 
                (
                    this.UserDisplayName == input.UserDisplayName ||
                    (this.UserDisplayName != null &&
                    this.UserDisplayName.Equals(input.UserDisplayName))
                ) && 
                (
                    this.DomainGroup == input.DomainGroup ||
                    this.DomainGroup.Equals(input.DomainGroup)
                ) && 
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
                ) && 
                (
                    this.MobilePhone == input.MobilePhone ||
                    (this.MobilePhone != null &&
                    this.MobilePhone.Equals(input.MobilePhone))
                ) && 
                (
                    this.Manager == input.Manager ||
                    (this.Manager != null &&
                    this.Manager.Equals(input.Manager))
                ) && 
                (
                    this.Permission == input.Permission ||
                    (this.Permission != null &&
                    this.Permission.Equals(input.Permission))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    this.IsDeleted.Equals(input.IsDeleted)
                ) && 
                (
                    this.SecurityToken == input.SecurityToken ||
                    (this.SecurityToken != null &&
                    this.SecurityToken.Equals(input.SecurityToken))
                ) && 
                (
                    this.UserType == input.UserType ||
                    this.UserType.Equals(input.UserType)
                ) && 
                (
                    this.AzureUserType == input.AzureUserType ||
                    (this.AzureUserType != null &&
                    this.AzureUserType.Equals(input.AzureUserType))
                ) && 
                (
                    this.LegalPerson == input.LegalPerson ||
                    this.LegalPerson.Equals(input.LegalPerson)
                ) && 
                (
                    this.AuthenticationType == input.AuthenticationType ||
                    this.AuthenticationType.Equals(input.AuthenticationType)
                ) && 
                (
                    this.AdminCenterUrl == input.AdminCenterUrl ||
                    (this.AdminCenterUrl != null &&
                    this.AdminCenterUrl.Equals(input.AdminCenterUrl))
                ) && 
                (
                    this.InviteType == input.InviteType ||
                    this.InviteType.Equals(input.InviteType)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.IsRegisteredAosGroup == input.IsRegisteredAosGroup ||
                    this.IsRegisteredAosGroup.Equals(input.IsRegisteredAosGroup)
                ) && 
                (
                    this.IsExternalUser == input.IsExternalUser ||
                    this.IsExternalUser.Equals(input.IsExternalUser)
                ) && 
                (
                    this.IsAPIExceptional == input.IsAPIExceptional ||
                    this.IsAPIExceptional.Equals(input.IsAPIExceptional)
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
                ) && 
                (
                    this.Version == input.Version ||
                    this.Version.Equals(input.Version)
                ) && 
                (
                    this.JobTitle == input.JobTitle ||
                    (this.JobTitle != null &&
                    this.JobTitle.Equals(input.JobTitle))
                ) && 
                (
                    this.UsageLocation == input.UsageLocation ||
                    (this.UsageLocation != null &&
                    this.UsageLocation.Equals(input.UsageLocation))
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
                    this.NetworkId == input.NetworkId ||
                    (this.NetworkId != null &&
                    this.NetworkId.Equals(input.NetworkId))
                ) && 
                (
                    this.IsValidateByProfile == input.IsValidateByProfile ||
                    this.IsValidateByProfile.Equals(input.IsValidateByProfile)
                ) && 
                (
                    this.ProxyAddresses == input.ProxyAddresses ||
                    this.ProxyAddresses != null &&
                    input.ProxyAddresses != null &&
                    this.ProxyAddresses.SequenceEqual(input.ProxyAddresses)
                ) && 
                (
                    this.PrincipalType == input.PrincipalType ||
                    this.PrincipalType.Equals(input.PrincipalType)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.IsValid == input.IsValid ||
                    this.IsValid.Equals(input.IsValid)
                ) && 
                (
                    this.ExistInAOS == input.ExistInAOS ||
                    this.ExistInAOS.Equals(input.ExistInAOS)
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
                if (this.IdentityName != null)
                    hashCode = hashCode * 59 + this.IdentityName.GetHashCode();
                if (this.UserDisplayName != null)
                    hashCode = hashCode * 59 + this.UserDisplayName.GetHashCode();
                hashCode = hashCode * 59 + this.DomainGroup.GetHashCode();
                if (this.Department != null)
                    hashCode = hashCode * 59 + this.Department.GetHashCode();
                if (this.MobilePhone != null)
                    hashCode = hashCode * 59 + this.MobilePhone.GetHashCode();
                if (this.Manager != null)
                    hashCode = hashCode * 59 + this.Manager.GetHashCode();
                if (this.Permission != null)
                    hashCode = hashCode * 59 + this.Permission.GetHashCode();
                hashCode = hashCode * 59 + this.IsDeleted.GetHashCode();
                if (this.SecurityToken != null)
                    hashCode = hashCode * 59 + this.SecurityToken.GetHashCode();
                hashCode = hashCode * 59 + this.UserType.GetHashCode();
                if (this.AzureUserType != null)
                    hashCode = hashCode * 59 + this.AzureUserType.GetHashCode();
                hashCode = hashCode * 59 + this.LegalPerson.GetHashCode();
                hashCode = hashCode * 59 + this.AuthenticationType.GetHashCode();
                if (this.AdminCenterUrl != null)
                    hashCode = hashCode * 59 + this.AdminCenterUrl.GetHashCode();
                hashCode = hashCode * 59 + this.InviteType.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.IsRegisteredAosGroup.GetHashCode();
                hashCode = hashCode * 59 + this.IsExternalUser.GetHashCode();
                hashCode = hashCode * 59 + this.IsAPIExceptional.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.ObjectId != null)
                    hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.JobTitle != null)
                    hashCode = hashCode * 59 + this.JobTitle.GetHashCode();
                if (this.UsageLocation != null)
                    hashCode = hashCode * 59 + this.UsageLocation.GetHashCode();
                if (this.PhysicalDeliveryOfficeName != null)
                    hashCode = hashCode * 59 + this.PhysicalDeliveryOfficeName.GetHashCode();
                hashCode = hashCode * 59 + this.IsOtherTenantUser.GetHashCode();
                if (this.NetworkId != null)
                    hashCode = hashCode * 59 + this.NetworkId.GetHashCode();
                hashCode = hashCode * 59 + this.IsValidateByProfile.GetHashCode();
                if (this.ProxyAddresses != null)
                    hashCode = hashCode * 59 + this.ProxyAddresses.GetHashCode();
                hashCode = hashCode * 59 + this.PrincipalType.GetHashCode();
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                hashCode = hashCode * 59 + this.IsValid.GetHashCode();
                hashCode = hashCode * 59 + this.ExistInAOS.GetHashCode();
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
