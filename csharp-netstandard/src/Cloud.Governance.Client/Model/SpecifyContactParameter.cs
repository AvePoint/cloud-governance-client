

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
    /// SpecifyContactParameter
    /// </summary>
    [DataContract(Name = "SpecifyContactParameter")]
    public partial class SpecifyContactParameter : IEquatable<SpecifyContactParameter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecifyContactParameter" /> class.
        /// </summary>
        /// <param name="primaryContact">ApiUser model.</param>
        /// <param name="secondaryContact">ApiUser model.</param>
        /// <param name="primaryContactNotifiedEmail">primaryContactNotifiedEmail.</param>
        /// <param name="secondaryContactNotifiedEmail">secondaryContactNotifiedEmail.</param>
        /// <param name="workspace">workspace.</param>
        /// <param name="isSelectAllWorkspace">isSelectAllWorkspace (default to false).</param>
        public SpecifyContactParameter(ApiUser primaryContact = default(ApiUser), ApiUser secondaryContact = default(ApiUser), Guid primaryContactNotifiedEmail = default(Guid), Guid secondaryContactNotifiedEmail = default(Guid), List<WorkspaceIdTypeModel> workspace = default(List<WorkspaceIdTypeModel>), bool isSelectAllWorkspace = false)
        {
            this.PrimaryContact = primaryContact;
            this.SecondaryContact = secondaryContact;
            this.PrimaryContactNotifiedEmail = primaryContactNotifiedEmail;
            this.SecondaryContactNotifiedEmail = secondaryContactNotifiedEmail;
            this.Workspace = workspace;
            this.IsSelectAllWorkspace = isSelectAllWorkspace;
        }

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
        /// Gets or Sets PrimaryContactNotifiedEmail
        /// </summary>
        [DataMember(Name = "primaryContactNotifiedEmail", EmitDefaultValue = false)]
        public Guid PrimaryContactNotifiedEmail { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryContactNotifiedEmail
        /// </summary>
        [DataMember(Name = "secondaryContactNotifiedEmail", EmitDefaultValue = false)]
        public Guid SecondaryContactNotifiedEmail { get; set; }

        /// <summary>
        /// Gets or Sets Workspace
        /// </summary>
        [DataMember(Name = "workspace", EmitDefaultValue = true)]
        public List<WorkspaceIdTypeModel> Workspace { get; set; }

        /// <summary>
        /// Gets or Sets IsSelectAllWorkspace
        /// </summary>
        [DataMember(Name = "isSelectAllWorkspace", EmitDefaultValue = false)]
        public bool IsSelectAllWorkspace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpecifyContactParameter {\n");
            sb.Append("  PrimaryContact: ").Append(PrimaryContact).Append("\n");
            sb.Append("  SecondaryContact: ").Append(SecondaryContact).Append("\n");
            sb.Append("  PrimaryContactNotifiedEmail: ").Append(PrimaryContactNotifiedEmail).Append("\n");
            sb.Append("  SecondaryContactNotifiedEmail: ").Append(SecondaryContactNotifiedEmail).Append("\n");
            sb.Append("  Workspace: ").Append(Workspace).Append("\n");
            sb.Append("  IsSelectAllWorkspace: ").Append(IsSelectAllWorkspace).Append("\n");
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
            return this.Equals(input as SpecifyContactParameter);
        }

        /// <summary>
        /// Returns true if SpecifyContactParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of SpecifyContactParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpecifyContactParameter input)
        {
            if (input == null)
                return false;

            return 
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
                    this.PrimaryContactNotifiedEmail == input.PrimaryContactNotifiedEmail ||
                    (this.PrimaryContactNotifiedEmail != null &&
                    this.PrimaryContactNotifiedEmail.Equals(input.PrimaryContactNotifiedEmail))
                ) && 
                (
                    this.SecondaryContactNotifiedEmail == input.SecondaryContactNotifiedEmail ||
                    (this.SecondaryContactNotifiedEmail != null &&
                    this.SecondaryContactNotifiedEmail.Equals(input.SecondaryContactNotifiedEmail))
                ) && 
                (
                    this.Workspace == input.Workspace ||
                    this.Workspace != null &&
                    input.Workspace != null &&
                    this.Workspace.SequenceEqual(input.Workspace)
                ) && 
                (
                    this.IsSelectAllWorkspace == input.IsSelectAllWorkspace ||
                    this.IsSelectAllWorkspace.Equals(input.IsSelectAllWorkspace)
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
                if (this.PrimaryContact != null)
                    hashCode = hashCode * 59 + this.PrimaryContact.GetHashCode();
                if (this.SecondaryContact != null)
                    hashCode = hashCode * 59 + this.SecondaryContact.GetHashCode();
                if (this.PrimaryContactNotifiedEmail != null)
                    hashCode = hashCode * 59 + this.PrimaryContactNotifiedEmail.GetHashCode();
                if (this.SecondaryContactNotifiedEmail != null)
                    hashCode = hashCode * 59 + this.SecondaryContactNotifiedEmail.GetHashCode();
                if (this.Workspace != null)
                    hashCode = hashCode * 59 + this.Workspace.GetHashCode();
                hashCode = hashCode * 59 + this.IsSelectAllWorkspace.GetHashCode();
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
