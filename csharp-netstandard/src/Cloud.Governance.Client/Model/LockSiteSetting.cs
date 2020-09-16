

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
    /// LockSiteSetting
    /// </summary>
    [DataContract(Name = "LockSiteSetting")]
    public partial class LockSiteSetting : IEquatable<LockSiteSetting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LockSiteSetting" /> class.
        /// </summary>
        /// <param name="enableLockAsNoAccess">enableLockAsNoAccess.</param>
        /// <param name="enableLockAsReadonly">enableLockAsReadonly.</param>
        public LockSiteSetting(bool enableLockAsNoAccess = default(bool), bool enableLockAsReadonly = default(bool))
        {
            this.EnableLockAsNoAccess = enableLockAsNoAccess;
            this.EnableLockAsReadonly = enableLockAsReadonly;
        }

        /// <summary>
        /// Gets or Sets EnableLockAsNoAccess
        /// </summary>
        [DataMember(Name = "enableLockAsNoAccess", EmitDefaultValue = false)]
        public bool EnableLockAsNoAccess { get; set; }

        /// <summary>
        /// Gets or Sets EnableLockAsReadonly
        /// </summary>
        [DataMember(Name = "enableLockAsReadonly", EmitDefaultValue = false)]
        public bool EnableLockAsReadonly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LockSiteSetting {\n");
            sb.Append("  EnableLockAsNoAccess: ").Append(EnableLockAsNoAccess).Append("\n");
            sb.Append("  EnableLockAsReadonly: ").Append(EnableLockAsReadonly).Append("\n");
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
            return this.Equals(input as LockSiteSetting);
        }

        /// <summary>
        /// Returns true if LockSiteSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of LockSiteSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LockSiteSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnableLockAsNoAccess == input.EnableLockAsNoAccess ||
                    this.EnableLockAsNoAccess.Equals(input.EnableLockAsNoAccess)
                ) && 
                (
                    this.EnableLockAsReadonly == input.EnableLockAsReadonly ||
                    this.EnableLockAsReadonly.Equals(input.EnableLockAsReadonly)
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
                hashCode = hashCode * 59 + this.EnableLockAsNoAccess.GetHashCode();
                hashCode = hashCode * 59 + this.EnableLockAsReadonly.GetHashCode();
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
