

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
    /// ApiUserPageResult
    /// </summary>
    [DataContract(Name = "ApiUserPageResult")]
    public partial class ApiUserPageResult : IEquatable<ApiUserPageResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiUserPageResult" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        /// <param name="nextLink">nextLink.</param>
        /// <param name="nextToken">nextToken.</param>
        public ApiUserPageResult(List<ApiUser> value = default(List<ApiUser>), string nextLink = default(string), string nextToken = default(string))
        {
            this.Value = value;
            this.NextLink = nextLink;
            this.NextToken = nextToken;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public List<ApiUser> Value { get; set; }

        /// <summary>
        /// Gets or Sets NextLink
        /// </summary>
        [DataMember(Name = "nextLink", EmitDefaultValue = true)]
        public string NextLink { get; set; }

        /// <summary>
        /// Gets or Sets NextToken
        /// </summary>
        [DataMember(Name = "nextToken", EmitDefaultValue = true)]
        public string NextToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiUserPageResult {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  NextLink: ").Append(NextLink).Append("\n");
            sb.Append("  NextToken: ").Append(NextToken).Append("\n");
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
            return this.Equals(input as ApiUserPageResult);
        }

        /// <summary>
        /// Returns true if ApiUserPageResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiUserPageResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiUserPageResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    this.Value != null &&
                    input.Value != null &&
                    this.Value.SequenceEqual(input.Value)
                ) && 
                (
                    this.NextLink == input.NextLink ||
                    (this.NextLink != null &&
                    this.NextLink.Equals(input.NextLink))
                ) && 
                (
                    this.NextToken == input.NextToken ||
                    (this.NextToken != null &&
                    this.NextToken.Equals(input.NextToken))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.NextLink != null)
                    hashCode = hashCode * 59 + this.NextLink.GetHashCode();
                if (this.NextToken != null)
                    hashCode = hashCode * 59 + this.NextToken.GetHashCode();
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
