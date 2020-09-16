

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
    /// GuestUserGridModel
    /// </summary>
    [DataContract(Name = "GuestUserGridModel")]
    public partial class GuestUserGridModel : IEquatable<GuestUserGridModel>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public GuestUserStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GuestUserGridModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="mail">mail.</param>
        /// <param name="primaryContact">primaryContact.</param>
        /// <param name="primaryContactDisplayName">primaryContactDisplayName.</param>
        /// <param name="secondaryContact">secondaryContact.</param>
        /// <param name="secondaryContactDisplayName">secondaryContactDisplayName.</param>
        /// <param name="status">status.</param>
        /// <param name="statusDescription">statusDescription.</param>
        /// <param name="profileName">profileName.</param>
        /// <param name="metadata">metadata.</param>
        public GuestUserGridModel(Guid id = default(Guid), string displayName = default(string), string mail = default(string), string primaryContact = default(string), string primaryContactDisplayName = default(string), string secondaryContact = default(string), string secondaryContactDisplayName = default(string), GuestUserStatus? status = default(GuestUserStatus?), string statusDescription = default(string), string profileName = default(string), List<ReportMetadata> metadata = default(List<ReportMetadata>))
        {
            this.Id = id;
            this.DisplayName = displayName;
            this.Mail = mail;
            this.PrimaryContact = primaryContact;
            this.PrimaryContactDisplayName = primaryContactDisplayName;
            this.SecondaryContact = secondaryContact;
            this.SecondaryContactDisplayName = secondaryContactDisplayName;
            this.Status = status;
            this.StatusDescription = statusDescription;
            this.ProfileName = profileName;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Mail
        /// </summary>
        [DataMember(Name = "mail", EmitDefaultValue = true)]
        public string Mail { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryContact
        /// </summary>
        [DataMember(Name = "primaryContact", EmitDefaultValue = true)]
        public string PrimaryContact { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryContactDisplayName
        /// </summary>
        [DataMember(Name = "primaryContactDisplayName", EmitDefaultValue = true)]
        public string PrimaryContactDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryContact
        /// </summary>
        [DataMember(Name = "secondaryContact", EmitDefaultValue = true)]
        public string SecondaryContact { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryContactDisplayName
        /// </summary>
        [DataMember(Name = "secondaryContactDisplayName", EmitDefaultValue = true)]
        public string SecondaryContactDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets StatusDescription
        /// </summary>
        [DataMember(Name = "statusDescription", EmitDefaultValue = true)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Gets or Sets ProfileName
        /// </summary>
        [DataMember(Name = "profileName", EmitDefaultValue = true)]
        public string ProfileName { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public List<ReportMetadata> Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GuestUserGridModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Mail: ").Append(Mail).Append("\n");
            sb.Append("  PrimaryContact: ").Append(PrimaryContact).Append("\n");
            sb.Append("  PrimaryContactDisplayName: ").Append(PrimaryContactDisplayName).Append("\n");
            sb.Append("  SecondaryContact: ").Append(SecondaryContact).Append("\n");
            sb.Append("  SecondaryContactDisplayName: ").Append(SecondaryContactDisplayName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  ProfileName: ").Append(ProfileName).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as GuestUserGridModel);
        }

        /// <summary>
        /// Returns true if GuestUserGridModel instances are equal
        /// </summary>
        /// <param name="input">Instance of GuestUserGridModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GuestUserGridModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Mail == input.Mail ||
                    (this.Mail != null &&
                    this.Mail.Equals(input.Mail))
                ) && 
                (
                    this.PrimaryContact == input.PrimaryContact ||
                    (this.PrimaryContact != null &&
                    this.PrimaryContact.Equals(input.PrimaryContact))
                ) && 
                (
                    this.PrimaryContactDisplayName == input.PrimaryContactDisplayName ||
                    (this.PrimaryContactDisplayName != null &&
                    this.PrimaryContactDisplayName.Equals(input.PrimaryContactDisplayName))
                ) && 
                (
                    this.SecondaryContact == input.SecondaryContact ||
                    (this.SecondaryContact != null &&
                    this.SecondaryContact.Equals(input.SecondaryContact))
                ) && 
                (
                    this.SecondaryContactDisplayName == input.SecondaryContactDisplayName ||
                    (this.SecondaryContactDisplayName != null &&
                    this.SecondaryContactDisplayName.Equals(input.SecondaryContactDisplayName))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.StatusDescription == input.StatusDescription ||
                    (this.StatusDescription != null &&
                    this.StatusDescription.Equals(input.StatusDescription))
                ) && 
                (
                    this.ProfileName == input.ProfileName ||
                    (this.ProfileName != null &&
                    this.ProfileName.Equals(input.ProfileName))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Mail != null)
                    hashCode = hashCode * 59 + this.Mail.GetHashCode();
                if (this.PrimaryContact != null)
                    hashCode = hashCode * 59 + this.PrimaryContact.GetHashCode();
                if (this.PrimaryContactDisplayName != null)
                    hashCode = hashCode * 59 + this.PrimaryContactDisplayName.GetHashCode();
                if (this.SecondaryContact != null)
                    hashCode = hashCode * 59 + this.SecondaryContact.GetHashCode();
                if (this.SecondaryContactDisplayName != null)
                    hashCode = hashCode * 59 + this.SecondaryContactDisplayName.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusDescription != null)
                    hashCode = hashCode * 59 + this.StatusDescription.GetHashCode();
                if (this.ProfileName != null)
                    hashCode = hashCode * 59 + this.ProfileName.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
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
