

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
    /// ListTemplateSettings
    /// </summary>
    [DataContract(Name = "ListTemplateSettings")]
    public partial class ListTemplateSettings : IEquatable<ListTemplateSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListTemplateSettings" /> class.
        /// </summary>
        /// <param name="availabeTemplates">availabeTemplates.</param>
        /// <param name="defaultTemplate">defaultTemplate.</param>
        /// <param name="templateStoreUrl">templateStoreUrl.</param>
        public ListTemplateSettings(List<ListTemplate> availabeTemplates = default(List<ListTemplate>), string defaultTemplate = default(string), string templateStoreUrl = default(string))
        {
            this.AvailabeTemplates = availabeTemplates;
            this.DefaultTemplate = defaultTemplate;
            this.TemplateStoreUrl = templateStoreUrl;
        }

        /// <summary>
        /// Gets or Sets AvailabeTemplates
        /// </summary>
        [DataMember(Name = "availabeTemplates", EmitDefaultValue = true)]
        public List<ListTemplate> AvailabeTemplates { get; set; }

        /// <summary>
        /// Gets or Sets DefaultTemplate
        /// </summary>
        [DataMember(Name = "defaultTemplate", EmitDefaultValue = true)]
        public string DefaultTemplate { get; set; }

        /// <summary>
        /// Gets or Sets TemplateStoreUrl
        /// </summary>
        [DataMember(Name = "templateStoreUrl", EmitDefaultValue = true)]
        public string TemplateStoreUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTemplateSettings {\n");
            sb.Append("  AvailabeTemplates: ").Append(AvailabeTemplates).Append("\n");
            sb.Append("  DefaultTemplate: ").Append(DefaultTemplate).Append("\n");
            sb.Append("  TemplateStoreUrl: ").Append(TemplateStoreUrl).Append("\n");
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
            return this.Equals(input as ListTemplateSettings);
        }

        /// <summary>
        /// Returns true if ListTemplateSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of ListTemplateSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListTemplateSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvailabeTemplates == input.AvailabeTemplates ||
                    this.AvailabeTemplates != null &&
                    input.AvailabeTemplates != null &&
                    this.AvailabeTemplates.SequenceEqual(input.AvailabeTemplates)
                ) && 
                (
                    this.DefaultTemplate == input.DefaultTemplate ||
                    (this.DefaultTemplate != null &&
                    this.DefaultTemplate.Equals(input.DefaultTemplate))
                ) && 
                (
                    this.TemplateStoreUrl == input.TemplateStoreUrl ||
                    (this.TemplateStoreUrl != null &&
                    this.TemplateStoreUrl.Equals(input.TemplateStoreUrl))
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
                if (this.AvailabeTemplates != null)
                    hashCode = hashCode * 59 + this.AvailabeTemplates.GetHashCode();
                if (this.DefaultTemplate != null)
                    hashCode = hashCode * 59 + this.DefaultTemplate.GetHashCode();
                if (this.TemplateStoreUrl != null)
                    hashCode = hashCode * 59 + this.TemplateStoreUrl.GetHashCode();
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
