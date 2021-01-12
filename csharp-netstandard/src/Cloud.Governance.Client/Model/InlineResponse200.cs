

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
    /// InlineResponse200
    /// </summary>
    [DataContract(Name = "inline_response_200")]
    public partial class InlineResponse200 : IEquatable<InlineResponse200>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse200" /> class.
        /// </summary>
        /// <param name="contact">contact.</param>
        /// <param name="license">license.</param>
        /// <param name="organization">organization.</param>
        public InlineResponse200(List<DynamicRuleElement> contact = default(List<DynamicRuleElement>), List<DynamicRuleElement> license = default(List<DynamicRuleElement>), List<DynamicRuleElement> organization = default(List<DynamicRuleElement>))
        {
            this.Contact = contact;
            this.License = license;
            this.Organization = organization;
        }

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name = "Contact", EmitDefaultValue = false)]
        public List<DynamicRuleElement> Contact { get; set; }

        /// <summary>
        /// Gets or Sets License
        /// </summary>
        [DataMember(Name = "License", EmitDefaultValue = false)]
        public List<DynamicRuleElement> License { get; set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name = "Organization", EmitDefaultValue = false)]
        public List<DynamicRuleElement> Organization { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse200 {\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  License: ").Append(License).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
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
            return this.Equals(input as InlineResponse200);
        }

        /// <summary>
        /// Returns true if InlineResponse200 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse200 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse200 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Contact == input.Contact ||
                    this.Contact != null &&
                    input.Contact != null &&
                    this.Contact.SequenceEqual(input.Contact)
                ) && 
                (
                    this.License == input.License ||
                    this.License != null &&
                    input.License != null &&
                    this.License.SequenceEqual(input.License)
                ) && 
                (
                    this.Organization == input.Organization ||
                    this.Organization != null &&
                    input.Organization != null &&
                    this.Organization.SequenceEqual(input.Organization)
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
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.License != null)
                    hashCode = hashCode * 59 + this.License.GetHashCode();
                if (this.Organization != null)
                    hashCode = hashCode * 59 + this.Organization.GetHashCode();
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
