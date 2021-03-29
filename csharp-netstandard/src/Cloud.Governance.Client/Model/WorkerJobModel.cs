

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
    /// WorkerJobModel
    /// </summary>
    [DataContract(Name = "WorkerJobModel")]
    public partial class WorkerJobModel : IEquatable<WorkerJobModel>, IValidatableObject
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
        /// Gets or Sets ServiceType
        /// </summary>
        [DataMember(Name = "serviceType", EmitDefaultValue = false)]
        public ServiceType? ServiceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkerJobModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="name">name.</param>
        /// <param name="type">type.</param>
        /// <param name="method">method.</param>
        /// <param name="_params">_params.</param>
        /// <param name="updateTime">updateTime.</param>
        /// <param name="isTimer">isTimer (default to false).</param>
        /// <param name="status">status.</param>
        /// <param name="statusDescription">statusDescription.</param>
        /// <param name="message">message.</param>
        /// <param name="priority">priority.</param>
        /// <param name="priorityDescription">priorityDescription.</param>
        /// <param name="instanceId">instanceId.</param>
        /// <param name="intervalSeconds">intervalSeconds (default to 0).</param>
        /// <param name="nextRunTime">nextRunTime.</param>
        /// <param name="jobType">jobType.</param>
        /// <param name="serviceType">serviceType.</param>
        /// <param name="serviceTypeDescription">serviceTypeDescription.</param>
        public WorkerJobModel(Guid id = default(Guid), string tenantId = default(string), string name = default(string), string type = default(string), string method = default(string), List<Object> _params = default(List<Object>), DateTime updateTime = default(DateTime), bool isTimer = false, TaskStatus? status = default(TaskStatus?), string statusDescription = default(string), string message = default(string), TaskPriority? priority = default(TaskPriority?), string priorityDescription = default(string), string instanceId = default(string), int intervalSeconds = 0, DateTime nextRunTime = default(DateTime), string jobType = default(string), ServiceType? serviceType = default(ServiceType?), string serviceTypeDescription = default(string))
        {
            this.Id = id;
            this.TenantId = tenantId;
            this.Name = name;
            this.Type = type;
            this.Method = method;
            this.Params = _params;
            this.UpdateTime = updateTime;
            this.IsTimer = isTimer;
            this.Status = status;
            this.StatusDescription = statusDescription;
            this.Message = message;
            this.Priority = priority;
            this.PriorityDescription = priorityDescription;
            this.InstanceId = instanceId;
            this.IntervalSeconds = intervalSeconds;
            this.NextRunTime = nextRunTime;
            this.JobType = jobType;
            this.ServiceType = serviceType;
            this.ServiceTypeDescription = serviceTypeDescription;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

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
        /// Gets or Sets Params
        /// </summary>
        [DataMember(Name = "params", EmitDefaultValue = true)]
        public List<Object> Params { get; set; }

        /// <summary>
        /// Gets or Sets UpdateTime
        /// </summary>
        [DataMember(Name = "updateTime", EmitDefaultValue = false)]
        public DateTime UpdateTime { get; set; }

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
        /// Gets or Sets InstanceId
        /// </summary>
        [DataMember(Name = "instanceId", EmitDefaultValue = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Gets or Sets IntervalSeconds
        /// </summary>
        [DataMember(Name = "intervalSeconds", EmitDefaultValue = false)]
        public int IntervalSeconds { get; set; }

        /// <summary>
        /// Gets or Sets NextRunTime
        /// </summary>
        [DataMember(Name = "nextRunTime", EmitDefaultValue = false)]
        public DateTime NextRunTime { get; set; }

        /// <summary>
        /// Gets or Sets JobType
        /// </summary>
        [DataMember(Name = "jobType", EmitDefaultValue = true)]
        public string JobType { get; set; }

        /// <summary>
        /// Gets or Sets ServiceTypeDescription
        /// </summary>
        [DataMember(Name = "serviceTypeDescription", EmitDefaultValue = true)]
        public string ServiceTypeDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkerJobModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("  UpdateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  IsTimer: ").Append(IsTimer).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  PriorityDescription: ").Append(PriorityDescription).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  IntervalSeconds: ").Append(IntervalSeconds).Append("\n");
            sb.Append("  NextRunTime: ").Append(NextRunTime).Append("\n");
            sb.Append("  JobType: ").Append(JobType).Append("\n");
            sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
            sb.Append("  ServiceTypeDescription: ").Append(ServiceTypeDescription).Append("\n");
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
            return this.Equals(input as WorkerJobModel);
        }

        /// <summary>
        /// Returns true if WorkerJobModel instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkerJobModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkerJobModel input)
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
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
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
                    this.Params == input.Params ||
                    this.Params != null &&
                    input.Params != null &&
                    this.Params.SequenceEqual(input.Params)
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
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
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.IntervalSeconds == input.IntervalSeconds ||
                    this.IntervalSeconds.Equals(input.IntervalSeconds)
                ) && 
                (
                    this.NextRunTime == input.NextRunTime ||
                    (this.NextRunTime != null &&
                    this.NextRunTime.Equals(input.NextRunTime))
                ) && 
                (
                    this.JobType == input.JobType ||
                    (this.JobType != null &&
                    this.JobType.Equals(input.JobType))
                ) && 
                (
                    this.ServiceType == input.ServiceType ||
                    this.ServiceType.Equals(input.ServiceType)
                ) && 
                (
                    this.ServiceTypeDescription == input.ServiceTypeDescription ||
                    (this.ServiceTypeDescription != null &&
                    this.ServiceTypeDescription.Equals(input.ServiceTypeDescription))
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
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.Params != null)
                    hashCode = hashCode * 59 + this.Params.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                hashCode = hashCode * 59 + this.IsTimer.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusDescription != null)
                    hashCode = hashCode * 59 + this.StatusDescription.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.PriorityDescription != null)
                    hashCode = hashCode * 59 + this.PriorityDescription.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                hashCode = hashCode * 59 + this.IntervalSeconds.GetHashCode();
                if (this.NextRunTime != null)
                    hashCode = hashCode * 59 + this.NextRunTime.GetHashCode();
                if (this.JobType != null)
                    hashCode = hashCode * 59 + this.JobType.GetHashCode();
                hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.ServiceTypeDescription != null)
                    hashCode = hashCode * 59 + this.ServiceTypeDescription.GetHashCode();
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
