

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
    /// Value of Lookup User Profile or Azure Ad metadata.
    /// </summary>
    [DataContract(Name = "LookupListValue")]
    public partial class LookupListValue : IEquatable<LookupListValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LookupListValue" /> class.
        /// </summary>
        /// <param name="columnType">type of lookup list column.</param>
        /// <param name="columnName">name of lookup list column.</param>
        /// <param name="value">Value of lookup list.</param>
        /// <param name="displayValue">Display value of lookup list.</param>
        public LookupListValue(string columnType = default(string), string columnName = default(string), string value = default(string), string displayValue = default(string))
        {
            this.ColumnType = columnType;
            this.ColumnName = columnName;
            this.Value = value;
            this.DisplayValue = displayValue;
        }

        /// <summary>
        /// type of lookup list column
        /// </summary>
        /// <value>type of lookup list column</value>
        [DataMember(Name = "columnType", EmitDefaultValue = true)]
        public string ColumnType { get; set; }

        /// <summary>
        /// name of lookup list column
        /// </summary>
        /// <value>name of lookup list column</value>
        [DataMember(Name = "columnName", EmitDefaultValue = true)]
        public string ColumnName { get; set; }

        /// <summary>
        /// Value of lookup list
        /// </summary>
        /// <value>Value of lookup list</value>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Display value of lookup list
        /// </summary>
        /// <value>Display value of lookup list</value>
        [DataMember(Name = "displayValue", EmitDefaultValue = true)]
        public string DisplayValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LookupListValue {\n");
            sb.Append("  ColumnType: ").Append(ColumnType).Append("\n");
            sb.Append("  ColumnName: ").Append(ColumnName).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  DisplayValue: ").Append(DisplayValue).Append("\n");
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
            return this.Equals(input as LookupListValue);
        }

        /// <summary>
        /// Returns true if LookupListValue instances are equal
        /// </summary>
        /// <param name="input">Instance of LookupListValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LookupListValue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ColumnType == input.ColumnType ||
                    (this.ColumnType != null &&
                    this.ColumnType.Equals(input.ColumnType))
                ) && 
                (
                    this.ColumnName == input.ColumnName ||
                    (this.ColumnName != null &&
                    this.ColumnName.Equals(input.ColumnName))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.DisplayValue == input.DisplayValue ||
                    (this.DisplayValue != null &&
                    this.DisplayValue.Equals(input.DisplayValue))
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
                if (this.ColumnType != null)
                    hashCode = hashCode * 59 + this.ColumnType.GetHashCode();
                if (this.ColumnName != null)
                    hashCode = hashCode * 59 + this.ColumnName.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.DisplayValue != null)
                    hashCode = hashCode * 59 + this.DisplayValue.GetHashCode();
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
