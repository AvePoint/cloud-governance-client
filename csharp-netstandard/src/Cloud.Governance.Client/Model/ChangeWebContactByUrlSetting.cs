

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
    /// ChangeWebContactByUrlSetting
    /// </summary>
    [DataContract(Name = "ChangeWebContactByUrlSetting")]
    public partial class ChangeWebContactByUrlSetting : IEquatable<ChangeWebContactByUrlSetting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeWebContactByUrlSetting" /> class.
        /// </summary>
        /// <param name="siteId">siteId.</param>
        /// <param name="siteUrl">siteUrl.</param>
        /// <param name="webId">webId.</param>
        /// <param name="webUrl">webUrl.</param>
        /// <param name="primaryContact">primaryContact.</param>
        /// <param name="secondaryContact">secondaryContact.</param>
        public ChangeWebContactByUrlSetting(Guid siteId = default(Guid), string siteUrl = default(string), Guid webId = default(Guid), string webUrl = default(string), ApiUserChangedProperty primaryContact = default(ApiUserChangedProperty), ApiUserChangedProperty secondaryContact = default(ApiUserChangedProperty))
        {
            this.SiteId = siteId;
            this.SiteUrl = siteUrl;
            this.WebId = webId;
            this.WebUrl = webUrl;
            this.PrimaryContact = primaryContact;
            this.SecondaryContact = secondaryContact;
        }

        /// <summary>
        /// Gets or Sets SiteId
        /// </summary>
        [DataMember(Name = "siteId", EmitDefaultValue = false)]
        public Guid SiteId { get; set; }

        /// <summary>
        /// Gets or Sets SiteUrl
        /// </summary>
        [DataMember(Name = "siteUrl", EmitDefaultValue = true)]
        public string SiteUrl { get; set; }

        /// <summary>
        /// Gets or Sets WebId
        /// </summary>
        [DataMember(Name = "webId", EmitDefaultValue = false)]
        public Guid WebId { get; set; }

        /// <summary>
        /// Gets or Sets WebUrl
        /// </summary>
        [DataMember(Name = "webUrl", EmitDefaultValue = true)]
        public string WebUrl { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryContact
        /// </summary>
        [DataMember(Name = "primaryContact", EmitDefaultValue = false)]
        public ApiUserChangedProperty PrimaryContact { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryContact
        /// </summary>
        [DataMember(Name = "secondaryContact", EmitDefaultValue = false)]
        public ApiUserChangedProperty SecondaryContact { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeWebContactByUrlSetting {\n");
            sb.Append("  SiteId: ").Append(SiteId).Append("\n");
            sb.Append("  SiteUrl: ").Append(SiteUrl).Append("\n");
            sb.Append("  WebId: ").Append(WebId).Append("\n");
            sb.Append("  WebUrl: ").Append(WebUrl).Append("\n");
            sb.Append("  PrimaryContact: ").Append(PrimaryContact).Append("\n");
            sb.Append("  SecondaryContact: ").Append(SecondaryContact).Append("\n");
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
            return this.Equals(input as ChangeWebContactByUrlSetting);
        }

        /// <summary>
        /// Returns true if ChangeWebContactByUrlSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeWebContactByUrlSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeWebContactByUrlSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SiteId == input.SiteId ||
                    (this.SiteId != null &&
                    this.SiteId.Equals(input.SiteId))
                ) && 
                (
                    this.SiteUrl == input.SiteUrl ||
                    (this.SiteUrl != null &&
                    this.SiteUrl.Equals(input.SiteUrl))
                ) && 
                (
                    this.WebId == input.WebId ||
                    (this.WebId != null &&
                    this.WebId.Equals(input.WebId))
                ) && 
                (
                    this.WebUrl == input.WebUrl ||
                    (this.WebUrl != null &&
                    this.WebUrl.Equals(input.WebUrl))
                ) && 
                (
                    this.PrimaryContact == input.PrimaryContact ||
                    (this.PrimaryContact != null &&
                    this.PrimaryContact.Equals(input.PrimaryContact))
                ) && 
                (
                    this.SecondaryContact == input.SecondaryContact ||
                    (this.SecondaryContact != null &&
                    this.SecondaryContact.Equals(input.SecondaryContact))
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
                if (this.SiteId != null)
                    hashCode = hashCode * 59 + this.SiteId.GetHashCode();
                if (this.SiteUrl != null)
                    hashCode = hashCode * 59 + this.SiteUrl.GetHashCode();
                if (this.WebId != null)
                    hashCode = hashCode * 59 + this.WebId.GetHashCode();
                if (this.WebUrl != null)
                    hashCode = hashCode * 59 + this.WebUrl.GetHashCode();
                if (this.PrimaryContact != null)
                    hashCode = hashCode * 59 + this.PrimaryContact.GetHashCode();
                if (this.SecondaryContact != null)
                    hashCode = hashCode * 59 + this.SecondaryContact.GetHashCode();
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
