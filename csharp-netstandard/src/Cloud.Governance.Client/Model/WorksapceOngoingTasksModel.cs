

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
    /// WorksapceOngoingTasksModel
    /// </summary>
    [DataContract(Name = "WorksapceOngoingTasksModel")]
    public partial class WorksapceOngoingTasksModel : IEquatable<WorksapceOngoingTasksModel>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ServiceType
        /// </summary>
        [DataMember(Name = "serviceType", EmitDefaultValue = false)]
        public ServiceType? ServiceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorksapceOngoingTasksModel" /> class.
        /// </summary>
        /// <param name="taskName">taskName.</param>
        /// <param name="serviceType">serviceType.</param>
        /// <param name="serviceTypeDescription">serviceTypeDescription.</param>
        /// <param name="instanceId">instanceId.</param>
        /// <param name="workspaceId">workspaceId.</param>
        public WorksapceOngoingTasksModel(string taskName = default(string), ServiceType? serviceType = default(ServiceType?), string serviceTypeDescription = default(string), Guid instanceId = default(Guid), Guid workspaceId = default(Guid))
        {
            this.TaskName = taskName;
            this.ServiceType = serviceType;
            this.ServiceTypeDescription = serviceTypeDescription;
            this.InstanceId = instanceId;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Gets or Sets TaskName
        /// </summary>
        [DataMember(Name = "taskName", EmitDefaultValue = true)]
        public string TaskName { get; set; }

        /// <summary>
        /// Gets or Sets ServiceTypeDescription
        /// </summary>
        [DataMember(Name = "serviceTypeDescription", EmitDefaultValue = true)]
        public string ServiceTypeDescription { get; set; }

        /// <summary>
        /// Gets or Sets InstanceId
        /// </summary>
        [DataMember(Name = "instanceId", EmitDefaultValue = false)]
        public Guid InstanceId { get; set; }

        /// <summary>
        /// Gets or Sets WorkspaceId
        /// </summary>
        [DataMember(Name = "workspaceId", EmitDefaultValue = false)]
        public Guid WorkspaceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorksapceOngoingTasksModel {\n");
            sb.Append("  TaskName: ").Append(TaskName).Append("\n");
            sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
            sb.Append("  ServiceTypeDescription: ").Append(ServiceTypeDescription).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
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
            return this.Equals(input as WorksapceOngoingTasksModel);
        }

        /// <summary>
        /// Returns true if WorksapceOngoingTasksModel instances are equal
        /// </summary>
        /// <param name="input">Instance of WorksapceOngoingTasksModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorksapceOngoingTasksModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskName == input.TaskName ||
                    (this.TaskName != null &&
                    this.TaskName.Equals(input.TaskName))
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
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.WorkspaceId == input.WorkspaceId ||
                    (this.WorkspaceId != null &&
                    this.WorkspaceId.Equals(input.WorkspaceId))
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
                if (this.TaskName != null)
                    hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.ServiceTypeDescription != null)
                    hashCode = hashCode * 59 + this.ServiceTypeDescription.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.WorkspaceId != null)
                    hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
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
