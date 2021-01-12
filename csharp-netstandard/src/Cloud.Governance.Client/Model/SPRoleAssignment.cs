

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
    /// SPRoleAssignment
    /// </summary>
    [DataContract(Name = "SPRoleAssignment")]
    public partial class SPRoleAssignment : IEquatable<SPRoleAssignment>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets PrincipalType
        /// </summary>
        [DataMember(Name = "principalType", EmitDefaultValue = false)]
        public SPPrincipalType? PrincipalType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SPRoleAssignment" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="loginName">loginName.</param>
        /// <param name="principalType">principalType.</param>
        /// <param name="principalTypeDescription">principalTypeDescription.</param>
        /// <param name="permissionLevels">permissionLevels.</param>
        public SPRoleAssignment(int id = default(int), string name = default(string), string loginName = default(string), SPPrincipalType? principalType = default(SPPrincipalType?), string principalTypeDescription = default(string), List<string> permissionLevels = default(List<string>))
        {
            this.Id = id;
            this.Name = name;
            this.LoginName = loginName;
            this.PrincipalType = principalType;
            this.PrincipalTypeDescription = principalTypeDescription;
            this.PermissionLevels = permissionLevels;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets LoginName
        /// </summary>
        [DataMember(Name = "loginName", EmitDefaultValue = true)]
        public string LoginName { get; set; }

        /// <summary>
        /// Gets or Sets PrincipalTypeDescription
        /// </summary>
        [DataMember(Name = "principalTypeDescription", EmitDefaultValue = true)]
        public string PrincipalTypeDescription { get; set; }

        /// <summary>
        /// Gets or Sets PermissionLevels
        /// </summary>
        [DataMember(Name = "permissionLevels", EmitDefaultValue = true)]
        public List<string> PermissionLevels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SPRoleAssignment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LoginName: ").Append(LoginName).Append("\n");
            sb.Append("  PrincipalType: ").Append(PrincipalType).Append("\n");
            sb.Append("  PrincipalTypeDescription: ").Append(PrincipalTypeDescription).Append("\n");
            sb.Append("  PermissionLevels: ").Append(PermissionLevels).Append("\n");
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
            return this.Equals(input as SPRoleAssignment);
        }

        /// <summary>
        /// Returns true if SPRoleAssignment instances are equal
        /// </summary>
        /// <param name="input">Instance of SPRoleAssignment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SPRoleAssignment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.LoginName == input.LoginName ||
                    (this.LoginName != null &&
                    this.LoginName.Equals(input.LoginName))
                ) && 
                (
                    this.PrincipalType == input.PrincipalType ||
                    this.PrincipalType.Equals(input.PrincipalType)
                ) && 
                (
                    this.PrincipalTypeDescription == input.PrincipalTypeDescription ||
                    (this.PrincipalTypeDescription != null &&
                    this.PrincipalTypeDescription.Equals(input.PrincipalTypeDescription))
                ) && 
                (
                    this.PermissionLevels == input.PermissionLevels ||
                    this.PermissionLevels != null &&
                    input.PermissionLevels != null &&
                    this.PermissionLevels.SequenceEqual(input.PermissionLevels)
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.LoginName != null)
                    hashCode = hashCode * 59 + this.LoginName.GetHashCode();
                hashCode = hashCode * 59 + this.PrincipalType.GetHashCode();
                if (this.PrincipalTypeDescription != null)
                    hashCode = hashCode * 59 + this.PrincipalTypeDescription.GetHashCode();
                if (this.PermissionLevels != null)
                    hashCode = hashCode * 59 + this.PermissionLevels.GetHashCode();
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
