

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
    /// Change PrivateChannel field
    /// </summary>
    [DataContract(Name = "ChangePrivateChannelFieldModel")]
    public partial class ChangePrivateChannelFieldModel : IEquatable<ChangePrivateChannelFieldModel>, IValidatableObject
    {
        /// <summary>
        /// Change PrivateChannel field name
        /// </summary>
        /// <value>Change PrivateChannel field name</value>
        [DataMember(Name = "changePrivateChannelFieldName", EmitDefaultValue = false)]
        public ChangePrivateChannelFieldName? ChangePrivateChannelFieldName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePrivateChannelFieldModel" /> class.
        /// </summary>
        /// <param name="changePrivateChannelFieldName">Change PrivateChannel field name.</param>
        /// <param name="isEnabled">Is enabled (default to false).</param>
        public ChangePrivateChannelFieldModel(ChangePrivateChannelFieldName? changePrivateChannelFieldName = default(ChangePrivateChannelFieldName?), bool isEnabled = false)
        {
            this.ChangePrivateChannelFieldName = changePrivateChannelFieldName;
            this.IsEnabled = isEnabled;
        }

        /// <summary>
        /// Is enabled
        /// </summary>
        /// <value>Is enabled</value>
        [DataMember(Name = "isEnabled", EmitDefaultValue = false)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangePrivateChannelFieldModel {\n");
            sb.Append("  ChangePrivateChannelFieldName: ").Append(ChangePrivateChannelFieldName).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
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
            return this.Equals(input as ChangePrivateChannelFieldModel);
        }

        /// <summary>
        /// Returns true if ChangePrivateChannelFieldModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangePrivateChannelFieldModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangePrivateChannelFieldModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChangePrivateChannelFieldName == input.ChangePrivateChannelFieldName ||
                    this.ChangePrivateChannelFieldName.Equals(input.ChangePrivateChannelFieldName)
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    this.IsEnabled.Equals(input.IsEnabled)
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
                hashCode = hashCode * 59 + this.ChangePrivateChannelFieldName.GetHashCode();
                hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
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
