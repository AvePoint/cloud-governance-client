

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
    /// ChangeContactByUrlSetting
    /// </summary>
    [DataContract(Name = "ChangeContactByUrlSetting")]
    public partial class ChangeContactByUrlSetting : IEquatable<ChangeContactByUrlSetting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeContactByUrlSetting" /> class.
        /// </summary>
        /// <param name="siteId">siteId.</param>
        /// <param name="siteUrl">siteUrl.</param>
        /// <param name="originalPrimaryContact">originalPrimaryContact.</param>
        /// <param name="newPrimaryContact">newPrimaryContact.</param>
        /// <param name="originalSecondaryContact">originalSecondaryContact.</param>
        /// <param name="newSecondaryContact">newSecondaryContact.</param>
        /// <param name="originalPrimaryAdministrator">originalPrimaryAdministrator.</param>
        /// <param name="newPrimaryAdministrator">newPrimaryAdministrator.</param>
        /// <param name="originalAdditionalAdministrators">originalAdditionalAdministrators.</param>
        /// <param name="newAdditionalAdministrators">newAdditionalAdministrators.</param>
        public ChangeContactByUrlSetting(Guid siteId = default(Guid), string siteUrl = default(string), ApiUser originalPrimaryContact = default(ApiUser), ApiUser newPrimaryContact = default(ApiUser), ApiUser originalSecondaryContact = default(ApiUser), ApiUser newSecondaryContact = default(ApiUser), ApiUser originalPrimaryAdministrator = default(ApiUser), ApiUser newPrimaryAdministrator = default(ApiUser), List<ApiUser> originalAdditionalAdministrators = default(List<ApiUser>), List<ApiUser> newAdditionalAdministrators = default(List<ApiUser>))
        {
            this.SiteId = siteId;
            this.SiteUrl = siteUrl;
            this.OriginalPrimaryContact = originalPrimaryContact;
            this.NewPrimaryContact = newPrimaryContact;
            this.OriginalSecondaryContact = originalSecondaryContact;
            this.NewSecondaryContact = newSecondaryContact;
            this.OriginalPrimaryAdministrator = originalPrimaryAdministrator;
            this.NewPrimaryAdministrator = newPrimaryAdministrator;
            this.OriginalAdditionalAdministrators = originalAdditionalAdministrators;
            this.NewAdditionalAdministrators = newAdditionalAdministrators;
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
        /// Gets or Sets OriginalPrimaryContact
        /// </summary>
        [DataMember(Name = "originalPrimaryContact", EmitDefaultValue = true)]
        public ApiUser OriginalPrimaryContact { get; set; }

        /// <summary>
        /// Gets or Sets NewPrimaryContact
        /// </summary>
        [DataMember(Name = "newPrimaryContact", EmitDefaultValue = true)]
        public ApiUser NewPrimaryContact { get; set; }

        /// <summary>
        /// Gets or Sets OriginalSecondaryContact
        /// </summary>
        [DataMember(Name = "originalSecondaryContact", EmitDefaultValue = true)]
        public ApiUser OriginalSecondaryContact { get; set; }

        /// <summary>
        /// Gets or Sets NewSecondaryContact
        /// </summary>
        [DataMember(Name = "newSecondaryContact", EmitDefaultValue = true)]
        public ApiUser NewSecondaryContact { get; set; }

        /// <summary>
        /// Gets or Sets OriginalPrimaryAdministrator
        /// </summary>
        [DataMember(Name = "originalPrimaryAdministrator", EmitDefaultValue = true)]
        public ApiUser OriginalPrimaryAdministrator { get; set; }

        /// <summary>
        /// Gets or Sets NewPrimaryAdministrator
        /// </summary>
        [DataMember(Name = "newPrimaryAdministrator", EmitDefaultValue = true)]
        public ApiUser NewPrimaryAdministrator { get; set; }

        /// <summary>
        /// Gets or Sets OriginalAdditionalAdministrators
        /// </summary>
        [DataMember(Name = "originalAdditionalAdministrators", EmitDefaultValue = true)]
        public List<ApiUser> OriginalAdditionalAdministrators { get; set; }

        /// <summary>
        /// Gets or Sets NewAdditionalAdministrators
        /// </summary>
        [DataMember(Name = "newAdditionalAdministrators", EmitDefaultValue = true)]
        public List<ApiUser> NewAdditionalAdministrators { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeContactByUrlSetting {\n");
            sb.Append("  SiteId: ").Append(SiteId).Append("\n");
            sb.Append("  SiteUrl: ").Append(SiteUrl).Append("\n");
            sb.Append("  OriginalPrimaryContact: ").Append(OriginalPrimaryContact).Append("\n");
            sb.Append("  NewPrimaryContact: ").Append(NewPrimaryContact).Append("\n");
            sb.Append("  OriginalSecondaryContact: ").Append(OriginalSecondaryContact).Append("\n");
            sb.Append("  NewSecondaryContact: ").Append(NewSecondaryContact).Append("\n");
            sb.Append("  OriginalPrimaryAdministrator: ").Append(OriginalPrimaryAdministrator).Append("\n");
            sb.Append("  NewPrimaryAdministrator: ").Append(NewPrimaryAdministrator).Append("\n");
            sb.Append("  OriginalAdditionalAdministrators: ").Append(OriginalAdditionalAdministrators).Append("\n");
            sb.Append("  NewAdditionalAdministrators: ").Append(NewAdditionalAdministrators).Append("\n");
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
            return this.Equals(input as ChangeContactByUrlSetting);
        }

        /// <summary>
        /// Returns true if ChangeContactByUrlSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeContactByUrlSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeContactByUrlSetting input)
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
                    this.OriginalPrimaryContact == input.OriginalPrimaryContact ||
                    (this.OriginalPrimaryContact != null &&
                    this.OriginalPrimaryContact.Equals(input.OriginalPrimaryContact))
                ) && 
                (
                    this.NewPrimaryContact == input.NewPrimaryContact ||
                    (this.NewPrimaryContact != null &&
                    this.NewPrimaryContact.Equals(input.NewPrimaryContact))
                ) && 
                (
                    this.OriginalSecondaryContact == input.OriginalSecondaryContact ||
                    (this.OriginalSecondaryContact != null &&
                    this.OriginalSecondaryContact.Equals(input.OriginalSecondaryContact))
                ) && 
                (
                    this.NewSecondaryContact == input.NewSecondaryContact ||
                    (this.NewSecondaryContact != null &&
                    this.NewSecondaryContact.Equals(input.NewSecondaryContact))
                ) && 
                (
                    this.OriginalPrimaryAdministrator == input.OriginalPrimaryAdministrator ||
                    (this.OriginalPrimaryAdministrator != null &&
                    this.OriginalPrimaryAdministrator.Equals(input.OriginalPrimaryAdministrator))
                ) && 
                (
                    this.NewPrimaryAdministrator == input.NewPrimaryAdministrator ||
                    (this.NewPrimaryAdministrator != null &&
                    this.NewPrimaryAdministrator.Equals(input.NewPrimaryAdministrator))
                ) && 
                (
                    this.OriginalAdditionalAdministrators == input.OriginalAdditionalAdministrators ||
                    this.OriginalAdditionalAdministrators != null &&
                    input.OriginalAdditionalAdministrators != null &&
                    this.OriginalAdditionalAdministrators.SequenceEqual(input.OriginalAdditionalAdministrators)
                ) && 
                (
                    this.NewAdditionalAdministrators == input.NewAdditionalAdministrators ||
                    this.NewAdditionalAdministrators != null &&
                    input.NewAdditionalAdministrators != null &&
                    this.NewAdditionalAdministrators.SequenceEqual(input.NewAdditionalAdministrators)
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
                if (this.OriginalPrimaryContact != null)
                    hashCode = hashCode * 59 + this.OriginalPrimaryContact.GetHashCode();
                if (this.NewPrimaryContact != null)
                    hashCode = hashCode * 59 + this.NewPrimaryContact.GetHashCode();
                if (this.OriginalSecondaryContact != null)
                    hashCode = hashCode * 59 + this.OriginalSecondaryContact.GetHashCode();
                if (this.NewSecondaryContact != null)
                    hashCode = hashCode * 59 + this.NewSecondaryContact.GetHashCode();
                if (this.OriginalPrimaryAdministrator != null)
                    hashCode = hashCode * 59 + this.OriginalPrimaryAdministrator.GetHashCode();
                if (this.NewPrimaryAdministrator != null)
                    hashCode = hashCode * 59 + this.NewPrimaryAdministrator.GetHashCode();
                if (this.OriginalAdditionalAdministrators != null)
                    hashCode = hashCode * 59 + this.OriginalAdditionalAdministrators.GetHashCode();
                if (this.NewAdditionalAdministrators != null)
                    hashCode = hashCode * 59 + this.NewAdditionalAdministrators.GetHashCode();
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
