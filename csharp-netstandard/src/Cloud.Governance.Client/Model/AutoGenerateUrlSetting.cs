

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
    /// AutoGenerateUrlSetting
    /// </summary>
    [DataContract(Name = "AutoGenerateUrlSetting")]
    public partial class AutoGenerateUrlSetting : IEquatable<AutoGenerateUrlSetting>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets GenerateUrlType
        /// </summary>
        [DataMember(Name = "generateUrlType", EmitDefaultValue = false)]
        public AutoGenerateUrlType? GenerateUrlType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoGenerateUrlSetting" /> class.
        /// </summary>
        /// <param name="generateUrlType">generateUrlType.</param>
        /// <param name="sequentialNumberingSettings">sequentialNumberingSettings.</param>
        /// <param name="randomStringSettings">randomStringSettings.</param>
        public AutoGenerateUrlSetting(AutoGenerateUrlType? generateUrlType = default(AutoGenerateUrlType?), UrlSequentialNumberingSettings sequentialNumberingSettings = default(UrlSequentialNumberingSettings), UrlRandomStringSettings randomStringSettings = default(UrlRandomStringSettings))
        {
            this.GenerateUrlType = generateUrlType;
            this.SequentialNumberingSettings = sequentialNumberingSettings;
            this.RandomStringSettings = randomStringSettings;
        }

        /// <summary>
        /// Gets or Sets SequentialNumberingSettings
        /// </summary>
        [DataMember(Name = "sequentialNumberingSettings", EmitDefaultValue = true)]
        public UrlSequentialNumberingSettings SequentialNumberingSettings { get; set; }

        /// <summary>
        /// Gets or Sets RandomStringSettings
        /// </summary>
        [DataMember(Name = "randomStringSettings", EmitDefaultValue = true)]
        public UrlRandomStringSettings RandomStringSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoGenerateUrlSetting {\n");
            sb.Append("  GenerateUrlType: ").Append(GenerateUrlType).Append("\n");
            sb.Append("  SequentialNumberingSettings: ").Append(SequentialNumberingSettings).Append("\n");
            sb.Append("  RandomStringSettings: ").Append(RandomStringSettings).Append("\n");
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
            return this.Equals(input as AutoGenerateUrlSetting);
        }

        /// <summary>
        /// Returns true if AutoGenerateUrlSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of AutoGenerateUrlSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutoGenerateUrlSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GenerateUrlType == input.GenerateUrlType ||
                    this.GenerateUrlType.Equals(input.GenerateUrlType)
                ) && 
                (
                    this.SequentialNumberingSettings == input.SequentialNumberingSettings ||
                    (this.SequentialNumberingSettings != null &&
                    this.SequentialNumberingSettings.Equals(input.SequentialNumberingSettings))
                ) && 
                (
                    this.RandomStringSettings == input.RandomStringSettings ||
                    (this.RandomStringSettings != null &&
                    this.RandomStringSettings.Equals(input.RandomStringSettings))
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
                hashCode = hashCode * 59 + this.GenerateUrlType.GetHashCode();
                if (this.SequentialNumberingSettings != null)
                    hashCode = hashCode * 59 + this.SequentialNumberingSettings.GetHashCode();
                if (this.RandomStringSettings != null)
                    hashCode = hashCode * 59 + this.RandomStringSettings.GetHashCode();
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
