

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
    /// ConflictResolutionSetting
    /// </summary>
    [DataContract(Name = "ConflictResolutionSetting")]
    public partial class ConflictResolutionSetting : IEquatable<ConflictResolutionSetting>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ContainerConflictSolution
        /// </summary>
        [DataMember(Name = "containerConflictSolution", EmitDefaultValue = false)]
        public ConflictSolutionType? ContainerConflictSolution { get; set; }
        /// <summary>
        /// Gets or Sets ContentConflictSolution
        /// </summary>
        [DataMember(Name = "contentConflictSolution", EmitDefaultValue = false)]
        public ConflictSolutionType? ContentConflictSolution { get; set; }
        /// <summary>
        /// Gets or Sets AppConflictSolution
        /// </summary>
        [DataMember(Name = "appConflictSolution", EmitDefaultValue = false)]
        public ConflictSolutionType? AppConflictSolution { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConflictResolutionSetting" /> class.
        /// </summary>
        /// <param name="containerConflictSolution">containerConflictSolution.</param>
        /// <param name="isCheckLowerObject">isCheckLowerObject.</param>
        /// <param name="isEnableContentConflictResolution">isEnableContentConflictResolution.</param>
        /// <param name="contentConflictSolution">contentConflictSolution.</param>
        /// <param name="appConflictSolution">appConflictSolution.</param>
        public ConflictResolutionSetting(ConflictSolutionType? containerConflictSolution = default(ConflictSolutionType?), bool isCheckLowerObject = default(bool), bool isEnableContentConflictResolution = default(bool), ConflictSolutionType? contentConflictSolution = default(ConflictSolutionType?), ConflictSolutionType? appConflictSolution = default(ConflictSolutionType?))
        {
            this.ContainerConflictSolution = containerConflictSolution;
            this.IsCheckLowerObject = isCheckLowerObject;
            this.IsEnableContentConflictResolution = isEnableContentConflictResolution;
            this.ContentConflictSolution = contentConflictSolution;
            this.AppConflictSolution = appConflictSolution;
        }

        /// <summary>
        /// Gets or Sets IsCheckLowerObject
        /// </summary>
        [DataMember(Name = "isCheckLowerObject", EmitDefaultValue = false)]
        public bool IsCheckLowerObject { get; set; }

        /// <summary>
        /// Gets or Sets IsEnableContentConflictResolution
        /// </summary>
        [DataMember(Name = "isEnableContentConflictResolution", EmitDefaultValue = false)]
        public bool IsEnableContentConflictResolution { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConflictResolutionSetting {\n");
            sb.Append("  ContainerConflictSolution: ").Append(ContainerConflictSolution).Append("\n");
            sb.Append("  IsCheckLowerObject: ").Append(IsCheckLowerObject).Append("\n");
            sb.Append("  IsEnableContentConflictResolution: ").Append(IsEnableContentConflictResolution).Append("\n");
            sb.Append("  ContentConflictSolution: ").Append(ContentConflictSolution).Append("\n");
            sb.Append("  AppConflictSolution: ").Append(AppConflictSolution).Append("\n");
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
            return this.Equals(input as ConflictResolutionSetting);
        }

        /// <summary>
        /// Returns true if ConflictResolutionSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of ConflictResolutionSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConflictResolutionSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContainerConflictSolution == input.ContainerConflictSolution ||
                    this.ContainerConflictSolution.Equals(input.ContainerConflictSolution)
                ) && 
                (
                    this.IsCheckLowerObject == input.IsCheckLowerObject ||
                    this.IsCheckLowerObject.Equals(input.IsCheckLowerObject)
                ) && 
                (
                    this.IsEnableContentConflictResolution == input.IsEnableContentConflictResolution ||
                    this.IsEnableContentConflictResolution.Equals(input.IsEnableContentConflictResolution)
                ) && 
                (
                    this.ContentConflictSolution == input.ContentConflictSolution ||
                    this.ContentConflictSolution.Equals(input.ContentConflictSolution)
                ) && 
                (
                    this.AppConflictSolution == input.AppConflictSolution ||
                    this.AppConflictSolution.Equals(input.AppConflictSolution)
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
                hashCode = hashCode * 59 + this.ContainerConflictSolution.GetHashCode();
                hashCode = hashCode * 59 + this.IsCheckLowerObject.GetHashCode();
                hashCode = hashCode * 59 + this.IsEnableContentConflictResolution.GetHashCode();
                hashCode = hashCode * 59 + this.ContentConflictSolution.GetHashCode();
                hashCode = hashCode * 59 + this.AppConflictSolution.GetHashCode();
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
