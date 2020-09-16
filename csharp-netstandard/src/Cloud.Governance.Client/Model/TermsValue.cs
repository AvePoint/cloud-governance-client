

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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Cloud.Governance.Client.Client.OpenAPIDateConverter;

namespace Cloud.Governance.Client.Model
{
    /// <summary>
    /// TermsValue
    /// </summary>
    [DataContract(Name = "TermsValue")]
    public partial class TermsValue : IEquatable<TermsValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TermsValue" /> class.
        /// </summary>
        /// <param name="termStore">termStore.</param>
        /// <param name="termGroup">termGroup.</param>
        /// <param name="termSet">termSet.</param>
        /// <param name="value">value.</param>
        public TermsValue(GuidModel termStore = default(GuidModel), GuidModel termGroup = default(GuidModel), GuidModel termSet = default(GuidModel), List<GuidModel> value = default(List<GuidModel>))
        {
            this.TermStore = termStore;
            this.TermGroup = termGroup;
            this.TermSet = termSet;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets TermStore
        /// </summary>
        [DataMember(Name = "termStore", EmitDefaultValue = false)]
        public GuidModel TermStore { get; set; }

        /// <summary>
        /// Gets or Sets TermGroup
        /// </summary>
        [DataMember(Name = "termGroup", EmitDefaultValue = false)]
        public GuidModel TermGroup { get; set; }

        /// <summary>
        /// Gets or Sets TermSet
        /// </summary>
        [DataMember(Name = "termSet", EmitDefaultValue = false)]
        public GuidModel TermSet { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public List<GuidModel> Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TermsValue {\n");
            sb.Append("  TermStore: ").Append(TermStore).Append("\n");
            sb.Append("  TermGroup: ").Append(TermGroup).Append("\n");
            sb.Append("  TermSet: ").Append(TermSet).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as TermsValue);
        }

        /// <summary>
        /// Returns true if TermsValue instances are equal
        /// </summary>
        /// <param name="input">Instance of TermsValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TermsValue input)
        {
            if (input == null)
                return false;

            return 
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
                    this.Value == input.Value ||
                    this.Value != null &&
                    input.Value != null &&
                    this.Value.SequenceEqual(input.Value)
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
                if (this.TermStore != null)
                    hashCode = hashCode * 59 + this.TermStore.GetHashCode();
                if (this.TermGroup != null)
                    hashCode = hashCode * 59 + this.TermGroup.GetHashCode();
                if (this.TermSet != null)
                    hashCode = hashCode * 59 + this.TermSet.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
