

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
    /// PermissionManagementModel
    /// </summary>
    [DataContract(Name = "PermissionManagementModel")]
    public partial class PermissionManagementModel : IEquatable<PermissionManagementModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionManagementModel" /> class.
        /// </summary>
        /// <param name="isUniquePermission">isUniquePermission (default to false).</param>
        /// <param name="isPermissionInheritanceChanged">isPermissionInheritanceChanged (default to false).</param>
        /// <param name="isCopyPermissionsFromParent">isCopyPermissionsFromParent (default to false).</param>
        /// <param name="inheritedSiteUrl">inheritedSiteUrl.</param>
        /// <param name="permissionItems">permissionItems.</param>
        public PermissionManagementModel(bool isUniquePermission = false, bool isPermissionInheritanceChanged = false, bool isCopyPermissionsFromParent = false, string inheritedSiteUrl = default(string), List<ObjectPermissionManagementModel> permissionItems = default(List<ObjectPermissionManagementModel>))
        {
            this.IsUniquePermission = isUniquePermission;
            this.IsPermissionInheritanceChanged = isPermissionInheritanceChanged;
            this.IsCopyPermissionsFromParent = isCopyPermissionsFromParent;
            this.InheritedSiteUrl = inheritedSiteUrl;
            this.PermissionItems = permissionItems;
        }

        /// <summary>
        /// Gets or Sets IsUniquePermission
        /// </summary>
        [DataMember(Name = "isUniquePermission", EmitDefaultValue = false)]
        public bool IsUniquePermission { get; set; }

        /// <summary>
        /// Gets or Sets IsPermissionInheritanceChanged
        /// </summary>
        [DataMember(Name = "isPermissionInheritanceChanged", EmitDefaultValue = false)]
        public bool IsPermissionInheritanceChanged { get; set; }

        /// <summary>
        /// Gets or Sets IsCopyPermissionsFromParent
        /// </summary>
        [DataMember(Name = "isCopyPermissionsFromParent", EmitDefaultValue = false)]
        public bool IsCopyPermissionsFromParent { get; set; }

        /// <summary>
        /// Gets or Sets InheritedSiteUrl
        /// </summary>
        [DataMember(Name = "inheritedSiteUrl", EmitDefaultValue = true)]
        public string InheritedSiteUrl { get; set; }

        /// <summary>
        /// Gets or Sets PermissionItems
        /// </summary>
        [DataMember(Name = "permissionItems", EmitDefaultValue = true)]
        public List<ObjectPermissionManagementModel> PermissionItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermissionManagementModel {\n");
            sb.Append("  IsUniquePermission: ").Append(IsUniquePermission).Append("\n");
            sb.Append("  IsPermissionInheritanceChanged: ").Append(IsPermissionInheritanceChanged).Append("\n");
            sb.Append("  IsCopyPermissionsFromParent: ").Append(IsCopyPermissionsFromParent).Append("\n");
            sb.Append("  InheritedSiteUrl: ").Append(InheritedSiteUrl).Append("\n");
            sb.Append("  PermissionItems: ").Append(PermissionItems).Append("\n");
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
            return this.Equals(input as PermissionManagementModel);
        }

        /// <summary>
        /// Returns true if PermissionManagementModel instances are equal
        /// </summary>
        /// <param name="input">Instance of PermissionManagementModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PermissionManagementModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsUniquePermission == input.IsUniquePermission ||
                    this.IsUniquePermission.Equals(input.IsUniquePermission)
                ) && 
                (
                    this.IsPermissionInheritanceChanged == input.IsPermissionInheritanceChanged ||
                    this.IsPermissionInheritanceChanged.Equals(input.IsPermissionInheritanceChanged)
                ) && 
                (
                    this.IsCopyPermissionsFromParent == input.IsCopyPermissionsFromParent ||
                    this.IsCopyPermissionsFromParent.Equals(input.IsCopyPermissionsFromParent)
                ) && 
                (
                    this.InheritedSiteUrl == input.InheritedSiteUrl ||
                    (this.InheritedSiteUrl != null &&
                    this.InheritedSiteUrl.Equals(input.InheritedSiteUrl))
                ) && 
                (
                    this.PermissionItems == input.PermissionItems ||
                    this.PermissionItems != null &&
                    input.PermissionItems != null &&
                    this.PermissionItems.SequenceEqual(input.PermissionItems)
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
                hashCode = hashCode * 59 + this.IsUniquePermission.GetHashCode();
                hashCode = hashCode * 59 + this.IsPermissionInheritanceChanged.GetHashCode();
                hashCode = hashCode * 59 + this.IsCopyPermissionsFromParent.GetHashCode();
                if (this.InheritedSiteUrl != null)
                    hashCode = hashCode * 59 + this.InheritedSiteUrl.GetHashCode();
                if (this.PermissionItems != null)
                    hashCode = hashCode * 59 + this.PermissionItems.GetHashCode();
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
