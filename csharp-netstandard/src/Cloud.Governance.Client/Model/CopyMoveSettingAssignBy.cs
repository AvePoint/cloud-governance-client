

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
    /// CopyMoveSettingAssignBy
    /// </summary>
    [DataContract(Name = "CopyMoveSettingAssignBy")]
    public partial class CopyMoveSettingAssignBy : IEquatable<CopyMoveSettingAssignBy>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ConfigurationAssignBy
        /// </summary>
        [DataMember(Name = "configurationAssignBy", EmitDefaultValue = false)]
        public AssignBy? ConfigurationAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets SecurityAssignBy
        /// </summary>
        [DataMember(Name = "securityAssignBy", EmitDefaultValue = false)]
        public AssignBy? SecurityAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets ContentAssignBy
        /// </summary>
        [DataMember(Name = "contentAssignBy", EmitDefaultValue = false)]
        public AssignBy? ContentAssignBy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CopyMoveSettingAssignBy" /> class.
        /// </summary>
        /// <param name="configurationAssignBy">configurationAssignBy.</param>
        /// <param name="securityAssignBy">securityAssignBy.</param>
        /// <param name="contentAssignBy">contentAssignBy.</param>
        public CopyMoveSettingAssignBy(AssignBy? configurationAssignBy = default(AssignBy?), AssignBy? securityAssignBy = default(AssignBy?), AssignBy? contentAssignBy = default(AssignBy?))
        {
            this.ConfigurationAssignBy = configurationAssignBy;
            this.SecurityAssignBy = securityAssignBy;
            this.ContentAssignBy = contentAssignBy;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CopyMoveSettingAssignBy {\n");
            sb.Append("  ConfigurationAssignBy: ").Append(ConfigurationAssignBy).Append("\n");
            sb.Append("  SecurityAssignBy: ").Append(SecurityAssignBy).Append("\n");
            sb.Append("  ContentAssignBy: ").Append(ContentAssignBy).Append("\n");
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
            return this.Equals(input as CopyMoveSettingAssignBy);
        }

        /// <summary>
        /// Returns true if CopyMoveSettingAssignBy instances are equal
        /// </summary>
        /// <param name="input">Instance of CopyMoveSettingAssignBy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CopyMoveSettingAssignBy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConfigurationAssignBy == input.ConfigurationAssignBy ||
                    this.ConfigurationAssignBy.Equals(input.ConfigurationAssignBy)
                ) && 
                (
                    this.SecurityAssignBy == input.SecurityAssignBy ||
                    this.SecurityAssignBy.Equals(input.SecurityAssignBy)
                ) && 
                (
                    this.ContentAssignBy == input.ContentAssignBy ||
                    this.ContentAssignBy.Equals(input.ContentAssignBy)
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
                hashCode = hashCode * 59 + this.ConfigurationAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.SecurityAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.ContentAssignBy.GetHashCode();
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
