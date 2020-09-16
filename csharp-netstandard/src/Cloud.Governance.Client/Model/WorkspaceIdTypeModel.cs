

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
    /// WorkspaceIdTypeModel
    /// </summary>
    [DataContract(Name = "WorkspaceIdTypeModel")]
    public partial class WorkspaceIdTypeModel : IEquatable<WorkspaceIdTypeModel>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets WorkspaceType
        /// </summary>
        [DataMember(Name = "workspaceType", EmitDefaultValue = false)]
        public WorkspaceType? WorkspaceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceIdTypeModel" /> class.
        /// </summary>
        /// <param name="objectId">objectId.</param>
        /// <param name="workspaceType">workspaceType.</param>
        public WorkspaceIdTypeModel(Guid objectId = default(Guid), WorkspaceType? workspaceType = default(WorkspaceType?))
        {
            this.ObjectId = objectId;
            this.WorkspaceType = workspaceType;
        }

        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name = "objectId", EmitDefaultValue = false)]
        public Guid ObjectId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkspaceIdTypeModel {\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
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
            return this.Equals(input as WorkspaceIdTypeModel);
        }

        /// <summary>
        /// Returns true if WorkspaceIdTypeModel instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkspaceIdTypeModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkspaceIdTypeModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
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
                if (this.ObjectId != null)
                    hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
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
