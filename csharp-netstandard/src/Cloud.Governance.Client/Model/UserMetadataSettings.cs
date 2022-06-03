

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
    /// UserMetadataSettings
    /// </summary>
    [DataContract(Name = "UserMetadataSettings")]
    public partial class UserMetadataSettings : IEquatable<UserMetadataSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserMetadataSettings" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        /// <param name="peoplePickerProfile">peoplePickerProfile.</param>
        /// <param name="allowReferenceAsRoleInApprovalProcess">allowReferenceAsRoleInApprovalProcess (default to false).</param>
        public UserMetadataSettings(List<ApiUser> value = default(List<ApiUser>), GuidModel peoplePickerProfile = default(GuidModel), bool allowReferenceAsRoleInApprovalProcess = false)
        {
            this.Value = value;
            this.PeoplePickerProfile = peoplePickerProfile;
            this.AllowReferenceAsRoleInApprovalProcess = allowReferenceAsRoleInApprovalProcess;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public List<ApiUser> Value { get; set; }

        /// <summary>
        /// Gets or Sets PeoplePickerProfile
        /// </summary>
        [DataMember(Name = "peoplePickerProfile", EmitDefaultValue = true)]
        public GuidModel PeoplePickerProfile { get; set; }

        /// <summary>
        /// Gets or Sets AllowReferenceAsRoleInApprovalProcess
        /// </summary>
        [DataMember(Name = "allowReferenceAsRoleInApprovalProcess", EmitDefaultValue = false)]
        public bool AllowReferenceAsRoleInApprovalProcess { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserMetadataSettings {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  PeoplePickerProfile: ").Append(PeoplePickerProfile).Append("\n");
            sb.Append("  AllowReferenceAsRoleInApprovalProcess: ").Append(AllowReferenceAsRoleInApprovalProcess).Append("\n");
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
            return this.Equals(input as UserMetadataSettings);
        }

        /// <summary>
        /// Returns true if UserMetadataSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of UserMetadataSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserMetadataSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    this.Value != null &&
                    input.Value != null &&
                    this.Value.SequenceEqual(input.Value)
                ) && 
                (
                    this.PeoplePickerProfile == input.PeoplePickerProfile ||
                    (this.PeoplePickerProfile != null &&
                    this.PeoplePickerProfile.Equals(input.PeoplePickerProfile))
                ) && 
                (
                    this.AllowReferenceAsRoleInApprovalProcess == input.AllowReferenceAsRoleInApprovalProcess ||
                    this.AllowReferenceAsRoleInApprovalProcess.Equals(input.AllowReferenceAsRoleInApprovalProcess)
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.PeoplePickerProfile != null)
                    hashCode = hashCode * 59 + this.PeoplePickerProfile.GetHashCode();
                hashCode = hashCode * 59 + this.AllowReferenceAsRoleInApprovalProcess.GetHashCode();
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
