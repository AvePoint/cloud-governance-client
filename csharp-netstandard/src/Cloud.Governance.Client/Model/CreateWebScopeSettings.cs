

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
    /// CreateWebScopeSettings
    /// </summary>
    [DataContract(Name = "CreateWebScopeSettings")]
    public partial class CreateWebScopeSettings : IEquatable<CreateWebScopeSettings>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ScopeType
        /// </summary>
        [DataMember(Name = "scopeType", EmitDefaultValue = false)]
        public ScopeType? ScopeType { get; set; }
        /// <summary>
        /// Gets or Sets AutoPopulateUrlWithSPContextAssignBy
        /// </summary>
        [DataMember(Name = "autoPopulateUrlWithSPContextAssignBy", EmitDefaultValue = false)]
        public AssignBy? AutoPopulateUrlWithSPContextAssignBy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebScopeSettings" /> class.
        /// </summary>
        /// <param name="restrictParentUrl">restrictParentUrl.</param>
        /// <param name="scopeType">scopeType.</param>
        /// <param name="useTitleInUrl">useTitleInUrl (default to false).</param>
        /// <param name="enableUrlValidation">enableUrlValidation (default to false).</param>
        /// <param name="textValidationRule">textValidationRule.</param>
        /// <param name="selectedNodes">selectedNodes.</param>
        /// <param name="autoPopulateUrlWithSPContext">autoPopulateUrlWithSPContext (default to false).</param>
        /// <param name="autoPopulateUrlWithSPContextAssignBy">autoPopulateUrlWithSPContextAssignBy.</param>
        public CreateWebScopeSettings(string restrictParentUrl = default(string), ScopeType? scopeType = default(ScopeType?), bool useTitleInUrl = false, bool enableUrlValidation = false, TextValidationRuleRef textValidationRule = default(TextValidationRuleRef), List<SPNode> selectedNodes = default(List<SPNode>), bool autoPopulateUrlWithSPContext = false, AssignBy? autoPopulateUrlWithSPContextAssignBy = default(AssignBy?))
        {
            this.RestrictParentUrl = restrictParentUrl;
            this.ScopeType = scopeType;
            this.UseTitleInUrl = useTitleInUrl;
            this.EnableUrlValidation = enableUrlValidation;
            this.TextValidationRule = textValidationRule;
            this.SelectedNodes = selectedNodes;
            this.AutoPopulateUrlWithSPContext = autoPopulateUrlWithSPContext;
            this.AutoPopulateUrlWithSPContextAssignBy = autoPopulateUrlWithSPContextAssignBy;
        }

        /// <summary>
        /// Gets or Sets RestrictParentUrl
        /// </summary>
        [DataMember(Name = "restrictParentUrl", EmitDefaultValue = true)]
        public string RestrictParentUrl { get; set; }

        /// <summary>
        /// Gets or Sets UseTitleInUrl
        /// </summary>
        [DataMember(Name = "useTitleInUrl", EmitDefaultValue = false)]
        public bool UseTitleInUrl { get; set; }

        /// <summary>
        /// Gets or Sets EnableUrlValidation
        /// </summary>
        [DataMember(Name = "enableUrlValidation", EmitDefaultValue = false)]
        public bool EnableUrlValidation { get; set; }

        /// <summary>
        /// Gets or Sets TextValidationRule
        /// </summary>
        [DataMember(Name = "textValidationRule", EmitDefaultValue = true)]
        public TextValidationRuleRef TextValidationRule { get; set; }

        /// <summary>
        /// Gets or Sets SelectedNodes
        /// </summary>
        [DataMember(Name = "selectedNodes", EmitDefaultValue = true)]
        public List<SPNode> SelectedNodes { get; set; }

        /// <summary>
        /// Gets or Sets AutoPopulateUrlWithSPContext
        /// </summary>
        [DataMember(Name = "autoPopulateUrlWithSPContext", EmitDefaultValue = false)]
        public bool AutoPopulateUrlWithSPContext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateWebScopeSettings {\n");
            sb.Append("  RestrictParentUrl: ").Append(RestrictParentUrl).Append("\n");
            sb.Append("  ScopeType: ").Append(ScopeType).Append("\n");
            sb.Append("  UseTitleInUrl: ").Append(UseTitleInUrl).Append("\n");
            sb.Append("  EnableUrlValidation: ").Append(EnableUrlValidation).Append("\n");
            sb.Append("  TextValidationRule: ").Append(TextValidationRule).Append("\n");
            sb.Append("  SelectedNodes: ").Append(SelectedNodes).Append("\n");
            sb.Append("  AutoPopulateUrlWithSPContext: ").Append(AutoPopulateUrlWithSPContext).Append("\n");
            sb.Append("  AutoPopulateUrlWithSPContextAssignBy: ").Append(AutoPopulateUrlWithSPContextAssignBy).Append("\n");
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
            return this.Equals(input as CreateWebScopeSettings);
        }

        /// <summary>
        /// Returns true if CreateWebScopeSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateWebScopeSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateWebScopeSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RestrictParentUrl == input.RestrictParentUrl ||
                    (this.RestrictParentUrl != null &&
                    this.RestrictParentUrl.Equals(input.RestrictParentUrl))
                ) && 
                (
                    this.ScopeType == input.ScopeType ||
                    this.ScopeType.Equals(input.ScopeType)
                ) && 
                (
                    this.UseTitleInUrl == input.UseTitleInUrl ||
                    this.UseTitleInUrl.Equals(input.UseTitleInUrl)
                ) && 
                (
                    this.EnableUrlValidation == input.EnableUrlValidation ||
                    this.EnableUrlValidation.Equals(input.EnableUrlValidation)
                ) && 
                (
                    this.TextValidationRule == input.TextValidationRule ||
                    (this.TextValidationRule != null &&
                    this.TextValidationRule.Equals(input.TextValidationRule))
                ) && 
                (
                    this.SelectedNodes == input.SelectedNodes ||
                    this.SelectedNodes != null &&
                    input.SelectedNodes != null &&
                    this.SelectedNodes.SequenceEqual(input.SelectedNodes)
                ) && 
                (
                    this.AutoPopulateUrlWithSPContext == input.AutoPopulateUrlWithSPContext ||
                    this.AutoPopulateUrlWithSPContext.Equals(input.AutoPopulateUrlWithSPContext)
                ) && 
                (
                    this.AutoPopulateUrlWithSPContextAssignBy == input.AutoPopulateUrlWithSPContextAssignBy ||
                    this.AutoPopulateUrlWithSPContextAssignBy.Equals(input.AutoPopulateUrlWithSPContextAssignBy)
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
                if (this.RestrictParentUrl != null)
                    hashCode = hashCode * 59 + this.RestrictParentUrl.GetHashCode();
                hashCode = hashCode * 59 + this.ScopeType.GetHashCode();
                hashCode = hashCode * 59 + this.UseTitleInUrl.GetHashCode();
                hashCode = hashCode * 59 + this.EnableUrlValidation.GetHashCode();
                if (this.TextValidationRule != null)
                    hashCode = hashCode * 59 + this.TextValidationRule.GetHashCode();
                if (this.SelectedNodes != null)
                    hashCode = hashCode * 59 + this.SelectedNodes.GetHashCode();
                hashCode = hashCode * 59 + this.AutoPopulateUrlWithSPContext.GetHashCode();
                hashCode = hashCode * 59 + this.AutoPopulateUrlWithSPContextAssignBy.GetHashCode();
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
