

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
    /// SPPrincipal
    /// </summary>
    [DataContract(Name = "SPPrincipal")]
    public partial class SPPrincipal : IEquatable<SPPrincipal>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets PrincipalType
        /// </summary>
        [DataMember(Name = "principalType", EmitDefaultValue = false)]
        public SPPrincipalType? PrincipalType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SPPrincipal" /> class.
        /// </summary>
        /// <param name="id">id (default to 0).</param>
        /// <param name="loginName">loginName.</param>
        /// <param name="name">name.</param>
        /// <param name="principalType">principalType.</param>
        /// <param name="azureUserType">azureUserType.</param>
        public SPPrincipal(int id = 0, string loginName = default(string), string name = default(string), SPPrincipalType? principalType = default(SPPrincipalType?), string azureUserType = default(string))
        {
            this.Id = id;
            this.LoginName = loginName;
            this.Name = name;
            this.PrincipalType = principalType;
            this.AzureUserType = azureUserType;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets LoginName
        /// </summary>
        [DataMember(Name = "loginName", EmitDefaultValue = true)]
        public string LoginName { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AzureUserType
        /// </summary>
        [DataMember(Name = "azureUserType", EmitDefaultValue = true)]
        public string AzureUserType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SPPrincipal {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LoginName: ").Append(LoginName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PrincipalType: ").Append(PrincipalType).Append("\n");
            sb.Append("  AzureUserType: ").Append(AzureUserType).Append("\n");
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
            return this.Equals(input as SPPrincipal);
        }

        /// <summary>
        /// Returns true if SPPrincipal instances are equal
        /// </summary>
        /// <param name="input">Instance of SPPrincipal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SPPrincipal input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.LoginName == input.LoginName ||
                    (this.LoginName != null &&
                    this.LoginName.Equals(input.LoginName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PrincipalType == input.PrincipalType ||
                    this.PrincipalType.Equals(input.PrincipalType)
                ) && 
                (
                    this.AzureUserType == input.AzureUserType ||
                    (this.AzureUserType != null &&
                    this.AzureUserType.Equals(input.AzureUserType))
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
                if (this.LoginName != null)
                    hashCode = hashCode * 59 + this.LoginName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.PrincipalType.GetHashCode();
                if (this.AzureUserType != null)
                    hashCode = hashCode * 59 + this.AzureUserType.GetHashCode();
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
