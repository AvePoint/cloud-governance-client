

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
    /// WelcomeEmailSettings
    /// </summary>
    [DataContract(Name = "WelcomeEmailSettings")]
    public partial class WelcomeEmailSettings : IEquatable<WelcomeEmailSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WelcomeEmailSettings" /> class.
        /// </summary>
        /// <param name="enabled">enabled (default to false).</param>
        /// <param name="subject">subject.</param>
        /// <param name="personalMessage">personalMessage.</param>
        /// <param name="enabledSendEmailInService">enabledSendEmailInService (default to false).</param>
        /// <param name="welcomeEmailTemplateId">welcomeEmailTemplateId.</param>
        /// <param name="isWelcomeEmailTemplate">isWelcomeEmailTemplate (default to false).</param>
        public WelcomeEmailSettings(bool enabled = false, string subject = default(string), string personalMessage = default(string), bool enabledSendEmailInService = false, Guid welcomeEmailTemplateId = default(Guid), bool isWelcomeEmailTemplate = false)
        {
            this.Enabled = enabled;
            this.Subject = subject;
            this.PersonalMessage = personalMessage;
            this.EnabledSendEmailInService = enabledSendEmailInService;
            this.WelcomeEmailTemplateId = welcomeEmailTemplateId;
            this.IsWelcomeEmailTemplate = isWelcomeEmailTemplate;
        }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", EmitDefaultValue = true)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets PersonalMessage
        /// </summary>
        [DataMember(Name = "personalMessage", EmitDefaultValue = true)]
        public string PersonalMessage { get; set; }

        /// <summary>
        /// Gets or Sets EnabledSendEmailInService
        /// </summary>
        [DataMember(Name = "enabledSendEmailInService", EmitDefaultValue = false)]
        public bool EnabledSendEmailInService { get; set; }

        /// <summary>
        /// Gets or Sets WelcomeEmailTemplateId
        /// </summary>
        [DataMember(Name = "welcomeEmailTemplateId", EmitDefaultValue = false)]
        public Guid WelcomeEmailTemplateId { get; set; }

        /// <summary>
        /// Gets or Sets IsWelcomeEmailTemplate
        /// </summary>
        [DataMember(Name = "isWelcomeEmailTemplate", EmitDefaultValue = false)]
        public bool IsWelcomeEmailTemplate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WelcomeEmailSettings {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  PersonalMessage: ").Append(PersonalMessage).Append("\n");
            sb.Append("  EnabledSendEmailInService: ").Append(EnabledSendEmailInService).Append("\n");
            sb.Append("  WelcomeEmailTemplateId: ").Append(WelcomeEmailTemplateId).Append("\n");
            sb.Append("  IsWelcomeEmailTemplate: ").Append(IsWelcomeEmailTemplate).Append("\n");
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
            return this.Equals(input as WelcomeEmailSettings);
        }

        /// <summary>
        /// Returns true if WelcomeEmailSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of WelcomeEmailSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WelcomeEmailSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.PersonalMessage == input.PersonalMessage ||
                    (this.PersonalMessage != null &&
                    this.PersonalMessage.Equals(input.PersonalMessage))
                ) && 
                (
                    this.EnabledSendEmailInService == input.EnabledSendEmailInService ||
                    this.EnabledSendEmailInService.Equals(input.EnabledSendEmailInService)
                ) && 
                (
                    this.WelcomeEmailTemplateId == input.WelcomeEmailTemplateId ||
                    (this.WelcomeEmailTemplateId != null &&
                    this.WelcomeEmailTemplateId.Equals(input.WelcomeEmailTemplateId))
                ) && 
                (
                    this.IsWelcomeEmailTemplate == input.IsWelcomeEmailTemplate ||
                    this.IsWelcomeEmailTemplate.Equals(input.IsWelcomeEmailTemplate)
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
                hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.PersonalMessage != null)
                    hashCode = hashCode * 59 + this.PersonalMessage.GetHashCode();
                hashCode = hashCode * 59 + this.EnabledSendEmailInService.GetHashCode();
                if (this.WelcomeEmailTemplateId != null)
                    hashCode = hashCode * 59 + this.WelcomeEmailTemplateId.GetHashCode();
                hashCode = hashCode * 59 + this.IsWelcomeEmailTemplate.GetHashCode();
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
