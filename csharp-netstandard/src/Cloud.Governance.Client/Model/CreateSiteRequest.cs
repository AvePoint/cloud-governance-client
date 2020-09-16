

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
    /// CreateSiteRequest
    /// </summary>
    [DataContract(Name = "CreateSiteRequest")]
    public partial class CreateSiteRequest : IEquatable<CreateSiteRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public ServiceType? Type { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public RequestStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSiteRequest" /> class.
        /// </summary>
        /// <param name="siteTitle">siteTitle.</param>
        /// <param name="siteDescription">siteDescription.</param>
        /// <param name="siteUrl">siteUrl.</param>
        /// <param name="policyId">policyId.</param>
        /// <param name="timeZone">timeZone.</param>
        /// <param name="language">language.</param>
        /// <param name="template">template.</param>
        /// <param name="deploymentManagerPlanName">deploymentManagerPlanName.</param>
        /// <param name="primaryAdmin">primaryAdmin.</param>
        /// <param name="additionalAdmins">additionalAdmins.</param>
        /// <param name="primaryContact">primaryContact.</param>
        /// <param name="secondaryContact">secondaryContact.</param>
        /// <param name="isShownClassificationAndDesing">isShownClassificationAndDesing.</param>
        /// <param name="siteDesign">siteDesign.</param>
        /// <param name="teamSiteDesign">teamSiteDesign.</param>
        /// <param name="classification">classification.</param>
        /// <param name="sensitivity">sensitivity.</param>
        /// <param name="isShownHubsiteSettings">isShownHubsiteSettings.</param>
        /// <param name="hubSiteSettings">hubSiteSettings.</param>
        /// <param name="userPermissions">userPermissions.</param>
        /// <param name="groupPermissions">groupPermissions.</param>
        /// <param name="yammerGroupSettings">yammerGroupSettings.</param>
        /// <param name="leasePeriodSettings">leasePeriodSettings.</param>
        /// <param name="multiGeoLocation">multiGeoLocation.</param>
        /// <param name="inputTitle">inputTitle.</param>
        /// <param name="id">id.</param>
        /// <param name="serviceId">serviceId.</param>
        /// <param name="department">department.</param>
        /// <param name="summary">summary.</param>
        /// <param name="notesToApprovers">notesToApprovers.</param>
        /// <param name="questionnaireId">questionnaireId.</param>
        /// <param name="metadatas">metadatas.</param>
        /// <param name="type">type.</param>
        /// <param name="typeDescription">typeDescription.</param>
        /// <param name="status">status.</param>
        /// <param name="progressStatus">progressStatus.</param>
        /// <param name="progressStatusDescription">progressStatusDescription.</param>
        public CreateSiteRequest(string siteTitle = default(string), string siteDescription = default(string), SiteUrl siteUrl = default(SiteUrl), Guid? policyId = default(Guid?), int? timeZone = default(int?), int language = default(int), string template = default(string), string deploymentManagerPlanName = default(string), ApiUser primaryAdmin = default(ApiUser), List<ApiUser> additionalAdmins = default(List<ApiUser>), ApiUser primaryContact = default(ApiUser), ApiUser secondaryContact = default(ApiUser), bool isShownClassificationAndDesing = default(bool), StringModel siteDesign = default(StringModel), string teamSiteDesign = default(string), string classification = default(string), string sensitivity = default(string), bool isShownHubsiteSettings = default(bool), HubSiteSettings hubSiteSettings = default(HubSiteSettings), List<RequestUserWithPermissions> userPermissions = default(List<RequestUserWithPermissions>), List<RequestGroupWithPermissions> groupPermissions = default(List<RequestGroupWithPermissions>), YammerGroupRequestSettings yammerGroupSettings = default(YammerGroupRequestSettings), SiteLeasePeriodRequestSettings leasePeriodSettings = default(SiteLeasePeriodRequestSettings), GeoLocationBase multiGeoLocation = default(GeoLocationBase), string inputTitle = default(string), Guid? id = default(Guid?), Guid serviceId = default(Guid), string department = default(string), string summary = default(string), string notesToApprovers = default(string), Guid? questionnaireId = default(Guid?), List<RequestMetadata> metadatas = default(List<RequestMetadata>), ServiceType? type = default(ServiceType?), string typeDescription = default(string), RequestStatus? status = default(RequestStatus?), int progressStatus = default(int), string progressStatusDescription = default(string))
        {
            this.SiteTitle = siteTitle;
            this.SiteDescription = siteDescription;
            this.SiteUrl = siteUrl;
            this.PolicyId = policyId;
            this.TimeZone = timeZone;
            this.Language = language;
            this.Template = template;
            this.DeploymentManagerPlanName = deploymentManagerPlanName;
            this.PrimaryAdmin = primaryAdmin;
            this.AdditionalAdmins = additionalAdmins;
            this.PrimaryContact = primaryContact;
            this.SecondaryContact = secondaryContact;
            this.IsShownClassificationAndDesing = isShownClassificationAndDesing;
            this.SiteDesign = siteDesign;
            this.TeamSiteDesign = teamSiteDesign;
            this.Classification = classification;
            this.Sensitivity = sensitivity;
            this.IsShownHubsiteSettings = isShownHubsiteSettings;
            this.HubSiteSettings = hubSiteSettings;
            this.UserPermissions = userPermissions;
            this.GroupPermissions = groupPermissions;
            this.YammerGroupSettings = yammerGroupSettings;
            this.LeasePeriodSettings = leasePeriodSettings;
            this.MultiGeoLocation = multiGeoLocation;
            this.InputTitle = inputTitle;
            this.Id = id;
            this.ServiceId = serviceId;
            this.Department = department;
            this.Summary = summary;
            this.NotesToApprovers = notesToApprovers;
            this.QuestionnaireId = questionnaireId;
            this.Metadatas = metadatas;
            this.Type = type;
            this.TypeDescription = typeDescription;
            this.Status = status;
            this.ProgressStatus = progressStatus;
            this.ProgressStatusDescription = progressStatusDescription;
        }

        /// <summary>
        /// Gets or Sets SiteTitle
        /// </summary>
        [DataMember(Name = "siteTitle", EmitDefaultValue = true)]
        public string SiteTitle { get; set; }

        /// <summary>
        /// Gets or Sets SiteDescription
        /// </summary>
        [DataMember(Name = "siteDescription", EmitDefaultValue = true)]
        public string SiteDescription { get; set; }

        /// <summary>
        /// Gets or Sets SiteUrl
        /// </summary>
        [DataMember(Name = "siteUrl", EmitDefaultValue = false)]
        public SiteUrl SiteUrl { get; set; }

        /// <summary>
        /// Gets or Sets PolicyId
        /// </summary>
        [DataMember(Name = "policyId", EmitDefaultValue = true)]
        public Guid? PolicyId { get; set; }

        /// <summary>
        /// Gets or Sets TimeZone
        /// </summary>
        [DataMember(Name = "timeZone", EmitDefaultValue = true)]
        public int? TimeZone { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public int Language { get; set; }

        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name = "template", EmitDefaultValue = true)]
        public string Template { get; set; }

        /// <summary>
        /// Gets or Sets DeploymentManagerPlanName
        /// </summary>
        [DataMember(Name = "deploymentManagerPlanName", EmitDefaultValue = true)]
        public string DeploymentManagerPlanName { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryAdmin
        /// </summary>
        [DataMember(Name = "primaryAdmin", EmitDefaultValue = false)]
        public ApiUser PrimaryAdmin { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalAdmins
        /// </summary>
        [DataMember(Name = "additionalAdmins", EmitDefaultValue = true)]
        public List<ApiUser> AdditionalAdmins { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryContact
        /// </summary>
        [DataMember(Name = "primaryContact", EmitDefaultValue = false)]
        public ApiUser PrimaryContact { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryContact
        /// </summary>
        [DataMember(Name = "secondaryContact", EmitDefaultValue = false)]
        public ApiUser SecondaryContact { get; set; }

        /// <summary>
        /// Gets or Sets IsShownClassificationAndDesing
        /// </summary>
        [DataMember(Name = "isShownClassificationAndDesing", EmitDefaultValue = false)]
        public bool IsShownClassificationAndDesing { get; set; }

        /// <summary>
        /// Gets or Sets SiteDesign
        /// </summary>
        [DataMember(Name = "siteDesign", EmitDefaultValue = false)]
        public StringModel SiteDesign { get; set; }

        /// <summary>
        /// Gets or Sets TeamSiteDesign
        /// </summary>
        [DataMember(Name = "teamSiteDesign", EmitDefaultValue = true)]
        public string TeamSiteDesign { get; set; }

        /// <summary>
        /// Gets or Sets Classification
        /// </summary>
        [DataMember(Name = "classification", EmitDefaultValue = true)]
        public string Classification { get; set; }

        /// <summary>
        /// Gets or Sets Sensitivity
        /// </summary>
        [DataMember(Name = "sensitivity", EmitDefaultValue = true)]
        public string Sensitivity { get; set; }

        /// <summary>
        /// Gets or Sets IsShownHubsiteSettings
        /// </summary>
        [DataMember(Name = "isShownHubsiteSettings", EmitDefaultValue = false)]
        public bool IsShownHubsiteSettings { get; set; }

        /// <summary>
        /// Gets or Sets HubSiteSettings
        /// </summary>
        [DataMember(Name = "hubSiteSettings", EmitDefaultValue = false)]
        public HubSiteSettings HubSiteSettings { get; set; }

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
        /// Gets or Sets YammerGroupSettings
        /// </summary>
        [DataMember(Name = "yammerGroupSettings", EmitDefaultValue = false)]
        public YammerGroupRequestSettings YammerGroupSettings { get; set; }

        /// <summary>
        /// Gets or Sets LeasePeriodSettings
        /// </summary>
        [DataMember(Name = "leasePeriodSettings", EmitDefaultValue = false)]
        public SiteLeasePeriodRequestSettings LeasePeriodSettings { get; set; }

        /// <summary>
        /// Gets or Sets MultiGeoLocation
        /// </summary>
        [DataMember(Name = "multiGeoLocation", EmitDefaultValue = false)]
        public GeoLocationBase MultiGeoLocation { get; set; }

        /// <summary>
        /// Gets or Sets InputTitle
        /// </summary>
        [DataMember(Name = "inputTitle", EmitDefaultValue = true)]
        public string InputTitle { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets ServiceId
        /// </summary>
        [DataMember(Name = "serviceId", EmitDefaultValue = false)]
        public Guid ServiceId { get; set; }

        /// <summary>
        /// Gets or Sets Department
        /// </summary>
        [DataMember(Name = "department", EmitDefaultValue = true)]
        public string Department { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", EmitDefaultValue = true)]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or Sets NotesToApprovers
        /// </summary>
        [DataMember(Name = "notesToApprovers", EmitDefaultValue = true)]
        public string NotesToApprovers { get; set; }

        /// <summary>
        /// Gets or Sets QuestionnaireId
        /// </summary>
        [DataMember(Name = "questionnaireId", EmitDefaultValue = true)]
        public Guid? QuestionnaireId { get; set; }

        /// <summary>
        /// Gets or Sets Metadatas
        /// </summary>
        [DataMember(Name = "metadatas", EmitDefaultValue = true)]
        public List<RequestMetadata> Metadatas { get; set; }

        /// <summary>
        /// Gets or Sets TicketNumber
        /// </summary>
        [DataMember(Name = "ticketNumber", EmitDefaultValue = true)]
        public int? TicketNumber { get; private set; }

        /// <summary>
        /// Gets or Sets TypeDescription
        /// </summary>
        [DataMember(Name = "typeDescription", EmitDefaultValue = true)]
        public string TypeDescription { get; set; }

        /// <summary>
        /// Gets or Sets Requester
        /// </summary>
        [DataMember(Name = "requester", EmitDefaultValue = true)]
        public string Requester { get; private set; }

        /// <summary>
        /// Gets or Sets RequesterLoginName
        /// </summary>
        [DataMember(Name = "requesterLoginName", EmitDefaultValue = true)]
        public string RequesterLoginName { get; private set; }

        /// <summary>
        /// Gets or Sets ProgressStatus
        /// </summary>
        [DataMember(Name = "progressStatus", EmitDefaultValue = false)]
        public int ProgressStatus { get; set; }

        /// <summary>
        /// Gets or Sets ProgressStatusDescription
        /// </summary>
        [DataMember(Name = "progressStatusDescription", EmitDefaultValue = true)]
        public string ProgressStatusDescription { get; set; }

        /// <summary>
        /// Gets or Sets SubmittedTime
        /// </summary>
        [DataMember(Name = "submittedTime", EmitDefaultValue = true)]
        public DateTime? SubmittedTime { get; private set; }

        /// <summary>
        /// Gets or Sets LastUpdated
        /// </summary>
        [DataMember(Name = "lastUpdated", EmitDefaultValue = true)]
        public DateTime? LastUpdated { get; private set; }

        /// <summary>
        /// Gets or Sets CreatedTime
        /// </summary>
        [DataMember(Name = "createdTime", EmitDefaultValue = true)]
        public DateTime? CreatedTime { get; private set; }

        /// <summary>
        /// Gets or Sets AssignTo
        /// </summary>
        [DataMember(Name = "assignTo", EmitDefaultValue = true)]
        public string AssignTo { get; private set; }

        /// <summary>
        /// Gets or Sets FullPath
        /// </summary>
        [DataMember(Name = "fullPath", EmitDefaultValue = true)]
        public string FullPath { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSiteRequest {\n");
            sb.Append("  SiteTitle: ").Append(SiteTitle).Append("\n");
            sb.Append("  SiteDescription: ").Append(SiteDescription).Append("\n");
            sb.Append("  SiteUrl: ").Append(SiteUrl).Append("\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  DeploymentManagerPlanName: ").Append(DeploymentManagerPlanName).Append("\n");
            sb.Append("  PrimaryAdmin: ").Append(PrimaryAdmin).Append("\n");
            sb.Append("  AdditionalAdmins: ").Append(AdditionalAdmins).Append("\n");
            sb.Append("  PrimaryContact: ").Append(PrimaryContact).Append("\n");
            sb.Append("  SecondaryContact: ").Append(SecondaryContact).Append("\n");
            sb.Append("  IsShownClassificationAndDesing: ").Append(IsShownClassificationAndDesing).Append("\n");
            sb.Append("  SiteDesign: ").Append(SiteDesign).Append("\n");
            sb.Append("  TeamSiteDesign: ").Append(TeamSiteDesign).Append("\n");
            sb.Append("  Classification: ").Append(Classification).Append("\n");
            sb.Append("  Sensitivity: ").Append(Sensitivity).Append("\n");
            sb.Append("  IsShownHubsiteSettings: ").Append(IsShownHubsiteSettings).Append("\n");
            sb.Append("  HubSiteSettings: ").Append(HubSiteSettings).Append("\n");
            sb.Append("  UserPermissions: ").Append(UserPermissions).Append("\n");
            sb.Append("  GroupPermissions: ").Append(GroupPermissions).Append("\n");
            sb.Append("  YammerGroupSettings: ").Append(YammerGroupSettings).Append("\n");
            sb.Append("  LeasePeriodSettings: ").Append(LeasePeriodSettings).Append("\n");
            sb.Append("  MultiGeoLocation: ").Append(MultiGeoLocation).Append("\n");
            sb.Append("  InputTitle: ").Append(InputTitle).Append("\n");
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
            return this.Equals(input as CreateSiteRequest);
        }

        /// <summary>
        /// Returns true if CreateSiteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSiteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSiteRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SiteTitle == input.SiteTitle ||
                    (this.SiteTitle != null &&
                    this.SiteTitle.Equals(input.SiteTitle))
                ) && 
                (
                    this.SiteDescription == input.SiteDescription ||
                    (this.SiteDescription != null &&
                    this.SiteDescription.Equals(input.SiteDescription))
                ) && 
                (
                    this.SiteUrl == input.SiteUrl ||
                    (this.SiteUrl != null &&
                    this.SiteUrl.Equals(input.SiteUrl))
                ) && 
                (
                    this.PolicyId == input.PolicyId ||
                    (this.PolicyId != null &&
                    this.PolicyId.Equals(input.PolicyId))
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
                ) && 
                (
                    this.Language == input.Language ||
                    this.Language.Equals(input.Language)
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
                ) && 
                (
                    this.DeploymentManagerPlanName == input.DeploymentManagerPlanName ||
                    (this.DeploymentManagerPlanName != null &&
                    this.DeploymentManagerPlanName.Equals(input.DeploymentManagerPlanName))
                ) && 
                (
                    this.PrimaryAdmin == input.PrimaryAdmin ||
                    (this.PrimaryAdmin != null &&
                    this.PrimaryAdmin.Equals(input.PrimaryAdmin))
                ) && 
                (
                    this.AdditionalAdmins == input.AdditionalAdmins ||
                    this.AdditionalAdmins != null &&
                    input.AdditionalAdmins != null &&
                    this.AdditionalAdmins.SequenceEqual(input.AdditionalAdmins)
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
                    this.IsShownClassificationAndDesing == input.IsShownClassificationAndDesing ||
                    this.IsShownClassificationAndDesing.Equals(input.IsShownClassificationAndDesing)
                ) && 
                (
                    this.SiteDesign == input.SiteDesign ||
                    (this.SiteDesign != null &&
                    this.SiteDesign.Equals(input.SiteDesign))
                ) && 
                (
                    this.TeamSiteDesign == input.TeamSiteDesign ||
                    (this.TeamSiteDesign != null &&
                    this.TeamSiteDesign.Equals(input.TeamSiteDesign))
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
                    this.IsShownHubsiteSettings == input.IsShownHubsiteSettings ||
                    this.IsShownHubsiteSettings.Equals(input.IsShownHubsiteSettings)
                ) && 
                (
                    this.HubSiteSettings == input.HubSiteSettings ||
                    (this.HubSiteSettings != null &&
                    this.HubSiteSettings.Equals(input.HubSiteSettings))
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
                    this.LeasePeriodSettings == input.LeasePeriodSettings ||
                    (this.LeasePeriodSettings != null &&
                    this.LeasePeriodSettings.Equals(input.LeasePeriodSettings))
                ) && 
                (
                    this.MultiGeoLocation == input.MultiGeoLocation ||
                    (this.MultiGeoLocation != null &&
                    this.MultiGeoLocation.Equals(input.MultiGeoLocation))
                ) && 
                (
                    this.InputTitle == input.InputTitle ||
                    (this.InputTitle != null &&
                    this.InputTitle.Equals(input.InputTitle))
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
                if (this.SiteTitle != null)
                    hashCode = hashCode * 59 + this.SiteTitle.GetHashCode();
                if (this.SiteDescription != null)
                    hashCode = hashCode * 59 + this.SiteDescription.GetHashCode();
                if (this.SiteUrl != null)
                    hashCode = hashCode * 59 + this.SiteUrl.GetHashCode();
                if (this.PolicyId != null)
                    hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.DeploymentManagerPlanName != null)
                    hashCode = hashCode * 59 + this.DeploymentManagerPlanName.GetHashCode();
                if (this.PrimaryAdmin != null)
                    hashCode = hashCode * 59 + this.PrimaryAdmin.GetHashCode();
                if (this.AdditionalAdmins != null)
                    hashCode = hashCode * 59 + this.AdditionalAdmins.GetHashCode();
                if (this.PrimaryContact != null)
                    hashCode = hashCode * 59 + this.PrimaryContact.GetHashCode();
                if (this.SecondaryContact != null)
                    hashCode = hashCode * 59 + this.SecondaryContact.GetHashCode();
                hashCode = hashCode * 59 + this.IsShownClassificationAndDesing.GetHashCode();
                if (this.SiteDesign != null)
                    hashCode = hashCode * 59 + this.SiteDesign.GetHashCode();
                if (this.TeamSiteDesign != null)
                    hashCode = hashCode * 59 + this.TeamSiteDesign.GetHashCode();
                if (this.Classification != null)
                    hashCode = hashCode * 59 + this.Classification.GetHashCode();
                if (this.Sensitivity != null)
                    hashCode = hashCode * 59 + this.Sensitivity.GetHashCode();
                hashCode = hashCode * 59 + this.IsShownHubsiteSettings.GetHashCode();
                if (this.HubSiteSettings != null)
                    hashCode = hashCode * 59 + this.HubSiteSettings.GetHashCode();
                if (this.UserPermissions != null)
                    hashCode = hashCode * 59 + this.UserPermissions.GetHashCode();
                if (this.GroupPermissions != null)
                    hashCode = hashCode * 59 + this.GroupPermissions.GetHashCode();
                if (this.YammerGroupSettings != null)
                    hashCode = hashCode * 59 + this.YammerGroupSettings.GetHashCode();
                if (this.LeasePeriodSettings != null)
                    hashCode = hashCode * 59 + this.LeasePeriodSettings.GetHashCode();
                if (this.MultiGeoLocation != null)
                    hashCode = hashCode * 59 + this.MultiGeoLocation.GetHashCode();
                if (this.InputTitle != null)
                    hashCode = hashCode * 59 + this.InputTitle.GetHashCode();
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
            // SiteDescription (string) maxLength
            if(this.SiteDescription != null && this.SiteDescription.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SiteDescription, length must be less than 1024.", new [] { "SiteDescription" });
            }

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
