

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
    /// LookupValue
    /// </summary>
    [DataContract(Name = "LookupValue")]
    public partial class LookupValue : IEquatable<LookupValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LookupValue" /> class.
        /// </summary>
        /// <param name="targetUser">targetUser.</param>
        /// <param name="userPropertyValue">userPropertyValue.</param>
        /// <param name="userPropertyDisplayValue">userPropertyDisplayValue.</param>
        public LookupValue(ApiUser targetUser = default(ApiUser), string userPropertyValue = default(string), string userPropertyDisplayValue = default(string))
        {
            this.TargetUser = targetUser;
            this.UserPropertyValue = userPropertyValue;
            this.UserPropertyDisplayValue = userPropertyDisplayValue;
        }

        /// <summary>
        /// Gets or Sets Tenant
        /// </summary>
        [DataMember(Name = "tenant", EmitDefaultValue = true)]
        public string Tenant { get; private set; }

        /// <summary>
        /// Returns false as Tenant should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTenant()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Property
        /// </summary>
        [DataMember(Name = "property", EmitDefaultValue = true)]
        public string Property { get; private set; }

        /// <summary>
        /// Returns false as Property should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProperty()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets TargetUser
        /// </summary>
        [DataMember(Name = "targetUser", EmitDefaultValue = true)]
        public ApiUser TargetUser { get; set; }

        /// <summary>
        /// Gets or Sets UserPropertyValue
        /// </summary>
        [DataMember(Name = "userPropertyValue", EmitDefaultValue = true)]
        public string UserPropertyValue { get; set; }

        /// <summary>
        /// Gets or Sets UserPropertyDisplayValue
        /// </summary>
        [DataMember(Name = "userPropertyDisplayValue", EmitDefaultValue = true)]
        public string UserPropertyDisplayValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LookupValue {\n");
            sb.Append("  Tenant: ").Append(Tenant).Append("\n");
            sb.Append("  Property: ").Append(Property).Append("\n");
            sb.Append("  TargetUser: ").Append(TargetUser).Append("\n");
            sb.Append("  UserPropertyValue: ").Append(UserPropertyValue).Append("\n");
            sb.Append("  UserPropertyDisplayValue: ").Append(UserPropertyDisplayValue).Append("\n");
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
            return this.Equals(input as LookupValue);
        }

        /// <summary>
        /// Returns true if LookupValue instances are equal
        /// </summary>
        /// <param name="input">Instance of LookupValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LookupValue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tenant == input.Tenant ||
                    (this.Tenant != null &&
                    this.Tenant.Equals(input.Tenant))
                ) && 
                (
                    this.Property == input.Property ||
                    (this.Property != null &&
                    this.Property.Equals(input.Property))
                ) && 
                (
                    this.TargetUser == input.TargetUser ||
                    (this.TargetUser != null &&
                    this.TargetUser.Equals(input.TargetUser))
                ) && 
                (
                    this.UserPropertyValue == input.UserPropertyValue ||
                    (this.UserPropertyValue != null &&
                    this.UserPropertyValue.Equals(input.UserPropertyValue))
                ) && 
                (
                    this.UserPropertyDisplayValue == input.UserPropertyDisplayValue ||
                    (this.UserPropertyDisplayValue != null &&
                    this.UserPropertyDisplayValue.Equals(input.UserPropertyDisplayValue))
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
                if (this.Tenant != null)
                    hashCode = hashCode * 59 + this.Tenant.GetHashCode();
                if (this.Property != null)
                    hashCode = hashCode * 59 + this.Property.GetHashCode();
                if (this.TargetUser != null)
                    hashCode = hashCode * 59 + this.TargetUser.GetHashCode();
                if (this.UserPropertyValue != null)
                    hashCode = hashCode * 59 + this.UserPropertyValue.GetHashCode();
                if (this.UserPropertyDisplayValue != null)
                    hashCode = hashCode * 59 + this.UserPropertyDisplayValue.GetHashCode();
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
