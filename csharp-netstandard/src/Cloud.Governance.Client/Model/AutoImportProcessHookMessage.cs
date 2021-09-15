

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
    /// When an import process with pre-defined governance details or end user completes a confirm governance details task is completed
    /// </summary>
    [DataContract(Name = "AutoImportProcessHookMessage")]
    public partial class AutoImportProcessHookMessage : IEquatable<AutoImportProcessHookMessage>, IValidatableObject
    {
        /// <summary>
        /// Event type that being triggered, available values and corresponding messages:    RequestSubmitted,RequestCompleted,RequestCancelled - -- -&gt; RequestHookMessage  TaskCreated,TaskApproved,TaskRejected,ErrorTaskCreated,TaskRetried,TaskSkipped - -- -&gt; TaskHookMessage  RenewalSuccess RenewalException,RenewalOverdue - -- -&gt; RenewalTaskHookMessage  FullyAutoImportSuccess,ConfirmDetailSuccess - -- -&gt; AutoImportProcessHookMessage  ElectionCompleted,ElectionOverdue - --&gt; ElectionHookMessage  LifecycleInactiveTaskCreated,LifecycleLeaseTaskCreated - -- -&gt; ElectionOverdue
        /// </summary>
        /// <value>Event type that being triggered, available values and corresponding messages:    RequestSubmitted,RequestCompleted,RequestCancelled - -- -&gt; RequestHookMessage  TaskCreated,TaskApproved,TaskRejected,ErrorTaskCreated,TaskRetried,TaskSkipped - -- -&gt; TaskHookMessage  RenewalSuccess RenewalException,RenewalOverdue - -- -&gt; RenewalTaskHookMessage  FullyAutoImportSuccess,ConfirmDetailSuccess - -- -&gt; AutoImportProcessHookMessage  ElectionCompleted,ElectionOverdue - --&gt; ElectionHookMessage  LifecycleInactiveTaskCreated,LifecycleLeaseTaskCreated - -- -&gt; ElectionOverdue</value>
        [DataMember(Name = "triggerType", EmitDefaultValue = false)]
        public TriggerType? TriggerType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoImportProcessHookMessage" /> class.
        /// </summary>
        /// <param name="autoImportProfileName">Name of the import job.</param>
        /// <param name="taskLink">Link of task  &lt;sample&gt;abc&lt;/sample&gt;.</param>
        /// <param name="objectTitle">Name of the workspace.</param>
        /// <param name="objectType">Type of the workspace.</param>
        /// <param name="objectTypeEnum">Type enum of the workspace, availabe values:SiteCollection,Group,Team,GuestUser,Yammer.</param>
        /// <param name="groupEmail">E-mail address of the workspace.</param>
        /// <param name="triggerType">Event type that being triggered, available values and corresponding messages:    RequestSubmitted,RequestCompleted,RequestCancelled - -- -&gt; RequestHookMessage  TaskCreated,TaskApproved,TaskRejected,ErrorTaskCreated,TaskRetried,TaskSkipped - -- -&gt; TaskHookMessage  RenewalSuccess RenewalException,RenewalOverdue - -- -&gt; RenewalTaskHookMessage  FullyAutoImportSuccess,ConfirmDetailSuccess - -- -&gt; AutoImportProcessHookMessage  ElectionCompleted,ElectionOverdue - --&gt; ElectionHookMessage  LifecycleInactiveTaskCreated,LifecycleLeaseTaskCreated - -- -&gt; ElectionOverdue.</param>
        /// <param name="triggerTime">Time that the webhook is triggered.</param>
        /// <param name="objectUrl">URL of the workspace.</param>
        /// <param name="objectId">The unique ID of the workspace.</param>
        /// <param name="summary">Request or task summary.</param>
        public AutoImportProcessHookMessage(string autoImportProfileName = default(string), string taskLink = default(string), string objectTitle = default(string), string objectType = default(string), string objectTypeEnum = default(string), string groupEmail = default(string), TriggerType? triggerType = default(TriggerType?), DateTime triggerTime = default(DateTime), string objectUrl = default(string), Guid? objectId = default(Guid?), string summary = default(string))
        {
            this.AutoImportProfileName = autoImportProfileName;
            this.TaskLink = taskLink;
            this.ObjectTitle = objectTitle;
            this.ObjectType = objectType;
            this.ObjectTypeEnum = objectTypeEnum;
            this.GroupEmail = groupEmail;
            this.TriggerType = triggerType;
            this.TriggerTime = triggerTime;
            this.ObjectUrl = objectUrl;
            this.ObjectId = objectId;
            this.Summary = summary;
        }

        /// <summary>
        /// Name of the import job
        /// </summary>
        /// <value>Name of the import job</value>
        [DataMember(Name = "autoImportProfileName", EmitDefaultValue = true)]
        public string AutoImportProfileName { get; set; }

        /// <summary>
        /// Link of task  &lt;sample&gt;abc&lt;/sample&gt;
        /// </summary>
        /// <value>Link of task  &lt;sample&gt;abc&lt;/sample&gt;</value>
        [DataMember(Name = "taskLink", EmitDefaultValue = true)]
        public string TaskLink { get; set; }

        /// <summary>
        /// Name of the workspace
        /// </summary>
        /// <value>Name of the workspace</value>
        [DataMember(Name = "objectTitle", EmitDefaultValue = true)]
        public string ObjectTitle { get; set; }

        /// <summary>
        /// Type of the workspace
        /// </summary>
        /// <value>Type of the workspace</value>
        [DataMember(Name = "objectType", EmitDefaultValue = true)]
        public string ObjectType { get; set; }

        /// <summary>
        /// Type enum of the workspace, availabe values:SiteCollection,Group,Team,GuestUser,Yammer
        /// </summary>
        /// <value>Type enum of the workspace, availabe values:SiteCollection,Group,Team,GuestUser,Yammer</value>
        [DataMember(Name = "objectTypeEnum", EmitDefaultValue = true)]
        public string ObjectTypeEnum { get; set; }

        /// <summary>
        /// E-mail address of the workspace
        /// </summary>
        /// <value>E-mail address of the workspace</value>
        [DataMember(Name = "groupEmail", EmitDefaultValue = true)]
        public string GroupEmail { get; set; }

        /// <summary>
        /// Time that the webhook is triggered
        /// </summary>
        /// <value>Time that the webhook is triggered</value>
        [DataMember(Name = "triggerTime", EmitDefaultValue = false)]
        public DateTime TriggerTime { get; set; }

        /// <summary>
        /// URL of the workspace
        /// </summary>
        /// <value>URL of the workspace</value>
        [DataMember(Name = "objectUrl", EmitDefaultValue = true)]
        public string ObjectUrl { get; set; }

        /// <summary>
        /// The unique ID of the workspace
        /// </summary>
        /// <value>The unique ID of the workspace</value>
        [DataMember(Name = "objectId", EmitDefaultValue = true)]
        public Guid? ObjectId { get; set; }

        /// <summary>
        /// Request or task summary
        /// </summary>
        /// <value>Request or task summary</value>
        [DataMember(Name = "summary", EmitDefaultValue = true)]
        public string Summary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoImportProcessHookMessage {\n");
            sb.Append("  AutoImportProfileName: ").Append(AutoImportProfileName).Append("\n");
            sb.Append("  TaskLink: ").Append(TaskLink).Append("\n");
            sb.Append("  ObjectTitle: ").Append(ObjectTitle).Append("\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
            sb.Append("  ObjectTypeEnum: ").Append(ObjectTypeEnum).Append("\n");
            sb.Append("  GroupEmail: ").Append(GroupEmail).Append("\n");
            sb.Append("  TriggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  TriggerTime: ").Append(TriggerTime).Append("\n");
            sb.Append("  ObjectUrl: ").Append(ObjectUrl).Append("\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
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
            return this.Equals(input as AutoImportProcessHookMessage);
        }

        /// <summary>
        /// Returns true if AutoImportProcessHookMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of AutoImportProcessHookMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutoImportProcessHookMessage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoImportProfileName == input.AutoImportProfileName ||
                    (this.AutoImportProfileName != null &&
                    this.AutoImportProfileName.Equals(input.AutoImportProfileName))
                ) && 
                (
                    this.TaskLink == input.TaskLink ||
                    (this.TaskLink != null &&
                    this.TaskLink.Equals(input.TaskLink))
                ) && 
                (
                    this.ObjectTitle == input.ObjectTitle ||
                    (this.ObjectTitle != null &&
                    this.ObjectTitle.Equals(input.ObjectTitle))
                ) && 
                (
                    this.ObjectType == input.ObjectType ||
                    (this.ObjectType != null &&
                    this.ObjectType.Equals(input.ObjectType))
                ) && 
                (
                    this.ObjectTypeEnum == input.ObjectTypeEnum ||
                    (this.ObjectTypeEnum != null &&
                    this.ObjectTypeEnum.Equals(input.ObjectTypeEnum))
                ) && 
                (
                    this.GroupEmail == input.GroupEmail ||
                    (this.GroupEmail != null &&
                    this.GroupEmail.Equals(input.GroupEmail))
                ) && 
                (
                    this.TriggerType == input.TriggerType ||
                    this.TriggerType.Equals(input.TriggerType)
                ) && 
                (
                    this.TriggerTime == input.TriggerTime ||
                    (this.TriggerTime != null &&
                    this.TriggerTime.Equals(input.TriggerTime))
                ) && 
                (
                    this.ObjectUrl == input.ObjectUrl ||
                    (this.ObjectUrl != null &&
                    this.ObjectUrl.Equals(input.ObjectUrl))
                ) && 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
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
                if (this.AutoImportProfileName != null)
                    hashCode = hashCode * 59 + this.AutoImportProfileName.GetHashCode();
                if (this.TaskLink != null)
                    hashCode = hashCode * 59 + this.TaskLink.GetHashCode();
                if (this.ObjectTitle != null)
                    hashCode = hashCode * 59 + this.ObjectTitle.GetHashCode();
                if (this.ObjectType != null)
                    hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.ObjectTypeEnum != null)
                    hashCode = hashCode * 59 + this.ObjectTypeEnum.GetHashCode();
                if (this.GroupEmail != null)
                    hashCode = hashCode * 59 + this.GroupEmail.GetHashCode();
                hashCode = hashCode * 59 + this.TriggerType.GetHashCode();
                if (this.TriggerTime != null)
                    hashCode = hashCode * 59 + this.TriggerTime.GetHashCode();
                if (this.ObjectUrl != null)
                    hashCode = hashCode * 59 + this.ObjectUrl.GetHashCode();
                if (this.ObjectId != null)
                    hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
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
