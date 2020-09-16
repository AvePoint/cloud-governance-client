

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
    /// ChoiceMetadataSettings
    /// </summary>
    [DataContract(Name = "ChoiceMetadataSettings")]
    public partial class ChoiceMetadataSettings : IEquatable<ChoiceMetadataSettings>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ChoiceType
        /// </summary>
        [DataMember(Name = "choiceType", EmitDefaultValue = false)]
        public ChoiceType? ChoiceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChoiceMetadataSettings" /> class.
        /// </summary>
        /// <param name="choices">choices.</param>
        /// <param name="value">value.</param>
        /// <param name="choiceType">choiceType.</param>
        public ChoiceMetadataSettings(List<string> choices = default(List<string>), List<string> value = default(List<string>), ChoiceType? choiceType = default(ChoiceType?))
        {
            this.Choices = choices;
            this.Value = value;
            this.ChoiceType = choiceType;
        }

        /// <summary>
        /// Gets or Sets Choices
        /// </summary>
        [DataMember(Name = "choices", EmitDefaultValue = true)]
        public List<string> Choices { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public List<string> Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChoiceMetadataSettings {\n");
            sb.Append("  Choices: ").Append(Choices).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ChoiceType: ").Append(ChoiceType).Append("\n");
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
            return this.Equals(input as ChoiceMetadataSettings);
        }

        /// <summary>
        /// Returns true if ChoiceMetadataSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of ChoiceMetadataSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChoiceMetadataSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Choices == input.Choices ||
                    this.Choices != null &&
                    input.Choices != null &&
                    this.Choices.SequenceEqual(input.Choices)
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value != null &&
                    input.Value != null &&
                    this.Value.SequenceEqual(input.Value)
                ) && 
                (
                    this.ChoiceType == input.ChoiceType ||
                    this.ChoiceType.Equals(input.ChoiceType)
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
                if (this.Choices != null)
                    hashCode = hashCode * 59 + this.Choices.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                hashCode = hashCode * 59 + this.ChoiceType.GetHashCode();
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
