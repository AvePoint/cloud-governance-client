

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
    /// ChangeSiteSettingValidateResult
    /// </summary>
    [DataContract(Name = "ChangeSiteSettingValidateResult")]
    public partial class ChangeSiteSettingValidateResult : IEquatable<ChangeSiteSettingValidateResult>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets MessageCode
        /// </summary>
        [DataMember(Name = "messageCode", EmitDefaultValue = false)]
        public MessageCode? MessageCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeSiteSettingValidateResult" /> class.
        /// </summary>
        /// <param name="siteUrl">siteUrl.</param>
        /// <param name="siteId">siteId.</param>
        /// <param name="siteTitle">siteTitle.</param>
        /// <param name="siteDescription">siteDescription.</param>
        /// <param name="isEnableChangeHubSite">isEnableChangeHubSite (default to false).</param>
        /// <param name="isModernSite">isModernSite (default to false).</param>
        /// <param name="isHubSite">isHubSite (default to false).</param>
        /// <param name="associatedHubSiteId">associatedHubSiteId.</param>
        /// <param name="metadatas">metadatas.</param>
        /// <param name="primaryContact">ApiUser model.</param>
        /// <param name="secondaryContact">ApiUser model.</param>
        /// <param name="primaryAdministrator">ApiUser model.</param>
        /// <param name="isValid">isValid (default to false).</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="messageCode">messageCode.</param>
        public ChangeSiteSettingValidateResult(string siteUrl = default(string), Guid siteId = default(Guid), string siteTitle = default(string), string siteDescription = default(string), bool isEnableChangeHubSite = false, bool isModernSite = false, bool isHubSite = false, Guid? associatedHubSiteId = default(Guid?), List<CustomMetadata> metadatas = default(List<CustomMetadata>), ApiUser primaryContact = default(ApiUser), ApiUser secondaryContact = default(ApiUser), ApiUser primaryAdministrator = default(ApiUser), bool isValid = false, string errorMessage = default(string), MessageCode? messageCode = default(MessageCode?))
        {
            this.SiteUrl = siteUrl;
            this.SiteId = siteId;
            this.SiteTitle = siteTitle;
            this.SiteDescription = siteDescription;
            this.IsEnableChangeHubSite = isEnableChangeHubSite;
            this.IsModernSite = isModernSite;
            this.IsHubSite = isHubSite;
            this.AssociatedHubSiteId = associatedHubSiteId;
            this.Metadatas = metadatas;
            this.PrimaryContact = primaryContact;
            this.SecondaryContact = secondaryContact;
            this.PrimaryAdministrator = primaryAdministrator;
            this.IsValid = isValid;
            this.ErrorMessage = errorMessage;
            this.MessageCode = messageCode;
        }

        /// <summary>
        /// Gets or Sets SiteUrl
        /// </summary>
        [DataMember(Name = "siteUrl", EmitDefaultValue = true)]
        public string SiteUrl { get; set; }

        /// <summary>
        /// Gets or Sets SiteId
        /// </summary>
        [DataMember(Name = "siteId", EmitDefaultValue = false)]
        public Guid SiteId { get; set; }

        /// <summary>
        /// Gets or Sets SiteTitle
        /// </summary>
        [DataMember(Name = "siteTitle", EmitDefaultValue = true)]
        public string SiteTitle { get; set; }

        /// <summary>
        /// Gets or Sets SiteDescription
        /// </summary>
        [DataMember(Name = "siteDescription", EmitDefaultValue = true)]
        public string SiteDescription { get; set; }

        /// <summary>
        /// Gets or Sets IsEnableChangeHubSite
        /// </summary>
        [DataMember(Name = "isEnableChangeHubSite", EmitDefaultValue = false)]
        public bool IsEnableChangeHubSite { get; set; }

        /// <summary>
        /// Gets or Sets IsModernSite
        /// </summary>
        [DataMember(Name = "isModernSite", EmitDefaultValue = false)]
        public bool IsModernSite { get; set; }

        /// <summary>
        /// Gets or Sets IsHubSite
        /// </summary>
        [DataMember(Name = "isHubSite", EmitDefaultValue = false)]
        public bool IsHubSite { get; set; }

        /// <summary>
        /// Gets or Sets AssociatedHubSiteId
        /// </summary>
        [DataMember(Name = "associatedHubSiteId", EmitDefaultValue = true)]
        public Guid? AssociatedHubSiteId { get; set; }

        /// <summary>
        /// Gets or Sets Metadatas
        /// </summary>
        [DataMember(Name = "metadatas", EmitDefaultValue = true)]
        public List<CustomMetadata> Metadatas { get; set; }

        /// <summary>
        /// ApiUser model
        /// </summary>
        /// <value>ApiUser model</value>
        [DataMember(Name = "primaryContact", EmitDefaultValue = true)]
        public ApiUser PrimaryContact { get; set; }

        /// <summary>
        /// ApiUser model
        /// </summary>
        /// <value>ApiUser model</value>
        [DataMember(Name = "secondaryContact", EmitDefaultValue = true)]
        public ApiUser SecondaryContact { get; set; }

        /// <summary>
        /// ApiUser model
        /// </summary>
        /// <value>ApiUser model</value>
        [DataMember(Name = "primaryAdministrator", EmitDefaultValue = true)]
        public ApiUser PrimaryAdministrator { get; set; }

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
            sb.Append("class ChangeSiteSettingValidateResult {\n");
            sb.Append("  SiteUrl: ").Append(SiteUrl).Append("\n");
            sb.Append("  SiteId: ").Append(SiteId).Append("\n");
            sb.Append("  SiteTitle: ").Append(SiteTitle).Append("\n");
            sb.Append("  SiteDescription: ").Append(SiteDescription).Append("\n");
            sb.Append("  IsEnableChangeHubSite: ").Append(IsEnableChangeHubSite).Append("\n");
            sb.Append("  IsModernSite: ").Append(IsModernSite).Append("\n");
            sb.Append("  IsHubSite: ").Append(IsHubSite).Append("\n");
            sb.Append("  AssociatedHubSiteId: ").Append(AssociatedHubSiteId).Append("\n");
            sb.Append("  Metadatas: ").Append(Metadatas).Append("\n");
            sb.Append("  PrimaryContact: ").Append(PrimaryContact).Append("\n");
            sb.Append("  SecondaryContact: ").Append(SecondaryContact).Append("\n");
            sb.Append("  PrimaryAdministrator: ").Append(PrimaryAdministrator).Append("\n");
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
            return this.Equals(input as ChangeSiteSettingValidateResult);
        }

        /// <summary>
        /// Returns true if ChangeSiteSettingValidateResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeSiteSettingValidateResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeSiteSettingValidateResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SiteUrl == input.SiteUrl ||
                    (this.SiteUrl != null &&
                    this.SiteUrl.Equals(input.SiteUrl))
                ) && 
                (
                    this.SiteId == input.SiteId ||
                    (this.SiteId != null &&
                    this.SiteId.Equals(input.SiteId))
                ) && 
                (
                    this.SiteTitle == input.SiteTitle ||
                    (this.SiteTitle != null &&
                    this.SiteTitle.Equals(input.SiteTitle))
                ) && 
                (
                    this.SiteDescription == input.SiteDescription ||
                    (this.SiteDescription != null &&
                    this.SiteDescription.Equals(input.SiteDescription))
                ) && 
                (
                    this.IsEnableChangeHubSite == input.IsEnableChangeHubSite ||
                    this.IsEnableChangeHubSite.Equals(input.IsEnableChangeHubSite)
                ) && 
                (
                    this.IsModernSite == input.IsModernSite ||
                    this.IsModernSite.Equals(input.IsModernSite)
                ) && 
                (
                    this.IsHubSite == input.IsHubSite ||
                    this.IsHubSite.Equals(input.IsHubSite)
                ) && 
                (
                    this.AssociatedHubSiteId == input.AssociatedHubSiteId ||
                    (this.AssociatedHubSiteId != null &&
                    this.AssociatedHubSiteId.Equals(input.AssociatedHubSiteId))
                ) && 
                (
                    this.Metadatas == input.Metadatas ||
                    this.Metadatas != null &&
                    input.Metadatas != null &&
                    this.Metadatas.SequenceEqual(input.Metadatas)
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
                ) && 
                (
                    this.PrimaryAdministrator == input.PrimaryAdministrator ||
                    (this.PrimaryAdministrator != null &&
                    this.PrimaryAdministrator.Equals(input.PrimaryAdministrator))
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
                if (this.SiteUrl != null)
                    hashCode = hashCode * 59 + this.SiteUrl.GetHashCode();
                if (this.SiteId != null)
                    hashCode = hashCode * 59 + this.SiteId.GetHashCode();
                if (this.SiteTitle != null)
                    hashCode = hashCode * 59 + this.SiteTitle.GetHashCode();
                if (this.SiteDescription != null)
                    hashCode = hashCode * 59 + this.SiteDescription.GetHashCode();
                hashCode = hashCode * 59 + this.IsEnableChangeHubSite.GetHashCode();
                hashCode = hashCode * 59 + this.IsModernSite.GetHashCode();
                hashCode = hashCode * 59 + this.IsHubSite.GetHashCode();
                if (this.AssociatedHubSiteId != null)
                    hashCode = hashCode * 59 + this.AssociatedHubSiteId.GetHashCode();
                if (this.Metadatas != null)
                    hashCode = hashCode * 59 + this.Metadatas.GetHashCode();
                if (this.PrimaryContact != null)
                    hashCode = hashCode * 59 + this.PrimaryContact.GetHashCode();
                if (this.SecondaryContact != null)
                    hashCode = hashCode * 59 + this.SecondaryContact.GetHashCode();
                if (this.PrimaryAdministrator != null)
                    hashCode = hashCode * 59 + this.PrimaryAdministrator.GetHashCode();
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
