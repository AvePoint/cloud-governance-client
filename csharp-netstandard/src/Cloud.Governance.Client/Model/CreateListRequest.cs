

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
    /// CreateListRequest
    /// </summary>
    [DataContract(Name = "CreateListRequest")]
    public partial class CreateListRequest : IEquatable<CreateListRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ListType
        /// </summary>
        [DataMember(Name = "listType", EmitDefaultValue = false)]
        public ListType? ListType { get; set; }
        /// <summary>
        /// Service type of request.
        /// </summary>
        /// <value>Service type of request.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public ServiceType? Type { get; set; }

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
        {
            return false;
        }
        /// <summary>
        /// Status of request.
        /// </summary>
        /// <value>Status of request.</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public RequestStatus? Status { get; set; }

        /// <summary>
        /// Returns false as Status should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStatus()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateListRequest" /> class.
        /// </summary>
        /// <param name="listTitle">listTitle.</param>
        /// <param name="listName">listName.</param>
        /// <param name="listDescription">listDescription.</param>
        /// <param name="parentObject">parentObject.</param>
        /// <param name="listTemplate">listTemplate.</param>
        /// <param name="enableNavigation">enableNavigation (default to false).</param>
        /// <param name="listType">listType.</param>
        /// <param name="versionSettings">versionSettings.</param>
        /// <param name="permissionSettings">permissionSettings.</param>
        /// <param name="id">Id of request..</param>
        /// <param name="serviceId">Id of service..</param>
        /// <param name="summary">Summary of request..</param>
        /// <param name="notesToApprovers">Notes to approvers..</param>
        /// <param name="questionnaireId">Id of questionnaire.</param>
        /// <param name="metadatas">Metadata of request..</param>
        public CreateListRequest(string listTitle = default(string), string listName = default(string), string listDescription = default(string), CreateListSPObject parentObject = default(CreateListSPObject), string listTemplate = default(string), bool enableNavigation = false, ListType? listType = default(ListType?), ListVersionSettings versionSettings = default(ListVersionSettings), ListPermissionSettings permissionSettings = default(ListPermissionSettings), Guid? id = default(Guid?), Guid serviceId = default(Guid), string summary = default(string), string notesToApprovers = default(string), Guid? questionnaireId = default(Guid?), List<RequestMetadata> metadatas = default(List<RequestMetadata>))
        {
            this.ListTitle = listTitle;
            this.ListName = listName;
            this.ListDescription = listDescription;
            this.ParentObject = parentObject;
            this.ListTemplate = listTemplate;
            this.EnableNavigation = enableNavigation;
            this.ListType = listType;
            this.VersionSettings = versionSettings;
            this.PermissionSettings = permissionSettings;
            this.Id = id;
            this.ServiceId = serviceId;
            this.Summary = summary;
            this.NotesToApprovers = notesToApprovers;
            this.QuestionnaireId = questionnaireId;
            this.Metadatas = metadatas;
        }

        /// <summary>
        /// Gets or Sets ListTitle
        /// </summary>
        [DataMember(Name = "listTitle", EmitDefaultValue = true)]
        public string ListTitle { get; set; }

        /// <summary>
        /// Gets or Sets ListName
        /// </summary>
        [DataMember(Name = "listName", EmitDefaultValue = true)]
        public string ListName { get; set; }

        /// <summary>
        /// Gets or Sets ListDescription
        /// </summary>
        [DataMember(Name = "listDescription", EmitDefaultValue = true)]
        public string ListDescription { get; set; }

        /// <summary>
        /// Gets or Sets ParentObject
        /// </summary>
        [DataMember(Name = "parentObject", EmitDefaultValue = true)]
        public CreateListSPObject ParentObject { get; set; }

        /// <summary>
        /// Gets or Sets ListTemplate
        /// </summary>
        [DataMember(Name = "listTemplate", EmitDefaultValue = true)]
        public string ListTemplate { get; set; }

        /// <summary>
        /// Gets or Sets EnableNavigation
        /// </summary>
        [DataMember(Name = "enableNavigation", EmitDefaultValue = false)]
        public bool EnableNavigation { get; set; }

        /// <summary>
        /// Gets or Sets VersionSettings
        /// </summary>
        [DataMember(Name = "versionSettings", EmitDefaultValue = true)]
        public ListVersionSettings VersionSettings { get; set; }

        /// <summary>
        /// Gets or Sets PermissionSettings
        /// </summary>
        [DataMember(Name = "permissionSettings", EmitDefaultValue = true)]
        public ListPermissionSettings PermissionSettings { get; set; }

        /// <summary>
        /// Id of request.
        /// </summary>
        /// <value>Id of request.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Id of service.
        /// </summary>
        /// <value>Id of service.</value>
        [DataMember(Name = "serviceId", EmitDefaultValue = false)]
        public Guid ServiceId { get; set; }

        /// <summary>
        /// Summary of request.
        /// </summary>
        /// <value>Summary of request.</value>
        [DataMember(Name = "summary", EmitDefaultValue = true)]
        public string Summary { get; set; }

        /// <summary>
        /// Notes to approvers.
        /// </summary>
        /// <value>Notes to approvers.</value>
        [DataMember(Name = "notesToApprovers", EmitDefaultValue = true)]
        public string NotesToApprovers { get; set; }

        /// <summary>
        /// Id of questionnaire
        /// </summary>
        /// <value>Id of questionnaire</value>
        [DataMember(Name = "questionnaireId", EmitDefaultValue = true)]
        public Guid? QuestionnaireId { get; set; }

        /// <summary>
        /// Metadata of request.
        /// </summary>
        /// <value>Metadata of request.</value>
        [DataMember(Name = "metadatas", EmitDefaultValue = true)]
        public List<RequestMetadata> Metadatas { get; set; }

        /// <summary>
        /// Ticket number of request.
        /// </summary>
        /// <value>Ticket number of request.</value>
        [DataMember(Name = "ticketNumber", EmitDefaultValue = true)]
        public int? TicketNumber { get; private set; }

        /// <summary>
        /// Returns false as TicketNumber should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTicketNumber()
        {
            return false;
        }

        /// <summary>
        /// Service type description of request.
        /// </summary>
        /// <value>Service type description of request.</value>
        [DataMember(Name = "typeDescription", EmitDefaultValue = true)]
        public string TypeDescription { get; private set; }

        /// <summary>
        /// Returns false as TypeDescription should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTypeDescription()
        {
            return false;
        }

        /// <summary>
        /// Requester display name.
        /// </summary>
        /// <value>Requester display name.</value>
        [DataMember(Name = "requester", EmitDefaultValue = true)]
        public string Requester { get; private set; }

        /// <summary>
        /// Returns false as Requester should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRequester()
        {
            return false;
        }

        /// <summary>
        /// Requester login name.
        /// </summary>
        /// <value>Requester login name.</value>
        [DataMember(Name = "requesterLoginName", EmitDefaultValue = true)]
        public string RequesterLoginName { get; private set; }

        /// <summary>
        /// Returns false as RequesterLoginName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRequesterLoginName()
        {
            return false;
        }

        /// <summary>
        /// Progress status of request.
        /// </summary>
        /// <value>Progress status of request.</value>
        [DataMember(Name = "progressStatus", EmitDefaultValue = false)]
        public int ProgressStatus { get; private set; }

        /// <summary>
        /// Returns false as ProgressStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProgressStatus()
        {
            return false;
        }

        /// <summary>
        /// Progress status description of request.
        /// </summary>
        /// <value>Progress status description of request.</value>
        [DataMember(Name = "progressStatusDescription", EmitDefaultValue = true)]
        public string ProgressStatusDescription { get; private set; }

        /// <summary>
        /// Returns false as ProgressStatusDescription should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProgressStatusDescription()
        {
            return false;
        }

        /// <summary>
        /// Submitted time of request.
        /// </summary>
        /// <value>Submitted time of request.</value>
        [DataMember(Name = "submittedTime", EmitDefaultValue = true)]
        public DateTime? SubmittedTime { get; private set; }

        /// <summary>
        /// Returns false as SubmittedTime should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSubmittedTime()
        {
            return false;
        }

        /// <summary>
        /// Last updated time of request.
        /// </summary>
        /// <value>Last updated time of request.</value>
        [DataMember(Name = "lastUpdated", EmitDefaultValue = true)]
        public DateTime? LastUpdated { get; private set; }

        /// <summary>
        /// Returns false as LastUpdated should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastUpdated()
        {
            return false;
        }

        /// <summary>
        /// Created time of request.
        /// </summary>
        /// <value>Created time of request.</value>
        [DataMember(Name = "createdTime", EmitDefaultValue = true)]
        public DateTime? CreatedTime { get; private set; }

        /// <summary>
        /// Returns false as CreatedTime should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedTime()
        {
            return false;
        }

        /// <summary>
        /// Task assignee of request.
        /// </summary>
        /// <value>Task assignee of request.</value>
        [DataMember(Name = "assignTo", EmitDefaultValue = true)]
        public string AssignTo { get; private set; }

        /// <summary>
        /// Returns false as AssignTo should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAssignTo()
        {
            return false;
        }

        /// <summary>
        /// Object full path of request.
        /// </summary>
        /// <value>Object full path of request.</value>
        [DataMember(Name = "fullPath", EmitDefaultValue = true)]
        public string FullPath { get; private set; }

        /// <summary>
        /// Returns false as FullPath should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFullPath()
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
            sb.Append("class CreateListRequest {\n");
            sb.Append("  ListTitle: ").Append(ListTitle).Append("\n");
            sb.Append("  ListName: ").Append(ListName).Append("\n");
            sb.Append("  ListDescription: ").Append(ListDescription).Append("\n");
            sb.Append("  ParentObject: ").Append(ParentObject).Append("\n");
            sb.Append("  ListTemplate: ").Append(ListTemplate).Append("\n");
            sb.Append("  EnableNavigation: ").Append(EnableNavigation).Append("\n");
            sb.Append("  ListType: ").Append(ListType).Append("\n");
            sb.Append("  VersionSettings: ").Append(VersionSettings).Append("\n");
            sb.Append("  PermissionSettings: ").Append(PermissionSettings).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  NotesToApprovers: ").Append(NotesToApprovers).Append("\n");
            sb.Append("  QuestionnaireId: ").Append(QuestionnaireId).Append("\n");
            sb.Append("  Metadatas: ").Append(Metadatas).Append("\n");
            sb.Append("  TicketNumber: ").Append(TicketNumber).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TypeDescription: ").Append(TypeDescription).Append("\n");
            sb.Append("  Requester: ").Append(Requester).Append("\n");
            sb.Append("  RequesterLoginName: ").Append(RequesterLoginName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ProgressStatus: ").Append(ProgressStatus).Append("\n");
            sb.Append("  ProgressStatusDescription: ").Append(ProgressStatusDescription).Append("\n");
            sb.Append("  SubmittedTime: ").Append(SubmittedTime).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  AssignTo: ").Append(AssignTo).Append("\n");
            sb.Append("  FullPath: ").Append(FullPath).Append("\n");
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
            return this.Equals(input as CreateListRequest);
        }

        /// <summary>
        /// Returns true if CreateListRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateListRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateListRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ListTitle == input.ListTitle ||
                    (this.ListTitle != null &&
                    this.ListTitle.Equals(input.ListTitle))
                ) && 
                (
                    this.ListName == input.ListName ||
                    (this.ListName != null &&
                    this.ListName.Equals(input.ListName))
                ) && 
                (
                    this.ListDescription == input.ListDescription ||
                    (this.ListDescription != null &&
                    this.ListDescription.Equals(input.ListDescription))
                ) && 
                (
                    this.ParentObject == input.ParentObject ||
                    (this.ParentObject != null &&
                    this.ParentObject.Equals(input.ParentObject))
                ) && 
                (
                    this.ListTemplate == input.ListTemplate ||
                    (this.ListTemplate != null &&
                    this.ListTemplate.Equals(input.ListTemplate))
                ) && 
                (
                    this.EnableNavigation == input.EnableNavigation ||
                    this.EnableNavigation.Equals(input.EnableNavigation)
                ) && 
                (
                    this.ListType == input.ListType ||
                    this.ListType.Equals(input.ListType)
                ) && 
                (
                    this.VersionSettings == input.VersionSettings ||
                    (this.VersionSettings != null &&
                    this.VersionSettings.Equals(input.VersionSettings))
                ) && 
                (
                    this.PermissionSettings == input.PermissionSettings ||
                    (this.PermissionSettings != null &&
                    this.PermissionSettings.Equals(input.PermissionSettings))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ServiceId == input.ServiceId ||
                    (this.ServiceId != null &&
                    this.ServiceId.Equals(input.ServiceId))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.NotesToApprovers == input.NotesToApprovers ||
                    (this.NotesToApprovers != null &&
                    this.NotesToApprovers.Equals(input.NotesToApprovers))
                ) && 
                (
                    this.QuestionnaireId == input.QuestionnaireId ||
                    (this.QuestionnaireId != null &&
                    this.QuestionnaireId.Equals(input.QuestionnaireId))
                ) && 
                (
                    this.Metadatas == input.Metadatas ||
                    this.Metadatas != null &&
                    input.Metadatas != null &&
                    this.Metadatas.SequenceEqual(input.Metadatas)
                ) && 
                (
                    this.TicketNumber == input.TicketNumber ||
                    (this.TicketNumber != null &&
                    this.TicketNumber.Equals(input.TicketNumber))
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
                    this.Requester == input.Requester ||
                    (this.Requester != null &&
                    this.Requester.Equals(input.Requester))
                ) && 
                (
                    this.RequesterLoginName == input.RequesterLoginName ||
                    (this.RequesterLoginName != null &&
                    this.RequesterLoginName.Equals(input.RequesterLoginName))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.ProgressStatus == input.ProgressStatus ||
                    this.ProgressStatus.Equals(input.ProgressStatus)
                ) && 
                (
                    this.ProgressStatusDescription == input.ProgressStatusDescription ||
                    (this.ProgressStatusDescription != null &&
                    this.ProgressStatusDescription.Equals(input.ProgressStatusDescription))
                ) && 
                (
                    this.SubmittedTime == input.SubmittedTime ||
                    (this.SubmittedTime != null &&
                    this.SubmittedTime.Equals(input.SubmittedTime))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
                ) && 
                (
                    this.AssignTo == input.AssignTo ||
                    (this.AssignTo != null &&
                    this.AssignTo.Equals(input.AssignTo))
                ) && 
                (
                    this.FullPath == input.FullPath ||
                    (this.FullPath != null &&
                    this.FullPath.Equals(input.FullPath))
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
                if (this.ListTitle != null)
                    hashCode = hashCode * 59 + this.ListTitle.GetHashCode();
                if (this.ListName != null)
                    hashCode = hashCode * 59 + this.ListName.GetHashCode();
                if (this.ListDescription != null)
                    hashCode = hashCode * 59 + this.ListDescription.GetHashCode();
                if (this.ParentObject != null)
                    hashCode = hashCode * 59 + this.ParentObject.GetHashCode();
                if (this.ListTemplate != null)
                    hashCode = hashCode * 59 + this.ListTemplate.GetHashCode();
                hashCode = hashCode * 59 + this.EnableNavigation.GetHashCode();
                hashCode = hashCode * 59 + this.ListType.GetHashCode();
                if (this.VersionSettings != null)
                    hashCode = hashCode * 59 + this.VersionSettings.GetHashCode();
                if (this.PermissionSettings != null)
                    hashCode = hashCode * 59 + this.PermissionSettings.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ServiceId != null)
                    hashCode = hashCode * 59 + this.ServiceId.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.NotesToApprovers != null)
                    hashCode = hashCode * 59 + this.NotesToApprovers.GetHashCode();
                if (this.QuestionnaireId != null)
                    hashCode = hashCode * 59 + this.QuestionnaireId.GetHashCode();
                if (this.Metadatas != null)
                    hashCode = hashCode * 59 + this.Metadatas.GetHashCode();
                if (this.TicketNumber != null)
                    hashCode = hashCode * 59 + this.TicketNumber.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TypeDescription != null)
                    hashCode = hashCode * 59 + this.TypeDescription.GetHashCode();
                if (this.Requester != null)
                    hashCode = hashCode * 59 + this.Requester.GetHashCode();
                if (this.RequesterLoginName != null)
                    hashCode = hashCode * 59 + this.RequesterLoginName.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.ProgressStatus.GetHashCode();
                if (this.ProgressStatusDescription != null)
                    hashCode = hashCode * 59 + this.ProgressStatusDescription.GetHashCode();
                if (this.SubmittedTime != null)
                    hashCode = hashCode * 59 + this.SubmittedTime.GetHashCode();
                if (this.LastUpdated != null)
                    hashCode = hashCode * 59 + this.LastUpdated.GetHashCode();
                if (this.CreatedTime != null)
                    hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.AssignTo != null)
                    hashCode = hashCode * 59 + this.AssignTo.GetHashCode();
                if (this.FullPath != null)
                    hashCode = hashCode * 59 + this.FullPath.GetHashCode();
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
