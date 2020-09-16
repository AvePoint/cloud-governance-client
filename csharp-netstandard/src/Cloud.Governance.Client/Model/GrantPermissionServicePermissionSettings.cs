

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
    /// GrantPermissionServicePermissionSettings
    /// </summary>
    [DataContract(Name = "GrantPermissionServicePermissionSettings")]
    public partial class GrantPermissionServicePermissionSettings : IEquatable<GrantPermissionServicePermissionSettings>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets AssignBy
        /// </summary>
        [DataMember(Name = "assignBy", EmitDefaultValue = false)]
        public AssignBy? AssignBy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GrantPermissionServicePermissionSettings" /> class.
        /// </summary>
        /// <param name="assignBy">assignBy.</param>
        /// <param name="isGrantPermissionDirectly">isGrantPermissionDirectly.</param>
        /// <param name="enableExcludePermissionLevles">enableExcludePermissionLevles.</param>
        /// <param name="excludedPermissionLevles">excludedPermissionLevles.</param>
        public GrantPermissionServicePermissionSettings(AssignBy? assignBy = default(AssignBy?), bool isGrantPermissionDirectly = default(bool), bool enableExcludePermissionLevles = default(bool), List<PermissionLevel> excludedPermissionLevles = default(List<PermissionLevel>))
        {
            this.AssignBy = assignBy;
            this.IsGrantPermissionDirectly = isGrantPermissionDirectly;
            this.EnableExcludePermissionLevles = enableExcludePermissionLevles;
            this.ExcludedPermissionLevles = excludedPermissionLevles;
        }

        /// <summary>
        /// Gets or Sets IsGrantPermissionDirectly
        /// </summary>
        [DataMember(Name = "isGrantPermissionDirectly", EmitDefaultValue = false)]
        public bool IsGrantPermissionDirectly { get; set; }

        /// <summary>
        /// Gets or Sets EnableExcludePermissionLevles
        /// </summary>
        [DataMember(Name = "enableExcludePermissionLevles", EmitDefaultValue = false)]
        public bool EnableExcludePermissionLevles { get; set; }

        /// <summary>
        /// Gets or Sets ExcludedPermissionLevles
        /// </summary>
        [DataMember(Name = "excludedPermissionLevles", EmitDefaultValue = true)]
        public List<PermissionLevel> ExcludedPermissionLevles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GrantPermissionServicePermissionSettings {\n");
            sb.Append("  AssignBy: ").Append(AssignBy).Append("\n");
            sb.Append("  IsGrantPermissionDirectly: ").Append(IsGrantPermissionDirectly).Append("\n");
            sb.Append("  EnableExcludePermissionLevles: ").Append(EnableExcludePermissionLevles).Append("\n");
            sb.Append("  ExcludedPermissionLevles: ").Append(ExcludedPermissionLevles).Append("\n");
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
            return this.Equals(input as GrantPermissionServicePermissionSettings);
        }

        /// <summary>
        /// Returns true if GrantPermissionServicePermissionSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of GrantPermissionServicePermissionSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GrantPermissionServicePermissionSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssignBy == input.AssignBy ||
                    this.AssignBy.Equals(input.AssignBy)
                ) && 
                (
                    this.IsGrantPermissionDirectly == input.IsGrantPermissionDirectly ||
                    this.IsGrantPermissionDirectly.Equals(input.IsGrantPermissionDirectly)
                ) && 
                (
                    this.EnableExcludePermissionLevles == input.EnableExcludePermissionLevles ||
                    this.EnableExcludePermissionLevles.Equals(input.EnableExcludePermissionLevles)
                ) && 
                (
                    this.ExcludedPermissionLevles == input.ExcludedPermissionLevles ||
                    this.ExcludedPermissionLevles != null &&
                    input.ExcludedPermissionLevles != null &&
                    this.ExcludedPermissionLevles.SequenceEqual(input.ExcludedPermissionLevles)
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
                hashCode = hashCode * 59 + this.AssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.IsGrantPermissionDirectly.GetHashCode();
                hashCode = hashCode * 59 + this.EnableExcludePermissionLevles.GetHashCode();
                if (this.ExcludedPermissionLevles != null)
                    hashCode = hashCode * 59 + this.ExcludedPermissionLevles.GetHashCode();
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
