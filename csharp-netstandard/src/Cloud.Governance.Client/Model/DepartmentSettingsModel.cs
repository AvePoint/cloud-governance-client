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
    /// DepartmentSettingsModel
    /// </summary>
    [DataContract]
    public partial class DepartmentSettingsModel :  IEquatable<DepartmentSettingsModel>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets DataSource
        /// </summary>
        [DataMember(Name="dataSource", EmitDefaultValue=false)]
        public DepartmentSource? DataSource { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentSettingsModel" /> class.
        /// </summary>
        /// <param name="dataSource">dataSource.</param>
        /// <param name="departments">departments.</param>
        public DepartmentSettingsModel(DepartmentSource dataSource = default(DepartmentSource), List<DepartmentActionModel> departments = default(List<DepartmentActionModel>))
        {
            this.DataSource = dataSource;
            this.Departments = departments;
        }
        
        /// <summary>
        /// Gets or Sets Departments
        /// </summary>
        [DataMember(Name="departments", EmitDefaultValue=true)]
        public List<DepartmentActionModel> Departments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DepartmentSettingsModel {\n");
            sb.Append("  DataSource: ").Append(DataSource).Append("\n");
            sb.Append("  Departments: ").Append(Departments).Append("\n");
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
            return this.Equals(input as DepartmentSettingsModel);
        }

        /// <summary>
        /// Returns true if DepartmentSettingsModel instances are equal
        /// </summary>
        /// <param name="input">Instance of DepartmentSettingsModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DepartmentSettingsModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataSource == input.DataSource ||
                    this.DataSource.Equals(input.DataSource)
                ) && 
                (
                    this.Departments == input.Departments ||
                    this.Departments != null &&
                    input.Departments != null &&
                    this.Departments.SequenceEqual(input.Departments)
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
                hashCode = hashCode * 59 + this.DataSource.GetHashCode();
                if (this.Departments != null)
                    hashCode = hashCode * 59 + this.Departments.GetHashCode();
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
