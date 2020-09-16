

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
        /// <param name="isCurrentRenewer">isCurrentRenewer.</param>
        /// <param name="createdTime">createdTime.</param>
        /// <param name="status">status.</param>
        /// <param name="autoImportProfileId">autoImportProfileId.</param>
        /// <param name="pendingAction">pendingAction.</param>
        public WorkspaceList(Guid id = default(Guid), string name = default(string), WorkspaceType? type = default(WorkspaceType?), string siteUrl = default(string), string groupEmail = default(string), string typeDescription = default(string), string primaryContact = default(string), string primaryContactEmail = default(string), AutoImportPhase? phase = default(AutoImportPhase?), string phaseDescription = default(string), bool isCurrentRenewer = default(bool), DateTime createdTime = default(DateTime), SiteStatus? status = default(SiteStatus?), Guid autoImportProfileId = default(Guid), int pendingAction = default(int))
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
