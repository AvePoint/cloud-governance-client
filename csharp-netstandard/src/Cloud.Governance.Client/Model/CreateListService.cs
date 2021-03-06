

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
    /// CreateListService
    /// </summary>
    [DataContract(Name = "CreateListService")]
    public partial class CreateListService : IEquatable<CreateListService>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets DefaultListType
        /// </summary>
        [DataMember(Name = "defaultListType", EmitDefaultValue = false)]
        public ListType? DefaultListType { get; set; }
        /// <summary>
        /// Gets or Sets ListVersionAssignBy
        /// </summary>
        [DataMember(Name = "listVersionAssignBy", EmitDefaultValue = false)]
        public AssignBy? ListVersionAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets ListTemplateAssignBy
        /// </summary>
        [DataMember(Name = "listTemplateAssignBy", EmitDefaultValue = false)]
        public AssignBy? ListTemplateAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets NavigationAssignBy
        /// </summary>
        [DataMember(Name = "navigationAssignBy", EmitDefaultValue = false)]
        public AssignBy? NavigationAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets ListTypeAssignBy
        /// </summary>
        [DataMember(Name = "listTypeAssignBy", EmitDefaultValue = false)]
        public AssignBy? ListTypeAssignBy { get; set; }
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
        /// Initializes a new instance of the <see cref="CreateListService" /> class.
        /// </summary>
        /// <param name="enableNavigation">enableNavigation (default to false).</param>
        /// <param name="defaultListType">defaultListType.</param>
        /// <param name="versionSettings">versionSettings.</param>
        /// <param name="listTemplateSettings">listTemplateSettings.</param>
        /// <param name="urlSettings">urlSettings.</param>
        /// <param name="allowBreakPermissionInheritance">allowBreakPermissionInheritance (default to false).</param>
        /// <param name="permissionSettings">permissionSettings.</param>
        /// <param name="scopeSettings">scopeSettings.</param>
        /// <param name="listVersionAssignBy">listVersionAssignBy.</param>
        /// <param name="listTemplateAssignBy">listTemplateAssignBy.</param>
        /// <param name="navigationAssignBy">navigationAssignBy.</param>
        /// <param name="listTypeAssignBy">listTypeAssignBy.</param>
        /// <param name="requestTemplate">requestTemplate.</param>
        /// <param name="metadatas">metadatas.</param>
        /// <param name="hideRequestSummary">hideRequestSummary (default to false).</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="type">type.</param>
        /// <param name="serviceContact">ApiUser model.</param>
        /// <param name="serviceAdminContact">ApiUser model.</param>
        /// <param name="approversContainManagerRole">approversContainManagerRole (default to false).</param>
        /// <param name="status">status.</param>
        /// <param name="showServiceInCatalog">showServiceInCatalog (default to false).</param>
        /// <param name="customActions">customActions.</param>
        /// <param name="approvalProcessId">approvalProcessId.</param>
        /// <param name="languageId">languageId (default to 0).</param>
        /// <param name="categoryId">categoryId.</param>
        public CreateListService(bool enableNavigation = false, ListType? defaultListType = default(ListType?), ListVersionSettings versionSettings = default(ListVersionSettings), ListTemplateSettings listTemplateSettings = default(ListTemplateSettings), CreateListUrlSettings urlSettings = default(CreateListUrlSettings), bool allowBreakPermissionInheritance = false, PermissionSettings permissionSettings = default(PermissionSettings), ServiceScopeSettings scopeSettings = default(ServiceScopeSettings), AssignBy? listVersionAssignBy = default(AssignBy?), AssignBy? listTemplateAssignBy = default(AssignBy?), AssignBy? navigationAssignBy = default(AssignBy?), AssignBy? listTypeAssignBy = default(AssignBy?), CreateListRequest requestTemplate = default(CreateListRequest), List<CustomMetadata> metadatas = default(List<CustomMetadata>), bool hideRequestSummary = false, Guid id = default(Guid), string name = default(string), string description = default(string), ServiceType? type = default(ServiceType?), ApiUser serviceContact = default(ApiUser), ApiUser serviceAdminContact = default(ApiUser), bool approversContainManagerRole = false, CommonStatus? status = default(CommonStatus?), bool showServiceInCatalog = false, CustomActionSettings customActions = default(CustomActionSettings), Guid approvalProcessId = default(Guid), int languageId = 0, string categoryId = default(string))
        {
            this.EnableNavigation = enableNavigation;
            this.DefaultListType = defaultListType;
            this.VersionSettings = versionSettings;
            this.ListTemplateSettings = listTemplateSettings;
            this.UrlSettings = urlSettings;
            this.AllowBreakPermissionInheritance = allowBreakPermissionInheritance;
            this.PermissionSettings = permissionSettings;
            this.ScopeSettings = scopeSettings;
            this.ListVersionAssignBy = listVersionAssignBy;
            this.ListTemplateAssignBy = listTemplateAssignBy;
            this.NavigationAssignBy = navigationAssignBy;
            this.ListTypeAssignBy = listTypeAssignBy;
            this.RequestTemplate = requestTemplate;
            this.Metadatas = metadatas;
            this.HideRequestSummary = hideRequestSummary;
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Type = type;
            this.ServiceContact = serviceContact;
            this.ServiceAdminContact = serviceAdminContact;
            this.ApproversContainManagerRole = approversContainManagerRole;
            this.Status = status;
            this.ShowServiceInCatalog = showServiceInCatalog;
            this.CustomActions = customActions;
            this.ApprovalProcessId = approvalProcessId;
            this.LanguageId = languageId;
            this.CategoryId = categoryId;
        }

        /// <summary>
        /// Gets or Sets EnableNavigation
        /// </summary>
        [DataMember(Name = "enableNavigation", EmitDefaultValue = false)]
        public bool EnableNavigation { get; set; }

        /// <summary>
        /// Gets or Sets VersionSettings
        /// </summary>
        [DataMember(Name = "versionSettings", EmitDefaultValue = true)]
        public ListVersionSettings VersionSettings { get; set; }

        /// <summary>
        /// Gets or Sets ListTemplateSettings
        /// </summary>
        [DataMember(Name = "listTemplateSettings", EmitDefaultValue = true)]
        public ListTemplateSettings ListTemplateSettings { get; set; }

        /// <summary>
        /// Gets or Sets UrlSettings
        /// </summary>
        [DataMember(Name = "urlSettings", EmitDefaultValue = true)]
        public CreateListUrlSettings UrlSettings { get; set; }

        /// <summary>
        /// Gets or Sets AllowBreakPermissionInheritance
        /// </summary>
        [DataMember(Name = "allowBreakPermissionInheritance", EmitDefaultValue = false)]
        public bool AllowBreakPermissionInheritance { get; set; }

        /// <summary>
        /// Gets or Sets PermissionSettings
        /// </summary>
        [DataMember(Name = "permissionSettings", EmitDefaultValue = true)]
        public PermissionSettings PermissionSettings { get; set; }

        /// <summary>
        /// Gets or Sets ScopeSettings
        /// </summary>
        [DataMember(Name = "scopeSettings", EmitDefaultValue = true)]
        public ServiceScopeSettings ScopeSettings { get; set; }

        /// <summary>
        /// Gets or Sets RequestTemplate
        /// </summary>
        [DataMember(Name = "requestTemplate", EmitDefaultValue = true)]
        public CreateListRequest RequestTemplate { get; set; }

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
        /// ApiUser model
        /// </summary>
        /// <value>ApiUser model</value>
        [DataMember(Name = "serviceContact", EmitDefaultValue = true)]
        public ApiUser ServiceContact { get; set; }

        /// <summary>
        /// ApiUser model
        /// </summary>
        /// <value>ApiUser model</value>
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateListService {\n");
            sb.Append("  EnableNavigation: ").Append(EnableNavigation).Append("\n");
            sb.Append("  DefaultListType: ").Append(DefaultListType).Append("\n");
            sb.Append("  VersionSettings: ").Append(VersionSettings).Append("\n");
            sb.Append("  ListTemplateSettings: ").Append(ListTemplateSettings).Append("\n");
            sb.Append("  UrlSettings: ").Append(UrlSettings).Append("\n");
            sb.Append("  AllowBreakPermissionInheritance: ").Append(AllowBreakPermissionInheritance).Append("\n");
            sb.Append("  PermissionSettings: ").Append(PermissionSettings).Append("\n");
            sb.Append("  ScopeSettings: ").Append(ScopeSettings).Append("\n");
            sb.Append("  ListVersionAssignBy: ").Append(ListVersionAssignBy).Append("\n");
            sb.Append("  ListTemplateAssignBy: ").Append(ListTemplateAssignBy).Append("\n");
            sb.Append("  NavigationAssignBy: ").Append(NavigationAssignBy).Append("\n");
            sb.Append("  ListTypeAssignBy: ").Append(ListTypeAssignBy).Append("\n");
            sb.Append("  RequestTemplate: ").Append(RequestTemplate).Append("\n");
            sb.Append("  Metadatas: ").Append(Metadatas).Append("\n");
            sb.Append("  HideRequestSummary: ").Append(HideRequestSummary).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ServiceContact: ").Append(ServiceContact).Append("\n");
            sb.Append("  ServiceAdminContact: ").Append(ServiceAdminContact).Append("\n");
            sb.Append("  ApproversContainManagerRole: ").Append(ApproversContainManagerRole).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ShowServiceInCatalog: ").Append(ShowServiceInCatalog).Append("\n");
            sb.Append("  CustomActions: ").Append(CustomActions).Append("\n");
            sb.Append("  ApprovalProcessId: ").Append(ApprovalProcessId).Append("\n");
            sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
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
            return this.Equals(input as CreateListService);
        }

        /// <summary>
        /// Returns true if CreateListService instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateListService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateListService input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnableNavigation == input.EnableNavigation ||
                    this.EnableNavigation.Equals(input.EnableNavigation)
                ) && 
                (
                    this.DefaultListType == input.DefaultListType ||
                    this.DefaultListType.Equals(input.DefaultListType)
                ) && 
                (
                    this.VersionSettings == input.VersionSettings ||
                    (this.VersionSettings != null &&
                    this.VersionSettings.Equals(input.VersionSettings))
                ) && 
                (
                    this.ListTemplateSettings == input.ListTemplateSettings ||
                    (this.ListTemplateSettings != null &&
                    this.ListTemplateSettings.Equals(input.ListTemplateSettings))
                ) && 
                (
                    this.UrlSettings == input.UrlSettings ||
                    (this.UrlSettings != null &&
                    this.UrlSettings.Equals(input.UrlSettings))
                ) && 
                (
                    this.AllowBreakPermissionInheritance == input.AllowBreakPermissionInheritance ||
                    this.AllowBreakPermissionInheritance.Equals(input.AllowBreakPermissionInheritance)
                ) && 
                (
                    this.PermissionSettings == input.PermissionSettings ||
                    (this.PermissionSettings != null &&
                    this.PermissionSettings.Equals(input.PermissionSettings))
                ) && 
                (
                    this.ScopeSettings == input.ScopeSettings ||
                    (this.ScopeSettings != null &&
                    this.ScopeSettings.Equals(input.ScopeSettings))
                ) && 
                (
                    this.ListVersionAssignBy == input.ListVersionAssignBy ||
                    this.ListVersionAssignBy.Equals(input.ListVersionAssignBy)
                ) && 
                (
                    this.ListTemplateAssignBy == input.ListTemplateAssignBy ||
                    this.ListTemplateAssignBy.Equals(input.ListTemplateAssignBy)
                ) && 
                (
                    this.NavigationAssignBy == input.NavigationAssignBy ||
                    this.NavigationAssignBy.Equals(input.NavigationAssignBy)
                ) && 
                (
                    this.ListTypeAssignBy == input.ListTypeAssignBy ||
                    this.ListTypeAssignBy.Equals(input.ListTypeAssignBy)
                ) && 
                (
                    this.RequestTemplate == input.RequestTemplate ||
                    (this.RequestTemplate != null &&
                    this.RequestTemplate.Equals(input.RequestTemplate))
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
                hashCode = hashCode * 59 + this.EnableNavigation.GetHashCode();
                hashCode = hashCode * 59 + this.DefaultListType.GetHashCode();
                if (this.VersionSettings != null)
                    hashCode = hashCode * 59 + this.VersionSettings.GetHashCode();
                if (this.ListTemplateSettings != null)
                    hashCode = hashCode * 59 + this.ListTemplateSettings.GetHashCode();
                if (this.UrlSettings != null)
                    hashCode = hashCode * 59 + this.UrlSettings.GetHashCode();
                hashCode = hashCode * 59 + this.AllowBreakPermissionInheritance.GetHashCode();
                if (this.PermissionSettings != null)
                    hashCode = hashCode * 59 + this.PermissionSettings.GetHashCode();
                if (this.ScopeSettings != null)
                    hashCode = hashCode * 59 + this.ScopeSettings.GetHashCode();
                hashCode = hashCode * 59 + this.ListVersionAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.ListTemplateAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.NavigationAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.ListTypeAssignBy.GetHashCode();
                if (this.RequestTemplate != null)
                    hashCode = hashCode * 59 + this.RequestTemplate.GetHashCode();
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
