

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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Cloud.Governance.Client.Client.OpenAPIDateConverter;

namespace Cloud.Governance.Client.Model
{
    /// <summary>
    /// CreateWebService
    /// </summary>
    [DataContract(Name = "CreateWebService")]
    public partial class CreateWebService : IEquatable<CreateWebService>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ScopeAssignBy
        /// </summary>
        [DataMember(Name = "scopeAssignBy", EmitDefaultValue = false)]
        public AssignBy? ScopeAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets WebLanguageAssignBy
        /// </summary>
        [DataMember(Name = "webLanguageAssignBy", EmitDefaultValue = false)]
        public AssignBy? WebLanguageAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets TemplateAssignBy
        /// </summary>
        [DataMember(Name = "templateAssignBy", EmitDefaultValue = false)]
        public AssignBy? TemplateAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets NavigationInheritanceAssignBy
        /// </summary>
        [DataMember(Name = "navigationInheritanceAssignBy", EmitDefaultValue = false)]
        public AssignBy? NavigationInheritanceAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets NavigationAssignBy
        /// </summary>
        [DataMember(Name = "navigationAssignBy", EmitDefaultValue = false)]
        public AssignBy? NavigationAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets PrimaryContactAssignBy
        /// </summary>
        [DataMember(Name = "primaryContactAssignBy", EmitDefaultValue = false)]
        public AssignBy? PrimaryContactAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets SecondaryContactAssignBy
        /// </summary>
        [DataMember(Name = "secondaryContactAssignBy", EmitDefaultValue = false)]
        public AssignBy? SecondaryContactAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets PermissionAssignBy
        /// </summary>
        [DataMember(Name = "permissionAssignBy", EmitDefaultValue = false)]
        public AssignBy? PermissionAssignBy { get; set; }
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
        /// Initializes a new instance of the <see cref="CreateWebService" /> class.
        /// </summary>
        /// <param name="scopeSettings">scopeSettings.</param>
        /// <param name="webLanguages">webLanguages.</param>
        /// <param name="languageIdsAndTemplates">languageIdsAndTemplates.</param>
        /// <param name="templateIdsAndPermissions">templateIdsAndPermissions.</param>
        /// <param name="permissionSettings">permissionSettings.</param>
        /// <param name="useUniquePermissions">useUniquePermissions.</param>
        /// <param name="deploymentManagerPlanSettings">deploymentManagerPlanSettings.</param>
        /// <param name="yammerGroupSettings">yammerGroupSettings.</param>
        /// <param name="templateStoreUrl">templateStoreUrl.</param>
        /// <param name="appSettings">appSettings.</param>
        /// <param name="notifyPrimaryContactSettings">notifyPrimaryContactSettings.</param>
        /// <param name="notifySecondaryContactSettings">notifySecondaryContactSettings.</param>
        /// <param name="defaultPrimaryContact">defaultPrimaryContact.</param>
        /// <param name="defaultSecondaryContact">defaultSecondaryContact.</param>
        /// <param name="isOnQuickLaunch">isOnQuickLaunch.</param>
        /// <param name="isOnTopLinkBar">isOnTopLinkBar.</param>
        /// <param name="isNavigationInheritance">isNavigationInheritance.</param>
        /// <param name="defaultWebLanguage">defaultWebLanguage.</param>
        /// <param name="scopeAssignBy">scopeAssignBy.</param>
        /// <param name="webLanguageAssignBy">webLanguageAssignBy.</param>
        /// <param name="templateAssignBy">templateAssignBy.</param>
        /// <param name="navigationInheritanceAssignBy">navigationInheritanceAssignBy.</param>
        /// <param name="navigationAssignBy">navigationAssignBy.</param>
        /// <param name="primaryContactAssignBy">primaryContactAssignBy.</param>
        /// <param name="secondaryContactAssignBy">secondaryContactAssignBy.</param>
        /// <param name="permissionAssignBy">permissionAssignBy.</param>
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
        public CreateWebService(CreateWebScopeSettings scopeSettings = default(CreateWebScopeSettings), List<IntModel> webLanguages = default(List<IntModel>), List<LanguageWithTemplates> languageIdsAndTemplates = default(List<LanguageWithTemplates>), List<TemplateWithPermissions> templateIdsAndPermissions = default(List<TemplateWithPermissions>), PermissionSettings permissionSettings = default(PermissionSettings), bool useUniquePermissions = default(bool), DeploymentManagerPlanSettings deploymentManagerPlanSettings = default(DeploymentManagerPlanSettings), YammerGroupServiceSettings yammerGroupSettings = default(YammerGroupServiceSettings), string templateStoreUrl = default(string), AppSettings appSettings = default(AppSettings), GuidBooleanModel notifyPrimaryContactSettings = default(GuidBooleanModel), GuidBooleanModel notifySecondaryContactSettings = default(GuidBooleanModel), ApiUser defaultPrimaryContact = default(ApiUser), ApiUser defaultSecondaryContact = default(ApiUser), bool isOnQuickLaunch = default(bool), bool isOnTopLinkBar = default(bool), bool isNavigationInheritance = default(bool), int defaultWebLanguage = default(int), AssignBy? scopeAssignBy = default(AssignBy?), AssignBy? webLanguageAssignBy = default(AssignBy?), AssignBy? templateAssignBy = default(AssignBy?), AssignBy? navigationInheritanceAssignBy = default(AssignBy?), AssignBy? navigationAssignBy = default(AssignBy?), AssignBy? primaryContactAssignBy = default(AssignBy?), AssignBy? secondaryContactAssignBy = default(AssignBy?), AssignBy? permissionAssignBy = default(AssignBy?), AssignBy? departmentAssignBy = default(AssignBy?), List<CustomMetadata> metadatas = default(List<CustomMetadata>), bool hideRequestSummary = default(bool), Guid id = default(Guid), string name = default(string), string description = default(string), ServiceType? type = default(ServiceType?), string department = default(string), bool loadDepartmentFromUps = default(bool), List<string> departments = default(List<string>), ApiUser serviceContact = default(ApiUser), ApiUser serviceAdminContact = default(ApiUser), bool approversContainManagerRole = default(bool), CommonStatus? status = default(CommonStatus?), bool showServiceInCatalog = default(bool), CustomActionSettings customActions = default(CustomActionSettings), Guid approvalProcessId = default(Guid), int languageId = default(int), string categoryId = default(string))
        {
            this.ScopeSettings = scopeSettings;
            this.WebLanguages = webLanguages;
            this.LanguageIdsAndTemplates = languageIdsAndTemplates;
            this.TemplateIdsAndPermissions = templateIdsAndPermissions;
            this.PermissionSettings = permissionSettings;
            this.UseUniquePermissions = useUniquePermissions;
            this.DeploymentManagerPlanSettings = deploymentManagerPlanSettings;
            this.YammerGroupSettings = yammerGroupSettings;
            this.TemplateStoreUrl = templateStoreUrl;
            this.AppSettings = appSettings;
            this.NotifyPrimaryContactSettings = notifyPrimaryContactSettings;
            this.NotifySecondaryContactSettings = notifySecondaryContactSettings;
            this.DefaultPrimaryContact = defaultPrimaryContact;
            this.DefaultSecondaryContact = defaultSecondaryContact;
            this.IsOnQuickLaunch = isOnQuickLaunch;
            this.IsOnTopLinkBar = isOnTopLinkBar;
            this.IsNavigationInheritance = isNavigationInheritance;
            this.DefaultWebLanguage = defaultWebLanguage;
            this.ScopeAssignBy = scopeAssignBy;
            this.WebLanguageAssignBy = webLanguageAssignBy;
            this.TemplateAssignBy = templateAssignBy;
            this.NavigationInheritanceAssignBy = navigationInheritanceAssignBy;
            this.NavigationAssignBy = navigationAssignBy;
            this.PrimaryContactAssignBy = primaryContactAssignBy;
            this.SecondaryContactAssignBy = secondaryContactAssignBy;
            this.PermissionAssignBy = permissionAssignBy;
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
        }

