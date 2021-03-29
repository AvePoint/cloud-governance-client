

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
    /// GroupNameConstructureSettings
    /// </summary>
    [DataContract(Name = "GroupNameConstructureSettings")]
    public partial class GroupNameConstructureSettings : IEquatable<GroupNameConstructureSettings>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets AssignBy
        /// </summary>
        [DataMember(Name = "assignBy", EmitDefaultValue = false)]
        public AssignBy? AssignBy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupNameConstructureSettings" /> class.
        /// </summary>
        /// <param name="enabled">enabled (default to false).</param>
        /// <param name="assignBy">assignBy.</param>
        /// <param name="prefixs">prefixs.</param>
        /// <param name="suffixs">suffixs.</param>
        public GroupNameConstructureSettings(bool enabled = false, AssignBy? assignBy = default(AssignBy?), List<GroupConstructureRule> prefixs = default(List<GroupConstructureRule>), List<GroupConstructureRule> suffixs = default(List<GroupConstructureRule>))
        {
            this.Enabled = enabled;
            this.AssignBy = assignBy;
            this.Prefixs = prefixs;
            this.Suffixs = suffixs;
        }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Prefixs
        /// </summary>
        [DataMember(Name = "prefixs", EmitDefaultValue = true)]
        public List<GroupConstructureRule> Prefixs { get; set; }

        /// <summary>
        /// Gets or Sets Suffixs
        /// </summary>
        [DataMember(Name = "suffixs", EmitDefaultValue = true)]
        public List<GroupConstructureRule> Suffixs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupNameConstructureSettings {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  AssignBy: ").Append(AssignBy).Append("\n");
            sb.Append("  Prefixs: ").Append(Prefixs).Append("\n");
            sb.Append("  Suffixs: ").Append(Suffixs).Append("\n");
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
            return this.Equals(input as GroupNameConstructureSettings);
        }

        /// <summary>
        /// Returns true if GroupNameConstructureSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupNameConstructureSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupNameConstructureSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.AssignBy == input.AssignBy ||
                    this.AssignBy.Equals(input.AssignBy)
                ) && 
                (
                    this.Prefixs == input.Prefixs ||
                    this.Prefixs != null &&
                    input.Prefixs != null &&
                    this.Prefixs.SequenceEqual(input.Prefixs)
                ) && 
                (
                    this.Suffixs == input.Suffixs ||
                    this.Suffixs != null &&
                    input.Suffixs != null &&
                    this.Suffixs.SequenceEqual(input.Suffixs)
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
                hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                hashCode = hashCode * 59 + this.AssignBy.GetHashCode();
                if (this.Prefixs != null)
                    hashCode = hashCode * 59 + this.Prefixs.GetHashCode();
                if (this.Suffixs != null)
                    hashCode = hashCode * 59 + this.Suffixs.GetHashCode();
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
