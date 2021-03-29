

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
    /// WorkerJobGridModel
    /// </summary>
    [DataContract(Name = "WorkerJobGridModel")]
    public partial class WorkerJobGridModel : IEquatable<WorkerJobGridModel>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public TaskStatus? Status { get; set; }
        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", EmitDefaultValue = false)]
        public TaskPriority? Priority { get; set; }
        /// <summary>
        /// Gets or Sets JobType
        /// </summary>
        [DataMember(Name = "jobType", EmitDefaultValue = false)]
        public ServiceType? JobType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkerJobGridModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="type">type.</param>
        /// <param name="method">method.</param>
        /// <param name="updateTime">updateTime.</param>
        /// <param name="nextRunTime">nextRunTime.</param>
        /// <param name="isTimer">isTimer (default to false).</param>
        /// <param name="status">status.</param>
        /// <param name="statusDescription">statusDescription.</param>
        /// <param name="message">message.</param>
        /// <param name="priority">priority.</param>
        /// <param name="priorityDescription">priorityDescription.</param>
        /// <param name="intervalSeconds">intervalSeconds (default to 0).</param>
        /// <param name="jobType">jobType.</param>
        /// <param name="jobTypeDescription">jobTypeDescription.</param>
        public WorkerJobGridModel(Guid id = default(Guid), string name = default(string), string type = default(string), string method = default(string), DateTime updateTime = default(DateTime), DateTime nextRunTime = default(DateTime), bool isTimer = false, TaskStatus? status = default(TaskStatus?), string statusDescription = default(string), string message = default(string), TaskPriority? priority = default(TaskPriority?), string priorityDescription = default(string), int intervalSeconds = 0, ServiceType? jobType = default(ServiceType?), string jobTypeDescription = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Method = method;
            this.UpdateTime = updateTime;
            this.NextRunTime = nextRunTime;
            this.IsTimer = isTimer;
            this.Status = status;
            this.StatusDescription = statusDescription;
            this.Message = message;
            this.Priority = priority;
            this.PriorityDescription = priorityDescription;
            this.IntervalSeconds = intervalSeconds;
            this.JobType = jobType;
            this.JobTypeDescription = jobTypeDescription;
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
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name = "method", EmitDefaultValue = true)]
        public string Method { get; set; }

        /// <summary>
        /// Gets or Sets UpdateTime
        /// </summary>
        [DataMember(Name = "updateTime", EmitDefaultValue = false)]
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// Gets or Sets NextRunTime
        /// </summary>
        [DataMember(Name = "nextRunTime", EmitDefaultValue = false)]
        public DateTime NextRunTime { get; set; }

        /// <summary>
        /// Gets or Sets IsTimer
        /// </summary>
        [DataMember(Name = "isTimer", EmitDefaultValue = false)]
        public bool IsTimer { get; set; }

        /// <summary>
        /// Gets or Sets StatusDescription
        /// </summary>
        [DataMember(Name = "statusDescription", EmitDefaultValue = true)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets PriorityDescription
        /// </summary>
        [DataMember(Name = "priorityDescription", EmitDefaultValue = true)]
        public string PriorityDescription { get; set; }

        /// <summary>
        /// Gets or Sets IntervalSeconds
        /// </summary>
        [DataMember(Name = "intervalSeconds", EmitDefaultValue = false)]
        public int IntervalSeconds { get; set; }

        /// <summary>
        /// Gets or Sets JobTypeDescription
        /// </summary>
        [DataMember(Name = "jobTypeDescription", EmitDefaultValue = true)]
        public string JobTypeDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkerJobGridModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  UpdateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  NextRunTime: ").Append(NextRunTime).Append("\n");
            sb.Append("  IsTimer: ").Append(IsTimer).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  PriorityDescription: ").Append(PriorityDescription).Append("\n");
            sb.Append("  IntervalSeconds: ").Append(IntervalSeconds).Append("\n");
            sb.Append("  JobType: ").Append(JobType).Append("\n");
            sb.Append("  JobTypeDescription: ").Append(JobTypeDescription).Append("\n");
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
            return this.Equals(input as WorkerJobGridModel);
        }

        /// <summary>
        /// Returns true if WorkerJobGridModel instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkerJobGridModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkerJobGridModel input)
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
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) && 
                (
                    this.NextRunTime == input.NextRunTime ||
                    (this.NextRunTime != null &&
                    this.NextRunTime.Equals(input.NextRunTime))
                ) && 
                (
                    this.IsTimer == input.IsTimer ||
                    this.IsTimer.Equals(input.IsTimer)
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
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Priority == input.Priority ||
                    this.Priority.Equals(input.Priority)
                ) && 
                (
                    this.PriorityDescription == input.PriorityDescription ||
                    (this.PriorityDescription != null &&
                    this.PriorityDescription.Equals(input.PriorityDescription))
                ) && 
                (
                    this.IntervalSeconds == input.IntervalSeconds ||
                    this.IntervalSeconds.Equals(input.IntervalSeconds)
                ) && 
                (
                    this.JobType == input.JobType ||
                    this.JobType.Equals(input.JobType)
                ) && 
                (
                    this.JobTypeDescription == input.JobTypeDescription ||
                    (this.JobTypeDescription != null &&
                    this.JobTypeDescription.Equals(input.JobTypeDescription))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.NextRunTime != null)
                    hashCode = hashCode * 59 + this.NextRunTime.GetHashCode();
                hashCode = hashCode * 59 + this.IsTimer.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusDescription != null)
                    hashCode = hashCode * 59 + this.StatusDescription.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.PriorityDescription != null)
                    hashCode = hashCode * 59 + this.PriorityDescription.GetHashCode();
                hashCode = hashCode * 59 + this.IntervalSeconds.GetHashCode();
                hashCode = hashCode * 59 + this.JobType.GetHashCode();
                if (this.JobTypeDescription != null)
                    hashCode = hashCode * 59 + this.JobTypeDescription.GetHashCode();
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
