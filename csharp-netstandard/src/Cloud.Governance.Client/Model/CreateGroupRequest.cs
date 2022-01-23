

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
    /// Create group request model
    /// </summary>
    [DataContract(Name = "CreateGroupRequest")]
    public partial class CreateGroupRequest : IEquatable<CreateGroupRequest>, IValidatableObject
    {
        /// <summary>
        /// Group type
        /// </summary>
        /// <value>Group type</value>
        [DataMember(Name = "groupType", EmitDefaultValue = false)]
        public CreateGroupType? GroupType { get; set; }
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
        /// Initializes a new instance of the <see cref="CreateGroupRequest" /> class.
        /// </summary>
        /// <param name="groupType">Group type.</param>
        /// <param name="groupId">An entire group ID.</param>
        /// <param name="groupIdWithoutPrefixSuffix">Group ID (without prefix and suffix).</param>
        /// <param name="groupName">An entire group name.</param>
        /// <param name="groupNameWithoutPrefixSuffix">Group name (without prefix and suffix).</param>
        /// <param name="policy">The ID of a group policy. You can get IDs and names of all available policies by invoking the GetCreateGroupServiceApi..</param>
        /// <param name="groupDescription">Group description.</param>
        /// <param name="owners">Group owners.</param>
        /// <param name="members">Group members.</param>
        /// <param name="privacy">The privacy settings of a group. Whether to allow anyone can see group content or only allow members to see group content. (default to false).</param>
        /// <param name="subscribe">Whether to allow group members to receive copies of group conversations and events. (default to false).</param>
        /// <param name="outsideSender">Whether to allow users outside the organization to send e-mails to groups. (default to false).</param>
        /// <param name="enableTeamCollaboration">Enable a team for the group. (default to false).</param>
        /// <param name="language">The language of a group. You can get IDs and names of all available languages by invoking the GetCreateGroupServiceApi..</param>
        /// <param name="classification">Group classification.</param>
        /// <param name="sensitivity">Group sensitive lable id.</param>
        /// <param name="sensitivityName">Group sensitive lable name.</param>
        /// <param name="leasePeriodSettings">Group lease period settings.</param>
        /// <param name="teamsSettings">Team members permission settings.</param>
        /// <param name="appliedSiteDesignId">The ID of the group team site design. You can get IDs and names of all group team sites by invoking the GetCreateGroupServiceApi..</param>
        /// <param name="primaryContact">Primary group contact.</param>
        /// <param name="secondaryContact">Secondary group contact.</param>
        /// <param name="enableGroupMembershipHidden">Whether to hide the group members from users who are not members of the group. (default to false).</param>
        /// <param name="enableAssignedMembership">Whether to allow to copy team members from existing teams. (default to false).</param>
        /// <param name="enableDynamicMembership">Whether to use dynamic membership rules to get group members. (default to false).</param>
        /// <param name="templateSettings">Teams template settings.</param>
        /// <param name="dynamicMembershipRules">Dynamic group membership rules.</param>
        /// <param name="multiGeoLocation">Multi-geo locations settings.</param>
        /// <param name="hubSiteSettings">Hub site settings.</param>
        /// <param name="yammerGroupInfo">Yammer community info.</param>
        /// <param name="id">Id of request..</param>
        /// <param name="serviceId">Id of service..</param>
        /// <param name="summary">Summary of request..</param>
        /// <param name="notesToApprovers">Notes to approvers..</param>
        /// <param name="questionnaireId">Id of questionnaire.</param>
        /// <param name="metadatas">Metadata of request..</param>
        public CreateGroupRequest(CreateGroupType? groupType = default(CreateGroupType?), string groupId = default(string), string groupIdWithoutPrefixSuffix = default(string), string groupName = default(string), string groupNameWithoutPrefixSuffix = default(string), Guid policy = default(Guid), string groupDescription = default(string), List<ApiUser> owners = default(List<ApiUser>), List<ApiUser> members = default(List<ApiUser>), bool privacy = false, bool subscribe = false, bool outsideSender = false, bool enableTeamCollaboration = false, string language = default(string), string classification = default(string), string sensitivity = default(string), string sensitivityName = default(string), GroupLeasePeriodSettings leasePeriodSettings = default(GroupLeasePeriodSettings), RequestTeamsSettings teamsSettings = default(RequestTeamsSettings), Guid? appliedSiteDesignId = default(Guid?), ApiUser primaryContact = default(ApiUser), ApiUser secondaryContact = default(ApiUser), bool enableGroupMembershipHidden = false, bool enableAssignedMembership = false, bool enableDynamicMembership = false, TeamsTemplateSettings templateSettings = default(TeamsTemplateSettings), List<DynamicGroupRuleInfo> dynamicMembershipRules = default(List<DynamicGroupRuleInfo>), GeoLocationBase multiGeoLocation = default(GeoLocationBase), HubSiteSettings hubSiteSettings = default(HubSiteSettings), string yammerGroupInfo = default(string), Guid? id = default(Guid?), Guid serviceId = default(Guid), string summary = default(string), string notesToApprovers = default(string), Guid? questionnaireId = default(Guid?), List<RequestMetadata> metadatas = default(List<RequestMetadata>))
        {
            this.GroupType = groupType;
            this.GroupId = groupId;
            this.GroupIdWithoutPrefixSuffix = groupIdWithoutPrefixSuffix;
            this.GroupName = groupName;
            this.GroupNameWithoutPrefixSuffix = groupNameWithoutPrefixSuffix;
            this.Policy = policy;
            this.GroupDescription = groupDescription;
            this.Owners = owners;
            this.Members = members;
            this.Privacy = privacy;
            this.Subscribe = subscribe;
            this.OutsideSender = outsideSender;
            this.EnableTeamCollaboration = enableTeamCollaboration;
            this.Language = language;
            this.Classification = classification;
            this.Sensitivity = sensitivity;
            this.SensitivityName = sensitivityName;
            this.LeasePeriodSettings = leasePeriodSettings;
            this.TeamsSettings = teamsSettings;
            this.AppliedSiteDesignId = appliedSiteDesignId;
            this.PrimaryContact = primaryContact;
            this.SecondaryContact = secondaryContact;
            this.EnableGroupMembershipHidden = enableGroupMembershipHidden;
            this.EnableAssignedMembership = enableAssignedMembership;
            this.EnableDynamicMembership = enableDynamicMembership;
            this.TemplateSettings = templateSettings;
            this.DynamicMembershipRules = dynamicMembershipRules;
            this.MultiGeoLocation = multiGeoLocation;
            this.HubSiteSettings = hubSiteSettings;
            this.YammerGroupInfo = yammerGroupInfo;
            this.Id = id;
            this.ServiceId = serviceId;
            this.Summary = summary;
            this.NotesToApprovers = notesToApprovers;
            this.QuestionnaireId = questionnaireId;
            this.Metadatas = metadatas;
        }

        /// <summary>
        /// An entire group ID
        /// </summary>
        /// <value>An entire group ID</value>
        [DataMember(Name = "groupId", EmitDefaultValue = true)]
        public string GroupId { get; set; }

        /// <summary>
        /// Group ID (without prefix and suffix)
        /// </summary>
        /// <value>Group ID (without prefix and suffix)</value>
        [DataMember(Name = "groupIdWithoutPrefixSuffix", EmitDefaultValue = true)]
        public string GroupIdWithoutPrefixSuffix { get; set; }

        /// <summary>
        /// An entire group name
        /// </summary>
        /// <value>An entire group name</value>
        [DataMember(Name = "groupName", EmitDefaultValue = true)]
        public string GroupName { get; set; }

        /// <summary>
        /// Group name (without prefix and suffix)
        /// </summary>
        /// <value>Group name (without prefix and suffix)</value>
        [DataMember(Name = "groupNameWithoutPrefixSuffix", EmitDefaultValue = true)]
        public string GroupNameWithoutPrefixSuffix { get; set; }

        /// <summary>
        /// Group e-mail address
        /// </summary>
        /// <value>Group e-mail address</value>
        [DataMember(Name = "groupEmail", EmitDefaultValue = true)]
        public string GroupEmail { get; private set; }

        /// <summary>
        /// Returns false as GroupEmail should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeGroupEmail()
        {
            return false;
        }

        /// <summary>
        /// The ID of a group policy. You can get IDs and names of all available policies by invoking the GetCreateGroupServiceApi.
        /// </summary>
        /// <value>The ID of a group policy. You can get IDs and names of all available policies by invoking the GetCreateGroupServiceApi.</value>
        [DataMember(Name = "policy", EmitDefaultValue = false)]
        public Guid Policy { get; set; }

        /// <summary>
        /// Group description
        /// </summary>
        /// <value>Group description</value>
        [DataMember(Name = "groupDescription", EmitDefaultValue = true)]
        public string GroupDescription { get; set; }

        /// <summary>
        /// Group owners
        /// </summary>
        /// <value>Group owners</value>
        [DataMember(Name = "owners", EmitDefaultValue = true)]
        public List<ApiUser> Owners { get; set; }

        /// <summary>
        /// Group members
        /// </summary>
        /// <value>Group members</value>
        [DataMember(Name = "members", EmitDefaultValue = true)]
        public List<ApiUser> Members { get; set; }

        /// <summary>
        /// The privacy settings of a group. Whether to allow anyone can see group content or only allow members to see group content.
        /// </summary>
        /// <value>The privacy settings of a group. Whether to allow anyone can see group content or only allow members to see group content.</value>
        [DataMember(Name = "privacy", EmitDefaultValue = false)]
        public bool Privacy { get; set; }

        /// <summary>
        /// Whether to allow group members to receive copies of group conversations and events.
        /// </summary>
        /// <value>Whether to allow group members to receive copies of group conversations and events.</value>
        [DataMember(Name = "subscribe", EmitDefaultValue = false)]
        public bool Subscribe { get; set; }

        /// <summary>
        /// Whether to allow users outside the organization to send e-mails to groups.
        /// </summary>
        /// <value>Whether to allow users outside the organization to send e-mails to groups.</value>
        [DataMember(Name = "outsideSender", EmitDefaultValue = false)]
        public bool OutsideSender { get; set; }

        /// <summary>
        /// Enable a team for the group.
        /// </summary>
        /// <value>Enable a team for the group.</value>
        [DataMember(Name = "enableTeamCollaboration", EmitDefaultValue = false)]
        public bool EnableTeamCollaboration { get; set; }

        /// <summary>
        /// The language of a group. You can get IDs and names of all available languages by invoking the GetCreateGroupServiceApi.
        /// </summary>
        /// <value>The language of a group. You can get IDs and names of all available languages by invoking the GetCreateGroupServiceApi.</value>
        [DataMember(Name = "language", EmitDefaultValue = true)]
        public string Language { get; set; }

        /// <summary>
        /// Group classification
        /// </summary>
        /// <value>Group classification</value>
        [DataMember(Name = "classification", EmitDefaultValue = true)]
        public string Classification { get; set; }

        /// <summary>
        /// Group sensitive lable id
        /// </summary>
        /// <value>Group sensitive lable id</value>
        [DataMember(Name = "sensitivity", EmitDefaultValue = true)]
        public string Sensitivity { get; set; }

        /// <summary>
        /// Group sensitive lable name
        /// </summary>
        /// <value>Group sensitive lable name</value>
        [DataMember(Name = "sensitivityName", EmitDefaultValue = true)]
        public string SensitivityName { get; set; }

        /// <summary>
        /// Links of the group related objects. You can get IDs and names of all group related objects by invoking the GetCreateGroupServiceApi.
        /// </summary>
        /// <value>Links of the group related objects. You can get IDs and names of all group related objects by invoking the GetCreateGroupServiceApi.</value>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public GroupLinks Links { get; private set; }

        /// <summary>
        /// Returns false as Links should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLinks()
        {
            return false;
        }

        /// <summary>
        /// Group lease period settings
        /// </summary>
        /// <value>Group lease period settings</value>
        [DataMember(Name = "leasePeriodSettings", EmitDefaultValue = true)]
        public GroupLeasePeriodSettings LeasePeriodSettings { get; set; }

        /// <summary>
        /// Team members permission settings
        /// </summary>
        /// <value>Team members permission settings</value>
        [DataMember(Name = "teamsSettings", EmitDefaultValue = true)]
        public RequestTeamsSettings TeamsSettings { get; set; }

        /// <summary>
        /// The ID of the group team site design. You can get IDs and names of all group team sites by invoking the GetCreateGroupServiceApi.
        /// </summary>
        /// <value>The ID of the group team site design. You can get IDs and names of all group team sites by invoking the GetCreateGroupServiceApi.</value>
        [DataMember(Name = "appliedSiteDesignId", EmitDefaultValue = true)]
        public Guid? AppliedSiteDesignId { get; set; }

        /// <summary>
        /// Primary group contact
        /// </summary>
        /// <value>Primary group contact</value>
        [DataMember(Name = "primaryContact", EmitDefaultValue = true)]
        public ApiUser PrimaryContact { get; set; }

        /// <summary>
        /// Secondary group contact
        /// </summary>
        /// <value>Secondary group contact</value>
        [DataMember(Name = "secondaryContact", EmitDefaultValue = true)]
        public ApiUser SecondaryContact { get; set; }

        /// <summary>
        /// Whether to hide the group members from users who are not members of the group.
        /// </summary>
        /// <value>Whether to hide the group members from users who are not members of the group.</value>
        [DataMember(Name = "enableGroupMembershipHidden", EmitDefaultValue = false)]
        public bool EnableGroupMembershipHidden { get; set; }

        /// <summary>
        /// Whether to allow to copy team members from existing teams.
        /// </summary>
        /// <value>Whether to allow to copy team members from existing teams.</value>
        [DataMember(Name = "enableAssignedMembership", EmitDefaultValue = false)]
        public bool EnableAssignedMembership { get; set; }

        /// <summary>
        /// Whether to use dynamic membership rules to get group members.
        /// </summary>
        /// <value>Whether to use dynamic membership rules to get group members.</value>
        [DataMember(Name = "enableDynamicMembership", EmitDefaultValue = false)]
        public bool EnableDynamicMembership { get; set; }

        /// <summary>
        /// Teams template settings
        /// </summary>
        /// <value>Teams template settings</value>
        [DataMember(Name = "templateSettings", EmitDefaultValue = true)]
        public TeamsTemplateSettings TemplateSettings { get; set; }

        /// <summary>
        /// Dynamic group membership rules
        /// </summary>
        /// <value>Dynamic group membership rules</value>
        [DataMember(Name = "dynamicMembershipRules", EmitDefaultValue = true)]
        public List<DynamicGroupRuleInfo> DynamicMembershipRules { get; set; }

        /// <summary>
        /// Multi-geo locations settings
        /// </summary>
        /// <value>Multi-geo locations settings</value>
        [DataMember(Name = "multiGeoLocation", EmitDefaultValue = true)]
        public GeoLocationBase MultiGeoLocation { get; set; }

        /// <summary>
        /// Hub site settings
        /// </summary>
        /// <value>Hub site settings</value>
        [DataMember(Name = "hubSiteSettings", EmitDefaultValue = true)]
        public HubSiteSettings HubSiteSettings { get; set; }

        /// <summary>
        /// Yammer community info
        /// </summary>
        /// <value>Yammer community info</value>
        [DataMember(Name = "yammerGroupInfo", EmitDefaultValue = true)]
        public string YammerGroupInfo { get; set; }

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
            sb.Append("class CreateGroupRequest {\n");
            sb.Append("  GroupType: ").Append(GroupType).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  GroupIdWithoutPrefixSuffix: ").Append(GroupIdWithoutPrefixSuffix).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  GroupNameWithoutPrefixSuffix: ").Append(GroupNameWithoutPrefixSuffix).Append("\n");
            sb.Append("  GroupEmail: ").Append(GroupEmail).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  GroupDescription: ").Append(GroupDescription).Append("\n");
            sb.Append("  Owners: ").Append(Owners).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  Privacy: ").Append(Privacy).Append("\n");
            sb.Append("  Subscribe: ").Append(Subscribe).Append("\n");
            sb.Append("  OutsideSender: ").Append(OutsideSender).Append("\n");
            sb.Append("  EnableTeamCollaboration: ").Append(EnableTeamCollaboration).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Classification: ").Append(Classification).Append("\n");
            sb.Append("  Sensitivity: ").Append(Sensitivity).Append("\n");
            sb.Append("  SensitivityName: ").Append(SensitivityName).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  LeasePeriodSettings: ").Append(LeasePeriodSettings).Append("\n");
            sb.Append("  TeamsSettings: ").Append(TeamsSettings).Append("\n");
            sb.Append("  AppliedSiteDesignId: ").Append(AppliedSiteDesignId).Append("\n");
            sb.Append("  PrimaryContact: ").Append(PrimaryContact).Append("\n");
            sb.Append("  SecondaryContact: ").Append(SecondaryContact).Append("\n");
            sb.Append("  EnableGroupMembershipHidden: ").Append(EnableGroupMembershipHidden).Append("\n");
            sb.Append("  EnableAssignedMembership: ").Append(EnableAssignedMembership).Append("\n");
            sb.Append("  EnableDynamicMembership: ").Append(EnableDynamicMembership).Append("\n");
            sb.Append("  TemplateSettings: ").Append(TemplateSettings).Append("\n");
            sb.Append("  DynamicMembershipRules: ").Append(DynamicMembershipRules).Append("\n");
            sb.Append("  MultiGeoLocation: ").Append(MultiGeoLocation).Append("\n");
            sb.Append("  HubSiteSettings: ").Append(HubSiteSettings).Append("\n");
            sb.Append("  YammerGroupInfo: ").Append(YammerGroupInfo).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
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
            return this.Equals(input as CreateGroupRequest);
        }

        /// <summary>
        /// Returns true if CreateGroupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateGroupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateGroupRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupType == input.GroupType ||
                    this.GroupType.Equals(input.GroupType)
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.GroupIdWithoutPrefixSuffix == input.GroupIdWithoutPrefixSuffix ||
                    (this.GroupIdWithoutPrefixSuffix != null &&
                    this.GroupIdWithoutPrefixSuffix.Equals(input.GroupIdWithoutPrefixSuffix))
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.GroupNameWithoutPrefixSuffix == input.GroupNameWithoutPrefixSuffix ||
                    (this.GroupNameWithoutPrefixSuffix != null &&
                    this.GroupNameWithoutPrefixSuffix.Equals(input.GroupNameWithoutPrefixSuffix))
                ) && 
                (
                    this.GroupEmail == input.GroupEmail ||
                    (this.GroupEmail != null &&
                    this.GroupEmail.Equals(input.GroupEmail))
                ) && 
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))
                ) && 
                (
                    this.GroupDescription == input.GroupDescription ||
                    (this.GroupDescription != null &&
                    this.GroupDescription.Equals(input.GroupDescription))
                ) && 
                (
                    this.Owners == input.Owners ||
                    this.Owners != null &&
                    input.Owners != null &&
                    this.Owners.SequenceEqual(input.Owners)
                ) && 
                (
                    this.Members == input.Members ||
                    this.Members != null &&
                    input.Members != null &&
                    this.Members.SequenceEqual(input.Members)
                ) && 
                (
                    this.Privacy == input.Privacy ||
                    this.Privacy.Equals(input.Privacy)
                ) && 
                (
                    this.Subscribe == input.Subscribe ||
                    this.Subscribe.Equals(input.Subscribe)
                ) && 
                (
                    this.OutsideSender == input.OutsideSender ||
                    this.OutsideSender.Equals(input.OutsideSender)
                ) && 
                (
                    this.EnableTeamCollaboration == input.EnableTeamCollaboration ||
                    this.EnableTeamCollaboration.Equals(input.EnableTeamCollaboration)
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Classification == input.Classification ||
                    (this.Classification != null &&
                    this.Classification.Equals(input.Classification))
                ) && 
                (
                    this.Sensitivity == input.Sensitivity ||
                    (this.Sensitivity != null &&
                    this.Sensitivity.Equals(input.Sensitivity))
                ) && 
                (
                    this.SensitivityName == input.SensitivityName ||
                    (this.SensitivityName != null &&
                    this.SensitivityName.Equals(input.SensitivityName))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.LeasePeriodSettings == input.LeasePeriodSettings ||
                    (this.LeasePeriodSettings != null &&
                    this.LeasePeriodSettings.Equals(input.LeasePeriodSettings))
                ) && 
                (
                    this.TeamsSettings == input.TeamsSettings ||
                    (this.TeamsSettings != null &&
                    this.TeamsSettings.Equals(input.TeamsSettings))
                ) && 
                (
                    this.AppliedSiteDesignId == input.AppliedSiteDesignId ||
                    (this.AppliedSiteDesignId != null &&
                    this.AppliedSiteDesignId.Equals(input.AppliedSiteDesignId))
                ) && 
                (
                    this.PrimaryContact == input.PrimaryContact ||
                    (this.PrimaryContact != null &&
                    this.PrimaryContact.Equals(input.PrimaryContact))
                ) && 
                (
                    this.SecondaryContact == input.SecondaryContact ||
                    (this.SecondaryContact != null &&
                    this.SecondaryContact.Equals(input.SecondaryContact))
                ) && 
                (
                    this.EnableGroupMembershipHidden == input.EnableGroupMembershipHidden ||
                    this.EnableGroupMembershipHidden.Equals(input.EnableGroupMembershipHidden)
                ) && 
                (
                    this.EnableAssignedMembership == input.EnableAssignedMembership ||
                    this.EnableAssignedMembership.Equals(input.EnableAssignedMembership)
                ) && 
                (
                    this.EnableDynamicMembership == input.EnableDynamicMembership ||
                    this.EnableDynamicMembership.Equals(input.EnableDynamicMembership)
                ) && 
                (
                    this.TemplateSettings == input.TemplateSettings ||
                    (this.TemplateSettings != null &&
                    this.TemplateSettings.Equals(input.TemplateSettings))
                ) && 
                (
                    this.DynamicMembershipRules == input.DynamicMembershipRules ||
                    this.DynamicMembershipRules != null &&
                    input.DynamicMembershipRules != null &&
                    this.DynamicMembershipRules.SequenceEqual(input.DynamicMembershipRules)
                ) && 
                (
                    this.MultiGeoLocation == input.MultiGeoLocation ||
                    (this.MultiGeoLocation != null &&
                    this.MultiGeoLocation.Equals(input.MultiGeoLocation))
                ) && 
                (
                    this.HubSiteSettings == input.HubSiteSettings ||
                    (this.HubSiteSettings != null &&
                    this.HubSiteSettings.Equals(input.HubSiteSettings))
                ) && 
                (
                    this.YammerGroupInfo == input.YammerGroupInfo ||
                    (this.YammerGroupInfo != null &&
                    this.YammerGroupInfo.Equals(input.YammerGroupInfo))
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
                hashCode = hashCode * 59 + this.GroupType.GetHashCode();
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.GroupIdWithoutPrefixSuffix != null)
                    hashCode = hashCode * 59 + this.GroupIdWithoutPrefixSuffix.GetHashCode();
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.GroupNameWithoutPrefixSuffix != null)
                    hashCode = hashCode * 59 + this.GroupNameWithoutPrefixSuffix.GetHashCode();
                if (this.GroupEmail != null)
                    hashCode = hashCode * 59 + this.GroupEmail.GetHashCode();
                if (this.Policy != null)
                    hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.GroupDescription != null)
                    hashCode = hashCode * 59 + this.GroupDescription.GetHashCode();
                if (this.Owners != null)
                    hashCode = hashCode * 59 + this.Owners.GetHashCode();
                if (this.Members != null)
                    hashCode = hashCode * 59 + this.Members.GetHashCode();
                hashCode = hashCode * 59 + this.Privacy.GetHashCode();
                hashCode = hashCode * 59 + this.Subscribe.GetHashCode();
                hashCode = hashCode * 59 + this.OutsideSender.GetHashCode();
                hashCode = hashCode * 59 + this.EnableTeamCollaboration.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Classification != null)
                    hashCode = hashCode * 59 + this.Classification.GetHashCode();
                if (this.Sensitivity != null)
                    hashCode = hashCode * 59 + this.Sensitivity.GetHashCode();
                if (this.SensitivityName != null)
                    hashCode = hashCode * 59 + this.SensitivityName.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.LeasePeriodSettings != null)
                    hashCode = hashCode * 59 + this.LeasePeriodSettings.GetHashCode();
                if (this.TeamsSettings != null)
                    hashCode = hashCode * 59 + this.TeamsSettings.GetHashCode();
                if (this.AppliedSiteDesignId != null)
                    hashCode = hashCode * 59 + this.AppliedSiteDesignId.GetHashCode();
                if (this.PrimaryContact != null)
                    hashCode = hashCode * 59 + this.PrimaryContact.GetHashCode();
                if (this.SecondaryContact != null)
                    hashCode = hashCode * 59 + this.SecondaryContact.GetHashCode();
                hashCode = hashCode * 59 + this.EnableGroupMembershipHidden.GetHashCode();
                hashCode = hashCode * 59 + this.EnableAssignedMembership.GetHashCode();
                hashCode = hashCode * 59 + this.EnableDynamicMembership.GetHashCode();
                if (this.TemplateSettings != null)
                    hashCode = hashCode * 59 + this.TemplateSettings.GetHashCode();
                if (this.DynamicMembershipRules != null)
                    hashCode = hashCode * 59 + this.DynamicMembershipRules.GetHashCode();
                if (this.MultiGeoLocation != null)
                    hashCode = hashCode * 59 + this.MultiGeoLocation.GetHashCode();
                if (this.HubSiteSettings != null)
                    hashCode = hashCode * 59 + this.HubSiteSettings.GetHashCode();
                if (this.YammerGroupInfo != null)
                    hashCode = hashCode * 59 + this.YammerGroupInfo.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ServiceId != null)
                    hashCode = hashCode * 59 + this.ServiceId.GetHashCode();
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
            yield break;
        }
    }

}
