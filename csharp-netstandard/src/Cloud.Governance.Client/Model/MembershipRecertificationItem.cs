/* 
 * Cloud Governance Api
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Cloud.Governance.Client.Client.OpenAPIDateConverter;

namespace Cloud.Governance.Client.Model
{
    /// <summary>
    /// MembershipRecertificationItem
    /// </summary>
    [DataContract]
    public partial class MembershipRecertificationItem :  IEquatable<MembershipRecertificationItem>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public RecertificationActionType? Type { get; set; }
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public RenewalItemAction? Action { get; set; }
        /// <summary>
        /// Gets or Sets MembershipType
        /// </summary>
        [DataMember(Name="membershipType", EmitDefaultValue=false)]
        public MembershipType? MembershipType { get; set; }
        /// <summary>
        /// Gets or Sets AccessType
        /// </summary>
        [DataMember(Name="accessType", EmitDefaultValue=false)]
        public UserAccessType? AccessType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MembershipRecertificationItem" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="instanceId">instanceId.</param>
        /// <param name="type">type.</param>
        /// <param name="taskId">taskId.</param>
        /// <param name="action">action.</param>
        /// <param name="user">user.</param>
        /// <param name="userDisplayName">userDisplayName.</param>
        /// <param name="membershipType">membershipType.</param>
        /// <param name="accessType">accessType.</param>
        public MembershipRecertificationItem(Guid id = default(Guid), Guid instanceId = default(Guid), RecertificationActionType type = default(RecertificationActionType), Guid? taskId = default(Guid?), RenewalItemAction action = default(RenewalItemAction), string user = default(string), string userDisplayName = default(string), MembershipType membershipType = default(MembershipType), UserAccessType accessType = default(UserAccessType))
        {
            this.Id = id;
            this.InstanceId = instanceId;
            this.Type = type;
            this.TaskId = taskId;
            this.Action = action;
            this.User = user;
            this.UserDisplayName = userDisplayName;
            this.MembershipType = membershipType;
            this.AccessType = accessType;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets InstanceId
        /// </summary>
        [DataMember(Name="instanceId", EmitDefaultValue=false)]
        public Guid InstanceId { get; set; }

        /// <summary>
        /// Gets or Sets TaskId
        /// </summary>
        [DataMember(Name="taskId", EmitDefaultValue=true)]
        public Guid? TaskId { get; set; }

        /// <summary>
        /// Gets or Sets ActionDescription
        /// </summary>
        [DataMember(Name="actionDescription", EmitDefaultValue=true)]
        public string ActionDescription { get; private set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=true)]
        public string User { get; set; }

        /// <summary>
        /// Gets or Sets UserDisplayName
        /// </summary>
        [DataMember(Name="userDisplayName", EmitDefaultValue=true)]
        public string UserDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets MembershipTypeDescription
        /// </summary>
        [DataMember(Name="membershipTypeDescription", EmitDefaultValue=true)]
        public string MembershipTypeDescription { get; private set; }

        /// <summary>
        /// Gets or Sets AccessTypeDescription
        /// </summary>
        [DataMember(Name="accessTypeDescription", EmitDefaultValue=true)]
        public string AccessTypeDescription { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MembershipRecertificationItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ActionDescription: ").Append(ActionDescription).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  UserDisplayName: ").Append(UserDisplayName).Append("\n");
            sb.Append("  MembershipType: ").Append(MembershipType).Append("\n");
            sb.Append("  MembershipTypeDescription: ").Append(MembershipTypeDescription).Append("\n");
            sb.Append("  AccessType: ").Append(AccessType).Append("\n");
            sb.Append("  AccessTypeDescription: ").Append(AccessTypeDescription).Append("\n");
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
            return this.Equals(input as MembershipRecertificationItem);
        }

        /// <summary>
        /// Returns true if MembershipRecertificationItem instances are equal
        /// </summary>
        /// <param name="input">Instance of MembershipRecertificationItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MembershipRecertificationItem input)
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
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
                ) && 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
                ) && 
                (
                    this.ActionDescription == input.ActionDescription ||
                    (this.ActionDescription != null &&
                    this.ActionDescription.Equals(input.ActionDescription))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.UserDisplayName == input.UserDisplayName ||
                    (this.UserDisplayName != null &&
                    this.UserDisplayName.Equals(input.UserDisplayName))
                ) && 
                (
                    this.MembershipType == input.MembershipType ||
                    this.MembershipType.Equals(input.MembershipType)
                ) && 
                (
                    this.MembershipTypeDescription == input.MembershipTypeDescription ||
                    (this.MembershipTypeDescription != null &&
                    this.MembershipTypeDescription.Equals(input.MembershipTypeDescription))
                ) && 
                (
                    this.AccessType == input.AccessType ||
                    this.AccessType.Equals(input.AccessType)
                ) && 
                (
                    this.AccessTypeDescription == input.AccessTypeDescription ||
                    (this.AccessTypeDescription != null &&
                    this.AccessTypeDescription.Equals(input.AccessTypeDescription))
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
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.ActionDescription != null)
                    hashCode = hashCode * 59 + this.ActionDescription.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.UserDisplayName != null)
                    hashCode = hashCode * 59 + this.UserDisplayName.GetHashCode();
                hashCode = hashCode * 59 + this.MembershipType.GetHashCode();
                if (this.MembershipTypeDescription != null)
                    hashCode = hashCode * 59 + this.MembershipTypeDescription.GetHashCode();
                hashCode = hashCode * 59 + this.AccessType.GetHashCode();
                if (this.AccessTypeDescription != null)
                    hashCode = hashCode * 59 + this.AccessTypeDescription.GetHashCode();
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
