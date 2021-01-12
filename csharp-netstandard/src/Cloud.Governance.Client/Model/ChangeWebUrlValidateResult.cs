

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
    /// ChangeWebUrlValidateResult
    /// </summary>
    [DataContract(Name = "ChangeWebUrlValidateResult")]
    public partial class ChangeWebUrlValidateResult : IEquatable<ChangeWebUrlValidateResult>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets MessageCode
        /// </summary>
        [DataMember(Name = "messageCode", EmitDefaultValue = false)]
        public MessageCode? MessageCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeWebUrlValidateResult" /> class.
        /// </summary>
        /// <param name="url">url.</param>
        /// <param name="webTitle">webTitle.</param>
        /// <param name="webDescription">webDescription.</param>
        /// <param name="metadatas">metadatas.</param>
        /// <param name="isValid">isValid.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="messageCode">messageCode.</param>
        public ChangeWebUrlValidateResult(ChangeWebSPObject url = default(ChangeWebSPObject), string webTitle = default(string), string webDescription = default(string), List<CustomMetadata> metadatas = default(List<CustomMetadata>), bool isValid = default(bool), string errorMessage = default(string), MessageCode? messageCode = default(MessageCode?))
        {
            this.Url = url;
            this.WebTitle = webTitle;
            this.WebDescription = webDescription;
            this.Metadatas = metadatas;
            this.IsValid = isValid;
            this.ErrorMessage = errorMessage;
            this.MessageCode = messageCode;
        }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public ChangeWebSPObject Url { get; set; }

        /// <summary>
        /// Gets or Sets WebTitle
        /// </summary>
        [DataMember(Name = "webTitle", EmitDefaultValue = true)]
        public string WebTitle { get; set; }

        /// <summary>
        /// Gets or Sets WebDescription
        /// </summary>
        [DataMember(Name = "webDescription", EmitDefaultValue = true)]
        public string WebDescription { get; set; }

        /// <summary>
        /// Gets or Sets Metadatas
        /// </summary>
        [DataMember(Name = "metadatas", EmitDefaultValue = true)]
        public List<CustomMetadata> Metadatas { get; set; }

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
            sb.Append("class ChangeWebUrlValidateResult {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  WebTitle: ").Append(WebTitle).Append("\n");
            sb.Append("  WebDescription: ").Append(WebDescription).Append("\n");
            sb.Append("  Metadatas: ").Append(Metadatas).Append("\n");
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
            return this.Equals(input as ChangeWebUrlValidateResult);
        }

        /// <summary>
        /// Returns true if ChangeWebUrlValidateResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeWebUrlValidateResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeWebUrlValidateResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.WebTitle == input.WebTitle ||
                    (this.WebTitle != null &&
                    this.WebTitle.Equals(input.WebTitle))
                ) && 
                (
                    this.WebDescription == input.WebDescription ||
                    (this.WebDescription != null &&
                    this.WebDescription.Equals(input.WebDescription))
                ) && 
                (
                    this.Metadatas == input.Metadatas ||
                    this.Metadatas != null &&
                    input.Metadatas != null &&
                    this.Metadatas.SequenceEqual(input.Metadatas)
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.WebTitle != null)
                    hashCode = hashCode * 59 + this.WebTitle.GetHashCode();
                if (this.WebDescription != null)
                    hashCode = hashCode * 59 + this.WebDescription.GetHashCode();
                if (this.Metadatas != null)
                    hashCode = hashCode * 59 + this.Metadatas.GetHashCode();
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
