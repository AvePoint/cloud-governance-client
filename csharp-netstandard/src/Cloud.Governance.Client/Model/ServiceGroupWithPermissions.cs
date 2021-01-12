

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
    /// ServiceGroupWithPermissions
    /// </summary>
    [DataContract(Name = "ServiceGroupWithPermissions")]
    public partial class ServiceGroupWithPermissions : IEquatable<ServiceGroupWithPermissions>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets UsersAssignBy
        /// </summary>
        [DataMember(Name = "usersAssignBy", EmitDefaultValue = false)]
        public AssignBy? UsersAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets GroupOwnerAssignBy
        /// </summary>
        [DataMember(Name = "groupOwnerAssignBy", EmitDefaultValue = false)]
        public AssignBy? GroupOwnerAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets GroupOwnerType
        /// </summary>
        [DataMember(Name = "groupOwnerType", EmitDefaultValue = false)]
        public GroupOwnerType? GroupOwnerType { get; set; }
        /// <summary>
        /// Gets or Sets BuildInGroupType
        /// </summary>
        [DataMember(Name = "buildInGroupType", EmitDefaultValue = false)]
        public SharePointBuildInGroupType? BuildInGroupType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceGroupWithPermissions" /> class.
        /// </summary>
        /// <param name="usersAssignBy">usersAssignBy.</param>
        /// <param name="groupOwnerAssignBy">groupOwnerAssignBy.</param>
        /// <param name="allowChangePermissionLevel">allowChangePermissionLevel.</param>
        /// <param name="removable">removable.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="users">users.</param>
        /// <param name="permissionLevels">permissionLevels.</param>
        /// <param name="groupOwner">groupOwner.</param>
        /// <param name="groupOwnerType">groupOwnerType.</param>
        /// <param name="buildInGroupType">buildInGroupType.</param>
        public ServiceGroupWithPermissions(AssignBy? usersAssignBy = default(AssignBy?), AssignBy? groupOwnerAssignBy = default(AssignBy?), bool allowChangePermissionLevel = default(bool), bool removable = default(bool), string name = default(string), string description = default(string), List<GroupUser> users = default(List<GroupUser>), List<PermissionLevel> permissionLevels = default(List<PermissionLevel>), ApiUser groupOwner = default(ApiUser), GroupOwnerType? groupOwnerType = default(GroupOwnerType?), SharePointBuildInGroupType? buildInGroupType = default(SharePointBuildInGroupType?))
        {
            this.UsersAssignBy = usersAssignBy;
            this.GroupOwnerAssignBy = groupOwnerAssignBy;
            this.AllowChangePermissionLevel = allowChangePermissionLevel;
            this.Removable = removable;
            this.Name = name;
            this.Description = description;
            this.Users = users;
            this.PermissionLevels = permissionLevels;
            this.GroupOwner = groupOwner;
            this.GroupOwnerType = groupOwnerType;
            this.BuildInGroupType = buildInGroupType;
        }

        /// <summary>
        /// Gets or Sets AllowChangePermissionLevel
        /// </summary>
        [DataMember(Name = "allowChangePermissionLevel", EmitDefaultValue = false)]
        public bool AllowChangePermissionLevel { get; set; }

        /// <summary>
        /// Gets or Sets Removable
        /// </summary>
        [DataMember(Name = "removable", EmitDefaultValue = false)]
        public bool Removable { get; set; }

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
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name = "users", EmitDefaultValue = true)]
        public List<GroupUser> Users { get; set; }

        /// <summary>
        /// Gets or Sets PermissionLevels
        /// </summary>
        [DataMember(Name = "permissionLevels", EmitDefaultValue = true)]
        public List<PermissionLevel> PermissionLevels { get; set; }

        /// <summary>
        /// Gets or Sets GroupOwner
        /// </summary>
        [DataMember(Name = "groupOwner", EmitDefaultValue = true)]
        public ApiUser GroupOwner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceGroupWithPermissions {\n");
            sb.Append("  UsersAssignBy: ").Append(UsersAssignBy).Append("\n");
            sb.Append("  GroupOwnerAssignBy: ").Append(GroupOwnerAssignBy).Append("\n");
            sb.Append("  AllowChangePermissionLevel: ").Append(AllowChangePermissionLevel).Append("\n");
            sb.Append("  Removable: ").Append(Removable).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  PermissionLevels: ").Append(PermissionLevels).Append("\n");
            sb.Append("  GroupOwner: ").Append(GroupOwner).Append("\n");
            sb.Append("  GroupOwnerType: ").Append(GroupOwnerType).Append("\n");
            sb.Append("  BuildInGroupType: ").Append(BuildInGroupType).Append("\n");
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
            return this.Equals(input as ServiceGroupWithPermissions);
        }

        /// <summary>
        /// Returns true if ServiceGroupWithPermissions instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceGroupWithPermissions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceGroupWithPermissions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UsersAssignBy == input.UsersAssignBy ||
                    this.UsersAssignBy.Equals(input.UsersAssignBy)
                ) && 
                (
                    this.GroupOwnerAssignBy == input.GroupOwnerAssignBy ||
                    this.GroupOwnerAssignBy.Equals(input.GroupOwnerAssignBy)
                ) && 
                (
                    this.AllowChangePermissionLevel == input.AllowChangePermissionLevel ||
                    this.AllowChangePermissionLevel.Equals(input.AllowChangePermissionLevel)
                ) && 
                (
                    this.Removable == input.Removable ||
                    this.Removable.Equals(input.Removable)
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
                    this.Users == input.Users ||
                    this.Users != null &&
                    input.Users != null &&
                    this.Users.SequenceEqual(input.Users)
                ) && 
                (
                    this.PermissionLevels == input.PermissionLevels ||
                    this.PermissionLevels != null &&
                    input.PermissionLevels != null &&
                    this.PermissionLevels.SequenceEqual(input.PermissionLevels)
                ) && 
                (
                    this.GroupOwner == input.GroupOwner ||
                    (this.GroupOwner != null &&
                    this.GroupOwner.Equals(input.GroupOwner))
                ) && 
                (
                    this.GroupOwnerType == input.GroupOwnerType ||
                    this.GroupOwnerType.Equals(input.GroupOwnerType)
                ) && 
                (
                    this.BuildInGroupType == input.BuildInGroupType ||
                    this.BuildInGroupType.Equals(input.BuildInGroupType)
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
                hashCode = hashCode * 59 + this.UsersAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.GroupOwnerAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.AllowChangePermissionLevel.GetHashCode();
                hashCode = hashCode * 59 + this.Removable.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
                if (this.PermissionLevels != null)
                    hashCode = hashCode * 59 + this.PermissionLevels.GetHashCode();
                if (this.GroupOwner != null)
                    hashCode = hashCode * 59 + this.GroupOwner.GetHashCode();
                hashCode = hashCode * 59 + this.GroupOwnerType.GetHashCode();
                hashCode = hashCode * 59 + this.BuildInGroupType.GetHashCode();
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
