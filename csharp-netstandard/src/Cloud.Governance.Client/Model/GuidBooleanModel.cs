

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
    /// GuidBooleanModel
    /// </summary>
    [DataContract(Name = "GuidBooleanModel")]
    public partial class GuidBooleanModel : IEquatable<GuidBooleanModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GuidBooleanModel" /> class.
        /// </summary>
        /// <param name="enabled">enabled.</param>
        /// <param name="seletedItem">seletedItem.</param>
        /// <param name="allItems">allItems.</param>
        public GuidBooleanModel(bool enabled = default(bool), Guid seletedItem = default(Guid), List<Guid> allItems = default(List<Guid>))
        {
            this.Enabled = enabled;
            this.SeletedItem = seletedItem;
            this.AllItems = allItems;
        }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets SeletedItem
        /// </summary>
        [DataMember(Name = "seletedItem", EmitDefaultValue = false)]
        public Guid SeletedItem { get; set; }

        /// <summary>
        /// Gets or Sets AllItems
        /// </summary>
        [DataMember(Name = "allItems", EmitDefaultValue = true)]
        public List<Guid> AllItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GuidBooleanModel {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  SeletedItem: ").Append(SeletedItem).Append("\n");
            sb.Append("  AllItems: ").Append(AllItems).Append("\n");
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
            return this.Equals(input as GuidBooleanModel);
        }

        /// <summary>
        /// Returns true if GuidBooleanModel instances are equal
        /// </summary>
        /// <param name="input">Instance of GuidBooleanModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GuidBooleanModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.SeletedItem == input.SeletedItem ||
                    (this.SeletedItem != null &&
                    this.SeletedItem.Equals(input.SeletedItem))
                ) && 
                (
                    this.AllItems == input.AllItems ||
                    this.AllItems != null &&
                    input.AllItems != null &&
                    this.AllItems.SequenceEqual(input.AllItems)
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
                if (this.SeletedItem != null)
                    hashCode = hashCode * 59 + this.SeletedItem.GetHashCode();
                if (this.AllItems != null)
                    hashCode = hashCode * 59 + this.AllItems.GetHashCode();
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
