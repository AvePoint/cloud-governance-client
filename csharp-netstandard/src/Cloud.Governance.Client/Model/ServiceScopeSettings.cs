

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
    /// ServiceScopeSettings
    /// </summary>
    [DataContract(Name = "ServiceScopeSettings")]
    public partial class ServiceScopeSettings : IEquatable<ServiceScopeSettings>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets AutoPopulateUrlWithSPContextAssignBy
        /// </summary>
        [DataMember(Name = "autoPopulateUrlWithSPContextAssignBy", EmitDefaultValue = false)]
        public AssignBy? AutoPopulateUrlWithSPContextAssignBy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceScopeSettings" /> class.
        /// </summary>
        /// <param name="selectedNodes">selectedNodes.</param>
        /// <param name="autoPopulateUrlWithSPContext">autoPopulateUrlWithSPContext.</param>
        /// <param name="autoPopulateUrlWithSPContextAssignBy">autoPopulateUrlWithSPContextAssignBy.</param>
        public ServiceScopeSettings(List<SPNode> selectedNodes = default(List<SPNode>), bool autoPopulateUrlWithSPContext = default(bool), AssignBy? autoPopulateUrlWithSPContextAssignBy = default(AssignBy?))
        {
            this.SelectedNodes = selectedNodes;
            this.AutoPopulateUrlWithSPContext = autoPopulateUrlWithSPContext;
            this.AutoPopulateUrlWithSPContextAssignBy = autoPopulateUrlWithSPContextAssignBy;
        }

        /// <summary>
        /// Gets or Sets SelectedNodes
        /// </summary>
        [DataMember(Name = "selectedNodes", EmitDefaultValue = true)]
        public List<SPNode> SelectedNodes { get; set; }

        /// <summary>
        /// Gets or Sets AutoPopulateUrlWithSPContext
        /// </summary>
        [DataMember(Name = "autoPopulateUrlWithSPContext", EmitDefaultValue = false)]
        public bool AutoPopulateUrlWithSPContext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceScopeSettings {\n");
            sb.Append("  SelectedNodes: ").Append(SelectedNodes).Append("\n");
            sb.Append("  AutoPopulateUrlWithSPContext: ").Append(AutoPopulateUrlWithSPContext).Append("\n");
            sb.Append("  AutoPopulateUrlWithSPContextAssignBy: ").Append(AutoPopulateUrlWithSPContextAssignBy).Append("\n");
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
            return this.Equals(input as ServiceScopeSettings);
        }

        /// <summary>
        /// Returns true if ServiceScopeSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceScopeSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceScopeSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SelectedNodes == input.SelectedNodes ||
                    this.SelectedNodes != null &&
                    input.SelectedNodes != null &&
                    this.SelectedNodes.SequenceEqual(input.SelectedNodes)
                ) && 
                (
                    this.AutoPopulateUrlWithSPContext == input.AutoPopulateUrlWithSPContext ||
                    this.AutoPopulateUrlWithSPContext.Equals(input.AutoPopulateUrlWithSPContext)
                ) && 
                (
                    this.AutoPopulateUrlWithSPContextAssignBy == input.AutoPopulateUrlWithSPContextAssignBy ||
                    this.AutoPopulateUrlWithSPContextAssignBy.Equals(input.AutoPopulateUrlWithSPContextAssignBy)
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
                if (this.SelectedNodes != null)
                    hashCode = hashCode * 59 + this.SelectedNodes.GetHashCode();
                hashCode = hashCode * 59 + this.AutoPopulateUrlWithSPContext.GetHashCode();
                hashCode = hashCode * 59 + this.AutoPopulateUrlWithSPContextAssignBy.GetHashCode();
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
