

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
    /// DeleteWorkspaceParameter
    /// </summary>
    [DataContract(Name = "DeleteWorkspaceParameter")]
    public partial class DeleteWorkspaceParameter : IEquatable<DeleteWorkspaceParameter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteWorkspaceParameter" /> class.
        /// </summary>
        /// <param name="enableRemoveObject">enableRemoveObject (default to false).</param>
        /// <param name="isSendCancelEmail">isSendCancelEmail (default to false).</param>
        /// <param name="cancelEmailTemplateId">cancelEmailTemplateId.</param>
        /// <param name="workspace">workspace.</param>
        /// <param name="isSelectAllWorkspace">isSelectAllWorkspace (default to false).</param>
        public DeleteWorkspaceParameter(bool enableRemoveObject = false, bool isSendCancelEmail = false, Guid cancelEmailTemplateId = default(Guid), List<WorkspaceIdTypeModel> workspace = default(List<WorkspaceIdTypeModel>), bool isSelectAllWorkspace = false)
        {
            this.EnableRemoveObject = enableRemoveObject;
            this.IsSendCancelEmail = isSendCancelEmail;
            this.CancelEmailTemplateId = cancelEmailTemplateId;
            this.Workspace = workspace;
            this.IsSelectAllWorkspace = isSelectAllWorkspace;
        }

        /// <summary>
        /// Gets or Sets EnableRemoveObject
        /// </summary>
        [DataMember(Name = "enableRemoveObject", EmitDefaultValue = false)]
        public bool EnableRemoveObject { get; set; }

        /// <summary>
        /// Gets or Sets IsSendCancelEmail
        /// </summary>
        [DataMember(Name = "isSendCancelEmail", EmitDefaultValue = false)]
        public bool IsSendCancelEmail { get; set; }

        /// <summary>
        /// Gets or Sets CancelEmailTemplateId
        /// </summary>
        [DataMember(Name = "cancelEmailTemplateId", EmitDefaultValue = false)]
        public Guid CancelEmailTemplateId { get; set; }

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
            sb.Append("class DeleteWorkspaceParameter {\n");
            sb.Append("  EnableRemoveObject: ").Append(EnableRemoveObject).Append("\n");
            sb.Append("  IsSendCancelEmail: ").Append(IsSendCancelEmail).Append("\n");
            sb.Append("  CancelEmailTemplateId: ").Append(CancelEmailTemplateId).Append("\n");
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
            return this.Equals(input as DeleteWorkspaceParameter);
        }

        /// <summary>
        /// Returns true if DeleteWorkspaceParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteWorkspaceParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteWorkspaceParameter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnableRemoveObject == input.EnableRemoveObject ||
                    this.EnableRemoveObject.Equals(input.EnableRemoveObject)
                ) && 
                (
                    this.IsSendCancelEmail == input.IsSendCancelEmail ||
                    this.IsSendCancelEmail.Equals(input.IsSendCancelEmail)
                ) && 
                (
                    this.CancelEmailTemplateId == input.CancelEmailTemplateId ||
                    (this.CancelEmailTemplateId != null &&
                    this.CancelEmailTemplateId.Equals(input.CancelEmailTemplateId))
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
                hashCode = hashCode * 59 + this.EnableRemoveObject.GetHashCode();
                hashCode = hashCode * 59 + this.IsSendCancelEmail.GetHashCode();
                if (this.CancelEmailTemplateId != null)
                    hashCode = hashCode * 59 + this.CancelEmailTemplateId.GetHashCode();
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
