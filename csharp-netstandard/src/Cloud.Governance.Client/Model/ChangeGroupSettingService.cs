

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
    /// ChangeGroupSettingService
    /// </summary>
    [DataContract(Name = "ChangeGroupSettingService")]
    public partial class ChangeGroupSettingService : IEquatable<ChangeGroupSettingService>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets GroupRestriction
        /// </summary>
        [DataMember(Name = "groupRestriction", EmitDefaultValue = false)]
        public GroupRestrictionType? GroupRestriction { get; set; }
        /// <summary>
        /// Gets or Sets AddOwnerRestriction
        /// </summary>
        [DataMember(Name = "addOwnerRestriction", EmitDefaultValue = false)]
        public UserLevelRestrictionType? AddOwnerRestriction { get; set; }
        /// <summary>
        /// Gets or Sets AddMemberRestriction
        /// </summary>
        [DataMember(Name = "addMemberRestriction", EmitDefaultValue = false)]
        public UserLevelRestrictionType? AddMemberRestriction { get; set; }
        /// <summary>
        /// Gets or Sets GroupObjectType
        /// </summary>
        [DataMember(Name = "groupObjectType", EmitDefaultValue = false)]
        public GroupObjectType? GroupObjectType { get; set; }
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
        /// Initializes a new instance of the <see cref="ChangeGroupSettingService" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="networkId">networkId.</param>
        /// <param name="groupRestriction">groupRestriction.</param>
        /// <param name="enableChangeName">enableChangeName (default to false).</param>
        /// <param name="preventDuplicateName">preventDuplicateName (default to false).</param>
        /// <param name="enableChangeDescription">enableChangeDescription (default to false).</param>
        /// <param name="enableChangeMemberSubscription">enableChangeMemberSubscription (default to false).</param>
        /// <param name="enableChangeOutsideSenders">enableChangeOutsideSenders (default to false).</param>
        /// <param name="enableChangePrimaryContact">enableChangePrimaryContact (default to false).</param>
        /// <param name="enableChangeSecondaryContact">enableChangeSecondaryContact (default to false).</param>
        /// <param name="enableAddOwners">enableAddOwners (default to false).</param>
        /// <param name="addOwnerRestriction">addOwnerRestriction.</param>
        /// <param name="enableRemoveOwners">enableRemoveOwners (default to false).</param>
        /// <param name="enableAddMembers">enableAddMembers (default to false).</param>
        /// <param name="addMemberRestriction">addMemberRestriction.</param>
        /// <param name="enableRemoveMembers">enableRemoveMembers (default to false).</param>
        /// <param name="enableChangeDynamicMembershipRules">enableChangeDynamicMembershipRules (default to false).</param>
        /// <param name="enableChangeTeamCollaboration">enableChangeTeamCollaboration (default to false).</param>
        /// <param name="enableChangeHubSite">enableChangeHubSite (default to false).</param>
        /// <param name="enableChangeClassification">enableChangeClassification (default to false).</param>
        /// <param name="classificationList">classificationList.</param>
        /// <param name="enableChangeSensitivity">enableChangeSensitivity (default to false).</param>
        /// <param name="sensitivityList">sensitivityList.</param>
        /// <param name="enableChangeMetadata">enableChangeMetadata (default to false).</param>
        /// <param name="enableAddOrDeleteMetadata">enableAddOrDeleteMetadata (default to false).</param>
        /// <param name="metadataList">metadataList.</param>
        /// <param name="enableChangeMembershipType">enableChangeMembershipType (default to false).</param>
        /// <param name="groupObjectType">groupObjectType.</param>
        /// <param name="enableChangeYammerGroupInfo">enableChangeYammerGroupInfo (default to false).</param>
        /// <param name="scopePeoplePickerFilterProfileId">scopePeoplePickerFilterProfileId.</param>
        /// <param name="peoplePickerFilterProfileId">peoplePickerFilterProfileId.</param>
        /// <param name="requestTemplate">requestTemplate.</param>
        /// <param name="isChangeTimeZoneEnabled">isChangeTimeZoneEnabled (default to false).</param>
        /// <param name="isChangeLocaleEnabled">isChangeLocaleEnabled (default to false).</param>
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
        public ChangeGroupSettingService(Guid tenantId = default(Guid), string networkId = default(string), GroupRestrictionType? groupRestriction = default(GroupRestrictionType?), bool enableChangeName = false, bool preventDuplicateName = false, bool enableChangeDescription = false, bool enableChangeMemberSubscription = false, bool enableChangeOutsideSenders = false, bool enableChangePrimaryContact = false, bool enableChangeSecondaryContact = false, bool enableAddOwners = false, UserLevelRestrictionType? addOwnerRestriction = default(UserLevelRestrictionType?), bool enableRemoveOwners = false, bool enableAddMembers = false, UserLevelRestrictionType? addMemberRestriction = default(UserLevelRestrictionType?), bool enableRemoveMembers = false, bool enableChangeDynamicMembershipRules = false, bool enableChangeTeamCollaboration = false, bool enableChangeHubSite = false, bool enableChangeClassification = false, List<string> classificationList = default(List<string>), bool enableChangeSensitivity = false, List<StringModel> sensitivityList = default(List<StringModel>), bool enableChangeMetadata = false, bool enableAddOrDeleteMetadata = false, List<CustomMetadata> metadataList = default(List<CustomMetadata>), bool enableChangeMembershipType = false, GroupObjectType? groupObjectType = default(GroupObjectType?), bool enableChangeYammerGroupInfo = false, Guid? scopePeoplePickerFilterProfileId = default(Guid?), Guid? peoplePickerFilterProfileId = default(Guid?), ChangeGroupSettingRequest requestTemplate = default(ChangeGroupSettingRequest), bool isChangeTimeZoneEnabled = false, bool isChangeLocaleEnabled = false, List<CustomMetadata> metadatas = default(List<CustomMetadata>), bool hideRequestSummary = false, Guid id = default(Guid), string name = default(string), string description = default(string), ServiceType? type = default(ServiceType?), ApiUser serviceContact = default(ApiUser), ApiUser serviceAdminContact = default(ApiUser), bool approversContainManagerRole = false, CommonStatus? status = default(CommonStatus?), bool showServiceInCatalog = false, CustomActionSettings customActions = default(CustomActionSettings), Guid approvalProcessId = default(Guid), int languageId = 0, string categoryId = default(string))
        {
            this.TenantId = tenantId;
            this.NetworkId = networkId;
            this.GroupRestriction = groupRestriction;
            this.EnableChangeName = enableChangeName;
            this.PreventDuplicateName = preventDuplicateName;
            this.EnableChangeDescription = enableChangeDescription;
            this.EnableChangeMemberSubscription = enableChangeMemberSubscription;
            this.EnableChangeOutsideSenders = enableChangeOutsideSenders;
            this.EnableChangePrimaryContact = enableChangePrimaryContact;
            this.EnableChangeSecondaryContact = enableChangeSecondaryContact;
            this.EnableAddOwners = enableAddOwners;
            this.AddOwnerRestriction = addOwnerRestriction;
            this.EnableRemoveOwners = enableRemoveOwners;
            this.EnableAddMembers = enableAddMembers;
            this.AddMemberRestriction = addMemberRestriction;
            this.EnableRemoveMembers = enableRemoveMembers;
            this.EnableChangeDynamicMembershipRules = enableChangeDynamicMembershipRules;
            this.EnableChangeTeamCollaboration = enableChangeTeamCollaboration;
            this.EnableChangeHubSite = enableChangeHubSite;
            this.EnableChangeClassification = enableChangeClassification;
            this.ClassificationList = classificationList;
            this.EnableChangeSensitivity = enableChangeSensitivity;
            this.SensitivityList = sensitivityList;
            this.EnableChangeMetadata = enableChangeMetadata;
            this.EnableAddOrDeleteMetadata = enableAddOrDeleteMetadata;
            this.MetadataList = metadataList;
            this.EnableChangeMembershipType = enableChangeMembershipType;
            this.GroupObjectType = groupObjectType;
            this.EnableChangeYammerGroupInfo = enableChangeYammerGroupInfo;
            this.ScopePeoplePickerFilterProfileId = scopePeoplePickerFilterProfileId;
            this.PeoplePickerFilterProfileId = peoplePickerFilterProfileId;
            this.RequestTemplate = requestTemplate;
            this.IsChangeTimeZoneEnabled = isChangeTimeZoneEnabled;
            this.IsChangeLocaleEnabled = isChangeLocaleEnabled;
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
        /// Gets or Sets EnableChangeName
        /// </summary>
        [DataMember(Name = "enableChangeName", EmitDefaultValue = false)]
        public bool EnableChangeName { get; set; }

        /// <summary>
        /// Gets or Sets PreventDuplicateName
        /// </summary>
        [DataMember(Name = "preventDuplicateName", EmitDefaultValue = false)]
        public bool PreventDuplicateName { get; set; }

        /// <summary>
        /// Gets or Sets EnableChangeDescription
        /// </summary>
        [DataMember(Name = "enableChangeDescription", EmitDefaultValue = false)]
        public bool EnableChangeDescription { get; set; }

        /// <summary>
        /// Gets or Sets EnableChangeMemberSubscription
        /// </summary>
        [DataMember(Name = "enableChangeMemberSubscription", EmitDefaultValue = false)]
        public bool EnableChangeMemberSubscription { get; set; }

        /// <summary>
        /// Gets or Sets EnableChangeOutsideSenders
        /// </summary>
        [DataMember(Name = "enableChangeOutsideSenders", EmitDefaultValue = false)]
        public bool EnableChangeOutsideSenders { get; set; }

        /// <summary>
        /// Gets or Sets EnableChangePrimaryContact
        /// </summary>
        [DataMember(Name = "enableChangePrimaryContact", EmitDefaultValue = false)]
        public bool EnableChangePrimaryContact { get; set; }

        /// <summary>
        /// Gets or Sets EnableChangeSecondaryContact
        /// </summary>
        [DataMember(Name = "enableChangeSecondaryContact", EmitDefaultValue = false)]
        public bool EnableChangeSecondaryContact { get; set; }

        /// <summary>
        /// Gets or Sets EnableAddOwners
        /// </summary>
        [DataMember(Name = "enableAddOwners", EmitDefaultValue = false)]
        public bool EnableAddOwners { get; set; }

        /// <summary>
        /// Gets or Sets EnableRemoveOwners
        /// </summary>
        [DataMember(Name = "enableRemoveOwners", EmitDefaultValue = false)]
        public bool EnableRemoveOwners { get; set; }

        /// <summary>
        /// Gets or Sets EnableAddMembers
        /// </summary>
        [DataMember(Name = "enableAddMembers", EmitDefaultValue = false)]
        public bool EnableAddMembers { get; set; }

        /// <summary>
        /// Gets or Sets EnableRemoveMembers
        /// </summary>
        [DataMember(Name = "enableRemoveMembers", EmitDefaultValue = false)]
        public bool EnableRemoveMembers { get; set; }

        /// <summary>
        /// Gets or Sets EnableChangeDynamicMembershipRules
        /// </summary>
        [DataMember(Name = "enableChangeDynamicMembershipRules", EmitDefaultValue = false)]
        public bool EnableChangeDynamicMembershipRules { get; set; }

        /// <summary>
        /// Gets or Sets EnableChangeTeamCollaboration
        /// </summary>
        [DataMember(Name = "enableChangeTeamCollaboration", EmitDefaultValue = false)]
        public bool EnableChangeTeamCollaboration { get; set; }

        /// <summary>
        /// Gets or Sets EnableChangeHubSite
        /// </summary>
        [DataMember(Name = "enableChangeHubSite", EmitDefaultValue = false)]
        public bool EnableChangeHubSite { get; set; }

        /// <summary>
        /// Gets or Sets EnableChangeClassification
        /// </summary>
        [DataMember(Name = "enableChangeClassification", EmitDefaultValue = false)]
        public bool EnableChangeClassification { get; set; }

        /// <summary>
        /// Gets or Sets ClassificationList
        /// </summary>
        [DataMember(Name = "classificationList", EmitDefaultValue = true)]
        public List<string> ClassificationList { get; set; }

        /// <summary>
        /// Gets or Sets EnableChangeSensitivity
        /// </summary>
        [DataMember(Name = "enableChangeSensitivity", EmitDefaultValue = false)]
        public bool EnableChangeSensitivity { get; set; }

        /// <summary>
        /// Gets or Sets SensitivityList
        /// </summary>
        [DataMember(Name = "sensitivityList", EmitDefaultValue = true)]
        public List<StringModel> SensitivityList { get; set; }

        /// <summary>
        /// Gets or Sets EnableChangeMetadata
        /// </summary>
        [DataMember(Name = "enableChangeMetadata", EmitDefaultValue = false)]
        public bool EnableChangeMetadata { get; set; }

        /// <summary>
        /// Gets or Sets EnableAddOrDeleteMetadata
        /// </summary>
        [DataMember(Name = "enableAddOrDeleteMetadata", EmitDefaultValue = false)]
        public bool EnableAddOrDeleteMetadata { get; set; }

        /// <summary>
        /// Gets or Sets MetadataList
        /// </summary>
        [DataMember(Name = "metadataList", EmitDefaultValue = true)]
        public List<CustomMetadata> MetadataList { get; set; }

        /// <summary>
        /// Gets or Sets EnableChangeMembershipType
        /// </summary>
        [DataMember(Name = "enableChangeMembershipType", EmitDefaultValue = false)]
        public bool EnableChangeMembershipType { get; set; }

        /// <summary>
        /// Gets or Sets EnableChangeYammerGroupInfo
        /// </summary>
        [DataMember(Name = "enableChangeYammerGroupInfo", EmitDefaultValue = false)]
        public bool EnableChangeYammerGroupInfo { get; set; }

        /// <summary>
        /// Gets or Sets ScopePeoplePickerFilterProfileId
        /// </summary>
        [DataMember(Name = "scopePeoplePickerFilterProfileId", EmitDefaultValue = true)]
        public Guid? ScopePeoplePickerFilterProfileId { get; set; }

        /// <summary>
        /// Gets or Sets PeoplePickerFilterProfileId
        /// </summary>
        [DataMember(Name = "peoplePickerFilterProfileId", EmitDefaultValue = true)]
        public Guid? PeoplePickerFilterProfileId { get; set; }

        /// <summary>
        /// Gets or Sets RequestTemplate
        /// </summary>
        [DataMember(Name = "requestTemplate", EmitDefaultValue = true)]
        public ChangeGroupSettingRequest RequestTemplate { get; set; }

        /// <summary>
        /// Gets or Sets IsChangeTimeZoneEnabled
        /// </summary>
        [DataMember(Name = "isChangeTimeZoneEnabled", EmitDefaultValue = false)]
        public bool IsChangeTimeZoneEnabled { get; set; }

        /// <summary>
        /// Gets or Sets IsChangeLocaleEnabled
        /// </summary>
        [DataMember(Name = "isChangeLocaleEnabled", EmitDefaultValue = false)]
        public bool IsChangeLocaleEnabled { get; set; }

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
            sb.Append("class ChangeGroupSettingService {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  NetworkId: ").Append(NetworkId).Append("\n");
            sb.Append("  GroupRestriction: ").Append(GroupRestriction).Append("\n");
            sb.Append("  EnableChangeName: ").Append(EnableChangeName).Append("\n");
            sb.Append("  PreventDuplicateName: ").Append(PreventDuplicateName).Append("\n");
            sb.Append("  EnableChangeDescription: ").Append(EnableChangeDescription).Append("\n");
            sb.Append("  EnableChangeMemberSubscription: ").Append(EnableChangeMemberSubscription).Append("\n");
            sb.Append("  EnableChangeOutsideSenders: ").Append(EnableChangeOutsideSenders).Append("\n");
            sb.Append("  EnableChangePrimaryContact: ").Append(EnableChangePrimaryContact).Append("\n");
            sb.Append("  EnableChangeSecondaryContact: ").Append(EnableChangeSecondaryContact).Append("\n");
            sb.Append("  EnableAddOwners: ").Append(EnableAddOwners).Append("\n");
            sb.Append("  AddOwnerRestriction: ").Append(AddOwnerRestriction).Append("\n");
            sb.Append("  EnableRemoveOwners: ").Append(EnableRemoveOwners).Append("\n");
            sb.Append("  EnableAddMembers: ").Append(EnableAddMembers).Append("\n");
            sb.Append("  AddMemberRestriction: ").Append(AddMemberRestriction).Append("\n");
            sb.Append("  EnableRemoveMembers: ").Append(EnableRemoveMembers).Append("\n");
            sb.Append("  EnableChangeDynamicMembershipRules: ").Append(EnableChangeDynamicMembershipRules).Append("\n");
            sb.Append("  EnableChangeTeamCollaboration: ").Append(EnableChangeTeamCollaboration).Append("\n");
            sb.Append("  EnableChangeHubSite: ").Append(EnableChangeHubSite).Append("\n");
            sb.Append("  EnableChangeClassification: ").Append(EnableChangeClassification).Append("\n");
            sb.Append("  ClassificationList: ").Append(ClassificationList).Append("\n");
            sb.Append("  EnableChangeSensitivity: ").Append(EnableChangeSensitivity).Append("\n");
            sb.Append("  SensitivityList: ").Append(SensitivityList).Append("\n");
            sb.Append("  EnableChangeMetadata: ").Append(EnableChangeMetadata).Append("\n");
            sb.Append("  EnableAddOrDeleteMetadata: ").Append(EnableAddOrDeleteMetadata).Append("\n");
            sb.Append("  MetadataList: ").Append(MetadataList).Append("\n");
            sb.Append("  EnableChangeMembershipType: ").Append(EnableChangeMembershipType).Append("\n");
            sb.Append("  GroupObjectType: ").Append(GroupObjectType).Append("\n");
            sb.Append("  EnableChangeYammerGroupInfo: ").Append(EnableChangeYammerGroupInfo).Append("\n");
            sb.Append("  ScopePeoplePickerFilterProfileId: ").Append(ScopePeoplePickerFilterProfileId).Append("\n");
            sb.Append("  PeoplePickerFilterProfileId: ").Append(PeoplePickerFilterProfileId).Append("\n");
            sb.Append("  RequestTemplate: ").Append(RequestTemplate).Append("\n");
            sb.Append("  IsChangeTimeZoneEnabled: ").Append(IsChangeTimeZoneEnabled).Append("\n");
            sb.Append("  IsChangeLocaleEnabled: ").Append(IsChangeLocaleEnabled).Append("\n");
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
            return this.Equals(input as ChangeGroupSettingService);
        }

        /// <summary>
        /// Returns true if ChangeGroupSettingService instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeGroupSettingService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeGroupSettingService input)
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
                    this.NetworkId == input.NetworkId ||
                    (this.NetworkId != null &&
                    this.NetworkId.Equals(input.NetworkId))
                ) && 
                (
                    this.GroupRestriction == input.GroupRestriction ||
                    this.GroupRestriction.Equals(input.GroupRestriction)
                ) && 
                (
                    this.EnableChangeName == input.EnableChangeName ||
                    this.EnableChangeName.Equals(input.EnableChangeName)
                ) && 
                (
                    this.PreventDuplicateName == input.PreventDuplicateName ||
                    this.PreventDuplicateName.Equals(input.PreventDuplicateName)
                ) && 
                (
                    this.EnableChangeDescription == input.EnableChangeDescription ||
                    this.EnableChangeDescription.Equals(input.EnableChangeDescription)
                ) && 
                (
                    this.EnableChangeMemberSubscription == input.EnableChangeMemberSubscription ||
                    this.EnableChangeMemberSubscription.Equals(input.EnableChangeMemberSubscription)
                ) && 
                (
                    this.EnableChangeOutsideSenders == input.EnableChangeOutsideSenders ||
                    this.EnableChangeOutsideSenders.Equals(input.EnableChangeOutsideSenders)
                ) && 
                (
                    this.EnableChangePrimaryContact == input.EnableChangePrimaryContact ||
                    this.EnableChangePrimaryContact.Equals(input.EnableChangePrimaryContact)
                ) && 
                (
                    this.EnableChangeSecondaryContact == input.EnableChangeSecondaryContact ||
                    this.EnableChangeSecondaryContact.Equals(input.EnableChangeSecondaryContact)
                ) && 
                (
                    this.EnableAddOwners == input.EnableAddOwners ||
                    this.EnableAddOwners.Equals(input.EnableAddOwners)
                ) && 
                (
                    this.AddOwnerRestriction == input.AddOwnerRestriction ||
                    this.AddOwnerRestriction.Equals(input.AddOwnerRestriction)
                ) && 
                (
                    this.EnableRemoveOwners == input.EnableRemoveOwners ||
                    this.EnableRemoveOwners.Equals(input.EnableRemoveOwners)
                ) && 
                (
                    this.EnableAddMembers == input.EnableAddMembers ||
                    this.EnableAddMembers.Equals(input.EnableAddMembers)
                ) && 
                (
                    this.AddMemberRestriction == input.AddMemberRestriction ||
                    this.AddMemberRestriction.Equals(input.AddMemberRestriction)
                ) && 
                (
                    this.EnableRemoveMembers == input.EnableRemoveMembers ||
                    this.EnableRemoveMembers.Equals(input.EnableRemoveMembers)
                ) && 
                (
                    this.EnableChangeDynamicMembershipRules == input.EnableChangeDynamicMembershipRules ||
                    this.EnableChangeDynamicMembershipRules.Equals(input.EnableChangeDynamicMembershipRules)
                ) && 
                (
                    this.EnableChangeTeamCollaboration == input.EnableChangeTeamCollaboration ||
                    this.EnableChangeTeamCollaboration.Equals(input.EnableChangeTeamCollaboration)
                ) && 
                (
                    this.EnableChangeHubSite == input.EnableChangeHubSite ||
                    this.EnableChangeHubSite.Equals(input.EnableChangeHubSite)
                ) && 
                (
                    this.EnableChangeClassification == input.EnableChangeClassification ||
                    this.EnableChangeClassification.Equals(input.EnableChangeClassification)
                ) && 
                (
                    this.ClassificationList == input.ClassificationList ||
                    this.ClassificationList != null &&
                    input.ClassificationList != null &&
                    this.ClassificationList.SequenceEqual(input.ClassificationList)
                ) && 
                (
                    this.EnableChangeSensitivity == input.EnableChangeSensitivity ||
                    this.EnableChangeSensitivity.Equals(input.EnableChangeSensitivity)
                ) && 
                (
                    this.SensitivityList == input.SensitivityList ||
                    this.SensitivityList != null &&
                    input.SensitivityList != null &&
                    this.SensitivityList.SequenceEqual(input.SensitivityList)
                ) && 
                (
                    this.EnableChangeMetadata == input.EnableChangeMetadata ||
                    this.EnableChangeMetadata.Equals(input.EnableChangeMetadata)
                ) && 
                (
                    this.EnableAddOrDeleteMetadata == input.EnableAddOrDeleteMetadata ||
                    this.EnableAddOrDeleteMetadata.Equals(input.EnableAddOrDeleteMetadata)
                ) && 
                (
                    this.MetadataList == input.MetadataList ||
                    this.MetadataList != null &&
                    input.MetadataList != null &&
                    this.MetadataList.SequenceEqual(input.MetadataList)
                ) && 
                (
                    this.EnableChangeMembershipType == input.EnableChangeMembershipType ||
                    this.EnableChangeMembershipType.Equals(input.EnableChangeMembershipType)
                ) && 
                (
                    this.GroupObjectType == input.GroupObjectType ||
                    this.GroupObjectType.Equals(input.GroupObjectType)
                ) && 
                (
                    this.EnableChangeYammerGroupInfo == input.EnableChangeYammerGroupInfo ||
                    this.EnableChangeYammerGroupInfo.Equals(input.EnableChangeYammerGroupInfo)
                ) && 
                (
                    this.ScopePeoplePickerFilterProfileId == input.ScopePeoplePickerFilterProfileId ||
                    (this.ScopePeoplePickerFilterProfileId != null &&
                    this.ScopePeoplePickerFilterProfileId.Equals(input.ScopePeoplePickerFilterProfileId))
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
                    this.IsChangeTimeZoneEnabled == input.IsChangeTimeZoneEnabled ||
                    this.IsChangeTimeZoneEnabled.Equals(input.IsChangeTimeZoneEnabled)
                ) && 
                (
                    this.IsChangeLocaleEnabled == input.IsChangeLocaleEnabled ||
                    this.IsChangeLocaleEnabled.Equals(input.IsChangeLocaleEnabled)
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
                if (this.NetworkId != null)
                    hashCode = hashCode * 59 + this.NetworkId.GetHashCode();
                hashCode = hashCode * 59 + this.GroupRestriction.GetHashCode();
                hashCode = hashCode * 59 + this.EnableChangeName.GetHashCode();
                hashCode = hashCode * 59 + this.PreventDuplicateName.GetHashCode();
                hashCode = hashCode * 59 + this.EnableChangeDescription.GetHashCode();
                hashCode = hashCode * 59 + this.EnableChangeMemberSubscription.GetHashCode();
                hashCode = hashCode * 59 + this.EnableChangeOutsideSenders.GetHashCode();
                hashCode = hashCode * 59 + this.EnableChangePrimaryContact.GetHashCode();
                hashCode = hashCode * 59 + this.EnableChangeSecondaryContact.GetHashCode();
                hashCode = hashCode * 59 + this.EnableAddOwners.GetHashCode();
                hashCode = hashCode * 59 + this.AddOwnerRestriction.GetHashCode();
                hashCode = hashCode * 59 + this.EnableRemoveOwners.GetHashCode();
                hashCode = hashCode * 59 + this.EnableAddMembers.GetHashCode();
                hashCode = hashCode * 59 + this.AddMemberRestriction.GetHashCode();
                hashCode = hashCode * 59 + this.EnableRemoveMembers.GetHashCode();
                hashCode = hashCode * 59 + this.EnableChangeDynamicMembershipRules.GetHashCode();
                hashCode = hashCode * 59 + this.EnableChangeTeamCollaboration.GetHashCode();
                hashCode = hashCode * 59 + this.EnableChangeHubSite.GetHashCode();
                hashCode = hashCode * 59 + this.EnableChangeClassification.GetHashCode();
                if (this.ClassificationList != null)
                    hashCode = hashCode * 59 + this.ClassificationList.GetHashCode();
                hashCode = hashCode * 59 + this.EnableChangeSensitivity.GetHashCode();
                if (this.SensitivityList != null)
                    hashCode = hashCode * 59 + this.SensitivityList.GetHashCode();
                hashCode = hashCode * 59 + this.EnableChangeMetadata.GetHashCode();
                hashCode = hashCode * 59 + this.EnableAddOrDeleteMetadata.GetHashCode();
                if (this.MetadataList != null)
                    hashCode = hashCode * 59 + this.MetadataList.GetHashCode();
                hashCode = hashCode * 59 + this.EnableChangeMembershipType.GetHashCode();
                hashCode = hashCode * 59 + this.GroupObjectType.GetHashCode();
                hashCode = hashCode * 59 + this.EnableChangeYammerGroupInfo.GetHashCode();
                if (this.ScopePeoplePickerFilterProfileId != null)
                    hashCode = hashCode * 59 + this.ScopePeoplePickerFilterProfileId.GetHashCode();
                if (this.PeoplePickerFilterProfileId != null)
                    hashCode = hashCode * 59 + this.PeoplePickerFilterProfileId.GetHashCode();
                if (this.RequestTemplate != null)
                    hashCode = hashCode * 59 + this.RequestTemplate.GetHashCode();
                hashCode = hashCode * 59 + this.IsChangeTimeZoneEnabled.GetHashCode();
                hashCode = hashCode * 59 + this.IsChangeLocaleEnabled.GetHashCode();
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
