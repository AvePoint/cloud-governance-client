

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
    /// GrantPermissionRequestPermissionSettings
    /// </summary>
    [DataContract(Name = "GrantPermissionRequestPermissionSettings")]
    public partial class GrantPermissionRequestPermissionSettings : IEquatable<GrantPermissionRequestPermissionSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GrantPermissionRequestPermissionSettings" /> class.
        /// </summary>
        /// <param name="isBreakInheritance">isBreakInheritance (default to false).</param>
        /// <param name="isGrantPermissionDirectly">isGrantPermissionDirectly (default to false).</param>
        /// <param name="selectedSPGroup">selectedSPGroup.</param>
        /// <param name="selectedPermissionLevels">selectedPermissionLevels.</param>
        public GrantPermissionRequestPermissionSettings(bool isBreakInheritance = false, bool isGrantPermissionDirectly = false, GrantPermissionGroup selectedSPGroup = default(GrantPermissionGroup), List<IntModel> selectedPermissionLevels = default(List<IntModel>))
        {
            this.IsBreakInheritance = isBreakInheritance;
            this.IsGrantPermissionDirectly = isGrantPermissionDirectly;
            this.SelectedSPGroup = selectedSPGroup;
            this.SelectedPermissionLevels = selectedPermissionLevels;
        }

        /// <summary>
        /// Gets or Sets IsBreakInheritance
        /// </summary>
        [DataMember(Name = "isBreakInheritance", EmitDefaultValue = false)]
        public bool IsBreakInheritance { get; set; }

        /// <summary>
        /// Gets or Sets IsGrantPermissionDirectly
        /// </summary>
        [DataMember(Name = "isGrantPermissionDirectly", EmitDefaultValue = false)]
        public bool IsGrantPermissionDirectly { get; set; }

        /// <summary>
        /// Gets or Sets SelectedSPGroup
        /// </summary>
        [DataMember(Name = "selectedSPGroup", EmitDefaultValue = true)]
        public GrantPermissionGroup SelectedSPGroup { get; set; }

        /// <summary>
        /// Gets or Sets SelectedPermissionLevels
        /// </summary>
        [DataMember(Name = "selectedPermissionLevels", EmitDefaultValue = true)]
        public List<IntModel> SelectedPermissionLevels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GrantPermissionRequestPermissionSettings {\n");
            sb.Append("  IsBreakInheritance: ").Append(IsBreakInheritance).Append("\n");
            sb.Append("  IsGrantPermissionDirectly: ").Append(IsGrantPermissionDirectly).Append("\n");
            sb.Append("  SelectedSPGroup: ").Append(SelectedSPGroup).Append("\n");
            sb.Append("  SelectedPermissionLevels: ").Append(SelectedPermissionLevels).Append("\n");
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
            return this.Equals(input as GrantPermissionRequestPermissionSettings);
        }

        /// <summary>
        /// Returns true if GrantPermissionRequestPermissionSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of GrantPermissionRequestPermissionSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GrantPermissionRequestPermissionSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsBreakInheritance == input.IsBreakInheritance ||
                    this.IsBreakInheritance.Equals(input.IsBreakInheritance)
                ) && 
                (
                    this.IsGrantPermissionDirectly == input.IsGrantPermissionDirectly ||
                    this.IsGrantPermissionDirectly.Equals(input.IsGrantPermissionDirectly)
                ) && 
                (
                    this.SelectedSPGroup == input.SelectedSPGroup ||
                    (this.SelectedSPGroup != null &&
                    this.SelectedSPGroup.Equals(input.SelectedSPGroup))
                ) && 
                (
                    this.SelectedPermissionLevels == input.SelectedPermissionLevels ||
                    this.SelectedPermissionLevels != null &&
                    input.SelectedPermissionLevels != null &&
                    this.SelectedPermissionLevels.SequenceEqual(input.SelectedPermissionLevels)
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
                hashCode = hashCode * 59 + this.IsBreakInheritance.GetHashCode();
                hashCode = hashCode * 59 + this.IsGrantPermissionDirectly.GetHashCode();
                if (this.SelectedSPGroup != null)
                    hashCode = hashCode * 59 + this.SelectedSPGroup.GetHashCode();
                if (this.SelectedPermissionLevels != null)
                    hashCode = hashCode * 59 + this.SelectedPermissionLevels.GetHashCode();
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
