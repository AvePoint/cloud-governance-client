

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
    /// PolicyWithTemplates
    /// </summary>
    [DataContract(Name = "PolicyWithTemplates")]
    public partial class PolicyWithTemplates : IEquatable<PolicyWithTemplates>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyWithTemplates" /> class.
        /// </summary>
        /// <param name="policyId">policyId.</param>
        /// <param name="defaultTemplate">defaultTemplate.</param>
        /// <param name="templates">templates.</param>
        public PolicyWithTemplates(Guid policyId = default(Guid), string defaultTemplate = default(string), List<SiteTemplate> templates = default(List<SiteTemplate>))
        {
            this.PolicyId = policyId;
            this.DefaultTemplate = defaultTemplate;
            this.Templates = templates;
        }

        /// <summary>
        /// Gets or Sets PolicyId
        /// </summary>
        [DataMember(Name = "policyId", EmitDefaultValue = false)]
        public Guid PolicyId { get; set; }

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
            sb.Append("class PolicyWithTemplates {\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
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
            return this.Equals(input as PolicyWithTemplates);
        }

        /// <summary>
        /// Returns true if PolicyWithTemplates instances are equal
        /// </summary>
        /// <param name="input">Instance of PolicyWithTemplates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyWithTemplates input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PolicyId == input.PolicyId ||
                    (this.PolicyId != null &&
                    this.PolicyId.Equals(input.PolicyId))
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
                if (this.PolicyId != null)
                    hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
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
