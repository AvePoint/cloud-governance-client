

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
    /// ExternalUserSharingSettings
    /// </summary>
    [DataContract(Name = "ExternalUserSharingSettings")]
    public partial class ExternalUserSharingSettings : IEquatable<ExternalUserSharingSettings>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets SharingType
        /// </summary>
        [DataMember(Name = "sharingType", EmitDefaultValue = false)]
        public ExternalUserSharingType? SharingType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalUserSharingSettings" /> class.
        /// </summary>
        /// <param name="enabled">enabled.</param>
        /// <param name="sharingType">sharingType.</param>
        /// <param name="anonymousLinkSettings">anonymousLinkSettings.</param>
        public ExternalUserSharingSettings(bool enabled = default(bool), ExternalUserSharingType? sharingType = default(ExternalUserSharingType?), AnonymousLinkSettings anonymousLinkSettings = default(AnonymousLinkSettings))
        {
            this.Enabled = enabled;
            this.SharingType = sharingType;
            this.AnonymousLinkSettings = anonymousLinkSettings;
        }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets AnonymousLinkSettings
        /// </summary>
        [DataMember(Name = "anonymousLinkSettings", EmitDefaultValue = false)]
        public AnonymousLinkSettings AnonymousLinkSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalUserSharingSettings {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  SharingType: ").Append(SharingType).Append("\n");
            sb.Append("  AnonymousLinkSettings: ").Append(AnonymousLinkSettings).Append("\n");
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
            return this.Equals(input as ExternalUserSharingSettings);
        }

        /// <summary>
        /// Returns true if ExternalUserSharingSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternalUserSharingSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalUserSharingSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.SharingType == input.SharingType ||
                    this.SharingType.Equals(input.SharingType)
                ) && 
                (
                    this.AnonymousLinkSettings == input.AnonymousLinkSettings ||
                    (this.AnonymousLinkSettings != null &&
                    this.AnonymousLinkSettings.Equals(input.AnonymousLinkSettings))
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
                hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                hashCode = hashCode * 59 + this.SharingType.GetHashCode();
                if (this.AnonymousLinkSettings != null)
                    hashCode = hashCode * 59 + this.AnonymousLinkSettings.GetHashCode();
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
