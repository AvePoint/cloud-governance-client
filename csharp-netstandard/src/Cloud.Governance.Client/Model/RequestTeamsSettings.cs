

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
    /// Teams settings model in request
    /// </summary>
    [DataContract(Name = "RequestTeamsSettings")]
    public partial class RequestTeamsSettings : IEquatable<RequestTeamsSettings>, IValidatableObject
    {
        /// <summary>
        /// Set the gihpy type settings.
        /// </summary>
        /// <value>Set the gihpy type settings.</value>
        [DataMember(Name = "giphyRatingType", EmitDefaultValue = false)]
        public GiphyRatingType? GiphyRatingType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestTeamsSettings" /> class.
        /// </summary>
        /// <param name="allowMembersCreateUpdateChannels">Whether to allow team members to create and update channels. (default to false).</param>
        /// <param name="allowMembersCreatePrivateChannels">Whether to allow members to create private channels. (default to false).</param>
        /// <param name="allowMemberDeleteRestoreChannels">Whether to allow members to delete and restore channels. (default to false).</param>
        /// <param name="allowMembersAddRemoveApps">Whether to allow members to add and remove apps. (default to false).</param>
        /// <param name="allowMembersCreateUpdateRemoveTabs">Whether to allow members to create, update, and remove tabs. (default to false).</param>
        /// <param name="allowMembersCreateUpdateRemoveConnections">Whether to allow members to create, update, and remove connectors. (default to false).</param>
        /// <param name="allowMembersDeleteMessages">Whether to allow members to delete their messages. (default to false).</param>
        /// <param name="allowMembersEditMessages">Whether to allow members to edit their messages. (default to false).</param>
        /// <param name="allowGuestsCreateUpdateChannels">Whether to allow guests to create and update channels. (default to false).</param>
        /// <param name="allowGuestsDeleteChannels">Whether to allow guests to delete channels. (default to false).</param>
        /// <param name="allowMentionsTeam">Whether to show members the option to @team or @[team name] (this will send a notification to everyone on the team). (default to false).</param>
        /// <param name="allowMentionsChannel">Whether to show members the option to @channel or @[channel name] (this will send a notification to everyone who has favorited the channel being mentioned). (default to false).</param>
        /// <param name="enableGiphy">Whether to enable giphy for the team. (default to false).</param>
        /// <param name="enableStickersAndMemes">Whether to enable stickers and memes. (default to false).</param>
        /// <param name="enableCustomMemes">Whether to allow memes to be uploaded. (default to false).</param>
        /// <param name="giphyRatingType">Set the gihpy type settings..</param>
        public RequestTeamsSettings(bool allowMembersCreateUpdateChannels = false, bool allowMembersCreatePrivateChannels = false, bool allowMemberDeleteRestoreChannels = false, bool allowMembersAddRemoveApps = false, bool allowMembersCreateUpdateRemoveTabs = false, bool allowMembersCreateUpdateRemoveConnections = false, bool allowMembersDeleteMessages = false, bool allowMembersEditMessages = false, bool allowGuestsCreateUpdateChannels = false, bool allowGuestsDeleteChannels = false, bool allowMentionsTeam = false, bool allowMentionsChannel = false, bool enableGiphy = false, bool enableStickersAndMemes = false, bool enableCustomMemes = false, GiphyRatingType? giphyRatingType = default(GiphyRatingType?))
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
        /// Whether to allow team members to create and update channels.
        /// </summary>
        /// <value>Whether to allow team members to create and update channels.</value>
        [DataMember(Name = "allowMembersCreateUpdateChannels", EmitDefaultValue = false)]
        public bool AllowMembersCreateUpdateChannels { get; set; }

        /// <summary>
        /// Whether to allow members to create private channels.
        /// </summary>
        /// <value>Whether to allow members to create private channels.</value>
        [DataMember(Name = "allowMembersCreatePrivateChannels", EmitDefaultValue = false)]
        public bool AllowMembersCreatePrivateChannels { get; set; }

        /// <summary>
        /// Whether to allow members to delete and restore channels.
        /// </summary>
        /// <value>Whether to allow members to delete and restore channels.</value>
        [DataMember(Name = "allowMemberDeleteRestoreChannels", EmitDefaultValue = false)]
        public bool AllowMemberDeleteRestoreChannels { get; set; }

        /// <summary>
        /// Whether to allow members to add and remove apps.
        /// </summary>
        /// <value>Whether to allow members to add and remove apps.</value>
        [DataMember(Name = "allowMembersAddRemoveApps", EmitDefaultValue = false)]
        public bool AllowMembersAddRemoveApps { get; set; }

        /// <summary>
        /// Whether to allow members to create, update, and remove tabs.
        /// </summary>
        /// <value>Whether to allow members to create, update, and remove tabs.</value>
        [DataMember(Name = "allowMembersCreateUpdateRemoveTabs", EmitDefaultValue = false)]
        public bool AllowMembersCreateUpdateRemoveTabs { get; set; }

        /// <summary>
        /// Whether to allow members to create, update, and remove connectors.
        /// </summary>
        /// <value>Whether to allow members to create, update, and remove connectors.</value>
        [DataMember(Name = "allowMembersCreateUpdateRemoveConnections", EmitDefaultValue = false)]
        public bool AllowMembersCreateUpdateRemoveConnections { get; set; }

        /// <summary>
        /// Whether to allow members to delete their messages.
        /// </summary>
        /// <value>Whether to allow members to delete their messages.</value>
        [DataMember(Name = "allowMembersDeleteMessages", EmitDefaultValue = false)]
        public bool AllowMembersDeleteMessages { get; set; }

        /// <summary>
        /// Whether to allow members to edit their messages.
        /// </summary>
        /// <value>Whether to allow members to edit their messages.</value>
        [DataMember(Name = "allowMembersEditMessages", EmitDefaultValue = false)]
        public bool AllowMembersEditMessages { get; set; }

        /// <summary>
        /// Whether to allow guests to create and update channels.
        /// </summary>
        /// <value>Whether to allow guests to create and update channels.</value>
        [DataMember(Name = "allowGuestsCreateUpdateChannels", EmitDefaultValue = false)]
        public bool AllowGuestsCreateUpdateChannels { get; set; }

        /// <summary>
        /// Whether to allow guests to delete channels.
        /// </summary>
        /// <value>Whether to allow guests to delete channels.</value>
        [DataMember(Name = "allowGuestsDeleteChannels", EmitDefaultValue = false)]
        public bool AllowGuestsDeleteChannels { get; set; }

        /// <summary>
        /// Whether to show members the option to @team or @[team name] (this will send a notification to everyone on the team).
        /// </summary>
        /// <value>Whether to show members the option to @team or @[team name] (this will send a notification to everyone on the team).</value>
        [DataMember(Name = "allowMentionsTeam", EmitDefaultValue = false)]
        public bool AllowMentionsTeam { get; set; }

        /// <summary>
        /// Whether to show members the option to @channel or @[channel name] (this will send a notification to everyone who has favorited the channel being mentioned).
        /// </summary>
        /// <value>Whether to show members the option to @channel or @[channel name] (this will send a notification to everyone who has favorited the channel being mentioned).</value>
        [DataMember(Name = "allowMentionsChannel", EmitDefaultValue = false)]
        public bool AllowMentionsChannel { get; set; }

        /// <summary>
        /// Whether to enable giphy for the team.
        /// </summary>
        /// <value>Whether to enable giphy for the team.</value>
        [DataMember(Name = "enableGiphy", EmitDefaultValue = false)]
        public bool EnableGiphy { get; set; }

        /// <summary>
        /// Whether to enable stickers and memes.
        /// </summary>
        /// <value>Whether to enable stickers and memes.</value>
        [DataMember(Name = "enableStickersAndMemes", EmitDefaultValue = false)]
        public bool EnableStickersAndMemes { get; set; }

        /// <summary>
        /// Whether to allow memes to be uploaded.
        /// </summary>
        /// <value>Whether to allow memes to be uploaded.</value>
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
