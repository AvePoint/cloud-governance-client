

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
    /// ArchiveWorkspaceParameter
    /// </summary>
    [DataContract(Name = "ArchiveWorkspaceParameter")]
    public partial class ArchiveWorkspaceParameter : IEquatable<ArchiveWorkspaceParameter>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets WorkspaceType
        /// </summary>
        [DataMember(Name = "workspaceType", EmitDefaultValue = false)]
        public WorkspaceArchivedType? WorkspaceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchiveWorkspaceParameter" /> class.
        /// </summary>
        /// <param name="archiveProfile">archiveProfile.</param>
        /// <param name="objectIds">objectIds.</param>
        /// <param name="workspaceType">workspaceType.</param>
        public ArchiveWorkspaceParameter(string archiveProfile = default(string), List<Guid> objectIds = default(List<Guid>), WorkspaceArchivedType? workspaceType = default(WorkspaceArchivedType?))
        {
            this.ArchiveProfile = archiveProfile;
            this.ObjectIds = objectIds;
            this.WorkspaceType = workspaceType;
        }

        /// <summary>
        /// Gets or Sets ArchiveProfile
        /// </summary>
        [DataMember(Name = "archiveProfile", EmitDefaultValue = true)]
        public string ArchiveProfile { get; set; }

        /// <summary>
        /// Gets or Sets ObjectIds
        /// </summary>
        [DataMember(Name = "objectIds", EmitDefaultValue = true)]
        public List<Guid> ObjectIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArchiveWorkspaceParameter {\n");
            sb.Append("  ArchiveProfile: ").Append(ArchiveProfile).Append("\n");
            sb.Append("  ObjectIds: ").Append(ObjectIds).Append("\n");
            sb.Append("  WorkspaceType: ").Append(WorkspaceType).Append("\n");
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
                    this.ObjectIds == input.ObjectIds ||
                    this.ObjectIds != null &&
                    input.ObjectIds != null &&
                    this.ObjectIds.SequenceEqual(input.ObjectIds)
                ) && 
                (
                    this.WorkspaceType == input.WorkspaceType ||
                    this.WorkspaceType.Equals(input.WorkspaceType)
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
                if (this.ObjectIds != null)
                    hashCode = hashCode * 59 + this.ObjectIds.GetHashCode();
                hashCode = hashCode * 59 + this.WorkspaceType.GetHashCode();
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
