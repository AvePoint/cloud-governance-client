

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
    /// CustomExtensionPropertyModel
    /// </summary>
    [DataContract(Name = "CustomExtensionPropertyModel")]
    public partial class CustomExtensionPropertyModel : IEquatable<CustomExtensionPropertyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomExtensionPropertyModel" /> class.
        /// </summary>
        /// <param name="propertyName">propertyName.</param>
        /// <param name="propertyDataType">propertyDataType.</param>
        public CustomExtensionPropertyModel(string propertyName = default(string), string propertyDataType = default(string))
        {
            this.PropertyName = propertyName;
            this.PropertyDataType = propertyDataType;
        }

        /// <summary>
        /// Gets or Sets PropertyName
        /// </summary>
        [DataMember(Name = "propertyName", EmitDefaultValue = true)]
        public string PropertyName { get; set; }

        /// <summary>
        /// Gets or Sets PropertyDataType
        /// </summary>
        [DataMember(Name = "propertyDataType", EmitDefaultValue = true)]
        public string PropertyDataType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomExtensionPropertyModel {\n");
            sb.Append("  PropertyName: ").Append(PropertyName).Append("\n");
            sb.Append("  PropertyDataType: ").Append(PropertyDataType).Append("\n");
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
            return this.Equals(input as CustomExtensionPropertyModel);
        }

        /// <summary>
        /// Returns true if CustomExtensionPropertyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomExtensionPropertyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomExtensionPropertyModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PropertyName == input.PropertyName ||
                    (this.PropertyName != null &&
                    this.PropertyName.Equals(input.PropertyName))
                ) && 
                (
                    this.PropertyDataType == input.PropertyDataType ||
                    (this.PropertyDataType != null &&
                    this.PropertyDataType.Equals(input.PropertyDataType))
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
                if (this.PropertyName != null)
                    hashCode = hashCode * 59 + this.PropertyName.GetHashCode();
                if (this.PropertyDataType != null)
                    hashCode = hashCode * 59 + this.PropertyDataType.GetHashCode();
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
