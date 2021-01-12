

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
    /// ClonePermissionService
    /// </summary>
    [DataContract(Name = "ClonePermissionService")]
    public partial class ClonePermissionService : IEquatable<ClonePermissionService>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets SourceUserRestrictionType
        /// </summary>
        [DataMember(Name = "sourceUserRestrictionType", EmitDefaultValue = false)]
        public UserLevelRestrictionType? SourceUserRestrictionType { get; set; }
        /// <summary>
        /// Gets or Sets TargetUserRestrictionType
        /// </summary>
        [DataMember(Name = "targetUserRestrictionType", EmitDefaultValue = false)]
        public UserLevelRestrictionType? TargetUserRestrictionType { get; set; }
        /// <summary>
        /// Gets or Sets CloneOption
        /// </summary>
        [DataMember(Name = "cloneOption", EmitDefaultValue = false)]
        public ClonePermissionOption? CloneOption { get; set; }
        /// <summary>
        /// Gets or Sets ClonePermissionAssignBy
        /// </summary>
        [DataMember(Name = "clonePermissionAssignBy", EmitDefaultValue = false)]
        public AssignBy? ClonePermissionAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets AdditionalCloneOption
        /// </summary>
        [DataMember(Name = "additionalCloneOption", EmitDefaultValue = false)]
        public ClonePermissionAdditionalOption? AdditionalCloneOption { get; set; }
        /// <summary>
        /// Gets or Sets CloneAdditionalOptionAssignBy
        /// </summary>
        [DataMember(Name = "cloneAdditionalOptionAssignBy", EmitDefaultValue = false)]
        public AssignBy? CloneAdditionalOptionAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets TransferOptionValueAssignBy
        /// </summary>
        [DataMember(Name = "transferOptionValueAssignBy", EmitDefaultValue = false)]
        public AssignBy? TransferOptionValueAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets DepartmentAssignBy
        /// </summary>
        [DataMember(Name = "departmentAssignBy", EmitDefaultValue = false)]
        public AssignBy? DepartmentAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public ServiceType? Type { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public CommonStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClonePermissionService" /> class.
        /// </summary>
        /// <param name="selectedNodes">selectedNodes.</param>
        /// <param name="uncheckedNodes">uncheckedNodes.</param>
        /// <param name="sourceUserRestrictionType">sourceUserRestrictionType.</param>
        /// <param name="targetUserRestrictionType">targetUserRestrictionType.</param>
        /// <param name="cloneOption">cloneOption.</param>
        /// <param name="clonePermissionAssignBy">clonePermissionAssignBy.</param>
        /// <param name="additionalCloneOption">additionalCloneOption.</param>
        /// <param name="cloneAdditionalOptionAssignBy">cloneAdditionalOptionAssignBy.</param>
        /// <param name="enabledRemoveExplicitPermission">enabledRemoveExplicitPermission.</param>
        /// <param name="enabledRemoveUserFromSPGroup">enabledRemoveUserFromSPGroup.</param>
        /// <param name="enabledDeleteUserPermission">enabledDeleteUserPermission.</param>
        /// <param name="transferOptionValueAssignBy">transferOptionValueAssignBy.</param>
        /// <param name="isHideTree">isHideTree.</param>
        /// <param name="scopeSettings">scopeSettings.</param>
        /// <param name="requestTemplate">requestTemplate.</param>
        /// <param name="departmentAssignBy">departmentAssignBy.</param>
        /// <param name="metadatas">metadatas.</param>
        /// <param name="hideRequestSummary">hideRequestSummary.</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="type">type.</param>
        /// <param name="department">department.</param>
        /// <param name="loadDepartmentFromUps">loadDepartmentFromUps.</param>
        /// <param name="departments">departments.</param>
        /// <param name="serviceContact">serviceContact.</param>
        /// <param name="serviceAdminContact">serviceAdminContact.</param>
        /// <param name="approversContainManagerRole">approversContainManagerRole.</param>
        /// <param name="status">status.</param>
        /// <param name="showServiceInCatalog">showServiceInCatalog.</param>
        /// <param name="customActions">customActions.</param>
        /// <param name="approvalProcessId">approvalProcessId.</param>
        /// <param name="languageId">languageId.</param>
        /// <param name="categoryId">categoryId.</param>
        /// <param name="details">details.</param>
        public ClonePermissionService(List<TreeNode> selectedNodes = default(List<TreeNode>), List<TreeNode> uncheckedNodes = default(List<TreeNode>), UserLevelRestrictionType? sourceUserRestrictionType = default(UserLevelRestrictionType?), UserLevelRestrictionType? targetUserRestrictionType = default(UserLevelRestrictionType?), ClonePermissionOption? cloneOption = default(ClonePermissionOption?), AssignBy? clonePermissionAssignBy = default(AssignBy?), ClonePermissionAdditionalOption? additionalCloneOption = default(ClonePermissionAdditionalOption?), AssignBy? cloneAdditionalOptionAssignBy = default(AssignBy?), bool enabledRemoveExplicitPermission = default(bool), bool enabledRemoveUserFromSPGroup = default(bool), bool enabledDeleteUserPermission = default(bool), AssignBy? transferOptionValueAssignBy = default(AssignBy?), bool isHideTree = default(bool), ServiceScopeSettings scopeSettings = default(ServiceScopeSettings), ClonePermissionRequest requestTemplate = default(ClonePermissionRequest), AssignBy? departmentAssignBy = default(AssignBy?), List<CustomMetadata> metadatas = default(List<CustomMetadata>), bool hideRequestSummary = default(bool), Guid id = default(Guid), string name = default(string), string description = default(string), ServiceType? type = default(ServiceType?), string department = default(string), bool loadDepartmentFromUps = default(bool), List<string> departments = default(List<string>), ApiUser serviceContact = default(ApiUser), ApiUser serviceAdminContact = default(ApiUser), bool approversContainManagerRole = default(bool), CommonStatus? status = default(CommonStatus?), bool showServiceInCatalog = default(bool), CustomActionSettings customActions = default(CustomActionSettings), Guid approvalProcessId = default(Guid), int languageId = default(int), string categoryId = default(string), string details = default(string))
        {
            this.SelectedNodes = selectedNodes;
            this.UncheckedNodes = uncheckedNodes;
            this.SourceUserRestrictionType = sourceUserRestrictionType;
            this.TargetUserRestrictionType = targetUserRestrictionType;
            this.CloneOption = cloneOption;
            this.ClonePermissionAssignBy = clonePermissionAssignBy;
            this.AdditionalCloneOption = additionalCloneOption;
            this.CloneAdditionalOptionAssignBy = cloneAdditionalOptionAssignBy;
            this.EnabledRemoveExplicitPermission = enabledRemoveExplicitPermission;
            this.EnabledRemoveUserFromSPGroup = enabledRemoveUserFromSPGroup;
            this.EnabledDeleteUserPermission = enabledDeleteUserPermission;
            this.TransferOptionValueAssignBy = transferOptionValueAssignBy;
            this.IsHideTree = isHideTree;
            this.ScopeSettings = scopeSettings;
            this.RequestTemplate = requestTemplate;
            this.DepartmentAssignBy = departmentAssignBy;
            this.Metadatas = metadatas;
            this.HideRequestSummary = hideRequestSummary;
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Type = type;
            this.Department = department;
            this.LoadDepartmentFromUps = loadDepartmentFromUps;
            this.Departments = departments;
            this.ServiceContact = serviceContact;
            this.ServiceAdminContact = serviceAdminContact;
            this.ApproversContainManagerRole = approversContainManagerRole;
            this.Status = status;
            this.ShowServiceInCatalog = showServiceInCatalog;
            this.CustomActions = customActions;
            this.ApprovalProcessId = approvalProcessId;
            this.LanguageId = languageId;
            this.CategoryId = categoryId;
            this.Details = details;
        }

        /// <summary>
        /// Gets or Sets SelectedNodes
        /// </summary>
        [DataMember(Name = "selectedNodes", EmitDefaultValue = true)]
        public List<TreeNode> SelectedNodes { get; set; }

        /// <summary>
        /// Gets or Sets UncheckedNodes
        /// </summary>
        [DataMember(Name = "uncheckedNodes", EmitDefaultValue = true)]
        public List<TreeNode> UncheckedNodes { get; set; }

        /// <summary>
        /// Gets or Sets EnabledRemoveExplicitPermission
        /// </summary>
        [DataMember(Name = "enabledRemoveExplicitPermission", EmitDefaultValue = false)]
        public bool EnabledRemoveExplicitPermission { get; set; }

        /// <summary>
        /// Gets or Sets EnabledRemoveUserFromSPGroup
        /// </summary>
        [DataMember(Name = "enabledRemoveUserFromSPGroup", EmitDefaultValue = false)]
        public bool EnabledRemoveUserFromSPGroup { get; set; }

        /// <summary>
        /// Gets or Sets EnabledDeleteUserPermission
        /// </summary>
        [DataMember(Name = "enabledDeleteUserPermission", EmitDefaultValue = false)]
        public bool EnabledDeleteUserPermission { get; set; }

        /// <summary>
        /// Gets or Sets IsHideTree
        /// </summary>
        [DataMember(Name = "isHideTree", EmitDefaultValue = false)]
        public bool IsHideTree { get; set; }

        /// <summary>
        /// Gets or Sets ScopeSettings
        /// </summary>
        [DataMember(Name = "scopeSettings", EmitDefaultValue = true)]
        public ServiceScopeSettings ScopeSettings { get; set; }

        /// <summary>
        /// Gets or Sets RequestTemplate
        /// </summary>
        [DataMember(Name = "requestTemplate", EmitDefaultValue = true)]
        public ClonePermissionRequest RequestTemplate { get; set; }

        /// <summary>
        /// Gets or Sets Metadatas
        /// </summary>
        [DataMember(Name = "metadatas", EmitDefaultValue = true)]
        public List<CustomMetadata> Metadatas { get; set; }

        /// <summary>
        /// Gets or Sets HideRequestSummary
        /// </summary>
        [DataMember(Name = "hideRequestSummary", EmitDefaultValue = false)]
        public bool HideRequestSummary { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

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
        /// Gets or Sets Department
        /// </summary>
        [DataMember(Name = "department", EmitDefaultValue = true)]
        public string Department { get; set; }

        /// <summary>
        /// Gets or Sets LoadDepartmentFromUps
        /// </summary>
        [DataMember(Name = "loadDepartmentFromUps", EmitDefaultValue = false)]
        public bool LoadDepartmentFromUps { get; set; }

        /// <summary>
        /// Gets or Sets Departments
        /// </summary>
        [DataMember(Name = "departments", EmitDefaultValue = true)]
        public List<string> Departments { get; set; }

        /// <summary>
        /// Gets or Sets ServiceContact
        /// </summary>
        [DataMember(Name = "serviceContact", EmitDefaultValue = true)]
        public ApiUser ServiceContact { get; set; }

        /// <summary>
        /// Gets or Sets ServiceAdminContact
        /// </summary>
        [DataMember(Name = "serviceAdminContact", EmitDefaultValue = true)]
        public ApiUser ServiceAdminContact { get; set; }

        /// <summary>
        /// Gets or Sets ApproversContainManagerRole
        /// </summary>
        [DataMember(Name = "approversContainManagerRole", EmitDefaultValue = false)]
        public bool ApproversContainManagerRole { get; set; }

        /// <summary>
        /// Gets or Sets ShowServiceInCatalog
        /// </summary>
        [DataMember(Name = "showServiceInCatalog", EmitDefaultValue = false)]
        public bool ShowServiceInCatalog { get; set; }

        /// <summary>
        /// Gets or Sets CustomActions
        /// </summary>
        [DataMember(Name = "customActions", EmitDefaultValue = true)]
        public CustomActionSettings CustomActions { get; set; }

        /// <summary>
        /// Gets or Sets ApprovalProcessId
        /// </summary>
        [DataMember(Name = "approvalProcessId", EmitDefaultValue = false)]
        public Guid ApprovalProcessId { get; set; }

        /// <summary>
        /// Gets or Sets LanguageId
        /// </summary>
        [DataMember(Name = "languageId", EmitDefaultValue = false)]
        public int LanguageId { get; set; }

        /// <summary>
        /// Gets or Sets CategoryId
        /// </summary>
        [DataMember(Name = "categoryId", EmitDefaultValue = true)]
        public string CategoryId { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name = "details", EmitDefaultValue = true)]
        public string Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClonePermissionService {\n");
            sb.Append("  SelectedNodes: ").Append(SelectedNodes).Append("\n");
            sb.Append("  UncheckedNodes: ").Append(UncheckedNodes).Append("\n");
            sb.Append("  SourceUserRestrictionType: ").Append(SourceUserRestrictionType).Append("\n");
            sb.Append("  TargetUserRestrictionType: ").Append(TargetUserRestrictionType).Append("\n");
            sb.Append("  CloneOption: ").Append(CloneOption).Append("\n");
            sb.Append("  ClonePermissionAssignBy: ").Append(ClonePermissionAssignBy).Append("\n");
            sb.Append("  AdditionalCloneOption: ").Append(AdditionalCloneOption).Append("\n");
            sb.Append("  CloneAdditionalOptionAssignBy: ").Append(CloneAdditionalOptionAssignBy).Append("\n");
            sb.Append("  EnabledRemoveExplicitPermission: ").Append(EnabledRemoveExplicitPermission).Append("\n");
            sb.Append("  EnabledRemoveUserFromSPGroup: ").Append(EnabledRemoveUserFromSPGroup).Append("\n");
            sb.Append("  EnabledDeleteUserPermission: ").Append(EnabledDeleteUserPermission).Append("\n");
            sb.Append("  TransferOptionValueAssignBy: ").Append(TransferOptionValueAssignBy).Append("\n");
            sb.Append("  IsHideTree: ").Append(IsHideTree).Append("\n");
            sb.Append("  ScopeSettings: ").Append(ScopeSettings).Append("\n");
            sb.Append("  RequestTemplate: ").Append(RequestTemplate).Append("\n");
            sb.Append("  DepartmentAssignBy: ").Append(DepartmentAssignBy).Append("\n");
            sb.Append("  Metadatas: ").Append(Metadatas).Append("\n");
            sb.Append("  HideRequestSummary: ").Append(HideRequestSummary).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  LoadDepartmentFromUps: ").Append(LoadDepartmentFromUps).Append("\n");
            sb.Append("  Departments: ").Append(Departments).Append("\n");
            sb.Append("  ServiceContact: ").Append(ServiceContact).Append("\n");
            sb.Append("  ServiceAdminContact: ").Append(ServiceAdminContact).Append("\n");
            sb.Append("  ApproversContainManagerRole: ").Append(ApproversContainManagerRole).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ShowServiceInCatalog: ").Append(ShowServiceInCatalog).Append("\n");
            sb.Append("  CustomActions: ").Append(CustomActions).Append("\n");
            sb.Append("  ApprovalProcessId: ").Append(ApprovalProcessId).Append("\n");
            sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(input as ClonePermissionService);
        }

        /// <summary>
        /// Returns true if ClonePermissionService instances are equal
        /// </summary>
        /// <param name="input">Instance of ClonePermissionService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClonePermissionService input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SelectedNodes == input.SelectedNodes ||
                    this.SelectedNodes != null &&
                    input.SelectedNodes != null &&
                    this.SelectedNodes.SequenceEqual(input.SelectedNodes)
                ) && 
                (
                    this.UncheckedNodes == input.UncheckedNodes ||
                    this.UncheckedNodes != null &&
                    input.UncheckedNodes != null &&
                    this.UncheckedNodes.SequenceEqual(input.UncheckedNodes)
                ) && 
                (
                    this.SourceUserRestrictionType == input.SourceUserRestrictionType ||
                    this.SourceUserRestrictionType.Equals(input.SourceUserRestrictionType)
                ) && 
                (
                    this.TargetUserRestrictionType == input.TargetUserRestrictionType ||
                    this.TargetUserRestrictionType.Equals(input.TargetUserRestrictionType)
                ) && 
                (
                    this.CloneOption == input.CloneOption ||
                    this.CloneOption.Equals(input.CloneOption)
                ) && 
                (
                    this.ClonePermissionAssignBy == input.ClonePermissionAssignBy ||
                    this.ClonePermissionAssignBy.Equals(input.ClonePermissionAssignBy)
                ) && 
                (
                    this.AdditionalCloneOption == input.AdditionalCloneOption ||
                    this.AdditionalCloneOption.Equals(input.AdditionalCloneOption)
                ) && 
                (
                    this.CloneAdditionalOptionAssignBy == input.CloneAdditionalOptionAssignBy ||
                    this.CloneAdditionalOptionAssignBy.Equals(input.CloneAdditionalOptionAssignBy)
                ) && 
                (
                    this.EnabledRemoveExplicitPermission == input.EnabledRemoveExplicitPermission ||
                    this.EnabledRemoveExplicitPermission.Equals(input.EnabledRemoveExplicitPermission)
                ) && 
                (
                    this.EnabledRemoveUserFromSPGroup == input.EnabledRemoveUserFromSPGroup ||
                    this.EnabledRemoveUserFromSPGroup.Equals(input.EnabledRemoveUserFromSPGroup)
                ) && 
                (
                    this.EnabledDeleteUserPermission == input.EnabledDeleteUserPermission ||
                    this.EnabledDeleteUserPermission.Equals(input.EnabledDeleteUserPermission)
                ) && 
                (
                    this.TransferOptionValueAssignBy == input.TransferOptionValueAssignBy ||
                    this.TransferOptionValueAssignBy.Equals(input.TransferOptionValueAssignBy)
                ) && 
                (
                    this.IsHideTree == input.IsHideTree ||
                    this.IsHideTree.Equals(input.IsHideTree)
                ) && 
                (
                    this.ScopeSettings == input.ScopeSettings ||
                    (this.ScopeSettings != null &&
                    this.ScopeSettings.Equals(input.ScopeSettings))
                ) && 
                (
                    this.RequestTemplate == input.RequestTemplate ||
                    (this.RequestTemplate != null &&
                    this.RequestTemplate.Equals(input.RequestTemplate))
                ) && 
                (
                    this.DepartmentAssignBy == input.DepartmentAssignBy ||
                    this.DepartmentAssignBy.Equals(input.DepartmentAssignBy)
                ) && 
                (
                    this.Metadatas == input.Metadatas ||
                    this.Metadatas != null &&
                    input.Metadatas != null &&
                    this.Metadatas.SequenceEqual(input.Metadatas)
                ) && 
                (
                    this.HideRequestSummary == input.HideRequestSummary ||
                    this.HideRequestSummary.Equals(input.HideRequestSummary)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
                ) && 
                (
                    this.LoadDepartmentFromUps == input.LoadDepartmentFromUps ||
                    this.LoadDepartmentFromUps.Equals(input.LoadDepartmentFromUps)
                ) && 
                (
                    this.Departments == input.Departments ||
                    this.Departments != null &&
                    input.Departments != null &&
                    this.Departments.SequenceEqual(input.Departments)
                ) && 
                (
                    this.ServiceContact == input.ServiceContact ||
                    (this.ServiceContact != null &&
                    this.ServiceContact.Equals(input.ServiceContact))
                ) && 
                (
                    this.ServiceAdminContact == input.ServiceAdminContact ||
                    (this.ServiceAdminContact != null &&
                    this.ServiceAdminContact.Equals(input.ServiceAdminContact))
                ) && 
                (
                    this.ApproversContainManagerRole == input.ApproversContainManagerRole ||
                    this.ApproversContainManagerRole.Equals(input.ApproversContainManagerRole)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.ShowServiceInCatalog == input.ShowServiceInCatalog ||
                    this.ShowServiceInCatalog.Equals(input.ShowServiceInCatalog)
                ) && 
                (
                    this.CustomActions == input.CustomActions ||
                    (this.CustomActions != null &&
                    this.CustomActions.Equals(input.CustomActions))
                ) && 
                (
                    this.ApprovalProcessId == input.ApprovalProcessId ||
                    (this.ApprovalProcessId != null &&
                    this.ApprovalProcessId.Equals(input.ApprovalProcessId))
                ) && 
                (
                    this.LanguageId == input.LanguageId ||
                    this.LanguageId.Equals(input.LanguageId)
                ) && 
                (
                    this.CategoryId == input.CategoryId ||
                    (this.CategoryId != null &&
                    this.CategoryId.Equals(input.CategoryId))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
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
                if (this.SelectedNodes != null)
                    hashCode = hashCode * 59 + this.SelectedNodes.GetHashCode();
                if (this.UncheckedNodes != null)
                    hashCode = hashCode * 59 + this.UncheckedNodes.GetHashCode();
                hashCode = hashCode * 59 + this.SourceUserRestrictionType.GetHashCode();
                hashCode = hashCode * 59 + this.TargetUserRestrictionType.GetHashCode();
                hashCode = hashCode * 59 + this.CloneOption.GetHashCode();
                hashCode = hashCode * 59 + this.ClonePermissionAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.AdditionalCloneOption.GetHashCode();
                hashCode = hashCode * 59 + this.CloneAdditionalOptionAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.EnabledRemoveExplicitPermission.GetHashCode();
                hashCode = hashCode * 59 + this.EnabledRemoveUserFromSPGroup.GetHashCode();
                hashCode = hashCode * 59 + this.EnabledDeleteUserPermission.GetHashCode();
                hashCode = hashCode * 59 + this.TransferOptionValueAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.IsHideTree.GetHashCode();
                if (this.ScopeSettings != null)
                    hashCode = hashCode * 59 + this.ScopeSettings.GetHashCode();
                if (this.RequestTemplate != null)
                    hashCode = hashCode * 59 + this.RequestTemplate.GetHashCode();
                hashCode = hashCode * 59 + this.DepartmentAssignBy.GetHashCode();
                if (this.Metadatas != null)
                    hashCode = hashCode * 59 + this.Metadatas.GetHashCode();
                hashCode = hashCode * 59 + this.HideRequestSummary.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Department != null)
                    hashCode = hashCode * 59 + this.Department.GetHashCode();
                hashCode = hashCode * 59 + this.LoadDepartmentFromUps.GetHashCode();
                if (this.Departments != null)
                    hashCode = hashCode * 59 + this.Departments.GetHashCode();
                if (this.ServiceContact != null)
                    hashCode = hashCode * 59 + this.ServiceContact.GetHashCode();
                if (this.ServiceAdminContact != null)
                    hashCode = hashCode * 59 + this.ServiceAdminContact.GetHashCode();
                hashCode = hashCode * 59 + this.ApproversContainManagerRole.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.ShowServiceInCatalog.GetHashCode();
                if (this.CustomActions != null)
                    hashCode = hashCode * 59 + this.CustomActions.GetHashCode();
                if (this.ApprovalProcessId != null)
                    hashCode = hashCode * 59 + this.ApprovalProcessId.GetHashCode();
                hashCode = hashCode * 59 + this.LanguageId.GetHashCode();
                if (this.CategoryId != null)
                    hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
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
