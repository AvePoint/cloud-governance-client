

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
    /// DelegatedAccessToken
    /// </summary>
    [DataContract(Name = "DelegatedAccessToken")]
    public partial class DelegatedAccessToken : IEquatable<DelegatedAccessToken>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DelegatedAccessToken" /> class.
        /// </summary>
        /// <param name="accessToken">accessToken.</param>
        /// <param name="refreshToken">refreshToken.</param>
        /// <param name="duration">duration.</param>
        public DelegatedAccessToken(string accessToken = default(string), string refreshToken = default(string), long duration = default(long))
        {
            this.AccessToken = accessToken;
            this.RefreshToken = refreshToken;
            this.Duration = duration;
        }

        /// <summary>
        /// Gets or Sets AccessToken
        /// </summary>
        [DataMember(Name = "access_token", EmitDefaultValue = true)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or Sets RefreshToken
        /// </summary>
        [DataMember(Name = "refresh_token", EmitDefaultValue = true)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", EmitDefaultValue = false)]
        public long Duration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DelegatedAccessToken {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
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
            return this.Equals(input as DelegatedAccessToken);
        }

        /// <summary>
        /// Returns true if DelegatedAccessToken instances are equal
        /// </summary>
        /// <param name="input">Instance of DelegatedAccessToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DelegatedAccessToken input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.RefreshToken == input.RefreshToken ||
                    (this.RefreshToken != null &&
                    this.RefreshToken.Equals(input.RefreshToken))
                ) && 
                (
                    this.Duration == input.Duration ||
                    this.Duration.Equals(input.Duration)
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
                if (this.AccessToken != null)
                    hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                if (this.RefreshToken != null)
                    hashCode = hashCode * 59 + this.RefreshToken.GetHashCode();
                hashCode = hashCode * 59 + this.Duration.GetHashCode();
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
