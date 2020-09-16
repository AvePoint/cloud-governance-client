

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
    /// UserLevelControlSettings
    /// </summary>
    [DataContract(Name = "UserLevelControlSettings")]
    public partial class UserLevelControlSettings : IEquatable<UserLevelControlSettings>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets UserLevelControlMode
        /// </summary>
        [DataMember(Name = "userLevelControlMode", EmitDefaultValue = false)]
        public UserLevelControlMode? UserLevelControlMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserLevelControlSettings" /> class.
        /// </summary>
        /// <param name="userLevelControlMode">userLevelControlMode.</param>
        /// <param name="isSetRequesterAsDefaultEnabled">isSetRequesterAsDefaultEnabled.</param>
        public UserLevelControlSettings(UserLevelControlMode? userLevelControlMode = default(UserLevelControlMode?), bool isSetRequesterAsDefaultEnabled = default(bool))
        {
            this.UserLevelControlMode = userLevelControlMode;
            this.IsSetRequesterAsDefaultEnabled = isSetRequesterAsDefaultEnabled;
        }

        /// <summary>
        /// Gets or Sets IsSetRequesterAsDefaultEnabled
        /// </summary>
        [DataMember(Name = "isSetRequesterAsDefaultEnabled", EmitDefaultValue = false)]
        public bool IsSetRequesterAsDefaultEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserLevelControlSettings {\n");
            sb.Append("  UserLevelControlMode: ").Append(UserLevelControlMode).Append("\n");
            sb.Append("  IsSetRequesterAsDefaultEnabled: ").Append(IsSetRequesterAsDefaultEnabled).Append("\n");
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
            return this.Equals(input as UserLevelControlSettings);
        }

        /// <summary>
        /// Returns true if UserLevelControlSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of UserLevelControlSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserLevelControlSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserLevelControlMode == input.UserLevelControlMode ||
                    this.UserLevelControlMode.Equals(input.UserLevelControlMode)
                ) && 
                (
                    this.IsSetRequesterAsDefaultEnabled == input.IsSetRequesterAsDefaultEnabled ||
                    this.IsSetRequesterAsDefaultEnabled.Equals(input.IsSetRequesterAsDefaultEnabled)
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
                hashCode = hashCode * 59 + this.UserLevelControlMode.GetHashCode();
                hashCode = hashCode * 59 + this.IsSetRequesterAsDefaultEnabled.GetHashCode();
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
