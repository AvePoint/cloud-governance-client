

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
    /// UrlRandomStringSettings
    /// </summary>
    [DataContract(Name = "UrlRandomStringSettings")]
    public partial class UrlRandomStringSettings : IEquatable<UrlRandomStringSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UrlRandomStringSettings" /> class.
        /// </summary>
        /// <param name="prefix">prefix.</param>
        /// <param name="maxLength">maxLength.</param>
        /// <param name="minLength">minLength.</param>
        public UrlRandomStringSettings(string prefix = default(string), int maxLength = default(int), int minLength = default(int))
        {
            this.Prefix = prefix;
            this.MaxLength = maxLength;
            this.MinLength = minLength;
        }

        /// <summary>
        /// Gets or Sets Prefix
        /// </summary>
        [DataMember(Name = "prefix", EmitDefaultValue = true)]
        public string Prefix { get; set; }

        /// <summary>
        /// Gets or Sets MaxLength
        /// </summary>
        [DataMember(Name = "maxLength", EmitDefaultValue = false)]
        public int MaxLength { get; set; }

        /// <summary>
        /// Gets or Sets MinLength
        /// </summary>
        [DataMember(Name = "minLength", EmitDefaultValue = false)]
        public int MinLength { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UrlRandomStringSettings {\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
            sb.Append("  MinLength: ").Append(MinLength).Append("\n");
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
            return this.Equals(input as UrlRandomStringSettings);
        }

        /// <summary>
        /// Returns true if UrlRandomStringSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of UrlRandomStringSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UrlRandomStringSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Prefix == input.Prefix ||
                    (this.Prefix != null &&
                    this.Prefix.Equals(input.Prefix))
                ) && 
                (
                    this.MaxLength == input.MaxLength ||
                    this.MaxLength.Equals(input.MaxLength)
                ) && 
                (
                    this.MinLength == input.MinLength ||
                    this.MinLength.Equals(input.MinLength)
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
                if (this.Prefix != null)
                    hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                hashCode = hashCode * 59 + this.MaxLength.GetHashCode();
                hashCode = hashCode * 59 + this.MinLength.GetHashCode();
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
