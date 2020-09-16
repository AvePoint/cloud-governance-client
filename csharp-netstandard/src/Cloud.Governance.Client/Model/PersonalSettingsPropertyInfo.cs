

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
    /// PersonalSettingsPropertyInfo
    /// </summary>
    [DataContract(Name = "PersonalSettingsPropertyInfo")]
    public partial class PersonalSettingsPropertyInfo : IEquatable<PersonalSettingsPropertyInfo>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Theme
        /// </summary>
        [DataMember(Name = "theme", EmitDefaultValue = false)]
        public ThemeType? Theme { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalSettingsPropertyInfo" /> class.
        /// </summary>
        /// <param name="theme">theme.</param>
        /// <param name="isUsingBrowserLanguage">isUsingBrowserLanguage.</param>
        /// <param name="selectedLanguages">selectedLanguages.</param>
        public PersonalSettingsPropertyInfo(ThemeType? theme = default(ThemeType?), bool isUsingBrowserLanguage = default(bool), List<int> selectedLanguages = default(List<int>))
        {
            this.Theme = theme;
            this.IsUsingBrowserLanguage = isUsingBrowserLanguage;
            this.SelectedLanguages = selectedLanguages;
        }

        /// <summary>
        /// Gets or Sets IsUsingBrowserLanguage
        /// </summary>
        [DataMember(Name = "isUsingBrowserLanguage", EmitDefaultValue = false)]
        public bool IsUsingBrowserLanguage { get; set; }

        /// <summary>
        /// Gets or Sets SelectedLanguages
        /// </summary>
        [DataMember(Name = "selectedLanguages", EmitDefaultValue = true)]
        public List<int> SelectedLanguages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersonalSettingsPropertyInfo {\n");
            sb.Append("  Theme: ").Append(Theme).Append("\n");
            sb.Append("  IsUsingBrowserLanguage: ").Append(IsUsingBrowserLanguage).Append("\n");
            sb.Append("  SelectedLanguages: ").Append(SelectedLanguages).Append("\n");
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
            return this.Equals(input as PersonalSettingsPropertyInfo);
        }

        /// <summary>
        /// Returns true if PersonalSettingsPropertyInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PersonalSettingsPropertyInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PersonalSettingsPropertyInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Theme == input.Theme ||
                    this.Theme.Equals(input.Theme)
                ) && 
                (
                    this.IsUsingBrowserLanguage == input.IsUsingBrowserLanguage ||
                    this.IsUsingBrowserLanguage.Equals(input.IsUsingBrowserLanguage)
                ) && 
                (
                    this.SelectedLanguages == input.SelectedLanguages ||
                    this.SelectedLanguages != null &&
                    input.SelectedLanguages != null &&
                    this.SelectedLanguages.SequenceEqual(input.SelectedLanguages)
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
                hashCode = hashCode * 59 + this.Theme.GetHashCode();
                hashCode = hashCode * 59 + this.IsUsingBrowserLanguage.GetHashCode();
                if (this.SelectedLanguages != null)
                    hashCode = hashCode * 59 + this.SelectedLanguages.GetHashCode();
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
