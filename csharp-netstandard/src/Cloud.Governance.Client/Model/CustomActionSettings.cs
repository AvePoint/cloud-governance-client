

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
    /// CustomActionSettings
    /// </summary>
    [DataContract(Name = "CustomActionSettings")]
    public partial class CustomActionSettings : IEquatable<CustomActionSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomActionSettings" /> class.
        /// </summary>
        /// <param name="beforeApprovalProcessExecution">beforeApprovalProcessExecution.</param>
        /// <param name="afterApprovalProcessExecution">afterApprovalProcessExecution.</param>
        /// <param name="postExecution">postExecution.</param>
        /// <param name="beforeSubmission">beforeSubmission.</param>
        /// <param name="whenErrorTaskGenerated">whenErrorTaskGenerated.</param>
        public CustomActionSettings(ExecutionModel beforeApprovalProcessExecution = default(ExecutionModel), ExecutionModel afterApprovalProcessExecution = default(ExecutionModel), ExecutionModel postExecution = default(ExecutionModel), ExecutionModel beforeSubmission = default(ExecutionModel), ExecutionModel whenErrorTaskGenerated = default(ExecutionModel))
        {
            this.BeforeApprovalProcessExecution = beforeApprovalProcessExecution;
            this.AfterApprovalProcessExecution = afterApprovalProcessExecution;
            this.PostExecution = postExecution;
            this.BeforeSubmission = beforeSubmission;
            this.WhenErrorTaskGenerated = whenErrorTaskGenerated;
        }

        /// <summary>
        /// Gets or Sets BeforeApprovalProcessExecution
        /// </summary>
        [DataMember(Name = "beforeApprovalProcessExecution", EmitDefaultValue = true)]
        public ExecutionModel BeforeApprovalProcessExecution { get; set; }

        /// <summary>
        /// Gets or Sets AfterApprovalProcessExecution
        /// </summary>
        [DataMember(Name = "afterApprovalProcessExecution", EmitDefaultValue = true)]
        public ExecutionModel AfterApprovalProcessExecution { get; set; }

        /// <summary>
        /// Gets or Sets PostExecution
        /// </summary>
        [DataMember(Name = "postExecution", EmitDefaultValue = true)]
        public ExecutionModel PostExecution { get; set; }

        /// <summary>
        /// Gets or Sets BeforeSubmission
        /// </summary>
        [DataMember(Name = "beforeSubmission", EmitDefaultValue = true)]
        public ExecutionModel BeforeSubmission { get; set; }

        /// <summary>
        /// Gets or Sets WhenErrorTaskGenerated
        /// </summary>
        [DataMember(Name = "whenErrorTaskGenerated", EmitDefaultValue = true)]
        public ExecutionModel WhenErrorTaskGenerated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomActionSettings {\n");
            sb.Append("  BeforeApprovalProcessExecution: ").Append(BeforeApprovalProcessExecution).Append("\n");
            sb.Append("  AfterApprovalProcessExecution: ").Append(AfterApprovalProcessExecution).Append("\n");
            sb.Append("  PostExecution: ").Append(PostExecution).Append("\n");
            sb.Append("  BeforeSubmission: ").Append(BeforeSubmission).Append("\n");
            sb.Append("  WhenErrorTaskGenerated: ").Append(WhenErrorTaskGenerated).Append("\n");
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
            return this.Equals(input as CustomActionSettings);
        }

        /// <summary>
        /// Returns true if CustomActionSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomActionSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomActionSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BeforeApprovalProcessExecution == input.BeforeApprovalProcessExecution ||
                    (this.BeforeApprovalProcessExecution != null &&
                    this.BeforeApprovalProcessExecution.Equals(input.BeforeApprovalProcessExecution))
                ) && 
                (
                    this.AfterApprovalProcessExecution == input.AfterApprovalProcessExecution ||
                    (this.AfterApprovalProcessExecution != null &&
                    this.AfterApprovalProcessExecution.Equals(input.AfterApprovalProcessExecution))
                ) && 
                (
                    this.PostExecution == input.PostExecution ||
                    (this.PostExecution != null &&
                    this.PostExecution.Equals(input.PostExecution))
                ) && 
                (
                    this.BeforeSubmission == input.BeforeSubmission ||
                    (this.BeforeSubmission != null &&
                    this.BeforeSubmission.Equals(input.BeforeSubmission))
                ) && 
                (
                    this.WhenErrorTaskGenerated == input.WhenErrorTaskGenerated ||
                    (this.WhenErrorTaskGenerated != null &&
                    this.WhenErrorTaskGenerated.Equals(input.WhenErrorTaskGenerated))
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
                if (this.BeforeApprovalProcessExecution != null)
                    hashCode = hashCode * 59 + this.BeforeApprovalProcessExecution.GetHashCode();
                if (this.AfterApprovalProcessExecution != null)
                    hashCode = hashCode * 59 + this.AfterApprovalProcessExecution.GetHashCode();
                if (this.PostExecution != null)
                    hashCode = hashCode * 59 + this.PostExecution.GetHashCode();
                if (this.BeforeSubmission != null)
                    hashCode = hashCode * 59 + this.BeforeSubmission.GetHashCode();
                if (this.WhenErrorTaskGenerated != null)
                    hashCode = hashCode * 59 + this.WhenErrorTaskGenerated.GetHashCode();
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
