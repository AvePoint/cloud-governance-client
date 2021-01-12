

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
    /// SiteUrlSetting
    /// </summary>
    [DataContract(Name = "SiteUrlSetting")]
    public partial class SiteUrlSetting : IEquatable<SiteUrlSetting>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public SiteConstructUrlType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SiteUrlSetting" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="manuallyInputSetting">manuallyInputSetting.</param>
        /// <param name="autoGenerateUrlSetting">autoGenerateUrlSetting.</param>
        public SiteUrlSetting(SiteConstructUrlType? type = default(SiteConstructUrlType?), ManuallyInputUrlSetting manuallyInputSetting = default(ManuallyInputUrlSetting), AutoGenerateUrlSetting autoGenerateUrlSetting = default(AutoGenerateUrlSetting))
        {
            this.Type = type;
            this.ManuallyInputSetting = manuallyInputSetting;
            this.AutoGenerateUrlSetting = autoGenerateUrlSetting;
        }

        /// <summary>
        /// Gets or Sets ManuallyInputSetting
        /// </summary>
        [DataMember(Name = "manuallyInputSetting", EmitDefaultValue = true)]
        public ManuallyInputUrlSetting ManuallyInputSetting { get; set; }

        /// <summary>
        /// Gets or Sets AutoGenerateUrlSetting
        /// </summary>
        [DataMember(Name = "autoGenerateUrlSetting", EmitDefaultValue = true)]
        public AutoGenerateUrlSetting AutoGenerateUrlSetting { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SiteUrlSetting {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ManuallyInputSetting: ").Append(ManuallyInputSetting).Append("\n");
            sb.Append("  AutoGenerateUrlSetting: ").Append(AutoGenerateUrlSetting).Append("\n");
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
            return this.Equals(input as SiteUrlSetting);
        }

        /// <summary>
        /// Returns true if SiteUrlSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of SiteUrlSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SiteUrlSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.ManuallyInputSetting == input.ManuallyInputSetting ||
                    (this.ManuallyInputSetting != null &&
                    this.ManuallyInputSetting.Equals(input.ManuallyInputSetting))
                ) && 
                (
                    this.AutoGenerateUrlSetting == input.AutoGenerateUrlSetting ||
                    (this.AutoGenerateUrlSetting != null &&
                    this.AutoGenerateUrlSetting.Equals(input.AutoGenerateUrlSetting))
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ManuallyInputSetting != null)
                    hashCode = hashCode * 59 + this.ManuallyInputSetting.GetHashCode();
                if (this.AutoGenerateUrlSetting != null)
                    hashCode = hashCode * 59 + this.AutoGenerateUrlSetting.GetHashCode();
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
