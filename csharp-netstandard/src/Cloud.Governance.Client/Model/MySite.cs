

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
    /// MySite
    /// </summary>
    [DataContract(Name = "MySite")]
    public partial class MySite : IEquatable<MySite>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public MySiteType? Type { get; set; }
        /// <summary>
        /// Gets or Sets Phase
        /// </summary>
        [DataMember(Name = "phase", EmitDefaultValue = false)]
        public AutoImportPhase? Phase { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MySite" /> class.
        /// </summary>
        /// <param name="fullUrl">fullUrl.</param>
        /// <param name="title">title.</param>
        /// <param name="description">description.</param>
        /// <param name="size">size (default to 0).</param>
        /// <param name="quotaSize">quotaSize (default to 0).</param>
        /// <param name="type">type.</param>
        /// <param name="mySiteType">mySiteType.</param>
        /// <param name="classification">classification.</param>
        /// <param name="sensitivity">sensitivity.</param>
        /// <param name="isCommunicationSite">isCommunicationSite (default to false).</param>
        /// <param name="createdTime">createdTime.</param>
        /// <param name="storageUsed">storageUsed.</param>
        /// <param name="primaryAdministrator">ApiUser model.</param>
        /// <param name="additionalAdministrator">additionalAdministrator.</param>
        /// <param name="preferredDataLocation">preferredDataLocation.</param>
        /// <param name="preferredDataLocationName">preferredDataLocationName.</param>
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
        public MySite(string fullUrl = default(string), string title = default(string), string description = default(string), long? size = 0, long quotaSize = 0, MySiteType? type = default(MySiteType?), string mySiteType = default(string), string classification = default(string), string sensitivity = default(string), bool isCommunicationSite = false, DateTime createdTime = default(DateTime), string storageUsed = default(string), ApiUser primaryAdministrator = default(ApiUser), List<ApiUser> additionalAdministrator = default(List<ApiUser>), string preferredDataLocation = default(string), string preferredDataLocationName = default(string), Guid id = default(Guid), AutoImportPhase? phase = default(AutoImportPhase?), DateTime? phaseStartTime = default(DateTime?), string phaseDescription = default(string), Guid? autoImportProfileId = default(Guid?), string autoImportProfileName = default(string), string policyName = default(string), string policyDescription = default(string), bool isCurrentRenewer = false, List<ApiUser> phaseAssignees = default(List<ApiUser>), DateTime? phaseDueDate = default(DateTime?), List<RequestMetadata> metadatas = default(List<RequestMetadata>), ApiUser primaryContact = default(ApiUser), ApiUser secondaryContact = default(ApiUser), string errorMessage = default(string))
        {
            this.FullUrl = fullUrl;
            this.Title = title;
            this.Description = description;
            // use default value if no "size" provided
            this.Size = size ?? 0;
            this.QuotaSize = quotaSize;
            this.Type = type;
            this.MySiteType = mySiteType;
            this.Classification = classification;
            this.Sensitivity = sensitivity;
            this.IsCommunicationSite = isCommunicationSite;
            this.CreatedTime = createdTime;
            this.StorageUsed = storageUsed;
            this.PrimaryAdministrator = primaryAdministrator;
            this.AdditionalAdministrator = additionalAdministrator;
            this.PreferredDataLocation = preferredDataLocation;
            this.PreferredDataLocationName = preferredDataLocationName;
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
        /// Gets or Sets FullUrl
        /// </summary>
        [DataMember(Name = "fullUrl", EmitDefaultValue = true)]
        public string FullUrl { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = true)]
        public long? Size { get; set; }

        /// <summary>
        /// Gets or Sets QuotaSize
        /// </summary>
        [DataMember(Name = "quotaSize", EmitDefaultValue = false)]
        public long QuotaSize { get; set; }

        /// <summary>
        /// Gets or Sets MySiteType
        /// </summary>
        [DataMember(Name = "mySiteType", EmitDefaultValue = true)]
        public string MySiteType { get; set; }

        /// <summary>
        /// Gets or Sets Classification
        /// </summary>
        [DataMember(Name = "classification", EmitDefaultValue = true)]
        public string Classification { get; set; }

        /// <summary>
        /// Gets or Sets Sensitivity
        /// </summary>
        [DataMember(Name = "sensitivity", EmitDefaultValue = true)]
        public string Sensitivity { get; set; }

        /// <summary>
        /// Gets or Sets IsCommunicationSite
        /// </summary>
        [DataMember(Name = "isCommunicationSite", EmitDefaultValue = false)]
        public bool IsCommunicationSite { get; set; }

        /// <summary>
        /// Gets or Sets CreatedTime
        /// </summary>
        [DataMember(Name = "createdTime", EmitDefaultValue = false)]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// Gets or Sets StorageUsed
        /// </summary>
        [DataMember(Name = "storageUsed", EmitDefaultValue = true)]
        public string StorageUsed { get; set; }

        /// <summary>
        /// ApiUser model
        /// </summary>
        /// <value>ApiUser model</value>
        [DataMember(Name = "primaryAdministrator", EmitDefaultValue = true)]
        public ApiUser PrimaryAdministrator { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalAdministrator
        /// </summary>
        [DataMember(Name = "additionalAdministrator", EmitDefaultValue = true)]
        public List<ApiUser> AdditionalAdministrator { get; set; }

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
            sb.Append("class MySite {\n");
            sb.Append("  FullUrl: ").Append(FullUrl).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  QuotaSize: ").Append(QuotaSize).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MySiteType: ").Append(MySiteType).Append("\n");
            sb.Append("  Classification: ").Append(Classification).Append("\n");
            sb.Append("  Sensitivity: ").Append(Sensitivity).Append("\n");
            sb.Append("  IsCommunicationSite: ").Append(IsCommunicationSite).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  StorageUsed: ").Append(StorageUsed).Append("\n");
            sb.Append("  PrimaryAdministrator: ").Append(PrimaryAdministrator).Append("\n");
            sb.Append("  AdditionalAdministrator: ").Append(AdditionalAdministrator).Append("\n");
            sb.Append("  PreferredDataLocation: ").Append(PreferredDataLocation).Append("\n");
            sb.Append("  PreferredDataLocationName: ").Append(PreferredDataLocationName).Append("\n");
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
            return this.Equals(input as MySite);
        }

        /// <summary>
        /// Returns true if MySite instances are equal
        /// </summary>
        /// <param name="input">Instance of MySite to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MySite input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FullUrl == input.FullUrl ||
                    (this.FullUrl != null &&
                    this.FullUrl.Equals(input.FullUrl))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.QuotaSize == input.QuotaSize ||
                    this.QuotaSize.Equals(input.QuotaSize)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.MySiteType == input.MySiteType ||
                    (this.MySiteType != null &&
                    this.MySiteType.Equals(input.MySiteType))
                ) && 
                (
                    this.Classification == input.Classification ||
                    (this.Classification != null &&
                    this.Classification.Equals(input.Classification))
                ) && 
                (
                    this.Sensitivity == input.Sensitivity ||
                    (this.Sensitivity != null &&
                    this.Sensitivity.Equals(input.Sensitivity))
                ) && 
                (
                    this.IsCommunicationSite == input.IsCommunicationSite ||
                    this.IsCommunicationSite.Equals(input.IsCommunicationSite)
                ) && 
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
                ) && 
                (
                    this.StorageUsed == input.StorageUsed ||
                    (this.StorageUsed != null &&
                    this.StorageUsed.Equals(input.StorageUsed))
                ) && 
                (
                    this.PrimaryAdministrator == input.PrimaryAdministrator ||
                    (this.PrimaryAdministrator != null &&
                    this.PrimaryAdministrator.Equals(input.PrimaryAdministrator))
                ) && 
                (
                    this.AdditionalAdministrator == input.AdditionalAdministrator ||
                    this.AdditionalAdministrator != null &&
                    input.AdditionalAdministrator != null &&
                    this.AdditionalAdministrator.SequenceEqual(input.AdditionalAdministrator)
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
                if (this.FullUrl != null)
                    hashCode = hashCode * 59 + this.FullUrl.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                hashCode = hashCode * 59 + this.QuotaSize.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.MySiteType != null)
                    hashCode = hashCode * 59 + this.MySiteType.GetHashCode();
                if (this.Classification != null)
                    hashCode = hashCode * 59 + this.Classification.GetHashCode();
                if (this.Sensitivity != null)
                    hashCode = hashCode * 59 + this.Sensitivity.GetHashCode();
                hashCode = hashCode * 59 + this.IsCommunicationSite.GetHashCode();
                if (this.CreatedTime != null)
                    hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.StorageUsed != null)
                    hashCode = hashCode * 59 + this.StorageUsed.GetHashCode();
                if (this.PrimaryAdministrator != null)
                    hashCode = hashCode * 59 + this.PrimaryAdministrator.GetHashCode();
                if (this.AdditionalAdministrator != null)
                    hashCode = hashCode * 59 + this.AdditionalAdministrator.GetHashCode();
                if (this.PreferredDataLocation != null)
                    hashCode = hashCode * 59 + this.PreferredDataLocation.GetHashCode();
                if (this.PreferredDataLocationName != null)
                    hashCode = hashCode * 59 + this.PreferredDataLocationName.GetHashCode();
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
