

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
    /// PersonalSettingsPropertyInfo
    /// </summary>
    [DataContract(Name = "PersonalSettingsPropertyInfo")]
    public partial class PersonalSettingsPropertyInfo : IEquatable<PersonalSettingsPropertyInfo>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ThemeType
        /// </summary>
        [DataMember(Name = "themeType", EmitDefaultValue = false)]
        public ThemeSettingType? ThemeType { get; set; }

        /// <summary>
        /// Returns false as ThemeType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeThemeType()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalSettingsPropertyInfo" /> class.
        /// </summary>
        /// <param name="selectedLanguages">selectedLanguages.</param>
        /// <param name="isUsingBrowserLanguage">isUsingBrowserLanguage (default to false).</param>
        /// <param name="themeCode">themeCode.</param>
        public PersonalSettingsPropertyInfo(List<int> selectedLanguages = default(List<int>), bool isUsingBrowserLanguage = false, string themeCode = default(string))
        {
            this.SelectedLanguages = selectedLanguages;
            this.IsUsingBrowserLanguage = isUsingBrowserLanguage;
            this.ThemeCode = themeCode;
        }

        /// <summary>
        /// Gets or Sets SelectedLanguages
        /// </summary>
        [DataMember(Name = "selectedLanguages", EmitDefaultValue = true)]
        public List<int> SelectedLanguages { get; set; }

        /// <summary>
        /// Gets or Sets IsUsingBrowserLanguage
        /// </summary>
        [DataMember(Name = "isUsingBrowserLanguage", EmitDefaultValue = false)]
        public bool IsUsingBrowserLanguage { get; set; }

        /// <summary>
        /// Gets or Sets ThemeCode
        /// </summary>
        [DataMember(Name = "themeCode", EmitDefaultValue = true)]
        public string ThemeCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersonalSettingsPropertyInfo {\n");
            sb.Append("  SelectedLanguages: ").Append(SelectedLanguages).Append("\n");
            sb.Append("  IsUsingBrowserLanguage: ").Append(IsUsingBrowserLanguage).Append("\n");
            sb.Append("  ThemeCode: ").Append(ThemeCode).Append("\n");
            sb.Append("  ThemeType: ").Append(ThemeType).Append("\n");
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
                    this.SelectedLanguages == input.SelectedLanguages ||
                    this.SelectedLanguages != null &&
                    input.SelectedLanguages != null &&
                    this.SelectedLanguages.SequenceEqual(input.SelectedLanguages)
                ) && 
                (
                    this.IsUsingBrowserLanguage == input.IsUsingBrowserLanguage ||
                    this.IsUsingBrowserLanguage.Equals(input.IsUsingBrowserLanguage)
                ) && 
                (
                    this.ThemeCode == input.ThemeCode ||
                    (this.ThemeCode != null &&
                    this.ThemeCode.Equals(input.ThemeCode))
                ) && 
                (
                    this.ThemeType == input.ThemeType ||
                    this.ThemeType.Equals(input.ThemeType)
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
                if (this.SelectedLanguages != null)
                    hashCode = hashCode * 59 + this.SelectedLanguages.GetHashCode();
                hashCode = hashCode * 59 + this.IsUsingBrowserLanguage.GetHashCode();
                if (this.ThemeCode != null)
                    hashCode = hashCode * 59 + this.ThemeCode.GetHashCode();
                hashCode = hashCode * 59 + this.ThemeType.GetHashCode();
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
