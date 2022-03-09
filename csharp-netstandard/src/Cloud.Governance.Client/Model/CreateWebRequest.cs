

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
    /// CreateWebRequest
    /// </summary>
    [DataContract(Name = "CreateWebRequest")]
    public partial class CreateWebRequest : IEquatable<CreateWebRequest>, IValidatableObject
    {
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
        /// Initializes a new instance of the <see cref="CreateWebRequest" /> class.
        /// </summary>
        /// <param name="webName">webName.</param>
        /// <param name="webTitle">webTitle.</param>
        /// <param name="webDescription">webDescription.</param>
        /// <param name="webLanguage">webLanguage.</param>
        /// <param name="webTemplate">webTemplate.</param>
        /// <param name="parentSiteUrl">parentSiteUrl.</param>
        /// <param name="parentWebUrl">parentWebUrl.</param>
        /// <param name="primaryContact">ApiUser model.</param>
        /// <param name="secondaryContact">ApiUser model.</param>
        /// <param name="userPermissions">userPermissions.</param>
        /// <param name="groupPermissions">groupPermissions.</param>
        /// <param name="yammerGroupSettings">Yammer community request settings model.</param>
        /// <param name="isOnQuickLaunch">isOnQuickLaunch (default to false).</param>
        /// <param name="isOnTopLinkBar">isOnTopLinkBar (default to false).</param>
        /// <param name="isInheritance">isInheritance (default to false).</param>
        /// <param name="deploymentManagerPlanName">deploymentManagerPlanName.</param>
        /// <param name="id">Id of request..</param>
        /// <param name="serviceId">Id of service..</param>
        /// <param name="summary">Summary of request..</param>
        /// <param name="notesToApprovers">Notes to approvers..</param>
        /// <param name="questionnaireId">Id of questionnaire.</param>
        /// <param name="questionnaireResponse">Questionnaire question and answer of request..</param>
        /// <param name="metadatas">Metadata of request..</param>
        public CreateWebRequest(string webName = default(string), string webTitle = default(string), string webDescription = default(string), IntModel webLanguage = default(IntModel), string webTemplate = default(string), string parentSiteUrl = default(string), string parentWebUrl = default(string), ApiUser primaryContact = default(ApiUser), ApiUser secondaryContact = default(ApiUser), List<RequestUserWithPermissions> userPermissions = default(List<RequestUserWithPermissions>), List<RequestGroupWithPermissions> groupPermissions = default(List<RequestGroupWithPermissions>), YammerGroupRequestSettings yammerGroupSettings = default(YammerGroupRequestSettings), bool isOnQuickLaunch = false, bool isOnTopLinkBar = false, bool isInheritance = false, string deploymentManagerPlanName = default(string), Guid? id = default(Guid?), Guid serviceId = default(Guid), string summary = default(string), string notesToApprovers = default(string), Guid? questionnaireId = default(Guid?), List<QuestionAnswerResponse> questionnaireResponse = default(List<QuestionAnswerResponse>), List<RequestMetadata> metadatas = default(List<RequestMetadata>))
        {
            this.WebName = webName;
            this.WebTitle = webTitle;
            this.WebDescription = webDescription;
            this.WebLanguage = webLanguage;
            this.WebTemplate = webTemplate;
            this.ParentSiteUrl = parentSiteUrl;
            this.ParentWebUrl = parentWebUrl;
            this.PrimaryContact = primaryContact;
            this.SecondaryContact = secondaryContact;
            this.UserPermissions = userPermissions;
            this.GroupPermissions = groupPermissions;
            this.YammerGroupSettings = yammerGroupSettings;
            this.IsOnQuickLaunch = isOnQuickLaunch;
            this.IsOnTopLinkBar = isOnTopLinkBar;
            this.IsInheritance = isInheritance;
            this.DeploymentManagerPlanName = deploymentManagerPlanName;
            this.Id = id;
            this.ServiceId = serviceId;
            this.Summary = summary;
            this.NotesToApprovers = notesToApprovers;
            this.QuestionnaireId = questionnaireId;
            this.QuestionnaireResponse = questionnaireResponse;
            this.Metadatas = metadatas;
        }

        /// <summary>
        /// Gets or Sets WebName
        /// </summary>
        [DataMember(Name = "webName", EmitDefaultValue = true)]
        public string WebName { get; set; }

        /// <summary>
        /// Gets or Sets WebTitle
        /// </summary>
        [DataMember(Name = "webTitle", EmitDefaultValue = true)]
        public string WebTitle { get; set; }

        /// <summary>
        /// Gets or Sets WebDescription
        /// </summary>
        [DataMember(Name = "webDescription", EmitDefaultValue = true)]
        public string WebDescription { get; set; }

        /// <summary>
        /// Gets or Sets WebLanguage
        /// </summary>
        [DataMember(Name = "webLanguage", EmitDefaultValue = true)]
        public IntModel WebLanguage { get; set; }

        /// <summary>
        /// Gets or Sets WebTemplate
        /// </summary>
        [DataMember(Name = "webTemplate", EmitDefaultValue = true)]
        public string WebTemplate { get; set; }

        /// <summary>
        /// Gets or Sets ParentSiteUrl
        /// </summary>
        [DataMember(Name = "parentSiteUrl", EmitDefaultValue = true)]
        public string ParentSiteUrl { get; set; }

        /// <summary>
        /// Gets or Sets ParentWebUrl
        /// </summary>
        [DataMember(Name = "parentWebUrl", EmitDefaultValue = true)]
        public string ParentWebUrl { get; set; }

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
        /// Gets or Sets UserPermissions
        /// </summary>
        [DataMember(Name = "userPermissions", EmitDefaultValue = true)]
        public List<RequestUserWithPermissions> UserPermissions { get; set; }

        /// <summary>
        /// Gets or Sets GroupPermissions
        /// </summary>
        [DataMember(Name = "groupPermissions", EmitDefaultValue = true)]
        public List<RequestGroupWithPermissions> GroupPermissions { get; set; }

        /// <summary>
        /// Yammer community request settings model
        /// </summary>
        /// <value>Yammer community request settings model</value>
        [DataMember(Name = "yammerGroupSettings", EmitDefaultValue = true)]
        public YammerGroupRequestSettings YammerGroupSettings { get; set; }

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
        /// Gets or Sets IsInheritance
        /// </summary>
        [DataMember(Name = "isInheritance", EmitDefaultValue = false)]
        public bool IsInheritance { get; set; }

        /// <summary>
        /// Gets or Sets DeploymentManagerPlanName
        /// </summary>
        [DataMember(Name = "deploymentManagerPlanName", EmitDefaultValue = true)]
        public string DeploymentManagerPlanName { get; set; }

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
        /// Questionnaire question and answer of request.
        /// </summary>
        /// <value>Questionnaire question and answer of request.</value>
        [DataMember(Name = "questionnaireResponse", EmitDefaultValue = true)]
        public List<QuestionAnswerResponse> QuestionnaireResponse { get; set; }

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
        /// Approval stage name of request.
        /// </summary>
        /// <value>Approval stage name of request.</value>
        [DataMember(Name = "approvalStageName", EmitDefaultValue = true)]
        public string ApprovalStageName { get; private set; }

        /// <summary>
        /// Returns false as ApprovalStageName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeApprovalStageName()
        {
            return false;
        }

        /// <summary>
        /// Participants of request.
        /// </summary>
        /// <value>Participants of request.</value>
        [DataMember(Name = "participants", EmitDefaultValue = true)]
        public string Participants { get; private set; }

        /// <summary>
        /// Returns false as Participants should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeParticipants()
        {
            return false;
        }

        /// <summary>
        /// Object full path/email/private channel of request.
        /// </summary>
        /// <value>Object full path/email/private channel of request.</value>
        [DataMember(Name = "objectID", EmitDefaultValue = true)]
        public string ObjectID { get; private set; }

        /// <summary>
        /// Returns false as ObjectID should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeObjectID()
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
            sb.Append("class CreateWebRequest {\n");
            sb.Append("  WebName: ").Append(WebName).Append("\n");
            sb.Append("  WebTitle: ").Append(WebTitle).Append("\n");
            sb.Append("  WebDescription: ").Append(WebDescription).Append("\n");
            sb.Append("  WebLanguage: ").Append(WebLanguage).Append("\n");
            sb.Append("  WebTemplate: ").Append(WebTemplate).Append("\n");
            sb.Append("  ParentSiteUrl: ").Append(ParentSiteUrl).Append("\n");
            sb.Append("  ParentWebUrl: ").Append(ParentWebUrl).Append("\n");
            sb.Append("  PrimaryContact: ").Append(PrimaryContact).Append("\n");
            sb.Append("  SecondaryContact: ").Append(SecondaryContact).Append("\n");
            sb.Append("  UserPermissions: ").Append(UserPermissions).Append("\n");
            sb.Append("  GroupPermissions: ").Append(GroupPermissions).Append("\n");
            sb.Append("  YammerGroupSettings: ").Append(YammerGroupSettings).Append("\n");
            sb.Append("  IsOnQuickLaunch: ").Append(IsOnQuickLaunch).Append("\n");
            sb.Append("  IsOnTopLinkBar: ").Append(IsOnTopLinkBar).Append("\n");
            sb.Append("  IsInheritance: ").Append(IsInheritance).Append("\n");
            sb.Append("  DeploymentManagerPlanName: ").Append(DeploymentManagerPlanName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  NotesToApprovers: ").Append(NotesToApprovers).Append("\n");
            sb.Append("  QuestionnaireId: ").Append(QuestionnaireId).Append("\n");
            sb.Append("  QuestionnaireResponse: ").Append(QuestionnaireResponse).Append("\n");
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
            sb.Append("  ApprovalStageName: ").Append(ApprovalStageName).Append("\n");
            sb.Append("  Participants: ").Append(Participants).Append("\n");
            sb.Append("  ObjectID: ").Append(ObjectID).Append("\n");
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
            return this.Equals(input as CreateWebRequest);
        }

        /// <summary>
        /// Returns true if CreateWebRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateWebRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateWebRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WebName == input.WebName ||
                    (this.WebName != null &&
                    this.WebName.Equals(input.WebName))
                ) && 
                (
                    this.WebTitle == input.WebTitle ||
                    (this.WebTitle != null &&
                    this.WebTitle.Equals(input.WebTitle))
                ) && 
                (
                    this.WebDescription == input.WebDescription ||
                    (this.WebDescription != null &&
                    this.WebDescription.Equals(input.WebDescription))
                ) && 
                (
                    this.WebLanguage == input.WebLanguage ||
                    (this.WebLanguage != null &&
                    this.WebLanguage.Equals(input.WebLanguage))
                ) && 
                (
                    this.WebTemplate == input.WebTemplate ||
                    (this.WebTemplate != null &&
                    this.WebTemplate.Equals(input.WebTemplate))
                ) && 
                (
                    this.ParentSiteUrl == input.ParentSiteUrl ||
                    (this.ParentSiteUrl != null &&
                    this.ParentSiteUrl.Equals(input.ParentSiteUrl))
                ) && 
                (
                    this.ParentWebUrl == input.ParentWebUrl ||
                    (this.ParentWebUrl != null &&
                    this.ParentWebUrl.Equals(input.ParentWebUrl))
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
                    this.UserPermissions == input.UserPermissions ||
                    this.UserPermissions != null &&
                    input.UserPermissions != null &&
                    this.UserPermissions.SequenceEqual(input.UserPermissions)
                ) && 
                (
                    this.GroupPermissions == input.GroupPermissions ||
                    this.GroupPermissions != null &&
                    input.GroupPermissions != null &&
                    this.GroupPermissions.SequenceEqual(input.GroupPermissions)
                ) && 
                (
                    this.YammerGroupSettings == input.YammerGroupSettings ||
                    (this.YammerGroupSettings != null &&
                    this.YammerGroupSettings.Equals(input.YammerGroupSettings))
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
                    this.IsInheritance == input.IsInheritance ||
                    this.IsInheritance.Equals(input.IsInheritance)
                ) && 
                (
                    this.DeploymentManagerPlanName == input.DeploymentManagerPlanName ||
                    (this.DeploymentManagerPlanName != null &&
                    this.DeploymentManagerPlanName.Equals(input.DeploymentManagerPlanName))
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
                    this.QuestionnaireResponse == input.QuestionnaireResponse ||
                    this.QuestionnaireResponse != null &&
                    input.QuestionnaireResponse != null &&
                    this.QuestionnaireResponse.SequenceEqual(input.QuestionnaireResponse)
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
                ) && 
                (
                    this.ApprovalStageName == input.ApprovalStageName ||
                    (this.ApprovalStageName != null &&
                    this.ApprovalStageName.Equals(input.ApprovalStageName))
                ) && 
                (
                    this.Participants == input.Participants ||
                    (this.Participants != null &&
                    this.Participants.Equals(input.Participants))
                ) && 
                (
                    this.ObjectID == input.ObjectID ||
                    (this.ObjectID != null &&
                    this.ObjectID.Equals(input.ObjectID))
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
                if (this.WebName != null)
                    hashCode = hashCode * 59 + this.WebName.GetHashCode();
                if (this.WebTitle != null)
                    hashCode = hashCode * 59 + this.WebTitle.GetHashCode();
                if (this.WebDescription != null)
                    hashCode = hashCode * 59 + this.WebDescription.GetHashCode();
                if (this.WebLanguage != null)
                    hashCode = hashCode * 59 + this.WebLanguage.GetHashCode();
                if (this.WebTemplate != null)
                    hashCode = hashCode * 59 + this.WebTemplate.GetHashCode();
                if (this.ParentSiteUrl != null)
                    hashCode = hashCode * 59 + this.ParentSiteUrl.GetHashCode();
                if (this.ParentWebUrl != null)
                    hashCode = hashCode * 59 + this.ParentWebUrl.GetHashCode();
                if (this.PrimaryContact != null)
                    hashCode = hashCode * 59 + this.PrimaryContact.GetHashCode();
                if (this.SecondaryContact != null)
                    hashCode = hashCode * 59 + this.SecondaryContact.GetHashCode();
                if (this.UserPermissions != null)
                    hashCode = hashCode * 59 + this.UserPermissions.GetHashCode();
                if (this.GroupPermissions != null)
                    hashCode = hashCode * 59 + this.GroupPermissions.GetHashCode();
                if (this.YammerGroupSettings != null)
                    hashCode = hashCode * 59 + this.YammerGroupSettings.GetHashCode();
                hashCode = hashCode * 59 + this.IsOnQuickLaunch.GetHashCode();
                hashCode = hashCode * 59 + this.IsOnTopLinkBar.GetHashCode();
                hashCode = hashCode * 59 + this.IsInheritance.GetHashCode();
                if (this.DeploymentManagerPlanName != null)
                    hashCode = hashCode * 59 + this.DeploymentManagerPlanName.GetHashCode();
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
                if (this.QuestionnaireResponse != null)
                    hashCode = hashCode * 59 + this.QuestionnaireResponse.GetHashCode();
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
                if (this.ApprovalStageName != null)
                    hashCode = hashCode * 59 + this.ApprovalStageName.GetHashCode();
                if (this.Participants != null)
                    hashCode = hashCode * 59 + this.Participants.GetHashCode();
                if (this.ObjectID != null)
                    hashCode = hashCode * 59 + this.ObjectID.GetHashCode();
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
