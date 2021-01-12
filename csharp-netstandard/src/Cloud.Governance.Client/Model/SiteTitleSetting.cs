

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
    /// SiteTitleSetting
    /// </summary>
    [DataContract(Name = "SiteTitleSetting")]
    public partial class SiteTitleSetting : IEquatable<SiteTitleSetting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SiteTitleSetting" /> class.
        /// </summary>
        /// <param name="titleAssignBy">titleAssignBy.</param>
        /// <param name="enableTitleConstructure">enableTitleConstructure.</param>
        /// <param name="titlePrefixes">titlePrefixes.</param>
        /// <param name="titleSuffixes">titleSuffixes.</param>
        public SiteTitleSetting(int titleAssignBy = default(int), bool enableTitleConstructure = default(bool), List<SiteTitleConstructureRule> titlePrefixes = default(List<SiteTitleConstructureRule>), List<SiteTitleConstructureRule> titleSuffixes = default(List<SiteTitleConstructureRule>))
        {
            this.TitleAssignBy = titleAssignBy;
            this.EnableTitleConstructure = enableTitleConstructure;
            this.TitlePrefixes = titlePrefixes;
            this.TitleSuffixes = titleSuffixes;
        }

        /// <summary>
        /// Gets or Sets TitleAssignBy
        /// </summary>
        [DataMember(Name = "titleAssignBy", EmitDefaultValue = false)]
        public int TitleAssignBy { get; set; }

        /// <summary>
        /// Gets or Sets EnableTitleConstructure
        /// </summary>
        [DataMember(Name = "enableTitleConstructure", EmitDefaultValue = false)]
        public bool EnableTitleConstructure { get; set; }

        /// <summary>
        /// Gets or Sets TitlePrefixes
        /// </summary>
        [DataMember(Name = "titlePrefixes", EmitDefaultValue = true)]
        public List<SiteTitleConstructureRule> TitlePrefixes { get; set; }

        /// <summary>
        /// Gets or Sets TitleSuffixes
        /// </summary>
        [DataMember(Name = "titleSuffixes", EmitDefaultValue = true)]
        public List<SiteTitleConstructureRule> TitleSuffixes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SiteTitleSetting {\n");
            sb.Append("  TitleAssignBy: ").Append(TitleAssignBy).Append("\n");
            sb.Append("  EnableTitleConstructure: ").Append(EnableTitleConstructure).Append("\n");
            sb.Append("  TitlePrefixes: ").Append(TitlePrefixes).Append("\n");
            sb.Append("  TitleSuffixes: ").Append(TitleSuffixes).Append("\n");
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
            return this.Equals(input as SiteTitleSetting);
        }

        /// <summary>
        /// Returns true if SiteTitleSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of SiteTitleSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SiteTitleSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TitleAssignBy == input.TitleAssignBy ||
                    this.TitleAssignBy.Equals(input.TitleAssignBy)
                ) && 
                (
                    this.EnableTitleConstructure == input.EnableTitleConstructure ||
                    this.EnableTitleConstructure.Equals(input.EnableTitleConstructure)
                ) && 
                (
                    this.TitlePrefixes == input.TitlePrefixes ||
                    this.TitlePrefixes != null &&
                    input.TitlePrefixes != null &&
                    this.TitlePrefixes.SequenceEqual(input.TitlePrefixes)
                ) && 
                (
                    this.TitleSuffixes == input.TitleSuffixes ||
                    this.TitleSuffixes != null &&
                    input.TitleSuffixes != null &&
                    this.TitleSuffixes.SequenceEqual(input.TitleSuffixes)
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
                hashCode = hashCode * 59 + this.TitleAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.EnableTitleConstructure.GetHashCode();
                if (this.TitlePrefixes != null)
                    hashCode = hashCode * 59 + this.TitlePrefixes.GetHashCode();
                if (this.TitleSuffixes != null)
                    hashCode = hashCode * 59 + this.TitleSuffixes.GetHashCode();
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
