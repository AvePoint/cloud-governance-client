

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
    /// ApiMyGroup
    /// </summary>
    [DataContract(Name = "ApiMyGroup")]
    public partial class ApiMyGroup : IEquatable<ApiMyGroup>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets GroupObjectType
        /// </summary>
        [DataMember(Name = "groupObjectType", EmitDefaultValue = false)]
        public GroupObjectType? GroupObjectType { get; set; }
        /// <summary>
        /// Gets or Sets Phase
        /// </summary>
        [DataMember(Name = "phase", EmitDefaultValue = false)]
        public AutoImportPhase? Phase { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiMyGroup" /> class.
        /// </summary>
        /// <param name="objectId">objectId.</param>
        /// <param name="policyId">policyId.</param>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="email">email.</param>
        /// <param name="language">language.</param>
        /// <param name="applyPolicyStatus">applyPolicyStatus (default to 0).</param>
        /// <param name="enableTeamCollaboration">enableTeamCollaboration (default to false).</param>
        /// <param name="groupType">groupType.</param>
        /// <param name="createdTime">createdTime.</param>
        /// <param name="owners">owners.</param>
        /// <param name="preferredDataLocation">preferredDataLocation.</param>
        /// <param name="preferredDataLocationName">preferredDataLocationName.</param>
        /// <param name="enableDynamicMembership">enableDynamicMembership (default to false).</param>
        /// <param name="groupTeamSiteUrl">groupTeamSiteUrl.</param>
        /// <param name="teamLink">teamLink.</param>
        /// <param name="noteBookLink">noteBookLink.</param>
        /// <param name="plannerLink">plannerLink.</param>
        /// <param name="classification">classification.</param>
        /// <param name="groupObjectType">groupObjectType.</param>
        /// <param name="groupObjectId">groupObjectId.</param>
        /// <param name="networkId">networkId.</param>
        /// <param name="id">id.</param>
        /// <param name="phase">phase.</param>
        /// <param name="phaseStartTime">phaseStartTime.</param>
        /// <param name="phaseDescription">phaseDescription.</param>
        /// <param name="autoImportProfileId">autoImportProfileId.</param>
        /// <param name="autoImportProfileName">autoImportProfileName.</param>
        /// <param name="policyName">policyName.</param>
        /// <param name="policyDescription">policyDescription.</param>
        /// <param name="isCurrentRenewer">isCurrentRenewer (default to false).</param>
        /// <param name="phaseAssignees">phaseAssignees.</param>
        /// <param name="phaseDueDate">phaseDueDate.</param>
        /// <param name="metadatas">metadatas.</param>
        /// <param name="primaryContact">ApiUser model.</param>
        /// <param name="secondaryContact">ApiUser model.</param>
        /// <param name="errorMessage">errorMessage.</param>
        public ApiMyGroup(string objectId = default(string), Guid policyId = default(Guid), Guid tenantId = default(Guid), string groupName = default(string), string email = default(string), string language = default(string), int applyPolicyStatus = 0, bool enableTeamCollaboration = false, string groupType = default(string), DateTime? createdTime = default(DateTime?), List<ApiUser> owners = default(List<ApiUser>), string preferredDataLocation = default(string), string preferredDataLocationName = default(string), bool enableDynamicMembership = false, string groupTeamSiteUrl = default(string), string teamLink = default(string), string noteBookLink = default(string), string plannerLink = default(string), string classification = default(string), GroupObjectType? groupObjectType = default(GroupObjectType?), string groupObjectId = default(string), string networkId = default(string), Guid id = default(Guid), AutoImportPhase? phase = default(AutoImportPhase?), DateTime? phaseStartTime = default(DateTime?), string phaseDescription = default(string), Guid? autoImportProfileId = default(Guid?), string autoImportProfileName = default(string), string policyName = default(string), string policyDescription = default(string), bool isCurrentRenewer = false, List<ApiUser> phaseAssignees = default(List<ApiUser>), DateTime? phaseDueDate = default(DateTime?), List<RequestMetadata> metadatas = default(List<RequestMetadata>), ApiUser primaryContact = default(ApiUser), ApiUser secondaryContact = default(ApiUser), string errorMessage = default(string))
        {
            this.ObjectId = objectId;
            this.PolicyId = policyId;
            this.TenantId = tenantId;
            this.GroupName = groupName;
            this.Email = email;
            this.Language = language;
            this.ApplyPolicyStatus = applyPolicyStatus;
            this.EnableTeamCollaboration = enableTeamCollaboration;
            this.GroupType = groupType;
            this.CreatedTime = createdTime;
            this.Owners = owners;
            this.PreferredDataLocation = preferredDataLocation;
            this.PreferredDataLocationName = preferredDataLocationName;
            this.EnableDynamicMembership = enableDynamicMembership;
            this.GroupTeamSiteUrl = groupTeamSiteUrl;
            this.TeamLink = teamLink;
            this.NoteBookLink = noteBookLink;
            this.PlannerLink = plannerLink;
            this.Classification = classification;
            this.GroupObjectType = groupObjectType;
            this.GroupObjectId = groupObjectId;
            this.NetworkId = networkId;
            this.Id = id;
            this.Phase = phase;
            this.PhaseStartTime = phaseStartTime;
            this.PhaseDescription = phaseDescription;
            this.AutoImportProfileId = autoImportProfileId;
            this.AutoImportProfileName = autoImportProfileName;
            this.PolicyName = policyName;
            this.PolicyDescription = policyDescription;
            this.IsCurrentRenewer = isCurrentRenewer;
            this.PhaseAssignees = phaseAssignees;
            this.PhaseDueDate = phaseDueDate;
            this.Metadatas = metadatas;
            this.PrimaryContact = primaryContact;
            this.SecondaryContact = secondaryContact;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name = "objectId", EmitDefaultValue = true)]
        public string ObjectId { get; set; }

        /// <summary>
        /// Gets or Sets PolicyId
        /// </summary>
        [DataMember(Name = "policyId", EmitDefaultValue = false)]
        public Guid PolicyId { get; set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Gets or Sets GroupName
        /// </summary>
        [DataMember(Name = "groupName", EmitDefaultValue = true)]
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name = "language", EmitDefaultValue = true)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets ApplyPolicyStatus
        /// </summary>
        [DataMember(Name = "applyPolicyStatus", EmitDefaultValue = false)]
        public int ApplyPolicyStatus { get; set; }

        /// <summary>
        /// Gets or Sets EnableTeamCollaboration
        /// </summary>
        [DataMember(Name = "enableTeamCollaboration", EmitDefaultValue = false)]
        public bool EnableTeamCollaboration { get; set; }

        /// <summary>
        /// Gets or Sets GroupType
        /// </summary>
        [DataMember(Name = "groupType", EmitDefaultValue = true)]
        public string GroupType { get; set; }

        /// <summary>
        /// Gets or Sets CreatedTime
        /// </summary>
        [DataMember(Name = "createdTime", EmitDefaultValue = true)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Gets or Sets Owners
        /// </summary>
        [DataMember(Name = "owners", EmitDefaultValue = true)]
        public List<ApiUser> Owners { get; set; }

        /// <summary>
        /// Gets or Sets PreferredDataLocation
        /// </summary>
        [DataMember(Name = "preferredDataLocation", EmitDefaultValue = true)]
        public string PreferredDataLocation { get; set; }

        /// <summary>
        /// Gets or Sets PreferredDataLocationName
        /// </summary>
        [DataMember(Name = "preferredDataLocationName", EmitDefaultValue = true)]
        public string PreferredDataLocationName { get; set; }

        /// <summary>
        /// Gets or Sets EnableDynamicMembership
        /// </summary>
        [DataMember(Name = "enableDynamicMembership", EmitDefaultValue = false)]
        public bool EnableDynamicMembership { get; set; }

        /// <summary>
        /// Gets or Sets GroupTeamSiteUrl
        /// </summary>
        [DataMember(Name = "groupTeamSiteUrl", EmitDefaultValue = true)]
        public string GroupTeamSiteUrl { get; set; }

        /// <summary>
        /// Gets or Sets TeamLink
        /// </summary>
        [DataMember(Name = "teamLink", EmitDefaultValue = true)]
        public string TeamLink { get; set; }

        /// <summary>
        /// Gets or Sets NoteBookLink
        /// </summary>
        [DataMember(Name = "noteBookLink", EmitDefaultValue = true)]
        public string NoteBookLink { get; set; }

        /// <summary>
        /// Gets or Sets PlannerLink
        /// </summary>
        [DataMember(Name = "plannerLink", EmitDefaultValue = true)]
        public string PlannerLink { get; set; }

        /// <summary>
        /// Gets or Sets Classification
        /// </summary>
        [DataMember(Name = "classification", EmitDefaultValue = true)]
        public string Classification { get; set; }

        /// <summary>
        /// Gets or Sets GroupObjectId
        /// </summary>
        [DataMember(Name = "groupObjectId", EmitDefaultValue = true)]
        public string GroupObjectId { get; set; }

        /// <summary>
        /// Gets or Sets NetworkId
        /// </summary>
        [DataMember(Name = "networkId", EmitDefaultValue = true)]
        public string NetworkId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets PhaseStartTime
        /// </summary>
        [DataMember(Name = "phaseStartTime", EmitDefaultValue = true)]
        public DateTime? PhaseStartTime { get; set; }

        /// <summary>
        /// Gets or Sets PhaseDescription
        /// </summary>
        [DataMember(Name = "phaseDescription", EmitDefaultValue = true)]
        public string PhaseDescription { get; set; }

        /// <summary>
        /// Gets or Sets AutoImportProfileId
        /// </summary>
        [DataMember(Name = "autoImportProfileId", EmitDefaultValue = true)]
        public Guid? AutoImportProfileId { get; set; }

        /// <summary>
        /// Gets or Sets AutoImportProfileName
        /// </summary>
        [DataMember(Name = "autoImportProfileName", EmitDefaultValue = true)]
        public string AutoImportProfileName { get; set; }

        /// <summary>
        /// Gets or Sets PolicyName
        /// </summary>
        [DataMember(Name = "policyName", EmitDefaultValue = true)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Gets or Sets PolicyDescription
        /// </summary>
        [DataMember(Name = "policyDescription", EmitDefaultValue = true)]
        public string PolicyDescription { get; set; }

        /// <summary>
        /// Gets or Sets IsCurrentRenewer
        /// </summary>
        [DataMember(Name = "isCurrentRenewer", EmitDefaultValue = false)]
        public bool IsCurrentRenewer { get; set; }

        /// <summary>
        /// Gets or Sets PhaseAssignees
        /// </summary>
        [DataMember(Name = "phaseAssignees", EmitDefaultValue = true)]
        public List<ApiUser> PhaseAssignees { get; set; }

        /// <summary>
        /// Gets or Sets PhaseDueDate
        /// </summary>
        [DataMember(Name = "phaseDueDate", EmitDefaultValue = true)]
        public DateTime? PhaseDueDate { get; set; }

        /// <summary>
        /// Gets or Sets Metadatas
        /// </summary>
        [DataMember(Name = "metadatas", EmitDefaultValue = true)]
        public List<RequestMetadata> Metadatas { get; set; }

        /// <summary>
        /// ApiUser model
        /// </summary>
        /// <value>ApiUser model</value>
        [DataMember(Name = "primaryContact", EmitDefaultValue = true)]
        public ApiUser PrimaryContact { get; set; }

        /// <summary>
        /// ApiUser model
        /// </summary>
        /// <value>ApiUser model</value>
        [DataMember(Name = "secondaryContact", EmitDefaultValue = true)]
        public ApiUser SecondaryContact { get; set; }

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
            sb.Append("class ApiMyGroup {\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  ApplyPolicyStatus: ").Append(ApplyPolicyStatus).Append("\n");
            sb.Append("  EnableTeamCollaboration: ").Append(EnableTeamCollaboration).Append("\n");
            sb.Append("  GroupType: ").Append(GroupType).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  Owners: ").Append(Owners).Append("\n");
            sb.Append("  PreferredDataLocation: ").Append(PreferredDataLocation).Append("\n");
            sb.Append("  PreferredDataLocationName: ").Append(PreferredDataLocationName).Append("\n");
            sb.Append("  EnableDynamicMembership: ").Append(EnableDynamicMembership).Append("\n");
            sb.Append("  GroupTeamSiteUrl: ").Append(GroupTeamSiteUrl).Append("\n");
            sb.Append("  TeamLink: ").Append(TeamLink).Append("\n");
            sb.Append("  NoteBookLink: ").Append(NoteBookLink).Append("\n");
            sb.Append("  PlannerLink: ").Append(PlannerLink).Append("\n");
            sb.Append("  Classification: ").Append(Classification).Append("\n");
            sb.Append("  GroupObjectType: ").Append(GroupObjectType).Append("\n");
            sb.Append("  GroupObjectId: ").Append(GroupObjectId).Append("\n");
            sb.Append("  NetworkId: ").Append(NetworkId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Phase: ").Append(Phase).Append("\n");
            sb.Append("  PhaseStartTime: ").Append(PhaseStartTime).Append("\n");
            sb.Append("  PhaseDescription: ").Append(PhaseDescription).Append("\n");
            sb.Append("  AutoImportProfileId: ").Append(AutoImportProfileId).Append("\n");
            sb.Append("  AutoImportProfileName: ").Append(AutoImportProfileName).Append("\n");
            sb.Append("  PolicyName: ").Append(PolicyName).Append("\n");
            sb.Append("  PolicyDescription: ").Append(PolicyDescription).Append("\n");
            sb.Append("  IsCurrentRenewer: ").Append(IsCurrentRenewer).Append("\n");
            sb.Append("  PhaseAssignees: ").Append(PhaseAssignees).Append("\n");
            sb.Append("  PhaseDueDate: ").Append(PhaseDueDate).Append("\n");
            sb.Append("  Metadatas: ").Append(Metadatas).Append("\n");
            sb.Append("  PrimaryContact: ").Append(PrimaryContact).Append("\n");
            sb.Append("  SecondaryContact: ").Append(SecondaryContact).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
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
            return this.Equals(input as ApiMyGroup);
        }

        /// <summary>
        /// Returns true if ApiMyGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiMyGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiMyGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
                ) && 
                (
                    this.PolicyId == input.PolicyId ||
                    (this.PolicyId != null &&
                    this.PolicyId.Equals(input.PolicyId))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.ApplyPolicyStatus == input.ApplyPolicyStatus ||
                    this.ApplyPolicyStatus.Equals(input.ApplyPolicyStatus)
                ) && 
                (
                    this.EnableTeamCollaboration == input.EnableTeamCollaboration ||
                    this.EnableTeamCollaboration.Equals(input.EnableTeamCollaboration)
                ) && 
                (
                    this.GroupType == input.GroupType ||
                    (this.GroupType != null &&
                    this.GroupType.Equals(input.GroupType))
                ) && 
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
                ) && 
                (
                    this.Owners == input.Owners ||
                    this.Owners != null &&
                    input.Owners != null &&
                    this.Owners.SequenceEqual(input.Owners)
                ) && 
                (
                    this.PreferredDataLocation == input.PreferredDataLocation ||
                    (this.PreferredDataLocation != null &&
                    this.PreferredDataLocation.Equals(input.PreferredDataLocation))
                ) && 
                (
                    this.PreferredDataLocationName == input.PreferredDataLocationName ||
                    (this.PreferredDataLocationName != null &&
                    this.PreferredDataLocationName.Equals(input.PreferredDataLocationName))
                ) && 
                (
                    this.EnableDynamicMembership == input.EnableDynamicMembership ||
                    this.EnableDynamicMembership.Equals(input.EnableDynamicMembership)
                ) && 
                (
                    this.GroupTeamSiteUrl == input.GroupTeamSiteUrl ||
                    (this.GroupTeamSiteUrl != null &&
                    this.GroupTeamSiteUrl.Equals(input.GroupTeamSiteUrl))
                ) && 
                (
                    this.TeamLink == input.TeamLink ||
                    (this.TeamLink != null &&
                    this.TeamLink.Equals(input.TeamLink))
                ) && 
                (
                    this.NoteBookLink == input.NoteBookLink ||
                    (this.NoteBookLink != null &&
                    this.NoteBookLink.Equals(input.NoteBookLink))
                ) && 
                (
                    this.PlannerLink == input.PlannerLink ||
                    (this.PlannerLink != null &&
                    this.PlannerLink.Equals(input.PlannerLink))
                ) && 
                (
                    this.Classification == input.Classification ||
                    (this.Classification != null &&
                    this.Classification.Equals(input.Classification))
                ) && 
                (
                    this.GroupObjectType == input.GroupObjectType ||
                    this.GroupObjectType.Equals(input.GroupObjectType)
                ) && 
                (
                    this.GroupObjectId == input.GroupObjectId ||
                    (this.GroupObjectId != null &&
                    this.GroupObjectId.Equals(input.GroupObjectId))
                ) && 
                (
                    this.NetworkId == input.NetworkId ||
                    (this.NetworkId != null &&
                    this.NetworkId.Equals(input.NetworkId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Phase == input.Phase ||
                    this.Phase.Equals(input.Phase)
                ) && 
                (
                    this.PhaseStartTime == input.PhaseStartTime ||
                    (this.PhaseStartTime != null &&
                    this.PhaseStartTime.Equals(input.PhaseStartTime))
                ) && 
                (
                    this.PhaseDescription == input.PhaseDescription ||
                    (this.PhaseDescription != null &&
                    this.PhaseDescription.Equals(input.PhaseDescription))
                ) && 
                (
                    this.AutoImportProfileId == input.AutoImportProfileId ||
                    (this.AutoImportProfileId != null &&
                    this.AutoImportProfileId.Equals(input.AutoImportProfileId))
                ) && 
                (
                    this.AutoImportProfileName == input.AutoImportProfileName ||
                    (this.AutoImportProfileName != null &&
                    this.AutoImportProfileName.Equals(input.AutoImportProfileName))
                ) && 
                (
                    this.PolicyName == input.PolicyName ||
                    (this.PolicyName != null &&
                    this.PolicyName.Equals(input.PolicyName))
                ) && 
                (
                    this.PolicyDescription == input.PolicyDescription ||
                    (this.PolicyDescription != null &&
                    this.PolicyDescription.Equals(input.PolicyDescription))
                ) && 
                (
                    this.IsCurrentRenewer == input.IsCurrentRenewer ||
                    this.IsCurrentRenewer.Equals(input.IsCurrentRenewer)
                ) && 
                (
                    this.PhaseAssignees == input.PhaseAssignees ||
                    this.PhaseAssignees != null &&
                    input.PhaseAssignees != null &&
                    this.PhaseAssignees.SequenceEqual(input.PhaseAssignees)
                ) && 
                (
                    this.PhaseDueDate == input.PhaseDueDate ||
                    (this.PhaseDueDate != null &&
                    this.PhaseDueDate.Equals(input.PhaseDueDate))
                ) && 
                (
                    this.Metadatas == input.Metadatas ||
                    this.Metadatas != null &&
                    input.Metadatas != null &&
                    this.Metadatas.SequenceEqual(input.Metadatas)
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
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
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
                if (this.ObjectId != null)
                    hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.PolicyId != null)
                    hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                hashCode = hashCode * 59 + this.ApplyPolicyStatus.GetHashCode();
                hashCode = hashCode * 59 + this.EnableTeamCollaboration.GetHashCode();
                if (this.GroupType != null)
                    hashCode = hashCode * 59 + this.GroupType.GetHashCode();
                if (this.CreatedTime != null)
                    hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.Owners != null)
                    hashCode = hashCode * 59 + this.Owners.GetHashCode();
                if (this.PreferredDataLocation != null)
                    hashCode = hashCode * 59 + this.PreferredDataLocation.GetHashCode();
                if (this.PreferredDataLocationName != null)
                    hashCode = hashCode * 59 + this.PreferredDataLocationName.GetHashCode();
                hashCode = hashCode * 59 + this.EnableDynamicMembership.GetHashCode();
                if (this.GroupTeamSiteUrl != null)
                    hashCode = hashCode * 59 + this.GroupTeamSiteUrl.GetHashCode();
                if (this.TeamLink != null)
                    hashCode = hashCode * 59 + this.TeamLink.GetHashCode();
                if (this.NoteBookLink != null)
                    hashCode = hashCode * 59 + this.NoteBookLink.GetHashCode();
                if (this.PlannerLink != null)
                    hashCode = hashCode * 59 + this.PlannerLink.GetHashCode();
                if (this.Classification != null)
                    hashCode = hashCode * 59 + this.Classification.GetHashCode();
                hashCode = hashCode * 59 + this.GroupObjectType.GetHashCode();
                if (this.GroupObjectId != null)
                    hashCode = hashCode * 59 + this.GroupObjectId.GetHashCode();
                if (this.NetworkId != null)
                    hashCode = hashCode * 59 + this.NetworkId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.Phase.GetHashCode();
                if (this.PhaseStartTime != null)
                    hashCode = hashCode * 59 + this.PhaseStartTime.GetHashCode();
                if (this.PhaseDescription != null)
                    hashCode = hashCode * 59 + this.PhaseDescription.GetHashCode();
                if (this.AutoImportProfileId != null)
                    hashCode = hashCode * 59 + this.AutoImportProfileId.GetHashCode();
                if (this.AutoImportProfileName != null)
                    hashCode = hashCode * 59 + this.AutoImportProfileName.GetHashCode();
                if (this.PolicyName != null)
                    hashCode = hashCode * 59 + this.PolicyName.GetHashCode();
                if (this.PolicyDescription != null)
                    hashCode = hashCode * 59 + this.PolicyDescription.GetHashCode();
                hashCode = hashCode * 59 + this.IsCurrentRenewer.GetHashCode();
                if (this.PhaseAssignees != null)
                    hashCode = hashCode * 59 + this.PhaseAssignees.GetHashCode();
                if (this.PhaseDueDate != null)
                    hashCode = hashCode * 59 + this.PhaseDueDate.GetHashCode();
                if (this.Metadatas != null)
                    hashCode = hashCode * 59 + this.Metadatas.GetHashCode();
                if (this.PrimaryContact != null)
                    hashCode = hashCode * 59 + this.PrimaryContact.GetHashCode();
                if (this.SecondaryContact != null)
                    hashCode = hashCode * 59 + this.SecondaryContact.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
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
