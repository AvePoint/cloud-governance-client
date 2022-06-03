

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
    /// OldMetadataGridModelPageResult
    /// </summary>
    [DataContract(Name = "OldMetadataGridModelPageResult")]
    public partial class OldMetadataGridModelPageResult : IEquatable<OldMetadataGridModelPageResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OldMetadataGridModelPageResult" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        /// <param name="nextLink">nextLink.</param>
        /// <param name="nextToken">nextToken.</param>
        public OldMetadataGridModelPageResult(List<OldMetadataGridModel> value = default(List<OldMetadataGridModel>), string nextLink = default(string), string nextToken = default(string))
        {
            this.Value = value;
            this.NextLink = nextLink;
            this.NextToken = nextToken;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public List<OldMetadataGridModel> Value { get; set; }

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
            sb.Append("class OldMetadataGridModelPageResult {\n");
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
            return this.Equals(input as OldMetadataGridModelPageResult);
        }

        /// <summary>
        /// Returns true if OldMetadataGridModelPageResult instances are equal
        /// </summary>
        /// <param name="input">Instance of OldMetadataGridModelPageResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OldMetadataGridModelPageResult input)
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
