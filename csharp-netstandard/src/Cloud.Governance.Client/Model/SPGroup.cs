

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
    /// SPGroup
    /// </summary>
    [DataContract(Name = "SPGroup")]
    public partial class SPGroup : IEquatable<SPGroup>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="SPGroup" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="owner">owner.</param>
        /// <param name="members">members.</param>
        /// <param name="permissionLevels">permissionLevels.</param>
        /// <param name="spGroupViewType">spGroupViewType.</param>
        /// <param name="spGroupEditType">spGroupEditType.</param>
        /// <param name="isAllowJoinOrLeaveRequest">isAllowJoinOrLeaveRequest.</param>
        /// <param name="autoAcceptRequestToJoinLeave">autoAcceptRequestToJoinLeave.</param>
        /// <param name="requestToJoinLeaveEmailSetting">requestToJoinLeaveEmailSetting.</param>
        /// <param name="isTemporaryGroup">isTemporaryGroup.</param>
        /// <param name="roleID">roleID.</param>
        public SPGroup(int id = default(int), string name = default(string), string description = default(string), SPPrincipal owner = default(SPPrincipal), List<ApiUser> members = default(List<ApiUser>), List<string> permissionLevels = default(List<string>), SPGroupViewOption? spGroupViewType = default(SPGroupViewOption?), SPGroupEditOption? spGroupEditType = default(SPGroupEditOption?), bool isAllowJoinOrLeaveRequest = default(bool), bool autoAcceptRequestToJoinLeave = default(bool), string requestToJoinLeaveEmailSetting = default(string), bool isTemporaryGroup = default(bool), List<string> roleID = default(List<string>))
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Owner = owner;
            this.Members = members;
            this.PermissionLevels = permissionLevels;
            this.SpGroupViewType = spGroupViewType;
            this.SpGroupEditType = spGroupEditType;
            this.IsAllowJoinOrLeaveRequest = isAllowJoinOrLeaveRequest;
            this.AutoAcceptRequestToJoinLeave = autoAcceptRequestToJoinLeave;
            this.RequestToJoinLeaveEmailSetting = requestToJoinLeaveEmailSetting;
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
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name = "owner", EmitDefaultValue = true)]
        public SPPrincipal Owner { get; set; }

        /// <summary>
        /// Gets or Sets Members
        /// </summary>
        [DataMember(Name = "members", EmitDefaultValue = true)]
        public List<ApiUser> Members { get; set; }

        /// <summary>
        /// Gets or Sets PermissionLevels
        /// </summary>
        [DataMember(Name = "permissionLevels", EmitDefaultValue = true)]
        public List<string> PermissionLevels { get; set; }

        /// <summary>
        /// Gets or Sets IsAllowJoinOrLeaveRequest
        /// </summary>
        [DataMember(Name = "isAllowJoinOrLeaveRequest", EmitDefaultValue = false)]
        public bool IsAllowJoinOrLeaveRequest { get; set; }

        /// <summary>
        /// Gets or Sets AutoAcceptRequestToJoinLeave
        /// </summary>
        [DataMember(Name = "autoAcceptRequestToJoinLeave", EmitDefaultValue = false)]
        public bool AutoAcceptRequestToJoinLeave { get; set; }

        /// <summary>
        /// Gets or Sets RequestToJoinLeaveEmailSetting
        /// </summary>
        [DataMember(Name = "requestToJoinLeaveEmailSetting", EmitDefaultValue = true)]
        public string RequestToJoinLeaveEmailSetting { get; set; }

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
            sb.Append("class SPGroup {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  PermissionLevels: ").Append(PermissionLevels).Append("\n");
            sb.Append("  SpGroupViewType: ").Append(SpGroupViewType).Append("\n");
            sb.Append("  SpGroupEditType: ").Append(SpGroupEditType).Append("\n");
            sb.Append("  IsAllowJoinOrLeaveRequest: ").Append(IsAllowJoinOrLeaveRequest).Append("\n");
            sb.Append("  AutoAcceptRequestToJoinLeave: ").Append(AutoAcceptRequestToJoinLeave).Append("\n");
            sb.Append("  RequestToJoinLeaveEmailSetting: ").Append(RequestToJoinLeaveEmailSetting).Append("\n");
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
            return this.Equals(input as SPGroup);
        }

        /// <summary>
        /// Returns true if SPGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of SPGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SPGroup input)
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
                    this.PermissionLevels == input.PermissionLevels ||
                    this.PermissionLevels != null &&
                    input.PermissionLevels != null &&
                    this.PermissionLevels.SequenceEqual(input.PermissionLevels)
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
                    this.IsAllowJoinOrLeaveRequest == input.IsAllowJoinOrLeaveRequest ||
                    this.IsAllowJoinOrLeaveRequest.Equals(input.IsAllowJoinOrLeaveRequest)
                ) && 
                (
                    this.AutoAcceptRequestToJoinLeave == input.AutoAcceptRequestToJoinLeave ||
                    this.AutoAcceptRequestToJoinLeave.Equals(input.AutoAcceptRequestToJoinLeave)
                ) && 
                (
                    this.RequestToJoinLeaveEmailSetting == input.RequestToJoinLeaveEmailSetting ||
                    (this.RequestToJoinLeaveEmailSetting != null &&
                    this.RequestToJoinLeaveEmailSetting.Equals(input.RequestToJoinLeaveEmailSetting))
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
                if (this.PermissionLevels != null)
                    hashCode = hashCode * 59 + this.PermissionLevels.GetHashCode();
                hashCode = hashCode * 59 + this.SpGroupViewType.GetHashCode();
                hashCode = hashCode * 59 + this.SpGroupEditType.GetHashCode();
                hashCode = hashCode * 59 + this.IsAllowJoinOrLeaveRequest.GetHashCode();
                hashCode = hashCode * 59 + this.AutoAcceptRequestToJoinLeave.GetHashCode();
                if (this.RequestToJoinLeaveEmailSetting != null)
                    hashCode = hashCode * 59 + this.RequestToJoinLeaveEmailSetting.GetHashCode();
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
