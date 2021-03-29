

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
    /// TaskReport
    /// </summary>
    [DataContract(Name = "TaskReport")]
    public partial class TaskReport : IEquatable<TaskReport>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="TaskReport" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="title">title.</param>
        /// <param name="requester">requester.</param>
        /// <param name="requesterLoginName">requesterLoginName.</param>
        /// <param name="requesterDisplayName">requesterDisplayName.</param>
        /// <param name="requestTicketNumber">requestTicketNumber (default to 0).</param>
        /// <param name="dueDate">dueDate.</param>
        /// <param name="dueDateType">dueDateType.</param>
        /// <param name="serviceType">serviceType.</param>
        /// <param name="serviceTypeDescription">serviceTypeDescription.</param>
        /// <param name="createdTime">createdTime.</param>
        /// <param name="taskType">taskType.</param>
        /// <param name="status">status.</param>
        /// <param name="statusDescription">statusDescription.</param>
        /// <param name="isApproveTask">isApproveTask (default to false).</param>
        /// <param name="assignee">assignee.</param>
        /// <param name="assigneeLoginName">assigneeLoginName.</param>
        /// <param name="assigneeDisplayName">assigneeDisplayName.</param>
        public TaskReport(Guid id = default(Guid), string title = default(string), string requester = default(string), string requesterLoginName = default(string), string requesterDisplayName = default(string), int requestTicketNumber = 0, DateTime? dueDate = default(DateTime?), DueDateType? dueDateType = default(DueDateType?), ServiceType? serviceType = default(ServiceType?), string serviceTypeDescription = default(string), DateTime createdTime = default(DateTime), TaskType? taskType = default(TaskType?), TaskResult? status = default(TaskResult?), string statusDescription = default(string), bool isApproveTask = false, string assignee = default(string), string assigneeLoginName = default(string), string assigneeDisplayName = default(string))
        {
            this.Id = id;
            this.Title = title;
            this.Requester = requester;
            this.RequesterLoginName = requesterLoginName;
            this.RequesterDisplayName = requesterDisplayName;
            this.RequestTicketNumber = requestTicketNumber;
            this.DueDate = dueDate;
            this.DueDateType = dueDateType;
            this.ServiceType = serviceType;
            this.ServiceTypeDescription = serviceTypeDescription;
            this.CreatedTime = createdTime;
            this.TaskType = taskType;
            this.Status = status;
            this.StatusDescription = statusDescription;
            this.IsApproveTask = isApproveTask;
            this.Assignee = assignee;
            this.AssigneeLoginName = assigneeLoginName;
            this.AssigneeDisplayName = assigneeDisplayName;
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
        /// Gets or Sets RequesterLoginName
        /// </summary>
        [DataMember(Name = "requesterLoginName", EmitDefaultValue = true)]
        public string RequesterLoginName { get; set; }

        /// <summary>
        /// Gets or Sets RequesterDisplayName
        /// </summary>
        [DataMember(Name = "requesterDisplayName", EmitDefaultValue = true)]
        public string RequesterDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets RequestTicketNumber
        /// </summary>
        [DataMember(Name = "requestTicketNumber", EmitDefaultValue = false)]
        public int RequestTicketNumber { get; set; }

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
        /// Gets or Sets IsApproveTask
        /// </summary>
        [DataMember(Name = "isApproveTask", EmitDefaultValue = false)]
        public bool IsApproveTask { get; set; }

        /// <summary>
        /// Gets or Sets Assignee
        /// </summary>
        [DataMember(Name = "assignee", EmitDefaultValue = true)]
        public string Assignee { get; set; }

        /// <summary>
        /// Gets or Sets AssigneeLoginName
        /// </summary>
        [DataMember(Name = "assigneeLoginName", EmitDefaultValue = true)]
        public string AssigneeLoginName { get; set; }

        /// <summary>
        /// Gets or Sets AssigneeDisplayName
        /// </summary>
        [DataMember(Name = "assigneeDisplayName", EmitDefaultValue = true)]
        public string AssigneeDisplayName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskReport {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Requester: ").Append(Requester).Append("\n");
            sb.Append("  RequesterLoginName: ").Append(RequesterLoginName).Append("\n");
            sb.Append("  RequesterDisplayName: ").Append(RequesterDisplayName).Append("\n");
            sb.Append("  RequestTicketNumber: ").Append(RequestTicketNumber).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  DueDateType: ").Append(DueDateType).Append("\n");
            sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
            sb.Append("  ServiceTypeDescription: ").Append(ServiceTypeDescription).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  TaskType: ").Append(TaskType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  IsApproveTask: ").Append(IsApproveTask).Append("\n");
            sb.Append("  Assignee: ").Append(Assignee).Append("\n");
            sb.Append("  AssigneeLoginName: ").Append(AssigneeLoginName).Append("\n");
            sb.Append("  AssigneeDisplayName: ").Append(AssigneeDisplayName).Append("\n");
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
            return this.Equals(input as TaskReport);
        }

        /// <summary>
        /// Returns true if TaskReport instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskReport input)
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
                    this.RequesterLoginName == input.RequesterLoginName ||
                    (this.RequesterLoginName != null &&
                    this.RequesterLoginName.Equals(input.RequesterLoginName))
                ) && 
                (
                    this.RequesterDisplayName == input.RequesterDisplayName ||
                    (this.RequesterDisplayName != null &&
                    this.RequesterDisplayName.Equals(input.RequesterDisplayName))
                ) && 
                (
                    this.RequestTicketNumber == input.RequestTicketNumber ||
                    this.RequestTicketNumber.Equals(input.RequestTicketNumber)
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
                    this.IsApproveTask == input.IsApproveTask ||
                    this.IsApproveTask.Equals(input.IsApproveTask)
                ) && 
                (
                    this.Assignee == input.Assignee ||
                    (this.Assignee != null &&
                    this.Assignee.Equals(input.Assignee))
                ) && 
                (
                    this.AssigneeLoginName == input.AssigneeLoginName ||
                    (this.AssigneeLoginName != null &&
                    this.AssigneeLoginName.Equals(input.AssigneeLoginName))
                ) && 
                (
                    this.AssigneeDisplayName == input.AssigneeDisplayName ||
                    (this.AssigneeDisplayName != null &&
                    this.AssigneeDisplayName.Equals(input.AssigneeDisplayName))
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
                if (this.RequesterLoginName != null)
                    hashCode = hashCode * 59 + this.RequesterLoginName.GetHashCode();
                if (this.RequesterDisplayName != null)
                    hashCode = hashCode * 59 + this.RequesterDisplayName.GetHashCode();
                hashCode = hashCode * 59 + this.RequestTicketNumber.GetHashCode();
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
                hashCode = hashCode * 59 + this.IsApproveTask.GetHashCode();
                if (this.Assignee != null)
                    hashCode = hashCode * 59 + this.Assignee.GetHashCode();
                if (this.AssigneeLoginName != null)
                    hashCode = hashCode * 59 + this.AssigneeLoginName.GetHashCode();
                if (this.AssigneeDisplayName != null)
                    hashCode = hashCode * 59 + this.AssigneeDisplayName.GetHashCode();
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
