

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
    /// GroupMembershipItem
    /// </summary>
    [DataContract(Name = "GroupMembershipItem")]
    public partial class GroupMembershipItem : IEquatable<GroupMembershipItem>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public GroupMembershipAction? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupMembershipItem" /> class.
        /// </summary>
        /// <param name="loginName">loginName.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="azureUserType">azureUserType.</param>
        /// <param name="isGroup">isGroup (default to false).</param>
        /// <param name="action">action.</param>
        public GroupMembershipItem(string loginName = default(string), string displayName = default(string), string azureUserType = default(string), bool isGroup = false, GroupMembershipAction? action = default(GroupMembershipAction?))
        {
            this.LoginName = loginName;
            this.DisplayName = displayName;
            this.AzureUserType = azureUserType;
            this.IsGroup = isGroup;
            this.Action = action;
        }

        /// <summary>
        /// Gets or Sets LoginName
        /// </summary>
        [DataMember(Name = "loginName", EmitDefaultValue = true)]
        public string LoginName { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets AzureUserType
        /// </summary>
        [DataMember(Name = "azureUserType", EmitDefaultValue = true)]
        public string AzureUserType { get; set; }

        /// <summary>
        /// Gets or Sets IsGroup
        /// </summary>
        [DataMember(Name = "isGroup", EmitDefaultValue = false)]
        public bool IsGroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupMembershipItem {\n");
            sb.Append("  LoginName: ").Append(LoginName).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  AzureUserType: ").Append(AzureUserType).Append("\n");
            sb.Append("  IsGroup: ").Append(IsGroup).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
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
            return this.Equals(input as GroupMembershipItem);
        }

        /// <summary>
        /// Returns true if GroupMembershipItem instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupMembershipItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupMembershipItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LoginName == input.LoginName ||
                    (this.LoginName != null &&
                    this.LoginName.Equals(input.LoginName))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.AzureUserType == input.AzureUserType ||
                    (this.AzureUserType != null &&
                    this.AzureUserType.Equals(input.AzureUserType))
                ) && 
                (
                    this.IsGroup == input.IsGroup ||
                    this.IsGroup.Equals(input.IsGroup)
                ) && 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
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
                if (this.LoginName != null)
                    hashCode = hashCode * 59 + this.LoginName.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.AzureUserType != null)
                    hashCode = hashCode * 59 + this.AzureUserType.GetHashCode();
                hashCode = hashCode * 59 + this.IsGroup.GetHashCode();
                hashCode = hashCode * 59 + this.Action.GetHashCode();
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
