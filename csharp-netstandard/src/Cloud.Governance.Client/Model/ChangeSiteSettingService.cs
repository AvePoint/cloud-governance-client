

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
    /// ChangeSiteSettingService
    /// </summary>
    [DataContract(Name = "ChangeSiteSettingService")]
    public partial class ChangeSiteSettingService : IEquatable<ChangeSiteSettingService>, IValidatableObject
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
        public CommonStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeSiteSettingService" /> class.
        /// </summary>
        /// <param name="enableChangeTitle">enableChangeTitle (default to false).</param>
        /// <param name="enableChangeDescription">enableChangeDescription (default to false).</param>
        /// <param name="changeMetadataSettings">changeMetadataSettings.</param>
        /// <param name="deploymentManagerPlanSettings">deploymentManagerPlanSettings.</param>
        /// <param name="enableChangeHubSite">enableChangeHubSite (default to false).</param>
        /// <param name="enableChangeSensitivity">enableChangeSensitivity (default to false).</param>
        /// <param name="sensitivityList">sensitivityList.</param>
        /// <param name="scopeSettings">scopeSettings.</param>
        /// <param name="requestTemplate">requestTemplate.</param>
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
        public ChangeSiteSettingService(bool enableChangeTitle = false, bool enableChangeDescription = false, ChangeMetadataActionSetting changeMetadataSettings = default(ChangeMetadataActionSetting), DpmServiceSetting deploymentManagerPlanSettings = default(DpmServiceSetting), bool enableChangeHubSite = false, bool enableChangeSensitivity = false, List<SensitivityLabelModel> sensitivityList = default(List<SensitivityLabelModel>), ServiceScopeSettings scopeSettings = default(ServiceScopeSettings), ChangeSiteSettingRequest requestTemplate = default(ChangeSiteSettingRequest), List<CustomMetadata> metadatas = default(List<CustomMetadata>), bool hideRequestSummary = false, Guid id = default(Guid), string name = default(string), string description = default(string), ServiceType? type = default(ServiceType?), ApiUser serviceContact = default(ApiUser), ApiUser serviceAdminContact = default(ApiUser), bool approversContainManagerRole = false, CommonStatus? status = default(CommonStatus?), bool showServiceInCatalog = false, CustomActionSettings customActions = default(CustomActionSettings), Guid approvalProcessId = default(Guid), int languageId = 0, string categoryId = default(string))
        {
            this.EnableChangeTitle = enableChangeTitle;
            this.EnableChangeDescription = enableChangeDescription;
            this.ChangeMetadataSettings = changeMetadataSettings;
            this.DeploymentManagerPlanSettings = deploymentManagerPlanSettings;
            this.EnableChangeHubSite = enableChangeHubSite;
            this.EnableChangeSensitivity = enableChangeSensitivity;
            this.SensitivityList = sensitivityList;
            this.ScopeSettings = scopeSettings;
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
        /// Gets or Sets EnableChangeTitle
        /// </summary>
        [DataMember(Name = "enableChangeTitle", EmitDefaultValue = false)]
        public bool EnableChangeTitle { get; set; }

        /// <summary>
        /// Gets or Sets EnableChangeDescription
        /// </summary>
        [DataMember(Name = "enableChangeDescription", EmitDefaultValue = false)]
        public bool EnableChangeDescription { get; set; }

        /// <summary>
        /// Gets or Sets ChangeMetadataSettings
        /// </summary>
        [DataMember(Name = "changeMetadataSettings", EmitDefaultValue = true)]
        public ChangeMetadataActionSetting ChangeMetadataSettings { get; set; }

        /// <summary>
        /// Gets or Sets DeploymentManagerPlanSettings
        /// </summary>
        [DataMember(Name = "deploymentManagerPlanSettings", EmitDefaultValue = true)]
        public DpmServiceSetting DeploymentManagerPlanSettings { get; set; }

        /// <summary>
        /// Gets or Sets EnableChangeHubSite
        /// </summary>
        [DataMember(Name = "enableChangeHubSite", EmitDefaultValue = false)]
        public bool EnableChangeHubSite { get; set; }

        /// <summary>
        /// Gets or Sets EnableChangeSensitivity
        /// </summary>
        [DataMember(Name = "enableChangeSensitivity", EmitDefaultValue = false)]
        public bool EnableChangeSensitivity { get; set; }

        /// <summary>
        /// Gets or Sets SensitivityList
        /// </summary>
        [DataMember(Name = "sensitivityList", EmitDefaultValue = true)]
        public List<SensitivityLabelModel> SensitivityList { get; set; }

        /// <summary>
        /// Gets or Sets ScopeSettings
        /// </summary>
        [DataMember(Name = "scopeSettings", EmitDefaultValue = true)]
        public ServiceScopeSettings ScopeSettings { get; set; }

        /// <summary>
        /// Gets or Sets RequestTemplate
        /// </summary>
        [DataMember(Name = "requestTemplate", EmitDefaultValue = true)]
        public ChangeSiteSettingRequest RequestTemplate { get; set; }

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
            sb.Append("class ChangeSiteSettingService {\n");
            sb.Append("  EnableChangeTitle: ").Append(EnableChangeTitle).Append("\n");
            sb.Append("  EnableChangeDescription: ").Append(EnableChangeDescription).Append("\n");
            sb.Append("  ChangeMetadataSettings: ").Append(ChangeMetadataSettings).Append("\n");
            sb.Append("  DeploymentManagerPlanSettings: ").Append(DeploymentManagerPlanSettings).Append("\n");
            sb.Append("  EnableChangeHubSite: ").Append(EnableChangeHubSite).Append("\n");
            sb.Append("  EnableChangeSensitivity: ").Append(EnableChangeSensitivity).Append("\n");
            sb.Append("  SensitivityList: ").Append(SensitivityList).Append("\n");
            sb.Append("  ScopeSettings: ").Append(ScopeSettings).Append("\n");
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
            return this.Equals(input as ChangeSiteSettingService);
        }

        /// <summary>
        /// Returns true if ChangeSiteSettingService instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeSiteSettingService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeSiteSettingService input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnableChangeTitle == input.EnableChangeTitle ||
                    this.EnableChangeTitle.Equals(input.EnableChangeTitle)
                ) && 
                (
                    this.EnableChangeDescription == input.EnableChangeDescription ||
                    this.EnableChangeDescription.Equals(input.EnableChangeDescription)
                ) && 
                (
                    this.ChangeMetadataSettings == input.ChangeMetadataSettings ||
                    (this.ChangeMetadataSettings != null &&
                    this.ChangeMetadataSettings.Equals(input.ChangeMetadataSettings))
                ) && 
                (
                    this.DeploymentManagerPlanSettings == input.DeploymentManagerPlanSettings ||
                    (this.DeploymentManagerPlanSettings != null &&
                    this.DeploymentManagerPlanSettings.Equals(input.DeploymentManagerPlanSettings))
                ) && 
                (
                    this.EnableChangeHubSite == input.EnableChangeHubSite ||
                    this.EnableChangeHubSite.Equals(input.EnableChangeHubSite)
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
                    this.ScopeSettings == input.ScopeSettings ||
                    (this.ScopeSettings != null &&
                    this.ScopeSettings.Equals(input.ScopeSettings))
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
                hashCode = hashCode * 59 + this.EnableChangeTitle.GetHashCode();
                hashCode = hashCode * 59 + this.EnableChangeDescription.GetHashCode();
                if (this.ChangeMetadataSettings != null)
                    hashCode = hashCode * 59 + this.ChangeMetadataSettings.GetHashCode();
                if (this.DeploymentManagerPlanSettings != null)
                    hashCode = hashCode * 59 + this.DeploymentManagerPlanSettings.GetHashCode();
                hashCode = hashCode * 59 + this.EnableChangeHubSite.GetHashCode();
                hashCode = hashCode * 59 + this.EnableChangeSensitivity.GetHashCode();
                if (this.SensitivityList != null)
                    hashCode = hashCode * 59 + this.SensitivityList.GetHashCode();
                if (this.ScopeSettings != null)
                    hashCode = hashCode * 59 + this.ScopeSettings.GetHashCode();
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
