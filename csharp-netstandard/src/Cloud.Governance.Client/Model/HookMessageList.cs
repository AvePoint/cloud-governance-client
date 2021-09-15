

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
    /// HookMessageList
    /// </summary>
    [DataContract(Name = "HookMessageList")]
    public partial class HookMessageList : IEquatable<HookMessageList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HookMessageList" /> class.
        /// </summary>
        /// <param name="renewalTaskCompleted">When a Renewal Task is Completed.</param>
        /// <param name="taskCreated">taskCreated.</param>
        /// <param name="autoImportCompleted">When an import process with pre-defined governance details or end user completes a confirm governance details task is completed.</param>
        /// <param name="requestsRelated">requestsRelated.</param>
        /// <param name="lifecycleHookMessage">lifecycleHookMessage.</param>
        /// <param name="electionHookMessage">electionHookMessage.</param>
        public HookMessageList(RenewalTaskHookMessage renewalTaskCompleted = default(RenewalTaskHookMessage), TaskHookMessage taskCreated = default(TaskHookMessage), AutoImportProcessHookMessage autoImportCompleted = default(AutoImportProcessHookMessage), RequestHookMessage requestsRelated = default(RequestHookMessage), LifecycleHookMessage lifecycleHookMessage = default(LifecycleHookMessage), ElectionHookMessage electionHookMessage = default(ElectionHookMessage))
        {
            this.RenewalTaskCompleted = renewalTaskCompleted;
            this.TaskCreated = taskCreated;
            this.AutoImportCompleted = autoImportCompleted;
            this.RequestsRelated = requestsRelated;
            this.LifecycleHookMessage = lifecycleHookMessage;
            this.ElectionHookMessage = electionHookMessage;
        }

        /// <summary>
        /// When a Renewal Task is Completed
        /// </summary>
        /// <value>When a Renewal Task is Completed</value>
        [DataMember(Name = "renewalTaskCompleted", EmitDefaultValue = true)]
        public RenewalTaskHookMessage RenewalTaskCompleted { get; set; }

        /// <summary>
        /// Gets or Sets TaskCreated
        /// </summary>
        [DataMember(Name = "taskCreated", EmitDefaultValue = true)]
        public TaskHookMessage TaskCreated { get; set; }

        /// <summary>
        /// When an import process with pre-defined governance details or end user completes a confirm governance details task is completed
        /// </summary>
        /// <value>When an import process with pre-defined governance details or end user completes a confirm governance details task is completed</value>
        [DataMember(Name = "autoImportCompleted", EmitDefaultValue = true)]
        public AutoImportProcessHookMessage AutoImportCompleted { get; set; }

        /// <summary>
        /// Gets or Sets RequestsRelated
        /// </summary>
        [DataMember(Name = "requestsRelated", EmitDefaultValue = true)]
        public RequestHookMessage RequestsRelated { get; set; }

        /// <summary>
        /// Gets or Sets LifecycleHookMessage
        /// </summary>
        [DataMember(Name = "lifecycleHookMessage", EmitDefaultValue = true)]
        public LifecycleHookMessage LifecycleHookMessage { get; set; }

        /// <summary>
        /// Gets or Sets ElectionHookMessage
        /// </summary>
        [DataMember(Name = "electionHookMessage", EmitDefaultValue = true)]
        public ElectionHookMessage ElectionHookMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HookMessageList {\n");
            sb.Append("  RenewalTaskCompleted: ").Append(RenewalTaskCompleted).Append("\n");
            sb.Append("  TaskCreated: ").Append(TaskCreated).Append("\n");
            sb.Append("  AutoImportCompleted: ").Append(AutoImportCompleted).Append("\n");
            sb.Append("  RequestsRelated: ").Append(RequestsRelated).Append("\n");
            sb.Append("  LifecycleHookMessage: ").Append(LifecycleHookMessage).Append("\n");
            sb.Append("  ElectionHookMessage: ").Append(ElectionHookMessage).Append("\n");
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
            return this.Equals(input as HookMessageList);
        }

        /// <summary>
        /// Returns true if HookMessageList instances are equal
        /// </summary>
        /// <param name="input">Instance of HookMessageList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HookMessageList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RenewalTaskCompleted == input.RenewalTaskCompleted ||
                    (this.RenewalTaskCompleted != null &&
                    this.RenewalTaskCompleted.Equals(input.RenewalTaskCompleted))
                ) && 
                (
                    this.TaskCreated == input.TaskCreated ||
                    (this.TaskCreated != null &&
                    this.TaskCreated.Equals(input.TaskCreated))
                ) && 
                (
                    this.AutoImportCompleted == input.AutoImportCompleted ||
                    (this.AutoImportCompleted != null &&
                    this.AutoImportCompleted.Equals(input.AutoImportCompleted))
                ) && 
                (
                    this.RequestsRelated == input.RequestsRelated ||
                    (this.RequestsRelated != null &&
                    this.RequestsRelated.Equals(input.RequestsRelated))
                ) && 
                (
                    this.LifecycleHookMessage == input.LifecycleHookMessage ||
                    (this.LifecycleHookMessage != null &&
                    this.LifecycleHookMessage.Equals(input.LifecycleHookMessage))
                ) && 
                (
                    this.ElectionHookMessage == input.ElectionHookMessage ||
                    (this.ElectionHookMessage != null &&
                    this.ElectionHookMessage.Equals(input.ElectionHookMessage))
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
                if (this.RenewalTaskCompleted != null)
                    hashCode = hashCode * 59 + this.RenewalTaskCompleted.GetHashCode();
                if (this.TaskCreated != null)
                    hashCode = hashCode * 59 + this.TaskCreated.GetHashCode();
                if (this.AutoImportCompleted != null)
                    hashCode = hashCode * 59 + this.AutoImportCompleted.GetHashCode();
                if (this.RequestsRelated != null)
                    hashCode = hashCode * 59 + this.RequestsRelated.GetHashCode();
                if (this.LifecycleHookMessage != null)
                    hashCode = hashCode * 59 + this.LifecycleHookMessage.GetHashCode();
                if (this.ElectionHookMessage != null)
                    hashCode = hashCode * 59 + this.ElectionHookMessage.GetHashCode();
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
