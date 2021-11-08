

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
    /// archive workspace parameter
    /// </summary>
    [DataContract(Name = "ArchiveWorkspaceParameter")]
    public partial class ArchiveWorkspaceParameter : IEquatable<ArchiveWorkspaceParameter>, IValidatableObject
    {
        /// <summary>
        /// workspace type
        /// </summary>
        /// <value>workspace type</value>
        [DataMember(Name = "workspaceType", EmitDefaultValue = false)]
        public WorkspaceArchivedType? WorkspaceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchiveWorkspaceParameter" /> class.
        /// </summary>
        /// <param name="archiveProfile">WorkspaceType is site, you should set profile name  WorkspaceType is teams, you should set profile id.</param>
        /// <param name="workspaceType">workspace type.</param>
        /// <param name="isSendCancelEmail">isSendCancelEmail (default to false).</param>
        /// <param name="cancelEmailTemplateId">cancelEmailTemplateId.</param>
        /// <param name="workspace">workspace.</param>
        public ArchiveWorkspaceParameter(string archiveProfile = default(string), WorkspaceArchivedType? workspaceType = default(WorkspaceArchivedType?), bool isSendCancelEmail = false, Guid cancelEmailTemplateId = default(Guid), List<WorkspaceIdTypeModel> workspace = default(List<WorkspaceIdTypeModel>))
        {
            this.ArchiveProfile = archiveProfile;
            this.WorkspaceType = workspaceType;
            this.IsSendCancelEmail = isSendCancelEmail;
            this.CancelEmailTemplateId = cancelEmailTemplateId;
            this.Workspace = workspace;
        }

        /// <summary>
        /// WorkspaceType is site, you should set profile name  WorkspaceType is teams, you should set profile id
        /// </summary>
        /// <value>WorkspaceType is site, you should set profile name  WorkspaceType is teams, you should set profile id</value>
        [DataMember(Name = "archiveProfile", EmitDefaultValue = true)]
        public string ArchiveProfile { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArchiveWorkspaceParameter {\n");
            sb.Append("  ArchiveProfile: ").Append(ArchiveProfile).Append("\n");
            sb.Append("  WorkspaceType: ").Append(WorkspaceType).Append("\n");
            sb.Append("  IsSendCancelEmail: ").Append(IsSendCancelEmail).Append("\n");
            sb.Append("  CancelEmailTemplateId: ").Append(CancelEmailTemplateId).Append("\n");
            sb.Append("  Workspace: ").Append(Workspace).Append("\n");
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
            return this.Equals(input as ArchiveWorkspaceParameter);
        }

        /// <summary>
        /// Returns true if ArchiveWorkspaceParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of ArchiveWorkspaceParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArchiveWorkspaceParameter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ArchiveProfile == input.ArchiveProfile ||
                    (this.ArchiveProfile != null &&
                    this.ArchiveProfile.Equals(input.ArchiveProfile))
                ) && 
                (
                    this.WorkspaceType == input.WorkspaceType ||
                    this.WorkspaceType.Equals(input.WorkspaceType)
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
                if (this.ArchiveProfile != null)
                    hashCode = hashCode * 59 + this.ArchiveProfile.GetHashCode();
                hashCode = hashCode * 59 + this.WorkspaceType.GetHashCode();
                hashCode = hashCode * 59 + this.IsSendCancelEmail.GetHashCode();
                if (this.CancelEmailTemplateId != null)
                    hashCode = hashCode * 59 + this.CancelEmailTemplateId.GetHashCode();
                if (this.Workspace != null)
                    hashCode = hashCode * 59 + this.Workspace.GetHashCode();
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
