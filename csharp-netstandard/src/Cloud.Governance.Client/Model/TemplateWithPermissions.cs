

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
    /// TemplateWithPermissions
    /// </summary>
    [DataContract(Name = "TemplateWithPermissions")]
    public partial class TemplateWithPermissions : IEquatable<TemplateWithPermissions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateWithPermissions" /> class.
        /// </summary>
        /// <param name="templateId">templateId.</param>
        /// <param name="isUseCommon">isUseCommon (default to false).</param>
        /// <param name="userPermissions">userPermissions.</param>
        /// <param name="groupPermissions">groupPermissions.</param>
        public TemplateWithPermissions(string templateId = default(string), bool isUseCommon = false, List<ServiceUserWithPermissions> userPermissions = default(List<ServiceUserWithPermissions>), List<ServiceGroupWithPermissions> groupPermissions = default(List<ServiceGroupWithPermissions>))
        {
            this.TemplateId = templateId;
            this.IsUseCommon = isUseCommon;
            this.UserPermissions = userPermissions;
            this.GroupPermissions = groupPermissions;
        }

        /// <summary>
        /// Gets or Sets TemplateId
        /// </summary>
        [DataMember(Name = "templateId", EmitDefaultValue = true)]
        public string TemplateId { get; set; }

        /// <summary>
        /// Gets or Sets IsUseCommon
        /// </summary>
        [DataMember(Name = "isUseCommon", EmitDefaultValue = false)]
        public bool IsUseCommon { get; set; }

        /// <summary>
        /// Gets or Sets UserPermissions
        /// </summary>
        [DataMember(Name = "userPermissions", EmitDefaultValue = true)]
        public List<ServiceUserWithPermissions> UserPermissions { get; set; }

        /// <summary>
        /// Gets or Sets GroupPermissions
        /// </summary>
        [DataMember(Name = "groupPermissions", EmitDefaultValue = true)]
        public List<ServiceGroupWithPermissions> GroupPermissions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateWithPermissions {\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  IsUseCommon: ").Append(IsUseCommon).Append("\n");
            sb.Append("  UserPermissions: ").Append(UserPermissions).Append("\n");
            sb.Append("  GroupPermissions: ").Append(GroupPermissions).Append("\n");
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
            return this.Equals(input as TemplateWithPermissions);
        }

        /// <summary>
        /// Returns true if TemplateWithPermissions instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateWithPermissions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateWithPermissions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.IsUseCommon == input.IsUseCommon ||
                    this.IsUseCommon.Equals(input.IsUseCommon)
                ) && 
                (
                    this.UserPermissions == input.UserPermissions ||
                    this.UserPermissions != null &&
                    input.UserPermissions != null &&
                    this.UserPermissions.SequenceEqual(input.UserPermissions)
                ) && 
                (
                    this.GroupPermissions == input.GroupPermissions ||
                    this.GroupPermissions != null &&
                    input.GroupPermissions != null &&
                    this.GroupPermissions.SequenceEqual(input.GroupPermissions)
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
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                hashCode = hashCode * 59 + this.IsUseCommon.GetHashCode();
                if (this.UserPermissions != null)
                    hashCode = hashCode * 59 + this.UserPermissions.GetHashCode();
                if (this.GroupPermissions != null)
                    hashCode = hashCode * 59 + this.GroupPermissions.GetHashCode();
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
