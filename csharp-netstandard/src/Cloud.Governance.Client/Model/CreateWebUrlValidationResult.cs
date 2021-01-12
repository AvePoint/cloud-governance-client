

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
    /// CreateWebUrlValidationResult
    /// </summary>
    [DataContract(Name = "CreateWebUrlValidationResult")]
    public partial class CreateWebUrlValidationResult : IEquatable<CreateWebUrlValidationResult>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets MessageCode
        /// </summary>
        [DataMember(Name = "messageCode", EmitDefaultValue = false)]
        public MessageCode? MessageCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebUrlValidationResult" /> class.
        /// </summary>
        /// <param name="parentWebUrl">parentWebUrl.</param>
        /// <param name="parentSiteUrl">parentSiteUrl.</param>
        /// <param name="sitePrimaryContact">sitePrimaryContact.</param>
        /// <param name="siteSecondaryContact">siteSecondaryContact.</param>
        /// <param name="isValid">isValid.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="messageCode">messageCode.</param>
        public CreateWebUrlValidationResult(string parentWebUrl = default(string), string parentSiteUrl = default(string), ApiUser sitePrimaryContact = default(ApiUser), ApiUser siteSecondaryContact = default(ApiUser), bool isValid = default(bool), string errorMessage = default(string), MessageCode? messageCode = default(MessageCode?))
        {
            this.ParentWebUrl = parentWebUrl;
            this.ParentSiteUrl = parentSiteUrl;
            this.SitePrimaryContact = sitePrimaryContact;
            this.SiteSecondaryContact = siteSecondaryContact;
            this.IsValid = isValid;
            this.ErrorMessage = errorMessage;
            this.MessageCode = messageCode;
        }

        /// <summary>
        /// Gets or Sets ParentWebUrl
        /// </summary>
        [DataMember(Name = "parentWebUrl", EmitDefaultValue = true)]
        public string ParentWebUrl { get; set; }

        /// <summary>
        /// Gets or Sets ParentSiteUrl
        /// </summary>
        [DataMember(Name = "parentSiteUrl", EmitDefaultValue = true)]
        public string ParentSiteUrl { get; set; }

        /// <summary>
        /// Gets or Sets SitePrimaryContact
        /// </summary>
        [DataMember(Name = "sitePrimaryContact", EmitDefaultValue = true)]
        public ApiUser SitePrimaryContact { get; set; }

        /// <summary>
        /// Gets or Sets SiteSecondaryContact
        /// </summary>
        [DataMember(Name = "siteSecondaryContact", EmitDefaultValue = true)]
        public ApiUser SiteSecondaryContact { get; set; }

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
            sb.Append("class CreateWebUrlValidationResult {\n");
            sb.Append("  ParentWebUrl: ").Append(ParentWebUrl).Append("\n");
            sb.Append("  ParentSiteUrl: ").Append(ParentSiteUrl).Append("\n");
            sb.Append("  SitePrimaryContact: ").Append(SitePrimaryContact).Append("\n");
            sb.Append("  SiteSecondaryContact: ").Append(SiteSecondaryContact).Append("\n");
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
            return this.Equals(input as CreateWebUrlValidationResult);
        }

        /// <summary>
        /// Returns true if CreateWebUrlValidationResult instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateWebUrlValidationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateWebUrlValidationResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ParentWebUrl == input.ParentWebUrl ||
                    (this.ParentWebUrl != null &&
                    this.ParentWebUrl.Equals(input.ParentWebUrl))
                ) && 
                (
                    this.ParentSiteUrl == input.ParentSiteUrl ||
                    (this.ParentSiteUrl != null &&
                    this.ParentSiteUrl.Equals(input.ParentSiteUrl))
                ) && 
                (
                    this.SitePrimaryContact == input.SitePrimaryContact ||
                    (this.SitePrimaryContact != null &&
                    this.SitePrimaryContact.Equals(input.SitePrimaryContact))
                ) && 
                (
                    this.SiteSecondaryContact == input.SiteSecondaryContact ||
                    (this.SiteSecondaryContact != null &&
                    this.SiteSecondaryContact.Equals(input.SiteSecondaryContact))
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
                if (this.ParentWebUrl != null)
                    hashCode = hashCode * 59 + this.ParentWebUrl.GetHashCode();
                if (this.ParentSiteUrl != null)
                    hashCode = hashCode * 59 + this.ParentSiteUrl.GetHashCode();
                if (this.SitePrimaryContact != null)
                    hashCode = hashCode * 59 + this.SitePrimaryContact.GetHashCode();
                if (this.SiteSecondaryContact != null)
                    hashCode = hashCode * 59 + this.SiteSecondaryContact.GetHashCode();
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
