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
    /// AutoImportProfileRef
    /// </summary>
    [DataContract]
    public partial class AutoImportProfileRef :  IEquatable<AutoImportProfileRef>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoImportProfileRef" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="objectName">objectName.</param>
        /// <param name="notesToPrimaryContact">notesToPrimaryContact.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="defaultSecondaryContact">defaultSecondaryContact.</param>
        /// <param name="defaultPolicyId">defaultPolicyId.</param>
        /// <param name="departments">departments.</param>
        /// <param name="policies">policies.</param>
        /// <param name="loadDepartmentFromUps">loadDepartmentFromUps.</param>
        /// <param name="isLastStep">isLastStep.</param>
        /// <param name="metadatas">metadatas.</param>
        public AutoImportProfileRef(Guid id = default(Guid), string objectName = default(string), string notesToPrimaryContact = default(string), string name = default(string), string description = default(string), ApiUser defaultSecondaryContact = default(ApiUser), Guid defaultPolicyId = default(Guid), List<string> departments = default(List<string>), List<PolicyRef> policies = default(List<PolicyRef>), bool loadDepartmentFromUps = default(bool), bool isLastStep = default(bool), List<CustomMetadata> metadatas = default(List<CustomMetadata>))
        {
            this.Id = id;
            this.ObjectName = objectName;
            this.NotesToPrimaryContact = notesToPrimaryContact;
            this.Name = name;
            this.Description = description;
            this.DefaultSecondaryContact = defaultSecondaryContact;
            this.DefaultPolicyId = defaultPolicyId;
            this.Departments = departments;
            this.Policies = policies;
            this.LoadDepartmentFromUps = loadDepartmentFromUps;
            this.IsLastStep = isLastStep;
            this.Metadatas = metadatas;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets ObjectName
        /// </summary>
        [DataMember(Name="objectName", EmitDefaultValue=true)]
        public string ObjectName { get; set; }

        /// <summary>
        /// Gets or Sets NotesToPrimaryContact
        /// </summary>
        [DataMember(Name="notesToPrimaryContact", EmitDefaultValue=true)]
        public string NotesToPrimaryContact { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DefaultSecondaryContact
        /// </summary>
        [DataMember(Name="defaultSecondaryContact", EmitDefaultValue=true)]
        public ApiUser DefaultSecondaryContact { get; set; }

        /// <summary>
        /// Gets or Sets DefaultPolicyId
        /// </summary>
        [DataMember(Name="defaultPolicyId", EmitDefaultValue=false)]
        public Guid DefaultPolicyId { get; set; }

        /// <summary>
        /// Gets or Sets Departments
        /// </summary>
        [DataMember(Name="departments", EmitDefaultValue=true)]
        public List<string> Departments { get; set; }

        /// <summary>
        /// Gets or Sets Policies
        /// </summary>
        [DataMember(Name="policies", EmitDefaultValue=true)]
        public List<PolicyRef> Policies { get; set; }

        /// <summary>
        /// Gets or Sets LoadDepartmentFromUps
        /// </summary>
        [DataMember(Name="loadDepartmentFromUps", EmitDefaultValue=false)]
        public bool LoadDepartmentFromUps { get; set; }

        /// <summary>
        /// Gets or Sets IsLastStep
        /// </summary>
        [DataMember(Name="isLastStep", EmitDefaultValue=false)]
        public bool IsLastStep { get; set; }

        /// <summary>
        /// Gets or Sets Metadatas
        /// </summary>
        [DataMember(Name="metadatas", EmitDefaultValue=true)]
        public List<CustomMetadata> Metadatas { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoImportProfileRef {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ObjectName: ").Append(ObjectName).Append("\n");
            sb.Append("  NotesToPrimaryContact: ").Append(NotesToPrimaryContact).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DefaultSecondaryContact: ").Append(DefaultSecondaryContact).Append("\n");
            sb.Append("  DefaultPolicyId: ").Append(DefaultPolicyId).Append("\n");
            sb.Append("  Departments: ").Append(Departments).Append("\n");
            sb.Append("  Policies: ").Append(Policies).Append("\n");
            sb.Append("  LoadDepartmentFromUps: ").Append(LoadDepartmentFromUps).Append("\n");
            sb.Append("  IsLastStep: ").Append(IsLastStep).Append("\n");
            sb.Append("  Metadatas: ").Append(Metadatas).Append("\n");
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
            return this.Equals(input as AutoImportProfileRef);
        }

        /// <summary>
        /// Returns true if AutoImportProfileRef instances are equal
        /// </summary>
        /// <param name="input">Instance of AutoImportProfileRef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutoImportProfileRef input)
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
                    this.ObjectName == input.ObjectName ||
                    (this.ObjectName != null &&
                    this.ObjectName.Equals(input.ObjectName))
                ) && 
                (
                    this.NotesToPrimaryContact == input.NotesToPrimaryContact ||
                    (this.NotesToPrimaryContact != null &&
                    this.NotesToPrimaryContact.Equals(input.NotesToPrimaryContact))
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
                    this.DefaultSecondaryContact == input.DefaultSecondaryContact ||
                    (this.DefaultSecondaryContact != null &&
                    this.DefaultSecondaryContact.Equals(input.DefaultSecondaryContact))
                ) && 
                (
                    this.DefaultPolicyId == input.DefaultPolicyId ||
                    (this.DefaultPolicyId != null &&
                    this.DefaultPolicyId.Equals(input.DefaultPolicyId))
                ) && 
                (
                    this.Departments == input.Departments ||
                    this.Departments != null &&
                    input.Departments != null &&
                    this.Departments.SequenceEqual(input.Departments)
                ) && 
                (
                    this.Policies == input.Policies ||
                    this.Policies != null &&
                    input.Policies != null &&
                    this.Policies.SequenceEqual(input.Policies)
                ) && 
                (
                    this.LoadDepartmentFromUps == input.LoadDepartmentFromUps ||
                    this.LoadDepartmentFromUps.Equals(input.LoadDepartmentFromUps)
                ) && 
                (
                    this.IsLastStep == input.IsLastStep ||
                    this.IsLastStep.Equals(input.IsLastStep)
                ) && 
                (
                    this.Metadatas == input.Metadatas ||
                    this.Metadatas != null &&
                    input.Metadatas != null &&
                    this.Metadatas.SequenceEqual(input.Metadatas)
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
                if (this.ObjectName != null)
                    hashCode = hashCode * 59 + this.ObjectName.GetHashCode();
                if (this.NotesToPrimaryContact != null)
                    hashCode = hashCode * 59 + this.NotesToPrimaryContact.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DefaultSecondaryContact != null)
                    hashCode = hashCode * 59 + this.DefaultSecondaryContact.GetHashCode();
                if (this.DefaultPolicyId != null)
                    hashCode = hashCode * 59 + this.DefaultPolicyId.GetHashCode();
                if (this.Departments != null)
                    hashCode = hashCode * 59 + this.Departments.GetHashCode();
                if (this.Policies != null)
                    hashCode = hashCode * 59 + this.Policies.GetHashCode();
                hashCode = hashCode * 59 + this.LoadDepartmentFromUps.GetHashCode();
                hashCode = hashCode * 59 + this.IsLastStep.GetHashCode();
                if (this.Metadatas != null)
                    hashCode = hashCode * 59 + this.Metadatas.GetHashCode();
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