        /// <summary>
        /// Gets or Sets ScopeSettings
        /// </summary>
        [DataMember(Name = "scopeSettings", EmitDefaultValue = false)]
        public CreateWebScopeSettings ScopeSettings { get; set; }

        /// <summary>
        /// Gets or Sets WebLanguages
        /// </summary>
        [DataMember(Name = "webLanguages", EmitDefaultValue = true)]
        public List<IntModel> WebLanguages { get; set; }

        /// <summary>
        /// Gets or Sets LanguageIdsAndTemplates
        /// </summary>
        [DataMember(Name = "languageIdsAndTemplates", EmitDefaultValue = true)]
        public List<LanguageWithTemplates> LanguageIdsAndTemplates { get; set; }

        /// <summary>
        /// Gets or Sets TemplateIdsAndPermissions
        /// </summary>
        [DataMember(Name = "templateIdsAndPermissions", EmitDefaultValue = true)]
        public List<TemplateWithPermissions> TemplateIdsAndPermissions { get; set; }

        /// <summary>
        /// Gets or Sets PermissionSettings
        /// </summary>
        [DataMember(Name = "permissionSettings", EmitDefaultValue = false)]
        public PermissionSettings PermissionSettings { get; set; }

        /// <summary>
        /// Gets or Sets UseUniquePermissions
        /// </summary>
        [DataMember(Name = "useUniquePermissions", EmitDefaultValue = false)]
        public bool UseUniquePermissions { get; set; }

