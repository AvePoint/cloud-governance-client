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
    /// GroupPermissionActionItem
    /// </summary>
    [DataContract]
    public partial class GroupPermissionActionItem :  IEquatable<GroupPermissionActionItem>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public RecertificationActionType? Type { get; set; }
        /// <summary>
        /// Gets or Sets ActionType
        /// </summary>
        [DataMember(Name="actionType", EmitDefaultValue=false)]
        public PermissionActionType? ActionType { get; set; }
        /// <summary>
        /// Gets or Sets AccountType
        /// </summary>
        [DataMember(Name="accountType", EmitDefaultValue=false)]
        public PrincipalType? AccountType { get; set; }
        /// <summary>
        /// Gets or Sets AccessType
        /// </summary>
        [DataMember(Name="accessType", EmitDefaultValue=false)]
        public UserAccessType? AccessType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupPermissionActionItem" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="instanceId">instanceId.</param>
        /// <param name="type">type.</param>
        /// <param name="taskId">taskId.</param>
        /// <param name="actionType">actionType.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="identityName">identityName.</param>
        /// <param name="permissionLevel">permissionLevel.</param>
        /// <param name="permissionIds">permissionIds.</param>
        /// <param name="memberId">memberId.</param>
        /// <param name="titleName">titleName.</param>
        /// <param name="path">path.</param>
        /// <param name="sharePointGroup">sharePointGroup.</param>
        /// <param name="parentId">parentId.</param>
        /// <param name="idInSharepoint">idInSharepoint.</param>
        /// <param name="level">level.</param>
        /// <param name="levelDescription">levelDescription.</param>
        /// <param name="accountType">accountType.</param>
        /// <param name="accountTypeDescription">accountTypeDescription.</param>
        /// <param name="accessType">accessType.</param>
        public GroupPermissionActionItem(Guid id = default(Guid), Guid instanceId = default(Guid), RecertificationActionType type = default(RecertificationActionType), Guid? taskId = default(Guid?), PermissionActionType actionType = default(PermissionActionType), string displayName = default(string), string identityName = default(string), string permissionLevel = default(string), List<int> permissionIds = default(List<int>), int memberId = default(int), string titleName = default(string), string path = default(string), string sharePointGroup = default(string), string parentId = default(string), string idInSharepoint = default(string), int level = default(int), string levelDescription = default(string), PrincipalType accountType = default(PrincipalType), string accountTypeDescription = default(string), UserAccessType accessType = default(UserAccessType))
        {
            this.Id = id;
            this.InstanceId = instanceId;
            this.Type = type;
            this.TaskId = taskId;
            this.ActionType = actionType;
            this.DisplayName = displayName;
            this.IdentityName = identityName;
            this.PermissionLevel = permissionLevel;
            this.PermissionIds = permissionIds;
            this.MemberId = memberId;
            this.TitleName = titleName;
            this.Path = path;
            this.SharePointGroup = sharePointGroup;
            this.ParentId = parentId;
            this.IdInSharepoint = idInSharepoint;
            this.Level = level;
            this.LevelDescription = levelDescription;
            this.AccountType = accountType;
            this.AccountTypeDescription = accountTypeDescription;
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
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets IdentityName
        /// </summary>
        [DataMember(Name="identityName", EmitDefaultValue=true)]
        public string IdentityName { get; set; }

        /// <summary>
        /// Gets or Sets PermissionLevel
        /// </summary>
        [DataMember(Name="permissionLevel", EmitDefaultValue=true)]
        public string PermissionLevel { get; set; }

        /// <summary>
        /// Gets or Sets PermissionIds
        /// </summary>
        [DataMember(Name="permissionIds", EmitDefaultValue=true)]
        public List<int> PermissionIds { get; set; }

        /// <summary>
        /// Gets or Sets MemberId
        /// </summary>
        [DataMember(Name="memberId", EmitDefaultValue=false)]
        public int MemberId { get; set; }

        /// <summary>
        /// Gets or Sets TitleName
        /// </summary>
        [DataMember(Name="titleName", EmitDefaultValue=true)]
        public string TitleName { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue=true)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets SharePointGroup
        /// </summary>
        [DataMember(Name="sharePointGroup", EmitDefaultValue=true)]
        public string SharePointGroup { get; set; }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name="parentId", EmitDefaultValue=true)]
        public string ParentId { get; set; }

        /// <summary>
        /// Gets or Sets IdInSharepoint
        /// </summary>
        [DataMember(Name="idInSharepoint", EmitDefaultValue=true)]
        public string IdInSharepoint { get; set; }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public int Level { get; set; }

        /// <summary>
        /// Gets or Sets LevelDescription
        /// </summary>
        [DataMember(Name="levelDescription", EmitDefaultValue=true)]
        public string LevelDescription { get; set; }

        /// <summary>
        /// Gets or Sets AccountTypeDescription
        /// </summary>
        [DataMember(Name="accountTypeDescription", EmitDefaultValue=true)]
        public string AccountTypeDescription { get; set; }

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
            sb.Append("class GroupPermissionActionItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  IdentityName: ").Append(IdentityName).Append("\n");
            sb.Append("  PermissionLevel: ").Append(PermissionLevel).Append("\n");
            sb.Append("  PermissionIds: ").Append(PermissionIds).Append("\n");
            sb.Append("  MemberId: ").Append(MemberId).Append("\n");
            sb.Append("  TitleName: ").Append(TitleName).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  SharePointGroup: ").Append(SharePointGroup).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  IdInSharepoint: ").Append(IdInSharepoint).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  LevelDescription: ").Append(LevelDescription).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  AccountTypeDescription: ").Append(AccountTypeDescription).Append("\n");
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
            return this.Equals(input as GroupPermissionActionItem);
        }

        /// <summary>
        /// Returns true if GroupPermissionActionItem instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupPermissionActionItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupPermissionActionItem input)
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
                    this.ActionType == input.ActionType ||
                    this.ActionType.Equals(input.ActionType)
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.IdentityName == input.IdentityName ||
                    (this.IdentityName != null &&
                    this.IdentityName.Equals(input.IdentityName))
                ) && 
                (
                    this.PermissionLevel == input.PermissionLevel ||
                    (this.PermissionLevel != null &&
                    this.PermissionLevel.Equals(input.PermissionLevel))
                ) && 
                (
                    this.PermissionIds == input.PermissionIds ||
                    this.PermissionIds != null &&
                    input.PermissionIds != null &&
                    this.PermissionIds.SequenceEqual(input.PermissionIds)
                ) && 
                (
                    this.MemberId == input.MemberId ||
                    this.MemberId.Equals(input.MemberId)
                ) && 
                (
                    this.TitleName == input.TitleName ||
                    (this.TitleName != null &&
                    this.TitleName.Equals(input.TitleName))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.SharePointGroup == input.SharePointGroup ||
                    (this.SharePointGroup != null &&
                    this.SharePointGroup.Equals(input.SharePointGroup))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.IdInSharepoint == input.IdInSharepoint ||
                    (this.IdInSharepoint != null &&
                    this.IdInSharepoint.Equals(input.IdInSharepoint))
                ) && 
                (
                    this.Level == input.Level ||
                    this.Level.Equals(input.Level)
                ) && 
                (
                    this.LevelDescription == input.LevelDescription ||
                    (this.LevelDescription != null &&
                    this.LevelDescription.Equals(input.LevelDescription))
                ) && 
                (
                    this.AccountType == input.AccountType ||
                    this.AccountType.Equals(input.AccountType)
                ) && 
                (
                    this.AccountTypeDescription == input.AccountTypeDescription ||
                    (this.AccountTypeDescription != null &&
                    this.AccountTypeDescription.Equals(input.AccountTypeDescription))
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
                hashCode = hashCode * 59 + this.ActionType.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.IdentityName != null)
                    hashCode = hashCode * 59 + this.IdentityName.GetHashCode();
                if (this.PermissionLevel != null)
                    hashCode = hashCode * 59 + this.PermissionLevel.GetHashCode();
                if (this.PermissionIds != null)
                    hashCode = hashCode * 59 + this.PermissionIds.GetHashCode();
                hashCode = hashCode * 59 + this.MemberId.GetHashCode();
                if (this.TitleName != null)
                    hashCode = hashCode * 59 + this.TitleName.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.SharePointGroup != null)
                    hashCode = hashCode * 59 + this.SharePointGroup.GetHashCode();
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.IdInSharepoint != null)
                    hashCode = hashCode * 59 + this.IdInSharepoint.GetHashCode();
                hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.LevelDescription != null)
                    hashCode = hashCode * 59 + this.LevelDescription.GetHashCode();
                hashCode = hashCode * 59 + this.AccountType.GetHashCode();
                if (this.AccountTypeDescription != null)
                    hashCode = hashCode * 59 + this.AccountTypeDescription.GetHashCode();
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
