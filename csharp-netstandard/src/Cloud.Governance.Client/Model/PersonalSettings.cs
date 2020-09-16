

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
    /// PersonalSettings
    /// </summary>
    [DataContract(Name = "PersonalSettings")]
    public partial class PersonalSettings : IEquatable<PersonalSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalSettings" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="userID">userID.</param>
        /// <param name="languageID">languageID.</param>
        /// <param name="timeZoneID">timeZoneID.</param>
        /// <param name="isAdjustDaylight">isAdjustDaylight.</param>
        /// <param name="properties">properties.</param>
        public PersonalSettings(Guid id = default(Guid), int userID = default(int), int languageID = default(int), int timeZoneID = default(int), bool isAdjustDaylight = default(bool), PersonalSettingsPropertyInfo properties = default(PersonalSettingsPropertyInfo))
        {
            this.Id = id;
            this.UserID = userID;
            this.LanguageID = languageID;
            this.TimeZoneID = timeZoneID;
            this.IsAdjustDaylight = isAdjustDaylight;
            this.Properties = properties;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets UserID
        /// </summary>
        [DataMember(Name = "userID", EmitDefaultValue = false)]
        public int UserID { get; set; }

        /// <summary>
        /// Gets or Sets LanguageID
        /// </summary>
        [DataMember(Name = "languageID", EmitDefaultValue = false)]
        public int LanguageID { get; set; }

        /// <summary>
        /// Gets or Sets TimeZoneID
        /// </summary>
        [DataMember(Name = "timeZoneID", EmitDefaultValue = false)]
        public int TimeZoneID { get; set; }

        /// <summary>
        /// Gets or Sets IsAdjustDaylight
        /// </summary>
        [DataMember(Name = "isAdjustDaylight", EmitDefaultValue = false)]
        public bool IsAdjustDaylight { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public PersonalSettingsPropertyInfo Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersonalSettings {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserID: ").Append(UserID).Append("\n");
            sb.Append("  LanguageID: ").Append(LanguageID).Append("\n");
            sb.Append("  TimeZoneID: ").Append(TimeZoneID).Append("\n");
            sb.Append("  IsAdjustDaylight: ").Append(IsAdjustDaylight).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(input as PersonalSettings);
        }

        /// <summary>
        /// Returns true if PersonalSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of PersonalSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PersonalSettings input)
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
                    this.UserID == input.UserID ||
                    this.UserID.Equals(input.UserID)
                ) && 
                (
                    this.LanguageID == input.LanguageID ||
                    this.LanguageID.Equals(input.LanguageID)
                ) && 
                (
                    this.TimeZoneID == input.TimeZoneID ||
                    this.TimeZoneID.Equals(input.TimeZoneID)
                ) && 
                (
                    this.IsAdjustDaylight == input.IsAdjustDaylight ||
                    this.IsAdjustDaylight.Equals(input.IsAdjustDaylight)
                ) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
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
                hashCode = hashCode * 59 + this.UserID.GetHashCode();
                hashCode = hashCode * 59 + this.LanguageID.GetHashCode();
                hashCode = hashCode * 59 + this.TimeZoneID.GetHashCode();
                hashCode = hashCode * 59 + this.IsAdjustDaylight.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
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
