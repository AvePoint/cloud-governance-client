

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
    /// SPGroupManagementModel
    /// </summary>
    [DataContract(Name = "SPGroupManagementModel")]
    public partial class SPGroupManagementModel : IEquatable<SPGroupManagementModel>, IValidatableObject
    {
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
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public ManagePermissionAction? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SPGroupManagementModel" /> class.
        /// </summary>
        /// <param name="id">id (default to 0).</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="owner">owner.</param>
        /// <param name="members">members.</param>
        /// <param name="spGroupViewType">spGroupViewType.</param>
        /// <param name="spGroupEditType">spGroupEditType.</param>
        /// <param name="permissions">permissions.</param>
        /// <param name="action">action.</param>
        /// <param name="isAllowJoinOrLeaveRequest">isAllowJoinOrLeaveRequest (default to false).</param>
        /// <param name="isAutoAcceptRequest">isAutoAcceptRequest (default to false).</param>
        /// <param name="sendMembershipRequestEmailAddress">sendMembershipRequestEmailAddress.</param>
        /// <param name="isTemporaryGroup">isTemporaryGroup (default to false).</param>
        /// <param name="roleID">roleID.</param>
        public SPGroupManagementModel(int id = 0, StringChangedProperty name = default(StringChangedProperty), string description = default(string), ApiUser owner = default(ApiUser), List<SPUserManagementModel> members = default(List<SPUserManagementModel>), SPGroupViewOption? spGroupViewType = default(SPGroupViewOption?), SPGroupEditOption? spGroupEditType = default(SPGroupEditOption?), List<string> permissions = default(List<string>), ManagePermissionAction? action = default(ManagePermissionAction?), bool isAllowJoinOrLeaveRequest = false, bool isAutoAcceptRequest = false, string sendMembershipRequestEmailAddress = default(string), bool isTemporaryGroup = false, List<string> roleID = default(List<string>))
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Owner = owner;
            this.Members = members;
            this.SpGroupViewType = spGroupViewType;
            this.SpGroupEditType = spGroupEditType;
            this.Permissions = permissions;
            this.Action = action;
            this.IsAllowJoinOrLeaveRequest = isAllowJoinOrLeaveRequest;
            this.IsAutoAcceptRequest = isAutoAcceptRequest;
            this.SendMembershipRequestEmailAddress = sendMembershipRequestEmailAddress;
            this.IsTemporaryGroup = isTemporaryGroup;
            this.RoleID = roleID;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public StringChangedProperty Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name = "owner", EmitDefaultValue = true)]
        public ApiUser Owner { get; set; }

        /// <summary>
        /// Gets or Sets Members
        /// </summary>
        [DataMember(Name = "members", EmitDefaultValue = true)]
        public List<SPUserManagementModel> Members { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name = "permissions", EmitDefaultValue = true)]
        public List<string> Permissions { get; set; }

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
        /// Gets or Sets IsTemporaryGroup
        /// </summary>
        [DataMember(Name = "isTemporaryGroup", EmitDefaultValue = false)]
        public bool IsTemporaryGroup { get; set; }

        /// <summary>
        /// Gets or Sets RoleID
        /// </summary>
        [DataMember(Name = "roleID", EmitDefaultValue = true)]
        public List<string> RoleID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SPGroupManagementModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  SpGroupViewType: ").Append(SpGroupViewType).Append("\n");
            sb.Append("  SpGroupEditType: ").Append(SpGroupEditType).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  IsAllowJoinOrLeaveRequest: ").Append(IsAllowJoinOrLeaveRequest).Append("\n");
            sb.Append("  IsAutoAcceptRequest: ").Append(IsAutoAcceptRequest).Append("\n");
            sb.Append("  SendMembershipRequestEmailAddress: ").Append(SendMembershipRequestEmailAddress).Append("\n");
            sb.Append("  IsTemporaryGroup: ").Append(IsTemporaryGroup).Append("\n");
            sb.Append("  RoleID: ").Append(RoleID).Append("\n");
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
            return this.Equals(input as SPGroupManagementModel);
        }

        /// <summary>
        /// Returns true if SPGroupManagementModel instances are equal
        /// </summary>
        /// <param name="input">Instance of SPGroupManagementModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SPGroupManagementModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Members == input.Members ||
                    this.Members != null &&
                    input.Members != null &&
                    this.Members.SequenceEqual(input.Members)
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
                    this.Permissions == input.Permissions ||
                    this.Permissions != null &&
                    input.Permissions != null &&
                    this.Permissions.SequenceEqual(input.Permissions)
                ) && 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
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
                    this.IsTemporaryGroup == input.IsTemporaryGroup ||
                    this.IsTemporaryGroup.Equals(input.IsTemporaryGroup)
                ) && 
                (
                    this.RoleID == input.RoleID ||
                    this.RoleID != null &&
                    input.RoleID != null &&
                    this.RoleID.SequenceEqual(input.RoleID)
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Members != null)
                    hashCode = hashCode * 59 + this.Members.GetHashCode();
                hashCode = hashCode * 59 + this.SpGroupViewType.GetHashCode();
                hashCode = hashCode * 59 + this.SpGroupEditType.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                hashCode = hashCode * 59 + this.IsAllowJoinOrLeaveRequest.GetHashCode();
                hashCode = hashCode * 59 + this.IsAutoAcceptRequest.GetHashCode();
                if (this.SendMembershipRequestEmailAddress != null)
                    hashCode = hashCode * 59 + this.SendMembershipRequestEmailAddress.GetHashCode();
                hashCode = hashCode * 59 + this.IsTemporaryGroup.GetHashCode();
                if (this.RoleID != null)
                    hashCode = hashCode * 59 + this.RoleID.GetHashCode();
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
