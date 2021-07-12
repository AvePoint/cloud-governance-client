

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
    /// YammerGroupServiceSettings
    /// </summary>
    [DataContract(Name = "YammerGroupServiceSettings")]
    public partial class YammerGroupServiceSettings : IEquatable<YammerGroupServiceSettings>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets CreateNewGroupAssignBy
        /// </summary>
        [DataMember(Name = "createNewGroupAssignBy", EmitDefaultValue = false)]
        public AssignBy? CreateNewGroupAssignBy { get; set; }
        /// <summary>
        /// Yammer community privacy type
        /// </summary>
        /// <value>Yammer community privacy type</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public YammerGroupType? Type { get; set; }
        /// <summary>
        /// Set who can view Yammer community content. Whether to allow every user in the Yammer network to view the community content or allow users approved by community members to view the community content.
        /// </summary>
        /// <value>Set who can view Yammer community content. Whether to allow every user in the Yammer network to view the community content or allow users approved by community members to view the community content.</value>
        [DataMember(Name = "joinType", EmitDefaultValue = false)]
        public YammerGroupJoinType? JoinType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="YammerGroupServiceSettings" /> class.
        /// </summary>
        /// <param name="networkId">networkId.</param>
        /// <param name="allowCreate">allowCreate (default to false).</param>
        /// <param name="allowReuseExisting">allowReuseExisting (default to false).</param>
        /// <param name="enabled">enabled (default to false).</param>
        /// <param name="createNewGroupAssignBy">createNewGroupAssignBy.</param>
        /// <param name="nameOrId">Yammer community name or ID.</param>
        /// <param name="description">Yammer community description.</param>
        /// <param name="type">Yammer community privacy type.</param>
        /// <param name="joinType">Set who can view Yammer community content. Whether to allow every user in the Yammer network to view the community content or allow users approved by community members to view the community content..</param>
        /// <param name="isListInDirectory">Whether the Yammer community is associated with a Microsoft 365 Group. (default to false).</param>
        /// <param name="isGroupAlreadyExisted">Whether the Yammer community already exists. (default to false).</param>
        public YammerGroupServiceSettings(string networkId = default(string), bool allowCreate = false, bool allowReuseExisting = false, bool enabled = false, AssignBy? createNewGroupAssignBy = default(AssignBy?), string nameOrId = default(string), string description = default(string), YammerGroupType? type = default(YammerGroupType?), YammerGroupJoinType? joinType = default(YammerGroupJoinType?), bool isListInDirectory = false, bool isGroupAlreadyExisted = false)
        {
            this.NetworkId = networkId;
            this.AllowCreate = allowCreate;
            this.AllowReuseExisting = allowReuseExisting;
            this.Enabled = enabled;
            this.CreateNewGroupAssignBy = createNewGroupAssignBy;
            this.NameOrId = nameOrId;
            this.Description = description;
            this.Type = type;
            this.JoinType = joinType;
            this.IsListInDirectory = isListInDirectory;
            this.IsGroupAlreadyExisted = isGroupAlreadyExisted;
        }

        /// <summary>
        /// Gets or Sets NetworkId
        /// </summary>
        [DataMember(Name = "networkId", EmitDefaultValue = true)]
        public string NetworkId { get; set; }

        /// <summary>
        /// Gets or Sets AllowCreate
        /// </summary>
        [DataMember(Name = "allowCreate", EmitDefaultValue = false)]
        public bool AllowCreate { get; set; }

        /// <summary>
        /// Gets or Sets AllowReuseExisting
        /// </summary>
        [DataMember(Name = "allowReuseExisting", EmitDefaultValue = false)]
        public bool AllowReuseExisting { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Yammer community name or ID
        /// </summary>
        /// <value>Yammer community name or ID</value>
        [DataMember(Name = "nameOrId", EmitDefaultValue = true)]
        public string NameOrId { get; set; }

        /// <summary>
        /// Yammer community description
        /// </summary>
        /// <value>Yammer community description</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Whether the Yammer community is associated with a Microsoft 365 Group.
        /// </summary>
        /// <value>Whether the Yammer community is associated with a Microsoft 365 Group.</value>
        [DataMember(Name = "isListInDirectory", EmitDefaultValue = false)]
        public bool IsListInDirectory { get; set; }

        /// <summary>
        /// Whether the Yammer community already exists.
        /// </summary>
        /// <value>Whether the Yammer community already exists.</value>
        [DataMember(Name = "isGroupAlreadyExisted", EmitDefaultValue = false)]
        public bool IsGroupAlreadyExisted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class YammerGroupServiceSettings {\n");
            sb.Append("  NetworkId: ").Append(NetworkId).Append("\n");
            sb.Append("  AllowCreate: ").Append(AllowCreate).Append("\n");
            sb.Append("  AllowReuseExisting: ").Append(AllowReuseExisting).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  CreateNewGroupAssignBy: ").Append(CreateNewGroupAssignBy).Append("\n");
            sb.Append("  NameOrId: ").Append(NameOrId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  JoinType: ").Append(JoinType).Append("\n");
            sb.Append("  IsListInDirectory: ").Append(IsListInDirectory).Append("\n");
            sb.Append("  IsGroupAlreadyExisted: ").Append(IsGroupAlreadyExisted).Append("\n");
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
            return this.Equals(input as YammerGroupServiceSettings);
        }

        /// <summary>
        /// Returns true if YammerGroupServiceSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of YammerGroupServiceSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(YammerGroupServiceSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NetworkId == input.NetworkId ||
                    (this.NetworkId != null &&
                    this.NetworkId.Equals(input.NetworkId))
                ) && 
                (
                    this.AllowCreate == input.AllowCreate ||
                    this.AllowCreate.Equals(input.AllowCreate)
                ) && 
                (
                    this.AllowReuseExisting == input.AllowReuseExisting ||
                    this.AllowReuseExisting.Equals(input.AllowReuseExisting)
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.CreateNewGroupAssignBy == input.CreateNewGroupAssignBy ||
                    this.CreateNewGroupAssignBy.Equals(input.CreateNewGroupAssignBy)
                ) && 
                (
                    this.NameOrId == input.NameOrId ||
                    (this.NameOrId != null &&
                    this.NameOrId.Equals(input.NameOrId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.JoinType == input.JoinType ||
                    this.JoinType.Equals(input.JoinType)
                ) && 
                (
                    this.IsListInDirectory == input.IsListInDirectory ||
                    this.IsListInDirectory.Equals(input.IsListInDirectory)
                ) && 
                (
                    this.IsGroupAlreadyExisted == input.IsGroupAlreadyExisted ||
                    this.IsGroupAlreadyExisted.Equals(input.IsGroupAlreadyExisted)
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
                if (this.NetworkId != null)
                    hashCode = hashCode * 59 + this.NetworkId.GetHashCode();
                hashCode = hashCode * 59 + this.AllowCreate.GetHashCode();
                hashCode = hashCode * 59 + this.AllowReuseExisting.GetHashCode();
                hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                hashCode = hashCode * 59 + this.CreateNewGroupAssignBy.GetHashCode();
                if (this.NameOrId != null)
                    hashCode = hashCode * 59 + this.NameOrId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.JoinType.GetHashCode();
                hashCode = hashCode * 59 + this.IsListInDirectory.GetHashCode();
                hashCode = hashCode * 59 + this.IsGroupAlreadyExisted.GetHashCode();
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
