

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
    /// ContentMoveUrlValidationResult
    /// </summary>
    [DataContract(Name = "ContentMoveUrlValidationResult")]
    public partial class ContentMoveUrlValidationResult : IEquatable<ContentMoveUrlValidationResult>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets MessageCode
        /// </summary>
        [DataMember(Name = "messageCode", EmitDefaultValue = false)]
        public MessageCode? MessageCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentMoveUrlValidationResult" /> class.
        /// </summary>
        /// <param name="_object">_object.</param>
        /// <param name="listBaseType">listBaseType.</param>
        /// <param name="isValid">isValid.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="messageCode">messageCode.</param>
        public ContentMoveUrlValidationResult(ContentMoveSPObject _object = default(ContentMoveSPObject), string listBaseType = default(string), bool isValid = default(bool), string errorMessage = default(string), MessageCode? messageCode = default(MessageCode?))
        {
            this.Object = _object;
            this.ListBaseType = listBaseType;
            this.IsValid = isValid;
            this.ErrorMessage = errorMessage;
            this.MessageCode = messageCode;
        }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", EmitDefaultValue = true)]
        public ContentMoveSPObject Object { get; set; }

        /// <summary>
        /// Gets or Sets ListBaseType
        /// </summary>
        [DataMember(Name = "listBaseType", EmitDefaultValue = true)]
        public string ListBaseType { get; set; }

        /// <summary>
        /// Gets or Sets IsValid
        /// </summary>
        [DataMember(Name = "isValid", EmitDefaultValue = false)]
        public bool IsValid { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name = "errorMessage", EmitDefaultValue = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentMoveUrlValidationResult {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  ListBaseType: ").Append(ListBaseType).Append("\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  MessageCode: ").Append(MessageCode).Append("\n");
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
            return this.Equals(input as ContentMoveUrlValidationResult);
        }

        /// <summary>
        /// Returns true if ContentMoveUrlValidationResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ContentMoveUrlValidationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentMoveUrlValidationResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.ListBaseType == input.ListBaseType ||
                    (this.ListBaseType != null &&
                    this.ListBaseType.Equals(input.ListBaseType))
                ) && 
                (
                    this.IsValid == input.IsValid ||
                    this.IsValid.Equals(input.IsValid)
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.MessageCode == input.MessageCode ||
                    this.MessageCode.Equals(input.MessageCode)
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
                if (this.Object != null)
                    hashCode = hashCode * 59 + this.Object.GetHashCode();
                if (this.ListBaseType != null)
                    hashCode = hashCode * 59 + this.ListBaseType.GetHashCode();
                hashCode = hashCode * 59 + this.IsValid.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                hashCode = hashCode * 59 + this.MessageCode.GetHashCode();
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
