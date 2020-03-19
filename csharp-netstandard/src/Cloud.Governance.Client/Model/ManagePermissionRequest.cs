/* 
 * Cloud Governance Api
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Cloud.Governance.Client.Client.OpenAPIDateConverter;

namespace Cloud.Governance.Client.Model
{
    /// <summary>
    /// ManagePermissionRequest
    /// </summary>
    [DataContract]
    public partial class ManagePermissionRequest :  IEquatable<ManagePermissionRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ObjectType
        /// </summary>
        [DataMember(Name="objectType", EmitDefaultValue=false)]
        public NodeType? ObjectType { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public ServiceTypeNullable? Type { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public RequestStatusNullable? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagePermissionRequest" /> class.
        /// </summary>
        /// <param name="objectUrl">objectUrl.</param>
        /// <param name="objectType">objectType.</param>
        /// <param name="objectTitle">objectTitle.</param>
        /// <param name="siteUrl">siteUrl.</param>
        /// <param name="webUrl">webUrl.</param>
        /// <param name="spGroupManagement">spGroupManagement.</param>
        /// <param name="permissionManagement">permissionManagement.</param>
        /// <param name="id">id.</param>
        /// <param name="serviceId">serviceId.</param>
        /// <param name="department">department.</param>
        /// <param name="summary">summary.</param>
        /// <param name="notesToApprovers">notesToApprovers.</param>
        /// <param name="questionnaireId">questionnaireId.</param>
        /// <param name="metadatas">metadatas.</param>
        public ManagePermissionRequest(string objectUrl = default(string), NodeType objectType = default(NodeType), string objectTitle = default(string), string siteUrl = default(string), string webUrl = default(string), List<SPGroupManagementModel> spGroupManagement = default(List<SPGroupManagementModel>), PermissionManagementModel permissionManagement = default(PermissionManagementModel), Guid? id = default(Guid?), Guid serviceId = default(Guid), string department = default(string), string summary = default(string), string notesToApprovers = default(string), Guid? questionnaireId = default(Guid?), List<RequestMetadata> metadatas = default(List<RequestMetadata>))
        {
            this.ObjectUrl = objectUrl;
            this.ObjectType = objectType;
            this.ObjectTitle = objectTitle;
            this.SiteUrl = siteUrl;
            this.WebUrl = webUrl;
            this.SpGroupManagement = spGroupManagement;
            this.PermissionManagement = permissionManagement;
            this.Id = id;
            this.ServiceId = serviceId;
            this.Department = department;
            this.Summary = summary;
            this.NotesToApprovers = notesToApprovers;
            this.QuestionnaireId = questionnaireId;
            this.Metadatas = metadatas;
        }
        
        /// <summary>
        /// Gets or Sets ObjectUrl
        /// </summary>
        [DataMember(Name="objectUrl", EmitDefaultValue=true)]
        public string ObjectUrl { get; set; }

        /// <summary>
        /// Gets or Sets ObjectTitle
        /// </summary>
        [DataMember(Name="objectTitle", EmitDefaultValue=true)]
        public string ObjectTitle { get; set; }

        /// <summary>
        /// Gets or Sets SiteUrl
        /// </summary>
        [DataMember(Name="siteUrl", EmitDefaultValue=true)]
        public string SiteUrl { get; set; }

        /// <summary>
        /// Gets or Sets WebUrl
        /// </summary>
        [DataMember(Name="webUrl", EmitDefaultValue=true)]
        public string WebUrl { get; set; }

        /// <summary>
        /// Gets or Sets SpGroupManagement
        /// </summary>
        [DataMember(Name="spGroupManagement", EmitDefaultValue=true)]
        public List<SPGroupManagementModel> SpGroupManagement { get; set; }

        /// <summary>
        /// Gets or Sets PermissionManagement
        /// </summary>
        [DataMember(Name="permissionManagement", EmitDefaultValue=true)]
        public PermissionManagementModel PermissionManagement { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets ServiceId
        /// </summary>
        [DataMember(Name="serviceId", EmitDefaultValue=false)]
        public Guid ServiceId { get; set; }

        /// <summary>
        /// Gets or Sets Department
        /// </summary>
        [DataMember(Name="department", EmitDefaultValue=true)]
        public string Department { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name="summary", EmitDefaultValue=true)]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or Sets NotesToApprovers
        /// </summary>
        [DataMember(Name="notesToApprovers", EmitDefaultValue=true)]
        public string NotesToApprovers { get; set; }

        /// <summary>
        /// Gets or Sets QuestionnaireId
        /// </summary>
        [DataMember(Name="questionnaireId", EmitDefaultValue=true)]
        public Guid? QuestionnaireId { get; set; }

        /// <summary>
        /// Gets or Sets Metadatas
        /// </summary>
        [DataMember(Name="metadatas", EmitDefaultValue=true)]
        public List<RequestMetadata> Metadatas { get; set; }

        /// <summary>
        /// Gets or Sets TicketNumber
        /// </summary>
        [DataMember(Name="ticketNumber", EmitDefaultValue=true)]
        public int? TicketNumber { get; private set; }

        /// <summary>
        /// Gets or Sets TypeDescription
        /// </summary>
        [DataMember(Name="typeDescription", EmitDefaultValue=true)]
        public string TypeDescription { get; private set; }

        /// <summary>
        /// Gets or Sets Requester
        /// </summary>
        [DataMember(Name="requester", EmitDefaultValue=true)]
        public string Requester { get; private set; }

        /// <summary>
        /// Gets or Sets ProgressStatus
        /// </summary>
        [DataMember(Name="progressStatus", EmitDefaultValue=false)]
        public int ProgressStatus { get; private set; }

        /// <summary>
        /// Gets or Sets ProgressStatusDescription
        /// </summary>
        [DataMember(Name="progressStatusDescription", EmitDefaultValue=true)]
        public string ProgressStatusDescription { get; private set; }

        /// <summary>
        /// Gets or Sets SubmittedTime
        /// </summary>
        [DataMember(Name="submittedTime", EmitDefaultValue=true)]
        public DateTime? SubmittedTime { get; private set; }

        /// <summary>
        /// Gets or Sets LastUpdated
        /// </summary>
        [DataMember(Name="lastUpdated", EmitDefaultValue=true)]
        public DateTime? LastUpdated { get; private set; }

        /// <summary>
        /// Gets or Sets CreatedTime
        /// </summary>
        [DataMember(Name="createdTime", EmitDefaultValue=true)]
        public DateTime? CreatedTime { get; private set; }

        /// <summary>
        /// Gets or Sets AssignTo
        /// </summary>
        [DataMember(Name="assignTo", EmitDefaultValue=true)]
        public string AssignTo { get; private set; }

        /// <summary>
        /// Gets or Sets FullPath
        /// </summary>
        [DataMember(Name="fullPath", EmitDefaultValue=true)]
        public string FullPath { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManagePermissionRequest {\n");
            sb.Append("  ObjectUrl: ").Append(ObjectUrl).Append("\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
            sb.Append("  ObjectTitle: ").Append(ObjectTitle).Append("\n");
            sb.Append("  SiteUrl: ").Append(SiteUrl).Append("\n");
            sb.Append("  WebUrl: ").Append(WebUrl).Append("\n");
            sb.Append("  SpGroupManagement: ").Append(SpGroupManagement).Append("\n");
            sb.Append("  PermissionManagement: ").Append(PermissionManagement).Append("\n");
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
            return this.Equals(input as ManagePermissionRequest);
        }

        /// <summary>
        /// Returns true if ManagePermissionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ManagePermissionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManagePermissionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectUrl == input.ObjectUrl ||
                    (this.ObjectUrl != null &&
                    this.ObjectUrl.Equals(input.ObjectUrl))
                ) && 
                (
                    this.ObjectType == input.ObjectType ||
                    this.ObjectType.Equals(input.ObjectType)
                ) && 
                (
                    this.ObjectTitle == input.ObjectTitle ||
                    (this.ObjectTitle != null &&
                    this.ObjectTitle.Equals(input.ObjectTitle))
                ) && 
                (
                    this.SiteUrl == input.SiteUrl ||
                    (this.SiteUrl != null &&
                    this.SiteUrl.Equals(input.SiteUrl))
                ) && 
                (
                    this.WebUrl == input.WebUrl ||
                    (this.WebUrl != null &&
                    this.WebUrl.Equals(input.WebUrl))
                ) && 
                (
                    this.SpGroupManagement == input.SpGroupManagement ||
                    this.SpGroupManagement != null &&
                    input.SpGroupManagement != null &&
                    this.SpGroupManagement.SequenceEqual(input.SpGroupManagement)
                ) && 
                (
                    this.PermissionManagement == input.PermissionManagement ||
                    (this.PermissionManagement != null &&
                    this.PermissionManagement.Equals(input.PermissionManagement))
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
                if (this.ObjectUrl != null)
                    hashCode = hashCode * 59 + this.ObjectUrl.GetHashCode();
                hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.ObjectTitle != null)
                    hashCode = hashCode * 59 + this.ObjectTitle.GetHashCode();
                if (this.SiteUrl != null)
                    hashCode = hashCode * 59 + this.SiteUrl.GetHashCode();
                if (this.WebUrl != null)
                    hashCode = hashCode * 59 + this.WebUrl.GetHashCode();
                if (this.SpGroupManagement != null)
                    hashCode = hashCode * 59 + this.SpGroupManagement.GetHashCode();
                if (this.PermissionManagement != null)
                    hashCode = hashCode * 59 + this.PermissionManagement.GetHashCode();
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
            if(this.NotesToApprovers != null && this.NotesToApprovers.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NotesToApprovers, length must be less than 255.", new [] { "NotesToApprovers" });
            }

            yield break;
        }
    }

}
