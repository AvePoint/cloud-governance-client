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
    /// AutoImportObjectDemoJob
    /// </summary>
    [DataContract]
    public partial class AutoImportObjectDemoJob :  IEquatable<AutoImportObjectDemoJob>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoImportObjectDemoJob" /> class.
        /// </summary>
        /// <param name="profileName">profileName.</param>
        /// <param name="isEnabled">isEnabled.</param>
        public AutoImportObjectDemoJob(string profileName = default(string), bool isEnabled = default(bool))
        {
            this.ProfileName = profileName;
            this.IsEnabled = isEnabled;
        }
        
        /// <summary>
        /// Gets or Sets ProfileName
        /// </summary>
        [DataMember(Name="profileName", EmitDefaultValue=true)]
        public string ProfileName { get; set; }

        /// <summary>
        /// Gets or Sets IsEnabled
        /// </summary>
        [DataMember(Name="isEnabled", EmitDefaultValue=false)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoImportObjectDemoJob {\n");
            sb.Append("  ProfileName: ").Append(ProfileName).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
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
            return this.Equals(input as AutoImportObjectDemoJob);
        }

        /// <summary>
        /// Returns true if AutoImportObjectDemoJob instances are equal
        /// </summary>
        /// <param name="input">Instance of AutoImportObjectDemoJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutoImportObjectDemoJob input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProfileName == input.ProfileName ||
                    (this.ProfileName != null &&
                    this.ProfileName.Equals(input.ProfileName))
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    this.IsEnabled.Equals(input.IsEnabled)
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
                if (this.ProfileName != null)
                    hashCode = hashCode * 59 + this.ProfileName.GetHashCode();
                hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
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