        /// <summary>
        /// Gets or Sets DeploymentManagerPlanSettings
        /// </summary>
        [DataMember(Name = "deploymentManagerPlanSettings", EmitDefaultValue = false)]
        public DeploymentManagerPlanSettings DeploymentManagerPlanSettings { get; set; }

        /// <summary>
        /// Gets or Sets YammerGroupSettings
        /// </summary>
        [DataMember(Name = "yammerGroupSettings", EmitDefaultValue = false)]
        public YammerGroupServiceSettings YammerGroupSettings { get; set; }

        /// <summary>
        /// Gets or Sets TemplateStoreUrl
        /// </summary>
        [DataMember(Name = "templateStoreUrl", EmitDefaultValue = true)]
        public string TemplateStoreUrl { get; set; }

        /// <summary>
        /// Gets or Sets AppSettings
        /// </summary>
        [DataMember(Name = "appSettings", EmitDefaultValue = false)]
        public AppSettings AppSettings { get; set; }

        /// <summary>
        /// Gets or Sets NotifyPrimaryContactSettings
        /// </summary>
        [DataMember(Name = "notifyPrimaryContactSettings", EmitDefaultValue = false)]
        public GuidBooleanModel NotifyPrimaryContactSettings { get; set; }

        /// <summary>
        /// Gets or Sets NotifySecondaryContactSettings
        /// </summary>
        [DataMember(Name = "notifySecondaryContactSettings", EmitDefaultValue = false)]
        public GuidBooleanModel NotifySecondaryContactSettings { get; set; }

        /// <summary>
        /// Gets or Sets DefaultPrimaryContact
        /// </summary>
        [DataMember(Name = "defaultPrimaryContact", EmitDefaultValue = false)]
        public ApiUser DefaultPrimaryContact { get; set; }

        /// <summary>
        /// Gets or Sets DefaultSecondaryContact
        /// </summary>
        [DataMember(Name = "defaultSecondaryContact", EmitDefaultValue = false)]
        public ApiUser DefaultSecondaryContact { get; set; }

        /// <summary>
        /// Gets or Sets IsOnQuickLaunch
        /// </summary>
        [DataMember(Name = "isOnQuickLaunch", EmitDefaultValue = false)]
        public bool IsOnQuickLaunch { get; set; }

        /// <summary>
        /// Gets or Sets IsOnTopLinkBar
        /// </summary>
        [DataMember(Name = "isOnTopLinkBar", EmitDefaultValue = false)]
        public bool IsOnTopLinkBar { get; set; }

