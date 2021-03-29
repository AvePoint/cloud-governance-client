

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
    /// LanguageWithTemplates
    /// </summary>
    [DataContract(Name = "LanguageWithTemplates")]
    public partial class LanguageWithTemplates : IEquatable<LanguageWithTemplates>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageWithTemplates" /> class.
        /// </summary>
        /// <param name="languageId">languageId (default to 0).</param>
        /// <param name="defaultTemplate">defaultTemplate.</param>
        /// <param name="templates">templates.</param>
        public LanguageWithTemplates(int languageId = 0, string defaultTemplate = default(string), List<SiteTemplate> templates = default(List<SiteTemplate>))
        {
            this.LanguageId = languageId;
            this.DefaultTemplate = defaultTemplate;
            this.Templates = templates;
        }

        /// <summary>
        /// Gets or Sets LanguageId
        /// </summary>
        [DataMember(Name = "languageId", EmitDefaultValue = false)]
        public int LanguageId { get; set; }

        /// <summary>
        /// Gets or Sets DefaultTemplate
        /// </summary>
        [DataMember(Name = "defaultTemplate", EmitDefaultValue = true)]
        public string DefaultTemplate { get; set; }

        /// <summary>
        /// Gets or Sets Templates
        /// </summary>
        [DataMember(Name = "templates", EmitDefaultValue = true)]
        public List<SiteTemplate> Templates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LanguageWithTemplates {\n");
            sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
            sb.Append("  DefaultTemplate: ").Append(DefaultTemplate).Append("\n");
            sb.Append("  Templates: ").Append(Templates).Append("\n");
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
            return this.Equals(input as LanguageWithTemplates);
        }

        /// <summary>
        /// Returns true if LanguageWithTemplates instances are equal
        /// </summary>
        /// <param name="input">Instance of LanguageWithTemplates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LanguageWithTemplates input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LanguageId == input.LanguageId ||
                    this.LanguageId.Equals(input.LanguageId)
                ) && 
                (
                    this.DefaultTemplate == input.DefaultTemplate ||
                    (this.DefaultTemplate != null &&
                    this.DefaultTemplate.Equals(input.DefaultTemplate))
                ) && 
                (
                    this.Templates == input.Templates ||
                    this.Templates != null &&
                    input.Templates != null &&
                    this.Templates.SequenceEqual(input.Templates)
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
                hashCode = hashCode * 59 + this.LanguageId.GetHashCode();
                if (this.DefaultTemplate != null)
                    hashCode = hashCode * 59 + this.DefaultTemplate.GetHashCode();
                if (this.Templates != null)
                    hashCode = hashCode * 59 + this.Templates.GetHashCode();
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
