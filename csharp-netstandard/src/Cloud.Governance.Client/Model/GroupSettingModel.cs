

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
    /// GroupSettingModel
    /// </summary>
    [DataContract(Name = "GroupSettingModel")]
    public partial class GroupSettingModel : IEquatable<GroupSettingModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupSettingModel" /> class.
        /// </summary>
        /// <param name="groupName">groupName.</param>
        /// <param name="groupDescription">groupDescription.</param>
        /// <param name="groupEmailAddress">groupEmailAddress.</param>
        /// <param name="owners">owners.</param>
        /// <param name="members">members.</param>
        /// <param name="groupDuration">groupDuration.</param>
        /// <param name="emailSubject">emailSubject.</param>
        /// <param name="emailBody">emailBody.</param>
        public GroupSettingModel(string groupName = default(string), string groupDescription = default(string), string groupEmailAddress = default(string), string owners = default(string), string members = default(string), int groupDuration = default(int), string emailSubject = default(string), string emailBody = default(string))
        {
            this.GroupName = groupName;
            this.GroupDescription = groupDescription;
            this.GroupEmailAddress = groupEmailAddress;
            this.Owners = owners;
            this.Members = members;
            this.GroupDuration = groupDuration;
            this.EmailSubject = emailSubject;
            this.EmailBody = emailBody;
        }

        /// <summary>
        /// Gets or Sets GroupName
        /// </summary>
        [DataMember(Name = "groupName", EmitDefaultValue = true)]
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or Sets GroupDescription
        /// </summary>
        [DataMember(Name = "groupDescription", EmitDefaultValue = true)]
        public string GroupDescription { get; set; }

        /// <summary>
        /// Gets or Sets GroupEmailAddress
        /// </summary>
        [DataMember(Name = "groupEmailAddress", EmitDefaultValue = true)]
        public string GroupEmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets Owners
        /// </summary>
        [DataMember(Name = "owners", EmitDefaultValue = true)]
        public string Owners { get; set; }

        /// <summary>
        /// Gets or Sets Members
        /// </summary>
        [DataMember(Name = "members", EmitDefaultValue = true)]
        public string Members { get; set; }

        /// <summary>
        /// Gets or Sets GroupDuration
        /// </summary>
        [DataMember(Name = "groupDuration", EmitDefaultValue = false)]
        public int GroupDuration { get; set; }

        /// <summary>
        /// Gets or Sets EmailSubject
        /// </summary>
        [DataMember(Name = "emailSubject", EmitDefaultValue = true)]
        public string EmailSubject { get; set; }

        /// <summary>
        /// Gets or Sets EmailBody
        /// </summary>
        [DataMember(Name = "emailBody", EmitDefaultValue = true)]
        public string EmailBody { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupSettingModel {\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  GroupDescription: ").Append(GroupDescription).Append("\n");
            sb.Append("  GroupEmailAddress: ").Append(GroupEmailAddress).Append("\n");
            sb.Append("  Owners: ").Append(Owners).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  GroupDuration: ").Append(GroupDuration).Append("\n");
            sb.Append("  EmailSubject: ").Append(EmailSubject).Append("\n");
            sb.Append("  EmailBody: ").Append(EmailBody).Append("\n");
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
            return this.Equals(input as GroupSettingModel);
        }

        /// <summary>
        /// Returns true if GroupSettingModel instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupSettingModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupSettingModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.GroupDescription == input.GroupDescription ||
                    (this.GroupDescription != null &&
                    this.GroupDescription.Equals(input.GroupDescription))
                ) && 
                (
                    this.GroupEmailAddress == input.GroupEmailAddress ||
                    (this.GroupEmailAddress != null &&
                    this.GroupEmailAddress.Equals(input.GroupEmailAddress))
                ) && 
                (
                    this.Owners == input.Owners ||
                    (this.Owners != null &&
                    this.Owners.Equals(input.Owners))
                ) && 
                (
                    this.Members == input.Members ||
                    (this.Members != null &&
                    this.Members.Equals(input.Members))
                ) && 
                (
                    this.GroupDuration == input.GroupDuration ||
                    this.GroupDuration.Equals(input.GroupDuration)
                ) && 
                (
                    this.EmailSubject == input.EmailSubject ||
                    (this.EmailSubject != null &&
                    this.EmailSubject.Equals(input.EmailSubject))
                ) && 
                (
                    this.EmailBody == input.EmailBody ||
                    (this.EmailBody != null &&
                    this.EmailBody.Equals(input.EmailBody))
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
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.GroupDescription != null)
                    hashCode = hashCode * 59 + this.GroupDescription.GetHashCode();
                if (this.GroupEmailAddress != null)
                    hashCode = hashCode * 59 + this.GroupEmailAddress.GetHashCode();
                if (this.Owners != null)
                    hashCode = hashCode * 59 + this.Owners.GetHashCode();
                if (this.Members != null)
                    hashCode = hashCode * 59 + this.Members.GetHashCode();
                hashCode = hashCode * 59 + this.GroupDuration.GetHashCode();
                if (this.EmailSubject != null)
                    hashCode = hashCode * 59 + this.EmailSubject.GetHashCode();
                if (this.EmailBody != null)
                    hashCode = hashCode * 59 + this.EmailBody.GetHashCode();
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
