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
    /// ApprovalProcessStageCollection
    /// </summary>
    [DataContract]
    public partial class ApprovalProcessStageCollection :  IEquatable<ApprovalProcessStageCollection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApprovalProcessStageCollection" /> class.
        /// </summary>
        /// <param name="uniqueId">uniqueId.</param>
        /// <param name="stageCount">stageCount.</param>
        /// <param name="stageOne">stageOne.</param>
        /// <param name="stageTwo">stageTwo.</param>
        /// <param name="stageThree">stageThree.</param>
        public ApprovalProcessStageCollection(string uniqueId = default(string), int stageCount = default(int), ApprovalProcessStageInfo stageOne = default(ApprovalProcessStageInfo), ApprovalProcessStageInfo stageTwo = default(ApprovalProcessStageInfo), ApprovalProcessStageInfo stageThree = default(ApprovalProcessStageInfo))
        {
            this.UniqueId = uniqueId;
            this.StageCount = stageCount;
            this.StageOne = stageOne;
            this.StageTwo = stageTwo;
            this.StageThree = stageThree;
        }
        
        /// <summary>
        /// Gets or Sets UniqueId
        /// </summary>
        [DataMember(Name="uniqueId", EmitDefaultValue=true)]
        public string UniqueId { get; set; }

        /// <summary>
        /// Gets or Sets StageCount
        /// </summary>
        [DataMember(Name="stageCount", EmitDefaultValue=false)]
        public int StageCount { get; set; }

        /// <summary>
        /// Gets or Sets StageOne
        /// </summary>
        [DataMember(Name="stageOne", EmitDefaultValue=true)]
        public ApprovalProcessStageInfo StageOne { get; set; }

        /// <summary>
        /// Gets or Sets StageTwo
        /// </summary>
        [DataMember(Name="stageTwo", EmitDefaultValue=true)]
        public ApprovalProcessStageInfo StageTwo { get; set; }

        /// <summary>
        /// Gets or Sets StageThree
        /// </summary>
        [DataMember(Name="stageThree", EmitDefaultValue=true)]
        public ApprovalProcessStageInfo StageThree { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApprovalProcessStageCollection {\n");
            sb.Append("  UniqueId: ").Append(UniqueId).Append("\n");
            sb.Append("  StageCount: ").Append(StageCount).Append("\n");
            sb.Append("  StageOne: ").Append(StageOne).Append("\n");
            sb.Append("  StageTwo: ").Append(StageTwo).Append("\n");
            sb.Append("  StageThree: ").Append(StageThree).Append("\n");
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
            return this.Equals(input as ApprovalProcessStageCollection);
        }

        /// <summary>
        /// Returns true if ApprovalProcessStageCollection instances are equal
        /// </summary>
        /// <param name="input">Instance of ApprovalProcessStageCollection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApprovalProcessStageCollection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UniqueId == input.UniqueId ||
                    (this.UniqueId != null &&
                    this.UniqueId.Equals(input.UniqueId))
                ) && 
                (
                    this.StageCount == input.StageCount ||
                    this.StageCount.Equals(input.StageCount)
                ) && 
                (
                    this.StageOne == input.StageOne ||
                    (this.StageOne != null &&
                    this.StageOne.Equals(input.StageOne))
                ) && 
                (
                    this.StageTwo == input.StageTwo ||
                    (this.StageTwo != null &&
                    this.StageTwo.Equals(input.StageTwo))
                ) && 
                (
                    this.StageThree == input.StageThree ||
                    (this.StageThree != null &&
                    this.StageThree.Equals(input.StageThree))
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
                if (this.UniqueId != null)
                    hashCode = hashCode * 59 + this.UniqueId.GetHashCode();
                hashCode = hashCode * 59 + this.StageCount.GetHashCode();
                if (this.StageOne != null)
                    hashCode = hashCode * 59 + this.StageOne.GetHashCode();
                if (this.StageTwo != null)
                    hashCode = hashCode * 59 + this.StageTwo.GetHashCode();
                if (this.StageThree != null)
                    hashCode = hashCode * 59 + this.StageThree.GetHashCode();
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
