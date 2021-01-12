

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
    /// WorkspaceReport
    /// </summary>
    [DataContract(Name = "WorkspaceReport")]
    public partial class WorkspaceReport : IEquatable<WorkspaceReport>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceReport" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="status">status.</param>
        /// <param name="type">type.</param>
        /// <param name="url">url.</param>
        /// <param name="email">email.</param>
        /// <param name="policyName">policyName.</param>
        /// <param name="primaryContact">primaryContact.</param>
        /// <param name="primaryContactEmail">primaryContactEmail.</param>
        /// <param name="primaryContactDisplayName">primaryContactDisplayName.</param>
        /// <param name="secondaryContact">secondaryContact.</param>
        /// <param name="secondaryContactEmail">secondaryContactEmail.</param>
        /// <param name="secondaryContactDisplayName">secondaryContactDisplayName.</param>
        /// <param name="primaryAdministrators">primaryAdministrators.</param>
        /// <param name="primaryAdministratorDisplayNames">primaryAdministratorDisplayNames.</param>
        /// <param name="additionalAdministrators">additionalAdministrators.</param>
        /// <param name="additionalAdministratorDisplayNames">additionalAdministratorDisplayNames.</param>
        /// <param name="phase">phase.</param>
        /// <param name="phaseAssigneeDisplayNames">phaseAssigneeDisplayNames.</param>
        /// <param name="phaseAssignees">phaseAssignees.</param>
        /// <param name="phaseProfileName">phaseProfileName.</param>
        /// <param name="phaseStartTime">phaseStartTime.</param>
        /// <param name="renewalDueDate">renewalDueDate.</param>
        /// <param name="nextRenewalDate">nextRenewalDate.</param>
        /// <param name="privacy">privacy.</param>
        /// <param name="associateHubTitle">associateHubTitle.</param>
        /// <param name="geoLocation">geoLocation.</param>
        /// <param name="storageLimit">storageLimit.</param>
        /// <param name="storageUsed">storageUsed.</param>
        /// <param name="siteSharing">siteSharing.</param>
        /// <param name="groupSharing">groupSharing.</param>
        /// <param name="classification">classification.</param>
        /// <param name="claimStatus">claimStatus.</param>
        /// <param name="createdTime">createdTime.</param>
        /// <param name="leaseExpirationTime">leaseExpirationTime.</param>
        /// <param name="inactivityThresholdTime">inactivityThresholdTime.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="hasOngoingTasks">hasOngoingTasks.</param>
        /// <param name="lastRenewalTime">lastRenewalTime.</param>
        public WorkspaceReport(string id = default(string), string name = default(string), string description = default(string), string status = default(string), string type = default(string), string url = default(string), string email = default(string), string policyName = default(string), string primaryContact = default(string), string primaryContactEmail = default(string), string primaryContactDisplayName = default(string), string secondaryContact = default(string), string secondaryContactEmail = default(string), string secondaryContactDisplayName = default(string), string primaryAdministrators = default(string), string primaryAdministratorDisplayNames = default(string), string additionalAdministrators = default(string), string additionalAdministratorDisplayNames = default(string), string phase = default(string), string phaseAssigneeDisplayNames = default(string), string phaseAssignees = default(string), string phaseProfileName = default(string), DateTime? phaseStartTime = default(DateTime?), DateTime? renewalDueDate = default(DateTime?), DateTime? nextRenewalDate = default(DateTime?), string privacy = default(string), string associateHubTitle = default(string), string geoLocation = default(string), long? storageLimit = default(long?), double? storageUsed = default(double?), string siteSharing = default(string), string groupSharing = default(string), string classification = default(string), string claimStatus = default(string), DateTime createdTime = default(DateTime), DateTime? leaseExpirationTime = default(DateTime?), DateTime? inactivityThresholdTime = default(DateTime?), Dictionary<string, string> metadata = default(Dictionary<string, string>), string hasOngoingTasks = default(string), DateTime? lastRenewalTime = default(DateTime?))
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Status = status;
            this.Type = type;
            this.Url = url;
            this.Email = email;
            this.PolicyName = policyName;
            this.PrimaryContact = primaryContact;
            this.PrimaryContactEmail = primaryContactEmail;
            this.PrimaryContactDisplayName = primaryContactDisplayName;
            this.SecondaryContact = secondaryContact;
            this.SecondaryContactEmail = secondaryContactEmail;
            this.SecondaryContactDisplayName = secondaryContactDisplayName;
            this.PrimaryAdministrators = primaryAdministrators;
            this.PrimaryAdministratorDisplayNames = primaryAdministratorDisplayNames;
            this.AdditionalAdministrators = additionalAdministrators;
            this.AdditionalAdministratorDisplayNames = additionalAdministratorDisplayNames;
            this.Phase = phase;
            this.PhaseAssigneeDisplayNames = phaseAssigneeDisplayNames;
            this.PhaseAssignees = phaseAssignees;
            this.PhaseProfileName = phaseProfileName;
            this.PhaseStartTime = phaseStartTime;
            this.RenewalDueDate = renewalDueDate;
            this.NextRenewalDate = nextRenewalDate;
            this.Privacy = privacy;
            this.AssociateHubTitle = associateHubTitle;
            this.GeoLocation = geoLocation;
            this.StorageLimit = storageLimit;
            this.StorageUsed = storageUsed;
            this.SiteSharing = siteSharing;
            this.GroupSharing = groupSharing;
            this.Classification = classification;
            this.ClaimStatus = claimStatus;
            this.CreatedTime = createdTime;
            this.LeaseExpirationTime = leaseExpirationTime;
            this.InactivityThresholdTime = inactivityThresholdTime;
            this.Metadata = metadata;
            this.HasOngoingTasks = hasOngoingTasks;
            this.LastRenewalTime = lastRenewalTime;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "Id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "Description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "Status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "Type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "Url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "Email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets PolicyName
        /// </summary>
        [DataMember(Name = "PolicyName", EmitDefaultValue = true)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryContact
        /// </summary>
        [DataMember(Name = "PrimaryContact", EmitDefaultValue = true)]
        public string PrimaryContact { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryContactEmail
        /// </summary>
        [DataMember(Name = "PrimaryContactEmail", EmitDefaultValue = true)]
        public string PrimaryContactEmail { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryContactDisplayName
        /// </summary>
        [DataMember(Name = "PrimaryContactDisplayName", EmitDefaultValue = true)]
        public string PrimaryContactDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryContact
        /// </summary>
        [DataMember(Name = "SecondaryContact", EmitDefaultValue = true)]
        public string SecondaryContact { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryContactEmail
        /// </summary>
        [DataMember(Name = "SecondaryContactEmail", EmitDefaultValue = true)]
        public string SecondaryContactEmail { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryContactDisplayName
        /// </summary>
        [DataMember(Name = "SecondaryContactDisplayName", EmitDefaultValue = true)]
        public string SecondaryContactDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryAdministrators
        /// </summary>
        [DataMember(Name = "PrimaryAdministrators", EmitDefaultValue = true)]
        public string PrimaryAdministrators { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryAdministratorDisplayNames
        /// </summary>
        [DataMember(Name = "PrimaryAdministratorDisplayNames", EmitDefaultValue = true)]
        public string PrimaryAdministratorDisplayNames { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalAdministrators
        /// </summary>
        [DataMember(Name = "AdditionalAdministrators", EmitDefaultValue = true)]
        public string AdditionalAdministrators { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalAdministratorDisplayNames
        /// </summary>
        [DataMember(Name = "AdditionalAdministratorDisplayNames", EmitDefaultValue = true)]
        public string AdditionalAdministratorDisplayNames { get; set; }

        /// <summary>
        /// Gets or Sets Phase
        /// </summary>
        [DataMember(Name = "Phase", EmitDefaultValue = true)]
        public string Phase { get; set; }

        /// <summary>
        /// Gets or Sets PhaseAssigneeDisplayNames
        /// </summary>
        [DataMember(Name = "PhaseAssigneeDisplayNames", EmitDefaultValue = true)]
        public string PhaseAssigneeDisplayNames { get; set; }

        /// <summary>
        /// Gets or Sets PhaseAssignees
        /// </summary>
        [DataMember(Name = "PhaseAssignees", EmitDefaultValue = true)]
        public string PhaseAssignees { get; set; }

        /// <summary>
        /// Gets or Sets PhaseProfileName
        /// </summary>
        [DataMember(Name = "PhaseProfileName", EmitDefaultValue = true)]
        public string PhaseProfileName { get; set; }

        /// <summary>
        /// Gets or Sets PhaseStartTime
        /// </summary>
        [DataMember(Name = "PhaseStartTime", EmitDefaultValue = true)]
        public DateTime? PhaseStartTime { get; set; }

        /// <summary>
        /// Gets or Sets RenewalDueDate
        /// </summary>
        [DataMember(Name = "RenewalDueDate", EmitDefaultValue = true)]
        public DateTime? RenewalDueDate { get; set; }

        /// <summary>
        /// Gets or Sets NextRenewalDate
        /// </summary>
        [DataMember(Name = "NextRenewalDate", EmitDefaultValue = true)]
        public DateTime? NextRenewalDate { get; set; }

        /// <summary>
        /// Gets or Sets Privacy
        /// </summary>
        [DataMember(Name = "Privacy", EmitDefaultValue = true)]
        public string Privacy { get; set; }

        /// <summary>
        /// Gets or Sets AssociateHubTitle
        /// </summary>
        [DataMember(Name = "AssociateHubTitle", EmitDefaultValue = true)]
        public string AssociateHubTitle { get; set; }

        /// <summary>
        /// Gets or Sets GeoLocation
        /// </summary>
        [DataMember(Name = "GeoLocation", EmitDefaultValue = true)]
        public string GeoLocation { get; set; }

        /// <summary>
        /// Gets or Sets StorageLimit
        /// </summary>
        [DataMember(Name = "StorageLimit", EmitDefaultValue = true)]
        public long? StorageLimit { get; set; }

        /// <summary>
        /// Gets or Sets StorageUsed
        /// </summary>
        [DataMember(Name = "StorageUsed", EmitDefaultValue = true)]
        public double? StorageUsed { get; set; }

        /// <summary>
        /// Gets or Sets SiteSharing
        /// </summary>
        [DataMember(Name = "SiteSharing", EmitDefaultValue = true)]
        public string SiteSharing { get; set; }

        /// <summary>
        /// Gets or Sets GroupSharing
        /// </summary>
        [DataMember(Name = "GroupSharing", EmitDefaultValue = true)]
        public string GroupSharing { get; set; }

        /// <summary>
        /// Gets or Sets Classification
        /// </summary>
        [DataMember(Name = "Classification", EmitDefaultValue = true)]
        public string Classification { get; set; }

        /// <summary>
        /// Gets or Sets ClaimStatus
        /// </summary>
        [DataMember(Name = "ClaimStatus", EmitDefaultValue = true)]
        public string ClaimStatus { get; set; }

        /// <summary>
        /// Gets or Sets CreatedTime
        /// </summary>
        [DataMember(Name = "CreatedTime", EmitDefaultValue = false)]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// Gets or Sets LeaseExpirationTime
        /// </summary>
        [DataMember(Name = "LeaseExpirationTime", EmitDefaultValue = true)]
        public DateTime? LeaseExpirationTime { get; set; }

        /// <summary>
        /// Gets or Sets InactivityThresholdTime
        /// </summary>
        [DataMember(Name = "InactivityThresholdTime", EmitDefaultValue = true)]
        public DateTime? InactivityThresholdTime { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "Metadata", EmitDefaultValue = true)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets HasOngoingTasks
        /// </summary>
        [DataMember(Name = "HasOngoingTasks", EmitDefaultValue = true)]
        public string HasOngoingTasks { get; set; }

        /// <summary>
        /// Gets or Sets LastRenewalTime
        /// </summary>
        [DataMember(Name = "LastRenewalTime", EmitDefaultValue = true)]
        public DateTime? LastRenewalTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkspaceReport {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  PolicyName: ").Append(PolicyName).Append("\n");
            sb.Append("  PrimaryContact: ").Append(PrimaryContact).Append("\n");
            sb.Append("  PrimaryContactEmail: ").Append(PrimaryContactEmail).Append("\n");
            sb.Append("  PrimaryContactDisplayName: ").Append(PrimaryContactDisplayName).Append("\n");
            sb.Append("  SecondaryContact: ").Append(SecondaryContact).Append("\n");
            sb.Append("  SecondaryContactEmail: ").Append(SecondaryContactEmail).Append("\n");
            sb.Append("  SecondaryContactDisplayName: ").Append(SecondaryContactDisplayName).Append("\n");
            sb.Append("  PrimaryAdministrators: ").Append(PrimaryAdministrators).Append("\n");
            sb.Append("  PrimaryAdministratorDisplayNames: ").Append(PrimaryAdministratorDisplayNames).Append("\n");
            sb.Append("  AdditionalAdministrators: ").Append(AdditionalAdministrators).Append("\n");
            sb.Append("  AdditionalAdministratorDisplayNames: ").Append(AdditionalAdministratorDisplayNames).Append("\n");
            sb.Append("  Phase: ").Append(Phase).Append("\n");
            sb.Append("  PhaseAssigneeDisplayNames: ").Append(PhaseAssigneeDisplayNames).Append("\n");
            sb.Append("  PhaseAssignees: ").Append(PhaseAssignees).Append("\n");
            sb.Append("  PhaseProfileName: ").Append(PhaseProfileName).Append("\n");
            sb.Append("  PhaseStartTime: ").Append(PhaseStartTime).Append("\n");
            sb.Append("  RenewalDueDate: ").Append(RenewalDueDate).Append("\n");
            sb.Append("  NextRenewalDate: ").Append(NextRenewalDate).Append("\n");
            sb.Append("  Privacy: ").Append(Privacy).Append("\n");
            sb.Append("  AssociateHubTitle: ").Append(AssociateHubTitle).Append("\n");
            sb.Append("  GeoLocation: ").Append(GeoLocation).Append("\n");
            sb.Append("  StorageLimit: ").Append(StorageLimit).Append("\n");
            sb.Append("  StorageUsed: ").Append(StorageUsed).Append("\n");
            sb.Append("  SiteSharing: ").Append(SiteSharing).Append("\n");
            sb.Append("  GroupSharing: ").Append(GroupSharing).Append("\n");
            sb.Append("  Classification: ").Append(Classification).Append("\n");
            sb.Append("  ClaimStatus: ").Append(ClaimStatus).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  LeaseExpirationTime: ").Append(LeaseExpirationTime).Append("\n");
            sb.Append("  InactivityThresholdTime: ").Append(InactivityThresholdTime).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  HasOngoingTasks: ").Append(HasOngoingTasks).Append("\n");
            sb.Append("  LastRenewalTime: ").Append(LastRenewalTime).Append("\n");
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
            return this.Equals(input as WorkspaceReport);
        }

        /// <summary>
        /// Returns true if WorkspaceReport instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkspaceReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkspaceReport input)
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
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                    this.PolicyName == input.PolicyName ||
                    (this.PolicyName != null &&
                    this.PolicyName.Equals(input.PolicyName))
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
                    this.Phase == input.Phase ||
                    (this.Phase != null &&
                    this.Phase.Equals(input.Phase))
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
                    this.Privacy == input.Privacy ||
                    (this.Privacy != null &&
                    this.Privacy.Equals(input.Privacy))
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
                    (this.SiteSharing != null &&
                    this.SiteSharing.Equals(input.SiteSharing))
                ) && 
                (
                    this.GroupSharing == input.GroupSharing ||
                    (this.GroupSharing != null &&
                    this.GroupSharing.Equals(input.GroupSharing))
                ) && 
                (
                    this.Classification == input.Classification ||
                    (this.Classification != null &&
                    this.Classification.Equals(input.Classification))
                ) && 
                (
                    this.ClaimStatus == input.ClaimStatus ||
                    (this.ClaimStatus != null &&
                    this.ClaimStatus.Equals(input.ClaimStatus))
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
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.HasOngoingTasks == input.HasOngoingTasks ||
                    (this.HasOngoingTasks != null &&
                    this.HasOngoingTasks.Equals(input.HasOngoingTasks))
                ) && 
                (
                    this.LastRenewalTime == input.LastRenewalTime ||
                    (this.LastRenewalTime != null &&
                    this.LastRenewalTime.Equals(input.LastRenewalTime))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.PolicyName != null)
                    hashCode = hashCode * 59 + this.PolicyName.GetHashCode();
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
                if (this.PrimaryAdministrators != null)
                    hashCode = hashCode * 59 + this.PrimaryAdministrators.GetHashCode();
                if (this.PrimaryAdministratorDisplayNames != null)
                    hashCode = hashCode * 59 + this.PrimaryAdministratorDisplayNames.GetHashCode();
                if (this.AdditionalAdministrators != null)
                    hashCode = hashCode * 59 + this.AdditionalAdministrators.GetHashCode();
                if (this.AdditionalAdministratorDisplayNames != null)
                    hashCode = hashCode * 59 + this.AdditionalAdministratorDisplayNames.GetHashCode();
                if (this.Phase != null)
                    hashCode = hashCode * 59 + this.Phase.GetHashCode();
                if (this.PhaseAssigneeDisplayNames != null)
                    hashCode = hashCode * 59 + this.PhaseAssigneeDisplayNames.GetHashCode();
                if (this.PhaseAssignees != null)
                    hashCode = hashCode * 59 + this.PhaseAssignees.GetHashCode();
                if (this.PhaseProfileName != null)
                    hashCode = hashCode * 59 + this.PhaseProfileName.GetHashCode();
                if (this.PhaseStartTime != null)
                    hashCode = hashCode * 59 + this.PhaseStartTime.GetHashCode();
                if (this.RenewalDueDate != null)
                    hashCode = hashCode * 59 + this.RenewalDueDate.GetHashCode();
                if (this.NextRenewalDate != null)
                    hashCode = hashCode * 59 + this.NextRenewalDate.GetHashCode();
                if (this.Privacy != null)
                    hashCode = hashCode * 59 + this.Privacy.GetHashCode();
                if (this.AssociateHubTitle != null)
                    hashCode = hashCode * 59 + this.AssociateHubTitle.GetHashCode();
                if (this.GeoLocation != null)
                    hashCode = hashCode * 59 + this.GeoLocation.GetHashCode();
                if (this.StorageLimit != null)
                    hashCode = hashCode * 59 + this.StorageLimit.GetHashCode();
                if (this.StorageUsed != null)
                    hashCode = hashCode * 59 + this.StorageUsed.GetHashCode();
                if (this.SiteSharing != null)
                    hashCode = hashCode * 59 + this.SiteSharing.GetHashCode();
                if (this.GroupSharing != null)
                    hashCode = hashCode * 59 + this.GroupSharing.GetHashCode();
                if (this.Classification != null)
                    hashCode = hashCode * 59 + this.Classification.GetHashCode();
                if (this.ClaimStatus != null)
                    hashCode = hashCode * 59 + this.ClaimStatus.GetHashCode();
                if (this.CreatedTime != null)
                    hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.LeaseExpirationTime != null)
                    hashCode = hashCode * 59 + this.LeaseExpirationTime.GetHashCode();
                if (this.InactivityThresholdTime != null)
                    hashCode = hashCode * 59 + this.InactivityThresholdTime.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.HasOngoingTasks != null)
                    hashCode = hashCode * 59 + this.HasOngoingTasks.GetHashCode();
                if (this.LastRenewalTime != null)
                    hashCode = hashCode * 59 + this.LastRenewalTime.GetHashCode();
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
