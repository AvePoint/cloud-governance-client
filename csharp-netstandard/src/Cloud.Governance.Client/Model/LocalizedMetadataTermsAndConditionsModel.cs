

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
    /// LocalizedMetadataTermsAndConditionsModel
    /// </summary>
    [DataContract(Name = "LocalizedMetadataTermsAndConditionsModel")]
    public partial class LocalizedMetadataTermsAndConditionsModel : IEquatable<LocalizedMetadataTermsAndConditionsModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedMetadataTermsAndConditionsModel" /> class.
        /// </summary>
        /// <param name="term">term.</param>
        /// <param name="languageId">languageId (default to 0).</param>
        /// <param name="isEnabled">isEnabled (default to false).</param>
        /// <param name="isEnableCustomValue">isEnableCustomValue (default to false).</param>
        /// <param name="trueValue">trueValue.</param>
        /// <param name="falseValue">falseValue.</param>
        public LocalizedMetadataTermsAndConditionsModel(string term = default(string), int languageId = 0, bool isEnabled = false, bool isEnableCustomValue = false, string trueValue = default(string), string falseValue = default(string))
        {
            this.Term = term;
            this.LanguageId = languageId;
            this.IsEnabled = isEnabled;
            this.IsEnableCustomValue = isEnableCustomValue;
            this.TrueValue = trueValue;
            this.FalseValue = falseValue;
        }

        /// <summary>
        /// Gets or Sets Term
        /// </summary>
        [DataMember(Name = "term", EmitDefaultValue = true)]
        public string Term { get; set; }

        /// <summary>
        /// Gets or Sets LanguageId
        /// </summary>
        [DataMember(Name = "languageId", EmitDefaultValue = false)]
        public int LanguageId { get; set; }

        /// <summary>
        /// Gets or Sets IsEnabled
        /// </summary>
        [DataMember(Name = "isEnabled", EmitDefaultValue = false)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets IsEnableCustomValue
        /// </summary>
        [DataMember(Name = "isEnableCustomValue", EmitDefaultValue = false)]
        public bool IsEnableCustomValue { get; set; }

        /// <summary>
        /// Gets or Sets TrueValue
        /// </summary>
        [DataMember(Name = "trueValue", EmitDefaultValue = true)]
        public string TrueValue { get; set; }

        /// <summary>
        /// Gets or Sets FalseValue
        /// </summary>
        [DataMember(Name = "falseValue", EmitDefaultValue = true)]
        public string FalseValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocalizedMetadataTermsAndConditionsModel {\n");
            sb.Append("  Term: ").Append(Term).Append("\n");
            sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  IsEnableCustomValue: ").Append(IsEnableCustomValue).Append("\n");
            sb.Append("  TrueValue: ").Append(TrueValue).Append("\n");
            sb.Append("  FalseValue: ").Append(FalseValue).Append("\n");
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
            return this.Equals(input as LocalizedMetadataTermsAndConditionsModel);
        }

        /// <summary>
        /// Returns true if LocalizedMetadataTermsAndConditionsModel instances are equal
        /// </summary>
        /// <param name="input">Instance of LocalizedMetadataTermsAndConditionsModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocalizedMetadataTermsAndConditionsModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Term == input.Term ||
                    (this.Term != null &&
                    this.Term.Equals(input.Term))
                ) && 
                (
                    this.LanguageId == input.LanguageId ||
                    this.LanguageId.Equals(input.LanguageId)
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    this.IsEnabled.Equals(input.IsEnabled)
                ) && 
                (
                    this.IsEnableCustomValue == input.IsEnableCustomValue ||
                    this.IsEnableCustomValue.Equals(input.IsEnableCustomValue)
                ) && 
                (
                    this.TrueValue == input.TrueValue ||
                    (this.TrueValue != null &&
                    this.TrueValue.Equals(input.TrueValue))
                ) && 
                (
                    this.FalseValue == input.FalseValue ||
                    (this.FalseValue != null &&
                    this.FalseValue.Equals(input.FalseValue))
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
                if (this.Term != null)
                    hashCode = hashCode * 59 + this.Term.GetHashCode();
                hashCode = hashCode * 59 + this.LanguageId.GetHashCode();
                hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                hashCode = hashCode * 59 + this.IsEnableCustomValue.GetHashCode();
                if (this.TrueValue != null)
                    hashCode = hashCode * 59 + this.TrueValue.GetHashCode();
                if (this.FalseValue != null)
                    hashCode = hashCode * 59 + this.FalseValue.GetHashCode();
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
