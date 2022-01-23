

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
    /// CreateGroupService
    /// </summary>
    [DataContract(Name = "CreateGroupService")]
    public partial class CreateGroupService : IEquatable<CreateGroupService>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets GroupType
        /// </summary>
        [DataMember(Name = "groupType", EmitDefaultValue = false)]
        public CreateGroupType? GroupType { get; set; }
        /// <summary>
        /// Gets or Sets AddGroupMemberType
        /// </summary>
        [DataMember(Name = "addGroupMemberType", EmitDefaultValue = false)]
        public AddGroupMemberType? AddGroupMemberType { get; set; }
        /// <summary>
        /// Gets or Sets MemberAssignBy
        /// </summary>
        [DataMember(Name = "memberAssignBy", EmitDefaultValue = false)]
        public AssignBy? MemberAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets OwnerAssignBy
        /// </summary>
        [DataMember(Name = "ownerAssignBy", EmitDefaultValue = false)]
        public AssignBy? OwnerAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets PrivacyAssignBy
        /// </summary>
        [DataMember(Name = "privacyAssignBy", EmitDefaultValue = false)]
        public AssignBy? PrivacyAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets SubscribeAssignBy
        /// </summary>
        [DataMember(Name = "subscribeAssignBy", EmitDefaultValue = false)]
        public AssignBy? SubscribeAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets OutsideSenderAssignBy
        /// </summary>
        [DataMember(Name = "outsideSenderAssignBy", EmitDefaultValue = false)]
        public AssignBy? OutsideSenderAssignBy { get; set; }
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
        /// Gets or Sets LanguageAssignBy
        /// </summary>
        [DataMember(Name = "languageAssignBy", EmitDefaultValue = false)]
        public AssignBy? LanguageAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets SecondaryContactAssignBy
        /// </summary>
        [DataMember(Name = "secondaryContactAssignBy", EmitDefaultValue = false)]
        public AssignBy? SecondaryContactAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets PrimaryContactAssignBy
        /// </summary>
        [DataMember(Name = "primaryContactAssignBy", EmitDefaultValue = false)]
        public AssignBy? PrimaryContactAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets HideGroupMembershipAssignBy
        /// </summary>
        [DataMember(Name = "hideGroupMembershipAssignBy", EmitDefaultValue = false)]
        public AssignBy? HideGroupMembershipAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets PolicyAssignBy
        /// </summary>
        [DataMember(Name = "policyAssignBy", EmitDefaultValue = false)]
        public AssignBy? PolicyAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets SiteDesignAssignBy
        /// </summary>
        [DataMember(Name = "siteDesignAssignBy", EmitDefaultValue = false)]
        public AssignBy? SiteDesignAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets HubSiteAssignBy
        /// </summary>
        [DataMember(Name = "hubSiteAssignBy", EmitDefaultValue = false)]
        public AssignBy? HubSiteAssignBy { get; set; }
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
        /// Initializes a new instance of the <see cref="CreateGroupService" /> class.
        /// </summary>
        /// <param name="groupType">groupType.</param>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="networkId">networkId.</param>
        /// <param name="enableTeams">enableTeams (default to false).</param>
        /// <param name="isPrivate">isPrivate (default to false).</param>
        /// <param name="enableSubscribe">enableSubscribe (default to false).</param>
        /// <param name="enableApplySiteDesign">enableApplySiteDesign (default to false).</param>
        /// <param name="enableOutsideSender">enableOutsideSender (default to false).</param>
        /// <param name="enableHideGroupMembership">enableHideGroupMembership (default to false).</param>
        /// <param name="enableClassification">enableClassification (default to false).</param>
        /// <param name="preventDuplicateName">preventDuplicateName (default to false).</param>
        /// <param name="enableSensitivity">enableSensitivity (default to false).</param>
        /// <param name="allSensitivities">allSensitivities.</param>
        /// <param name="allowConfigureLeasePeriod">allowConfigureLeasePeriod (default to false).</param>
        /// <param name="showNotebookLink">showNotebookLink (default to false).</param>
        /// <param name="showConversationsLink">showConversationsLink (default to false).</param>
        /// <param name="showFilesLink">showFilesLink (default to false).</param>
        /// <param name="showTeamSiteLink">showTeamSiteLink (default to false).</param>
        /// <param name="showPlannerLink">showPlannerLink (default to false).</param>
        /// <param name="showYammerGroupLink">showYammerGroupLink (default to false).</param>
        /// <param name="classifications">classifications.</param>
        /// <param name="sensitivities">sensitivities.</param>
        /// <param name="siteDesigns">siteDesigns.</param>
        /// <param name="addGroupMemberType">addGroupMemberType.</param>
        /// <param name="selectedPolicies">selectedPolicies.</param>
        /// <param name="selectedLanguages">selectedLanguages.</param>
        /// <param name="teamsSettings">teamsSettings.</param>
        /// <param name="groupNameConstructureSettings">groupNameConstructureSettings.</param>
        /// <param name="groupIdConstructureSettings">groupIdConstructureSettings.</param>
        /// <param name="enableInstallApp">enableInstallApp (default to false).</param>
        /// <param name="enableInstallPanel">enableInstallPanel (default to false).</param>
        /// <param name="templateSettings">templateSettings.</param>
        /// <param name="defaultPrimaryContact">ApiUser model.</param>
        /// <param name="defaultSecondaryContact">ApiUser model.</param>
        /// <param name="defaultOwners">defaultOwners.</param>
        /// <param name="defaultMembers">defaultMembers.</param>
        /// <param name="disableAddRemoveDynamicMembershipRules">disableAddRemoveDynamicMembershipRules (default to false).</param>
        /// <param name="dynamicMembershipRules">dynamicMembershipRules.</param>
        /// <param name="defaultPolicy">defaultPolicy.</param>
        /// <param name="defaultClassification">defaultClassification.</param>
        /// <param name="defaultSensitivity">defaultSensitivity.</param>
        /// <param name="defaultLanguage">defaultLanguage.</param>
        /// <param name="defaultSiteDesign">defaultSiteDesign.</param>
        /// <param name="defaultOwnersReal">defaultOwnersReal.</param>
        /// <param name="defaultMembersReal">defaultMembersReal.</param>
        /// <param name="defaultPrimaryContactReal">ApiUser model.</param>
        /// <param name="defaultSecondaryContactReal">ApiUser model.</param>
        /// <param name="memberAssignBy">memberAssignBy.</param>
        /// <param name="ownerAssignBy">ownerAssignBy.</param>
        /// <param name="privacyAssignBy">privacyAssignBy.</param>
        /// <param name="subscribeAssignBy">subscribeAssignBy.</param>
        /// <param name="outsideSenderAssignBy">outsideSenderAssignBy.</param>
        /// <param name="classificationAssignBy">classificationAssignBy.</param>
        /// <param name="sensitivityAssignBy">sensitivityAssignBy.</param>
        /// <param name="languageAssignBy">languageAssignBy.</param>
        /// <param name="secondaryContactAssignBy">secondaryContactAssignBy.</param>
        /// <param name="primaryContactAssignBy">primaryContactAssignBy.</param>
        /// <param name="enableDynamicMembership">enableDynamicMembership (default to false).</param>
        /// <param name="hideGroupMembershipAssignBy">hideGroupMembershipAssignBy.</param>
        /// <param name="policyAssignBy">policyAssignBy.</param>
        /// <param name="siteDesignAssignBy">siteDesignAssignBy.</param>
        /// <param name="hubSiteAssignBy">hubSiteAssignBy.</param>
        /// <param name="multiGeoSetting">multiGeoSetting.</param>
        /// <param name="hubSiteSettings">Hub site settings model.</param>
        /// <param name="hasImpernastionUsers">hasImpernastionUsers (default to false).</param>
        /// <param name="peoplePickerFilterProfileId">peoplePickerFilterProfileId.</param>
        /// <param name="requestTemplate">Create group request model.</param>
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
        public CreateGroupService(CreateGroupType? groupType = default(CreateGroupType?), Guid tenantId = default(Guid), string networkId = default(string), bool enableTeams = false, bool isPrivate = false, bool enableSubscribe = false, bool enableApplySiteDesign = false, bool enableOutsideSender = false, bool enableHideGroupMembership = false, bool enableClassification = false, bool preventDuplicateName = false, bool enableSensitivity = false, List<StringModel> allSensitivities = default(List<StringModel>), bool allowConfigureLeasePeriod = false, bool showNotebookLink = false, bool showConversationsLink = false, bool showFilesLink = false, bool showTeamSiteLink = false, bool showPlannerLink = false, bool showYammerGroupLink = false, List<string> classifications = default(List<string>), List<StringModel> sensitivities = default(List<StringModel>), List<GuidModel> siteDesigns = default(List<GuidModel>), AddGroupMemberType? addGroupMemberType = default(AddGroupMemberType?), List<BriefGroupPolicy> selectedPolicies = default(List<BriefGroupPolicy>), List<StringModel> selectedLanguages = default(List<StringModel>), ServiceTeamsSettings teamsSettings = default(ServiceTeamsSettings), GroupNameConstructureSettings groupNameConstructureSettings = default(GroupNameConstructureSettings), GroupIdConstructureSettings groupIdConstructureSettings = default(GroupIdConstructureSettings), bool enableInstallApp = false, bool enableInstallPanel = false, TeamsTemplateServiceSettings templateSettings = default(TeamsTemplateServiceSettings), ApiUser defaultPrimaryContact = default(ApiUser), ApiUser defaultSecondaryContact = default(ApiUser), List<ApiUser> defaultOwners = default(List<ApiUser>), List<ApiUser> defaultMembers = default(List<ApiUser>), bool disableAddRemoveDynamicMembershipRules = false, List<DynamicGroupRuleInfo> dynamicMembershipRules = default(List<DynamicGroupRuleInfo>), Guid defaultPolicy = default(Guid), string defaultClassification = default(string), string defaultSensitivity = default(string), string defaultLanguage = default(string), Guid? defaultSiteDesign = default(Guid?), List<ApiUser> defaultOwnersReal = default(List<ApiUser>), List<ApiUser> defaultMembersReal = default(List<ApiUser>), ApiUser defaultPrimaryContactReal = default(ApiUser), ApiUser defaultSecondaryContactReal = default(ApiUser), AssignBy? memberAssignBy = default(AssignBy?), AssignBy? ownerAssignBy = default(AssignBy?), AssignBy? privacyAssignBy = default(AssignBy?), AssignBy? subscribeAssignBy = default(AssignBy?), AssignBy? outsideSenderAssignBy = default(AssignBy?), AssignBy? classificationAssignBy = default(AssignBy?), AssignBy? sensitivityAssignBy = default(AssignBy?), AssignBy? languageAssignBy = default(AssignBy?), AssignBy? secondaryContactAssignBy = default(AssignBy?), AssignBy? primaryContactAssignBy = default(AssignBy?), bool enableDynamicMembership = false, AssignBy? hideGroupMembershipAssignBy = default(AssignBy?), AssignBy? policyAssignBy = default(AssignBy?), AssignBy? siteDesignAssignBy = default(AssignBy?), AssignBy? hubSiteAssignBy = default(AssignBy?), MultiGeoSetting multiGeoSetting = default(MultiGeoSetting), HubSiteSettings hubSiteSettings = default(HubSiteSettings), bool hasImpernastionUsers = false, Guid? peoplePickerFilterProfileId = default(Guid?), CreateGroupRequest requestTemplate = default(CreateGroupRequest), List<CustomMetadata> metadatas = default(List<CustomMetadata>), bool hideRequestSummary = false, Guid id = default(Guid), string name = default(string), string description = default(string), ServiceType? type = default(ServiceType?), ApiUser serviceContact = default(ApiUser), ApiUser serviceAdminContact = default(ApiUser), bool approversContainManagerRole = false, CommonStatus? status = default(CommonStatus?), bool showServiceInCatalog = false, CustomActionSettings customActions = default(CustomActionSettings), Guid approvalProcessId = default(Guid), int languageId = 0, string categoryId = default(string))
        {
            this.GroupType = groupType;
            this.TenantId = tenantId;
            this.NetworkId = networkId;
            this.EnableTeams = enableTeams;
            this.IsPrivate = isPrivate;
            this.EnableSubscribe = enableSubscribe;
            this.EnableApplySiteDesign = enableApplySiteDesign;
            this.EnableOutsideSender = enableOutsideSender;
            this.EnableHideGroupMembership = enableHideGroupMembership;
            this.EnableClassification = enableClassification;
            this.PreventDuplicateName = preventDuplicateName;
            this.EnableSensitivity = enableSensitivity;
            this.AllSensitivities = allSensitivities;
            this.AllowConfigureLeasePeriod = allowConfigureLeasePeriod;
            this.ShowNotebookLink = showNotebookLink;
            this.ShowConversationsLink = showConversationsLink;
            this.ShowFilesLink = showFilesLink;
            this.ShowTeamSiteLink = showTeamSiteLink;
            this.ShowPlannerLink = showPlannerLink;
            this.ShowYammerGroupLink = showYammerGroupLink;
            this.Classifications = classifications;
            this.Sensitivities = sensitivities;
            this.SiteDesigns = siteDesigns;
            this.AddGroupMemberType = addGroupMemberType;
            this.SelectedPolicies = selectedPolicies;
            this.SelectedLanguages = selectedLanguages;
            this.TeamsSettings = teamsSettings;
            this.GroupNameConstructureSettings = groupNameConstructureSettings;
            this.GroupIdConstructureSettings = groupIdConstructureSettings;
            this.EnableInstallApp = enableInstallApp;
            this.EnableInstallPanel = enableInstallPanel;
            this.TemplateSettings = templateSettings;
            this.DefaultPrimaryContact = defaultPrimaryContact;
            this.DefaultSecondaryContact = defaultSecondaryContact;
            this.DefaultOwners = defaultOwners;
            this.DefaultMembers = defaultMembers;
            this.DisableAddRemoveDynamicMembershipRules = disableAddRemoveDynamicMembershipRules;
            this.DynamicMembershipRules = dynamicMembershipRules;
            this.DefaultPolicy = defaultPolicy;
            this.DefaultClassification = defaultClassification;
            this.DefaultSensitivity = defaultSensitivity;
            this.DefaultLanguage = defaultLanguage;
            this.DefaultSiteDesign = defaultSiteDesign;
            this.DefaultOwnersReal = defaultOwnersReal;
            this.DefaultMembersReal = defaultMembersReal;
            this.DefaultPrimaryContactReal = defaultPrimaryContactReal;
            this.DefaultSecondaryContactReal = defaultSecondaryContactReal;
            this.MemberAssignBy = memberAssignBy;
            this.OwnerAssignBy = ownerAssignBy;
            this.PrivacyAssignBy = privacyAssignBy;
            this.SubscribeAssignBy = subscribeAssignBy;
            this.OutsideSenderAssignBy = outsideSenderAssignBy;
            this.ClassificationAssignBy = classificationAssignBy;
            this.SensitivityAssignBy = sensitivityAssignBy;
            this.LanguageAssignBy = languageAssignBy;
            this.SecondaryContactAssignBy = secondaryContactAssignBy;
            this.PrimaryContactAssignBy = primaryContactAssignBy;
            this.EnableDynamicMembership = enableDynamicMembership;
            this.HideGroupMembershipAssignBy = hideGroupMembershipAssignBy;
            this.PolicyAssignBy = policyAssignBy;
            this.SiteDesignAssignBy = siteDesignAssignBy;
            this.HubSiteAssignBy = hubSiteAssignBy;
            this.MultiGeoSetting = multiGeoSetting;
            this.HubSiteSettings = hubSiteSettings;
            this.HasImpernastionUsers = hasImpernastionUsers;
            this.PeoplePickerFilterProfileId = peoplePickerFilterProfileId;
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
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Gets or Sets NetworkId
        /// </summary>
        [DataMember(Name = "networkId", EmitDefaultValue = true)]
        public string NetworkId { get; set; }

        /// <summary>
        /// Gets or Sets EnableTeams
        /// </summary>
        [DataMember(Name = "enableTeams", EmitDefaultValue = false)]
        public bool EnableTeams { get; set; }

        /// <summary>
        /// Gets or Sets IsPrivate
        /// </summary>
        [DataMember(Name = "isPrivate", EmitDefaultValue = false)]
        public bool IsPrivate { get; set; }

        /// <summary>
        /// Gets or Sets EnableSubscribe
        /// </summary>
        [DataMember(Name = "enableSubscribe", EmitDefaultValue = false)]
        public bool EnableSubscribe { get; set; }

        /// <summary>
        /// Gets or Sets EnableApplySiteDesign
        /// </summary>
        [DataMember(Name = "enableApplySiteDesign", EmitDefaultValue = false)]
        public bool EnableApplySiteDesign { get; set; }

        /// <summary>
        /// Gets or Sets EnableOutsideSender
        /// </summary>
        [DataMember(Name = "enableOutsideSender", EmitDefaultValue = false)]
        public bool EnableOutsideSender { get; set; }

        /// <summary>
        /// Gets or Sets EnableHideGroupMembership
        /// </summary>
        [DataMember(Name = "enableHideGroupMembership", EmitDefaultValue = false)]
        public bool EnableHideGroupMembership { get; set; }

        /// <summary>
        /// Gets or Sets EnableClassification
        /// </summary>
        [DataMember(Name = "enableClassification", EmitDefaultValue = false)]
        public bool EnableClassification { get; set; }

        /// <summary>
        /// Gets or Sets PreventDuplicateName
        /// </summary>
        [DataMember(Name = "preventDuplicateName", EmitDefaultValue = false)]
        public bool PreventDuplicateName { get; set; }

        /// <summary>
        /// Gets or Sets EnableSensitivity
        /// </summary>
        [DataMember(Name = "enableSensitivity", EmitDefaultValue = false)]
        public bool EnableSensitivity { get; set; }

        /// <summary>
        /// Gets or Sets AllSensitivities
        /// </summary>
        [DataMember(Name = "allSensitivities", EmitDefaultValue = true)]
        public List<StringModel> AllSensitivities { get; set; }

        /// <summary>
        /// Gets or Sets AllowConfigureLeasePeriod
        /// </summary>
        [DataMember(Name = "allowConfigureLeasePeriod", EmitDefaultValue = false)]
        public bool AllowConfigureLeasePeriod { get; set; }

        /// <summary>
        /// Gets or Sets ShowNotebookLink
        /// </summary>
        [DataMember(Name = "showNotebookLink", EmitDefaultValue = false)]
        public bool ShowNotebookLink { get; set; }

        /// <summary>
        /// Gets or Sets ShowConversationsLink
        /// </summary>
        [DataMember(Name = "showConversationsLink", EmitDefaultValue = false)]
        public bool ShowConversationsLink { get; set; }

        /// <summary>
        /// Gets or Sets ShowFilesLink
        /// </summary>
        [DataMember(Name = "showFilesLink", EmitDefaultValue = false)]
        public bool ShowFilesLink { get; set; }

        /// <summary>
        /// Gets or Sets ShowTeamSiteLink
        /// </summary>
        [DataMember(Name = "showTeamSiteLink", EmitDefaultValue = false)]
        public bool ShowTeamSiteLink { get; set; }

        /// <summary>
        /// Gets or Sets ShowPlannerLink
        /// </summary>
        [DataMember(Name = "showPlannerLink", EmitDefaultValue = false)]
        public bool ShowPlannerLink { get; set; }

        /// <summary>
        /// Gets or Sets ShowYammerGroupLink
        /// </summary>
        [DataMember(Name = "showYammerGroupLink", EmitDefaultValue = false)]
        public bool ShowYammerGroupLink { get; set; }

        /// <summary>
        /// Gets or Sets Classifications
        /// </summary>
        [DataMember(Name = "classifications", EmitDefaultValue = true)]
        public List<string> Classifications { get; set; }

        /// <summary>
        /// Gets or Sets Sensitivities
        /// </summary>
        [DataMember(Name = "sensitivities", EmitDefaultValue = true)]
        public List<StringModel> Sensitivities { get; set; }

        /// <summary>
        /// Gets or Sets SiteDesigns
        /// </summary>
        [DataMember(Name = "siteDesigns", EmitDefaultValue = true)]
        public List<GuidModel> SiteDesigns { get; set; }

        /// <summary>
        /// Gets or Sets SelectedPolicies
        /// </summary>
        [DataMember(Name = "selectedPolicies", EmitDefaultValue = true)]
        public List<BriefGroupPolicy> SelectedPolicies { get; set; }

        /// <summary>
        /// Gets or Sets SelectedLanguages
        /// </summary>
        [DataMember(Name = "selectedLanguages", EmitDefaultValue = true)]
        public List<StringModel> SelectedLanguages { get; set; }

        /// <summary>
        /// Gets or Sets TeamsSettings
        /// </summary>
        [DataMember(Name = "teamsSettings", EmitDefaultValue = true)]
        public ServiceTeamsSettings TeamsSettings { get; set; }

        /// <summary>
        /// Gets or Sets GroupNameConstructureSettings
        /// </summary>
        [DataMember(Name = "groupNameConstructureSettings", EmitDefaultValue = true)]
        public GroupNameConstructureSettings GroupNameConstructureSettings { get; set; }

        /// <summary>
        /// Gets or Sets GroupIdConstructureSettings
        /// </summary>
        [DataMember(Name = "groupIdConstructureSettings", EmitDefaultValue = true)]
        public GroupIdConstructureSettings GroupIdConstructureSettings { get; set; }

        /// <summary>
        /// Gets or Sets EnableInstallApp
        /// </summary>
        [DataMember(Name = "enableInstallApp", EmitDefaultValue = false)]
        public bool EnableInstallApp { get; set; }

        /// <summary>
        /// Gets or Sets EnableInstallPanel
        /// </summary>
        [DataMember(Name = "enableInstallPanel", EmitDefaultValue = false)]
        public bool EnableInstallPanel { get; set; }

        /// <summary>
        /// Gets or Sets TemplateSettings
        /// </summary>
        [DataMember(Name = "templateSettings", EmitDefaultValue = true)]
        public TeamsTemplateServiceSettings TemplateSettings { get; set; }

        /// <summary>
        /// ApiUser model
        /// </summary>
        /// <value>ApiUser model</value>
        [DataMember(Name = "defaultPrimaryContact", EmitDefaultValue = true)]
        public ApiUser DefaultPrimaryContact { get; set; }

        /// <summary>
        /// ApiUser model
        /// </summary>
        /// <value>ApiUser model</value>
        [DataMember(Name = "defaultSecondaryContact", EmitDefaultValue = true)]
        public ApiUser DefaultSecondaryContact { get; set; }

        /// <summary>
        /// Gets or Sets DefaultOwners
        /// </summary>
        [DataMember(Name = "defaultOwners", EmitDefaultValue = true)]
        public List<ApiUser> DefaultOwners { get; set; }

        /// <summary>
        /// Gets or Sets DefaultMembers
        /// </summary>
        [DataMember(Name = "defaultMembers", EmitDefaultValue = true)]
        public List<ApiUser> DefaultMembers { get; set; }

        /// <summary>
        /// Gets or Sets DisableAddRemoveDynamicMembershipRules
        /// </summary>
        [DataMember(Name = "disableAddRemoveDynamicMembershipRules", EmitDefaultValue = false)]
        public bool DisableAddRemoveDynamicMembershipRules { get; set; }

        /// <summary>
        /// Gets or Sets DynamicMembershipRules
        /// </summary>
        [DataMember(Name = "dynamicMembershipRules", EmitDefaultValue = true)]
        public List<DynamicGroupRuleInfo> DynamicMembershipRules { get; set; }

        /// <summary>
        /// Gets or Sets DefaultPolicy
        /// </summary>
        [DataMember(Name = "defaultPolicy", EmitDefaultValue = false)]
        public Guid DefaultPolicy { get; set; }

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
        /// Gets or Sets DefaultLanguage
        /// </summary>
        [DataMember(Name = "defaultLanguage", EmitDefaultValue = true)]
        public string DefaultLanguage { get; set; }

        /// <summary>
        /// Gets or Sets DefaultSiteDesign
        /// </summary>
        [DataMember(Name = "defaultSiteDesign", EmitDefaultValue = true)]
        public Guid? DefaultSiteDesign { get; set; }

        /// <summary>
        /// Gets or Sets DefaultOwnersReal
        /// </summary>
        [DataMember(Name = "defaultOwnersReal", EmitDefaultValue = true)]
        public List<ApiUser> DefaultOwnersReal { get; set; }

        /// <summary>
        /// Gets or Sets DefaultMembersReal
        /// </summary>
        [DataMember(Name = "defaultMembersReal", EmitDefaultValue = true)]
        public List<ApiUser> DefaultMembersReal { get; set; }

        /// <summary>
        /// ApiUser model
        /// </summary>
        /// <value>ApiUser model</value>
        [DataMember(Name = "defaultPrimaryContactReal", EmitDefaultValue = true)]
        public ApiUser DefaultPrimaryContactReal { get; set; }

        /// <summary>
        /// ApiUser model
        /// </summary>
        /// <value>ApiUser model</value>
        [DataMember(Name = "defaultSecondaryContactReal", EmitDefaultValue = true)]
        public ApiUser DefaultSecondaryContactReal { get; set; }

        /// <summary>
        /// Gets or Sets EnableDynamicMembership
        /// </summary>
        [DataMember(Name = "enableDynamicMembership", EmitDefaultValue = false)]
        public bool EnableDynamicMembership { get; set; }

        /// <summary>
        /// Gets or Sets MultiGeoSetting
        /// </summary>
        [DataMember(Name = "multiGeoSetting", EmitDefaultValue = true)]
        public MultiGeoSetting MultiGeoSetting { get; set; }

        /// <summary>
        /// Gets or Sets IsShowHubSiteSection
        /// </summary>
        [DataMember(Name = "isShowHubSiteSection", EmitDefaultValue = false)]
        public bool IsShowHubSiteSection { get; private set; }

        /// <summary>
        /// Returns false as IsShowHubSiteSection should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsShowHubSiteSection()
        {
            return false;
        }

        /// <summary>
        /// Hub site settings model
        /// </summary>
        /// <value>Hub site settings model</value>
        [DataMember(Name = "hubSiteSettings", EmitDefaultValue = true)]
        public HubSiteSettings HubSiteSettings { get; set; }

        /// <summary>
        /// Gets or Sets HasImpernastionUsers
        /// </summary>
        [DataMember(Name = "hasImpernastionUsers", EmitDefaultValue = false)]
        public bool HasImpernastionUsers { get; set; }

        /// <summary>
        /// Gets or Sets PeoplePickerFilterProfileId
        /// </summary>
        [DataMember(Name = "peoplePickerFilterProfileId", EmitDefaultValue = true)]
        public Guid? PeoplePickerFilterProfileId { get; set; }

        /// <summary>
        /// Create group request model
        /// </summary>
        /// <value>Create group request model</value>
        [DataMember(Name = "requestTemplate", EmitDefaultValue = true)]
        public CreateGroupRequest RequestTemplate { get; set; }

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
            sb.Append("class CreateGroupService {\n");
            sb.Append("  GroupType: ").Append(GroupType).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  NetworkId: ").Append(NetworkId).Append("\n");
            sb.Append("  EnableTeams: ").Append(EnableTeams).Append("\n");
            sb.Append("  IsPrivate: ").Append(IsPrivate).Append("\n");
            sb.Append("  EnableSubscribe: ").Append(EnableSubscribe).Append("\n");
            sb.Append("  EnableApplySiteDesign: ").Append(EnableApplySiteDesign).Append("\n");
            sb.Append("  EnableOutsideSender: ").Append(EnableOutsideSender).Append("\n");
            sb.Append("  EnableHideGroupMembership: ").Append(EnableHideGroupMembership).Append("\n");
            sb.Append("  EnableClassification: ").Append(EnableClassification).Append("\n");
            sb.Append("  PreventDuplicateName: ").Append(PreventDuplicateName).Append("\n");
            sb.Append("  EnableSensitivity: ").Append(EnableSensitivity).Append("\n");
            sb.Append("  AllSensitivities: ").Append(AllSensitivities).Append("\n");
            sb.Append("  AllowConfigureLeasePeriod: ").Append(AllowConfigureLeasePeriod).Append("\n");
            sb.Append("  ShowNotebookLink: ").Append(ShowNotebookLink).Append("\n");
            sb.Append("  ShowConversationsLink: ").Append(ShowConversationsLink).Append("\n");
            sb.Append("  ShowFilesLink: ").Append(ShowFilesLink).Append("\n");
            sb.Append("  ShowTeamSiteLink: ").Append(ShowTeamSiteLink).Append("\n");
            sb.Append("  ShowPlannerLink: ").Append(ShowPlannerLink).Append("\n");
            sb.Append("  ShowYammerGroupLink: ").Append(ShowYammerGroupLink).Append("\n");
            sb.Append("  Classifications: ").Append(Classifications).Append("\n");
            sb.Append("  Sensitivities: ").Append(Sensitivities).Append("\n");
            sb.Append("  SiteDesigns: ").Append(SiteDesigns).Append("\n");
            sb.Append("  AddGroupMemberType: ").Append(AddGroupMemberType).Append("\n");
            sb.Append("  SelectedPolicies: ").Append(SelectedPolicies).Append("\n");
            sb.Append("  SelectedLanguages: ").Append(SelectedLanguages).Append("\n");
            sb.Append("  TeamsSettings: ").Append(TeamsSettings).Append("\n");
            sb.Append("  GroupNameConstructureSettings: ").Append(GroupNameConstructureSettings).Append("\n");
            sb.Append("  GroupIdConstructureSettings: ").Append(GroupIdConstructureSettings).Append("\n");
            sb.Append("  EnableInstallApp: ").Append(EnableInstallApp).Append("\n");
            sb.Append("  EnableInstallPanel: ").Append(EnableInstallPanel).Append("\n");
            sb.Append("  TemplateSettings: ").Append(TemplateSettings).Append("\n");
            sb.Append("  DefaultPrimaryContact: ").Append(DefaultPrimaryContact).Append("\n");
            sb.Append("  DefaultSecondaryContact: ").Append(DefaultSecondaryContact).Append("\n");
            sb.Append("  DefaultOwners: ").Append(DefaultOwners).Append("\n");
            sb.Append("  DefaultMembers: ").Append(DefaultMembers).Append("\n");
            sb.Append("  DisableAddRemoveDynamicMembershipRules: ").Append(DisableAddRemoveDynamicMembershipRules).Append("\n");
            sb.Append("  DynamicMembershipRules: ").Append(DynamicMembershipRules).Append("\n");
            sb.Append("  DefaultPolicy: ").Append(DefaultPolicy).Append("\n");
            sb.Append("  DefaultClassification: ").Append(DefaultClassification).Append("\n");
            sb.Append("  DefaultSensitivity: ").Append(DefaultSensitivity).Append("\n");
            sb.Append("  DefaultLanguage: ").Append(DefaultLanguage).Append("\n");
            sb.Append("  DefaultSiteDesign: ").Append(DefaultSiteDesign).Append("\n");
            sb.Append("  DefaultOwnersReal: ").Append(DefaultOwnersReal).Append("\n");
            sb.Append("  DefaultMembersReal: ").Append(DefaultMembersReal).Append("\n");
            sb.Append("  DefaultPrimaryContactReal: ").Append(DefaultPrimaryContactReal).Append("\n");
            sb.Append("  DefaultSecondaryContactReal: ").Append(DefaultSecondaryContactReal).Append("\n");
            sb.Append("  MemberAssignBy: ").Append(MemberAssignBy).Append("\n");
            sb.Append("  OwnerAssignBy: ").Append(OwnerAssignBy).Append("\n");
            sb.Append("  PrivacyAssignBy: ").Append(PrivacyAssignBy).Append("\n");
            sb.Append("  SubscribeAssignBy: ").Append(SubscribeAssignBy).Append("\n");
            sb.Append("  OutsideSenderAssignBy: ").Append(OutsideSenderAssignBy).Append("\n");
            sb.Append("  ClassificationAssignBy: ").Append(ClassificationAssignBy).Append("\n");
            sb.Append("  SensitivityAssignBy: ").Append(SensitivityAssignBy).Append("\n");
            sb.Append("  LanguageAssignBy: ").Append(LanguageAssignBy).Append("\n");
            sb.Append("  SecondaryContactAssignBy: ").Append(SecondaryContactAssignBy).Append("\n");
            sb.Append("  PrimaryContactAssignBy: ").Append(PrimaryContactAssignBy).Append("\n");
            sb.Append("  EnableDynamicMembership: ").Append(EnableDynamicMembership).Append("\n");
            sb.Append("  HideGroupMembershipAssignBy: ").Append(HideGroupMembershipAssignBy).Append("\n");
            sb.Append("  PolicyAssignBy: ").Append(PolicyAssignBy).Append("\n");
            sb.Append("  SiteDesignAssignBy: ").Append(SiteDesignAssignBy).Append("\n");
            sb.Append("  HubSiteAssignBy: ").Append(HubSiteAssignBy).Append("\n");
            sb.Append("  MultiGeoSetting: ").Append(MultiGeoSetting).Append("\n");
            sb.Append("  IsShowHubSiteSection: ").Append(IsShowHubSiteSection).Append("\n");
            sb.Append("  HubSiteSettings: ").Append(HubSiteSettings).Append("\n");
            sb.Append("  HasImpernastionUsers: ").Append(HasImpernastionUsers).Append("\n");
            sb.Append("  PeoplePickerFilterProfileId: ").Append(PeoplePickerFilterProfileId).Append("\n");
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
            return this.Equals(input as CreateGroupService);
        }

        /// <summary>
        /// Returns true if CreateGroupService instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateGroupService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateGroupService input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupType == input.GroupType ||
                    this.GroupType.Equals(input.GroupType)
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.NetworkId == input.NetworkId ||
                    (this.NetworkId != null &&
                    this.NetworkId.Equals(input.NetworkId))
                ) && 
                (
                    this.EnableTeams == input.EnableTeams ||
                    this.EnableTeams.Equals(input.EnableTeams)
                ) && 
                (
                    this.IsPrivate == input.IsPrivate ||
                    this.IsPrivate.Equals(input.IsPrivate)
                ) && 
                (
                    this.EnableSubscribe == input.EnableSubscribe ||
                    this.EnableSubscribe.Equals(input.EnableSubscribe)
                ) && 
                (
                    this.EnableApplySiteDesign == input.EnableApplySiteDesign ||
                    this.EnableApplySiteDesign.Equals(input.EnableApplySiteDesign)
                ) && 
                (
                    this.EnableOutsideSender == input.EnableOutsideSender ||
                    this.EnableOutsideSender.Equals(input.EnableOutsideSender)
                ) && 
                (
                    this.EnableHideGroupMembership == input.EnableHideGroupMembership ||
                    this.EnableHideGroupMembership.Equals(input.EnableHideGroupMembership)
                ) && 
                (
                    this.EnableClassification == input.EnableClassification ||
                    this.EnableClassification.Equals(input.EnableClassification)
                ) && 
                (
                    this.PreventDuplicateName == input.PreventDuplicateName ||
                    this.PreventDuplicateName.Equals(input.PreventDuplicateName)
                ) && 
                (
                    this.EnableSensitivity == input.EnableSensitivity ||
                    this.EnableSensitivity.Equals(input.EnableSensitivity)
                ) && 
                (
                    this.AllSensitivities == input.AllSensitivities ||
                    this.AllSensitivities != null &&
                    input.AllSensitivities != null &&
                    this.AllSensitivities.SequenceEqual(input.AllSensitivities)
                ) && 
                (
                    this.AllowConfigureLeasePeriod == input.AllowConfigureLeasePeriod ||
                    this.AllowConfigureLeasePeriod.Equals(input.AllowConfigureLeasePeriod)
                ) && 
                (
                    this.ShowNotebookLink == input.ShowNotebookLink ||
                    this.ShowNotebookLink.Equals(input.ShowNotebookLink)
                ) && 
                (
                    this.ShowConversationsLink == input.ShowConversationsLink ||
                    this.ShowConversationsLink.Equals(input.ShowConversationsLink)
                ) && 
                (
                    this.ShowFilesLink == input.ShowFilesLink ||
                    this.ShowFilesLink.Equals(input.ShowFilesLink)
                ) && 
                (
                    this.ShowTeamSiteLink == input.ShowTeamSiteLink ||
                    this.ShowTeamSiteLink.Equals(input.ShowTeamSiteLink)
                ) && 
                (
                    this.ShowPlannerLink == input.ShowPlannerLink ||
                    this.ShowPlannerLink.Equals(input.ShowPlannerLink)
                ) && 
                (
                    this.ShowYammerGroupLink == input.ShowYammerGroupLink ||
                    this.ShowYammerGroupLink.Equals(input.ShowYammerGroupLink)
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
                    this.SiteDesigns == input.SiteDesigns ||
                    this.SiteDesigns != null &&
                    input.SiteDesigns != null &&
                    this.SiteDesigns.SequenceEqual(input.SiteDesigns)
                ) && 
                (
                    this.AddGroupMemberType == input.AddGroupMemberType ||
                    this.AddGroupMemberType.Equals(input.AddGroupMemberType)
                ) && 
                (
                    this.SelectedPolicies == input.SelectedPolicies ||
                    this.SelectedPolicies != null &&
                    input.SelectedPolicies != null &&
                    this.SelectedPolicies.SequenceEqual(input.SelectedPolicies)
                ) && 
                (
                    this.SelectedLanguages == input.SelectedLanguages ||
                    this.SelectedLanguages != null &&
                    input.SelectedLanguages != null &&
                    this.SelectedLanguages.SequenceEqual(input.SelectedLanguages)
                ) && 
                (
                    this.TeamsSettings == input.TeamsSettings ||
                    (this.TeamsSettings != null &&
                    this.TeamsSettings.Equals(input.TeamsSettings))
                ) && 
                (
                    this.GroupNameConstructureSettings == input.GroupNameConstructureSettings ||
                    (this.GroupNameConstructureSettings != null &&
                    this.GroupNameConstructureSettings.Equals(input.GroupNameConstructureSettings))
                ) && 
                (
                    this.GroupIdConstructureSettings == input.GroupIdConstructureSettings ||
                    (this.GroupIdConstructureSettings != null &&
                    this.GroupIdConstructureSettings.Equals(input.GroupIdConstructureSettings))
                ) && 
                (
                    this.EnableInstallApp == input.EnableInstallApp ||
                    this.EnableInstallApp.Equals(input.EnableInstallApp)
                ) && 
                (
                    this.EnableInstallPanel == input.EnableInstallPanel ||
                    this.EnableInstallPanel.Equals(input.EnableInstallPanel)
                ) && 
                (
                    this.TemplateSettings == input.TemplateSettings ||
                    (this.TemplateSettings != null &&
                    this.TemplateSettings.Equals(input.TemplateSettings))
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
                    this.DefaultOwners == input.DefaultOwners ||
                    this.DefaultOwners != null &&
                    input.DefaultOwners != null &&
                    this.DefaultOwners.SequenceEqual(input.DefaultOwners)
                ) && 
                (
                    this.DefaultMembers == input.DefaultMembers ||
                    this.DefaultMembers != null &&
                    input.DefaultMembers != null &&
                    this.DefaultMembers.SequenceEqual(input.DefaultMembers)
                ) && 
                (
                    this.DisableAddRemoveDynamicMembershipRules == input.DisableAddRemoveDynamicMembershipRules ||
                    this.DisableAddRemoveDynamicMembershipRules.Equals(input.DisableAddRemoveDynamicMembershipRules)
                ) && 
                (
                    this.DynamicMembershipRules == input.DynamicMembershipRules ||
                    this.DynamicMembershipRules != null &&
                    input.DynamicMembershipRules != null &&
                    this.DynamicMembershipRules.SequenceEqual(input.DynamicMembershipRules)
                ) && 
                (
                    this.DefaultPolicy == input.DefaultPolicy ||
                    (this.DefaultPolicy != null &&
                    this.DefaultPolicy.Equals(input.DefaultPolicy))
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
                    this.DefaultLanguage == input.DefaultLanguage ||
                    (this.DefaultLanguage != null &&
                    this.DefaultLanguage.Equals(input.DefaultLanguage))
                ) && 
                (
                    this.DefaultSiteDesign == input.DefaultSiteDesign ||
                    (this.DefaultSiteDesign != null &&
                    this.DefaultSiteDesign.Equals(input.DefaultSiteDesign))
                ) && 
                (
                    this.DefaultOwnersReal == input.DefaultOwnersReal ||
                    this.DefaultOwnersReal != null &&
                    input.DefaultOwnersReal != null &&
                    this.DefaultOwnersReal.SequenceEqual(input.DefaultOwnersReal)
                ) && 
                (
                    this.DefaultMembersReal == input.DefaultMembersReal ||
                    this.DefaultMembersReal != null &&
                    input.DefaultMembersReal != null &&
                    this.DefaultMembersReal.SequenceEqual(input.DefaultMembersReal)
                ) && 
                (
                    this.DefaultPrimaryContactReal == input.DefaultPrimaryContactReal ||
                    (this.DefaultPrimaryContactReal != null &&
                    this.DefaultPrimaryContactReal.Equals(input.DefaultPrimaryContactReal))
                ) && 
                (
                    this.DefaultSecondaryContactReal == input.DefaultSecondaryContactReal ||
                    (this.DefaultSecondaryContactReal != null &&
                    this.DefaultSecondaryContactReal.Equals(input.DefaultSecondaryContactReal))
                ) && 
                (
                    this.MemberAssignBy == input.MemberAssignBy ||
                    this.MemberAssignBy.Equals(input.MemberAssignBy)
                ) && 
                (
                    this.OwnerAssignBy == input.OwnerAssignBy ||
                    this.OwnerAssignBy.Equals(input.OwnerAssignBy)
                ) && 
                (
                    this.PrivacyAssignBy == input.PrivacyAssignBy ||
                    this.PrivacyAssignBy.Equals(input.PrivacyAssignBy)
                ) && 
                (
                    this.SubscribeAssignBy == input.SubscribeAssignBy ||
                    this.SubscribeAssignBy.Equals(input.SubscribeAssignBy)
                ) && 
                (
                    this.OutsideSenderAssignBy == input.OutsideSenderAssignBy ||
                    this.OutsideSenderAssignBy.Equals(input.OutsideSenderAssignBy)
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
                    this.LanguageAssignBy == input.LanguageAssignBy ||
                    this.LanguageAssignBy.Equals(input.LanguageAssignBy)
                ) && 
                (
                    this.SecondaryContactAssignBy == input.SecondaryContactAssignBy ||
                    this.SecondaryContactAssignBy.Equals(input.SecondaryContactAssignBy)
                ) && 
                (
                    this.PrimaryContactAssignBy == input.PrimaryContactAssignBy ||
                    this.PrimaryContactAssignBy.Equals(input.PrimaryContactAssignBy)
                ) && 
                (
                    this.EnableDynamicMembership == input.EnableDynamicMembership ||
                    this.EnableDynamicMembership.Equals(input.EnableDynamicMembership)
                ) && 
                (
                    this.HideGroupMembershipAssignBy == input.HideGroupMembershipAssignBy ||
                    this.HideGroupMembershipAssignBy.Equals(input.HideGroupMembershipAssignBy)
                ) && 
                (
                    this.PolicyAssignBy == input.PolicyAssignBy ||
                    this.PolicyAssignBy.Equals(input.PolicyAssignBy)
                ) && 
                (
                    this.SiteDesignAssignBy == input.SiteDesignAssignBy ||
                    this.SiteDesignAssignBy.Equals(input.SiteDesignAssignBy)
                ) && 
                (
                    this.HubSiteAssignBy == input.HubSiteAssignBy ||
                    this.HubSiteAssignBy.Equals(input.HubSiteAssignBy)
                ) && 
                (
                    this.MultiGeoSetting == input.MultiGeoSetting ||
                    (this.MultiGeoSetting != null &&
                    this.MultiGeoSetting.Equals(input.MultiGeoSetting))
                ) && 
                (
                    this.IsShowHubSiteSection == input.IsShowHubSiteSection ||
                    this.IsShowHubSiteSection.Equals(input.IsShowHubSiteSection)
                ) && 
                (
                    this.HubSiteSettings == input.HubSiteSettings ||
                    (this.HubSiteSettings != null &&
                    this.HubSiteSettings.Equals(input.HubSiteSettings))
                ) && 
                (
                    this.HasImpernastionUsers == input.HasImpernastionUsers ||
                    this.HasImpernastionUsers.Equals(input.HasImpernastionUsers)
                ) && 
                (
                    this.PeoplePickerFilterProfileId == input.PeoplePickerFilterProfileId ||
                    (this.PeoplePickerFilterProfileId != null &&
                    this.PeoplePickerFilterProfileId.Equals(input.PeoplePickerFilterProfileId))
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
                hashCode = hashCode * 59 + this.GroupType.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.NetworkId != null)
                    hashCode = hashCode * 59 + this.NetworkId.GetHashCode();
                hashCode = hashCode * 59 + this.EnableTeams.GetHashCode();
                hashCode = hashCode * 59 + this.IsPrivate.GetHashCode();
                hashCode = hashCode * 59 + this.EnableSubscribe.GetHashCode();
                hashCode = hashCode * 59 + this.EnableApplySiteDesign.GetHashCode();
                hashCode = hashCode * 59 + this.EnableOutsideSender.GetHashCode();
                hashCode = hashCode * 59 + this.EnableHideGroupMembership.GetHashCode();
                hashCode = hashCode * 59 + this.EnableClassification.GetHashCode();
                hashCode = hashCode * 59 + this.PreventDuplicateName.GetHashCode();
                hashCode = hashCode * 59 + this.EnableSensitivity.GetHashCode();
                if (this.AllSensitivities != null)
                    hashCode = hashCode * 59 + this.AllSensitivities.GetHashCode();
                hashCode = hashCode * 59 + this.AllowConfigureLeasePeriod.GetHashCode();
                hashCode = hashCode * 59 + this.ShowNotebookLink.GetHashCode();
                hashCode = hashCode * 59 + this.ShowConversationsLink.GetHashCode();
                hashCode = hashCode * 59 + this.ShowFilesLink.GetHashCode();
                hashCode = hashCode * 59 + this.ShowTeamSiteLink.GetHashCode();
                hashCode = hashCode * 59 + this.ShowPlannerLink.GetHashCode();
                hashCode = hashCode * 59 + this.ShowYammerGroupLink.GetHashCode();
                if (this.Classifications != null)
                    hashCode = hashCode * 59 + this.Classifications.GetHashCode();
                if (this.Sensitivities != null)
                    hashCode = hashCode * 59 + this.Sensitivities.GetHashCode();
                if (this.SiteDesigns != null)
                    hashCode = hashCode * 59 + this.SiteDesigns.GetHashCode();
                hashCode = hashCode * 59 + this.AddGroupMemberType.GetHashCode();
                if (this.SelectedPolicies != null)
                    hashCode = hashCode * 59 + this.SelectedPolicies.GetHashCode();
                if (this.SelectedLanguages != null)
                    hashCode = hashCode * 59 + this.SelectedLanguages.GetHashCode();
                if (this.TeamsSettings != null)
                    hashCode = hashCode * 59 + this.TeamsSettings.GetHashCode();
                if (this.GroupNameConstructureSettings != null)
                    hashCode = hashCode * 59 + this.GroupNameConstructureSettings.GetHashCode();
                if (this.GroupIdConstructureSettings != null)
                    hashCode = hashCode * 59 + this.GroupIdConstructureSettings.GetHashCode();
                hashCode = hashCode * 59 + this.EnableInstallApp.GetHashCode();
                hashCode = hashCode * 59 + this.EnableInstallPanel.GetHashCode();
                if (this.TemplateSettings != null)
                    hashCode = hashCode * 59 + this.TemplateSettings.GetHashCode();
                if (this.DefaultPrimaryContact != null)
                    hashCode = hashCode * 59 + this.DefaultPrimaryContact.GetHashCode();
                if (this.DefaultSecondaryContact != null)
                    hashCode = hashCode * 59 + this.DefaultSecondaryContact.GetHashCode();
                if (this.DefaultOwners != null)
                    hashCode = hashCode * 59 + this.DefaultOwners.GetHashCode();
                if (this.DefaultMembers != null)
                    hashCode = hashCode * 59 + this.DefaultMembers.GetHashCode();
                hashCode = hashCode * 59 + this.DisableAddRemoveDynamicMembershipRules.GetHashCode();
                if (this.DynamicMembershipRules != null)
                    hashCode = hashCode * 59 + this.DynamicMembershipRules.GetHashCode();
                if (this.DefaultPolicy != null)
                    hashCode = hashCode * 59 + this.DefaultPolicy.GetHashCode();
                if (this.DefaultClassification != null)
                    hashCode = hashCode * 59 + this.DefaultClassification.GetHashCode();
                if (this.DefaultSensitivity != null)
                    hashCode = hashCode * 59 + this.DefaultSensitivity.GetHashCode();
                if (this.DefaultLanguage != null)
                    hashCode = hashCode * 59 + this.DefaultLanguage.GetHashCode();
                if (this.DefaultSiteDesign != null)
                    hashCode = hashCode * 59 + this.DefaultSiteDesign.GetHashCode();
                if (this.DefaultOwnersReal != null)
                    hashCode = hashCode * 59 + this.DefaultOwnersReal.GetHashCode();
                if (this.DefaultMembersReal != null)
                    hashCode = hashCode * 59 + this.DefaultMembersReal.GetHashCode();
                if (this.DefaultPrimaryContactReal != null)
                    hashCode = hashCode * 59 + this.DefaultPrimaryContactReal.GetHashCode();
                if (this.DefaultSecondaryContactReal != null)
                    hashCode = hashCode * 59 + this.DefaultSecondaryContactReal.GetHashCode();
                hashCode = hashCode * 59 + this.MemberAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.OwnerAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.PrivacyAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.SubscribeAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.OutsideSenderAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.ClassificationAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.SensitivityAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.LanguageAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.SecondaryContactAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.PrimaryContactAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.EnableDynamicMembership.GetHashCode();
                hashCode = hashCode * 59 + this.HideGroupMembershipAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.PolicyAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.SiteDesignAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.HubSiteAssignBy.GetHashCode();
                if (this.MultiGeoSetting != null)
                    hashCode = hashCode * 59 + this.MultiGeoSetting.GetHashCode();
                hashCode = hashCode * 59 + this.IsShowHubSiteSection.GetHashCode();
                if (this.HubSiteSettings != null)
                    hashCode = hashCode * 59 + this.HubSiteSettings.GetHashCode();
                hashCode = hashCode * 59 + this.HasImpernastionUsers.GetHashCode();
                if (this.PeoplePickerFilterProfileId != null)
                    hashCode = hashCode * 59 + this.PeoplePickerFilterProfileId.GetHashCode();
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
