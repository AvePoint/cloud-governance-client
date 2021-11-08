

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
    /// WorkspaceActionParameter
    /// </summary>
    [DataContract(Name = "WorkspaceActionParameter")]
    public partial class WorkspaceActionParameter : IEquatable<WorkspaceActionParameter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceActionParameter" /> class.
        /// </summary>
        /// <param name="workspace">workspace.</param>
        public WorkspaceActionParameter(List<WorkspaceIdTypeModel> workspace = default(List<WorkspaceIdTypeModel>))
        {
            this.Workspace = workspace;
        }

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
            sb.Append("class WorkspaceActionParameter {\n");
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
            return this.Equals(input as WorkspaceActionParameter);
        }

        /// <summary>
        /// Returns true if WorkspaceActionParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkspaceActionParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkspaceActionParameter input)
        {
            if (input == null)
                return false;

            return 
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
