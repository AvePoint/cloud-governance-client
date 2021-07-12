

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
    /// ServiceUserWithPermissions
    /// </summary>
    [DataContract(Name = "ServiceUserWithPermissions")]
    public partial class ServiceUserWithPermissions : IEquatable<ServiceUserWithPermissions>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets UserAssignBy
        /// </summary>
        [DataMember(Name = "userAssignBy", EmitDefaultValue = false)]
        public AssignBy? UserAssignBy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceUserWithPermissions" /> class.
        /// </summary>
        /// <param name="userAssignBy">userAssignBy.</param>
        /// <param name="user">User information.</param>
        /// <param name="permissionLevels">User permission levels&#39; information.</param>
        public ServiceUserWithPermissions(AssignBy? userAssignBy = default(AssignBy?), ApiUser user = default(ApiUser), List<PermissionLevel> permissionLevels = default(List<PermissionLevel>))
        {
            this.UserAssignBy = userAssignBy;
            this.User = user;
            this.PermissionLevels = permissionLevels;
        }

        /// <summary>
        /// User information
        /// </summary>
        /// <value>User information</value>
        [DataMember(Name = "user", EmitDefaultValue = true)]
        public ApiUser User { get; set; }

        /// <summary>
        /// User permission levels&#39; information
        /// </summary>
        /// <value>User permission levels&#39; information</value>
        [DataMember(Name = "permissionLevels", EmitDefaultValue = true)]
        public List<PermissionLevel> PermissionLevels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceUserWithPermissions {\n");
            sb.Append("  UserAssignBy: ").Append(UserAssignBy).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(input as ServiceUserWithPermissions);
        }

        /// <summary>
        /// Returns true if ServiceUserWithPermissions instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceUserWithPermissions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceUserWithPermissions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserAssignBy == input.UserAssignBy ||
                    this.UserAssignBy.Equals(input.UserAssignBy)
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                hashCode = hashCode * 59 + this.UserAssignBy.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
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
