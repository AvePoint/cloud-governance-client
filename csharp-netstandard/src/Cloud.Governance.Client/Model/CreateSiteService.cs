

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
    /// CreateSiteService
    /// </summary>
    [DataContract(Name = "CreateSiteService")]
    public partial class CreateSiteService : IEquatable<CreateSiteService>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets SiteDesignAssignBy
        /// </summary>
        [DataMember(Name = "siteDesignAssignBy", EmitDefaultValue = false)]
        public AssignBy? SiteDesignAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets SiteLanguageAssignBy
        /// </summary>
        [DataMember(Name = "siteLanguageAssignBy", EmitDefaultValue = false)]
        public AssignBy? SiteLanguageAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets TemplateAssignBy
        /// </summary>
        [DataMember(Name = "templateAssignBy", EmitDefaultValue = false)]
        public AssignBy? TemplateAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets PolicyAssignBy
        /// </summary>
        [DataMember(Name = "policyAssignBy", EmitDefaultValue = false)]
        public AssignBy? PolicyAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets PermissionAssignBy
        /// </summary>
        [DataMember(Name = "permissionAssignBy", EmitDefaultValue = false)]
        public AssignBy? PermissionAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets RootSiteAndManagedPathAssignBy
        /// </summary>
        [DataMember(Name = "rootSiteAndManagedPathAssignBy", EmitDefaultValue = false)]
        public AssignBy? RootSiteAndManagedPathAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets TimeZoneAssignBy
        /// </summary>
        [DataMember(Name = "timeZoneAssignBy", EmitDefaultValue = false)]
        public AssignBy? TimeZoneAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets PrimaryAdminAssignBy
        /// </summary>
        [DataMember(Name = "primaryAdminAssignBy", EmitDefaultValue = false)]
        public AssignBy? PrimaryAdminAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets AdditionalAdminAssignBy
        /// </summary>
        [DataMember(Name = "additionalAdminAssignBy", EmitDefaultValue = false)]
        public AssignBy? AdditionalAdminAssignBy { get; set; }
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
        /// Gets or Sets DesignTypeAssignBy
        /// </summary>
        [DataMember(Name = "designTypeAssignBy", EmitDefaultValue = false)]
        public AssignBy? DesignTypeAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets ClassificationAssignBy
        /// </summary>
        [DataMember(Name = "classificationAssignBy", EmitDefaultValue = false)]
        public AssignBy? ClassificationAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets SensitivityAssignBy
        /// </summary>
        [DataMember(Name = "sensitivityAssignBy", EmitDefaultValue = false)]
        public AssignBy? SensitivityAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets HubSiteAssignBy
        /// </summary>
        [DataMember(Name = "hubSiteAssignBy", EmitDefaultValue = false)]
        public AssignBy? HubSiteAssignBy { get; set; }
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
        /// Initializes a new instance of the <see cref="CreateSiteService" /> class.
        /// </summary>
        /// <param name="scopeSettings">scopeSettings.</param>
        /// <param name="adminCenterUrl">adminCenterUrl.</param>
        /// <param name="siteLanguages">siteLanguages.</param>
        /// <param name="rootSiteAndManagedPaths">rootSiteAndManagedPaths.</param>
        /// <param name="siteUrlSetting">siteUrlSetting.</param>
        /// <param name="multiGeoSetting">multiGeoSetting.</param>
        /// <param name="siteTitleSetting">siteTitleSetting.</param>
        /// <param name="policies">policies.</param>
        /// <param name="deploymentManagerPlanSettings">deploymentManagerPlanSettings.</param>
        /// <param name="policyIdsAndTemplates">policyIdsAndTemplates.</param>
        /// <param name="templateIdsAndPermissions">templateIdsAndPermissions.</param>
        /// <param name="permissionSettings">permissionSettings.</param>
        /// <param name="leasePeriodSettings">leasePeriodSettings.</param>
        /// <param name="timeZones">timeZones.</param>
        /// <param name="siteDesigns">siteDesigns.</param>
        /// <param name="siteDesign">siteDesign.</param>
        /// <param name="defaultTeamSiteDesignId">defaultTeamSiteDesignId.</param>
        /// <param name="siteDesignAssignBy">siteDesignAssignBy.</param>
        /// <param name="yammerGroupSettings">yammerGroupSettings.</param>
        /// <param name="classifications">classifications.</param>
        /// <param name="sensitivities">sensitivities.</param>
        /// <param name="hubSiteSettings">hubSiteSettings.</param>
        /// <param name="enabledCustomTemplate">enabledCustomTemplate.</param>
        /// <param name="customSiteTemplateListURL">customSiteTemplateListURL.</param>
        /// <param name="defaultPrimaryAdmin">defaultPrimaryAdmin.</param>
        /// <param name="defaultAdditionalAdmins">defaultAdditionalAdmins.</param>
        /// <param name="defaultPrimaryAdminReal">defaultPrimaryAdminReal.</param>
        /// <param name="defaultAdditionalAdminsReal">defaultAdditionalAdminsReal.</param>
        /// <param name="defaultPrimaryContact">defaultPrimaryContact.</param>
        /// <param name="defaultSecondaryContact">defaultSecondaryContact.</param>
        /// <param name="defaultSiteLanguage">defaultSiteLanguage.</param>
        /// <param name="defaultRootSite">defaultRootSite.</param>
        /// <param name="defaultManagedPath">defaultManagedPath.</param>
        /// <param name="defaultPolicy">defaultPolicy.</param>
        /// <param name="defaultTemplate">defaultTemplate.</param>
        /// <param name="defaultTimeZone">defaultTimeZone.</param>
        /// <param name="defaultClassification">defaultClassification.</param>
        /// <param name="defaultSensitivity">defaultSensitivity.</param>
        /// <param name="defaultDesignType">defaultDesignType.</param>
        /// <param name="siteLanguageAssignBy">siteLanguageAssignBy.</param>
        /// <param name="templateAssignBy">templateAssignBy.</param>
        /// <param name="policyAssignBy">policyAssignBy.</param>
        /// <param name="permissionAssignBy">permissionAssignBy.</param>
        /// <param name="rootSiteAndManagedPathAssignBy">rootSiteAndManagedPathAssignBy.</param>
        /// <param name="timeZoneAssignBy">timeZoneAssignBy.</param>
        /// <param name="primaryAdminAssignBy">primaryAdminAssignBy.</param>
        /// <param name="additionalAdminAssignBy">additionalAdminAssignBy.</param>
        /// <param name="primaryContactAssignBy">primaryContactAssignBy.</param>
        /// <param name="secondaryContactAssignBy">secondaryContactAssignBy.</param>
        /// <param name="designTypeAssignBy">designTypeAssignBy.</param>
        /// <param name="classificationAssignBy">classificationAssignBy.</param>
        /// <param name="sensitivityAssignBy">sensitivityAssignBy.</param>
        /// <param name="hubSiteAssignBy">hubSiteAssignBy.</param>
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
        public CreateSiteService(ServiceScopeSettings scopeSettings = default(ServiceScopeSettings), string adminCenterUrl = default(string), List<IntModel> siteLanguages = default(List<IntModel>), List<RootSiteWithManagedPaths> rootSiteAndManagedPaths = default(List<RootSiteWithManagedPaths>), SiteUrlSetting siteUrlSetting = default(SiteUrlSetting), MultiGeoSerivceSetting multiGeoSetting = default(MultiGeoSerivceSetting), SiteTitleSetting siteTitleSetting = default(SiteTitleSetting), List<PolicyRef> policies = default(List<PolicyRef>), DeploymentManagerPlanSettings deploymentManagerPlanSettings = default(DeploymentManagerPlanSettings), List<PolicyWithTemplates> policyIdsAndTemplates = default(List<PolicyWithTemplates>), List<TemplateWithPermissions> templateIdsAndPermissions = default(List<TemplateWithPermissions>), PermissionSettings permissionSettings = default(PermissionSettings), SiteLeasePeriodServiceSettings leasePeriodSettings = default(SiteLeasePeriodServiceSettings), List<IntModel> timeZones = default(List<IntModel>), List<StringModel> siteDesigns = default(List<StringModel>), GuidModel siteDesign = default(GuidModel), string defaultTeamSiteDesignId = default(string), AssignBy? siteDesignAssignBy = default(AssignBy?), YammerGroupServiceSettings yammerGroupSettings = default(YammerGroupServiceSettings), List<string> classifications = default(List<string>), List<string> sensitivities = default(List<string>), HubSiteSettings hubSiteSettings = default(HubSiteSettings), bool enabledCustomTemplate = default(bool), string customSiteTemplateListURL = default(string), ApiUser defaultPrimaryAdmin = default(ApiUser), List<ApiUser> defaultAdditionalAdmins = default(List<ApiUser>), ApiUser defaultPrimaryAdminReal = default(ApiUser), List<ApiUser> defaultAdditionalAdminsReal = default(List<ApiUser>), ApiUser defaultPrimaryContact = default(ApiUser), ApiUser defaultSecondaryContact = default(ApiUser), int defaultSiteLanguage = default(int), string defaultRootSite = default(string), string defaultManagedPath = default(string), Guid defaultPolicy = default(Guid), string defaultTemplate = default(string), int defaultTimeZone = default(int), string defaultClassification = default(string), string defaultSensitivity = default(string), string defaultDesignType = default(string), AssignBy? siteLanguageAssignBy = default(AssignBy?), AssignBy? templateAssignBy = default(AssignBy?), AssignBy? policyAssignBy = default(AssignBy?), AssignBy? permissionAssignBy = default(AssignBy?), AssignBy? rootSiteAndManagedPathAssignBy = default(AssignBy?), AssignBy? timeZoneAssignBy = default(AssignBy?), AssignBy? primaryAdminAssignBy = default(AssignBy?), AssignBy? additionalAdminAssignBy = default(AssignBy?), AssignBy? primaryContactAssignBy = default(AssignBy?), AssignBy? secondaryContactAssignBy = default(AssignBy?), AssignBy? designTypeAssignBy = default(AssignBy?), AssignBy? classificationAssignBy = default(AssignBy?), AssignBy? sensitivityAssignBy = default(AssignBy?), AssignBy? hubSiteAssignBy = default(AssignBy?), CreateSiteRequest requestTemplate = default(CreateSiteRequest), AssignBy? departmentAssignBy = default(AssignBy?), List<CustomMetadata> metadatas = default(List<CustomMetadata>), bool hideRequestSummary = default(bool), Guid id = default(Guid), string name = default(string), string description = default(string), ServiceType? type = default(ServiceType?), string department = default(string), bool loadDepartmentFromUps = default(bool), List<string> departments = default(List<string>), ApiUser serviceContact = default(ApiUser), ApiUser serviceAdminContact = default(ApiUser), bool approversContainManagerRole = default(bool), CommonStatus? status = default(CommonStatus?), bool showServiceInCatalog = default(bool), CustomActionSettings customActions = default(CustomActionSettings), Guid approvalProcessId = default(Guid), int languageId = default(int), string categoryId = default(string), string details = default(string))
        {
            this.ScopeSettings = scopeSettings;
            this.AdminCenterUrl = adminCenterUrl;
            this.SiteLanguages = siteLanguages;
            this.RootSiteAndManagedPaths = rootSiteAndManagedPaths;
            this.SiteUrlSetting = siteUrlSetting;
            this.MultiGeoSetting = multiGeoSetting;
            this.SiteTitleSetting = siteTitleSetting;
            this.Policies = policies;
            this.DeploymentManagerPlanSettings = deploymentManagerPlanSettings;
            this.PolicyIdsAndTemplates = policyIdsAndTemplates;
            this.TemplateIdsAndPermissions = templateIdsAndPermissions;
            this.PermissionSettings = permissionSettings;
            this.LeasePeriodSettings = leasePeriodSettings;
            this.TimeZones = timeZones;
            this.SiteDesigns = siteDesigns;
            this.SiteDesign = siteDesign;
            this.DefaultTeamSiteDesignId = defaultTeamSiteDesignId;
            this.SiteDesignAssignBy = siteDesignAssignBy;
            this.YammerGroupSettings = yammerGroupSettings;
            this.Classifications = classifications;
            this.Sensitivities = sensitivities;
            this.HubSiteSettings = hubSiteSettings;
            this.EnabledCustomTemplate = enabledCustomTemplate;
            this.CustomSiteTemplateListURL = customSiteTemplateListURL;
            this.DefaultPrimaryAdmin = defaultPrimaryAdmin;
            this.DefaultAdditionalAdmins = defaultAdditionalAdmins;
            this.DefaultPrimaryAdminReal = defaultPrimaryAdminReal;
            this.DefaultAdditionalAdminsReal = defaultAdditionalAdminsReal;
            this.DefaultPrimaryContact = defaultPrimaryContact;
            this.DefaultSecondaryContact = defaultSecondaryContact;
            this.DefaultSiteLanguage = defaultSiteLanguage;
            this.DefaultRootSite = defaultRootSite;
            this.DefaultManagedPath = defaultManagedPath;
            this.DefaultPolicy = defaultPolicy;
            this.DefaultTemplate = defaultTemplate;
            this.DefaultTimeZone = defaultTimeZone;
            this.DefaultClassification = defaultClassification;
            this.DefaultSensitivity = defaultSensitivity;
            this.DefaultDesignType = defaultDesignType;
            this.SiteLanguageAssignBy = siteLanguageAssignBy;
            this.TemplateAssignBy = templateAssignBy;
            this.PolicyAssignBy = policyAssignBy;
            this.PermissionAssignBy = permissionAssignBy;
            this.RootSiteAndManagedPathAssignBy = rootSiteAndManagedPathAssignBy;
            this.TimeZoneAssignBy = timeZoneAssignBy;
            this.PrimaryAdminAssignBy = primaryAdminAssignBy;
            this.AdditionalAdminAssignBy = additionalAdminAssignBy;
            this.PrimaryContactAssignBy = primaryContactAssignBy;
            this.SecondaryContactAssignBy = secondaryContactAssignBy;
            this.DesignTypeAssignBy = designTypeAssignBy;
            this.ClassificationAssignBy = classificationAssignBy;
            this.SensitivityAssignBy = sensitivityAssignBy;
            this.HubSiteAssignBy = hubSiteAssignBy;
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
        /// Gets or Sets ScopeSettings
        /// </summary>
        [DataMember(Name = "scopeSettings", EmitDefaultValue = true)]
        public ServiceScopeSettings ScopeSettings { get; set; }

        /// <summary>
        /// Gets or Sets AdminCenterUrl
        /// </summary>
        [DataMember(Name = "adminCenterUrl", EmitDefaultValue = true)]
        public string AdminCenterUrl { get; set; }

        /// <summary>
        /// Gets or Sets SiteLanguages
        /// </summary>
        [DataMember(Name = "siteLanguages", EmitDefaultValue = true)]
        public List<IntModel> SiteLanguages { get; set; }

        /// <summary>
        /// Gets or Sets RootSiteAndManagedPaths
        /// </summary>
        [DataMember(Name = "rootSiteAndManagedPaths", EmitDefaultValue = true)]
        public List<RootSiteWithManagedPaths> RootSiteAndManagedPaths { get; set; }

        /// <summary>
        /// Gets or Sets SiteUrlSetting
        /// </summary>
        [DataMember(Name = "siteUrlSetting", EmitDefaultValue = true)]
        public SiteUrlSetting SiteUrlSetting { get; set; }

        /// <summary>
        /// Gets or Sets MultiGeoSetting
        /// </summary>
        [DataMember(Name = "multiGeoSetting", EmitDefaultValue = true)]
        public MultiGeoSerivceSetting MultiGeoSetting { get; set; }

        /// <summary>
        /// Gets or Sets SiteTitleSetting
        /// </summary>
        [DataMember(Name = "siteTitleSetting", EmitDefaultValue = true)]
        public SiteTitleSetting SiteTitleSetting { get; set; }

        /// <summary>
        /// Gets or Sets Policies
        /// </summary>
        [DataMember(Name = "policies", EmitDefaultValue = true)]
        public List<PolicyRef> Policies { get; set; }

        /// <summary>
        /// Gets or Sets DeploymentManagerPlanSettings
        /// </summary>
        [DataMember(Name = "deploymentManagerPlanSettings", EmitDefaultValue = true)]
        public DeploymentManagerPlanSettings DeploymentManagerPlanSettings { get; set; }

        /// <summary>
        /// Gets or Sets PolicyIdsAndTemplates
        /// </summary>
        [DataMember(Name = "policyIdsAndTemplates", EmitDefaultValue = true)]
        public List<PolicyWithTemplates> PolicyIdsAndTemplates { get; set; }

        /// <summary>
        /// Gets or Sets TemplateIdsAndPermissions
        /// </summary>
        [DataMember(Name = "templateIdsAndPermissions", EmitDefaultValue = true)]
        public List<TemplateWithPermissions> TemplateIdsAndPermissions { get; set; }

        /// <summary>
        /// Gets or Sets PermissionSettings
        /// </summary>
        [DataMember(Name = "permissionSettings", EmitDefaultValue = true)]
        public PermissionSettings PermissionSettings { get; set; }

        /// <summary>
        /// Gets or Sets LeasePeriodSettings
        /// </summary>
        [DataMember(Name = "leasePeriodSettings", EmitDefaultValue = true)]
        public SiteLeasePeriodServiceSettings LeasePeriodSettings { get; set; }

        /// <summary>
        /// Gets or Sets TimeZones
        /// </summary>
        [DataMember(Name = "timeZones", EmitDefaultValue = true)]
        public List<IntModel> TimeZones { get; set; }

        /// <summary>
        /// Gets or Sets SiteDesigns
        /// </summary>
        [DataMember(Name = "siteDesigns", EmitDefaultValue = true)]
        public List<StringModel> SiteDesigns { get; set; }

        /// <summary>
        /// Gets or Sets SiteDesign
        /// </summary>
        [DataMember(Name = "siteDesign", EmitDefaultValue = true)]
        public GuidModel SiteDesign { get; set; }

        /// <summary>
        /// Gets or Sets DefaultTeamSiteDesignId
        /// </summary>
        [DataMember(Name = "defaultTeamSiteDesignId", EmitDefaultValue = true)]
        public string DefaultTeamSiteDesignId { get; set; }

        /// <summary>
        /// Gets or Sets YammerGroupSettings
        /// </summary>
        [DataMember(Name = "yammerGroupSettings", EmitDefaultValue = true)]
        public YammerGroupServiceSettings YammerGroupSettings { get; set; }

        /// <summary>
        /// Gets or Sets Classifications
        /// </summary>
        [DataMember(Name = "classifications", EmitDefaultValue = true)]
        public List<string> Classifications { get; set; }

        /// <summary>
        /// Gets or Sets Sensitivities
        /// </summary>
        [DataMember(Name = "sensitivities", EmitDefaultValue = true)]
        public List<string> Sensitivities { get; set; }

        /// <summary>
        /// Gets or Sets HubSiteSettings
        /// </summary>
        [DataMember(Name = "hubSiteSettings", EmitDefaultValue = true)]
        public HubSiteSettings HubSiteSettings { get; set; }

        /// <summary>
        /// Gets or Sets EnabledCustomTemplate
        /// </summary>
        [DataMember(Name = "enabledCustomTemplate", EmitDefaultValue = false)]
        public bool EnabledCustomTemplate { get; set; }

        /// <summary>
        /// Gets or Sets CustomSiteTemplateListURL
        /// </summary>
        [DataMember(Name = "customSiteTemplateListURL", EmitDefaultValue = true)]
        public string CustomSiteTemplateListURL { get; set; }

        /// <summary>
        /// Gets or Sets DefaultPrimaryAdmin
        /// </summary>
        [DataMember(Name = "defaultPrimaryAdmin", EmitDefaultValue = true)]
        public ApiUser DefaultPrimaryAdmin { get; set; }

        /// <summary>
        /// Gets or Sets DefaultAdditionalAdmins
        /// </summary>
        [DataMember(Name = "defaultAdditionalAdmins", EmitDefaultValue = true)]
        public List<ApiUser> DefaultAdditionalAdmins { get; set; }

        /// <summary>
        /// Gets or Sets DefaultPrimaryAdminReal
        /// </summary>
        [DataMember(Name = "defaultPrimaryAdminReal", EmitDefaultValue = true)]
        public ApiUser DefaultPrimaryAdminReal { get; set; }

        /// <summary>
        /// Gets or Sets DefaultAdditionalAdminsReal
        /// </summary>
        [DataMember(Name = "defaultAdditionalAdminsReal", EmitDefaultValue = true)]
        public List<ApiUser> DefaultAdditionalAdminsReal { get; set; }

        /// <summary>
        /// Gets or Sets DefaultPrimaryContact
        /// </summary>
        [DataMember(Name = "defaultPrimaryContact", EmitDefaultValue = true)]
        public ApiUser DefaultPrimaryContact { get; set; }

        /// <summary>
        /// Gets or Sets DefaultSecondaryContact
        /// </summary>
        [DataMember(Name = "defaultSecondaryContact", EmitDefaultValue = true)]
        public ApiUser DefaultSecondaryContact { get; set; }

        /// <summary>
        /// Gets or Sets DefaultSiteLanguage
        /// </summary>
        [DataMember(Name = "defaultSiteLanguage", EmitDefaultValue = false)]
        public int DefaultSiteLanguage { get; set; }

        /// <summary>
        /// Gets or Sets DefaultRootSite
        /// </summary>
        [DataMember(Name = "defaultRootSite", EmitDefaultValue = true)]
        public string DefaultRootSite { get; set; }

        /// <summary>
        /// Gets or Sets DefaultManagedPath
        /// </summary>
        [DataMember(Name = "defaultManagedPath", EmitDefaultValue = true)]
        public string DefaultManagedPath { get; set; }

        /// <summary>
        /// Gets or Sets DefaultPolicy
        /// </summary>
        [DataMember(Name = "defaultPolicy", EmitDefaultValue = false)]
        public Guid DefaultPolicy { get; set; }

        /// <summary>
        /// Gets or Sets DefaultTemplate
        /// </summary>
        [DataMember(Name = "defaultTemplate", EmitDefaultValue = true)]
        public string DefaultTemplate { get; set; }

        /// <summary>
        /// Gets or Sets DefaultTimeZone
        /// </summary>
        [DataMember(Name = "defaultTimeZone", EmitDefaultValue = false)]
        public int DefaultTimeZone { get; set; }

        /// <summary>
        /// Gets or Sets DefaultClassification
        /// </summary>
        [DataMember(Name = "defaultClassification", EmitDefaultValue = true)]
        public string DefaultClassification { get; set; }

        /// <summary>
        /// Gets or Sets DefaultSensitivity
        /// </summary>
        [DataMember(Name = "defaultSensitivity", EmitDefaultValue = true)]
        public string DefaultSensitivity { get; set; }

        /// <summary>
        /// Gets or Sets DefaultDesignType
        /// </summary>
        [DataMember(Name = "defaultDesignType", EmitDefaultValue = true)]
        public string DefaultDesignType { get; set; }

        /// <summary>
        /// Gets or Sets RequestTemplate
        /// </summary>
        [DataMember(Name = "requestTemplate", EmitDefaultValue = true)]
        public CreateSiteRequest RequestTemplate { get; set; }

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
            sb.Append("class CreateSiteService {\n");
            sb.Append("  ScopeSettings: ").Append(ScopeSettings).Append("\n");
            sb.Append("  AdminCenterUrl: ").Append(AdminCenterUrl).Append("\n");
            sb.Append("  SiteLanguages: ").Append(SiteLanguages).Append("\n");
            sb.Append("  RootSiteAndManagedPaths: ").Append(RootSiteAndManagedPaths).Append("\n");
            sb.Append("  SiteUrlSetting: ").Append(SiteUrlSetting).Append("\n");
            sb.Append("  MultiGeoSetting: ").Append(MultiGeoSetting).Append("\n");
            sb.Append("  SiteTitleSetting: ").Append(SiteTitleSetting).Append("\n");
            sb.Append("  Policies: ").Append(Policies).Append("\n");
            sb.Append("  DeploymentManagerPlanSettings: ").Append(DeploymentManagerPlanSettings).Append("\n");
            sb.Append("  PolicyIdsAndTemplates: ").Append(PolicyIdsAndTemplates).Append("\n");
            sb.Append("  TemplateIdsAndPermissions: ").Append(TemplateIdsAndPermissions).Append("\n");
            sb.Append("  PermissionSettings: ").Append(PermissionSettings).Append("\n");
            sb.Append("  LeasePeriodSettings: ").Append(LeasePeriodSettings).Append("\n");
            sb.Append("  TimeZones: ").Append(TimeZones).Append("\n");
            sb.Append("  SiteDesigns: ").Append(SiteDesigns).Append("\n");
            sb.Append("  SiteDesign: ").Append(SiteDesign).Append("\n");
            sb.Append("  DefaultTeamSiteDesignId: ").Append(DefaultTeamSiteDesignId).Append("\n");
            sb.Append("  SiteDesignAssignBy: ").Append(SiteDesignAssignBy).Append("\n");
            sb.Append("  YammerGroupSettings: ").Append(YammerGroupSettings).Append("\n");
            sb.Append("  Classifications: ").Append(Classifications).Append("\n");
            sb.Append("  Sensitivities: ").Append(Sensitivities).Append("\n");
            sb.Append("  HubSiteSettings: ").Append(HubSiteSettings).Append("\n");
            sb.Append("  EnabledCustomTemplate: ").Append(EnabledCustomTemplate).Append("\n");
            sb.Append("  CustomSiteTemplateListURL: ").Append(CustomSiteTemplateListURL).Append("\n");
            sb.Append("  DefaultPrimaryAdmin: ").Append(DefaultPrimaryAdmin).Append("\n");
            sb.Append("  DefaultAdditionalAdmins: ").Append(DefaultAdditionalAdmins).Append("\n");
            sb.Append("  DefaultPrimaryAdminReal: ").Append(DefaultPrimaryAdminReal).Append("\n");
            sb.Append("  DefaultAdditionalAdminsReal: ").Append(DefaultAdditionalAdminsReal).Append("\n");
            sb.Append("  DefaultPrimaryContact: ").Append(DefaultPrimaryContact).Append("\n");
            sb.Append("  DefaultSecondaryContact: ").Append(DefaultSecondaryContact).Append("\n");
            sb.Append("  DefaultSiteLanguage: ").Append(DefaultSiteLanguage).Append("\n");
            sb.Append("  DefaultRootSite: ").Append(DefaultRootSite).Append("\n");
            sb.Append("  DefaultManagedPath: ").Append(DefaultManagedPath).Append("\n");
            sb.Append("  DefaultPolicy: ").Append(DefaultPolicy).Append("\n");
            sb.Append("  DefaultTemplate: ").Append(DefaultTemplate).Append("\n");
            sb.Append("  DefaultTimeZone: ").Append(DefaultTimeZone).Append("\n");
            sb.Append("  DefaultClassification: ").Append(DefaultClassification).Append("\n");
            sb.Append("  DefaultSensitivity: ").Append(DefaultSensitivity).Append("\n");
            sb.Append("  DefaultDesignType: ").Append(DefaultDesignType).Append("\n");
            sb.Append("  SiteLanguageAssignBy: ").Append(SiteLanguageAssignBy).Append("\n");
            sb.Append("  TemplateAssignBy: ").Append(TemplateAssignBy).Append("\n");
            sb.Append("  PolicyAssignBy: ").Append(PolicyAssignBy).Append("\n");
            sb.Append("  PermissionAssignBy: ").Append(PermissionAssignBy).Append("\n");
            sb.Append("  RootSiteAndManagedPathAssignBy: ").Append(RootSiteAndManagedPathAssignBy).Append("\n");
            sb.Append("  TimeZoneAssignBy: ").Append(TimeZoneAssignBy).Append("\n");
            sb.Append("  PrimaryAdminAssignBy: ").Append(PrimaryAdminAssignBy).Append("\n");
            sb.Append("  AdditionalAdminAssignBy: ").Append(AdditionalAdminAssignBy).Append("\n");
            sb.Append("  PrimaryContactAssignBy: ").Append(PrimaryContactAssignBy).Append("\n");
            sb.Append("  SecondaryContactAssignBy: ").Append(SecondaryContactAssignBy).Append("\n");
            sb.Append("  DesignTypeAssignBy: ").Append(DesignTypeAssignBy).Append("\n");
            sb.Append("  ClassificationAssignBy: ").Append(ClassificationAssignBy).Append("\n");
            sb.Append("  SensitivityAssignBy: ").Append(SensitivityAssignBy).Append("\n");
            sb.Append("  HubSiteAssignBy: ").Append(HubSiteAssignBy).Append("\n");
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
            return this.Equals(input as CreateSiteService);
        }

        /// <summary>
        /// Returns true if CreateSiteService instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSiteService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSiteService input)
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
                    this.AdminCenterUrl == input.AdminCenterUrl ||
                    (this.AdminCenterUrl != null &&
                    this.AdminCenterUrl.Equals(input.AdminCenterUrl))
                ) && 
                (
                    this.SiteLanguages == input.SiteLanguages ||
                    this.SiteLanguages != null &&
                    input.SiteLanguages != null &&
                    this.SiteLanguages.SequenceEqual(input.SiteLanguages)
                ) && 
                (
                    this.RootSiteAndManagedPaths == input.RootSiteAndManagedPaths ||
                    this.RootSiteAndManagedPaths != null &&
                    input.RootSiteAndManagedPaths != null &&
                    this.RootSiteAndManagedPaths.SequenceEqual(input.RootSiteAndManagedPaths)
                ) && 
                (
                    this.SiteUrlSetting == input.SiteUrlSetting ||
                    (this.SiteUrlSetting != null &&
                    this.SiteUrlSetting.Equals(input.SiteUrlSetting))
                ) && 
                (
                    this.MultiGeoSetting == input.MultiGeoSetting ||
                    (this.MultiGeoSetting != null &&
                    this.MultiGeoSetting.Equals(input.MultiGeoSetting))
                ) && 
                (
                    this.SiteTitleSetting == input.SiteTitleSetting ||
                    (this.SiteTitleSetting != null &&
                    this.SiteTitleSetting.Equals(input.SiteTitleSetting))
                ) && 
                (
                    this.Policies == input.Policies ||
                    this.Policies != null &&
                    input.Policies != null &&
                    this.Policies.SequenceEqual(input.Policies)
                ) && 
                (
                    this.DeploymentManagerPlanSettings == input.DeploymentManagerPlanSettings ||
                    (this.DeploymentManagerPlanSettings != null &&
                    this.DeploymentManagerPlanSettings.Equals(input.DeploymentManagerPlanSettings))
                ) && 
                (
                    this.PolicyIdsAndTemplates == input.PolicyIdsAndTemplates ||
                    this.PolicyIdsAndTemplates != null &&
                    input.PolicyIdsAndTemplates != null &&
                    this.PolicyIdsAndTemplates.SequenceEqual(input.PolicyIdsAndTemplates)
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
                    this.LeasePeriodSettings == input.LeasePeriodSettings ||
                    (this.LeasePeriodSettings != null &&
                    this.LeasePeriodSettings.Equals(input.LeasePeriodSettings))
                ) && 
                (
                    this.TimeZones == input.TimeZones ||
                    this.TimeZones != null &&
                    input.TimeZones != null &&
                    this.TimeZones.SequenceEqual(input.TimeZones)
                ) && 
                (
                    this.SiteDesigns == input.SiteDesigns ||
                    this.SiteDesigns != null &&
                    input.SiteDesigns != null &&
                    this.SiteDesigns.SequenceEqual(input.SiteDesigns)
                ) && 
                (
                    this.SiteDesign == input.SiteDesign ||
                    (this.SiteDesign != null &&
                    this.SiteDesign.Equals(input.SiteDesign))
                ) && 
                (
                    this.DefaultTeamSiteDesignId == input.DefaultTeamSiteDesignId ||
                    (this.DefaultTeamSiteDesignId != null &&
                    this.DefaultTeamSiteDesignId.Equals(input.DefaultTeamSiteDesignId))
                ) && 
                (
                    this.SiteDesignAssignBy == input.SiteDesignAssignBy ||
                    this.SiteDesignAssignBy.Equals(input.SiteDesignAssignBy)
                ) && 
                (
                    this.YammerGroupSettings == input.YammerGroupSettings ||
                    (this.YammerGroupSettings != null &&
                    this.YammerGroupSettings.Equals(input.YammerGroupSettings))
                ) && 
                (
                    this.Classifications == input.Classifications ||
                    this.Classifications != null &&
                    input.Classifications != null &&
                    this.Classifications.SequenceEqual(input.Classifications)
                ) && 
                (
                    this.Sensitivities == input.Sensitivities ||
                    this.Sensitivities != null &&
                    input.Sensitivities != null &&
                    this.Sensitivities.SequenceEqual(input.Sensitivities)
                ) && 
                (
                    this.HubSiteSettings == input.HubSiteSettings ||
                    (this.HubSiteSettings != null &&
                    this.HubSiteSettings.Equals(input.HubSiteSettings))
                ) && 
                (
                    this.EnabledCustomTemplate == input.EnabledCustomTemplate ||
                    this.EnabledCustomTemplate.Equals(input.EnabledCustomTemplate)
                ) && 
                (
                    this.CustomSiteTemplateListURL == input.CustomSiteTemplateListURL ||
                    (this.CustomSiteTemplateListURL != null &&
                    this.CustomSiteTemplateListURL.Equals(input.CustomSiteTemplateListURL))
                ) && 
                (
                    this.DefaultPrimaryAdmin == input.DefaultPrimaryAdmin ||
                    (this.DefaultPrimaryAdmin != null &&
                    this.DefaultPrimaryAdmin.Equals(input.DefaultPrimaryAdmin))
                ) && 
                (
                    this.DefaultAdditionalAdmins == input.DefaultAdditionalAdmins ||
                    this.DefaultAdditionalAdmins != null &&
                    input.DefaultAdditionalAdmins != null &&
                    this.DefaultAdditionalAdmins.SequenceEqual(input.DefaultAdditionalAdmins)
                ) && 
                (
                    this.DefaultPrimaryAdminReal == input.DefaultPrimaryAdminReal ||
                    (this.DefaultPrimaryAdminReal != null &&
                    this.DefaultPrimaryAdminReal.Equals(input.DefaultPrimaryAdminReal))
                ) && 
                (
                    this.DefaultAdditionalAdminsReal == input.DefaultAdditionalAdminsReal ||
                    this.DefaultAdditionalAdminsReal != null &&
                    input.DefaultAdditionalAdminsReal != null &&
                    this.DefaultAdditionalAdminsReal.SequenceEqual(input.DefaultAdditionalAdminsReal)
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
                    this.DefaultSiteLanguage == input.DefaultSiteLanguage ||
                    this.DefaultSiteLanguage.Equals(input.DefaultSiteLanguage)
                ) && 
                (
                    this.DefaultRootSite == input.DefaultRootSite ||
                    (this.DefaultRootSite != null &&
                    this.DefaultRootSite.Equals(input.DefaultRootSite))
                ) && 
                (
                    this.DefaultManagedPath == input.DefaultManagedPath ||
                    (this.DefaultManagedPath != null &&
                    this.DefaultManagedPath.Equals(input.DefaultManagedPath))
                ) && 
                (
                    this.DefaultPolicy == input.DefaultPolicy ||
                    (this.DefaultPolicy != null &&
                    this.DefaultPolicy.Equals(input.DefaultPolicy))
                ) && 
                (
                    this.DefaultTemplate == input.DefaultTemplate ||
                    (this.DefaultTemplate != null &&
                    this.DefaultTemplate.Equals(input.DefaultTemplate))
                ) && 
                (
                    this.DefaultTimeZone == input.DefaultTimeZone ||
                    this.DefaultTimeZone.Equals(input.DefaultTimeZone)
                ) && 
                (
                    this.DefaultClassification == input.DefaultClassification ||
                    (this.DefaultClassification != null &&
                    this.DefaultClassification.Equals(input.DefaultClassification))
                ) && 
                (
                    this.DefaultSensitivity == input.DefaultSensitivity ||
                    (this.DefaultSensitivity != null &&
                    this.DefaultSensitivity.Equals(input.DefaultSensitivity))
                ) && 
                (
                    this.DefaultDesignType == input.DefaultDesignType ||
                    (this.DefaultDesignType != null &&
                    this.DefaultDesignType.Equals(input.DefaultDesignType))
                ) && 
                (
                    this.SiteLanguageAssignBy == input.SiteLanguageAssignBy ||
                    this.SiteLanguageAssignBy.Equals(input.SiteLanguageAssignBy)
                ) && 
                (
                    this.TemplateAssignBy == input.TemplateAssignBy ||
                    this.TemplateAssignBy.Equals(input.TemplateAssignBy)
                ) && 
                (
                    this.PolicyAssignBy == input.PolicyAssignBy ||
                    this.PolicyAssignBy.Equals(input.PolicyAssignBy)
                ) && 
                (
                    this.PermissionAssignBy == input.PermissionAssignBy ||
                    this.PermissionAssignBy.Equals(input.PermissionAssignBy)
                ) && 
                (
                    this.RootSiteAndManagedPathAssignBy == input.RootSiteAndManagedPathAssignBy ||
                    this.RootSiteAndManagedPathAssignBy.Equals(input.RootSiteAndManagedPathAssignBy)
                ) && 
                (
                    this.TimeZoneAssignBy == input.TimeZoneAssignBy ||
                    this.TimeZoneAssignBy.Equals(input.TimeZoneAssignBy)
                ) && 
                (
                    this.PrimaryAdminAssignBy == input.PrimaryAdminAssignBy ||
                    this.PrimaryAdminAssignBy.Equals(input.PrimaryAdminAssignBy)
                ) && 
                (
                    this.AdditionalAdminAssignBy == input.AdditionalAdminAssignBy ||
                    this.AdditionalAdminAssignBy.Equals(input.AdditionalAdminAssignBy)
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
                    this.DesignTypeAssignBy == input.DesignTypeAssignBy ||
                    this.DesignTypeAssignBy.Equals(input.DesignTypeAssignBy)
                ) && 
                (
                    this.ClassificationAssignBy == input.ClassificationAssignBy ||
                    this.ClassificationAssignBy.Equals(input.ClassificationAssignBy)
                ) && 
                (
                    this.SensitivityAssignBy == input.SensitivityAssignBy ||
                    this.SensitivityAssignBy.Equals(input.SensitivityAssignBy)
                ) && 
                (
                    this.HubSiteAssignBy == input.HubSiteAssignBy ||
                    this.HubSiteAssignBy.Equals(input.HubSiteAssignBy)
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
                if (this.ScopeSettings != null)
                    hashCode = hashCode * 59 + this.ScopeSettings.GetHashCode();
                if (this.AdminCenterUrl != null)
                    hashCode = hashCode * 59 + this.AdminCenterUrl.GetHashCode();
                if (this.SiteLanguages != null)
                    hashCode = hashCode * 59 + this.SiteLanguages.GetHashCode();
                if (this.RootSiteAndManagedPaths != null)
                    hashCode = hashCode * 59 + this.RootSiteAndManagedPaths.GetHashCode();
                if (this.SiteUrlSetting != null)
                    hashCode = hashCode * 59 + this.SiteUrlSetting.GetHashCode();
                if (this.MultiGeoSetting != null)
                    hashCode = hashCode * 59 + this.MultiGeoSetting.GetHashCode();
                if (this.SiteTitleSetting != null)
                    hashCode = hashCode * 59 + this.SiteTitleSetting.GetHashCode();
                if (this.Policies != null)
                    hashCode = hashCode * 59 + this.Policies.GetHashCode();
                if (this.DeploymentManagerPlanSettings != null)
                    hashCode = hashCode * 59 + this.DeploymentManagerPlanSettings.GetHashCode();
                if (this.PolicyIdsAndTemplates != null)
                    hashCode = hashCode * 59 + this.PolicyIdsAndTemplates.GetHashCode();
                if (this.TemplateIdsAndPermissions != null)
                    hashCode = hashCode * 59 + this.TemplateIdsAndPermissions.GetHashCode();
                if (this.PermissionSettings != null)
                    hashCode = hashCode * 59 + this.PermissionSettings.GetHashCode();
                if (this.LeasePeriodSettings != null)
                    hashCode = hashCode * 59 + this.LeasePeriodSettings.GetHashCode();
                if (this.TimeZones != null)
                    hashCode = hashCode * 59 + this.TimeZones.GetHashCode();
                if (this.SiteDesigns != null)
                    hashCode = hashCode * 59 + this.SiteDesigns.GetHashCode();
                if (this.SiteDesign != null)
                    hashCode = hashCode * 59 + this.SiteDesign.GetHashCode();
                if (this.DefaultTeamSiteDesignId != null)
                    hashCode = hashCode * 59 + this.DefaultTeamSiteDesignId.GetHashCode();
                hashCode = hashCode * 59 + this.SiteDesignAssignBy.GetHashCode();
                if (this.YammerGroupSettings != null)
                    hashCode = hashCode * 59 + this.YammerGroupSettings.GetHashCode();
                if (this.Classifications != null)
                    hashCode = hashCode * 59 + this.Classifications.GetHashCode();
                if (this.Sensitivities != null)
                    hashCode = hashCode * 59 + this.Sensitivities.GetHashCode();
                if (this.HubSiteSettings != null)
                    hashCode = hashCode * 59 + this.HubSiteSettings.GetHashCode();
                hashCode = hashCode * 59 + this.EnabledCustomTemplate.GetHashCode();
                if (this.CustomSiteTemplateListURL != null)
                    hashCode = hashCode * 59 + this.CustomSiteTemplateListURL.GetHashCode();
                if (this.DefaultPrimaryAdmin != null)
                    hashCode = hashCode * 59 + this.DefaultPrimaryAdmin.GetHashCode();
                if (this.DefaultAdditionalAdmins != null)
                    hashCode = hashCode * 59 + this.DefaultAdditionalAdmins.GetHashCode();
                if (this.DefaultPrimaryAdminReal != null)
                    hashCode = hashCode * 59 + this.DefaultPrimaryAdminReal.GetHashCode();
                if (this.DefaultAdditionalAdminsReal != null)
                    hashCode = hashCode * 59 + this.DefaultAdditionalAdminsReal.GetHashCode();
                if (this.DefaultPrimaryContact != null)
                    hashCode = hashCode * 59 + this.DefaultPrimaryContact.GetHashCode();
                if (this.DefaultSecondaryContact != null)
                    hashCode = hashCode * 59 + this.DefaultSecondaryContact.GetHashCode();
                hashCode = hashCode * 59 + this.DefaultSiteLanguage.GetHashCode();
                if (this.DefaultRootSite != null)
                    hashCode = hashCode * 59 + this.DefaultRootSite.GetHashCode();
                if (this.DefaultManagedPath != null)
                    hashCode = hashCode * 59 + this.DefaultManagedPath.GetHashCode();
                if (this.DefaultPolicy != null)
                    hashCode = hashCode * 59 + this.DefaultPolicy.GetHashCode();
                if (this.DefaultTemplate != null)
                    hashCode = hashCode * 59 + this.DefaultTemplate.GetHashCode();
                hashCode = hashCode * 59 + this.DefaultTimeZone.GetHashCode();
                if (this.DefaultClassification != null)
                    hashCode = hashCode * 59 + this.DefaultClassification.GetHashCode();
                if (this.DefaultSensitivity != null)
                    hashCode = hashCode * 59 + this.DefaultSensitivity.GetHashCode();
                if (this.DefaultDesignType != null)
                    hashCode = hashCode * 59 + this.DefaultDesignType.GetHashCode();
                hashCode = hashCode * 59 + this.SiteLanguageAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.TemplateAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.PolicyAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.PermissionAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.RootSiteAndManagedPathAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.TimeZoneAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.PrimaryAdminAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.AdditionalAdminAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.PrimaryContactAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.SecondaryContactAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.DesignTypeAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.ClassificationAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.SensitivityAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.HubSiteAssignBy.GetHashCode();
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
