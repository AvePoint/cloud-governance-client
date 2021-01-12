

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
    /// ManagePermissionSharePointGroupOption
    /// </summary>
    [DataContract(Name = "ManagePermissionSharePointGroupOption")]
    public partial class ManagePermissionSharePointGroupOption : IEquatable<ManagePermissionSharePointGroupOption>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets GroupOwnerAssignBy
        /// </summary>
        [DataMember(Name = "groupOwnerAssignBy", EmitDefaultValue = false)]
        public AssignBy? GroupOwnerAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets SpGroupViewType
        /// </summary>
        [DataMember(Name = "spGroupViewType", EmitDefaultValue = false)]
        public SPGroupViewOption? SpGroupViewType { get; set; }
        /// <summary>
        /// Gets or Sets SpGroupEditType
        /// </summary>
        [DataMember(Name = "spGroupEditType", EmitDefaultValue = false)]
        public SPGroupEditOption? SpGroupEditType { get; set; }
        /// <summary>
        /// Gets or Sets SpGroupOptionAssignBy
        /// </summary>
        [DataMember(Name = "spGroupOptionAssignBy", EmitDefaultValue = false)]
        public AssignBy? SpGroupOptionAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets GroupRequestAssignBy
        /// </summary>
        [DataMember(Name = "groupRequestAssignBy", EmitDefaultValue = false)]
        public AssignBy? GroupRequestAssignBy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagePermissionSharePointGroupOption" /> class.
        /// </summary>
        /// <param name="isEnableCreateSPGroup">isEnableCreateSPGroup.</param>
        /// <param name="isEnableDeleteSPGroup">isEnableDeleteSPGroup.</param>
        /// <param name="isEnableManageGroupSettings">isEnableManageGroupSettings.</param>
        /// <param name="isEnableManageGroupMembers">isEnableManageGroupMembers.</param>
        /// <param name="groupOwner">groupOwner.</param>
        /// <param name="groupOwnerAssignBy">groupOwnerAssignBy.</param>
        /// <param name="spGroupViewType">spGroupViewType.</param>
        /// <param name="spGroupEditType">spGroupEditType.</param>
        /// <param name="spGroupOptionAssignBy">spGroupOptionAssignBy.</param>
        /// <param name="isAllowJoinOrLeaveRequest">isAllowJoinOrLeaveRequest.</param>
        /// <param name="isAutoAcceptRequest">isAutoAcceptRequest.</param>
        /// <param name="sendMembershipRequestEmailAddress">sendMembershipRequestEmailAddress.</param>
        /// <param name="groupRequestAssignBy">groupRequestAssignBy.</param>
        public ManagePermissionSharePointGroupOption(bool isEnableCreateSPGroup = default(bool), bool isEnableDeleteSPGroup = default(bool), bool isEnableManageGroupSettings = default(bool), bool isEnableManageGroupMembers = default(bool), ApiUser groupOwner = default(ApiUser), AssignBy? groupOwnerAssignBy = default(AssignBy?), SPGroupViewOption? spGroupViewType = default(SPGroupViewOption?), SPGroupEditOption? spGroupEditType = default(SPGroupEditOption?), AssignBy? spGroupOptionAssignBy = default(AssignBy?), bool isAllowJoinOrLeaveRequest = default(bool), bool isAutoAcceptRequest = default(bool), string sendMembershipRequestEmailAddress = default(string), AssignBy? groupRequestAssignBy = default(AssignBy?))
        {
            this.IsEnableCreateSPGroup = isEnableCreateSPGroup;
            this.IsEnableDeleteSPGroup = isEnableDeleteSPGroup;
            this.IsEnableManageGroupSettings = isEnableManageGroupSettings;
            this.IsEnableManageGroupMembers = isEnableManageGroupMembers;
            this.GroupOwner = groupOwner;
            this.GroupOwnerAssignBy = groupOwnerAssignBy;
            this.SpGroupViewType = spGroupViewType;
            this.SpGroupEditType = spGroupEditType;
            this.SpGroupOptionAssignBy = spGroupOptionAssignBy;
            this.IsAllowJoinOrLeaveRequest = isAllowJoinOrLeaveRequest;
            this.IsAutoAcceptRequest = isAutoAcceptRequest;
            this.SendMembershipRequestEmailAddress = sendMembershipRequestEmailAddress;
            this.GroupRequestAssignBy = groupRequestAssignBy;
        }

        /// <summary>
        /// Gets or Sets IsEnableCreateSPGroup
        /// </summary>
        [DataMember(Name = "isEnableCreateSPGroup", EmitDefaultValue = false)]
        public bool IsEnableCreateSPGroup { get; set; }

        /// <summary>
        /// Gets or Sets IsEnableDeleteSPGroup
        /// </summary>
        [DataMember(Name = "isEnableDeleteSPGroup", EmitDefaultValue = false)]
        public bool IsEnableDeleteSPGroup { get; set; }

        /// <summary>
        /// Gets or Sets IsEnableManageGroupSettings
        /// </summary>
        [DataMember(Name = "isEnableManageGroupSettings", EmitDefaultValue = false)]
        public bool IsEnableManageGroupSettings { get; set; }

        /// <summary>
        /// Gets or Sets IsEnableManageGroupMembers
        /// </summary>
        [DataMember(Name = "isEnableManageGroupMembers", EmitDefaultValue = false)]
        public bool IsEnableManageGroupMembers { get; set; }

        /// <summary>
        /// Gets or Sets GroupOwner
        /// </summary>
        [DataMember(Name = "groupOwner", EmitDefaultValue = true)]
        public ApiUser GroupOwner { get; set; }

        /// <summary>
        /// Gets or Sets IsAllowJoinOrLeaveRequest
        /// </summary>
        [DataMember(Name = "isAllowJoinOrLeaveRequest", EmitDefaultValue = false)]
        public bool IsAllowJoinOrLeaveRequest { get; set; }

        /// <summary>
        /// Gets or Sets IsAutoAcceptRequest
        /// </summary>
        [DataMember(Name = "isAutoAcceptRequest", EmitDefaultValue = false)]
        public bool IsAutoAcceptRequest { get; set; }

        /// <summary>
        /// Gets or Sets SendMembershipRequestEmailAddress
        /// </summary>
        [DataMember(Name = "sendMembershipRequestEmailAddress", EmitDefaultValue = true)]
        public string SendMembershipRequestEmailAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManagePermissionSharePointGroupOption {\n");
            sb.Append("  IsEnableCreateSPGroup: ").Append(IsEnableCreateSPGroup).Append("\n");
            sb.Append("  IsEnableDeleteSPGroup: ").Append(IsEnableDeleteSPGroup).Append("\n");
            sb.Append("  IsEnableManageGroupSettings: ").Append(IsEnableManageGroupSettings).Append("\n");
            sb.Append("  IsEnableManageGroupMembers: ").Append(IsEnableManageGroupMembers).Append("\n");
            sb.Append("  GroupOwner: ").Append(GroupOwner).Append("\n");
            sb.Append("  GroupOwnerAssignBy: ").Append(GroupOwnerAssignBy).Append("\n");
            sb.Append("  SpGroupViewType: ").Append(SpGroupViewType).Append("\n");
            sb.Append("  SpGroupEditType: ").Append(SpGroupEditType).Append("\n");
            sb.Append("  SpGroupOptionAssignBy: ").Append(SpGroupOptionAssignBy).Append("\n");
            sb.Append("  IsAllowJoinOrLeaveRequest: ").Append(IsAllowJoinOrLeaveRequest).Append("\n");
            sb.Append("  IsAutoAcceptRequest: ").Append(IsAutoAcceptRequest).Append("\n");
            sb.Append("  SendMembershipRequestEmailAddress: ").Append(SendMembershipRequestEmailAddress).Append("\n");
            sb.Append("  GroupRequestAssignBy: ").Append(GroupRequestAssignBy).Append("\n");
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
            return this.Equals(input as ManagePermissionSharePointGroupOption);
        }

        /// <summary>
        /// Returns true if ManagePermissionSharePointGroupOption instances are equal
        /// </summary>
        /// <param name="input">Instance of ManagePermissionSharePointGroupOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManagePermissionSharePointGroupOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsEnableCreateSPGroup == input.IsEnableCreateSPGroup ||
                    this.IsEnableCreateSPGroup.Equals(input.IsEnableCreateSPGroup)
                ) && 
                (
                    this.IsEnableDeleteSPGroup == input.IsEnableDeleteSPGroup ||
                    this.IsEnableDeleteSPGroup.Equals(input.IsEnableDeleteSPGroup)
                ) && 
                (
                    this.IsEnableManageGroupSettings == input.IsEnableManageGroupSettings ||
                    this.IsEnableManageGroupSettings.Equals(input.IsEnableManageGroupSettings)
                ) && 
                (
                    this.IsEnableManageGroupMembers == input.IsEnableManageGroupMembers ||
                    this.IsEnableManageGroupMembers.Equals(input.IsEnableManageGroupMembers)
                ) && 
                (
                    this.GroupOwner == input.GroupOwner ||
                    (this.GroupOwner != null &&
                    this.GroupOwner.Equals(input.GroupOwner))
                ) && 
                (
                    this.GroupOwnerAssignBy == input.GroupOwnerAssignBy ||
                    this.GroupOwnerAssignBy.Equals(input.GroupOwnerAssignBy)
                ) && 
                (
                    this.SpGroupViewType == input.SpGroupViewType ||
                    this.SpGroupViewType.Equals(input.SpGroupViewType)
                ) && 
                (
                    this.SpGroupEditType == input.SpGroupEditType ||
                    this.SpGroupEditType.Equals(input.SpGroupEditType)
                ) && 
                (
                    this.SpGroupOptionAssignBy == input.SpGroupOptionAssignBy ||
                    this.SpGroupOptionAssignBy.Equals(input.SpGroupOptionAssignBy)
                ) && 
                (
                    this.IsAllowJoinOrLeaveRequest == input.IsAllowJoinOrLeaveRequest ||
                    this.IsAllowJoinOrLeaveRequest.Equals(input.IsAllowJoinOrLeaveRequest)
                ) && 
                (
                    this.IsAutoAcceptRequest == input.IsAutoAcceptRequest ||
                    this.IsAutoAcceptRequest.Equals(input.IsAutoAcceptRequest)
                ) && 
                (
                    this.SendMembershipRequestEmailAddress == input.SendMembershipRequestEmailAddress ||
                    (this.SendMembershipRequestEmailAddress != null &&
                    this.SendMembershipRequestEmailAddress.Equals(input.SendMembershipRequestEmailAddress))
                ) && 
                (
                    this.GroupRequestAssignBy == input.GroupRequestAssignBy ||
                    this.GroupRequestAssignBy.Equals(input.GroupRequestAssignBy)
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
                hashCode = hashCode * 59 + this.IsEnableCreateSPGroup.GetHashCode();
                hashCode = hashCode * 59 + this.IsEnableDeleteSPGroup.GetHashCode();
                hashCode = hashCode * 59 + this.IsEnableManageGroupSettings.GetHashCode();
                hashCode = hashCode * 59 + this.IsEnableManageGroupMembers.GetHashCode();
                if (this.GroupOwner != null)
                    hashCode = hashCode * 59 + this.GroupOwner.GetHashCode();
                hashCode = hashCode * 59 + this.GroupOwnerAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.SpGroupViewType.GetHashCode();
                hashCode = hashCode * 59 + this.SpGroupEditType.GetHashCode();
                hashCode = hashCode * 59 + this.SpGroupOptionAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.IsAllowJoinOrLeaveRequest.GetHashCode();
                hashCode = hashCode * 59 + this.IsAutoAcceptRequest.GetHashCode();
                if (this.SendMembershipRequestEmailAddress != null)
                    hashCode = hashCode * 59 + this.SendMembershipRequestEmailAddress.GetHashCode();
                hashCode = hashCode * 59 + this.GroupRequestAssignBy.GetHashCode();
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
