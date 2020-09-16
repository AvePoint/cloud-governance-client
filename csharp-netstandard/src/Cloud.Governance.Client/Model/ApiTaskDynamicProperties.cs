

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
    /// ApiTaskDynamicProperties
    /// </summary>
    [DataContract(Name = "ApiTask_dynamicProperties")]
    public partial class ApiTaskDynamicProperties : IEquatable<ApiTaskDynamicProperties>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiTaskDynamicProperties" /> class.
        /// </summary>
        /// <param name="none">none.</param>
        /// <param name="primaryContact">primaryContact.</param>
        /// <param name="secondaryContact">secondaryContact.</param>
        /// <param name="siteId">siteId.</param>
        /// <param name="siteUrl">siteUrl.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="expirationDate">expirationDate.</param>
        /// <param name="groupOwners">groupOwners.</param>
        /// <param name="autoTaskActionHistories">autoTaskActionHistories.</param>
        /// <param name="inactivityThresholdDate">inactivityThresholdDate.</param>
        /// <param name="groupEmail">groupEmail.</param>
        /// <param name="groupId">groupId.</param>
        /// <param name="policyName">policyName.</param>
        /// <param name="primaryAdministrator">primaryAdministrator.</param>
        /// <param name="siteTemplate">siteTemplate.</param>
        /// <param name="siteTitle">siteTitle.</param>
        /// <param name="siteDescription">siteDescription.</param>
        /// <param name="requester">requester.</param>
        /// <param name="isTeam">isTeam.</param>
        /// <param name="groupOwnersStr">groupOwnersStr.</param>
        public ApiTaskDynamicProperties(Object none = default(Object), Object primaryContact = default(Object), Object secondaryContact = default(Object), Object siteId = default(Object), Object siteUrl = default(Object), Object groupName = default(Object), Object expirationDate = default(Object), Object groupOwners = default(Object), Object autoTaskActionHistories = default(Object), Object inactivityThresholdDate = default(Object), Object groupEmail = default(Object), Object groupId = default(Object), Object policyName = default(Object), Object primaryAdministrator = default(Object), Object siteTemplate = default(Object), Object siteTitle = default(Object), Object siteDescription = default(Object), Object requester = default(Object), Object isTeam = default(Object), Object groupOwnersStr = default(Object))
        {
            this.None = none;
            this.PrimaryContact = primaryContact;
            this.SecondaryContact = secondaryContact;
            this.SiteId = siteId;
            this.SiteUrl = siteUrl;
            this.GroupName = groupName;
            this.ExpirationDate = expirationDate;
            this.GroupOwners = groupOwners;
            this.AutoTaskActionHistories = autoTaskActionHistories;
            this.InactivityThresholdDate = inactivityThresholdDate;
            this.GroupEmail = groupEmail;
            this.GroupId = groupId;
            this.PolicyName = policyName;
            this.PrimaryAdministrator = primaryAdministrator;
            this.SiteTemplate = siteTemplate;
            this.SiteTitle = siteTitle;
            this.SiteDescription = siteDescription;
            this.Requester = requester;
            this.IsTeam = isTeam;
            this.GroupOwnersStr = groupOwnersStr;
        }

        /// <summary>
        /// Gets or Sets None
        /// </summary>
        [DataMember(Name = "None", EmitDefaultValue = false)]
        public Object None { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryContact
        /// </summary>
        [DataMember(Name = "PrimaryContact", EmitDefaultValue = false)]
        public Object PrimaryContact { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryContact
        /// </summary>
        [DataMember(Name = "SecondaryContact", EmitDefaultValue = false)]
        public Object SecondaryContact { get; set; }

        /// <summary>
        /// Gets or Sets SiteId
        /// </summary>
        [DataMember(Name = "SiteId", EmitDefaultValue = false)]
        public Object SiteId { get; set; }

        /// <summary>
        /// Gets or Sets SiteUrl
        /// </summary>
        [DataMember(Name = "SiteUrl", EmitDefaultValue = false)]
        public Object SiteUrl { get; set; }

        /// <summary>
        /// Gets or Sets GroupName
        /// </summary>
        [DataMember(Name = "GroupName", EmitDefaultValue = false)]
        public Object GroupName { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name = "ExpirationDate", EmitDefaultValue = false)]
        public Object ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets GroupOwners
        /// </summary>
        [DataMember(Name = "GroupOwners", EmitDefaultValue = false)]
        public Object GroupOwners { get; set; }

        /// <summary>
        /// Gets or Sets AutoTaskActionHistories
        /// </summary>
        [DataMember(Name = "AutoTaskActionHistories", EmitDefaultValue = false)]
        public Object AutoTaskActionHistories { get; set; }

        /// <summary>
        /// Gets or Sets InactivityThresholdDate
        /// </summary>
        [DataMember(Name = "InactivityThresholdDate", EmitDefaultValue = false)]
        public Object InactivityThresholdDate { get; set; }

        /// <summary>
        /// Gets or Sets GroupEmail
        /// </summary>
        [DataMember(Name = "GroupEmail", EmitDefaultValue = false)]
        public Object GroupEmail { get; set; }

        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name = "GroupId", EmitDefaultValue = false)]
        public Object GroupId { get; set; }

        /// <summary>
        /// Gets or Sets PolicyName
        /// </summary>
        [DataMember(Name = "PolicyName", EmitDefaultValue = false)]
        public Object PolicyName { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryAdministrator
        /// </summary>
        [DataMember(Name = "PrimaryAdministrator", EmitDefaultValue = false)]
        public Object PrimaryAdministrator { get; set; }

        /// <summary>
        /// Gets or Sets SiteTemplate
        /// </summary>
        [DataMember(Name = "SiteTemplate", EmitDefaultValue = false)]
        public Object SiteTemplate { get; set; }

        /// <summary>
        /// Gets or Sets SiteTitle
        /// </summary>
        [DataMember(Name = "SiteTitle", EmitDefaultValue = false)]
        public Object SiteTitle { get; set; }

        /// <summary>
        /// Gets or Sets SiteDescription
        /// </summary>
        [DataMember(Name = "SiteDescription", EmitDefaultValue = false)]
        public Object SiteDescription { get; set; }

        /// <summary>
        /// Gets or Sets Requester
        /// </summary>
        [DataMember(Name = "Requester", EmitDefaultValue = false)]
        public Object Requester { get; set; }

        /// <summary>
        /// Gets or Sets IsTeam
        /// </summary>
        [DataMember(Name = "IsTeam", EmitDefaultValue = false)]
        public Object IsTeam { get; set; }

        /// <summary>
        /// Gets or Sets GroupOwnersStr
        /// </summary>
        [DataMember(Name = "GroupOwnersStr", EmitDefaultValue = false)]
        public Object GroupOwnersStr { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiTaskDynamicProperties {\n");
            sb.Append("  None: ").Append(None).Append("\n");
            sb.Append("  PrimaryContact: ").Append(PrimaryContact).Append("\n");
            sb.Append("  SecondaryContact: ").Append(SecondaryContact).Append("\n");
            sb.Append("  SiteId: ").Append(SiteId).Append("\n");
            sb.Append("  SiteUrl: ").Append(SiteUrl).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  GroupOwners: ").Append(GroupOwners).Append("\n");
            sb.Append("  AutoTaskActionHistories: ").Append(AutoTaskActionHistories).Append("\n");
            sb.Append("  InactivityThresholdDate: ").Append(InactivityThresholdDate).Append("\n");
            sb.Append("  GroupEmail: ").Append(GroupEmail).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  PolicyName: ").Append(PolicyName).Append("\n");
            sb.Append("  PrimaryAdministrator: ").Append(PrimaryAdministrator).Append("\n");
            sb.Append("  SiteTemplate: ").Append(SiteTemplate).Append("\n");
            sb.Append("  SiteTitle: ").Append(SiteTitle).Append("\n");
            sb.Append("  SiteDescription: ").Append(SiteDescription).Append("\n");
            sb.Append("  Requester: ").Append(Requester).Append("\n");
            sb.Append("  IsTeam: ").Append(IsTeam).Append("\n");
            sb.Append("  GroupOwnersStr: ").Append(GroupOwnersStr).Append("\n");
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
            return this.Equals(input as ApiTaskDynamicProperties);
        }

        /// <summary>
        /// Returns true if ApiTaskDynamicProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiTaskDynamicProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiTaskDynamicProperties input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.None == input.None ||
                    (this.None != null &&
                    this.None.Equals(input.None))
                ) && 
                (
                    this.PrimaryContact == input.PrimaryContact ||
                    (this.PrimaryContact != null &&
                    this.PrimaryContact.Equals(input.PrimaryContact))
                ) && 
                (
                    this.SecondaryContact == input.SecondaryContact ||
                    (this.SecondaryContact != null &&
                    this.SecondaryContact.Equals(input.SecondaryContact))
                ) && 
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
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && 
                (
                    this.GroupOwners == input.GroupOwners ||
                    (this.GroupOwners != null &&
                    this.GroupOwners.Equals(input.GroupOwners))
                ) && 
                (
                    this.AutoTaskActionHistories == input.AutoTaskActionHistories ||
                    (this.AutoTaskActionHistories != null &&
                    this.AutoTaskActionHistories.Equals(input.AutoTaskActionHistories))
                ) && 
                (
                    this.InactivityThresholdDate == input.InactivityThresholdDate ||
                    (this.InactivityThresholdDate != null &&
                    this.InactivityThresholdDate.Equals(input.InactivityThresholdDate))
                ) && 
                (
                    this.GroupEmail == input.GroupEmail ||
                    (this.GroupEmail != null &&
                    this.GroupEmail.Equals(input.GroupEmail))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.PolicyName == input.PolicyName ||
                    (this.PolicyName != null &&
                    this.PolicyName.Equals(input.PolicyName))
                ) && 
                (
                    this.PrimaryAdministrator == input.PrimaryAdministrator ||
                    (this.PrimaryAdministrator != null &&
                    this.PrimaryAdministrator.Equals(input.PrimaryAdministrator))
                ) && 
                (
                    this.SiteTemplate == input.SiteTemplate ||
                    (this.SiteTemplate != null &&
                    this.SiteTemplate.Equals(input.SiteTemplate))
                ) && 
                (
                    this.SiteTitle == input.SiteTitle ||
                    (this.SiteTitle != null &&
                    this.SiteTitle.Equals(input.SiteTitle))
                ) && 
                (
                    this.SiteDescription == input.SiteDescription ||
                    (this.SiteDescription != null &&
                    this.SiteDescription.Equals(input.SiteDescription))
                ) && 
                (
                    this.Requester == input.Requester ||
                    (this.Requester != null &&
                    this.Requester.Equals(input.Requester))
                ) && 
                (
                    this.IsTeam == input.IsTeam ||
                    (this.IsTeam != null &&
                    this.IsTeam.Equals(input.IsTeam))
                ) && 
                (
                    this.GroupOwnersStr == input.GroupOwnersStr ||
                    (this.GroupOwnersStr != null &&
                    this.GroupOwnersStr.Equals(input.GroupOwnersStr))
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
                if (this.None != null)
                    hashCode = hashCode * 59 + this.None.GetHashCode();
                if (this.PrimaryContact != null)
                    hashCode = hashCode * 59 + this.PrimaryContact.GetHashCode();
                if (this.SecondaryContact != null)
                    hashCode = hashCode * 59 + this.SecondaryContact.GetHashCode();
                if (this.SiteId != null)
                    hashCode = hashCode * 59 + this.SiteId.GetHashCode();
                if (this.SiteUrl != null)
                    hashCode = hashCode * 59 + this.SiteUrl.GetHashCode();
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                if (this.GroupOwners != null)
                    hashCode = hashCode * 59 + this.GroupOwners.GetHashCode();
                if (this.AutoTaskActionHistories != null)
                    hashCode = hashCode * 59 + this.AutoTaskActionHistories.GetHashCode();
                if (this.InactivityThresholdDate != null)
                    hashCode = hashCode * 59 + this.InactivityThresholdDate.GetHashCode();
                if (this.GroupEmail != null)
                    hashCode = hashCode * 59 + this.GroupEmail.GetHashCode();
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.PolicyName != null)
                    hashCode = hashCode * 59 + this.PolicyName.GetHashCode();
                if (this.PrimaryAdministrator != null)
                    hashCode = hashCode * 59 + this.PrimaryAdministrator.GetHashCode();
                if (this.SiteTemplate != null)
                    hashCode = hashCode * 59 + this.SiteTemplate.GetHashCode();
                if (this.SiteTitle != null)
                    hashCode = hashCode * 59 + this.SiteTitle.GetHashCode();
                if (this.SiteDescription != null)
                    hashCode = hashCode * 59 + this.SiteDescription.GetHashCode();
                if (this.Requester != null)
                    hashCode = hashCode * 59 + this.Requester.GetHashCode();
                if (this.IsTeam != null)
                    hashCode = hashCode * 59 + this.IsTeam.GetHashCode();
                if (this.GroupOwnersStr != null)
                    hashCode = hashCode * 59 + this.GroupOwnersStr.GetHashCode();
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
