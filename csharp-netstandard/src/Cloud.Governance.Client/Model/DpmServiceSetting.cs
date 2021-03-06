

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
    /// DpmServiceSetting
    /// </summary>
    [DataContract(Name = "DpmServiceSetting")]
    public partial class DpmServiceSetting : IEquatable<DpmServiceSetting>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets AssignBy
        /// </summary>
        [DataMember(Name = "assignBy", EmitDefaultValue = false)]
        public AssignBy? AssignBy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DpmServiceSetting" /> class.
        /// </summary>
        /// <param name="isEnabled">isEnabled (default to false).</param>
        /// <param name="defaultValue">defaultValue.</param>
        /// <param name="selectedItems">selectedItems.</param>
        /// <param name="assignBy">assignBy.</param>
        public DpmServiceSetting(bool isEnabled = false, string defaultValue = default(string), List<string> selectedItems = default(List<string>), AssignBy? assignBy = default(AssignBy?))
        {
            this.IsEnabled = isEnabled;
            this.DefaultValue = defaultValue;
            this.SelectedItems = selectedItems;
            this.AssignBy = assignBy;
        }

        /// <summary>
        /// Gets or Sets IsEnabled
        /// </summary>
        [DataMember(Name = "isEnabled", EmitDefaultValue = false)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets DefaultValue
        /// </summary>
        [DataMember(Name = "defaultValue", EmitDefaultValue = true)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Gets or Sets SelectedItems
        /// </summary>
        [DataMember(Name = "selectedItems", EmitDefaultValue = true)]
        public List<string> SelectedItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DpmServiceSetting {\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  SelectedItems: ").Append(SelectedItems).Append("\n");
            sb.Append("  AssignBy: ").Append(AssignBy).Append("\n");
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
            return this.Equals(input as DpmServiceSetting);
        }

        /// <summary>
        /// Returns true if DpmServiceSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of DpmServiceSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DpmServiceSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsEnabled == input.IsEnabled ||
                    this.IsEnabled.Equals(input.IsEnabled)
                ) && 
                (
                    this.DefaultValue == input.DefaultValue ||
                    (this.DefaultValue != null &&
                    this.DefaultValue.Equals(input.DefaultValue))
                ) && 
                (
                    this.SelectedItems == input.SelectedItems ||
                    this.SelectedItems != null &&
                    input.SelectedItems != null &&
                    this.SelectedItems.SequenceEqual(input.SelectedItems)
                ) && 
                (
                    this.AssignBy == input.AssignBy ||
                    this.AssignBy.Equals(input.AssignBy)
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
                hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                if (this.DefaultValue != null)
                    hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.SelectedItems != null)
                    hashCode = hashCode * 59 + this.SelectedItems.GetHashCode();
                hashCode = hashCode * 59 + this.AssignBy.GetHashCode();
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
