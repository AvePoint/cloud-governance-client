

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
    /// ChangeMetadataActionSetting
    /// </summary>
    [DataContract(Name = "ChangeMetadataActionSetting")]
    public partial class ChangeMetadataActionSetting : IEquatable<ChangeMetadataActionSetting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeMetadataActionSetting" /> class.
        /// </summary>
        /// <param name="isEnabled">isEnabled.</param>
        /// <param name="enableAddOrDelete">enableAddOrDelete.</param>
        /// <param name="metadatas">metadatas.</param>
        public ChangeMetadataActionSetting(bool isEnabled = default(bool), bool enableAddOrDelete = default(bool), List<CustomMetadata> metadatas = default(List<CustomMetadata>))
        {
            this.IsEnabled = isEnabled;
            this.EnableAddOrDelete = enableAddOrDelete;
            this.Metadatas = metadatas;
        }

        /// <summary>
        /// Gets or Sets IsEnabled
        /// </summary>
        [DataMember(Name = "isEnabled", EmitDefaultValue = false)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets EnableAddOrDelete
        /// </summary>
        [DataMember(Name = "enableAddOrDelete", EmitDefaultValue = false)]
        public bool EnableAddOrDelete { get; set; }

        /// <summary>
        /// Gets or Sets Metadatas
        /// </summary>
        [DataMember(Name = "metadatas", EmitDefaultValue = true)]
        public List<CustomMetadata> Metadatas { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeMetadataActionSetting {\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  EnableAddOrDelete: ").Append(EnableAddOrDelete).Append("\n");
            sb.Append("  Metadatas: ").Append(Metadatas).Append("\n");
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
            return this.Equals(input as ChangeMetadataActionSetting);
        }

        /// <summary>
        /// Returns true if ChangeMetadataActionSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeMetadataActionSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeMetadataActionSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsEnabled == input.IsEnabled ||
                    this.IsEnabled.Equals(input.IsEnabled)
                ) && 
                (
                    this.EnableAddOrDelete == input.EnableAddOrDelete ||
                    this.EnableAddOrDelete.Equals(input.EnableAddOrDelete)
                ) && 
                (
                    this.Metadatas == input.Metadatas ||
                    this.Metadatas != null &&
                    input.Metadatas != null &&
                    this.Metadatas.SequenceEqual(input.Metadatas)
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
                hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                hashCode = hashCode * 59 + this.EnableAddOrDelete.GetHashCode();
                if (this.Metadatas != null)
                    hashCode = hashCode * 59 + this.Metadatas.GetHashCode();
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
