

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
    /// Group links model
    /// </summary>
    [DataContract(Name = "GroupLinks")]
    public partial class GroupLinks : IEquatable<GroupLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupLinks" /> class.
        /// </summary>
        /// <param name="groupSiteLink">Group team site link.</param>
        /// <param name="groupPlannerLink">Planner link.</param>
        /// <param name="groupFilesLink">Files link.</param>
        /// <param name="groupConversationsLink">Conversations link.</param>
        /// <param name="groupNotebookLink">Notebook link.</param>
        /// <param name="yammerGroupLink">Yammer community link.</param>
        public GroupLinks(string groupSiteLink = default(string), string groupPlannerLink = default(string), string groupFilesLink = default(string), string groupConversationsLink = default(string), string groupNotebookLink = default(string), string yammerGroupLink = default(string))
        {
            this.GroupSiteLink = groupSiteLink;
            this.GroupPlannerLink = groupPlannerLink;
            this.GroupFilesLink = groupFilesLink;
            this.GroupConversationsLink = groupConversationsLink;
            this.GroupNotebookLink = groupNotebookLink;
            this.YammerGroupLink = yammerGroupLink;
        }

        /// <summary>
        /// Group team site link
        /// </summary>
        /// <value>Group team site link</value>
        [DataMember(Name = "groupSiteLink", EmitDefaultValue = true)]
        public string GroupSiteLink { get; set; }

        /// <summary>
        /// Planner link
        /// </summary>
        /// <value>Planner link</value>
        [DataMember(Name = "groupPlannerLink", EmitDefaultValue = true)]
        public string GroupPlannerLink { get; set; }

        /// <summary>
        /// Files link
        /// </summary>
        /// <value>Files link</value>
        [DataMember(Name = "groupFilesLink", EmitDefaultValue = true)]
        public string GroupFilesLink { get; set; }

        /// <summary>
        /// Conversations link
        /// </summary>
        /// <value>Conversations link</value>
        [DataMember(Name = "groupConversationsLink", EmitDefaultValue = true)]
        public string GroupConversationsLink { get; set; }

        /// <summary>
        /// Notebook link
        /// </summary>
        /// <value>Notebook link</value>
        [DataMember(Name = "groupNotebookLink", EmitDefaultValue = true)]
        public string GroupNotebookLink { get; set; }

        /// <summary>
        /// Yammer community link
        /// </summary>
        /// <value>Yammer community link</value>
        [DataMember(Name = "yammerGroupLink", EmitDefaultValue = true)]
        public string YammerGroupLink { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupLinks {\n");
            sb.Append("  GroupSiteLink: ").Append(GroupSiteLink).Append("\n");
            sb.Append("  GroupPlannerLink: ").Append(GroupPlannerLink).Append("\n");
            sb.Append("  GroupFilesLink: ").Append(GroupFilesLink).Append("\n");
            sb.Append("  GroupConversationsLink: ").Append(GroupConversationsLink).Append("\n");
            sb.Append("  GroupNotebookLink: ").Append(GroupNotebookLink).Append("\n");
            sb.Append("  YammerGroupLink: ").Append(YammerGroupLink).Append("\n");
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
            return this.Equals(input as GroupLinks);
        }

        /// <summary>
        /// Returns true if GroupLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupLinks input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupSiteLink == input.GroupSiteLink ||
                    (this.GroupSiteLink != null &&
                    this.GroupSiteLink.Equals(input.GroupSiteLink))
                ) && 
                (
                    this.GroupPlannerLink == input.GroupPlannerLink ||
                    (this.GroupPlannerLink != null &&
                    this.GroupPlannerLink.Equals(input.GroupPlannerLink))
                ) && 
                (
                    this.GroupFilesLink == input.GroupFilesLink ||
                    (this.GroupFilesLink != null &&
                    this.GroupFilesLink.Equals(input.GroupFilesLink))
                ) && 
                (
                    this.GroupConversationsLink == input.GroupConversationsLink ||
                    (this.GroupConversationsLink != null &&
                    this.GroupConversationsLink.Equals(input.GroupConversationsLink))
                ) && 
                (
                    this.GroupNotebookLink == input.GroupNotebookLink ||
                    (this.GroupNotebookLink != null &&
                    this.GroupNotebookLink.Equals(input.GroupNotebookLink))
                ) && 
                (
                    this.YammerGroupLink == input.YammerGroupLink ||
                    (this.YammerGroupLink != null &&
                    this.YammerGroupLink.Equals(input.YammerGroupLink))
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
                if (this.GroupSiteLink != null)
                    hashCode = hashCode * 59 + this.GroupSiteLink.GetHashCode();
                if (this.GroupPlannerLink != null)
                    hashCode = hashCode * 59 + this.GroupPlannerLink.GetHashCode();
                if (this.GroupFilesLink != null)
                    hashCode = hashCode * 59 + this.GroupFilesLink.GetHashCode();
                if (this.GroupConversationsLink != null)
                    hashCode = hashCode * 59 + this.GroupConversationsLink.GetHashCode();
                if (this.GroupNotebookLink != null)
                    hashCode = hashCode * 59 + this.GroupNotebookLink.GetHashCode();
                if (this.YammerGroupLink != null)
                    hashCode = hashCode * 59 + this.YammerGroupLink.GetHashCode();
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
