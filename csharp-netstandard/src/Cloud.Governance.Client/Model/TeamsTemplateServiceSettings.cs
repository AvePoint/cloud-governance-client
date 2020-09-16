

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
    /// TeamsTemplateServiceSettings
    /// </summary>
    [DataContract(Name = "TeamsTemplateServiceSettings")]
    public partial class TeamsTemplateServiceSettings : IEquatable<TeamsTemplateServiceSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsTemplateServiceSettings" /> class.
        /// </summary>
        /// <param name="enableCreateTeamFromScratch">enableCreateTeamFromScratch.</param>
        /// <param name="enableCreateTeamFromExistTeam">enableCreateTeamFromExistTeam.</param>
        /// <param name="enableCreateTeamFromIT">enableCreateTeamFromIT.</param>
        /// <param name="enableCreateTeamFromOwned">enableCreateTeamFromOwned.</param>
        /// <param name="templateTeams">templateTeams.</param>
        public TeamsTemplateServiceSettings(bool enableCreateTeamFromScratch = default(bool), bool enableCreateTeamFromExistTeam = default(bool), bool enableCreateTeamFromIT = default(bool), bool enableCreateTeamFromOwned = default(bool), List<GuidModel> templateTeams = default(List<GuidModel>))
        {
            this.EnableCreateTeamFromScratch = enableCreateTeamFromScratch;
            this.EnableCreateTeamFromExistTeam = enableCreateTeamFromExistTeam;
            this.EnableCreateTeamFromIT = enableCreateTeamFromIT;
            this.EnableCreateTeamFromOwned = enableCreateTeamFromOwned;
            this.TemplateTeams = templateTeams;
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
        /// Gets or Sets TemplateTeams
        /// </summary>
        [DataMember(Name = "templateTeams", EmitDefaultValue = true)]
        public List<GuidModel> TemplateTeams { get; set; }

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
            sb.Append("  EnableCreateTeamFromIT: ").Append(EnableCreateTeamFromIT).Append("\n");
            sb.Append("  EnableCreateTeamFromOwned: ").Append(EnableCreateTeamFromOwned).Append("\n");
            sb.Append("  TemplateTeams: ").Append(TemplateTeams).Append("\n");
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
                    this.EnableCreateTeamFromIT == input.EnableCreateTeamFromIT ||
                    this.EnableCreateTeamFromIT.Equals(input.EnableCreateTeamFromIT)
                ) && 
                (
                    this.EnableCreateTeamFromOwned == input.EnableCreateTeamFromOwned ||
                    this.EnableCreateTeamFromOwned.Equals(input.EnableCreateTeamFromOwned)
                ) && 
                (
                    this.TemplateTeams == input.TemplateTeams ||
                    this.TemplateTeams != null &&
                    input.TemplateTeams != null &&
                    this.TemplateTeams.SequenceEqual(input.TemplateTeams)
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
                hashCode = hashCode * 59 + this.EnableCreateTeamFromIT.GetHashCode();
                hashCode = hashCode * 59 + this.EnableCreateTeamFromOwned.GetHashCode();
                if (this.TemplateTeams != null)
                    hashCode = hashCode * 59 + this.TemplateTeams.GetHashCode();
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
