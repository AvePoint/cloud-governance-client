

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
    /// ApiTask
    /// </summary>
    [DataContract(Name = "ApiTask")]
    public partial class ApiTask : IEquatable<ApiTask>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public TaskResult? Status { get; set; }
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
        /// Initializes a new instance of the <see cref="ApiTask" /> class.
        /// </summary>
        /// <param name="dynamicProperties">dynamicProperties.</param>
        /// <param name="id">id.</param>
        /// <param name="title">title.</param>
        /// <param name="description">description.</param>
        /// <param name="requestGuid">requestGuid.</param>
        /// <param name="status">status.</param>
        /// <param name="statusDescription">statusDescription.</param>
        /// <param name="serviceType">serviceType.</param>
        /// <param name="serviceTypeDescription">serviceTypeDescription.</param>
        /// <param name="comments">comments.</param>
        /// <param name="allComments">allComments.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="lastModifiedTime">lastModifiedTime.</param>
        /// <param name="taskType">taskType.</param>
        /// <param name="allowReassign">allowReassign.</param>
        /// <param name="allowEdit">allowEdit.</param>
        /// <param name="dynamicActions">dynamicActions.</param>
        public ApiTask(ApiTaskDynamicProperties dynamicProperties = default(ApiTaskDynamicProperties), Guid id = default(Guid), string title = default(string), string description = default(string), Guid requestGuid = default(Guid), TaskResult? status = default(TaskResult?), string statusDescription = default(string), ServiceType? serviceType = default(ServiceType?), string serviceTypeDescription = default(string), string comments = default(string), List<TaskComment> allComments = default(List<TaskComment>), string errorMessage = default(string), DateTime lastModifiedTime = default(DateTime), TaskType? taskType = default(TaskType?), bool allowReassign = default(bool), bool allowEdit = default(bool), List<TaskDynamicActions> dynamicActions = default(List<TaskDynamicActions>))
        {
            this.DynamicProperties = dynamicProperties;
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.RequestGuid = requestGuid;
            this.Status = status;
            this.StatusDescription = statusDescription;
            this.ServiceType = serviceType;
            this.ServiceTypeDescription = serviceTypeDescription;
            this.Comments = comments;
            this.AllComments = allComments;
            this.ErrorMessage = errorMessage;
            this.LastModifiedTime = lastModifiedTime;
            this.TaskType = taskType;
            this.AllowReassign = allowReassign;
            this.AllowEdit = allowEdit;
            this.DynamicActions = dynamicActions;
        }

        /// <summary>
        /// Gets or Sets DynamicProperties
        /// </summary>
        [DataMember(Name = "dynamicProperties", EmitDefaultValue = true)]
        public ApiTaskDynamicProperties DynamicProperties { get; set; }

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
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets RequestGuid
        /// </summary>
        [DataMember(Name = "requestGuid", EmitDefaultValue = false)]
        public Guid RequestGuid { get; set; }

        /// <summary>
        /// Gets or Sets StatusDescription
        /// </summary>
        [DataMember(Name = "statusDescription", EmitDefaultValue = true)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Gets or Sets ServiceTypeDescription
        /// </summary>
        [DataMember(Name = "serviceTypeDescription", EmitDefaultValue = true)]
        public string ServiceTypeDescription { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name = "comments", EmitDefaultValue = true)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets AllComments
        /// </summary>
        [DataMember(Name = "allComments", EmitDefaultValue = true)]
        public List<TaskComment> AllComments { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name = "errorMessage", EmitDefaultValue = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedTime
        /// </summary>
        [DataMember(Name = "lastModifiedTime", EmitDefaultValue = false)]
        public DateTime LastModifiedTime { get; set; }

        /// <summary>
        /// Gets or Sets AllowReassign
        /// </summary>
        [DataMember(Name = "allowReassign", EmitDefaultValue = false)]
        public bool AllowReassign { get; set; }

        /// <summary>
        /// Gets or Sets AllowEdit
        /// </summary>
        [DataMember(Name = "allowEdit", EmitDefaultValue = false)]
        public bool AllowEdit { get; set; }

        /// <summary>
        /// Gets or Sets DynamicActions
        /// </summary>
        [DataMember(Name = "dynamicActions", EmitDefaultValue = true)]
        public List<TaskDynamicActions> DynamicActions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiTask {\n");
            sb.Append("  DynamicProperties: ").Append(DynamicProperties).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  RequestGuid: ").Append(RequestGuid).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
            sb.Append("  ServiceTypeDescription: ").Append(ServiceTypeDescription).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  AllComments: ").Append(AllComments).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  LastModifiedTime: ").Append(LastModifiedTime).Append("\n");
            sb.Append("  TaskType: ").Append(TaskType).Append("\n");
            sb.Append("  AllowReassign: ").Append(AllowReassign).Append("\n");
            sb.Append("  AllowEdit: ").Append(AllowEdit).Append("\n");
            sb.Append("  DynamicActions: ").Append(DynamicActions).Append("\n");
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
            return this.Equals(input as ApiTask);
        }

        /// <summary>
        /// Returns true if ApiTask instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiTask to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiTask input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DynamicProperties == input.DynamicProperties ||
                    (this.DynamicProperties != null &&
                    this.DynamicProperties.Equals(input.DynamicProperties))
                ) && 
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.RequestGuid == input.RequestGuid ||
                    (this.RequestGuid != null &&
                    this.RequestGuid.Equals(input.RequestGuid))
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
                    this.ServiceType == input.ServiceType ||
                    this.ServiceType.Equals(input.ServiceType)
                ) && 
                (
                    this.ServiceTypeDescription == input.ServiceTypeDescription ||
                    (this.ServiceTypeDescription != null &&
                    this.ServiceTypeDescription.Equals(input.ServiceTypeDescription))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.AllComments == input.AllComments ||
                    this.AllComments != null &&
                    input.AllComments != null &&
                    this.AllComments.SequenceEqual(input.AllComments)
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.LastModifiedTime == input.LastModifiedTime ||
                    (this.LastModifiedTime != null &&
                    this.LastModifiedTime.Equals(input.LastModifiedTime))
                ) && 
                (
                    this.TaskType == input.TaskType ||
                    this.TaskType.Equals(input.TaskType)
                ) && 
                (
                    this.AllowReassign == input.AllowReassign ||
                    this.AllowReassign.Equals(input.AllowReassign)
                ) && 
                (
                    this.AllowEdit == input.AllowEdit ||
                    this.AllowEdit.Equals(input.AllowEdit)
                ) && 
                (
                    this.DynamicActions == input.DynamicActions ||
                    this.DynamicActions != null &&
                    input.DynamicActions != null &&
                    this.DynamicActions.SequenceEqual(input.DynamicActions)
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
                if (this.DynamicProperties != null)
                    hashCode = hashCode * 59 + this.DynamicProperties.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.RequestGuid != null)
                    hashCode = hashCode * 59 + this.RequestGuid.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusDescription != null)
                    hashCode = hashCode * 59 + this.StatusDescription.GetHashCode();
                hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.ServiceTypeDescription != null)
                    hashCode = hashCode * 59 + this.ServiceTypeDescription.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.AllComments != null)
                    hashCode = hashCode * 59 + this.AllComments.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.LastModifiedTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedTime.GetHashCode();
                hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                hashCode = hashCode * 59 + this.AllowReassign.GetHashCode();
                hashCode = hashCode * 59 + this.AllowEdit.GetHashCode();
                if (this.DynamicActions != null)
                    hashCode = hashCode * 59 + this.DynamicActions.GetHashCode();
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
