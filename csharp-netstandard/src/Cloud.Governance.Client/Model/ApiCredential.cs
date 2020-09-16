

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
    /// ApiCredential
    /// </summary>
    [DataContract(Name = "ApiCredential")]
    public partial class ApiCredential : IEquatable<ApiCredential>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiCredential" /> class.
        /// </summary>
        /// <param name="clientSecret">clientSecret.</param>
        /// <param name="userPrincipalName">userPrincipalName.</param>
        public ApiCredential(string clientSecret = default(string), string userPrincipalName = default(string))
        {
            this.ClientSecret = clientSecret;
            this.UserPrincipalName = userPrincipalName;
        }

        /// <summary>
        /// Gets or Sets ClientSecret
        /// </summary>
        [DataMember(Name = "clientSecret", EmitDefaultValue = true)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or Sets UserPrincipalName
        /// </summary>
        [DataMember(Name = "userPrincipalName", EmitDefaultValue = true)]
        public string UserPrincipalName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiCredential {\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  UserPrincipalName: ").Append(UserPrincipalName).Append("\n");
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
            return this.Equals(input as ApiCredential);
        }

        /// <summary>
        /// Returns true if ApiCredential instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiCredential to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiCredential input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientSecret == input.ClientSecret ||
                    (this.ClientSecret != null &&
                    this.ClientSecret.Equals(input.ClientSecret))
                ) && 
                (
                    this.UserPrincipalName == input.UserPrincipalName ||
                    (this.UserPrincipalName != null &&
                    this.UserPrincipalName.Equals(input.UserPrincipalName))
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
                if (this.ClientSecret != null)
                    hashCode = hashCode * 59 + this.ClientSecret.GetHashCode();
                if (this.UserPrincipalName != null)
                    hashCode = hashCode * 59 + this.UserPrincipalName.GetHashCode();
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
