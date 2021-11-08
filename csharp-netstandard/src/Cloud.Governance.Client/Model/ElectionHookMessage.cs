

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
    /// ElectionHookMessage
    /// </summary>
    [DataContract(Name = "ElectionHookMessage")]
    public partial class ElectionHookMessage : IEquatable<ElectionHookMessage>, IValidatableObject
    {
        /// <summary>
        /// Type enum of the workspace, availabe values:SiteCollection,Group,Team,GuestUser,Yammer
        /// </summary>
        /// <value>Type enum of the workspace, availabe values:SiteCollection,Group,Team,GuestUser,Yammer</value>
        [DataMember(Name = "objectTypeEnum", EmitDefaultValue = false)]
        public HookMessageObjectType? ObjectTypeEnum { get; set; }
        /// <summary>
        /// Event type that being triggered, available values and corresponding messages:    RequestSubmitted,RequestCompleted,RequestCancelled - -- -&gt; RequestHookMessage  TaskCreated,TaskApproved,TaskRejected,ErrorTaskCreated,TaskRetried,TaskSkipped - -- -&gt; TaskHookMessage  RenewalSuccess RenewalException,RenewalOverdue - -- -&gt; RenewalTaskHookMessage  FullyAutoImportSuccess,ConfirmDetailSuccess - -- -&gt; AutoImportProcessHookMessage  ElectionCompleted,ElectionOverdue - --&gt; ElectionHookMessage  LifecycleInactiveTaskCreated,LifecycleLeaseTaskCreated - -- -&gt; ElectionOverdue
        /// </summary>
        /// <value>Event type that being triggered, available values and corresponding messages:    RequestSubmitted,RequestCompleted,RequestCancelled - -- -&gt; RequestHookMessage  TaskCreated,TaskApproved,TaskRejected,ErrorTaskCreated,TaskRetried,TaskSkipped - -- -&gt; TaskHookMessage  RenewalSuccess RenewalException,RenewalOverdue - -- -&gt; RenewalTaskHookMessage  FullyAutoImportSuccess,ConfirmDetailSuccess - -- -&gt; AutoImportProcessHookMessage  ElectionCompleted,ElectionOverdue - --&gt; ElectionHookMessage  LifecycleInactiveTaskCreated,LifecycleLeaseTaskCreated - -- -&gt; ElectionOverdue</value>
        [DataMember(Name = "triggerType", EmitDefaultValue = false)]
        public TriggerType? TriggerType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectionHookMessage" /> class.
        /// </summary>
        /// <param name="serviceType">Type enum of election, available values: Group Deactivated Contact Election, Site Collection Deactivated Contact Election  , Elect Contact, Specify contact.</param>
        /// <param name="isPrimaryContactDeactived">Is primary contact deactived (default to false).</param>
        /// <param name="originalPrimaryContact">Original primary contact.</param>
        /// <param name="isPrimaryContactChanged">Is primary contact changed (default to false).</param>
        /// <param name="newPrimaryContact">New primary contact.</param>
        /// <param name="isSecondaryContactDeactived">Is secondary contact deactived (default to false).</param>
        /// <param name="originalSecondaryContact">Original secondary contact.</param>
        /// <param name="isSecondaryContactChanged">Is secondary contact changed (default to false).</param>
        /// <param name="newSecondaryContact">New secondary contact.</param>
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
        public ElectionHookMessage(string serviceType = default(string), bool isPrimaryContactDeactived = false, ElectionContact originalPrimaryContact = default(ElectionContact), bool isPrimaryContactChanged = false, ElectionContact newPrimaryContact = default(ElectionContact), bool isSecondaryContactDeactived = false, ElectionContact originalSecondaryContact = default(ElectionContact), bool isSecondaryContactChanged = false, ElectionContact newSecondaryContact = default(ElectionContact), string taskLink = default(string), string objectTitle = default(string), string objectType = default(string), HookMessageObjectType? objectTypeEnum = default(HookMessageObjectType?), string groupEmail = default(string), TriggerType? triggerType = default(TriggerType?), DateTime triggerTime = default(DateTime), string objectUrl = default(string), Guid? objectId = default(Guid?), string summary = default(string))
        {
            this.ServiceType = serviceType;
            this.IsPrimaryContactDeactived = isPrimaryContactDeactived;
            this.OriginalPrimaryContact = originalPrimaryContact;
            this.IsPrimaryContactChanged = isPrimaryContactChanged;
            this.NewPrimaryContact = newPrimaryContact;
            this.IsSecondaryContactDeactived = isSecondaryContactDeactived;
            this.OriginalSecondaryContact = originalSecondaryContact;
            this.IsSecondaryContactChanged = isSecondaryContactChanged;
            this.NewSecondaryContact = newSecondaryContact;
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
        /// Type enum of election, available values: Group Deactivated Contact Election, Site Collection Deactivated Contact Election  , Elect Contact, Specify contact
        /// </summary>
        /// <value>Type enum of election, available values: Group Deactivated Contact Election, Site Collection Deactivated Contact Election  , Elect Contact, Specify contact</value>
        [DataMember(Name = "serviceType", EmitDefaultValue = true)]
        public string ServiceType { get; set; }

        /// <summary>
        /// Is primary contact deactived
        /// </summary>
        /// <value>Is primary contact deactived</value>
        [DataMember(Name = "isPrimaryContactDeactived", EmitDefaultValue = false)]
        public bool IsPrimaryContactDeactived { get; set; }

        /// <summary>
        /// Original primary contact
        /// </summary>
        /// <value>Original primary contact</value>
        [DataMember(Name = "originalPrimaryContact", EmitDefaultValue = true)]
        public ElectionContact OriginalPrimaryContact { get; set; }

        /// <summary>
        /// Is primary contact changed
        /// </summary>
        /// <value>Is primary contact changed</value>
        [DataMember(Name = "isPrimaryContactChanged", EmitDefaultValue = false)]
        public bool IsPrimaryContactChanged { get; set; }

        /// <summary>
        /// New primary contact
        /// </summary>
        /// <value>New primary contact</value>
        [DataMember(Name = "newPrimaryContact", EmitDefaultValue = true)]
        public ElectionContact NewPrimaryContact { get; set; }

        /// <summary>
        /// Is secondary contact deactived
        /// </summary>
        /// <value>Is secondary contact deactived</value>
        [DataMember(Name = "isSecondaryContactDeactived", EmitDefaultValue = false)]
        public bool IsSecondaryContactDeactived { get; set; }

        /// <summary>
        /// Original secondary contact
        /// </summary>
        /// <value>Original secondary contact</value>
        [DataMember(Name = "originalSecondaryContact", EmitDefaultValue = true)]
        public ElectionContact OriginalSecondaryContact { get; set; }

        /// <summary>
        /// Is secondary contact changed
        /// </summary>
        /// <value>Is secondary contact changed</value>
        [DataMember(Name = "isSecondaryContactChanged", EmitDefaultValue = false)]
        public bool IsSecondaryContactChanged { get; set; }

        /// <summary>
        /// New secondary contact
        /// </summary>
        /// <value>New secondary contact</value>
        [DataMember(Name = "newSecondaryContact", EmitDefaultValue = true)]
        public ElectionContact NewSecondaryContact { get; set; }

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
            sb.Append("class ElectionHookMessage {\n");
            sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
            sb.Append("  IsPrimaryContactDeactived: ").Append(IsPrimaryContactDeactived).Append("\n");
            sb.Append("  OriginalPrimaryContact: ").Append(OriginalPrimaryContact).Append("\n");
            sb.Append("  IsPrimaryContactChanged: ").Append(IsPrimaryContactChanged).Append("\n");
            sb.Append("  NewPrimaryContact: ").Append(NewPrimaryContact).Append("\n");
            sb.Append("  IsSecondaryContactDeactived: ").Append(IsSecondaryContactDeactived).Append("\n");
            sb.Append("  OriginalSecondaryContact: ").Append(OriginalSecondaryContact).Append("\n");
            sb.Append("  IsSecondaryContactChanged: ").Append(IsSecondaryContactChanged).Append("\n");
            sb.Append("  NewSecondaryContact: ").Append(NewSecondaryContact).Append("\n");
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
            return this.Equals(input as ElectionHookMessage);
        }

        /// <summary>
        /// Returns true if ElectionHookMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of ElectionHookMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ElectionHookMessage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServiceType == input.ServiceType ||
                    (this.ServiceType != null &&
                    this.ServiceType.Equals(input.ServiceType))
                ) && 
                (
                    this.IsPrimaryContactDeactived == input.IsPrimaryContactDeactived ||
                    this.IsPrimaryContactDeactived.Equals(input.IsPrimaryContactDeactived)
                ) && 
                (
                    this.OriginalPrimaryContact == input.OriginalPrimaryContact ||
                    (this.OriginalPrimaryContact != null &&
                    this.OriginalPrimaryContact.Equals(input.OriginalPrimaryContact))
                ) && 
                (
                    this.IsPrimaryContactChanged == input.IsPrimaryContactChanged ||
                    this.IsPrimaryContactChanged.Equals(input.IsPrimaryContactChanged)
                ) && 
                (
                    this.NewPrimaryContact == input.NewPrimaryContact ||
                    (this.NewPrimaryContact != null &&
                    this.NewPrimaryContact.Equals(input.NewPrimaryContact))
                ) && 
                (
                    this.IsSecondaryContactDeactived == input.IsSecondaryContactDeactived ||
                    this.IsSecondaryContactDeactived.Equals(input.IsSecondaryContactDeactived)
                ) && 
                (
                    this.OriginalSecondaryContact == input.OriginalSecondaryContact ||
                    (this.OriginalSecondaryContact != null &&
                    this.OriginalSecondaryContact.Equals(input.OriginalSecondaryContact))
                ) && 
                (
                    this.IsSecondaryContactChanged == input.IsSecondaryContactChanged ||
                    this.IsSecondaryContactChanged.Equals(input.IsSecondaryContactChanged)
                ) && 
                (
                    this.NewSecondaryContact == input.NewSecondaryContact ||
                    (this.NewSecondaryContact != null &&
                    this.NewSecondaryContact.Equals(input.NewSecondaryContact))
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
                    this.ObjectTypeEnum.Equals(input.ObjectTypeEnum)
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
                if (this.ServiceType != null)
                    hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                hashCode = hashCode * 59 + this.IsPrimaryContactDeactived.GetHashCode();
                if (this.OriginalPrimaryContact != null)
                    hashCode = hashCode * 59 + this.OriginalPrimaryContact.GetHashCode();
                hashCode = hashCode * 59 + this.IsPrimaryContactChanged.GetHashCode();
                if (this.NewPrimaryContact != null)
                    hashCode = hashCode * 59 + this.NewPrimaryContact.GetHashCode();
                hashCode = hashCode * 59 + this.IsSecondaryContactDeactived.GetHashCode();
                if (this.OriginalSecondaryContact != null)
                    hashCode = hashCode * 59 + this.OriginalSecondaryContact.GetHashCode();
                hashCode = hashCode * 59 + this.IsSecondaryContactChanged.GetHashCode();
                if (this.NewSecondaryContact != null)
                    hashCode = hashCode * 59 + this.NewSecondaryContact.GetHashCode();
                if (this.TaskLink != null)
                    hashCode = hashCode * 59 + this.TaskLink.GetHashCode();
                if (this.ObjectTitle != null)
                    hashCode = hashCode * 59 + this.ObjectTitle.GetHashCode();
                if (this.ObjectType != null)
                    hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
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
