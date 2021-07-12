

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
    /// TaskList
    /// </summary>
    [DataContract(Name = "TaskList")]
    public partial class TaskList : IEquatable<TaskList>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets DueDateType
        /// </summary>
        [DataMember(Name = "dueDateType", EmitDefaultValue = false)]
        public DueDateType? DueDateType { get; set; }
        /// <summary>
        /// Gets or Sets ServiceType
        /// </summary>
        [DataMember(Name = "serviceType", EmitDefaultValue = false)]
        public ServiceType? ServiceType { get; set; }
        /// <summary>
        /// Gets or Sets TaskType
        /// </summary>
        [DataMember(Name = "taskType", EmitDefaultValue = false)]
        public TaskType? TaskType { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public TaskResult? Status { get; set; }
        /// <summary>
        /// Gets or Sets ProgressStatus
        /// </summary>
        [DataMember(Name = "progressStatus", EmitDefaultValue = false)]
        public RequestProgressStatus? ProgressStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskList" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="title">title.</param>
        /// <param name="requester">requester.</param>
        /// <param name="requestId">requestId.</param>
        /// <param name="requestTicketNumber">requestTicketNumber (default to 0).</param>
        /// <param name="requesterDisplayName">requesterDisplayName.</param>
        /// <param name="requesterEmail">requesterEmail.</param>
        /// <param name="dueDate">dueDate.</param>
        /// <param name="dueDateType">dueDateType.</param>
        /// <param name="serviceType">serviceType.</param>
        /// <param name="serviceTypeDescription">serviceTypeDescription.</param>
        /// <param name="createdTime">createdTime.</param>
        /// <param name="taskType">taskType.</param>
        /// <param name="status">status.</param>
        /// <param name="statusDescription">statusDescription.</param>
        /// <param name="taskFullPath">taskFullPath.</param>
        /// <param name="lastUpdated">lastUpdated.</param>
        /// <param name="category">category.</param>
        /// <param name="categoryDisplayName">categoryDisplayName.</param>
        /// <param name="serviceName">serviceName.</param>
        /// <param name="objectId">objectId.</param>
        /// <param name="profileId">profileId.</param>
        /// <param name="allowEdit">allowEdit (default to false).</param>
        /// <param name="progressStatus">progressStatus.</param>
        public TaskList(Guid id = default(Guid), string title = default(string), string requester = default(string), Guid requestId = default(Guid), int requestTicketNumber = 0, string requesterDisplayName = default(string), string requesterEmail = default(string), DateTime? dueDate = default(DateTime?), DueDateType? dueDateType = default(DueDateType?), ServiceType? serviceType = default(ServiceType?), string serviceTypeDescription = default(string), DateTime createdTime = default(DateTime), TaskType? taskType = default(TaskType?), TaskResult? status = default(TaskResult?), string statusDescription = default(string), string taskFullPath = default(string), DateTime lastUpdated = default(DateTime), Guid? category = default(Guid?), string categoryDisplayName = default(string), string serviceName = default(string), Guid? objectId = default(Guid?), Guid? profileId = default(Guid?), bool allowEdit = false, RequestProgressStatus? progressStatus = default(RequestProgressStatus?))
        {
            this.Id = id;
            this.Title = title;
            this.Requester = requester;
            this.RequestId = requestId;
            this.RequestTicketNumber = requestTicketNumber;
            this.RequesterDisplayName = requesterDisplayName;
            this.RequesterEmail = requesterEmail;
            this.DueDate = dueDate;
            this.DueDateType = dueDateType;
            this.ServiceType = serviceType;
            this.ServiceTypeDescription = serviceTypeDescription;
            this.CreatedTime = createdTime;
            this.TaskType = taskType;
            this.Status = status;
            this.StatusDescription = statusDescription;
            this.TaskFullPath = taskFullPath;
            this.LastUpdated = lastUpdated;
            this.Category = category;
            this.CategoryDisplayName = categoryDisplayName;
            this.ServiceName = serviceName;
            this.ObjectId = objectId;
            this.ProfileId = profileId;
            this.AllowEdit = allowEdit;
            this.ProgressStatus = progressStatus;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Requester
        /// </summary>
        [DataMember(Name = "requester", EmitDefaultValue = true)]
        public string Requester { get; set; }

        /// <summary>
        /// Gets or Sets RequestId
        /// </summary>
        [DataMember(Name = "requestId", EmitDefaultValue = false)]
        public Guid RequestId { get; set; }

        /// <summary>
        /// Gets or Sets RequestTicketNumber
        /// </summary>
        [DataMember(Name = "requestTicketNumber", EmitDefaultValue = false)]
        public int RequestTicketNumber { get; set; }

        /// <summary>
        /// Gets or Sets RequesterDisplayName
        /// </summary>
        [DataMember(Name = "requesterDisplayName", EmitDefaultValue = true)]
        public string RequesterDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets RequesterEmail
        /// </summary>
        [DataMember(Name = "requesterEmail", EmitDefaultValue = true)]
        public string RequesterEmail { get; set; }

        /// <summary>
        /// Gets or Sets DueDate
        /// </summary>
        [DataMember(Name = "dueDate", EmitDefaultValue = true)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or Sets ServiceTypeDescription
        /// </summary>
        [DataMember(Name = "serviceTypeDescription", EmitDefaultValue = true)]
        public string ServiceTypeDescription { get; set; }

        /// <summary>
        /// Gets or Sets CreatedTime
        /// </summary>
        [DataMember(Name = "createdTime", EmitDefaultValue = false)]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// Gets or Sets StatusDescription
        /// </summary>
        [DataMember(Name = "statusDescription", EmitDefaultValue = true)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Gets or Sets TaskFullPath
        /// </summary>
        [DataMember(Name = "taskFullPath", EmitDefaultValue = true)]
        public string TaskFullPath { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdated
        /// </summary>
        [DataMember(Name = "lastUpdated", EmitDefaultValue = false)]
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = true)]
        public Guid? Category { get; set; }

        /// <summary>
        /// Gets or Sets CategoryDisplayName
        /// </summary>
        [DataMember(Name = "categoryDisplayName", EmitDefaultValue = true)]
        public string CategoryDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets ServiceName
        /// </summary>
        [DataMember(Name = "serviceName", EmitDefaultValue = true)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name = "objectId", EmitDefaultValue = true)]
        public Guid? ObjectId { get; set; }

        /// <summary>
        /// Gets or Sets ProfileId
        /// </summary>
        [DataMember(Name = "profileId", EmitDefaultValue = true)]
        public Guid? ProfileId { get; set; }

        /// <summary>
        /// Gets or Sets AllowEdit
        /// </summary>
        [DataMember(Name = "allowEdit", EmitDefaultValue = false)]
        public bool AllowEdit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskList {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Requester: ").Append(Requester).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  RequestTicketNumber: ").Append(RequestTicketNumber).Append("\n");
            sb.Append("  RequesterDisplayName: ").Append(RequesterDisplayName).Append("\n");
            sb.Append("  RequesterEmail: ").Append(RequesterEmail).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  DueDateType: ").Append(DueDateType).Append("\n");
            sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
            sb.Append("  ServiceTypeDescription: ").Append(ServiceTypeDescription).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  TaskType: ").Append(TaskType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  TaskFullPath: ").Append(TaskFullPath).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  CategoryDisplayName: ").Append(CategoryDisplayName).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
            sb.Append("  AllowEdit: ").Append(AllowEdit).Append("\n");
            sb.Append("  ProgressStatus: ").Append(ProgressStatus).Append("\n");
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
            return this.Equals(input as TaskList);
        }

        /// <summary>
        /// Returns true if TaskList instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskList input)
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
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Requester == input.Requester ||
                    (this.Requester != null &&
                    this.Requester.Equals(input.Requester))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.RequestTicketNumber == input.RequestTicketNumber ||
                    this.RequestTicketNumber.Equals(input.RequestTicketNumber)
                ) && 
                (
                    this.RequesterDisplayName == input.RequesterDisplayName ||
                    (this.RequesterDisplayName != null &&
                    this.RequesterDisplayName.Equals(input.RequesterDisplayName))
                ) && 
                (
                    this.RequesterEmail == input.RequesterEmail ||
                    (this.RequesterEmail != null &&
                    this.RequesterEmail.Equals(input.RequesterEmail))
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.DueDateType == input.DueDateType ||
                    this.DueDateType.Equals(input.DueDateType)
                ) && 
                (
                    this.ServiceType == input.ServiceType ||
                    this.ServiceType.Equals(input.ServiceType)
                ) && 
                (
                    this.ServiceTypeDescription == input.ServiceTypeDescription ||
                    (this.ServiceTypeDescription != null &&
                    this.ServiceTypeDescription.Equals(input.ServiceTypeDescription))
                ) && 
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
                ) && 
                (
                    this.TaskType == input.TaskType ||
                    this.TaskType.Equals(input.TaskType)
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
                    this.TaskFullPath == input.TaskFullPath ||
                    (this.TaskFullPath != null &&
                    this.TaskFullPath.Equals(input.TaskFullPath))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.CategoryDisplayName == input.CategoryDisplayName ||
                    (this.CategoryDisplayName != null &&
                    this.CategoryDisplayName.Equals(input.CategoryDisplayName))
                ) && 
                (
                    this.ServiceName == input.ServiceName ||
                    (this.ServiceName != null &&
                    this.ServiceName.Equals(input.ServiceName))
                ) && 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
                ) && 
                (
                    this.ProfileId == input.ProfileId ||
                    (this.ProfileId != null &&
                    this.ProfileId.Equals(input.ProfileId))
                ) && 
                (
                    this.AllowEdit == input.AllowEdit ||
                    this.AllowEdit.Equals(input.AllowEdit)
                ) && 
                (
                    this.ProgressStatus == input.ProgressStatus ||
                    this.ProgressStatus.Equals(input.ProgressStatus)
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Requester != null)
                    hashCode = hashCode * 59 + this.Requester.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                hashCode = hashCode * 59 + this.RequestTicketNumber.GetHashCode();
                if (this.RequesterDisplayName != null)
                    hashCode = hashCode * 59 + this.RequesterDisplayName.GetHashCode();
                if (this.RequesterEmail != null)
                    hashCode = hashCode * 59 + this.RequesterEmail.GetHashCode();
                if (this.DueDate != null)
                    hashCode = hashCode * 59 + this.DueDate.GetHashCode();
                hashCode = hashCode * 59 + this.DueDateType.GetHashCode();
                hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.ServiceTypeDescription != null)
                    hashCode = hashCode * 59 + this.ServiceTypeDescription.GetHashCode();
                if (this.CreatedTime != null)
                    hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusDescription != null)
                    hashCode = hashCode * 59 + this.StatusDescription.GetHashCode();
                if (this.TaskFullPath != null)
                    hashCode = hashCode * 59 + this.TaskFullPath.GetHashCode();
                if (this.LastUpdated != null)
                    hashCode = hashCode * 59 + this.LastUpdated.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.CategoryDisplayName != null)
                    hashCode = hashCode * 59 + this.CategoryDisplayName.GetHashCode();
                if (this.ServiceName != null)
                    hashCode = hashCode * 59 + this.ServiceName.GetHashCode();
                if (this.ObjectId != null)
                    hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.ProfileId != null)
                    hashCode = hashCode * 59 + this.ProfileId.GetHashCode();
                hashCode = hashCode * 59 + this.AllowEdit.GetHashCode();
                hashCode = hashCode * 59 + this.ProgressStatus.GetHashCode();
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
