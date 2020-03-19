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
    /// TermsMetadataSettings
    /// </summary>
    [DataContract]
    public partial class TermsMetadataSettings :  IEquatable<TermsMetadataSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TermsMetadataSettings" /> class.
        /// </summary>
        /// <param name="allowMultiple">allowMultiple.</param>
        /// <param name="adminCenter">adminCenter.</param>
        /// <param name="value">value.</param>
        /// <param name="termStore">termStore.</param>
        /// <param name="termGroup">termGroup.</param>
        /// <param name="termSet">termSet.</param>
        /// <param name="scope">scope.</param>
        public TermsMetadataSettings(bool allowMultiple = default(bool), string adminCenter = default(string), List<GuidModel> value = default(List<GuidModel>), GuidModel termStore = default(GuidModel), GuidModel termGroup = default(GuidModel), GuidModel termSet = default(GuidModel), GuidModel scope = default(GuidModel))
        {
            this.AllowMultiple = allowMultiple;
            this.AdminCenter = adminCenter;
            this.Value = value;
            this.TermStore = termStore;
            this.TermGroup = termGroup;
            this.TermSet = termSet;
            this.Scope = scope;
        }
        
        /// <summary>
        /// Gets or Sets AllowMultiple
        /// </summary>
        [DataMember(Name="allowMultiple", EmitDefaultValue=false)]
        public bool AllowMultiple { get; set; }

        /// <summary>
        /// Gets or Sets AdminCenter
        /// </summary>
        [DataMember(Name="adminCenter", EmitDefaultValue=true)]
        public string AdminCenter { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=true)]
        public List<GuidModel> Value { get; set; }

        /// <summary>
        /// Gets or Sets TermStore
        /// </summary>
        [DataMember(Name="termStore", EmitDefaultValue=true)]
        public GuidModel TermStore { get; set; }

        /// <summary>
        /// Gets or Sets TermGroup
        /// </summary>
        [DataMember(Name="termGroup", EmitDefaultValue=true)]
        public GuidModel TermGroup { get; set; }

        /// <summary>
        /// Gets or Sets TermSet
        /// </summary>
        [DataMember(Name="termSet", EmitDefaultValue=true)]
        public GuidModel TermSet { get; set; }

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name="scope", EmitDefaultValue=true)]
        public GuidModel Scope { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TermsMetadataSettings {\n");
            sb.Append("  AllowMultiple: ").Append(AllowMultiple).Append("\n");
            sb.Append("  AdminCenter: ").Append(AdminCenter).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  TermStore: ").Append(TermStore).Append("\n");
            sb.Append("  TermGroup: ").Append(TermGroup).Append("\n");
            sb.Append("  TermSet: ").Append(TermSet).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
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
            return this.Equals(input as TermsMetadataSettings);
        }

        /// <summary>
        /// Returns true if TermsMetadataSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of TermsMetadataSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TermsMetadataSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowMultiple == input.AllowMultiple ||
                    this.AllowMultiple.Equals(input.AllowMultiple)
                ) && 
                (
                    this.AdminCenter == input.AdminCenter ||
                    (this.AdminCenter != null &&
                    this.AdminCenter.Equals(input.AdminCenter))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value != null &&
                    input.Value != null &&
                    this.Value.SequenceEqual(input.Value)
                ) && 
                (
                    this.TermStore == input.TermStore ||
                    (this.TermStore != null &&
                    this.TermStore.Equals(input.TermStore))
                ) && 
                (
                    this.TermGroup == input.TermGroup ||
                    (this.TermGroup != null &&
                    this.TermGroup.Equals(input.TermGroup))
                ) && 
                (
                    this.TermSet == input.TermSet ||
                    (this.TermSet != null &&
                    this.TermSet.Equals(input.TermSet))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
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
                hashCode = hashCode * 59 + this.AllowMultiple.GetHashCode();
                if (this.AdminCenter != null)
                    hashCode = hashCode * 59 + this.AdminCenter.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.TermStore != null)
                    hashCode = hashCode * 59 + this.TermStore.GetHashCode();
                if (this.TermGroup != null)
                    hashCode = hashCode * 59 + this.TermGroup.GetHashCode();
                if (this.TermSet != null)
                    hashCode = hashCode * 59 + this.TermSet.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
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
