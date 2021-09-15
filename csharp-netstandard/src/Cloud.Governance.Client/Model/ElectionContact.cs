

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
    /// ElectionContact
    /// </summary>
    [DataContract(Name = "ElectionContact")]
    public partial class ElectionContact : IEquatable<ElectionContact>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectionContact" /> class.
        /// </summary>
        /// <param name="displayName">Display name of contact.</param>
        /// <param name="identityName">User principal name of contact.</param>
        public ElectionContact(string displayName = default(string), string identityName = default(string))
        {
            this.DisplayName = displayName;
            this.IdentityName = identityName;
        }

        /// <summary>
        /// Display name of contact
        /// </summary>
        /// <value>Display name of contact</value>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// User principal name of contact
        /// </summary>
        /// <value>User principal name of contact</value>
        [DataMember(Name = "identityName", EmitDefaultValue = true)]
        public string IdentityName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ElectionContact {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  IdentityName: ").Append(IdentityName).Append("\n");
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
            return this.Equals(input as ElectionContact);
        }

        /// <summary>
        /// Returns true if ElectionContact instances are equal
        /// </summary>
        /// <param name="input">Instance of ElectionContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ElectionContact input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.IdentityName == input.IdentityName ||
                    (this.IdentityName != null &&
                    this.IdentityName.Equals(input.IdentityName))
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
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.IdentityName != null)
                    hashCode = hashCode * 59 + this.IdentityName.GetHashCode();
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
