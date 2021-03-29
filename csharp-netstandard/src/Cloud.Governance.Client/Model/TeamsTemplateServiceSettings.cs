

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
    /// TeamsTemplateServiceSettings
    /// </summary>
    [DataContract(Name = "TeamsTemplateServiceSettings")]
    public partial class TeamsTemplateServiceSettings : IEquatable<TeamsTemplateServiceSettings>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets CloneTeamTemplateSettingValueAssignBy
        /// </summary>
        [DataMember(Name = "cloneTeamTemplateSettingValueAssignBy", EmitDefaultValue = false)]
        public AssignBy? CloneTeamTemplateSettingValueAssignBy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsTemplateServiceSettings" /> class.
        /// </summary>
        /// <param name="enableCreateTeamFromScratch">enableCreateTeamFromScratch (default to false).</param>
        /// <param name="enableCreateTeamFromExistTeam">enableCreateTeamFromExistTeam (default to false).</param>
        /// <param name="enableCreateTeamFromTeamTemplate">enableCreateTeamFromTeamTemplate (default to false).</param>
        /// <param name="enableCreateTeamFromIT">enableCreateTeamFromIT (default to false).</param>
        /// <param name="enableCreateTeamFromOwned">enableCreateTeamFromOwned (default to false).</param>
        /// <param name="enableCloneChannels">enableCloneChannels (default to false).</param>
        /// <param name="enableCloneApps">enableCloneApps (default to false).</param>
        /// <param name="enableCloneTabs">enableCloneTabs (default to false).</param>
        /// <param name="enableCloneMembers">enableCloneMembers (default to false).</param>
        /// <param name="enableCloneTeamSetting">enableCloneTeamSetting (default to false).</param>
        /// <param name="enableCloneTeamPrivacy">enableCloneTeamPrivacy (default to false).</param>
        /// <param name="enableCloneTeamClassification">enableCloneTeamClassification (default to false).</param>
        /// <param name="cloneTeamTemplateSettingValueAssignBy">cloneTeamTemplateSettingValueAssignBy.</param>
        /// <param name="templateTeams">templateTeams.</param>
        /// <param name="teamTemplates">teamTemplates.</param>
        /// <param name="hidden">hidden (default to false).</param>
        public TeamsTemplateServiceSettings(bool enableCreateTeamFromScratch = false, bool enableCreateTeamFromExistTeam = false, bool enableCreateTeamFromTeamTemplate = false, bool enableCreateTeamFromIT = false, bool enableCreateTeamFromOwned = false, bool enableCloneChannels = false, bool enableCloneApps = false, bool enableCloneTabs = false, bool enableCloneMembers = false, bool enableCloneTeamSetting = false, bool enableCloneTeamPrivacy = false, bool enableCloneTeamClassification = false, AssignBy? cloneTeamTemplateSettingValueAssignBy = default(AssignBy?), List<GuidModel> templateTeams = default(List<GuidModel>), List<TextModel> teamTemplates = default(List<TextModel>), bool hidden = false)
        {
            this.EnableCreateTeamFromScratch = enableCreateTeamFromScratch;
            this.EnableCreateTeamFromExistTeam = enableCreateTeamFromExistTeam;
            this.EnableCreateTeamFromTeamTemplate = enableCreateTeamFromTeamTemplate;
            this.EnableCreateTeamFromIT = enableCreateTeamFromIT;
            this.EnableCreateTeamFromOwned = enableCreateTeamFromOwned;
            this.EnableCloneChannels = enableCloneChannels;
            this.EnableCloneApps = enableCloneApps;
            this.EnableCloneTabs = enableCloneTabs;
            this.EnableCloneMembers = enableCloneMembers;
            this.EnableCloneTeamSetting = enableCloneTeamSetting;
            this.EnableCloneTeamPrivacy = enableCloneTeamPrivacy;
            this.EnableCloneTeamClassification = enableCloneTeamClassification;
            this.CloneTeamTemplateSettingValueAssignBy = cloneTeamTemplateSettingValueAssignBy;
            this.TemplateTeams = templateTeams;
            this.TeamTemplates = teamTemplates;
            this.Hidden = hidden;
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
        /// Gets or Sets EnableCreateTeamFromTeamTemplate
        /// </summary>
        [DataMember(Name = "enableCreateTeamFromTeamTemplate", EmitDefaultValue = false)]
        public bool EnableCreateTeamFromTeamTemplate { get; set; }

        /// <summary>
        /// Gets or Sets EnableCreateTeamFromIT
        /// </summary>
        [DataMember(Name = "enableCreateTeamFromIT", EmitDefaultValue = false)]
        public bool EnableCreateTeamFromIT { get; set; }

        /// <summary>
        /// Gets or Sets EnableCreateTeamFromOwned
        /// </summary>
        [DataMember(Name = "enableCreateTeamFromOwned", EmitDefaultValue = false)]
        public bool EnableCreateTeamFromOwned { get; set; }

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
        /// Gets or Sets TemplateTeams
        /// </summary>
        [DataMember(Name = "templateTeams", EmitDefaultValue = true)]
        public List<GuidModel> TemplateTeams { get; set; }

        /// <summary>
        /// Gets or Sets TeamTemplates
        /// </summary>
        [DataMember(Name = "teamTemplates", EmitDefaultValue = true)]
        public List<TextModel> TeamTemplates { get; set; }

        /// <summary>
        /// Gets or Sets Hidden
        /// </summary>
        [DataMember(Name = "hidden", EmitDefaultValue = false)]
        public bool Hidden { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamsTemplateServiceSettings {\n");
            sb.Append("  EnableCreateTeamFromScratch: ").Append(EnableCreateTeamFromScratch).Append("\n");
            sb.Append("  EnableCreateTeamFromExistTeam: ").Append(EnableCreateTeamFromExistTeam).Append("\n");
            sb.Append("  EnableCreateTeamFromTeamTemplate: ").Append(EnableCreateTeamFromTeamTemplate).Append("\n");
            sb.Append("  EnableCreateTeamFromIT: ").Append(EnableCreateTeamFromIT).Append("\n");
            sb.Append("  EnableCreateTeamFromOwned: ").Append(EnableCreateTeamFromOwned).Append("\n");
            sb.Append("  EnableCloneChannels: ").Append(EnableCloneChannels).Append("\n");
            sb.Append("  EnableCloneApps: ").Append(EnableCloneApps).Append("\n");
            sb.Append("  EnableCloneTabs: ").Append(EnableCloneTabs).Append("\n");
            sb.Append("  EnableCloneMembers: ").Append(EnableCloneMembers).Append("\n");
            sb.Append("  EnableCloneTeamSetting: ").Append(EnableCloneTeamSetting).Append("\n");
            sb.Append("  EnableCloneTeamPrivacy: ").Append(EnableCloneTeamPrivacy).Append("\n");
            sb.Append("  EnableCloneTeamClassification: ").Append(EnableCloneTeamClassification).Append("\n");
            sb.Append("  CloneTeamTemplateSettingValueAssignBy: ").Append(CloneTeamTemplateSettingValueAssignBy).Append("\n");
            sb.Append("  TemplateTeams: ").Append(TemplateTeams).Append("\n");
            sb.Append("  TeamTemplates: ").Append(TeamTemplates).Append("\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
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
            return this.Equals(input as TeamsTemplateServiceSettings);
        }

        /// <summary>
        /// Returns true if TeamsTemplateServiceSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamsTemplateServiceSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamsTemplateServiceSettings input)
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
                    this.EnableCreateTeamFromIT == input.EnableCreateTeamFromIT ||
                    this.EnableCreateTeamFromIT.Equals(input.EnableCreateTeamFromIT)
                ) && 
                (
                    this.EnableCreateTeamFromOwned == input.EnableCreateTeamFromOwned ||
                    this.EnableCreateTeamFromOwned.Equals(input.EnableCreateTeamFromOwned)
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
                ) && 
                (
                    this.CloneTeamTemplateSettingValueAssignBy == input.CloneTeamTemplateSettingValueAssignBy ||
                    this.CloneTeamTemplateSettingValueAssignBy.Equals(input.CloneTeamTemplateSettingValueAssignBy)
                ) && 
                (
                    this.TemplateTeams == input.TemplateTeams ||
                    this.TemplateTeams != null &&
                    input.TemplateTeams != null &&
                    this.TemplateTeams.SequenceEqual(input.TemplateTeams)
                ) && 
                (
                    this.TeamTemplates == input.TeamTemplates ||
                    this.TeamTemplates != null &&
                    input.TeamTemplates != null &&
                    this.TeamTemplates.SequenceEqual(input.TeamTemplates)
                ) && 
                (
                    this.Hidden == input.Hidden ||
                    this.Hidden.Equals(input.Hidden)
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
                hashCode = hashCode * 59 + this.EnableCreateTeamFromIT.GetHashCode();
                hashCode = hashCode * 59 + this.EnableCreateTeamFromOwned.GetHashCode();
                hashCode = hashCode * 59 + this.EnableCloneChannels.GetHashCode();
                hashCode = hashCode * 59 + this.EnableCloneApps.GetHashCode();
                hashCode = hashCode * 59 + this.EnableCloneTabs.GetHashCode();
                hashCode = hashCode * 59 + this.EnableCloneMembers.GetHashCode();
                hashCode = hashCode * 59 + this.EnableCloneTeamSetting.GetHashCode();
                hashCode = hashCode * 59 + this.EnableCloneTeamPrivacy.GetHashCode();
                hashCode = hashCode * 59 + this.EnableCloneTeamClassification.GetHashCode();
                hashCode = hashCode * 59 + this.CloneTeamTemplateSettingValueAssignBy.GetHashCode();
                if (this.TemplateTeams != null)
                    hashCode = hashCode * 59 + this.TemplateTeams.GetHashCode();
                if (this.TeamTemplates != null)
                    hashCode = hashCode * 59 + this.TeamTemplates.GetHashCode();
                hashCode = hashCode * 59 + this.Hidden.GetHashCode();
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
