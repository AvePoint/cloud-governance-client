

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
    /// DelegatedAccessTokenApiResult
    /// </summary>
    [DataContract(Name = "DelegatedAccessTokenApiResult")]
    public partial class DelegatedAccessTokenApiResult : IEquatable<DelegatedAccessTokenApiResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DelegatedAccessTokenApiResult" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        /// <param name="isSuccess">isSuccess.</param>
        /// <param name="errorMsg">errorMsg.</param>
        public DelegatedAccessTokenApiResult(DelegatedAccessToken value = default(DelegatedAccessToken), bool isSuccess = default(bool), string errorMsg = default(string))
        {
            this.Value = value;
            this.IsSuccess = isSuccess;
            this.ErrorMsg = errorMsg;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public DelegatedAccessToken Value { get; set; }

        /// <summary>
        /// Gets or Sets IsSuccess
        /// </summary>
        [DataMember(Name = "isSuccess", EmitDefaultValue = false)]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMsg
        /// </summary>
        [DataMember(Name = "errorMsg", EmitDefaultValue = true)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DelegatedAccessTokenApiResult {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  IsSuccess: ").Append(IsSuccess).Append("\n");
            sb.Append("  ErrorMsg: ").Append(ErrorMsg).Append("\n");
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
            return this.Equals(input as DelegatedAccessTokenApiResult);
        }

        /// <summary>
        /// Returns true if DelegatedAccessTokenApiResult instances are equal
        /// </summary>
        /// <param name="input">Instance of DelegatedAccessTokenApiResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DelegatedAccessTokenApiResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.IsSuccess == input.IsSuccess ||
                    this.IsSuccess.Equals(input.IsSuccess)
                ) && 
                (
                    this.ErrorMsg == input.ErrorMsg ||
                    (this.ErrorMsg != null &&
                    this.ErrorMsg.Equals(input.ErrorMsg))
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
                hashCode = hashCode * 59 + this.IsSuccess.GetHashCode();
                if (this.ErrorMsg != null)
                    hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
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
