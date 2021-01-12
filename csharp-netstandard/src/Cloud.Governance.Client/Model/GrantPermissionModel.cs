

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
    /// GrantPermissionModel
    /// </summary>
    [DataContract(Name = "GrantPermissionModel")]
    public partial class GrantPermissionModel : IEquatable<GrantPermissionModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GrantPermissionModel" /> class.
        /// </summary>
        /// <param name="permissionDurationSettings">permissionDurationSettings.</param>
        /// <param name="welcomeEmailSettings">welcomeEmailSettings.</param>
        public GrantPermissionModel(TemporaryPermissionRequestSetting permissionDurationSettings = default(TemporaryPermissionRequestSetting), WelcomeEmailSettings welcomeEmailSettings = default(WelcomeEmailSettings))
        {
            this.PermissionDurationSettings = permissionDurationSettings;
            this.WelcomeEmailSettings = welcomeEmailSettings;
        }

        /// <summary>
        /// Gets or Sets PermissionDurationSettings
        /// </summary>
        [DataMember(Name = "permissionDurationSettings", EmitDefaultValue = true)]
        public TemporaryPermissionRequestSetting PermissionDurationSettings { get; set; }

        /// <summary>
        /// Gets or Sets WelcomeEmailSettings
        /// </summary>
        [DataMember(Name = "welcomeEmailSettings", EmitDefaultValue = true)]
        public WelcomeEmailSettings WelcomeEmailSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GrantPermissionModel {\n");
            sb.Append("  PermissionDurationSettings: ").Append(PermissionDurationSettings).Append("\n");
            sb.Append("  WelcomeEmailSettings: ").Append(WelcomeEmailSettings).Append("\n");
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
            return this.Equals(input as GrantPermissionModel);
        }

        /// <summary>
        /// Returns true if GrantPermissionModel instances are equal
        /// </summary>
        /// <param name="input">Instance of GrantPermissionModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GrantPermissionModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PermissionDurationSettings == input.PermissionDurationSettings ||
                    (this.PermissionDurationSettings != null &&
                    this.PermissionDurationSettings.Equals(input.PermissionDurationSettings))
                ) && 
                (
                    this.WelcomeEmailSettings == input.WelcomeEmailSettings ||
                    (this.WelcomeEmailSettings != null &&
                    this.WelcomeEmailSettings.Equals(input.WelcomeEmailSettings))
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
                if (this.PermissionDurationSettings != null)
                    hashCode = hashCode * 59 + this.PermissionDurationSettings.GetHashCode();
                if (this.WelcomeEmailSettings != null)
                    hashCode = hashCode * 59 + this.WelcomeEmailSettings.GetHashCode();
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
