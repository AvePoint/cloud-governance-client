

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
    /// TeamsTemplateSettings
    /// </summary>
    [DataContract(Name = "TeamsTemplateSettings")]
    public partial class TeamsTemplateSettings : IEquatable<TeamsTemplateSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsTemplateSettings" /> class.
        /// </summary>
        /// <param name="enableCreateTeamFromScratch">enableCreateTeamFromScratch.</param>
        /// <param name="enableCreateTeamFromExistTeam">enableCreateTeamFromExistTeam.</param>
        /// <param name="selectedTemplate">selectedTemplate.</param>
        /// <param name="enableCloneChannels">enableCloneChannels.</param>
        /// <param name="enableCloneApps">enableCloneApps.</param>
        /// <param name="enableCloneTabs">enableCloneTabs.</param>
        /// <param name="enableCloneMembers">enableCloneMembers.</param>
        /// <param name="enableCloneTeamSetting">enableCloneTeamSetting.</param>
        /// <param name="enableCloneTeamPrivacy">enableCloneTeamPrivacy.</param>
        /// <param name="enableCloneTeamClassification">enableCloneTeamClassification.</param>
        public TeamsTemplateSettings(bool enableCreateTeamFromScratch = default(bool), bool enableCreateTeamFromExistTeam = default(bool), GuidModel selectedTemplate = default(GuidModel), bool enableCloneChannels = default(bool), bool enableCloneApps = default(bool), bool enableCloneTabs = default(bool), bool enableCloneMembers = default(bool), bool enableCloneTeamSetting = default(bool), bool enableCloneTeamPrivacy = default(bool), bool enableCloneTeamClassification = default(bool))
        {
            this.EnableCreateTeamFromScratch = enableCreateTeamFromScratch;
            this.EnableCreateTeamFromExistTeam = enableCreateTeamFromExistTeam;
            this.SelectedTemplate = selectedTemplate;
            this.EnableCloneChannels = enableCloneChannels;
            this.EnableCloneApps = enableCloneApps;
            this.EnableCloneTabs = enableCloneTabs;
            this.EnableCloneMembers = enableCloneMembers;
            this.EnableCloneTeamSetting = enableCloneTeamSetting;
            this.EnableCloneTeamPrivacy = enableCloneTeamPrivacy;
            this.EnableCloneTeamClassification = enableCloneTeamClassification;
        }

        /// <summary>
        /// Gets or Sets EnableCreateTeamFromScratch
        /// </summary>
        [DataMember(Name = "enableCreateTeamFromScratch", EmitDefaultValue = false)]
        public bool EnableCreateTeamFromScratch { get; set; }

        /// <summary>
        /// Gets or Sets EnableCreateTeamFromExistTeam
        /// </summary>
        [DataMember(Name = "enableCreateTeamFromExistTeam", EmitDefaultValue = false)]
        public bool EnableCreateTeamFromExistTeam { get; set; }

        /// <summary>
        /// Gets or Sets SelectedTemplate
        /// </summary>
        [DataMember(Name = "selectedTemplate", EmitDefaultValue = true)]
        public GuidModel SelectedTemplate { get; set; }

        /// <summary>
        /// Gets or Sets EnableCloneChannels
        /// </summary>
        [DataMember(Name = "enableCloneChannels", EmitDefaultValue = false)]
        public bool EnableCloneChannels { get; set; }

        /// <summary>
        /// Gets or Sets EnableCloneApps
        /// </summary>
        [DataMember(Name = "enableCloneApps", EmitDefaultValue = false)]
        public bool EnableCloneApps { get; set; }

        /// <summary>
        /// Gets or Sets EnableCloneTabs
        /// </summary>
        [DataMember(Name = "enableCloneTabs", EmitDefaultValue = false)]
        public bool EnableCloneTabs { get; set; }

        /// <summary>
        /// Gets or Sets EnableCloneMembers
        /// </summary>
        [DataMember(Name = "enableCloneMembers", EmitDefaultValue = false)]
        public bool EnableCloneMembers { get; set; }

        /// <summary>
        /// Gets or Sets EnableCloneTeamSetting
        /// </summary>
        [DataMember(Name = "enableCloneTeamSetting", EmitDefaultValue = false)]
        public bool EnableCloneTeamSetting { get; set; }

        /// <summary>
        /// Gets or Sets EnableCloneTeamPrivacy
        /// </summary>
        [DataMember(Name = "enableCloneTeamPrivacy", EmitDefaultValue = false)]
        public bool EnableCloneTeamPrivacy { get; set; }

        /// <summary>
        /// Gets or Sets EnableCloneTeamClassification
        /// </summary>
        [DataMember(Name = "enableCloneTeamClassification", EmitDefaultValue = false)]
        public bool EnableCloneTeamClassification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamsTemplateSettings {\n");
            sb.Append("  EnableCreateTeamFromScratch: ").Append(EnableCreateTeamFromScratch).Append("\n");
            sb.Append("  EnableCreateTeamFromExistTeam: ").Append(EnableCreateTeamFromExistTeam).Append("\n");
            sb.Append("  SelectedTemplate: ").Append(SelectedTemplate).Append("\n");
            sb.Append("  EnableCloneChannels: ").Append(EnableCloneChannels).Append("\n");
            sb.Append("  EnableCloneApps: ").Append(EnableCloneApps).Append("\n");
            sb.Append("  EnableCloneTabs: ").Append(EnableCloneTabs).Append("\n");
            sb.Append("  EnableCloneMembers: ").Append(EnableCloneMembers).Append("\n");
            sb.Append("  EnableCloneTeamSetting: ").Append(EnableCloneTeamSetting).Append("\n");
            sb.Append("  EnableCloneTeamPrivacy: ").Append(EnableCloneTeamPrivacy).Append("\n");
            sb.Append("  EnableCloneTeamClassification: ").Append(EnableCloneTeamClassification).Append("\n");
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
            return this.Equals(input as TeamsTemplateSettings);
        }

        /// <summary>
        /// Returns true if TeamsTemplateSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamsTemplateSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamsTemplateSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnableCreateTeamFromScratch == input.EnableCreateTeamFromScratch ||
                    this.EnableCreateTeamFromScratch.Equals(input.EnableCreateTeamFromScratch)
                ) && 
                (
                    this.EnableCreateTeamFromExistTeam == input.EnableCreateTeamFromExistTeam ||
                    this.EnableCreateTeamFromExistTeam.Equals(input.EnableCreateTeamFromExistTeam)
                ) && 
                (
                    this.SelectedTemplate == input.SelectedTemplate ||
                    (this.SelectedTemplate != null &&
                    this.SelectedTemplate.Equals(input.SelectedTemplate))
                ) && 
                (
                    this.EnableCloneChannels == input.EnableCloneChannels ||
                    this.EnableCloneChannels.Equals(input.EnableCloneChannels)
                ) && 
                (
                    this.EnableCloneApps == input.EnableCloneApps ||
                    this.EnableCloneApps.Equals(input.EnableCloneApps)
                ) && 
                (
                    this.EnableCloneTabs == input.EnableCloneTabs ||
                    this.EnableCloneTabs.Equals(input.EnableCloneTabs)
                ) && 
                (
                    this.EnableCloneMembers == input.EnableCloneMembers ||
                    this.EnableCloneMembers.Equals(input.EnableCloneMembers)
                ) && 
                (
                    this.EnableCloneTeamSetting == input.EnableCloneTeamSetting ||
                    this.EnableCloneTeamSetting.Equals(input.EnableCloneTeamSetting)
                ) && 
                (
                    this.EnableCloneTeamPrivacy == input.EnableCloneTeamPrivacy ||
                    this.EnableCloneTeamPrivacy.Equals(input.EnableCloneTeamPrivacy)
                ) && 
                (
                    this.EnableCloneTeamClassification == input.EnableCloneTeamClassification ||
                    this.EnableCloneTeamClassification.Equals(input.EnableCloneTeamClassification)
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
                hashCode = hashCode * 59 + this.EnableCreateTeamFromScratch.GetHashCode();
                hashCode = hashCode * 59 + this.EnableCreateTeamFromExistTeam.GetHashCode();
                if (this.SelectedTemplate != null)
                    hashCode = hashCode * 59 + this.SelectedTemplate.GetHashCode();
                hashCode = hashCode * 59 + this.EnableCloneChannels.GetHashCode();
                hashCode = hashCode * 59 + this.EnableCloneApps.GetHashCode();
                hashCode = hashCode * 59 + this.EnableCloneTabs.GetHashCode();
                hashCode = hashCode * 59 + this.EnableCloneMembers.GetHashCode();
                hashCode = hashCode * 59 + this.EnableCloneTeamSetting.GetHashCode();
                hashCode = hashCode * 59 + this.EnableCloneTeamPrivacy.GetHashCode();
                hashCode = hashCode * 59 + this.EnableCloneTeamClassification.GetHashCode();
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
