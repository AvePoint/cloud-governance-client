

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
    /// ApiUserChangedProperty
    /// </summary>
    [DataContract(Name = "ApiUserChangedProperty")]
    public partial class ApiUserChangedProperty : IEquatable<ApiUserChangedProperty>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiUserChangedProperty" /> class.
        /// </summary>
        /// <param name="changeValue">changeValue.</param>
        /// <param name="originalValue">originalValue.</param>
        public ApiUserChangedProperty(ApiUser changeValue = default(ApiUser), ApiUser originalValue = default(ApiUser))
        {
            this.ChangeValue = changeValue;
            this.OriginalValue = originalValue;
        }

        /// <summary>
        /// Gets or Sets ChangeValue
        /// </summary>
        [DataMember(Name = "changeValue", EmitDefaultValue = false)]
        public ApiUser ChangeValue { get; set; }

        /// <summary>
        /// Gets or Sets OriginalValue
        /// </summary>
        [DataMember(Name = "originalValue", EmitDefaultValue = false)]
        public ApiUser OriginalValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiUserChangedProperty {\n");
            sb.Append("  ChangeValue: ").Append(ChangeValue).Append("\n");
            sb.Append("  OriginalValue: ").Append(OriginalValue).Append("\n");
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
            return this.Equals(input as ApiUserChangedProperty);
        }

        /// <summary>
        /// Returns true if ApiUserChangedProperty instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiUserChangedProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiUserChangedProperty input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChangeValue == input.ChangeValue ||
                    (this.ChangeValue != null &&
                    this.ChangeValue.Equals(input.ChangeValue))
                ) && 
                (
                    this.OriginalValue == input.OriginalValue ||
                    (this.OriginalValue != null &&
                    this.OriginalValue.Equals(input.OriginalValue))
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
                if (this.ChangeValue != null)
                    hashCode = hashCode * 59 + this.ChangeValue.GetHashCode();
                if (this.OriginalValue != null)
                    hashCode = hashCode * 59 + this.OriginalValue.GetHashCode();
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
