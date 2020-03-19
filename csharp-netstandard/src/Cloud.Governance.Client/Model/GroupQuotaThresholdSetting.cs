/* 
 * Cloud Governance Api
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Cloud.Governance.Client.Client.OpenAPIDateConverter;

namespace Cloud.Governance.Client.Model
{
    /// <summary>
    /// GroupQuotaThresholdSetting
    /// </summary>
    [DataContract]
    public partial class GroupQuotaThresholdSetting :  IEquatable<GroupQuotaThresholdSetting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupQuotaThresholdSetting" /> class.
        /// </summary>
        /// <param name="enabled">enabled.</param>
        /// <param name="percentage">percentage.</param>
        /// <param name="notifiedUsers">notifiedUsers.</param>
        public GroupQuotaThresholdSetting(bool enabled = default(bool), int percentage = default(int), List<ApiUser> notifiedUsers = default(List<ApiUser>))
        {
            this.Enabled = enabled;
            this.Percentage = percentage;
            this.NotifiedUsers = notifiedUsers;
        }
        
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Percentage
        /// </summary>
        [DataMember(Name="percentage", EmitDefaultValue=false)]
        public int Percentage { get; set; }

        /// <summary>
        /// Gets or Sets NotifiedUsers
        /// </summary>
        [DataMember(Name="notifiedUsers", EmitDefaultValue=true)]
        public List<ApiUser> NotifiedUsers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupQuotaThresholdSetting {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  NotifiedUsers: ").Append(NotifiedUsers).Append("\n");
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
            return this.Equals(input as GroupQuotaThresholdSetting);
        }

        /// <summary>
        /// Returns true if GroupQuotaThresholdSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupQuotaThresholdSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupQuotaThresholdSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Percentage == input.Percentage ||
                    this.Percentage.Equals(input.Percentage)
                ) && 
                (
                    this.NotifiedUsers == input.NotifiedUsers ||
                    this.NotifiedUsers != null &&
                    input.NotifiedUsers != null &&
                    this.NotifiedUsers.SequenceEqual(input.NotifiedUsers)
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
                hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                hashCode = hashCode * 59 + this.Percentage.GetHashCode();
                if (this.NotifiedUsers != null)
                    hashCode = hashCode * 59 + this.NotifiedUsers.GetHashCode();
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