        /// <summary>
        /// Gets or Sets IsNavigationInheritance
        /// </summary>
        [DataMember(Name = "isNavigationInheritance", EmitDefaultValue = false)]
        public bool IsNavigationInheritance { get; set; }

        /// <summary>
        /// Gets or Sets DefaultWebLanguage
        /// </summary>
        [DataMember(Name = "defaultWebLanguage", EmitDefaultValue = false)]
        public int DefaultWebLanguage { get; set; }

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
        [DataMember(Name = "serviceContact", EmitDefaultValue = false)]
        public ApiUser ServiceContact { get; set; }

        /// <summary>
        /// Gets or Sets ServiceAdminContact
        /// </summary>
        [DataMember(Name = "serviceAdminContact", EmitDefaultValue = false)]
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
        [DataMember(Name = "customActions", EmitDefaultValue = false)]
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
            sb.Append("class CreateWebService {\n");
            sb.Append("  ScopeSettings: ").Append(ScopeSettings).Append("\n");
            sb.Append("  WebLanguages: ").Append(WebLanguages).Append("\n");
            sb.Append("  LanguageIdsAndTemplates: ").Append(LanguageIdsAndTemplates).Append("\n");
            sb.Append("  TemplateIdsAndPermissions: ").Append(TemplateIdsAndPermissions).Append("\n");
            sb.Append("  PermissionSettings: ").Append(PermissionSettings).Append("\n");
            sb.Append("  UseUniquePermissions: ").Append(UseUniquePermissions).Append("\n");
            sb.Append("  DeploymentManagerPlanSettings: ").Append(DeploymentManagerPlanSettings).Append("\n");
            sb.Append("  YammerGroupSettings: ").Append(YammerGroupSettings).Append("\n");
            sb.Append("  TemplateStoreUrl: ").Append(TemplateStoreUrl).Append("\n");
            sb.Append("  AppSettings: ").Append(AppSettings).Append("\n");
            sb.Append("  NotifyPrimaryContactSettings: ").Append(NotifyPrimaryContactSettings).Append("\n");
            sb.Append("  NotifySecondaryContactSettings: ").Append(NotifySecondaryContactSettings).Append("\n");
            sb.Append("  DefaultPrimaryContact: ").Append(DefaultPrimaryContact).Append("\n");
            sb.Append("  DefaultSecondaryContact: ").Append(DefaultSecondaryContact).Append("\n");
            sb.Append("  IsOnQuickLaunch: ").Append(IsOnQuickLaunch).Append("\n");
            sb.Append("  IsOnTopLinkBar: ").Append(IsOnTopLinkBar).Append("\n");
            sb.Append("  IsNavigationInheritance: ").Append(IsNavigationInheritance).Append("\n");
            sb.Append("  DefaultWebLanguage: ").Append(DefaultWebLanguage).Append("\n");
            sb.Append("  ScopeAssignBy: ").Append(ScopeAssignBy).Append("\n");
            sb.Append("  WebLanguageAssignBy: ").Append(WebLanguageAssignBy).Append("\n");
            sb.Append("  TemplateAssignBy: ").Append(TemplateAssignBy).Append("\n");
            sb.Append("  NavigationInheritanceAssignBy: ").Append(NavigationInheritanceAssignBy).Append("\n");
            sb.Append("  NavigationAssignBy: ").Append(NavigationAssignBy).Append("\n");
            sb.Append("  PrimaryContactAssignBy: ").Append(PrimaryContactAssignBy).Append("\n");
            sb.Append("  SecondaryContactAssignBy: ").Append(SecondaryContactAssignBy).Append("\n");
            sb.Append("  PermissionAssignBy: ").Append(PermissionAssignBy).Append("\n");
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
            return this.Equals(input as CreateWebService);
        }

        /// <summary>
        /// Returns true if CreateWebService instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateWebService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateWebService input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScopeSettings == input.ScopeSettings ||
                    (this.ScopeSettings != null &&
                    this.ScopeSettings.Equals(input.ScopeSettings))
                ) && 
                (
                    this.WebLanguages == input.WebLanguages ||
                    this.WebLanguages != null &&
                    input.WebLanguages != null &&
                    this.WebLanguages.SequenceEqual(input.WebLanguages)
                ) && 
                (
                    this.LanguageIdsAndTemplates == input.LanguageIdsAndTemplates ||
                    this.LanguageIdsAndTemplates != null &&
                    input.LanguageIdsAndTemplates != null &&
                    this.LanguageIdsAndTemplates.SequenceEqual(input.LanguageIdsAndTemplates)
                ) && 
                (
                    this.TemplateIdsAndPermissions == input.TemplateIdsAndPermissions ||
                    this.TemplateIdsAndPermissions != null &&
                    input.TemplateIdsAndPermissions != null &&
                    this.TemplateIdsAndPermissions.SequenceEqual(input.TemplateIdsAndPermissions)
                ) && 
                (
                    this.PermissionSettings == input.PermissionSettings ||
                    (this.PermissionSettings != null &&
                    this.PermissionSettings.Equals(input.PermissionSettings))
                ) && 
                (
                    this.UseUniquePermissions == input.UseUniquePermissions ||
                    this.UseUniquePermissions.Equals(input.UseUniquePermissions)
                ) && 
                (
                    this.DeploymentManagerPlanSettings == input.DeploymentManagerPlanSettings ||
                    (this.DeploymentManagerPlanSettings != null &&
                    this.DeploymentManagerPlanSettings.Equals(input.DeploymentManagerPlanSettings))
                ) && 
                (
                    this.YammerGroupSettings == input.YammerGroupSettings ||
                    (this.YammerGroupSettings != null &&
                    this.YammerGroupSettings.Equals(input.YammerGroupSettings))
                ) && 
                (
                    this.TemplateStoreUrl == input.TemplateStoreUrl ||
                    (this.TemplateStoreUrl != null &&
                    this.TemplateStoreUrl.Equals(input.TemplateStoreUrl))
                ) && 
                (
                    this.AppSettings == input.AppSettings ||
                    (this.AppSettings != null &&
                    this.AppSettings.Equals(input.AppSettings))
                ) && 
                (
                    this.NotifyPrimaryContactSettings == input.NotifyPrimaryContactSettings ||
                    (this.NotifyPrimaryContactSettings != null &&
                    this.NotifyPrimaryContactSettings.Equals(input.NotifyPrimaryContactSettings))
                ) && 
                (
                    this.NotifySecondaryContactSettings == input.NotifySecondaryContactSettings ||
                    (this.NotifySecondaryContactSettings != null &&
                    this.NotifySecondaryContactSettings.Equals(input.NotifySecondaryContactSettings))
                ) && 
                (
                    this.DefaultPrimaryContact == input.DefaultPrimaryContact ||
                    (this.DefaultPrimaryContact != null &&
                    this.DefaultPrimaryContact.Equals(input.DefaultPrimaryContact))
                ) && 
                (
                    this.DefaultSecondaryContact == input.DefaultSecondaryContact ||
                    (this.DefaultSecondaryContact != null &&
                    this.DefaultSecondaryContact.Equals(input.DefaultSecondaryContact))
                ) && 
                (
                    this.IsOnQuickLaunch == input.IsOnQuickLaunch ||
                    this.IsOnQuickLaunch.Equals(input.IsOnQuickLaunch)
                ) && 
                (
                    this.IsOnTopLinkBar == input.IsOnTopLinkBar ||
                    this.IsOnTopLinkBar.Equals(input.IsOnTopLinkBar)
                ) && 
                (
                    this.IsNavigationInheritance == input.IsNavigationInheritance ||
                    this.IsNavigationInheritance.Equals(input.IsNavigationInheritance)
                ) && 
                (
                    this.DefaultWebLanguage == input.DefaultWebLanguage ||
                    this.DefaultWebLanguage.Equals(input.DefaultWebLanguage)
                ) && 
                (
                    this.ScopeAssignBy == input.ScopeAssignBy ||
                    this.ScopeAssignBy.Equals(input.ScopeAssignBy)
                ) && 
                (
                    this.WebLanguageAssignBy == input.WebLanguageAssignBy ||
                    this.WebLanguageAssignBy.Equals(input.WebLanguageAssignBy)
                ) && 
                (
                    this.TemplateAssignBy == input.TemplateAssignBy ||
                    this.TemplateAssignBy.Equals(input.TemplateAssignBy)
                ) && 
                (
                    this.NavigationInheritanceAssignBy == input.NavigationInheritanceAssignBy ||
                    this.NavigationInheritanceAssignBy.Equals(input.NavigationInheritanceAssignBy)
                ) && 
                (
                    this.NavigationAssignBy == input.NavigationAssignBy ||
                    this.NavigationAssignBy.Equals(input.NavigationAssignBy)
                ) && 
                (
                    this.PrimaryContactAssignBy == input.PrimaryContactAssignBy ||
                    this.PrimaryContactAssignBy.Equals(input.PrimaryContactAssignBy)
                ) && 
                (
                    this.SecondaryContactAssignBy == input.SecondaryContactAssignBy ||
                    this.SecondaryContactAssignBy.Equals(input.SecondaryContactAssignBy)
                ) && 
                (
                    this.PermissionAssignBy == input.PermissionAssignBy ||
                    this.PermissionAssignBy.Equals(input.PermissionAssignBy)
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
                if (this.ScopeSettings != null)
                    hashCode = hashCode * 59 + this.ScopeSettings.GetHashCode();
                if (this.WebLanguages != null)
                    hashCode = hashCode * 59 + this.WebLanguages.GetHashCode();
                if (this.LanguageIdsAndTemplates != null)
                    hashCode = hashCode * 59 + this.LanguageIdsAndTemplates.GetHashCode();
                if (this.TemplateIdsAndPermissions != null)
                    hashCode = hashCode * 59 + this.TemplateIdsAndPermissions.GetHashCode();
                if (this.PermissionSettings != null)
                    hashCode = hashCode * 59 + this.PermissionSettings.GetHashCode();
                hashCode = hashCode * 59 + this.UseUniquePermissions.GetHashCode();
                if (this.DeploymentManagerPlanSettings != null)
                    hashCode = hashCode * 59 + this.DeploymentManagerPlanSettings.GetHashCode();
                if (this.YammerGroupSettings != null)
                    hashCode = hashCode * 59 + this.YammerGroupSettings.GetHashCode();
                if (this.TemplateStoreUrl != null)
                    hashCode = hashCode * 59 + this.TemplateStoreUrl.GetHashCode();
                if (this.AppSettings != null)
                    hashCode = hashCode * 59 + this.AppSettings.GetHashCode();
                if (this.NotifyPrimaryContactSettings != null)
                    hashCode = hashCode * 59 + this.NotifyPrimaryContactSettings.GetHashCode();
                if (this.NotifySecondaryContactSettings != null)
                    hashCode = hashCode * 59 + this.NotifySecondaryContactSettings.GetHashCode();
                if (this.DefaultPrimaryContact != null)
                    hashCode = hashCode * 59 + this.DefaultPrimaryContact.GetHashCode();
                if (this.DefaultSecondaryContact != null)
                    hashCode = hashCode * 59 + this.DefaultSecondaryContact.GetHashCode();
                hashCode = hashCode * 59 + this.IsOnQuickLaunch.GetHashCode();
                hashCode = hashCode * 59 + this.IsOnTopLinkBar.GetHashCode();
                hashCode = hashCode * 59 + this.IsNavigationInheritance.GetHashCode();
                hashCode = hashCode * 59 + this.DefaultWebLanguage.GetHashCode();
                hashCode = hashCode * 59 + this.ScopeAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.WebLanguageAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.TemplateAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.NavigationInheritanceAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.NavigationAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.PrimaryContactAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.SecondaryContactAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.PermissionAssignBy.GetHashCode();
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
