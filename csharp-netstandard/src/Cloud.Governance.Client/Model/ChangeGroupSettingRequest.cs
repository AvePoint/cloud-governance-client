

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
    /// ChangeGroupSettingRequest
    /// </summary>
    [DataContract(Name = "ChangeGroupSettingRequest")]
    public partial class ChangeGroupSettingRequest : IEquatable<ChangeGroupSettingRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets HubSiteActionType
        /// </summary>
        [DataMember(Name = "hubSiteActionType", EmitDefaultValue = false)]
        public ChangeHubsiteActionType? HubSiteActionType { get; set; }
        /// <summary>
        /// Gets or Sets ChangedDynamicGroupType
        /// </summary>
        [DataMember(Name = "changedDynamicGroupType", EmitDefaultValue = false)]
        public AddGroupMemberType? ChangedDynamicGroupType { get; set; }
        /// <summary>
        /// Gets or Sets GroupObjectType
        /// </summary>
        [DataMember(Name = "groupObjectType", EmitDefaultValue = false)]
        public GroupObjectType? GroupObjectType { get; set; }
        /// <summary>
        /// Service type of request.
        /// </summary>
        /// <value>Service type of request.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public ServiceType? Type { get; set; }

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
        {
            return false;
        }
        /// <summary>
        /// Status of request.
        /// </summary>
        /// <value>Status of request.</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public RequestStatus? Status { get; set; }

        /// <summary>
        /// Returns false as Status should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStatus()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeGroupSettingRequest" /> class.
        /// </summary>
        /// <param name="groupId">groupId.</param>
        /// <param name="groupEmail">groupEmail.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="originalGroupName">originalGroupName.</param>
        /// <param name="groupDescription">groupDescription.</param>
        /// <param name="originalGroupDescription">originalGroupDescription.</param>
        /// <param name="originalYammerGroupInfo">originalYammerGroupInfo.</param>
        /// <param name="primaryContact">primaryContact.</param>
        /// <param name="originalPrimaryContact">originalPrimaryContact.</param>
        /// <param name="secondaryContact">secondaryContact.</param>
        /// <param name="originalSecondaryContact">originalSecondaryContact.</param>
        /// <param name="groupOwners">groupOwners.</param>
        /// <param name="groupMembers">groupMembers.</param>
        /// <param name="isDynamicMembership">isDynamicMembership (default to false).</param>
        /// <param name="dynamicMembershipRules">dynamicMembershipRules.</param>
        /// <param name="enabledSubscribe">enabledSubscribe (default to false).</param>
        /// <param name="originalEnabledSubscribe">originalEnabledSubscribe (default to false).</param>
        /// <param name="enabledOutsideSender">enabledOutsideSender (default to false).</param>
        /// <param name="originalEnabledOutsideSender">originalEnabledOutsideSender (default to false).</param>
        /// <param name="hubSiteActionType">hubSiteActionType.</param>
        /// <param name="associateHubSiteId">associateHubSiteId.</param>
        /// <param name="associateHubSiteTitle">associateHubSiteTitle.</param>
        /// <param name="classification">classification.</param>
        /// <param name="originalClassification">originalClassification.</param>
        /// <param name="sensitivity">sensitivity.</param>
        /// <param name="originalSensitivity">originalSensitivity.</param>
        /// <param name="enableTeams">enableTeams (default to false).</param>
        /// <param name="originalEnableTeams">originalEnableTeams (default to false).</param>
        /// <param name="groupMetadatas">groupMetadatas.</param>
        /// <param name="originalGroupMetadata">originalGroupMetadata.</param>
        /// <param name="changedDynamicGroupType">changedDynamicGroupType.</param>
        /// <param name="yammerGroupInfo">yammerGroupInfo.</param>
        /// <param name="groupObjectType">groupObjectType.</param>
        /// <param name="networkId">networkId.</param>
        /// <param name="groupObjectId">groupObjectId.</param>
        /// <param name="enableTeamCollaboration">enableTeamCollaboration (default to false).</param>
        /// <param name="id">Id of request..</param>
        /// <param name="serviceId">Id of service..</param>
        /// <param name="department">Department of requester..</param>
        /// <param name="summary">Summary of request..</param>
        /// <param name="notesToApprovers">Notes to approvers..</param>
        /// <param name="questionnaireId">Id of questionnaire.</param>
        /// <param name="metadatas">Metadata of request..</param>
        public ChangeGroupSettingRequest(Guid groupId = default(Guid), string groupEmail = default(string), string groupName = default(string), string originalGroupName = default(string), string groupDescription = default(string), string originalGroupDescription = default(string), string originalYammerGroupInfo = default(string), ApiUser primaryContact = default(ApiUser), ApiUser originalPrimaryContact = default(ApiUser), ApiUser secondaryContact = default(ApiUser), ApiUser originalSecondaryContact = default(ApiUser), List<GroupMembershipItem> groupOwners = default(List<GroupMembershipItem>), List<GroupMembershipItem> groupMembers = default(List<GroupMembershipItem>), bool isDynamicMembership = false, List<DynamicGroupRuleInfo> dynamicMembershipRules = default(List<DynamicGroupRuleInfo>), bool enabledSubscribe = false, bool originalEnabledSubscribe = false, bool enabledOutsideSender = false, bool originalEnabledOutsideSender = false, ChangeHubsiteActionType? hubSiteActionType = default(ChangeHubsiteActionType?), Guid? associateHubSiteId = default(Guid?), string associateHubSiteTitle = default(string), string classification = default(string), string originalClassification = default(string), string sensitivity = default(string), string originalSensitivity = default(string), bool enableTeams = false, bool originalEnableTeams = false, List<RequestMetadata> groupMetadatas = default(List<RequestMetadata>), List<RequestMetadata> originalGroupMetadata = default(List<RequestMetadata>), AddGroupMemberType? changedDynamicGroupType = default(AddGroupMemberType?), string yammerGroupInfo = default(string), GroupObjectType? groupObjectType = default(GroupObjectType?), string networkId = default(string), string groupObjectId = default(string), bool enableTeamCollaboration = false, Guid? id = default(Guid?), Guid serviceId = default(Guid), string department = default(string), string summary = default(string), string notesToApprovers = default(string), Guid? questionnaireId = default(Guid?), List<RequestMetadata> metadatas = default(List<RequestMetadata>))
        {
            this.GroupId = groupId;
            this.GroupEmail = groupEmail;
            this.GroupName = groupName;
            this.OriginalGroupName = originalGroupName;
            this.GroupDescription = groupDescription;
            this.OriginalGroupDescription = originalGroupDescription;
            this.OriginalYammerGroupInfo = originalYammerGroupInfo;
            this.PrimaryContact = primaryContact;
            this.OriginalPrimaryContact = originalPrimaryContact;
            this.SecondaryContact = secondaryContact;
            this.OriginalSecondaryContact = originalSecondaryContact;
            this.GroupOwners = groupOwners;
            this.GroupMembers = groupMembers;
            this.IsDynamicMembership = isDynamicMembership;
            this.DynamicMembershipRules = dynamicMembershipRules;
            this.EnabledSubscribe = enabledSubscribe;
            this.OriginalEnabledSubscribe = originalEnabledSubscribe;
            this.EnabledOutsideSender = enabledOutsideSender;
            this.OriginalEnabledOutsideSender = originalEnabledOutsideSender;
            this.HubSiteActionType = hubSiteActionType;
            this.AssociateHubSiteId = associateHubSiteId;
            this.AssociateHubSiteTitle = associateHubSiteTitle;
            this.Classification = classification;
            this.OriginalClassification = originalClassification;
            this.Sensitivity = sensitivity;
            this.OriginalSensitivity = originalSensitivity;
            this.EnableTeams = enableTeams;
            this.OriginalEnableTeams = originalEnableTeams;
            this.GroupMetadatas = groupMetadatas;
            this.OriginalGroupMetadata = originalGroupMetadata;
            this.ChangedDynamicGroupType = changedDynamicGroupType;
            this.YammerGroupInfo = yammerGroupInfo;
            this.GroupObjectType = groupObjectType;
            this.NetworkId = networkId;
            this.GroupObjectId = groupObjectId;
            this.EnableTeamCollaboration = enableTeamCollaboration;
            this.Id = id;
            this.ServiceId = serviceId;
            this.Department = department;
            this.Summary = summary;
            this.NotesToApprovers = notesToApprovers;
            this.QuestionnaireId = questionnaireId;
            this.Metadatas = metadatas;
        }

        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name = "groupId", EmitDefaultValue = false)]
        public Guid GroupId { get; set; }

        /// <summary>
        /// Gets or Sets GroupEmail
        /// </summary>
        [DataMember(Name = "groupEmail", EmitDefaultValue = true)]
        public string GroupEmail { get; set; }

        /// <summary>
        /// Gets or Sets GroupName
        /// </summary>
        [DataMember(Name = "groupName", EmitDefaultValue = true)]
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or Sets OriginalGroupName
        /// </summary>
        [DataMember(Name = "originalGroupName", EmitDefaultValue = true)]
        public string OriginalGroupName { get; set; }

        /// <summary>
        /// Gets or Sets GroupDescription
        /// </summary>
        [DataMember(Name = "groupDescription", EmitDefaultValue = true)]
        public string GroupDescription { get; set; }

        /// <summary>
        /// Gets or Sets OriginalGroupDescription
        /// </summary>
        [DataMember(Name = "originalGroupDescription", EmitDefaultValue = true)]
        public string OriginalGroupDescription { get; set; }

        /// <summary>
        /// Gets or Sets OriginalYammerGroupInfo
        /// </summary>
        [DataMember(Name = "originalYammerGroupInfo", EmitDefaultValue = true)]
        public string OriginalYammerGroupInfo { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryContact
        /// </summary>
        [DataMember(Name = "primaryContact", EmitDefaultValue = true)]
        public ApiUser PrimaryContact { get; set; }

        /// <summary>
        /// Gets or Sets OriginalPrimaryContact
        /// </summary>
        [DataMember(Name = "originalPrimaryContact", EmitDefaultValue = true)]
        public ApiUser OriginalPrimaryContact { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryContact
        /// </summary>
        [DataMember(Name = "secondaryContact", EmitDefaultValue = true)]
        public ApiUser SecondaryContact { get; set; }

        /// <summary>
        /// Gets or Sets OriginalSecondaryContact
        /// </summary>
        [DataMember(Name = "originalSecondaryContact", EmitDefaultValue = true)]
        public ApiUser OriginalSecondaryContact { get; set; }

        /// <summary>
        /// Gets or Sets GroupOwners
        /// </summary>
        [DataMember(Name = "groupOwners", EmitDefaultValue = true)]
        public List<GroupMembershipItem> GroupOwners { get; set; }

        /// <summary>
        /// Gets or Sets GroupMembers
        /// </summary>
        [DataMember(Name = "groupMembers", EmitDefaultValue = true)]
        public List<GroupMembershipItem> GroupMembers { get; set; }

        /// <summary>
        /// Gets or Sets IsDynamicMembership
        /// </summary>
        [DataMember(Name = "isDynamicMembership", EmitDefaultValue = false)]
        public bool IsDynamicMembership { get; set; }

        /// <summary>
        /// Gets or Sets DynamicMembershipRules
        /// </summary>
        [DataMember(Name = "dynamicMembershipRules", EmitDefaultValue = true)]
        public List<DynamicGroupRuleInfo> DynamicMembershipRules { get; set; }

        /// <summary>
        /// Gets or Sets EnabledSubscribe
        /// </summary>
        [DataMember(Name = "enabledSubscribe", EmitDefaultValue = false)]
        public bool EnabledSubscribe { get; set; }

        /// <summary>
        /// Gets or Sets OriginalEnabledSubscribe
        /// </summary>
        [DataMember(Name = "originalEnabledSubscribe", EmitDefaultValue = false)]
        public bool OriginalEnabledSubscribe { get; set; }

        /// <summary>
        /// Gets or Sets EnabledOutsideSender
        /// </summary>
        [DataMember(Name = "enabledOutsideSender", EmitDefaultValue = false)]
        public bool EnabledOutsideSender { get; set; }

        /// <summary>
        /// Gets or Sets OriginalEnabledOutsideSender
        /// </summary>
        [DataMember(Name = "originalEnabledOutsideSender", EmitDefaultValue = false)]
        public bool OriginalEnabledOutsideSender { get; set; }

        /// <summary>
        /// Gets or Sets AssociateHubSiteId
        /// </summary>
        [DataMember(Name = "associateHubSiteId", EmitDefaultValue = true)]
        public Guid? AssociateHubSiteId { get; set; }

        /// <summary>
        /// Gets or Sets AssociateHubSiteTitle
        /// </summary>
        [DataMember(Name = "associateHubSiteTitle", EmitDefaultValue = true)]
        public string AssociateHubSiteTitle { get; set; }

        /// <summary>
        /// Gets or Sets Classification
        /// </summary>
        [DataMember(Name = "classification", EmitDefaultValue = true)]
        public string Classification { get; set; }

        /// <summary>
        /// Gets or Sets OriginalClassification
        /// </summary>
        [DataMember(Name = "originalClassification", EmitDefaultValue = true)]
        public string OriginalClassification { get; set; }

        /// <summary>
        /// Gets or Sets Sensitivity
        /// </summary>
        [DataMember(Name = "sensitivity", EmitDefaultValue = true)]
        public string Sensitivity { get; set; }

        /// <summary>
        /// Gets or Sets OriginalSensitivity
        /// </summary>
        [DataMember(Name = "originalSensitivity", EmitDefaultValue = true)]
        public string OriginalSensitivity { get; set; }

        /// <summary>
        /// Gets or Sets EnableTeams
        /// </summary>
        [DataMember(Name = "enableTeams", EmitDefaultValue = false)]
        public bool EnableTeams { get; set; }

        /// <summary>
        /// Gets or Sets OriginalEnableTeams
        /// </summary>
        [DataMember(Name = "originalEnableTeams", EmitDefaultValue = false)]
        public bool OriginalEnableTeams { get; set; }

        /// <summary>
        /// Gets or Sets GroupMetadatas
        /// </summary>
        [DataMember(Name = "groupMetadatas", EmitDefaultValue = true)]
        public List<RequestMetadata> GroupMetadatas { get; set; }

        /// <summary>
        /// Gets or Sets OriginalGroupMetadata
        /// </summary>
        [DataMember(Name = "originalGroupMetadata", EmitDefaultValue = true)]
        public List<RequestMetadata> OriginalGroupMetadata { get; set; }

        /// <summary>
        /// Gets or Sets YammerGroupInfo
        /// </summary>
        [DataMember(Name = "yammerGroupInfo", EmitDefaultValue = true)]
        public string YammerGroupInfo { get; set; }

        /// <summary>
        /// Gets or Sets NetworkId
        /// </summary>
        [DataMember(Name = "networkId", EmitDefaultValue = true)]
        public string NetworkId { get; set; }

        /// <summary>
        /// Gets or Sets GroupObjectId
        /// </summary>
        [DataMember(Name = "groupObjectId", EmitDefaultValue = true)]
        public string GroupObjectId { get; set; }

        /// <summary>
        /// Gets or Sets EnableTeamCollaboration
        /// </summary>
        [DataMember(Name = "enableTeamCollaboration", EmitDefaultValue = false)]
        public bool EnableTeamCollaboration { get; set; }

        /// <summary>
        /// Id of request.
        /// </summary>
        /// <value>Id of request.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Id of service.
        /// </summary>
        /// <value>Id of service.</value>
        [DataMember(Name = "serviceId", EmitDefaultValue = false)]
        public Guid ServiceId { get; set; }

        /// <summary>
        /// Department of requester.
        /// </summary>
        /// <value>Department of requester.</value>
        [DataMember(Name = "department", EmitDefaultValue = true)]
        public string Department { get; set; }

        /// <summary>
        /// Summary of request.
        /// </summary>
        /// <value>Summary of request.</value>
        [DataMember(Name = "summary", EmitDefaultValue = true)]
        public string Summary { get; set; }

        /// <summary>
        /// Notes to approvers.
        /// </summary>
        /// <value>Notes to approvers.</value>
        [DataMember(Name = "notesToApprovers", EmitDefaultValue = true)]
        public string NotesToApprovers { get; set; }

        /// <summary>
        /// Id of questionnaire
        /// </summary>
        /// <value>Id of questionnaire</value>
        [DataMember(Name = "questionnaireId", EmitDefaultValue = true)]
        public Guid? QuestionnaireId { get; set; }

        /// <summary>
        /// Metadata of request.
        /// </summary>
        /// <value>Metadata of request.</value>
        [DataMember(Name = "metadatas", EmitDefaultValue = true)]
        public List<RequestMetadata> Metadatas { get; set; }

        /// <summary>
        /// Ticket number of request.
        /// </summary>
        /// <value>Ticket number of request.</value>
        [DataMember(Name = "ticketNumber", EmitDefaultValue = true)]
        public int? TicketNumber { get; private set; }

        /// <summary>
        /// Returns false as TicketNumber should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTicketNumber()
        {
            return false;
        }

        /// <summary>
        /// Service type description of request.
        /// </summary>
        /// <value>Service type description of request.</value>
        [DataMember(Name = "typeDescription", EmitDefaultValue = true)]
        public string TypeDescription { get; private set; }

        /// <summary>
        /// Returns false as TypeDescription should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTypeDescription()
        {
            return false;
        }

        /// <summary>
        /// Requester display name.
        /// </summary>
        /// <value>Requester display name.</value>
        [DataMember(Name = "requester", EmitDefaultValue = true)]
        public string Requester { get; private set; }

        /// <summary>
        /// Returns false as Requester should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRequester()
        {
            return false;
        }

        /// <summary>
        /// Requester login name.
        /// </summary>
        /// <value>Requester login name.</value>
        [DataMember(Name = "requesterLoginName", EmitDefaultValue = true)]
        public string RequesterLoginName { get; private set; }

        /// <summary>
        /// Returns false as RequesterLoginName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRequesterLoginName()
        {
            return false;
        }

        /// <summary>
        /// Progress status of request.
        /// </summary>
        /// <value>Progress status of request.</value>
        [DataMember(Name = "progressStatus", EmitDefaultValue = false)]
        public int ProgressStatus { get; private set; }

        /// <summary>
        /// Returns false as ProgressStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProgressStatus()
        {
            return false;
        }

        /// <summary>
        /// Progress status description of request.
        /// </summary>
        /// <value>Progress status description of request.</value>
        [DataMember(Name = "progressStatusDescription", EmitDefaultValue = true)]
        public string ProgressStatusDescription { get; private set; }

        /// <summary>
        /// Returns false as ProgressStatusDescription should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProgressStatusDescription()
        {
            return false;
        }

        /// <summary>
        /// Submitted time of request.
        /// </summary>
        /// <value>Submitted time of request.</value>
        [DataMember(Name = "submittedTime", EmitDefaultValue = true)]
        public DateTime? SubmittedTime { get; private set; }

        /// <summary>
        /// Returns false as SubmittedTime should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSubmittedTime()
        {
            return false;
        }

        /// <summary>
        /// Last updated time of request.
        /// </summary>
        /// <value>Last updated time of request.</value>
        [DataMember(Name = "lastUpdated", EmitDefaultValue = true)]
        public DateTime? LastUpdated { get; private set; }

        /// <summary>
        /// Returns false as LastUpdated should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastUpdated()
        {
            return false;
        }

        /// <summary>
        /// Created time of request.
        /// </summary>
        /// <value>Created time of request.</value>
        [DataMember(Name = "createdTime", EmitDefaultValue = true)]
        public DateTime? CreatedTime { get; private set; }

        /// <summary>
        /// Returns false as CreatedTime should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedTime()
        {
            return false;
        }

        /// <summary>
        /// Task assignee of request.
        /// </summary>
        /// <value>Task assignee of request.</value>
        [DataMember(Name = "assignTo", EmitDefaultValue = true)]
        public string AssignTo { get; private set; }

        /// <summary>
        /// Returns false as AssignTo should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAssignTo()
        {
            return false;
        }

        /// <summary>
        /// Object full path of request.
        /// </summary>
        /// <value>Object full path of request.</value>
        [DataMember(Name = "fullPath", EmitDefaultValue = true)]
        public string FullPath { get; private set; }

        /// <summary>
        /// Returns false as FullPath should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFullPath()
        {
            return false;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeGroupSettingRequest {\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  GroupEmail: ").Append(GroupEmail).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  OriginalGroupName: ").Append(OriginalGroupName).Append("\n");
            sb.Append("  GroupDescription: ").Append(GroupDescription).Append("\n");
            sb.Append("  OriginalGroupDescription: ").Append(OriginalGroupDescription).Append("\n");
            sb.Append("  OriginalYammerGroupInfo: ").Append(OriginalYammerGroupInfo).Append("\n");
            sb.Append("  PrimaryContact: ").Append(PrimaryContact).Append("\n");
            sb.Append("  OriginalPrimaryContact: ").Append(OriginalPrimaryContact).Append("\n");
            sb.Append("  SecondaryContact: ").Append(SecondaryContact).Append("\n");
            sb.Append("  OriginalSecondaryContact: ").Append(OriginalSecondaryContact).Append("\n");
            sb.Append("  GroupOwners: ").Append(GroupOwners).Append("\n");
            sb.Append("  GroupMembers: ").Append(GroupMembers).Append("\n");
            sb.Append("  IsDynamicMembership: ").Append(IsDynamicMembership).Append("\n");
            sb.Append("  DynamicMembershipRules: ").Append(DynamicMembershipRules).Append("\n");
            sb.Append("  EnabledSubscribe: ").Append(EnabledSubscribe).Append("\n");
            sb.Append("  OriginalEnabledSubscribe: ").Append(OriginalEnabledSubscribe).Append("\n");
            sb.Append("  EnabledOutsideSender: ").Append(EnabledOutsideSender).Append("\n");
            sb.Append("  OriginalEnabledOutsideSender: ").Append(OriginalEnabledOutsideSender).Append("\n");
            sb.Append("  HubSiteActionType: ").Append(HubSiteActionType).Append("\n");
            sb.Append("  AssociateHubSiteId: ").Append(AssociateHubSiteId).Append("\n");
            sb.Append("  AssociateHubSiteTitle: ").Append(AssociateHubSiteTitle).Append("\n");
            sb.Append("  Classification: ").Append(Classification).Append("\n");
            sb.Append("  OriginalClassification: ").Append(OriginalClassification).Append("\n");
            sb.Append("  Sensitivity: ").Append(Sensitivity).Append("\n");
            sb.Append("  OriginalSensitivity: ").Append(OriginalSensitivity).Append("\n");
            sb.Append("  EnableTeams: ").Append(EnableTeams).Append("\n");
            sb.Append("  OriginalEnableTeams: ").Append(OriginalEnableTeams).Append("\n");
            sb.Append("  GroupMetadatas: ").Append(GroupMetadatas).Append("\n");
            sb.Append("  OriginalGroupMetadata: ").Append(OriginalGroupMetadata).Append("\n");
            sb.Append("  ChangedDynamicGroupType: ").Append(ChangedDynamicGroupType).Append("\n");
            sb.Append("  YammerGroupInfo: ").Append(YammerGroupInfo).Append("\n");
            sb.Append("  GroupObjectType: ").Append(GroupObjectType).Append("\n");
            sb.Append("  NetworkId: ").Append(NetworkId).Append("\n");
            sb.Append("  GroupObjectId: ").Append(GroupObjectId).Append("\n");
            sb.Append("  EnableTeamCollaboration: ").Append(EnableTeamCollaboration).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  NotesToApprovers: ").Append(NotesToApprovers).Append("\n");
            sb.Append("  QuestionnaireId: ").Append(QuestionnaireId).Append("\n");
            sb.Append("  Metadatas: ").Append(Metadatas).Append("\n");
            sb.Append("  TicketNumber: ").Append(TicketNumber).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TypeDescription: ").Append(TypeDescription).Append("\n");
            sb.Append("  Requester: ").Append(Requester).Append("\n");
            sb.Append("  RequesterLoginName: ").Append(RequesterLoginName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ProgressStatus: ").Append(ProgressStatus).Append("\n");
            sb.Append("  ProgressStatusDescription: ").Append(ProgressStatusDescription).Append("\n");
            sb.Append("  SubmittedTime: ").Append(SubmittedTime).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  AssignTo: ").Append(AssignTo).Append("\n");
            sb.Append("  FullPath: ").Append(FullPath).Append("\n");
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
            return this.Equals(input as ChangeGroupSettingRequest);
        }

        /// <summary>
        /// Returns true if ChangeGroupSettingRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeGroupSettingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeGroupSettingRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.GroupEmail == input.GroupEmail ||
                    (this.GroupEmail != null &&
                    this.GroupEmail.Equals(input.GroupEmail))
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.OriginalGroupName == input.OriginalGroupName ||
                    (this.OriginalGroupName != null &&
                    this.OriginalGroupName.Equals(input.OriginalGroupName))
                ) && 
                (
                    this.GroupDescription == input.GroupDescription ||
                    (this.GroupDescription != null &&
                    this.GroupDescription.Equals(input.GroupDescription))
                ) && 
                (
                    this.OriginalGroupDescription == input.OriginalGroupDescription ||
                    (this.OriginalGroupDescription != null &&
                    this.OriginalGroupDescription.Equals(input.OriginalGroupDescription))
                ) && 
                (
                    this.OriginalYammerGroupInfo == input.OriginalYammerGroupInfo ||
                    (this.OriginalYammerGroupInfo != null &&
                    this.OriginalYammerGroupInfo.Equals(input.OriginalYammerGroupInfo))
                ) && 
                (
                    this.PrimaryContact == input.PrimaryContact ||
                    (this.PrimaryContact != null &&
                    this.PrimaryContact.Equals(input.PrimaryContact))
                ) && 
                (
                    this.OriginalPrimaryContact == input.OriginalPrimaryContact ||
                    (this.OriginalPrimaryContact != null &&
                    this.OriginalPrimaryContact.Equals(input.OriginalPrimaryContact))
                ) && 
                (
                    this.SecondaryContact == input.SecondaryContact ||
                    (this.SecondaryContact != null &&
                    this.SecondaryContact.Equals(input.SecondaryContact))
                ) && 
                (
                    this.OriginalSecondaryContact == input.OriginalSecondaryContact ||
                    (this.OriginalSecondaryContact != null &&
                    this.OriginalSecondaryContact.Equals(input.OriginalSecondaryContact))
                ) && 
                (
                    this.GroupOwners == input.GroupOwners ||
                    this.GroupOwners != null &&
                    input.GroupOwners != null &&
                    this.GroupOwners.SequenceEqual(input.GroupOwners)
                ) && 
                (
                    this.GroupMembers == input.GroupMembers ||
                    this.GroupMembers != null &&
                    input.GroupMembers != null &&
                    this.GroupMembers.SequenceEqual(input.GroupMembers)
                ) && 
                (
                    this.IsDynamicMembership == input.IsDynamicMembership ||
                    this.IsDynamicMembership.Equals(input.IsDynamicMembership)
                ) && 
                (
                    this.DynamicMembershipRules == input.DynamicMembershipRules ||
                    this.DynamicMembershipRules != null &&
                    input.DynamicMembershipRules != null &&
                    this.DynamicMembershipRules.SequenceEqual(input.DynamicMembershipRules)
                ) && 
                (
                    this.EnabledSubscribe == input.EnabledSubscribe ||
                    this.EnabledSubscribe.Equals(input.EnabledSubscribe)
                ) && 
                (
                    this.OriginalEnabledSubscribe == input.OriginalEnabledSubscribe ||
                    this.OriginalEnabledSubscribe.Equals(input.OriginalEnabledSubscribe)
                ) && 
                (
                    this.EnabledOutsideSender == input.EnabledOutsideSender ||
                    this.EnabledOutsideSender.Equals(input.EnabledOutsideSender)
                ) && 
                (
                    this.OriginalEnabledOutsideSender == input.OriginalEnabledOutsideSender ||
                    this.OriginalEnabledOutsideSender.Equals(input.OriginalEnabledOutsideSender)
                ) && 
                (
                    this.HubSiteActionType == input.HubSiteActionType ||
                    this.HubSiteActionType.Equals(input.HubSiteActionType)
                ) && 
                (
                    this.AssociateHubSiteId == input.AssociateHubSiteId ||
                    (this.AssociateHubSiteId != null &&
                    this.AssociateHubSiteId.Equals(input.AssociateHubSiteId))
                ) && 
                (
                    this.AssociateHubSiteTitle == input.AssociateHubSiteTitle ||
                    (this.AssociateHubSiteTitle != null &&
                    this.AssociateHubSiteTitle.Equals(input.AssociateHubSiteTitle))
                ) && 
                (
                    this.Classification == input.Classification ||
                    (this.Classification != null &&
                    this.Classification.Equals(input.Classification))
                ) && 
                (
                    this.OriginalClassification == input.OriginalClassification ||
                    (this.OriginalClassification != null &&
                    this.OriginalClassification.Equals(input.OriginalClassification))
                ) && 
                (
                    this.Sensitivity == input.Sensitivity ||
                    (this.Sensitivity != null &&
                    this.Sensitivity.Equals(input.Sensitivity))
                ) && 
                (
                    this.OriginalSensitivity == input.OriginalSensitivity ||
                    (this.OriginalSensitivity != null &&
                    this.OriginalSensitivity.Equals(input.OriginalSensitivity))
                ) && 
                (
                    this.EnableTeams == input.EnableTeams ||
                    this.EnableTeams.Equals(input.EnableTeams)
                ) && 
                (
                    this.OriginalEnableTeams == input.OriginalEnableTeams ||
                    this.OriginalEnableTeams.Equals(input.OriginalEnableTeams)
                ) && 
                (
                    this.GroupMetadatas == input.GroupMetadatas ||
                    this.GroupMetadatas != null &&
                    input.GroupMetadatas != null &&
                    this.GroupMetadatas.SequenceEqual(input.GroupMetadatas)
                ) && 
                (
                    this.OriginalGroupMetadata == input.OriginalGroupMetadata ||
                    this.OriginalGroupMetadata != null &&
                    input.OriginalGroupMetadata != null &&
                    this.OriginalGroupMetadata.SequenceEqual(input.OriginalGroupMetadata)
                ) && 
                (
                    this.ChangedDynamicGroupType == input.ChangedDynamicGroupType ||
                    this.ChangedDynamicGroupType.Equals(input.ChangedDynamicGroupType)
                ) && 
                (
                    this.YammerGroupInfo == input.YammerGroupInfo ||
                    (this.YammerGroupInfo != null &&
                    this.YammerGroupInfo.Equals(input.YammerGroupInfo))
                ) && 
                (
                    this.GroupObjectType == input.GroupObjectType ||
                    this.GroupObjectType.Equals(input.GroupObjectType)
                ) && 
                (
                    this.NetworkId == input.NetworkId ||
                    (this.NetworkId != null &&
                    this.NetworkId.Equals(input.NetworkId))
                ) && 
                (
                    this.GroupObjectId == input.GroupObjectId ||
                    (this.GroupObjectId != null &&
                    this.GroupObjectId.Equals(input.GroupObjectId))
                ) && 
                (
                    this.EnableTeamCollaboration == input.EnableTeamCollaboration ||
                    this.EnableTeamCollaboration.Equals(input.EnableTeamCollaboration)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ServiceId == input.ServiceId ||
                    (this.ServiceId != null &&
                    this.ServiceId.Equals(input.ServiceId))
                ) && 
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.NotesToApprovers == input.NotesToApprovers ||
                    (this.NotesToApprovers != null &&
                    this.NotesToApprovers.Equals(input.NotesToApprovers))
                ) && 
                (
                    this.QuestionnaireId == input.QuestionnaireId ||
                    (this.QuestionnaireId != null &&
                    this.QuestionnaireId.Equals(input.QuestionnaireId))
                ) && 
                (
                    this.Metadatas == input.Metadatas ||
                    this.Metadatas != null &&
                    input.Metadatas != null &&
                    this.Metadatas.SequenceEqual(input.Metadatas)
                ) && 
                (
                    this.TicketNumber == input.TicketNumber ||
                    (this.TicketNumber != null &&
                    this.TicketNumber.Equals(input.TicketNumber))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.TypeDescription == input.TypeDescription ||
                    (this.TypeDescription != null &&
                    this.TypeDescription.Equals(input.TypeDescription))
                ) && 
                (
                    this.Requester == input.Requester ||
                    (this.Requester != null &&
                    this.Requester.Equals(input.Requester))
                ) && 
                (
                    this.RequesterLoginName == input.RequesterLoginName ||
                    (this.RequesterLoginName != null &&
                    this.RequesterLoginName.Equals(input.RequesterLoginName))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.ProgressStatus == input.ProgressStatus ||
                    this.ProgressStatus.Equals(input.ProgressStatus)
                ) && 
                (
                    this.ProgressStatusDescription == input.ProgressStatusDescription ||
                    (this.ProgressStatusDescription != null &&
                    this.ProgressStatusDescription.Equals(input.ProgressStatusDescription))
                ) && 
                (
                    this.SubmittedTime == input.SubmittedTime ||
                    (this.SubmittedTime != null &&
                    this.SubmittedTime.Equals(input.SubmittedTime))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
                ) && 
                (
                    this.AssignTo == input.AssignTo ||
                    (this.AssignTo != null &&
                    this.AssignTo.Equals(input.AssignTo))
                ) && 
                (
                    this.FullPath == input.FullPath ||
                    (this.FullPath != null &&
                    this.FullPath.Equals(input.FullPath))
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
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.GroupEmail != null)
                    hashCode = hashCode * 59 + this.GroupEmail.GetHashCode();
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.OriginalGroupName != null)
                    hashCode = hashCode * 59 + this.OriginalGroupName.GetHashCode();
                if (this.GroupDescription != null)
                    hashCode = hashCode * 59 + this.GroupDescription.GetHashCode();
                if (this.OriginalGroupDescription != null)
                    hashCode = hashCode * 59 + this.OriginalGroupDescription.GetHashCode();
                if (this.OriginalYammerGroupInfo != null)
                    hashCode = hashCode * 59 + this.OriginalYammerGroupInfo.GetHashCode();
                if (this.PrimaryContact != null)
                    hashCode = hashCode * 59 + this.PrimaryContact.GetHashCode();
                if (this.OriginalPrimaryContact != null)
                    hashCode = hashCode * 59 + this.OriginalPrimaryContact.GetHashCode();
                if (this.SecondaryContact != null)
                    hashCode = hashCode * 59 + this.SecondaryContact.GetHashCode();
                if (this.OriginalSecondaryContact != null)
                    hashCode = hashCode * 59 + this.OriginalSecondaryContact.GetHashCode();
                if (this.GroupOwners != null)
                    hashCode = hashCode * 59 + this.GroupOwners.GetHashCode();
                if (this.GroupMembers != null)
                    hashCode = hashCode * 59 + this.GroupMembers.GetHashCode();
                hashCode = hashCode * 59 + this.IsDynamicMembership.GetHashCode();
                if (this.DynamicMembershipRules != null)
                    hashCode = hashCode * 59 + this.DynamicMembershipRules.GetHashCode();
                hashCode = hashCode * 59 + this.EnabledSubscribe.GetHashCode();
                hashCode = hashCode * 59 + this.OriginalEnabledSubscribe.GetHashCode();
                hashCode = hashCode * 59 + this.EnabledOutsideSender.GetHashCode();
                hashCode = hashCode * 59 + this.OriginalEnabledOutsideSender.GetHashCode();
                hashCode = hashCode * 59 + this.HubSiteActionType.GetHashCode();
                if (this.AssociateHubSiteId != null)
                    hashCode = hashCode * 59 + this.AssociateHubSiteId.GetHashCode();
                if (this.AssociateHubSiteTitle != null)
                    hashCode = hashCode * 59 + this.AssociateHubSiteTitle.GetHashCode();
                if (this.Classification != null)
                    hashCode = hashCode * 59 + this.Classification.GetHashCode();
                if (this.OriginalClassification != null)
                    hashCode = hashCode * 59 + this.OriginalClassification.GetHashCode();
                if (this.Sensitivity != null)
                    hashCode = hashCode * 59 + this.Sensitivity.GetHashCode();
                if (this.OriginalSensitivity != null)
                    hashCode = hashCode * 59 + this.OriginalSensitivity.GetHashCode();
                hashCode = hashCode * 59 + this.EnableTeams.GetHashCode();
                hashCode = hashCode * 59 + this.OriginalEnableTeams.GetHashCode();
                if (this.GroupMetadatas != null)
                    hashCode = hashCode * 59 + this.GroupMetadatas.GetHashCode();
                if (this.OriginalGroupMetadata != null)
                    hashCode = hashCode * 59 + this.OriginalGroupMetadata.GetHashCode();
                hashCode = hashCode * 59 + this.ChangedDynamicGroupType.GetHashCode();
                if (this.YammerGroupInfo != null)
                    hashCode = hashCode * 59 + this.YammerGroupInfo.GetHashCode();
                hashCode = hashCode * 59 + this.GroupObjectType.GetHashCode();
                if (this.NetworkId != null)
                    hashCode = hashCode * 59 + this.NetworkId.GetHashCode();
                if (this.GroupObjectId != null)
                    hashCode = hashCode * 59 + this.GroupObjectId.GetHashCode();
                hashCode = hashCode * 59 + this.EnableTeamCollaboration.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ServiceId != null)
                    hashCode = hashCode * 59 + this.ServiceId.GetHashCode();
                if (this.Department != null)
                    hashCode = hashCode * 59 + this.Department.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.NotesToApprovers != null)
                    hashCode = hashCode * 59 + this.NotesToApprovers.GetHashCode();
                if (this.QuestionnaireId != null)
                    hashCode = hashCode * 59 + this.QuestionnaireId.GetHashCode();
                if (this.Metadatas != null)
                    hashCode = hashCode * 59 + this.Metadatas.GetHashCode();
                if (this.TicketNumber != null)
                    hashCode = hashCode * 59 + this.TicketNumber.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TypeDescription != null)
                    hashCode = hashCode * 59 + this.TypeDescription.GetHashCode();
                if (this.Requester != null)
                    hashCode = hashCode * 59 + this.Requester.GetHashCode();
                if (this.RequesterLoginName != null)
                    hashCode = hashCode * 59 + this.RequesterLoginName.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.ProgressStatus.GetHashCode();
                if (this.ProgressStatusDescription != null)
                    hashCode = hashCode * 59 + this.ProgressStatusDescription.GetHashCode();
                if (this.SubmittedTime != null)
                    hashCode = hashCode * 59 + this.SubmittedTime.GetHashCode();
                if (this.LastUpdated != null)
                    hashCode = hashCode * 59 + this.LastUpdated.GetHashCode();
                if (this.CreatedTime != null)
                    hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.AssignTo != null)
                    hashCode = hashCode * 59 + this.AssignTo.GetHashCode();
                if (this.FullPath != null)
                    hashCode = hashCode * 59 + this.FullPath.GetHashCode();
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
            // Summary (string) maxLength
            if(this.Summary != null && this.Summary.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Summary, length must be less than 255.", new [] { "Summary" });
            }

            // NotesToApprovers (string) maxLength
            if(this.NotesToApprovers != null && this.NotesToApprovers.Length > 1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NotesToApprovers, length must be less than 1000.", new [] { "NotesToApprovers" });
            }

            yield break;
        }
    }

}
