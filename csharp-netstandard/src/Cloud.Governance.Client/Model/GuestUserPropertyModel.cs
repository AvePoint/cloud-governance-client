

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
    /// GuestUserPropertyModel
    /// </summary>
    [DataContract(Name = "GuestUserPropertyModel")]
    public partial class GuestUserPropertyModel : IEquatable<GuestUserPropertyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GuestUserPropertyModel" /> class.
        /// </summary>
        /// <param name="displayName">displayName.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="userName">userName.</param>
        /// <param name="usageLocation">usageLocation.</param>
        /// <param name="jobTitle">jobTitle.</param>
        /// <param name="jobDepartment">jobDepartment.</param>
        public GuestUserPropertyModel(string displayName = default(string), string firstName = default(string), string lastName = default(string), string userName = default(string), string usageLocation = default(string), string jobTitle = default(string), string jobDepartment = default(string))
        {
            this.DisplayName = displayName;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserName = userName;
            this.UsageLocation = usageLocation;
            this.JobTitle = jobTitle;
            this.JobDepartment = jobDepartment;
        }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "firstName", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "lastName", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name = "userName", EmitDefaultValue = true)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets UsageLocation
        /// </summary>
        [DataMember(Name = "usageLocation", EmitDefaultValue = true)]
        public string UsageLocation { get; set; }

        /// <summary>
        /// Gets or Sets JobTitle
        /// </summary>
        [DataMember(Name = "jobTitle", EmitDefaultValue = true)]
        public string JobTitle { get; set; }

        /// <summary>
        /// Gets or Sets JobDepartment
        /// </summary>
        [DataMember(Name = "jobDepartment", EmitDefaultValue = true)]
        public string JobDepartment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GuestUserPropertyModel {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  UsageLocation: ").Append(UsageLocation).Append("\n");
            sb.Append("  JobTitle: ").Append(JobTitle).Append("\n");
            sb.Append("  JobDepartment: ").Append(JobDepartment).Append("\n");
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
            return this.Equals(input as GuestUserPropertyModel);
        }

        /// <summary>
        /// Returns true if GuestUserPropertyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of GuestUserPropertyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GuestUserPropertyModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.UsageLocation == input.UsageLocation ||
                    (this.UsageLocation != null &&
                    this.UsageLocation.Equals(input.UsageLocation))
                ) && 
                (
                    this.JobTitle == input.JobTitle ||
                    (this.JobTitle != null &&
                    this.JobTitle.Equals(input.JobTitle))
                ) && 
                (
                    this.JobDepartment == input.JobDepartment ||
                    (this.JobDepartment != null &&
                    this.JobDepartment.Equals(input.JobDepartment))
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
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.UsageLocation != null)
                    hashCode = hashCode * 59 + this.UsageLocation.GetHashCode();
                if (this.JobTitle != null)
                    hashCode = hashCode * 59 + this.JobTitle.GetHashCode();
                if (this.JobDepartment != null)
                    hashCode = hashCode * 59 + this.JobDepartment.GetHashCode();
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
