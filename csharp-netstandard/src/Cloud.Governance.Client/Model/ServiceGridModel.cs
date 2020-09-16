

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
    /// ServiceGridModel
    /// </summary>
    [DataContract(Name = "ServiceGridModel")]
    public partial class ServiceGridModel : IEquatable<ServiceGridModel>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ServiceType
        /// </summary>
        [DataMember(Name = "serviceType", EmitDefaultValue = false)]
        public ServiceType? ServiceType { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public CommonStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceGridModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="description">description.</param>
        /// <param name="name">name.</param>
        /// <param name="serviceType">serviceType.</param>
        /// <param name="serviceTypeDescription">serviceTypeDescription.</param>
        /// <param name="status">status.</param>
        /// <param name="statusDescription">statusDescription.</param>
        /// <param name="language">language.</param>
        /// <param name="modifiedTime">modifiedTime.</param>
        /// <param name="createdByDisplayName">createdByDisplayName.</param>
        /// <param name="createdBy">createdBy.</param>
        public ServiceGridModel(Guid id = default(Guid), string description = default(string), string name = default(string), ServiceType? serviceType = default(ServiceType?), string serviceTypeDescription = default(string), CommonStatus? status = default(CommonStatus?), string statusDescription = default(string), int language = default(int), DateTime modifiedTime = default(DateTime), string createdByDisplayName = default(string), string createdBy = default(string))
        {
            this.Id = id;
            this.Description = description;
            this.Name = name;
            this.ServiceType = serviceType;
            this.ServiceTypeDescription = serviceTypeDescription;
            this.Status = status;
            this.StatusDescription = statusDescription;
            this.Language = language;
            this.ModifiedTime = modifiedTime;
            this.CreatedByDisplayName = createdByDisplayName;
            this.CreatedBy = createdBy;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ServiceTypeDescription
        /// </summary>
        [DataMember(Name = "serviceTypeDescription", EmitDefaultValue = true)]
        public string ServiceTypeDescription { get; set; }

        /// <summary>
        /// Gets or Sets StatusDescription
        /// </summary>
        [DataMember(Name = "statusDescription", EmitDefaultValue = true)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public int Language { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedTime
        /// </summary>
        [DataMember(Name = "modifiedTime", EmitDefaultValue = false)]
        public DateTime ModifiedTime { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByDisplayName
        /// </summary>
        [DataMember(Name = "createdByDisplayName", EmitDefaultValue = true)]
        public string CreatedByDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "createdBy", EmitDefaultValue = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceGridModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
            sb.Append("  ServiceTypeDescription: ").Append(ServiceTypeDescription).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  ModifiedTime: ").Append(ModifiedTime).Append("\n");
            sb.Append("  CreatedByDisplayName: ").Append(CreatedByDisplayName).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
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
            return this.Equals(input as ServiceGridModel);
        }

        /// <summary>
        /// Returns true if ServiceGridModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceGridModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceGridModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ServiceType == input.ServiceType ||
                    this.ServiceType.Equals(input.ServiceType)
                ) && 
                (
                    this.ServiceTypeDescription == input.ServiceTypeDescription ||
                    (this.ServiceTypeDescription != null &&
                    this.ServiceTypeDescription.Equals(input.ServiceTypeDescription))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.StatusDescription == input.StatusDescription ||
                    (this.StatusDescription != null &&
                    this.StatusDescription.Equals(input.StatusDescription))
                ) && 
                (
                    this.Language == input.Language ||
                    this.Language.Equals(input.Language)
                ) && 
                (
                    this.ModifiedTime == input.ModifiedTime ||
                    (this.ModifiedTime != null &&
                    this.ModifiedTime.Equals(input.ModifiedTime))
                ) && 
                (
                    this.CreatedByDisplayName == input.CreatedByDisplayName ||
                    (this.CreatedByDisplayName != null &&
                    this.CreatedByDisplayName.Equals(input.CreatedByDisplayName))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.ServiceTypeDescription != null)
                    hashCode = hashCode * 59 + this.ServiceTypeDescription.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusDescription != null)
                    hashCode = hashCode * 59 + this.StatusDescription.GetHashCode();
                hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.ModifiedTime != null)
                    hashCode = hashCode * 59 + this.ModifiedTime.GetHashCode();
                if (this.CreatedByDisplayName != null)
                    hashCode = hashCode * 59 + this.CreatedByDisplayName.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
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
