

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
    /// CreateGuestUserSubRequest
    /// </summary>
    [DataContract(Name = "CreateGuestUserSubRequest")]
    public partial class CreateGuestUserSubRequest : IEquatable<CreateGuestUserSubRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ProcessStatus
        /// </summary>
        [DataMember(Name = "processStatus", EmitDefaultValue = false)]
        public ApiRequestProgressStatus? ProcessStatus { get; set; }

        /// <summary>
        /// Returns false as ProcessStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProcessStatus()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGuestUserSubRequest" /> class.
        /// </summary>
        /// <param name="userProperties">userProperties.</param>
        /// <param name="welcomeEmailMessage">welcomeEmailMessage.</param>
        /// <param name="primaryContact">ApiUser model.</param>
        /// <param name="secondaryContact">ApiUser model.</param>
        /// <param name="inviteGroups">inviteGroups.</param>
        /// <param name="oneTimeSettings">oneTimeSettings.</param>
        /// <param name="metadatas">metadatas.</param>
        /// <param name="assignTo">assignTo.</param>
        public CreateGuestUserSubRequest(GuestUserPropertyModel userProperties = default(GuestUserPropertyModel), string welcomeEmailMessage = default(string), ApiUser primaryContact = default(ApiUser), ApiUser secondaryContact = default(ApiUser), List<ApiUser> inviteGroups = default(List<ApiUser>), GuestUserRequestOneTimeRenewalSettingModel oneTimeSettings = default(GuestUserRequestOneTimeRenewalSettingModel), List<RequestMetadata> metadatas = default(List<RequestMetadata>), List<ApiUser> assignTo = default(List<ApiUser>))
        {
            this.UserProperties = userProperties;
            this.WelcomeEmailMessage = welcomeEmailMessage;
            this.PrimaryContact = primaryContact;
            this.SecondaryContact = secondaryContact;
            this.InviteGroups = inviteGroups;
            this.OneTimeSettings = oneTimeSettings;
            this.Metadatas = metadatas;
            this.AssignTo = assignTo;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets UserProperties
        /// </summary>
        [DataMember(Name = "userProperties", EmitDefaultValue = true)]
        public GuestUserPropertyModel UserProperties { get; set; }

        /// <summary>
        /// Gets or Sets WelcomeEmailMessage
        /// </summary>
        [DataMember(Name = "welcomeEmailMessage", EmitDefaultValue = true)]
        public string WelcomeEmailMessage { get; set; }

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
        /// Gets or Sets InviteGroups
        /// </summary>
        [DataMember(Name = "inviteGroups", EmitDefaultValue = true)]
        public List<ApiUser> InviteGroups { get; set; }

        /// <summary>
        /// Gets or Sets OneTimeSettings
        /// </summary>
        [DataMember(Name = "oneTimeSettings", EmitDefaultValue = true)]
        public GuestUserRequestOneTimeRenewalSettingModel OneTimeSettings { get; set; }

        /// <summary>
        /// Gets or Sets Metadatas
        /// </summary>
        [DataMember(Name = "metadatas", EmitDefaultValue = true)]
        public List<RequestMetadata> Metadatas { get; set; }

        /// <summary>
        /// Gets or Sets AssignTo
        /// </summary>
        [DataMember(Name = "assignTo", EmitDefaultValue = true)]
        public List<ApiUser> AssignTo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateGuestUserSubRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserProperties: ").Append(UserProperties).Append("\n");
            sb.Append("  WelcomeEmailMessage: ").Append(WelcomeEmailMessage).Append("\n");
            sb.Append("  PrimaryContact: ").Append(PrimaryContact).Append("\n");
            sb.Append("  SecondaryContact: ").Append(SecondaryContact).Append("\n");
            sb.Append("  InviteGroups: ").Append(InviteGroups).Append("\n");
            sb.Append("  OneTimeSettings: ").Append(OneTimeSettings).Append("\n");
            sb.Append("  Metadatas: ").Append(Metadatas).Append("\n");
            sb.Append("  ProcessStatus: ").Append(ProcessStatus).Append("\n");
            sb.Append("  AssignTo: ").Append(AssignTo).Append("\n");
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
            return this.Equals(input as CreateGuestUserSubRequest);
        }

        /// <summary>
        /// Returns true if CreateGuestUserSubRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateGuestUserSubRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateGuestUserSubRequest input)
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
                    this.UserProperties == input.UserProperties ||
                    (this.UserProperties != null &&
                    this.UserProperties.Equals(input.UserProperties))
                ) && 
                (
                    this.WelcomeEmailMessage == input.WelcomeEmailMessage ||
                    (this.WelcomeEmailMessage != null &&
                    this.WelcomeEmailMessage.Equals(input.WelcomeEmailMessage))
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
                    this.InviteGroups == input.InviteGroups ||
                    this.InviteGroups != null &&
                    input.InviteGroups != null &&
                    this.InviteGroups.SequenceEqual(input.InviteGroups)
                ) && 
                (
                    this.OneTimeSettings == input.OneTimeSettings ||
                    (this.OneTimeSettings != null &&
                    this.OneTimeSettings.Equals(input.OneTimeSettings))
                ) && 
                (
                    this.Metadatas == input.Metadatas ||
                    this.Metadatas != null &&
                    input.Metadatas != null &&
                    this.Metadatas.SequenceEqual(input.Metadatas)
                ) && 
                (
                    this.ProcessStatus == input.ProcessStatus ||
                    this.ProcessStatus.Equals(input.ProcessStatus)
                ) && 
                (
                    this.AssignTo == input.AssignTo ||
                    this.AssignTo != null &&
                    input.AssignTo != null &&
                    this.AssignTo.SequenceEqual(input.AssignTo)
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
                if (this.UserProperties != null)
                    hashCode = hashCode * 59 + this.UserProperties.GetHashCode();
                if (this.WelcomeEmailMessage != null)
                    hashCode = hashCode * 59 + this.WelcomeEmailMessage.GetHashCode();
                if (this.PrimaryContact != null)
                    hashCode = hashCode * 59 + this.PrimaryContact.GetHashCode();
                if (this.SecondaryContact != null)
                    hashCode = hashCode * 59 + this.SecondaryContact.GetHashCode();
                if (this.InviteGroups != null)
                    hashCode = hashCode * 59 + this.InviteGroups.GetHashCode();
                if (this.OneTimeSettings != null)
                    hashCode = hashCode * 59 + this.OneTimeSettings.GetHashCode();
                if (this.Metadatas != null)
                    hashCode = hashCode * 59 + this.Metadatas.GetHashCode();
                hashCode = hashCode * 59 + this.ProcessStatus.GetHashCode();
                if (this.AssignTo != null)
                    hashCode = hashCode * 59 + this.AssignTo.GetHashCode();
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
