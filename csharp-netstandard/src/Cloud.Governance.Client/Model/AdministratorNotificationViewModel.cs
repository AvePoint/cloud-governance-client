/* 
 * Cloud Governance Api
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Cloud.Governance.Client.Client.OpenAPIDateConverter;

namespace Cloud.Governance.Client.Model
{
    /// <summary>
    /// AdministratorNotificationViewModel
    /// </summary>
    [DataContract]
    public partial class AdministratorNotificationViewModel :  IEquatable<AdministratorNotificationViewModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdministratorNotificationViewModel" /> class.
        /// </summary>
        /// <param name="reminderProfiles">reminderProfiles.</param>
        /// <param name="notificationEmailTemplates">notificationEmailTemplates.</param>
        /// <param name="escalationEmailTemplates">escalationEmailTemplates.</param>
        /// <param name="reassignEmailTemplates">reassignEmailTemplates.</param>
        /// <param name="administratorContact">administratorContact.</param>
        /// <param name="emailSettings">emailSettings.</param>
        /// <param name="escalationSettings">escalationSettings.</param>
        public AdministratorNotificationViewModel(List<GuidModel> reminderProfiles = default(List<GuidModel>), List<GuidModel> notificationEmailTemplates = default(List<GuidModel>), List<GuidModel> escalationEmailTemplates = default(List<GuidModel>), List<GuidModel> reassignEmailTemplates = default(List<GuidModel>), ApiUser administratorContact = default(ApiUser), GuidSettingModel emailSettings = default(GuidSettingModel), AdminNotificationEscalationModel escalationSettings = default(AdminNotificationEscalationModel))
        {
            this.ReminderProfiles = reminderProfiles;
            this.NotificationEmailTemplates = notificationEmailTemplates;
            this.EscalationEmailTemplates = escalationEmailTemplates;
            this.ReassignEmailTemplates = reassignEmailTemplates;
            this.AdministratorContact = administratorContact;
            this.EmailSettings = emailSettings;
            this.EscalationSettings = escalationSettings;
        }
        
        /// <summary>
        /// Gets or Sets ReminderProfiles
        /// </summary>
        [DataMember(Name="reminderProfiles", EmitDefaultValue=true)]
        public List<GuidModel> ReminderProfiles { get; set; }

        /// <summary>
        /// Gets or Sets NotificationEmailTemplates
        /// </summary>
        [DataMember(Name="notificationEmailTemplates", EmitDefaultValue=true)]
        public List<GuidModel> NotificationEmailTemplates { get; set; }

        /// <summary>
        /// Gets or Sets EscalationEmailTemplates
        /// </summary>
        [DataMember(Name="escalationEmailTemplates", EmitDefaultValue=true)]
        public List<GuidModel> EscalationEmailTemplates { get; set; }

        /// <summary>
        /// Gets or Sets ReassignEmailTemplates
        /// </summary>
        [DataMember(Name="reassignEmailTemplates", EmitDefaultValue=true)]
        public List<GuidModel> ReassignEmailTemplates { get; set; }

        /// <summary>
        /// Gets or Sets AdministratorContact
        /// </summary>
        [DataMember(Name="administratorContact", EmitDefaultValue=true)]
        public ApiUser AdministratorContact { get; set; }

        /// <summary>
        /// Gets or Sets EmailSettings
        /// </summary>
        [DataMember(Name="emailSettings", EmitDefaultValue=true)]
        public GuidSettingModel EmailSettings { get; set; }

        /// <summary>
        /// Gets or Sets EscalationSettings
        /// </summary>
        [DataMember(Name="escalationSettings", EmitDefaultValue=true)]
        public AdminNotificationEscalationModel EscalationSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdministratorNotificationViewModel {\n");
            sb.Append("  ReminderProfiles: ").Append(ReminderProfiles).Append("\n");
            sb.Append("  NotificationEmailTemplates: ").Append(NotificationEmailTemplates).Append("\n");
            sb.Append("  EscalationEmailTemplates: ").Append(EscalationEmailTemplates).Append("\n");
            sb.Append("  ReassignEmailTemplates: ").Append(ReassignEmailTemplates).Append("\n");
            sb.Append("  AdministratorContact: ").Append(AdministratorContact).Append("\n");
            sb.Append("  EmailSettings: ").Append(EmailSettings).Append("\n");
            sb.Append("  EscalationSettings: ").Append(EscalationSettings).Append("\n");
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
            return this.Equals(input as AdministratorNotificationViewModel);
        }

        /// <summary>
        /// Returns true if AdministratorNotificationViewModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AdministratorNotificationViewModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdministratorNotificationViewModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReminderProfiles == input.ReminderProfiles ||
                    this.ReminderProfiles != null &&
                    input.ReminderProfiles != null &&
                    this.ReminderProfiles.SequenceEqual(input.ReminderProfiles)
                ) && 
                (
                    this.NotificationEmailTemplates == input.NotificationEmailTemplates ||
                    this.NotificationEmailTemplates != null &&
                    input.NotificationEmailTemplates != null &&
                    this.NotificationEmailTemplates.SequenceEqual(input.NotificationEmailTemplates)
                ) && 
                (
                    this.EscalationEmailTemplates == input.EscalationEmailTemplates ||
                    this.EscalationEmailTemplates != null &&
                    input.EscalationEmailTemplates != null &&
                    this.EscalationEmailTemplates.SequenceEqual(input.EscalationEmailTemplates)
                ) && 
                (
                    this.ReassignEmailTemplates == input.ReassignEmailTemplates ||
                    this.ReassignEmailTemplates != null &&
                    input.ReassignEmailTemplates != null &&
                    this.ReassignEmailTemplates.SequenceEqual(input.ReassignEmailTemplates)
                ) && 
                (
                    this.AdministratorContact == input.AdministratorContact ||
                    (this.AdministratorContact != null &&
                    this.AdministratorContact.Equals(input.AdministratorContact))
                ) && 
                (
                    this.EmailSettings == input.EmailSettings ||
                    (this.EmailSettings != null &&
                    this.EmailSettings.Equals(input.EmailSettings))
                ) && 
                (
                    this.EscalationSettings == input.EscalationSettings ||
                    (this.EscalationSettings != null &&
                    this.EscalationSettings.Equals(input.EscalationSettings))
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
                if (this.ReminderProfiles != null)
                    hashCode = hashCode * 59 + this.ReminderProfiles.GetHashCode();
                if (this.NotificationEmailTemplates != null)
                    hashCode = hashCode * 59 + this.NotificationEmailTemplates.GetHashCode();
                if (this.EscalationEmailTemplates != null)
                    hashCode = hashCode * 59 + this.EscalationEmailTemplates.GetHashCode();
                if (this.ReassignEmailTemplates != null)
                    hashCode = hashCode * 59 + this.ReassignEmailTemplates.GetHashCode();
                if (this.AdministratorContact != null)
                    hashCode = hashCode * 59 + this.AdministratorContact.GetHashCode();
                if (this.EmailSettings != null)
                    hashCode = hashCode * 59 + this.EmailSettings.GetHashCode();
                if (this.EscalationSettings != null)
                    hashCode = hashCode * 59 + this.EscalationSettings.GetHashCode();
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
