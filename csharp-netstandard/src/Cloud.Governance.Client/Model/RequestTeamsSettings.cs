

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
    /// RequestTeamsSettings
    /// </summary>
    [DataContract(Name = "RequestTeamsSettings")]
    public partial class RequestTeamsSettings : IEquatable<RequestTeamsSettings>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets GiphyRatingType
        /// </summary>
        [DataMember(Name = "giphyRatingType", EmitDefaultValue = false)]
        public GiphyRatingType? GiphyRatingType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestTeamsSettings" /> class.
        /// </summary>
        /// <param name="allowMembersCreateUpdateChannels">allowMembersCreateUpdateChannels.</param>
        /// <param name="allowMembersCreatePrivateChannels">allowMembersCreatePrivateChannels.</param>
        /// <param name="allowMemberDeleteRestoreChannels">allowMemberDeleteRestoreChannels.</param>
        /// <param name="allowMembersAddRemoveApps">allowMembersAddRemoveApps.</param>
        /// <param name="allowMembersCreateUpdateRemoveTabs">allowMembersCreateUpdateRemoveTabs.</param>
        /// <param name="allowMembersCreateUpdateRemoveConnections">allowMembersCreateUpdateRemoveConnections.</param>
        /// <param name="allowMembersDeleteMessages">allowMembersDeleteMessages.</param>
        /// <param name="allowMembersEditMessages">allowMembersEditMessages.</param>
        /// <param name="allowGuestsCreateUpdateChannels">allowGuestsCreateUpdateChannels.</param>
        /// <param name="allowGuestsDeleteChannels">allowGuestsDeleteChannels.</param>
        /// <param name="allowMentionsTeam">allowMentionsTeam.</param>
        /// <param name="allowMentionsChannel">allowMentionsChannel.</param>
        /// <param name="enableGiphy">enableGiphy.</param>
        /// <param name="enableStickersAndMemes">enableStickersAndMemes.</param>
        /// <param name="enableCustomMemes">enableCustomMemes.</param>
        /// <param name="giphyRatingType">giphyRatingType.</param>
        public RequestTeamsSettings(bool allowMembersCreateUpdateChannels = default(bool), bool allowMembersCreatePrivateChannels = default(bool), bool allowMemberDeleteRestoreChannels = default(bool), bool allowMembersAddRemoveApps = default(bool), bool allowMembersCreateUpdateRemoveTabs = default(bool), bool allowMembersCreateUpdateRemoveConnections = default(bool), bool allowMembersDeleteMessages = default(bool), bool allowMembersEditMessages = default(bool), bool allowGuestsCreateUpdateChannels = default(bool), bool allowGuestsDeleteChannels = default(bool), bool allowMentionsTeam = default(bool), bool allowMentionsChannel = default(bool), bool enableGiphy = default(bool), bool enableStickersAndMemes = default(bool), bool enableCustomMemes = default(bool), GiphyRatingType? giphyRatingType = default(GiphyRatingType?))
        {
            this.AllowMembersCreateUpdateChannels = allowMembersCreateUpdateChannels;
            this.AllowMembersCreatePrivateChannels = allowMembersCreatePrivateChannels;
            this.AllowMemberDeleteRestoreChannels = allowMemberDeleteRestoreChannels;
            this.AllowMembersAddRemoveApps = allowMembersAddRemoveApps;
            this.AllowMembersCreateUpdateRemoveTabs = allowMembersCreateUpdateRemoveTabs;
            this.AllowMembersCreateUpdateRemoveConnections = allowMembersCreateUpdateRemoveConnections;
            this.AllowMembersDeleteMessages = allowMembersDeleteMessages;
            this.AllowMembersEditMessages = allowMembersEditMessages;
            this.AllowGuestsCreateUpdateChannels = allowGuestsCreateUpdateChannels;
            this.AllowGuestsDeleteChannels = allowGuestsDeleteChannels;
            this.AllowMentionsTeam = allowMentionsTeam;
            this.AllowMentionsChannel = allowMentionsChannel;
            this.EnableGiphy = enableGiphy;
            this.EnableStickersAndMemes = enableStickersAndMemes;
            this.EnableCustomMemes = enableCustomMemes;
            this.GiphyRatingType = giphyRatingType;
        }

        /// <summary>
        /// Gets or Sets AllowMembersCreateUpdateChannels
        /// </summary>
        [DataMember(Name = "allowMembersCreateUpdateChannels", EmitDefaultValue = false)]
        public bool AllowMembersCreateUpdateChannels { get; set; }

        /// <summary>
        /// Gets or Sets AllowMembersCreatePrivateChannels
        /// </summary>
        [DataMember(Name = "allowMembersCreatePrivateChannels", EmitDefaultValue = false)]
        public bool AllowMembersCreatePrivateChannels { get; set; }

        /// <summary>
        /// Gets or Sets AllowMemberDeleteRestoreChannels
        /// </summary>
        [DataMember(Name = "allowMemberDeleteRestoreChannels", EmitDefaultValue = false)]
        public bool AllowMemberDeleteRestoreChannels { get; set; }

        /// <summary>
        /// Gets or Sets AllowMembersAddRemoveApps
        /// </summary>
        [DataMember(Name = "allowMembersAddRemoveApps", EmitDefaultValue = false)]
        public bool AllowMembersAddRemoveApps { get; set; }

        /// <summary>
        /// Gets or Sets AllowMembersCreateUpdateRemoveTabs
        /// </summary>
        [DataMember(Name = "allowMembersCreateUpdateRemoveTabs", EmitDefaultValue = false)]
        public bool AllowMembersCreateUpdateRemoveTabs { get; set; }

        /// <summary>
        /// Gets or Sets AllowMembersCreateUpdateRemoveConnections
        /// </summary>
        [DataMember(Name = "allowMembersCreateUpdateRemoveConnections", EmitDefaultValue = false)]
        public bool AllowMembersCreateUpdateRemoveConnections { get; set; }

        /// <summary>
        /// Gets or Sets AllowMembersDeleteMessages
        /// </summary>
        [DataMember(Name = "allowMembersDeleteMessages", EmitDefaultValue = false)]
        public bool AllowMembersDeleteMessages { get; set; }

        /// <summary>
        /// Gets or Sets AllowMembersEditMessages
        /// </summary>
        [DataMember(Name = "allowMembersEditMessages", EmitDefaultValue = false)]
        public bool AllowMembersEditMessages { get; set; }

        /// <summary>
        /// Gets or Sets AllowGuestsCreateUpdateChannels
        /// </summary>
        [DataMember(Name = "allowGuestsCreateUpdateChannels", EmitDefaultValue = false)]
        public bool AllowGuestsCreateUpdateChannels { get; set; }

        /// <summary>
        /// Gets or Sets AllowGuestsDeleteChannels
        /// </summary>
        [DataMember(Name = "allowGuestsDeleteChannels", EmitDefaultValue = false)]
        public bool AllowGuestsDeleteChannels { get; set; }

        /// <summary>
        /// Gets or Sets AllowMentionsTeam
        /// </summary>
        [DataMember(Name = "allowMentionsTeam", EmitDefaultValue = false)]
        public bool AllowMentionsTeam { get; set; }

        /// <summary>
        /// Gets or Sets AllowMentionsChannel
        /// </summary>
        [DataMember(Name = "allowMentionsChannel", EmitDefaultValue = false)]
        public bool AllowMentionsChannel { get; set; }

        /// <summary>
        /// Gets or Sets EnableGiphy
        /// </summary>
        [DataMember(Name = "enableGiphy", EmitDefaultValue = false)]
        public bool EnableGiphy { get; set; }

        /// <summary>
        /// Gets or Sets EnableStickersAndMemes
        /// </summary>
        [DataMember(Name = "enableStickersAndMemes", EmitDefaultValue = false)]
        public bool EnableStickersAndMemes { get; set; }

        /// <summary>
        /// Gets or Sets EnableCustomMemes
        /// </summary>
        [DataMember(Name = "enableCustomMemes", EmitDefaultValue = false)]
        public bool EnableCustomMemes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestTeamsSettings {\n");
            sb.Append("  AllowMembersCreateUpdateChannels: ").Append(AllowMembersCreateUpdateChannels).Append("\n");
            sb.Append("  AllowMembersCreatePrivateChannels: ").Append(AllowMembersCreatePrivateChannels).Append("\n");
            sb.Append("  AllowMemberDeleteRestoreChannels: ").Append(AllowMemberDeleteRestoreChannels).Append("\n");
            sb.Append("  AllowMembersAddRemoveApps: ").Append(AllowMembersAddRemoveApps).Append("\n");
            sb.Append("  AllowMembersCreateUpdateRemoveTabs: ").Append(AllowMembersCreateUpdateRemoveTabs).Append("\n");
            sb.Append("  AllowMembersCreateUpdateRemoveConnections: ").Append(AllowMembersCreateUpdateRemoveConnections).Append("\n");
            sb.Append("  AllowMembersDeleteMessages: ").Append(AllowMembersDeleteMessages).Append("\n");
            sb.Append("  AllowMembersEditMessages: ").Append(AllowMembersEditMessages).Append("\n");
            sb.Append("  AllowGuestsCreateUpdateChannels: ").Append(AllowGuestsCreateUpdateChannels).Append("\n");
            sb.Append("  AllowGuestsDeleteChannels: ").Append(AllowGuestsDeleteChannels).Append("\n");
            sb.Append("  AllowMentionsTeam: ").Append(AllowMentionsTeam).Append("\n");
            sb.Append("  AllowMentionsChannel: ").Append(AllowMentionsChannel).Append("\n");
            sb.Append("  EnableGiphy: ").Append(EnableGiphy).Append("\n");
            sb.Append("  EnableStickersAndMemes: ").Append(EnableStickersAndMemes).Append("\n");
            sb.Append("  EnableCustomMemes: ").Append(EnableCustomMemes).Append("\n");
            sb.Append("  GiphyRatingType: ").Append(GiphyRatingType).Append("\n");
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
            return this.Equals(input as RequestTeamsSettings);
        }

        /// <summary>
        /// Returns true if RequestTeamsSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestTeamsSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestTeamsSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowMembersCreateUpdateChannels == input.AllowMembersCreateUpdateChannels ||
                    this.AllowMembersCreateUpdateChannels.Equals(input.AllowMembersCreateUpdateChannels)
                ) && 
                (
                    this.AllowMembersCreatePrivateChannels == input.AllowMembersCreatePrivateChannels ||
                    this.AllowMembersCreatePrivateChannels.Equals(input.AllowMembersCreatePrivateChannels)
                ) && 
                (
                    this.AllowMemberDeleteRestoreChannels == input.AllowMemberDeleteRestoreChannels ||
                    this.AllowMemberDeleteRestoreChannels.Equals(input.AllowMemberDeleteRestoreChannels)
                ) && 
                (
                    this.AllowMembersAddRemoveApps == input.AllowMembersAddRemoveApps ||
                    this.AllowMembersAddRemoveApps.Equals(input.AllowMembersAddRemoveApps)
                ) && 
                (
                    this.AllowMembersCreateUpdateRemoveTabs == input.AllowMembersCreateUpdateRemoveTabs ||
                    this.AllowMembersCreateUpdateRemoveTabs.Equals(input.AllowMembersCreateUpdateRemoveTabs)
                ) && 
                (
                    this.AllowMembersCreateUpdateRemoveConnections == input.AllowMembersCreateUpdateRemoveConnections ||
                    this.AllowMembersCreateUpdateRemoveConnections.Equals(input.AllowMembersCreateUpdateRemoveConnections)
                ) && 
                (
                    this.AllowMembersDeleteMessages == input.AllowMembersDeleteMessages ||
                    this.AllowMembersDeleteMessages.Equals(input.AllowMembersDeleteMessages)
                ) && 
                (
                    this.AllowMembersEditMessages == input.AllowMembersEditMessages ||
                    this.AllowMembersEditMessages.Equals(input.AllowMembersEditMessages)
                ) && 
                (
                    this.AllowGuestsCreateUpdateChannels == input.AllowGuestsCreateUpdateChannels ||
                    this.AllowGuestsCreateUpdateChannels.Equals(input.AllowGuestsCreateUpdateChannels)
                ) && 
                (
                    this.AllowGuestsDeleteChannels == input.AllowGuestsDeleteChannels ||
                    this.AllowGuestsDeleteChannels.Equals(input.AllowGuestsDeleteChannels)
                ) && 
                (
                    this.AllowMentionsTeam == input.AllowMentionsTeam ||
                    this.AllowMentionsTeam.Equals(input.AllowMentionsTeam)
                ) && 
                (
                    this.AllowMentionsChannel == input.AllowMentionsChannel ||
                    this.AllowMentionsChannel.Equals(input.AllowMentionsChannel)
                ) && 
                (
                    this.EnableGiphy == input.EnableGiphy ||
                    this.EnableGiphy.Equals(input.EnableGiphy)
                ) && 
                (
                    this.EnableStickersAndMemes == input.EnableStickersAndMemes ||
                    this.EnableStickersAndMemes.Equals(input.EnableStickersAndMemes)
                ) && 
                (
                    this.EnableCustomMemes == input.EnableCustomMemes ||
                    this.EnableCustomMemes.Equals(input.EnableCustomMemes)
                ) && 
                (
                    this.GiphyRatingType == input.GiphyRatingType ||
                    this.GiphyRatingType.Equals(input.GiphyRatingType)
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
                hashCode = hashCode * 59 + this.AllowMembersCreateUpdateChannels.GetHashCode();
                hashCode = hashCode * 59 + this.AllowMembersCreatePrivateChannels.GetHashCode();
                hashCode = hashCode * 59 + this.AllowMemberDeleteRestoreChannels.GetHashCode();
                hashCode = hashCode * 59 + this.AllowMembersAddRemoveApps.GetHashCode();
                hashCode = hashCode * 59 + this.AllowMembersCreateUpdateRemoveTabs.GetHashCode();
                hashCode = hashCode * 59 + this.AllowMembersCreateUpdateRemoveConnections.GetHashCode();
                hashCode = hashCode * 59 + this.AllowMembersDeleteMessages.GetHashCode();
                hashCode = hashCode * 59 + this.AllowMembersEditMessages.GetHashCode();
                hashCode = hashCode * 59 + this.AllowGuestsCreateUpdateChannels.GetHashCode();
                hashCode = hashCode * 59 + this.AllowGuestsDeleteChannels.GetHashCode();
                hashCode = hashCode * 59 + this.AllowMentionsTeam.GetHashCode();
                hashCode = hashCode * 59 + this.AllowMentionsChannel.GetHashCode();
                hashCode = hashCode * 59 + this.EnableGiphy.GetHashCode();
                hashCode = hashCode * 59 + this.EnableStickersAndMemes.GetHashCode();
                hashCode = hashCode * 59 + this.EnableCustomMemes.GetHashCode();
                hashCode = hashCode * 59 + this.GiphyRatingType.GetHashCode();
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
