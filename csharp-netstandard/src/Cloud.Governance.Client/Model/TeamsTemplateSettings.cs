

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
    /// Teams template settings model
    /// </summary>
    [DataContract(Name = "TeamsTemplateSettings")]
    public partial class TeamsTemplateSettings : IEquatable<TeamsTemplateSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsTemplateSettings" /> class.
        /// </summary>
        /// <param name="enableCreateTeamFromScratch">Whether to allow business users to create a team from scratch. (default to false).</param>
        /// <param name="enableCreateTeamFromExistTeam">Whether to allow business users to create a team from an existing team. (default to false).</param>
        /// <param name="enableCreateTeamFromTeamTemplate">Whether to allow business users to create a team using a team template. (default to false).</param>
        /// <param name="selectedTemplate">The selected custom team template.</param>
        /// <param name="selectedMSTemplate">The selected built-in team template.</param>
        /// <param name="teamTemplates">All team templates.</param>
        /// <param name="enableCloneChannels">Set whether copying channels from the team is enabled. (default to false).</param>
        /// <param name="enableCloneApps">Set whether copying apps from the team is enabled. (default to false).</param>
        /// <param name="enableCloneTabs">Set whether copying tabs from the team is enabled. (default to false).</param>
        /// <param name="enableCloneMembers">Set whether copying members from the team is enabled. (default to false).</param>
        /// <param name="enableCloneTeamSetting">Set whether copying team settings from the team is enabled. (default to false).</param>
        /// <param name="enableCloneTeamPrivacy">Whether to enable the team privacy. (Currently not supported) (default to false).</param>
        /// <param name="enableCloneTeamClassification">Whether to enable the team classification. (Currently not supported) (default to false).</param>
        public TeamsTemplateSettings(bool enableCreateTeamFromScratch = false, bool enableCreateTeamFromExistTeam = false, bool enableCreateTeamFromTeamTemplate = false, GuidModel selectedTemplate = default(GuidModel), StringModel selectedMSTemplate = default(StringModel), List<TextModel> teamTemplates = default(List<TextModel>), bool enableCloneChannels = false, bool enableCloneApps = false, bool enableCloneTabs = false, bool enableCloneMembers = false, bool enableCloneTeamSetting = false, bool enableCloneTeamPrivacy = false, bool enableCloneTeamClassification = false)
        {
            this.EnableCreateTeamFromScratch = enableCreateTeamFromScratch;
            this.EnableCreateTeamFromExistTeam = enableCreateTeamFromExistTeam;
            this.EnableCreateTeamFromTeamTemplate = enableCreateTeamFromTeamTemplate;
            this.SelectedTemplate = selectedTemplate;
            this.SelectedMSTemplate = selectedMSTemplate;
            this.TeamTemplates = teamTemplates;
            this.EnableCloneChannels = enableCloneChannels;
            this.EnableCloneApps = enableCloneApps;
            this.EnableCloneTabs = enableCloneTabs;
            this.EnableCloneMembers = enableCloneMembers;
            this.EnableCloneTeamSetting = enableCloneTeamSetting;
            this.EnableCloneTeamPrivacy = enableCloneTeamPrivacy;
            this.EnableCloneTeamClassification = enableCloneTeamClassification;
        }

        /// <summary>
        /// Whether to allow business users to create a team from scratch.
        /// </summary>
        /// <value>Whether to allow business users to create a team from scratch.</value>
        [DataMember(Name = "enableCreateTeamFromScratch", EmitDefaultValue = false)]
        public bool EnableCreateTeamFromScratch { get; set; }

        /// <summary>
        /// Whether to allow business users to create a team from an existing team.
        /// </summary>
        /// <value>Whether to allow business users to create a team from an existing team.</value>
        [DataMember(Name = "enableCreateTeamFromExistTeam", EmitDefaultValue = false)]
        public bool EnableCreateTeamFromExistTeam { get; set; }

        /// <summary>
        /// Whether to allow business users to create a team using a team template.
        /// </summary>
        /// <value>Whether to allow business users to create a team using a team template.</value>
        [DataMember(Name = "enableCreateTeamFromTeamTemplate", EmitDefaultValue = false)]
        public bool EnableCreateTeamFromTeamTemplate { get; set; }

        /// <summary>
        /// The selected custom team template
        /// </summary>
        /// <value>The selected custom team template</value>
        [DataMember(Name = "selectedTemplate", EmitDefaultValue = true)]
        public GuidModel SelectedTemplate { get; set; }

        /// <summary>
        /// The selected built-in team template
        /// </summary>
        /// <value>The selected built-in team template</value>
        [DataMember(Name = "selectedMSTemplate", EmitDefaultValue = true)]
        public StringModel SelectedMSTemplate { get; set; }

        /// <summary>
        /// All team templates
        /// </summary>
        /// <value>All team templates</value>
        [DataMember(Name = "teamTemplates", EmitDefaultValue = true)]
        public List<TextModel> TeamTemplates { get; set; }

        /// <summary>
        /// Set whether copying channels from the team is enabled.
        /// </summary>
        /// <value>Set whether copying channels from the team is enabled.</value>
        [DataMember(Name = "enableCloneChannels", EmitDefaultValue = false)]
        public bool EnableCloneChannels { get; set; }

        /// <summary>
        /// Set whether copying apps from the team is enabled.
        /// </summary>
        /// <value>Set whether copying apps from the team is enabled.</value>
        [DataMember(Name = "enableCloneApps", EmitDefaultValue = false)]
        public bool EnableCloneApps { get; set; }

        /// <summary>
        /// Set whether copying tabs from the team is enabled.
        /// </summary>
        /// <value>Set whether copying tabs from the team is enabled.</value>
        [DataMember(Name = "enableCloneTabs", EmitDefaultValue = false)]
        public bool EnableCloneTabs { get; set; }

        /// <summary>
        /// Set whether copying members from the team is enabled.
        /// </summary>
        /// <value>Set whether copying members from the team is enabled.</value>
        [DataMember(Name = "enableCloneMembers", EmitDefaultValue = false)]
        public bool EnableCloneMembers { get; set; }

        /// <summary>
        /// Set whether copying team settings from the team is enabled.
        /// </summary>
        /// <value>Set whether copying team settings from the team is enabled.</value>
        [DataMember(Name = "enableCloneTeamSetting", EmitDefaultValue = false)]
        public bool EnableCloneTeamSetting { get; set; }

        /// <summary>
        /// Whether to enable the team privacy. (Currently not supported)
        /// </summary>
        /// <value>Whether to enable the team privacy. (Currently not supported)</value>
        [DataMember(Name = "enableCloneTeamPrivacy", EmitDefaultValue = false)]
        public bool EnableCloneTeamPrivacy { get; set; }

        /// <summary>
        /// Whether to enable the team classification. (Currently not supported)
        /// </summary>
        /// <value>Whether to enable the team classification. (Currently not supported)</value>
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
            sb.Append("  EnableCreateTeamFromTeamTemplate: ").Append(EnableCreateTeamFromTeamTemplate).Append("\n");
            sb.Append("  SelectedTemplate: ").Append(SelectedTemplate).Append("\n");
            sb.Append("  SelectedMSTemplate: ").Append(SelectedMSTemplate).Append("\n");
            sb.Append("  TeamTemplates: ").Append(TeamTemplates).Append("\n");
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
                    this.EnableCreateTeamFromTeamTemplate == input.EnableCreateTeamFromTeamTemplate ||
                    this.EnableCreateTeamFromTeamTemplate.Equals(input.EnableCreateTeamFromTeamTemplate)
                ) && 
                (
                    this.SelectedTemplate == input.SelectedTemplate ||
                    (this.SelectedTemplate != null &&
                    this.SelectedTemplate.Equals(input.SelectedTemplate))
                ) && 
                (
                    this.SelectedMSTemplate == input.SelectedMSTemplate ||
                    (this.SelectedMSTemplate != null &&
                    this.SelectedMSTemplate.Equals(input.SelectedMSTemplate))
                ) && 
                (
                    this.TeamTemplates == input.TeamTemplates ||
                    this.TeamTemplates != null &&
                    input.TeamTemplates != null &&
                    this.TeamTemplates.SequenceEqual(input.TeamTemplates)
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
                hashCode = hashCode * 59 + this.EnableCreateTeamFromTeamTemplate.GetHashCode();
                if (this.SelectedTemplate != null)
                    hashCode = hashCode * 59 + this.SelectedTemplate.GetHashCode();
                if (this.SelectedMSTemplate != null)
                    hashCode = hashCode * 59 + this.SelectedMSTemplate.GetHashCode();
                if (this.TeamTemplates != null)
                    hashCode = hashCode * 59 + this.TeamTemplates.GetHashCode();
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
