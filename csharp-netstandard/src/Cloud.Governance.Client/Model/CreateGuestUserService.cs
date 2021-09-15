

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
    /// CreateGuestUserService
    /// </summary>
    [DataContract(Name = "CreateGuestUserService")]
    public partial class CreateGuestUserService : IEquatable<CreateGuestUserService>, IValidatableObject
    {
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
        /// Gets or Sets ManagerAssignBy
        /// </summary>
        [DataMember(Name = "managerAssignBy", EmitDefaultValue = false)]
        public AssignBy? ManagerAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets OneTimeDurationType
        /// </summary>
        [DataMember(Name = "oneTimeDurationType", EmitDefaultValue = false)]
        public ApiDurationType? OneTimeDurationType { get; set; }
        /// <summary>
        /// Gets or Sets DomainListType
        /// </summary>
        [DataMember(Name = "domainListType", EmitDefaultValue = false)]
        public ExternalDomainListType? DomainListType { get; set; }
        /// <summary>
        /// Gets or Sets UsageLocationAssignBy
        /// </summary>
        [DataMember(Name = "usageLocationAssignBy", EmitDefaultValue = false)]
        public AssignBy? UsageLocationAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets JobTitleAssignBy
        /// </summary>
        [DataMember(Name = "jobTitleAssignBy", EmitDefaultValue = false)]
        public AssignBy? JobTitleAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets JobDepartmentAssignBy
        /// </summary>
        [DataMember(Name = "jobDepartmentAssignBy", EmitDefaultValue = false)]
        public AssignBy? JobDepartmentAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets WelcomeEmailMessageAssignBy
        /// </summary>
        [DataMember(Name = "welcomeEmailMessageAssignBy", EmitDefaultValue = false)]
        public AssignBy? WelcomeEmailMessageAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets DisplayNameAssignBy
        /// </summary>
        [DataMember(Name = "displayNameAssignBy", EmitDefaultValue = false)]
        public AssignBy? DisplayNameAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets FirstNameAssignBy
        /// </summary>
        [DataMember(Name = "firstNameAssignBy", EmitDefaultValue = false)]
        public AssignBy? FirstNameAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets LastNameAssignBy
        /// </summary>
        [DataMember(Name = "lastNameAssignBy", EmitDefaultValue = false)]
        public AssignBy? LastNameAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets CompanyNameAssignBy
        /// </summary>
        [DataMember(Name = "companyNameAssignBy", EmitDefaultValue = false)]
        public AssignBy? CompanyNameAssignBy { get; set; }
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
        /// Initializes a new instance of the <see cref="CreateGuestUserService" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="enableInviteOwnersGroup">enableInviteOwnersGroup (default to false).</param>
        /// <param name="enableInviteContactGroup">enableInviteContactGroup (default to false).</param>
        /// <param name="enableAddToGroups">enableAddToGroups (default to false).</param>
        /// <param name="primaryContact">ApiUser model.</param>
        /// <param name="primaryContactAssignBy">primaryContactAssignBy.</param>
        /// <param name="secondaryContact">ApiUser model.</param>
        /// <param name="secondaryContactAssignBy">secondaryContactAssignBy.</param>
        /// <param name="manager">ApiUser model.</param>
        /// <param name="managerAssignBy">managerAssignBy.</param>
        /// <param name="enableOnTimeRenewal">enableOnTimeRenewal (default to false).</param>
        /// <param name="oneTimeDuration">oneTimeDuration (default to 0).</param>
        /// <param name="oneTimeDurationType">oneTimeDurationType.</param>
        /// <param name="peoplePickerFilterProfileId">peoplePickerFilterProfileId.</param>
        /// <param name="enableDomainList">enableDomainList (default to false).</param>
        /// <param name="domainListType">domainListType.</param>
        /// <param name="domains">domains.</param>
        /// <param name="usageLocationAssignBy">usageLocationAssignBy.</param>
        /// <param name="jobTitleAssignBy">jobTitleAssignBy.</param>
        /// <param name="jobDepartmentAssignBy">jobDepartmentAssignBy.</param>
        /// <param name="welcomeEmailMessageAssignBy">welcomeEmailMessageAssignBy.</param>
        /// <param name="usageLocation">usageLocation.</param>
        /// <param name="jobTitle">jobTitle.</param>
        /// <param name="jobDepartment">jobDepartment.</param>
        /// <param name="welcomeEmailMessage">welcomeEmailMessage.</param>
        /// <param name="displayNameAssignBy">displayNameAssignBy.</param>
        /// <param name="firstNameAssignBy">firstNameAssignBy.</param>
        /// <param name="lastNameAssignBy">lastNameAssignBy.</param>
        /// <param name="requestTemplate">requestTemplate.</param>
        /// <param name="enableInviteMultiple">enableInviteMultiple (default to false).</param>
        /// <param name="companyName">companyName.</param>
        /// <param name="companyNameAssignBy">companyNameAssignBy.</param>
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
        public CreateGuestUserService(Guid tenantId = default(Guid), bool enableInviteOwnersGroup = false, bool enableInviteContactGroup = false, bool enableAddToGroups = false, ApiUser primaryContact = default(ApiUser), AssignBy? primaryContactAssignBy = default(AssignBy?), ApiUser secondaryContact = default(ApiUser), AssignBy? secondaryContactAssignBy = default(AssignBy?), ApiUser manager = default(ApiUser), AssignBy? managerAssignBy = default(AssignBy?), bool enableOnTimeRenewal = false, int oneTimeDuration = 0, ApiDurationType? oneTimeDurationType = default(ApiDurationType?), Guid? peoplePickerFilterProfileId = default(Guid?), bool enableDomainList = false, ExternalDomainListType? domainListType = default(ExternalDomainListType?), List<string> domains = default(List<string>), AssignBy? usageLocationAssignBy = default(AssignBy?), AssignBy? jobTitleAssignBy = default(AssignBy?), AssignBy? jobDepartmentAssignBy = default(AssignBy?), AssignBy? welcomeEmailMessageAssignBy = default(AssignBy?), string usageLocation = default(string), string jobTitle = default(string), string jobDepartment = default(string), string welcomeEmailMessage = default(string), AssignBy? displayNameAssignBy = default(AssignBy?), AssignBy? firstNameAssignBy = default(AssignBy?), AssignBy? lastNameAssignBy = default(AssignBy?), CreateGuestUserRequest requestTemplate = default(CreateGuestUserRequest), bool enableInviteMultiple = false, string companyName = default(string), AssignBy? companyNameAssignBy = default(AssignBy?), List<CustomMetadata> metadatas = default(List<CustomMetadata>), bool hideRequestSummary = false, Guid id = default(Guid), string name = default(string), string description = default(string), ServiceType? type = default(ServiceType?), ApiUser serviceContact = default(ApiUser), ApiUser serviceAdminContact = default(ApiUser), bool approversContainManagerRole = false, CommonStatus? status = default(CommonStatus?), bool showServiceInCatalog = false, CustomActionSettings customActions = default(CustomActionSettings), Guid approvalProcessId = default(Guid), int languageId = 0, string categoryId = default(string))
        {
            this.TenantId = tenantId;
            this.EnableInviteOwnersGroup = enableInviteOwnersGroup;
            this.EnableInviteContactGroup = enableInviteContactGroup;
            this.EnableAddToGroups = enableAddToGroups;
            this.PrimaryContact = primaryContact;
            this.PrimaryContactAssignBy = primaryContactAssignBy;
            this.SecondaryContact = secondaryContact;
            this.SecondaryContactAssignBy = secondaryContactAssignBy;
            this.Manager = manager;
            this.ManagerAssignBy = managerAssignBy;
            this.EnableOnTimeRenewal = enableOnTimeRenewal;
            this.OneTimeDuration = oneTimeDuration;
            this.OneTimeDurationType = oneTimeDurationType;
            this.PeoplePickerFilterProfileId = peoplePickerFilterProfileId;
            this.EnableDomainList = enableDomainList;
            this.DomainListType = domainListType;
            this.Domains = domains;
            this.UsageLocationAssignBy = usageLocationAssignBy;
            this.JobTitleAssignBy = jobTitleAssignBy;
            this.JobDepartmentAssignBy = jobDepartmentAssignBy;
            this.WelcomeEmailMessageAssignBy = welcomeEmailMessageAssignBy;
            this.UsageLocation = usageLocation;
            this.JobTitle = jobTitle;
            this.JobDepartment = jobDepartment;
            this.WelcomeEmailMessage = welcomeEmailMessage;
            this.DisplayNameAssignBy = displayNameAssignBy;
            this.FirstNameAssignBy = firstNameAssignBy;
            this.LastNameAssignBy = lastNameAssignBy;
            this.RequestTemplate = requestTemplate;
            this.EnableInviteMultiple = enableInviteMultiple;
            this.CompanyName = companyName;
            this.CompanyNameAssignBy = companyNameAssignBy;
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
        /// Gets or Sets EnableInviteOwnersGroup
        /// </summary>
        [DataMember(Name = "enableInviteOwnersGroup", EmitDefaultValue = false)]
        public bool EnableInviteOwnersGroup { get; set; }

        /// <summary>
        /// Gets or Sets EnableInviteContactGroup
        /// </summary>
        [DataMember(Name = "enableInviteContactGroup", EmitDefaultValue = false)]
        public bool EnableInviteContactGroup { get; set; }

        /// <summary>
        /// Gets or Sets EnableAddToGroups
        /// </summary>
        [DataMember(Name = "enableAddToGroups", EmitDefaultValue = false)]
        public bool EnableAddToGroups { get; set; }

        /// <summary>
        /// ApiUser model
        /// </summary>
        /// <value>ApiUser model</value>
        [DataMember(Name = "primaryContact", EmitDefaultValue = true)]
        public ApiUser PrimaryContact { get; set; }

        /// <summary>
        /// ApiUser model
        /// </summary>
        /// <value>ApiUser model</value>
        [DataMember(Name = "secondaryContact", EmitDefaultValue = true)]
        public ApiUser SecondaryContact { get; set; }

        /// <summary>
        /// ApiUser model
        /// </summary>
        /// <value>ApiUser model</value>
        [DataMember(Name = "manager", EmitDefaultValue = true)]
        public ApiUser Manager { get; set; }

        /// <summary>
        /// Gets or Sets EnableOnTimeRenewal
        /// </summary>
        [DataMember(Name = "enableOnTimeRenewal", EmitDefaultValue = false)]
        public bool EnableOnTimeRenewal { get; set; }

        /// <summary>
        /// Gets or Sets OneTimeDuration
        /// </summary>
        [DataMember(Name = "oneTimeDuration", EmitDefaultValue = false)]
        public int OneTimeDuration { get; set; }

        /// <summary>
        /// Gets or Sets PeoplePickerFilterProfileId
        /// </summary>
        [DataMember(Name = "peoplePickerFilterProfileId", EmitDefaultValue = true)]
        public Guid? PeoplePickerFilterProfileId { get; set; }

        /// <summary>
        /// Gets or Sets EnableDomainList
        /// </summary>
        [DataMember(Name = "enableDomainList", EmitDefaultValue = false)]
        public bool EnableDomainList { get; set; }

        /// <summary>
        /// Gets or Sets Domains
        /// </summary>
        [DataMember(Name = "domains", EmitDefaultValue = true)]
        public List<string> Domains { get; set; }

        /// <summary>
        /// Gets or Sets UsageLocation
        /// </summary>
        [DataMember(Name = "usageLocation", EmitDefaultValue = true)]
        public string UsageLocation { get; set; }

        /// <summary>
        /// Gets or Sets JobTitle
        /// </summary>
        [DataMember(Name = "jobTitle", EmitDefaultValue = true)]
        public string JobTitle { get; set; }

        /// <summary>
        /// Gets or Sets JobDepartment
        /// </summary>
        [DataMember(Name = "jobDepartment", EmitDefaultValue = true)]
        public string JobDepartment { get; set; }

        /// <summary>
        /// Gets or Sets WelcomeEmailMessage
        /// </summary>
        [DataMember(Name = "welcomeEmailMessage", EmitDefaultValue = true)]
        public string WelcomeEmailMessage { get; set; }

        /// <summary>
        /// Gets or Sets RequestTemplate
        /// </summary>
        [DataMember(Name = "requestTemplate", EmitDefaultValue = true)]
        public CreateGuestUserRequest RequestTemplate { get; set; }

        /// <summary>
        /// Gets or Sets EnableInviteMultiple
        /// </summary>
        [DataMember(Name = "enableInviteMultiple", EmitDefaultValue = false)]
        public bool EnableInviteMultiple { get; set; }

        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name = "companyName", EmitDefaultValue = true)]
        public string CompanyName { get; set; }

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
            sb.Append("class CreateGuestUserService {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  EnableInviteOwnersGroup: ").Append(EnableInviteOwnersGroup).Append("\n");
            sb.Append("  EnableInviteContactGroup: ").Append(EnableInviteContactGroup).Append("\n");
            sb.Append("  EnableAddToGroups: ").Append(EnableAddToGroups).Append("\n");
            sb.Append("  PrimaryContact: ").Append(PrimaryContact).Append("\n");
            sb.Append("  PrimaryContactAssignBy: ").Append(PrimaryContactAssignBy).Append("\n");
            sb.Append("  SecondaryContact: ").Append(SecondaryContact).Append("\n");
            sb.Append("  SecondaryContactAssignBy: ").Append(SecondaryContactAssignBy).Append("\n");
            sb.Append("  Manager: ").Append(Manager).Append("\n");
            sb.Append("  ManagerAssignBy: ").Append(ManagerAssignBy).Append("\n");
            sb.Append("  EnableOnTimeRenewal: ").Append(EnableOnTimeRenewal).Append("\n");
            sb.Append("  OneTimeDuration: ").Append(OneTimeDuration).Append("\n");
            sb.Append("  OneTimeDurationType: ").Append(OneTimeDurationType).Append("\n");
            sb.Append("  PeoplePickerFilterProfileId: ").Append(PeoplePickerFilterProfileId).Append("\n");
            sb.Append("  EnableDomainList: ").Append(EnableDomainList).Append("\n");
            sb.Append("  DomainListType: ").Append(DomainListType).Append("\n");
            sb.Append("  Domains: ").Append(Domains).Append("\n");
            sb.Append("  UsageLocationAssignBy: ").Append(UsageLocationAssignBy).Append("\n");
            sb.Append("  JobTitleAssignBy: ").Append(JobTitleAssignBy).Append("\n");
            sb.Append("  JobDepartmentAssignBy: ").Append(JobDepartmentAssignBy).Append("\n");
            sb.Append("  WelcomeEmailMessageAssignBy: ").Append(WelcomeEmailMessageAssignBy).Append("\n");
            sb.Append("  UsageLocation: ").Append(UsageLocation).Append("\n");
            sb.Append("  JobTitle: ").Append(JobTitle).Append("\n");
            sb.Append("  JobDepartment: ").Append(JobDepartment).Append("\n");
            sb.Append("  WelcomeEmailMessage: ").Append(WelcomeEmailMessage).Append("\n");
            sb.Append("  DisplayNameAssignBy: ").Append(DisplayNameAssignBy).Append("\n");
            sb.Append("  FirstNameAssignBy: ").Append(FirstNameAssignBy).Append("\n");
            sb.Append("  LastNameAssignBy: ").Append(LastNameAssignBy).Append("\n");
            sb.Append("  RequestTemplate: ").Append(RequestTemplate).Append("\n");
            sb.Append("  EnableInviteMultiple: ").Append(EnableInviteMultiple).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  CompanyNameAssignBy: ").Append(CompanyNameAssignBy).Append("\n");
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
            return this.Equals(input as CreateGuestUserService);
        }

        /// <summary>
        /// Returns true if CreateGuestUserService instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateGuestUserService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateGuestUserService input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.EnableInviteOwnersGroup == input.EnableInviteOwnersGroup ||
                    this.EnableInviteOwnersGroup.Equals(input.EnableInviteOwnersGroup)
                ) && 
                (
                    this.EnableInviteContactGroup == input.EnableInviteContactGroup ||
                    this.EnableInviteContactGroup.Equals(input.EnableInviteContactGroup)
                ) && 
                (
                    this.EnableAddToGroups == input.EnableAddToGroups ||
                    this.EnableAddToGroups.Equals(input.EnableAddToGroups)
                ) && 
                (
                    this.PrimaryContact == input.PrimaryContact ||
                    (this.PrimaryContact != null &&
                    this.PrimaryContact.Equals(input.PrimaryContact))
                ) && 
                (
                    this.PrimaryContactAssignBy == input.PrimaryContactAssignBy ||
                    this.PrimaryContactAssignBy.Equals(input.PrimaryContactAssignBy)
                ) && 
                (
                    this.SecondaryContact == input.SecondaryContact ||
                    (this.SecondaryContact != null &&
                    this.SecondaryContact.Equals(input.SecondaryContact))
                ) && 
                (
                    this.SecondaryContactAssignBy == input.SecondaryContactAssignBy ||
                    this.SecondaryContactAssignBy.Equals(input.SecondaryContactAssignBy)
                ) && 
                (
                    this.Manager == input.Manager ||
                    (this.Manager != null &&
                    this.Manager.Equals(input.Manager))
                ) && 
                (
                    this.ManagerAssignBy == input.ManagerAssignBy ||
                    this.ManagerAssignBy.Equals(input.ManagerAssignBy)
                ) && 
                (
                    this.EnableOnTimeRenewal == input.EnableOnTimeRenewal ||
                    this.EnableOnTimeRenewal.Equals(input.EnableOnTimeRenewal)
                ) && 
                (
                    this.OneTimeDuration == input.OneTimeDuration ||
                    this.OneTimeDuration.Equals(input.OneTimeDuration)
                ) && 
                (
                    this.OneTimeDurationType == input.OneTimeDurationType ||
                    this.OneTimeDurationType.Equals(input.OneTimeDurationType)
                ) && 
                (
                    this.PeoplePickerFilterProfileId == input.PeoplePickerFilterProfileId ||
                    (this.PeoplePickerFilterProfileId != null &&
                    this.PeoplePickerFilterProfileId.Equals(input.PeoplePickerFilterProfileId))
                ) && 
                (
                    this.EnableDomainList == input.EnableDomainList ||
                    this.EnableDomainList.Equals(input.EnableDomainList)
                ) && 
                (
                    this.DomainListType == input.DomainListType ||
                    this.DomainListType.Equals(input.DomainListType)
                ) && 
                (
                    this.Domains == input.Domains ||
                    this.Domains != null &&
                    input.Domains != null &&
                    this.Domains.SequenceEqual(input.Domains)
                ) && 
                (
                    this.UsageLocationAssignBy == input.UsageLocationAssignBy ||
                    this.UsageLocationAssignBy.Equals(input.UsageLocationAssignBy)
                ) && 
                (
                    this.JobTitleAssignBy == input.JobTitleAssignBy ||
                    this.JobTitleAssignBy.Equals(input.JobTitleAssignBy)
                ) && 
                (
                    this.JobDepartmentAssignBy == input.JobDepartmentAssignBy ||
                    this.JobDepartmentAssignBy.Equals(input.JobDepartmentAssignBy)
                ) && 
                (
                    this.WelcomeEmailMessageAssignBy == input.WelcomeEmailMessageAssignBy ||
                    this.WelcomeEmailMessageAssignBy.Equals(input.WelcomeEmailMessageAssignBy)
                ) && 
                (
                    this.UsageLocation == input.UsageLocation ||
                    (this.UsageLocation != null &&
                    this.UsageLocation.Equals(input.UsageLocation))
                ) && 
                (
                    this.JobTitle == input.JobTitle ||
                    (this.JobTitle != null &&
                    this.JobTitle.Equals(input.JobTitle))
                ) && 
                (
                    this.JobDepartment == input.JobDepartment ||
                    (this.JobDepartment != null &&
                    this.JobDepartment.Equals(input.JobDepartment))
                ) && 
                (
                    this.WelcomeEmailMessage == input.WelcomeEmailMessage ||
                    (this.WelcomeEmailMessage != null &&
                    this.WelcomeEmailMessage.Equals(input.WelcomeEmailMessage))
                ) && 
                (
                    this.DisplayNameAssignBy == input.DisplayNameAssignBy ||
                    this.DisplayNameAssignBy.Equals(input.DisplayNameAssignBy)
                ) && 
                (
                    this.FirstNameAssignBy == input.FirstNameAssignBy ||
                    this.FirstNameAssignBy.Equals(input.FirstNameAssignBy)
                ) && 
                (
                    this.LastNameAssignBy == input.LastNameAssignBy ||
                    this.LastNameAssignBy.Equals(input.LastNameAssignBy)
                ) && 
                (
                    this.RequestTemplate == input.RequestTemplate ||
                    (this.RequestTemplate != null &&
                    this.RequestTemplate.Equals(input.RequestTemplate))
                ) && 
                (
                    this.EnableInviteMultiple == input.EnableInviteMultiple ||
                    this.EnableInviteMultiple.Equals(input.EnableInviteMultiple)
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.CompanyNameAssignBy == input.CompanyNameAssignBy ||
                    this.CompanyNameAssignBy.Equals(input.CompanyNameAssignBy)
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
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                hashCode = hashCode * 59 + this.EnableInviteOwnersGroup.GetHashCode();
                hashCode = hashCode * 59 + this.EnableInviteContactGroup.GetHashCode();
                hashCode = hashCode * 59 + this.EnableAddToGroups.GetHashCode();
                if (this.PrimaryContact != null)
                    hashCode = hashCode * 59 + this.PrimaryContact.GetHashCode();
                hashCode = hashCode * 59 + this.PrimaryContactAssignBy.GetHashCode();
                if (this.SecondaryContact != null)
                    hashCode = hashCode * 59 + this.SecondaryContact.GetHashCode();
                hashCode = hashCode * 59 + this.SecondaryContactAssignBy.GetHashCode();
                if (this.Manager != null)
                    hashCode = hashCode * 59 + this.Manager.GetHashCode();
                hashCode = hashCode * 59 + this.ManagerAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.EnableOnTimeRenewal.GetHashCode();
                hashCode = hashCode * 59 + this.OneTimeDuration.GetHashCode();
                hashCode = hashCode * 59 + this.OneTimeDurationType.GetHashCode();
                if (this.PeoplePickerFilterProfileId != null)
                    hashCode = hashCode * 59 + this.PeoplePickerFilterProfileId.GetHashCode();
                hashCode = hashCode * 59 + this.EnableDomainList.GetHashCode();
                hashCode = hashCode * 59 + this.DomainListType.GetHashCode();
                if (this.Domains != null)
                    hashCode = hashCode * 59 + this.Domains.GetHashCode();
                hashCode = hashCode * 59 + this.UsageLocationAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.JobTitleAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.JobDepartmentAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.WelcomeEmailMessageAssignBy.GetHashCode();
                if (this.UsageLocation != null)
                    hashCode = hashCode * 59 + this.UsageLocation.GetHashCode();
                if (this.JobTitle != null)
                    hashCode = hashCode * 59 + this.JobTitle.GetHashCode();
                if (this.JobDepartment != null)
                    hashCode = hashCode * 59 + this.JobDepartment.GetHashCode();
                if (this.WelcomeEmailMessage != null)
                    hashCode = hashCode * 59 + this.WelcomeEmailMessage.GetHashCode();
                hashCode = hashCode * 59 + this.DisplayNameAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.FirstNameAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.LastNameAssignBy.GetHashCode();
                if (this.RequestTemplate != null)
                    hashCode = hashCode * 59 + this.RequestTemplate.GetHashCode();
                hashCode = hashCode * 59 + this.EnableInviteMultiple.GetHashCode();
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                hashCode = hashCode * 59 + this.CompanyNameAssignBy.GetHashCode();
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
