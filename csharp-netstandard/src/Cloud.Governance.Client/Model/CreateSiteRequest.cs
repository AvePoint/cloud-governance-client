

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
    /// Create collection requesst model
    /// </summary>
    [DataContract(Name = "CreateSiteRequest")]
    public partial class CreateSiteRequest : IEquatable<CreateSiteRequest>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="CreateSiteRequest" /> class.
        /// </summary>
        /// <param name="siteTitle">Site collection title.</param>
        /// <param name="siteDescription">Site collection description.</param>
        /// <param name="siteUrl">Site collection url information.</param>
        /// <param name="policyId">Site collection policy id, you can use GetCreateSiteService api to get all the available policy ids and names..</param>
        /// <param name="timeZone">Site collection time zone id, you can use GetCreateSiteService api to get all the available time zone ids and names. (default to 0).</param>
        /// <param name="language">Site collection language id, you can use GetCreateSiteService api to get all the available language ids and names. (default to 0).</param>
        /// <param name="template">Site collection template id, you can use GetCreateSiteService api to get all the available template ids and names..</param>
        /// <param name="deploymentManagerPlanName">Deployment manager plan name, you can use GetCreateSiteService api to get all the available deployment manager plan names..</param>
        /// <param name="primaryAdmin">Primary site collection administrator.</param>
        /// <param name="additionalAdmins">Additional site collection administrator.</param>
        /// <param name="primaryContact">Primary site collection contact.</param>
        /// <param name="secondaryContact">Secondary site collection contact.</param>
        /// <param name="siteDesign">Communication site design.</param>
        /// <param name="teamSiteDesign">Team site design.</param>
        /// <param name="classification">Communication site Classification.</param>
        /// <param name="hubSiteSettings">Hub site setting.</param>
        /// <param name="userPermissions">Granted user/group permission setting.</param>
        /// <param name="groupPermissions">Site collection SharePoint group setting.</param>
        /// <param name="yammerGroupSettings">Yammer group setting.</param>
        /// <param name="leasePeriodSettings">Lease period setting.</param>
        /// <param name="multiGeoLocation">Multi-geo location.</param>
        /// <param name="inputTitle">Site collection title without prefix and sufix when service enables constructing title.</param>
        /// <param name="id">Id of request..</param>
        /// <param name="serviceId">Id of service..</param>
        /// <param name="summary">Summary of request..</param>
        /// <param name="notesToApprovers">Notes to approvers..</param>
        /// <param name="questionnaireId">Id of questionnaire.</param>
        /// <param name="metadatas">Metadata of request..</param>
        public CreateSiteRequest(string siteTitle = default(string), string siteDescription = default(string), SiteUrl siteUrl = default(SiteUrl), Guid? policyId = default(Guid?), int? timeZone = 0, int language = 0, string template = default(string), string deploymentManagerPlanName = default(string), ApiUser primaryAdmin = default(ApiUser), List<ApiUser> additionalAdmins = default(List<ApiUser>), ApiUser primaryContact = default(ApiUser), ApiUser secondaryContact = default(ApiUser), StringModel siteDesign = default(StringModel), string teamSiteDesign = default(string), string classification = default(string), HubSiteSettings hubSiteSettings = default(HubSiteSettings), List<RequestUserWithPermissions> userPermissions = default(List<RequestUserWithPermissions>), List<RequestGroupWithPermissions> groupPermissions = default(List<RequestGroupWithPermissions>), YammerGroupRequestSettings yammerGroupSettings = default(YammerGroupRequestSettings), SiteLeasePeriodRequestSettings leasePeriodSettings = default(SiteLeasePeriodRequestSettings), GeoLocationBase multiGeoLocation = default(GeoLocationBase), string inputTitle = default(string), Guid? id = default(Guid?), Guid serviceId = default(Guid), string summary = default(string), string notesToApprovers = default(string), Guid? questionnaireId = default(Guid?), List<RequestMetadata> metadatas = default(List<RequestMetadata>))
        {
            this.SiteTitle = siteTitle;
            this.SiteDescription = siteDescription;
            this.SiteUrl = siteUrl;
            this.PolicyId = policyId;
            // use default value if no "timeZone" provided
            this.TimeZone = timeZone ?? 0;
            this.Language = language;
            this.Template = template;
            this.DeploymentManagerPlanName = deploymentManagerPlanName;
            this.PrimaryAdmin = primaryAdmin;
            this.AdditionalAdmins = additionalAdmins;
            this.PrimaryContact = primaryContact;
            this.SecondaryContact = secondaryContact;
            this.SiteDesign = siteDesign;
            this.TeamSiteDesign = teamSiteDesign;
            this.Classification = classification;
            this.HubSiteSettings = hubSiteSettings;
            this.UserPermissions = userPermissions;
            this.GroupPermissions = groupPermissions;
            this.YammerGroupSettings = yammerGroupSettings;
            this.LeasePeriodSettings = leasePeriodSettings;
            this.MultiGeoLocation = multiGeoLocation;
            this.InputTitle = inputTitle;
            this.Id = id;
            this.ServiceId = serviceId;
            this.Summary = summary;
            this.NotesToApprovers = notesToApprovers;
            this.QuestionnaireId = questionnaireId;
            this.Metadatas = metadatas;
        }

        /// <summary>
        /// Site collection title
        /// </summary>
        /// <value>Site collection title</value>
        [DataMember(Name = "siteTitle", EmitDefaultValue = true)]
        public string SiteTitle { get; set; }

        /// <summary>
        /// Site collection description
        /// </summary>
        /// <value>Site collection description</value>
        [DataMember(Name = "siteDescription", EmitDefaultValue = true)]
        public string SiteDescription { get; set; }

        /// <summary>
        /// Site collection url information
        /// </summary>
        /// <value>Site collection url information</value>
        [DataMember(Name = "siteUrl", EmitDefaultValue = true)]
        public SiteUrl SiteUrl { get; set; }

        /// <summary>
        /// Site collection policy id, you can use GetCreateSiteService api to get all the available policy ids and names.
        /// </summary>
        /// <value>Site collection policy id, you can use GetCreateSiteService api to get all the available policy ids and names.</value>
        [DataMember(Name = "policyId", EmitDefaultValue = true)]
        public Guid? PolicyId { get; set; }

        /// <summary>
        /// Site collection time zone id, you can use GetCreateSiteService api to get all the available time zone ids and names.
        /// </summary>
        /// <value>Site collection time zone id, you can use GetCreateSiteService api to get all the available time zone ids and names.</value>
        [DataMember(Name = "timeZone", EmitDefaultValue = true)]
        public int? TimeZone { get; set; }

        /// <summary>
        /// Site collection language id, you can use GetCreateSiteService api to get all the available language ids and names.
        /// </summary>
        /// <value>Site collection language id, you can use GetCreateSiteService api to get all the available language ids and names.</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public int Language { get; set; }

        /// <summary>
        /// Site collection template id, you can use GetCreateSiteService api to get all the available template ids and names.
        /// </summary>
        /// <value>Site collection template id, you can use GetCreateSiteService api to get all the available template ids and names.</value>
        [DataMember(Name = "template", EmitDefaultValue = true)]
        public string Template { get; set; }

        /// <summary>
        /// Deployment manager plan name, you can use GetCreateSiteService api to get all the available deployment manager plan names.
        /// </summary>
        /// <value>Deployment manager plan name, you can use GetCreateSiteService api to get all the available deployment manager plan names.</value>
        [DataMember(Name = "deploymentManagerPlanName", EmitDefaultValue = true)]
        public string DeploymentManagerPlanName { get; set; }

        /// <summary>
        /// Primary site collection administrator
        /// </summary>
        /// <value>Primary site collection administrator</value>
        [DataMember(Name = "primaryAdmin", EmitDefaultValue = true)]
        public ApiUser PrimaryAdmin { get; set; }

        /// <summary>
        /// Additional site collection administrator
        /// </summary>
        /// <value>Additional site collection administrator</value>
        [DataMember(Name = "additionalAdmins", EmitDefaultValue = true)]
        public List<ApiUser> AdditionalAdmins { get; set; }

        /// <summary>
        /// Primary site collection contact
        /// </summary>
        /// <value>Primary site collection contact</value>
        [DataMember(Name = "primaryContact", EmitDefaultValue = true)]
        public ApiUser PrimaryContact { get; set; }

        /// <summary>
        /// Secondary site collection contact
        /// </summary>
        /// <value>Secondary site collection contact</value>
        [DataMember(Name = "secondaryContact", EmitDefaultValue = true)]
        public ApiUser SecondaryContact { get; set; }

        /// <summary>
        /// Communication site design
        /// </summary>
        /// <value>Communication site design</value>
        [DataMember(Name = "siteDesign", EmitDefaultValue = true)]
        public StringModel SiteDesign { get; set; }

        /// <summary>
        /// Team site design
        /// </summary>
        /// <value>Team site design</value>
        [DataMember(Name = "teamSiteDesign", EmitDefaultValue = true)]
        public string TeamSiteDesign { get; set; }

        /// <summary>
        /// Communication site Classification
        /// </summary>
        /// <value>Communication site Classification</value>
        [DataMember(Name = "classification", EmitDefaultValue = true)]
        public string Classification { get; set; }

        /// <summary>
        /// Hub site setting
        /// </summary>
        /// <value>Hub site setting</value>
        [DataMember(Name = "hubSiteSettings", EmitDefaultValue = true)]
        public HubSiteSettings HubSiteSettings { get; set; }

        /// <summary>
        /// Granted user/group permission setting
        /// </summary>
        /// <value>Granted user/group permission setting</value>
        [DataMember(Name = "userPermissions", EmitDefaultValue = true)]
        public List<RequestUserWithPermissions> UserPermissions { get; set; }

        /// <summary>
        /// Site collection SharePoint group setting
        /// </summary>
        /// <value>Site collection SharePoint group setting</value>
        [DataMember(Name = "groupPermissions", EmitDefaultValue = true)]
        public List<RequestGroupWithPermissions> GroupPermissions { get; set; }

        /// <summary>
        /// Yammer group setting
        /// </summary>
        /// <value>Yammer group setting</value>
        [DataMember(Name = "yammerGroupSettings", EmitDefaultValue = true)]
        public YammerGroupRequestSettings YammerGroupSettings { get; set; }

        /// <summary>
        /// Lease period setting
        /// </summary>
        /// <value>Lease period setting</value>
        [DataMember(Name = "leasePeriodSettings", EmitDefaultValue = true)]
        public SiteLeasePeriodRequestSettings LeasePeriodSettings { get; set; }

        /// <summary>
        /// Multi-geo location
        /// </summary>
        /// <value>Multi-geo location</value>
        [DataMember(Name = "multiGeoLocation", EmitDefaultValue = true)]
        public GeoLocationBase MultiGeoLocation { get; set; }

        /// <summary>
        /// Site collection title without prefix and sufix when service enables constructing title
        /// </summary>
        /// <value>Site collection title without prefix and sufix when service enables constructing title</value>
        [DataMember(Name = "inputTitle", EmitDefaultValue = true)]
        public string InputTitle { get; set; }

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
            sb.Append("  SiteDesign: ").Append(SiteDesign).Append("\n");
            sb.Append("  TeamSiteDesign: ").Append(TeamSiteDesign).Append("\n");
            sb.Append("  Classification: ").Append(Classification).Append("\n");
            sb.Append("  HubSiteSettings: ").Append(HubSiteSettings).Append("\n");
            sb.Append("  UserPermissions: ").Append(UserPermissions).Append("\n");
            sb.Append("  GroupPermissions: ").Append(GroupPermissions).Append("\n");
            sb.Append("  YammerGroupSettings: ").Append(YammerGroupSettings).Append("\n");
            sb.Append("  LeasePeriodSettings: ").Append(LeasePeriodSettings).Append("\n");
            sb.Append("  MultiGeoLocation: ").Append(MultiGeoLocation).Append("\n");
            sb.Append("  InputTitle: ").Append(InputTitle).Append("\n");
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
                if (this.SiteDesign != null)
                    hashCode = hashCode * 59 + this.SiteDesign.GetHashCode();
                if (this.TeamSiteDesign != null)
                    hashCode = hashCode * 59 + this.TeamSiteDesign.GetHashCode();
                if (this.Classification != null)
                    hashCode = hashCode * 59 + this.Classification.GetHashCode();
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
