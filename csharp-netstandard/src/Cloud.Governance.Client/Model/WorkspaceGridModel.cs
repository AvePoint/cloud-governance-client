

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
    /// WorkspaceGridModel
    /// </summary>
    [DataContract(Name = "WorkspaceGridModel")]
    public partial class WorkspaceGridModel : IEquatable<WorkspaceGridModel>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public WorkspaceStatus? Status { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public WorkspaceType? Type { get; set; }
        /// <summary>
        /// Gets or Sets HubType
        /// </summary>
        [DataMember(Name = "hubType", EmitDefaultValue = false)]
        public HubSiteType? HubType { get; set; }
        /// <summary>
        /// Gets or Sets SiteSharing
        /// </summary>
        [DataMember(Name = "siteSharing", EmitDefaultValue = false)]
        public SiteSharingStatus? SiteSharing { get; set; }
        /// <summary>
        /// Gets or Sets GroupSharing
        /// </summary>
        [DataMember(Name = "groupSharing", EmitDefaultValue = false)]
        public GroupEnableSharingStatus? GroupSharing { get; set; }
        /// <summary>
        /// Gets or Sets ClaimStatus
        /// </summary>
        [DataMember(Name = "claimStatus", EmitDefaultValue = false)]
        public ClaimStatus? ClaimStatus { get; set; }
        /// <summary>
        /// Gets or Sets Phase
        /// </summary>
        [DataMember(Name = "phase", EmitDefaultValue = false)]
        public AutoImportPhase? Phase { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceGridModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="status">status.</param>
        /// <param name="statusDescription">statusDescription.</param>
        /// <param name="type">type.</param>
        /// <param name="typeDescription">typeDescription.</param>
        /// <param name="url">url.</param>
        /// <param name="email">email.</param>
        /// <param name="privacy">privacy.</param>
        /// <param name="privacyDescription">privacyDescription.</param>
        /// <param name="policyName">policyName.</param>
        /// <param name="policyId">policyId.</param>
        /// <param name="primaryAdministrators">primaryAdministrators.</param>
        /// <param name="primaryAdministratorDisplayNames">primaryAdministratorDisplayNames.</param>
        /// <param name="additionalAdministrators">additionalAdministrators.</param>
        /// <param name="additionalAdministratorDisplayNames">additionalAdministratorDisplayNames.</param>
        /// <param name="primaryContact">primaryContact.</param>
        /// <param name="primaryContactEmail">primaryContactEmail.</param>
        /// <param name="primaryContactDisplayName">primaryContactDisplayName.</param>
        /// <param name="secondaryContact">secondaryContact.</param>
        /// <param name="secondaryContactEmail">secondaryContactEmail.</param>
        /// <param name="secondaryContactDisplayName">secondaryContactDisplayName.</param>
        /// <param name="hubType">hubType.</param>
        /// <param name="associateHubTitle">associateHubTitle.</param>
        /// <param name="geoLocation">geoLocation.</param>
        /// <param name="geoLocationDescription">geoLocationDescription.</param>
        /// <param name="storageLimit">storageLimit.</param>
        /// <param name="storageUsed">storageUsed.</param>
        /// <param name="siteSharing">siteSharing.</param>
        /// <param name="siteSharingDescription">siteSharingDescription.</param>
        /// <param name="groupSharing">groupSharing.</param>
        /// <param name="groupSharingDescription">groupSharingDescription.</param>
        /// <param name="classification">classification.</param>
        /// <param name="claimStatus">claimStatus.</param>
        /// <param name="claimStatusDescription">claimStatusDescription.</param>
        /// <param name="createdTime">createdTime.</param>
        /// <param name="leaseExpirationTime">leaseExpirationTime.</param>
        /// <param name="inactivityThresholdTime">inactivityThresholdTime.</param>
        /// <param name="phaseAssigneeDisplayNames">phaseAssigneeDisplayNames.</param>
        /// <param name="phaseAssignees">phaseAssignees.</param>
        /// <param name="phaseProfileName">phaseProfileName.</param>
        /// <param name="phaseProfileId">phaseProfileId.</param>
        /// <param name="phaseStartTime">phaseStartTime.</param>
        /// <param name="renewalDueDate">renewalDueDate.</param>
        /// <param name="nextRenewalDate">nextRenewalDate.</param>
        /// <param name="phase">phase.</param>
        /// <param name="phaseDescription">phaseDescription.</param>
        /// <param name="metadata">metadata.</param>
        public WorkspaceGridModel(Guid id = default(Guid), string name = default(string), string description = default(string), WorkspaceStatus? status = default(WorkspaceStatus?), string statusDescription = default(string), WorkspaceType? type = default(WorkspaceType?), string typeDescription = default(string), string url = default(string), string email = default(string), bool? privacy = default(bool?), string privacyDescription = default(string), string policyName = default(string), Guid? policyId = default(Guid?), string primaryAdministrators = default(string), string primaryAdministratorDisplayNames = default(string), string additionalAdministrators = default(string), string additionalAdministratorDisplayNames = default(string), string primaryContact = default(string), string primaryContactEmail = default(string), string primaryContactDisplayName = default(string), string secondaryContact = default(string), string secondaryContactEmail = default(string), string secondaryContactDisplayName = default(string), HubSiteType? hubType = default(HubSiteType?), string associateHubTitle = default(string), string geoLocation = default(string), string geoLocationDescription = default(string), long? storageLimit = default(long?), double? storageUsed = default(double?), SiteSharingStatus? siteSharing = default(SiteSharingStatus?), string siteSharingDescription = default(string), GroupEnableSharingStatus? groupSharing = default(GroupEnableSharingStatus?), string groupSharingDescription = default(string), string classification = default(string), ClaimStatus? claimStatus = default(ClaimStatus?), string claimStatusDescription = default(string), DateTime createdTime = default(DateTime), DateTime? leaseExpirationTime = default(DateTime?), DateTime? inactivityThresholdTime = default(DateTime?), string phaseAssigneeDisplayNames = default(string), string phaseAssignees = default(string), string phaseProfileName = default(string), Guid? phaseProfileId = default(Guid?), DateTime? phaseStartTime = default(DateTime?), DateTime? renewalDueDate = default(DateTime?), DateTime? nextRenewalDate = default(DateTime?), AutoImportPhase? phase = default(AutoImportPhase?), string phaseDescription = default(string), List<ReportMetadata> metadata = default(List<ReportMetadata>))
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Status = status;
            this.StatusDescription = statusDescription;
            this.Type = type;
            this.TypeDescription = typeDescription;
            this.Url = url;
            this.Email = email;
            this.Privacy = privacy;
            this.PrivacyDescription = privacyDescription;
            this.PolicyName = policyName;
            this.PolicyId = policyId;
            this.PrimaryAdministrators = primaryAdministrators;
            this.PrimaryAdministratorDisplayNames = primaryAdministratorDisplayNames;
            this.AdditionalAdministrators = additionalAdministrators;
            this.AdditionalAdministratorDisplayNames = additionalAdministratorDisplayNames;
            this.PrimaryContact = primaryContact;
            this.PrimaryContactEmail = primaryContactEmail;
            this.PrimaryContactDisplayName = primaryContactDisplayName;
            this.SecondaryContact = secondaryContact;
            this.SecondaryContactEmail = secondaryContactEmail;
            this.SecondaryContactDisplayName = secondaryContactDisplayName;
            this.HubType = hubType;
            this.AssociateHubTitle = associateHubTitle;
            this.GeoLocation = geoLocation;
            this.GeoLocationDescription = geoLocationDescription;
            this.StorageLimit = storageLimit;
            this.StorageUsed = storageUsed;
            this.SiteSharing = siteSharing;
            this.SiteSharingDescription = siteSharingDescription;
            this.GroupSharing = groupSharing;
            this.GroupSharingDescription = groupSharingDescription;
            this.Classification = classification;
            this.ClaimStatus = claimStatus;
            this.ClaimStatusDescription = claimStatusDescription;
            this.CreatedTime = createdTime;
            this.LeaseExpirationTime = leaseExpirationTime;
            this.InactivityThresholdTime = inactivityThresholdTime;
            this.PhaseAssigneeDisplayNames = phaseAssigneeDisplayNames;
            this.PhaseAssignees = phaseAssignees;
            this.PhaseProfileName = phaseProfileName;
            this.PhaseProfileId = phaseProfileId;
            this.PhaseStartTime = phaseStartTime;
            this.RenewalDueDate = renewalDueDate;
            this.NextRenewalDate = nextRenewalDate;
            this.Phase = phase;
            this.PhaseDescription = phaseDescription;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets StatusDescription
        /// </summary>
        [DataMember(Name = "statusDescription", EmitDefaultValue = true)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Gets or Sets TypeDescription
        /// </summary>
        [DataMember(Name = "typeDescription", EmitDefaultValue = true)]
        public string TypeDescription { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Privacy
        /// </summary>
        [DataMember(Name = "privacy", EmitDefaultValue = true)]
        public bool? Privacy { get; set; }

        /// <summary>
        /// Gets or Sets PrivacyDescription
        /// </summary>
        [DataMember(Name = "privacyDescription", EmitDefaultValue = true)]
        public string PrivacyDescription { get; set; }

        /// <summary>
        /// Gets or Sets PolicyName
        /// </summary>
        [DataMember(Name = "policyName", EmitDefaultValue = true)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Gets or Sets PolicyId
        /// </summary>
        [DataMember(Name = "policyId", EmitDefaultValue = true)]
        public Guid? PolicyId { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryAdministrators
        /// </summary>
        [DataMember(Name = "primaryAdministrators", EmitDefaultValue = true)]
        public string PrimaryAdministrators { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryAdministratorDisplayNames
        /// </summary>
        [DataMember(Name = "primaryAdministratorDisplayNames", EmitDefaultValue = true)]
        public string PrimaryAdministratorDisplayNames { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalAdministrators
        /// </summary>
        [DataMember(Name = "additionalAdministrators", EmitDefaultValue = true)]
        public string AdditionalAdministrators { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalAdministratorDisplayNames
        /// </summary>
        [DataMember(Name = "additionalAdministratorDisplayNames", EmitDefaultValue = true)]
        public string AdditionalAdministratorDisplayNames { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryContact
        /// </summary>
        [DataMember(Name = "primaryContact", EmitDefaultValue = true)]
        public string PrimaryContact { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryContactEmail
        /// </summary>
        [DataMember(Name = "primaryContactEmail", EmitDefaultValue = true)]
        public string PrimaryContactEmail { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryContactDisplayName
        /// </summary>
        [DataMember(Name = "primaryContactDisplayName", EmitDefaultValue = true)]
        public string PrimaryContactDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryContact
        /// </summary>
        [DataMember(Name = "secondaryContact", EmitDefaultValue = true)]
        public string SecondaryContact { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryContactEmail
        /// </summary>
        [DataMember(Name = "secondaryContactEmail", EmitDefaultValue = true)]
        public string SecondaryContactEmail { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryContactDisplayName
        /// </summary>
        [DataMember(Name = "secondaryContactDisplayName", EmitDefaultValue = true)]
        public string SecondaryContactDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets AssociateHubTitle
        /// </summary>
        [DataMember(Name = "associateHubTitle", EmitDefaultValue = true)]
        public string AssociateHubTitle { get; set; }

        /// <summary>
        /// Gets or Sets GeoLocation
        /// </summary>
        [DataMember(Name = "geoLocation", EmitDefaultValue = true)]
        public string GeoLocation { get; set; }

        /// <summary>
        /// Gets or Sets GeoLocationDescription
        /// </summary>
        [DataMember(Name = "geoLocationDescription", EmitDefaultValue = true)]
        public string GeoLocationDescription { get; set; }

        /// <summary>
        /// Gets or Sets StorageLimit
        /// </summary>
        [DataMember(Name = "storageLimit", EmitDefaultValue = true)]
        public long? StorageLimit { get; set; }

        /// <summary>
        /// Gets or Sets StorageUsed
        /// </summary>
        [DataMember(Name = "storageUsed", EmitDefaultValue = true)]
        public double? StorageUsed { get; set; }

        /// <summary>
        /// Gets or Sets SiteSharingDescription
        /// </summary>
        [DataMember(Name = "siteSharingDescription", EmitDefaultValue = true)]
        public string SiteSharingDescription { get; set; }

        /// <summary>
        /// Gets or Sets GroupSharingDescription
        /// </summary>
        [DataMember(Name = "groupSharingDescription", EmitDefaultValue = true)]
        public string GroupSharingDescription { get; set; }

        /// <summary>
        /// Gets or Sets Classification
        /// </summary>
        [DataMember(Name = "classification", EmitDefaultValue = true)]
        public string Classification { get; set; }

        /// <summary>
        /// Gets or Sets ClaimStatusDescription
        /// </summary>
        [DataMember(Name = "claimStatusDescription", EmitDefaultValue = true)]
        public string ClaimStatusDescription { get; set; }

        /// <summary>
        /// Gets or Sets CreatedTime
        /// </summary>
        [DataMember(Name = "createdTime", EmitDefaultValue = false)]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// Gets or Sets LeaseExpirationTime
        /// </summary>
        [DataMember(Name = "leaseExpirationTime", EmitDefaultValue = true)]
        public DateTime? LeaseExpirationTime { get; set; }

        /// <summary>
        /// Gets or Sets InactivityThresholdTime
        /// </summary>
        [DataMember(Name = "inactivityThresholdTime", EmitDefaultValue = true)]
        public DateTime? InactivityThresholdTime { get; set; }

        /// <summary>
        /// Gets or Sets PhaseAssigneeDisplayNames
        /// </summary>
        [DataMember(Name = "phaseAssigneeDisplayNames", EmitDefaultValue = true)]
        public string PhaseAssigneeDisplayNames { get; set; }

        /// <summary>
        /// Gets or Sets PhaseAssignees
        /// </summary>
        [DataMember(Name = "phaseAssignees", EmitDefaultValue = true)]
        public string PhaseAssignees { get; set; }

        /// <summary>
        /// Gets or Sets PhaseProfileName
        /// </summary>
        [DataMember(Name = "phaseProfileName", EmitDefaultValue = true)]
        public string PhaseProfileName { get; set; }

        /// <summary>
        /// Gets or Sets PhaseProfileId
        /// </summary>
        [DataMember(Name = "phaseProfileId", EmitDefaultValue = true)]
        public Guid? PhaseProfileId { get; set; }

        /// <summary>
        /// Gets or Sets PhaseStartTime
        /// </summary>
        [DataMember(Name = "phaseStartTime", EmitDefaultValue = true)]
        public DateTime? PhaseStartTime { get; set; }

        /// <summary>
        /// Gets or Sets RenewalDueDate
        /// </summary>
        [DataMember(Name = "renewalDueDate", EmitDefaultValue = true)]
        public DateTime? RenewalDueDate { get; set; }

        /// <summary>
        /// Gets or Sets NextRenewalDate
        /// </summary>
        [DataMember(Name = "nextRenewalDate", EmitDefaultValue = true)]
        public DateTime? NextRenewalDate { get; set; }

        /// <summary>
        /// Gets or Sets PhaseDescription
        /// </summary>
        [DataMember(Name = "phaseDescription", EmitDefaultValue = true)]
        public string PhaseDescription { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public List<ReportMetadata> Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkspaceGridModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TypeDescription: ").Append(TypeDescription).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Privacy: ").Append(Privacy).Append("\n");
            sb.Append("  PrivacyDescription: ").Append(PrivacyDescription).Append("\n");
            sb.Append("  PolicyName: ").Append(PolicyName).Append("\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
            sb.Append("  PrimaryAdministrators: ").Append(PrimaryAdministrators).Append("\n");
            sb.Append("  PrimaryAdministratorDisplayNames: ").Append(PrimaryAdministratorDisplayNames).Append("\n");
            sb.Append("  AdditionalAdministrators: ").Append(AdditionalAdministrators).Append("\n");
            sb.Append("  AdditionalAdministratorDisplayNames: ").Append(AdditionalAdministratorDisplayNames).Append("\n");
            sb.Append("  PrimaryContact: ").Append(PrimaryContact).Append("\n");
            sb.Append("  PrimaryContactEmail: ").Append(PrimaryContactEmail).Append("\n");
            sb.Append("  PrimaryContactDisplayName: ").Append(PrimaryContactDisplayName).Append("\n");
            sb.Append("  SecondaryContact: ").Append(SecondaryContact).Append("\n");
            sb.Append("  SecondaryContactEmail: ").Append(SecondaryContactEmail).Append("\n");
            sb.Append("  SecondaryContactDisplayName: ").Append(SecondaryContactDisplayName).Append("\n");
            sb.Append("  HubType: ").Append(HubType).Append("\n");
            sb.Append("  AssociateHubTitle: ").Append(AssociateHubTitle).Append("\n");
            sb.Append("  GeoLocation: ").Append(GeoLocation).Append("\n");
            sb.Append("  GeoLocationDescription: ").Append(GeoLocationDescription).Append("\n");
            sb.Append("  StorageLimit: ").Append(StorageLimit).Append("\n");
            sb.Append("  StorageUsed: ").Append(StorageUsed).Append("\n");
            sb.Append("  SiteSharing: ").Append(SiteSharing).Append("\n");
            sb.Append("  SiteSharingDescription: ").Append(SiteSharingDescription).Append("\n");
            sb.Append("  GroupSharing: ").Append(GroupSharing).Append("\n");
            sb.Append("  GroupSharingDescription: ").Append(GroupSharingDescription).Append("\n");
            sb.Append("  Classification: ").Append(Classification).Append("\n");
            sb.Append("  ClaimStatus: ").Append(ClaimStatus).Append("\n");
            sb.Append("  ClaimStatusDescription: ").Append(ClaimStatusDescription).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  LeaseExpirationTime: ").Append(LeaseExpirationTime).Append("\n");
            sb.Append("  InactivityThresholdTime: ").Append(InactivityThresholdTime).Append("\n");
            sb.Append("  PhaseAssigneeDisplayNames: ").Append(PhaseAssigneeDisplayNames).Append("\n");
            sb.Append("  PhaseAssignees: ").Append(PhaseAssignees).Append("\n");
            sb.Append("  PhaseProfileName: ").Append(PhaseProfileName).Append("\n");
            sb.Append("  PhaseProfileId: ").Append(PhaseProfileId).Append("\n");
            sb.Append("  PhaseStartTime: ").Append(PhaseStartTime).Append("\n");
            sb.Append("  RenewalDueDate: ").Append(RenewalDueDate).Append("\n");
            sb.Append("  NextRenewalDate: ").Append(NextRenewalDate).Append("\n");
            sb.Append("  Phase: ").Append(Phase).Append("\n");
            sb.Append("  PhaseDescription: ").Append(PhaseDescription).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as WorkspaceGridModel);
        }

        /// <summary>
        /// Returns true if WorkspaceGridModel instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkspaceGridModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkspaceGridModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.StatusDescription == input.StatusDescription ||
                    (this.StatusDescription != null &&
                    this.StatusDescription.Equals(input.StatusDescription))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.TypeDescription == input.TypeDescription ||
                    (this.TypeDescription != null &&
                    this.TypeDescription.Equals(input.TypeDescription))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Privacy == input.Privacy ||
                    (this.Privacy != null &&
                    this.Privacy.Equals(input.Privacy))
                ) && 
                (
                    this.PrivacyDescription == input.PrivacyDescription ||
                    (this.PrivacyDescription != null &&
                    this.PrivacyDescription.Equals(input.PrivacyDescription))
                ) && 
                (
                    this.PolicyName == input.PolicyName ||
                    (this.PolicyName != null &&
                    this.PolicyName.Equals(input.PolicyName))
                ) && 
                (
                    this.PolicyId == input.PolicyId ||
                    (this.PolicyId != null &&
                    this.PolicyId.Equals(input.PolicyId))
                ) && 
                (
                    this.PrimaryAdministrators == input.PrimaryAdministrators ||
                    (this.PrimaryAdministrators != null &&
                    this.PrimaryAdministrators.Equals(input.PrimaryAdministrators))
                ) && 
                (
                    this.PrimaryAdministratorDisplayNames == input.PrimaryAdministratorDisplayNames ||
                    (this.PrimaryAdministratorDisplayNames != null &&
                    this.PrimaryAdministratorDisplayNames.Equals(input.PrimaryAdministratorDisplayNames))
                ) && 
                (
                    this.AdditionalAdministrators == input.AdditionalAdministrators ||
                    (this.AdditionalAdministrators != null &&
                    this.AdditionalAdministrators.Equals(input.AdditionalAdministrators))
                ) && 
                (
                    this.AdditionalAdministratorDisplayNames == input.AdditionalAdministratorDisplayNames ||
                    (this.AdditionalAdministratorDisplayNames != null &&
                    this.AdditionalAdministratorDisplayNames.Equals(input.AdditionalAdministratorDisplayNames))
                ) && 
                (
                    this.PrimaryContact == input.PrimaryContact ||
                    (this.PrimaryContact != null &&
                    this.PrimaryContact.Equals(input.PrimaryContact))
                ) && 
                (
                    this.PrimaryContactEmail == input.PrimaryContactEmail ||
                    (this.PrimaryContactEmail != null &&
                    this.PrimaryContactEmail.Equals(input.PrimaryContactEmail))
                ) && 
                (
                    this.PrimaryContactDisplayName == input.PrimaryContactDisplayName ||
                    (this.PrimaryContactDisplayName != null &&
                    this.PrimaryContactDisplayName.Equals(input.PrimaryContactDisplayName))
                ) && 
                (
                    this.SecondaryContact == input.SecondaryContact ||
                    (this.SecondaryContact != null &&
                    this.SecondaryContact.Equals(input.SecondaryContact))
                ) && 
                (
                    this.SecondaryContactEmail == input.SecondaryContactEmail ||
                    (this.SecondaryContactEmail != null &&
                    this.SecondaryContactEmail.Equals(input.SecondaryContactEmail))
                ) && 
                (
                    this.SecondaryContactDisplayName == input.SecondaryContactDisplayName ||
                    (this.SecondaryContactDisplayName != null &&
                    this.SecondaryContactDisplayName.Equals(input.SecondaryContactDisplayName))
                ) && 
                (
                    this.HubType == input.HubType ||
                    this.HubType.Equals(input.HubType)
                ) && 
                (
                    this.AssociateHubTitle == input.AssociateHubTitle ||
                    (this.AssociateHubTitle != null &&
                    this.AssociateHubTitle.Equals(input.AssociateHubTitle))
                ) && 
                (
                    this.GeoLocation == input.GeoLocation ||
                    (this.GeoLocation != null &&
                    this.GeoLocation.Equals(input.GeoLocation))
                ) && 
                (
                    this.GeoLocationDescription == input.GeoLocationDescription ||
                    (this.GeoLocationDescription != null &&
                    this.GeoLocationDescription.Equals(input.GeoLocationDescription))
                ) && 
                (
                    this.StorageLimit == input.StorageLimit ||
                    (this.StorageLimit != null &&
                    this.StorageLimit.Equals(input.StorageLimit))
                ) && 
                (
                    this.StorageUsed == input.StorageUsed ||
                    (this.StorageUsed != null &&
                    this.StorageUsed.Equals(input.StorageUsed))
                ) && 
                (
                    this.SiteSharing == input.SiteSharing ||
                    this.SiteSharing.Equals(input.SiteSharing)
                ) && 
                (
                    this.SiteSharingDescription == input.SiteSharingDescription ||
                    (this.SiteSharingDescription != null &&
                    this.SiteSharingDescription.Equals(input.SiteSharingDescription))
                ) && 
                (
                    this.GroupSharing == input.GroupSharing ||
                    this.GroupSharing.Equals(input.GroupSharing)
                ) && 
                (
                    this.GroupSharingDescription == input.GroupSharingDescription ||
                    (this.GroupSharingDescription != null &&
                    this.GroupSharingDescription.Equals(input.GroupSharingDescription))
                ) && 
                (
                    this.Classification == input.Classification ||
                    (this.Classification != null &&
                    this.Classification.Equals(input.Classification))
                ) && 
                (
                    this.ClaimStatus == input.ClaimStatus ||
                    this.ClaimStatus.Equals(input.ClaimStatus)
                ) && 
                (
                    this.ClaimStatusDescription == input.ClaimStatusDescription ||
                    (this.ClaimStatusDescription != null &&
                    this.ClaimStatusDescription.Equals(input.ClaimStatusDescription))
                ) && 
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
                ) && 
                (
                    this.LeaseExpirationTime == input.LeaseExpirationTime ||
                    (this.LeaseExpirationTime != null &&
                    this.LeaseExpirationTime.Equals(input.LeaseExpirationTime))
                ) && 
                (
                    this.InactivityThresholdTime == input.InactivityThresholdTime ||
                    (this.InactivityThresholdTime != null &&
                    this.InactivityThresholdTime.Equals(input.InactivityThresholdTime))
                ) && 
                (
                    this.PhaseAssigneeDisplayNames == input.PhaseAssigneeDisplayNames ||
                    (this.PhaseAssigneeDisplayNames != null &&
                    this.PhaseAssigneeDisplayNames.Equals(input.PhaseAssigneeDisplayNames))
                ) && 
                (
                    this.PhaseAssignees == input.PhaseAssignees ||
                    (this.PhaseAssignees != null &&
                    this.PhaseAssignees.Equals(input.PhaseAssignees))
                ) && 
                (
                    this.PhaseProfileName == input.PhaseProfileName ||
                    (this.PhaseProfileName != null &&
                    this.PhaseProfileName.Equals(input.PhaseProfileName))
                ) && 
                (
                    this.PhaseProfileId == input.PhaseProfileId ||
                    (this.PhaseProfileId != null &&
                    this.PhaseProfileId.Equals(input.PhaseProfileId))
                ) && 
                (
                    this.PhaseStartTime == input.PhaseStartTime ||
                    (this.PhaseStartTime != null &&
                    this.PhaseStartTime.Equals(input.PhaseStartTime))
                ) && 
                (
                    this.RenewalDueDate == input.RenewalDueDate ||
                    (this.RenewalDueDate != null &&
                    this.RenewalDueDate.Equals(input.RenewalDueDate))
                ) && 
                (
                    this.NextRenewalDate == input.NextRenewalDate ||
                    (this.NextRenewalDate != null &&
                    this.NextRenewalDate.Equals(input.NextRenewalDate))
                ) && 
                (
                    this.Phase == input.Phase ||
                    this.Phase.Equals(input.Phase)
                ) && 
                (
                    this.PhaseDescription == input.PhaseDescription ||
                    (this.PhaseDescription != null &&
                    this.PhaseDescription.Equals(input.PhaseDescription))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusDescription != null)
                    hashCode = hashCode * 59 + this.StatusDescription.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TypeDescription != null)
                    hashCode = hashCode * 59 + this.TypeDescription.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Privacy != null)
                    hashCode = hashCode * 59 + this.Privacy.GetHashCode();
                if (this.PrivacyDescription != null)
                    hashCode = hashCode * 59 + this.PrivacyDescription.GetHashCode();
                if (this.PolicyName != null)
                    hashCode = hashCode * 59 + this.PolicyName.GetHashCode();
                if (this.PolicyId != null)
                    hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
                if (this.PrimaryAdministrators != null)
                    hashCode = hashCode * 59 + this.PrimaryAdministrators.GetHashCode();
                if (this.PrimaryAdministratorDisplayNames != null)
                    hashCode = hashCode * 59 + this.PrimaryAdministratorDisplayNames.GetHashCode();
                if (this.AdditionalAdministrators != null)
                    hashCode = hashCode * 59 + this.AdditionalAdministrators.GetHashCode();
                if (this.AdditionalAdministratorDisplayNames != null)
                    hashCode = hashCode * 59 + this.AdditionalAdministratorDisplayNames.GetHashCode();
                if (this.PrimaryContact != null)
                    hashCode = hashCode * 59 + this.PrimaryContact.GetHashCode();
                if (this.PrimaryContactEmail != null)
                    hashCode = hashCode * 59 + this.PrimaryContactEmail.GetHashCode();
                if (this.PrimaryContactDisplayName != null)
                    hashCode = hashCode * 59 + this.PrimaryContactDisplayName.GetHashCode();
                if (this.SecondaryContact != null)
                    hashCode = hashCode * 59 + this.SecondaryContact.GetHashCode();
                if (this.SecondaryContactEmail != null)
                    hashCode = hashCode * 59 + this.SecondaryContactEmail.GetHashCode();
                if (this.SecondaryContactDisplayName != null)
                    hashCode = hashCode * 59 + this.SecondaryContactDisplayName.GetHashCode();
                hashCode = hashCode * 59 + this.HubType.GetHashCode();
                if (this.AssociateHubTitle != null)
                    hashCode = hashCode * 59 + this.AssociateHubTitle.GetHashCode();
                if (this.GeoLocation != null)
                    hashCode = hashCode * 59 + this.GeoLocation.GetHashCode();
                if (this.GeoLocationDescription != null)
                    hashCode = hashCode * 59 + this.GeoLocationDescription.GetHashCode();
                if (this.StorageLimit != null)
                    hashCode = hashCode * 59 + this.StorageLimit.GetHashCode();
                if (this.StorageUsed != null)
                    hashCode = hashCode * 59 + this.StorageUsed.GetHashCode();
                hashCode = hashCode * 59 + this.SiteSharing.GetHashCode();
                if (this.SiteSharingDescription != null)
                    hashCode = hashCode * 59 + this.SiteSharingDescription.GetHashCode();
                hashCode = hashCode * 59 + this.GroupSharing.GetHashCode();
                if (this.GroupSharingDescription != null)
                    hashCode = hashCode * 59 + this.GroupSharingDescription.GetHashCode();
                if (this.Classification != null)
                    hashCode = hashCode * 59 + this.Classification.GetHashCode();
                hashCode = hashCode * 59 + this.ClaimStatus.GetHashCode();
                if (this.ClaimStatusDescription != null)
                    hashCode = hashCode * 59 + this.ClaimStatusDescription.GetHashCode();
                if (this.CreatedTime != null)
                    hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.LeaseExpirationTime != null)
                    hashCode = hashCode * 59 + this.LeaseExpirationTime.GetHashCode();
                if (this.InactivityThresholdTime != null)
                    hashCode = hashCode * 59 + this.InactivityThresholdTime.GetHashCode();
                if (this.PhaseAssigneeDisplayNames != null)
                    hashCode = hashCode * 59 + this.PhaseAssigneeDisplayNames.GetHashCode();
                if (this.PhaseAssignees != null)
                    hashCode = hashCode * 59 + this.PhaseAssignees.GetHashCode();
                if (this.PhaseProfileName != null)
                    hashCode = hashCode * 59 + this.PhaseProfileName.GetHashCode();
                if (this.PhaseProfileId != null)
                    hashCode = hashCode * 59 + this.PhaseProfileId.GetHashCode();
                if (this.PhaseStartTime != null)
                    hashCode = hashCode * 59 + this.PhaseStartTime.GetHashCode();
                if (this.RenewalDueDate != null)
                    hashCode = hashCode * 59 + this.RenewalDueDate.GetHashCode();
                if (this.NextRenewalDate != null)
                    hashCode = hashCode * 59 + this.NextRenewalDate.GetHashCode();
                hashCode = hashCode * 59 + this.Phase.GetHashCode();
                if (this.PhaseDescription != null)
                    hashCode = hashCode * 59 + this.PhaseDescription.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
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
