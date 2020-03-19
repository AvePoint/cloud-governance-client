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
    /// CreateListUrlValidationResult
    /// </summary>
    [DataContract]
    public partial class CreateListUrlValidationResult :  IEquatable<CreateListUrlValidationResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateListUrlValidationResult" /> class.
        /// </summary>
        /// <param name="parentObject">parentObject.</param>
        /// <param name="errorMessage">errorMessage.</param>
        public CreateListUrlValidationResult(CreateListSPObject parentObject = default(CreateListSPObject), string errorMessage = default(string))
        {
            this.ParentObject = parentObject;
            this.ErrorMessage = errorMessage;
        }
        
        /// <summary>
        /// Gets or Sets ParentObject
        /// </summary>
        [DataMember(Name="parentObject", EmitDefaultValue=true)]
        public CreateListSPObject ParentObject { get; set; }

        /// <summary>
        /// Gets or Sets IsValid
        /// </summary>
        [DataMember(Name="isValid", EmitDefaultValue=false)]
        public bool IsValid { get; private set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="errorMessage", EmitDefaultValue=true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateListUrlValidationResult {\n");
            sb.Append("  ParentObject: ").Append(ParentObject).Append("\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
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
            return this.Equals(input as CreateListUrlValidationResult);
        }

        /// <summary>
        /// Returns true if CreateListUrlValidationResult instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateListUrlValidationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateListUrlValidationResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ParentObject == input.ParentObject ||
                    (this.ParentObject != null &&
                    this.ParentObject.Equals(input.ParentObject))
                ) && 
                (
                    this.IsValid == input.IsValid ||
                    this.IsValid.Equals(input.IsValid)
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
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
                if (this.ParentObject != null)
                    hashCode = hashCode * 59 + this.ParentObject.GetHashCode();
                hashCode = hashCode * 59 + this.IsValid.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
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
