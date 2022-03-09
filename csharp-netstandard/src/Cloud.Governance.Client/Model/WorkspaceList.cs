

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
    /// WorkspaceList
    /// </summary>
    [DataContract(Name = "WorkspaceList")]
    public partial class WorkspaceList : IEquatable<WorkspaceList>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public WorkspaceType? Type { get; set; }
        /// <summary>
        /// Gets or Sets Phase
        /// </summary>
        [DataMember(Name = "phase", EmitDefaultValue = false)]
        public AutoImportPhase? Phase { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public SiteStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceList" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="type">type.</param>
        /// <param name="siteUrl">siteUrl.</param>
        /// <param name="groupEmail">groupEmail.</param>
        /// <param name="typeDescription">typeDescription.</param>
        /// <param name="primaryContact">primaryContact.</param>
        /// <param name="primaryContactEmail">primaryContactEmail.</param>
        /// <param name="phase">phase.</param>
        /// <param name="phaseDescription">phaseDescription.</param>
        /// <param name="isCurrentRenewer">isCurrentRenewer (default to false).</param>
        /// <param name="createdTime">createdTime.</param>
        /// <param name="status">status.</param>
        /// <param name="autoImportProfileId">autoImportProfileId.</param>
        /// <param name="pendingAction">pendingAction (default to 0).</param>
        /// <param name="secondaryContact">secondaryContact.</param>
        /// <param name="secondaryContactEmail">secondaryContactEmail.</param>
        /// <param name="policy">policy.</param>
        /// <param name="policyId">policyId.</param>
        /// <param name="description">description.</param>
        /// <param name="primaryAdmin">primaryAdmin.</param>
        /// <param name="primaryAdminEmail">primaryAdminEmail.</param>
        /// <param name="additionalAdmin">additionalAdmin.</param>
        /// <param name="additionalAdminEmail">additionalAdminEmail.</param>
        /// <param name="geoLocation">geoLocation.</param>
        /// <param name="geoLocationDescription">geoLocationDescription.</param>
        /// <param name="storageLimit">storageLimit.</param>
        /// <param name="storageUsage">storageUsage.</param>
        /// <param name="classification">classification.</param>
        /// <param name="privacy">privacy (default to false).</param>
        /// <param name="sensitivity">sensitivity.</param>
        /// <param name="privacyDescription">privacyDescription.</param>
        /// <param name="enableDynamicMembership">enableDynamicMembership (default to false).</param>
        /// <param name="enableDynamicMembershipDescription">enableDynamicMembershipDescription.</param>
        /// <param name="metadata">metadata.</param>
        public WorkspaceList(Guid id = default(Guid), string name = default(string), WorkspaceType? type = default(WorkspaceType?), string siteUrl = default(string), string groupEmail = default(string), string typeDescription = default(string), string primaryContact = default(string), string primaryContactEmail = default(string), AutoImportPhase? phase = default(AutoImportPhase?), string phaseDescription = default(string), bool isCurrentRenewer = false, DateTime createdTime = default(DateTime), SiteStatus? status = default(SiteStatus?), Guid autoImportProfileId = default(Guid), int pendingAction = 0, string secondaryContact = default(string), string secondaryContactEmail = default(string), string policy = default(string), Guid policyId = default(Guid), string description = default(string), string primaryAdmin = default(string), string primaryAdminEmail = default(string), string additionalAdmin = default(string), string additionalAdminEmail = default(string), string geoLocation = default(string), string geoLocationDescription = default(string), string storageLimit = default(string), string storageUsage = default(string), string classification = default(string), bool? privacy = false, string sensitivity = default(string), string privacyDescription = default(string), bool? enableDynamicMembership = false, string enableDynamicMembershipDescription = default(string), List<EndUserReportMetadata> metadata = default(List<EndUserReportMetadata>))
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.SiteUrl = siteUrl;
            this.GroupEmail = groupEmail;
            this.TypeDescription = typeDescription;
            this.PrimaryContact = primaryContact;
            this.PrimaryContactEmail = primaryContactEmail;
            this.Phase = phase;
            this.PhaseDescription = phaseDescription;
            this.IsCurrentRenewer = isCurrentRenewer;
            this.CreatedTime = createdTime;
            this.Status = status;
            this.AutoImportProfileId = autoImportProfileId;
            this.PendingAction = pendingAction;
            this.SecondaryContact = secondaryContact;
            this.SecondaryContactEmail = secondaryContactEmail;
            this.Policy = policy;
            this.PolicyId = policyId;
            this.Description = description;
            this.PrimaryAdmin = primaryAdmin;
            this.PrimaryAdminEmail = primaryAdminEmail;
            this.AdditionalAdmin = additionalAdmin;
            this.AdditionalAdminEmail = additionalAdminEmail;
            this.GeoLocation = geoLocation;
            this.GeoLocationDescription = geoLocationDescription;
            this.StorageLimit = storageLimit;
            this.StorageUsage = storageUsage;
            this.Classification = classification;
            // use default value if no "privacy" provided
            this.Privacy = privacy ?? false;
            this.Sensitivity = sensitivity;
            this.PrivacyDescription = privacyDescription;
            // use default value if no "enableDynamicMembership" provided
            this.EnableDynamicMembership = enableDynamicMembership ?? false;
            this.EnableDynamicMembershipDescription = enableDynamicMembershipDescription;
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
        /// Gets or Sets SiteUrl
        /// </summary>
        [DataMember(Name = "siteUrl", EmitDefaultValue = true)]
        public string SiteUrl { get; set; }

        /// <summary>
        /// Gets or Sets GroupEmail
        /// </summary>
        [DataMember(Name = "groupEmail", EmitDefaultValue = true)]
        public string GroupEmail { get; set; }

        /// <summary>
        /// Gets or Sets TypeDescription
        /// </summary>
        [DataMember(Name = "typeDescription", EmitDefaultValue = true)]
        public string TypeDescription { get; set; }

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
        /// Gets or Sets PhaseDescription
        /// </summary>
        [DataMember(Name = "phaseDescription", EmitDefaultValue = true)]
        public string PhaseDescription { get; set; }

        /// <summary>
        /// Gets or Sets IsCurrentRenewer
        /// </summary>
        [DataMember(Name = "isCurrentRenewer", EmitDefaultValue = false)]
        public bool IsCurrentRenewer { get; set; }

        /// <summary>
        /// Gets or Sets CreatedTime
        /// </summary>
        [DataMember(Name = "createdTime", EmitDefaultValue = false)]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// Gets or Sets AutoImportProfileId
        /// </summary>
        [DataMember(Name = "autoImportProfileId", EmitDefaultValue = false)]
        public Guid AutoImportProfileId { get; set; }

        /// <summary>
        /// Gets or Sets PendingAction
        /// </summary>
        [DataMember(Name = "pendingAction", EmitDefaultValue = false)]
        public int PendingAction { get; set; }

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
        /// Gets or Sets Policy
        /// </summary>
        [DataMember(Name = "policy", EmitDefaultValue = true)]
        public string Policy { get; set; }

        /// <summary>
        /// Gets or Sets PolicyId
        /// </summary>
        [DataMember(Name = "policyId", EmitDefaultValue = false)]
        public Guid PolicyId { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryAdmin
        /// </summary>
        [DataMember(Name = "primaryAdmin", EmitDefaultValue = true)]
        public string PrimaryAdmin { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryAdminEmail
        /// </summary>
        [DataMember(Name = "primaryAdminEmail", EmitDefaultValue = true)]
        public string PrimaryAdminEmail { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalAdmin
        /// </summary>
        [DataMember(Name = "additionalAdmin", EmitDefaultValue = true)]
        public string AdditionalAdmin { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalAdminEmail
        /// </summary>
        [DataMember(Name = "additionalAdminEmail", EmitDefaultValue = true)]
        public string AdditionalAdminEmail { get; set; }

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
        public string StorageLimit { get; set; }

        /// <summary>
        /// Gets or Sets StorageUsage
        /// </summary>
        [DataMember(Name = "storageUsage", EmitDefaultValue = true)]
        public string StorageUsage { get; set; }

        /// <summary>
        /// Gets or Sets Classification
        /// </summary>
        [DataMember(Name = "classification", EmitDefaultValue = true)]
        public string Classification { get; set; }

        /// <summary>
        /// Gets or Sets Privacy
        /// </summary>
        [DataMember(Name = "privacy", EmitDefaultValue = true)]
        public bool? Privacy { get; set; }

        /// <summary>
        /// Gets or Sets Sensitivity
        /// </summary>
        [DataMember(Name = "sensitivity", EmitDefaultValue = true)]
        public string Sensitivity { get; set; }

        /// <summary>
        /// Gets or Sets PrivacyDescription
        /// </summary>
        [DataMember(Name = "privacyDescription", EmitDefaultValue = true)]
        public string PrivacyDescription { get; set; }

        /// <summary>
        /// Gets or Sets EnableDynamicMembership
        /// </summary>
        [DataMember(Name = "enableDynamicMembership", EmitDefaultValue = true)]
        public bool? EnableDynamicMembership { get; set; }

        /// <summary>
        /// Gets or Sets EnableDynamicMembershipDescription
        /// </summary>
        [DataMember(Name = "enableDynamicMembershipDescription", EmitDefaultValue = true)]
        public string EnableDynamicMembershipDescription { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public List<EndUserReportMetadata> Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkspaceList {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SiteUrl: ").Append(SiteUrl).Append("\n");
            sb.Append("  GroupEmail: ").Append(GroupEmail).Append("\n");
            sb.Append("  TypeDescription: ").Append(TypeDescription).Append("\n");
            sb.Append("  PrimaryContact: ").Append(PrimaryContact).Append("\n");
            sb.Append("  PrimaryContactEmail: ").Append(PrimaryContactEmail).Append("\n");
            sb.Append("  Phase: ").Append(Phase).Append("\n");
            sb.Append("  PhaseDescription: ").Append(PhaseDescription).Append("\n");
            sb.Append("  IsCurrentRenewer: ").Append(IsCurrentRenewer).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  AutoImportProfileId: ").Append(AutoImportProfileId).Append("\n");
            sb.Append("  PendingAction: ").Append(PendingAction).Append("\n");
            sb.Append("  SecondaryContact: ").Append(SecondaryContact).Append("\n");
            sb.Append("  SecondaryContactEmail: ").Append(SecondaryContactEmail).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PrimaryAdmin: ").Append(PrimaryAdmin).Append("\n");
            sb.Append("  PrimaryAdminEmail: ").Append(PrimaryAdminEmail).Append("\n");
            sb.Append("  AdditionalAdmin: ").Append(AdditionalAdmin).Append("\n");
            sb.Append("  AdditionalAdminEmail: ").Append(AdditionalAdminEmail).Append("\n");
            sb.Append("  GeoLocation: ").Append(GeoLocation).Append("\n");
            sb.Append("  GeoLocationDescription: ").Append(GeoLocationDescription).Append("\n");
            sb.Append("  StorageLimit: ").Append(StorageLimit).Append("\n");
            sb.Append("  StorageUsage: ").Append(StorageUsage).Append("\n");
            sb.Append("  Classification: ").Append(Classification).Append("\n");
            sb.Append("  Privacy: ").Append(Privacy).Append("\n");
            sb.Append("  Sensitivity: ").Append(Sensitivity).Append("\n");
            sb.Append("  PrivacyDescription: ").Append(PrivacyDescription).Append("\n");
            sb.Append("  EnableDynamicMembership: ").Append(EnableDynamicMembership).Append("\n");
            sb.Append("  EnableDynamicMembershipDescription: ").Append(EnableDynamicMembershipDescription).Append("\n");
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
            return this.Equals(input as WorkspaceList);
        }

        /// <summary>
        /// Returns true if WorkspaceList instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkspaceList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkspaceList input)
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
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.SiteUrl == input.SiteUrl ||
                    (this.SiteUrl != null &&
                    this.SiteUrl.Equals(input.SiteUrl))
                ) && 
                (
                    this.GroupEmail == input.GroupEmail ||
                    (this.GroupEmail != null &&
                    this.GroupEmail.Equals(input.GroupEmail))
                ) && 
                (
                    this.TypeDescription == input.TypeDescription ||
                    (this.TypeDescription != null &&
                    this.TypeDescription.Equals(input.TypeDescription))
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
                    this.Phase == input.Phase ||
                    this.Phase.Equals(input.Phase)
                ) && 
                (
                    this.PhaseDescription == input.PhaseDescription ||
                    (this.PhaseDescription != null &&
                    this.PhaseDescription.Equals(input.PhaseDescription))
                ) && 
                (
                    this.IsCurrentRenewer == input.IsCurrentRenewer ||
                    this.IsCurrentRenewer.Equals(input.IsCurrentRenewer)
                ) && 
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.AutoImportProfileId == input.AutoImportProfileId ||
                    (this.AutoImportProfileId != null &&
                    this.AutoImportProfileId.Equals(input.AutoImportProfileId))
                ) && 
                (
                    this.PendingAction == input.PendingAction ||
                    this.PendingAction.Equals(input.PendingAction)
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
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))
                ) && 
                (
                    this.PolicyId == input.PolicyId ||
                    (this.PolicyId != null &&
                    this.PolicyId.Equals(input.PolicyId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.PrimaryAdmin == input.PrimaryAdmin ||
                    (this.PrimaryAdmin != null &&
                    this.PrimaryAdmin.Equals(input.PrimaryAdmin))
                ) && 
                (
                    this.PrimaryAdminEmail == input.PrimaryAdminEmail ||
                    (this.PrimaryAdminEmail != null &&
                    this.PrimaryAdminEmail.Equals(input.PrimaryAdminEmail))
                ) && 
                (
                    this.AdditionalAdmin == input.AdditionalAdmin ||
                    (this.AdditionalAdmin != null &&
                    this.AdditionalAdmin.Equals(input.AdditionalAdmin))
                ) && 
                (
                    this.AdditionalAdminEmail == input.AdditionalAdminEmail ||
                    (this.AdditionalAdminEmail != null &&
                    this.AdditionalAdminEmail.Equals(input.AdditionalAdminEmail))
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
                    this.StorageUsage == input.StorageUsage ||
                    (this.StorageUsage != null &&
                    this.StorageUsage.Equals(input.StorageUsage))
                ) && 
                (
                    this.Classification == input.Classification ||
                    (this.Classification != null &&
                    this.Classification.Equals(input.Classification))
                ) && 
                (
                    this.Privacy == input.Privacy ||
                    (this.Privacy != null &&
                    this.Privacy.Equals(input.Privacy))
                ) && 
                (
                    this.Sensitivity == input.Sensitivity ||
                    (this.Sensitivity != null &&
                    this.Sensitivity.Equals(input.Sensitivity))
                ) && 
                (
                    this.PrivacyDescription == input.PrivacyDescription ||
                    (this.PrivacyDescription != null &&
                    this.PrivacyDescription.Equals(input.PrivacyDescription))
                ) && 
                (
                    this.EnableDynamicMembership == input.EnableDynamicMembership ||
                    (this.EnableDynamicMembership != null &&
                    this.EnableDynamicMembership.Equals(input.EnableDynamicMembership))
                ) && 
                (
                    this.EnableDynamicMembershipDescription == input.EnableDynamicMembershipDescription ||
                    (this.EnableDynamicMembershipDescription != null &&
                    this.EnableDynamicMembershipDescription.Equals(input.EnableDynamicMembershipDescription))
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SiteUrl != null)
                    hashCode = hashCode * 59 + this.SiteUrl.GetHashCode();
                if (this.GroupEmail != null)
                    hashCode = hashCode * 59 + this.GroupEmail.GetHashCode();
                if (this.TypeDescription != null)
                    hashCode = hashCode * 59 + this.TypeDescription.GetHashCode();
                if (this.PrimaryContact != null)
                    hashCode = hashCode * 59 + this.PrimaryContact.GetHashCode();
                if (this.PrimaryContactEmail != null)
                    hashCode = hashCode * 59 + this.PrimaryContactEmail.GetHashCode();
                hashCode = hashCode * 59 + this.Phase.GetHashCode();
                if (this.PhaseDescription != null)
                    hashCode = hashCode * 59 + this.PhaseDescription.GetHashCode();
                hashCode = hashCode * 59 + this.IsCurrentRenewer.GetHashCode();
                if (this.CreatedTime != null)
                    hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.AutoImportProfileId != null)
                    hashCode = hashCode * 59 + this.AutoImportProfileId.GetHashCode();
                hashCode = hashCode * 59 + this.PendingAction.GetHashCode();
                if (this.SecondaryContact != null)
                    hashCode = hashCode * 59 + this.SecondaryContact.GetHashCode();
                if (this.SecondaryContactEmail != null)
                    hashCode = hashCode * 59 + this.SecondaryContactEmail.GetHashCode();
                if (this.Policy != null)
                    hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.PolicyId != null)
                    hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.PrimaryAdmin != null)
                    hashCode = hashCode * 59 + this.PrimaryAdmin.GetHashCode();
                if (this.PrimaryAdminEmail != null)
                    hashCode = hashCode * 59 + this.PrimaryAdminEmail.GetHashCode();
                if (this.AdditionalAdmin != null)
                    hashCode = hashCode * 59 + this.AdditionalAdmin.GetHashCode();
                if (this.AdditionalAdminEmail != null)
                    hashCode = hashCode * 59 + this.AdditionalAdminEmail.GetHashCode();
                if (this.GeoLocation != null)
                    hashCode = hashCode * 59 + this.GeoLocation.GetHashCode();
                if (this.GeoLocationDescription != null)
                    hashCode = hashCode * 59 + this.GeoLocationDescription.GetHashCode();
                if (this.StorageLimit != null)
                    hashCode = hashCode * 59 + this.StorageLimit.GetHashCode();
                if (this.StorageUsage != null)
                    hashCode = hashCode * 59 + this.StorageUsage.GetHashCode();
                if (this.Classification != null)
                    hashCode = hashCode * 59 + this.Classification.GetHashCode();
                if (this.Privacy != null)
                    hashCode = hashCode * 59 + this.Privacy.GetHashCode();
                if (this.Sensitivity != null)
                    hashCode = hashCode * 59 + this.Sensitivity.GetHashCode();
                if (this.PrivacyDescription != null)
                    hashCode = hashCode * 59 + this.PrivacyDescription.GetHashCode();
                if (this.EnableDynamicMembership != null)
                    hashCode = hashCode * 59 + this.EnableDynamicMembership.GetHashCode();
                if (this.EnableDynamicMembershipDescription != null)
                    hashCode = hashCode * 59 + this.EnableDynamicMembershipDescription.GetHashCode();
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
