

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
    /// YammerGroupRequestSettings
    /// </summary>
    [DataContract(Name = "YammerGroupRequestSettings")]
    public partial class YammerGroupRequestSettings : IEquatable<YammerGroupRequestSettings>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public YammerGroupType? Type { get; set; }
        /// <summary>
        /// Gets or Sets JoinType
        /// </summary>
        [DataMember(Name = "joinType", EmitDefaultValue = false)]
        public YammerGroupJoinType? JoinType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="YammerGroupRequestSettings" /> class.
        /// </summary>
        /// <param name="nameOrId">nameOrId.</param>
        /// <param name="description">description.</param>
        /// <param name="type">type.</param>
        /// <param name="joinType">joinType.</param>
        /// <param name="isListInDirectory">isListInDirectory.</param>
        /// <param name="isGroupAlreadyExisted">isGroupAlreadyExisted.</param>
        public YammerGroupRequestSettings(string nameOrId = default(string), string description = default(string), YammerGroupType? type = default(YammerGroupType?), YammerGroupJoinType? joinType = default(YammerGroupJoinType?), bool isListInDirectory = default(bool), bool isGroupAlreadyExisted = default(bool))
        {
            this.NameOrId = nameOrId;
            this.Description = description;
            this.Type = type;
            this.JoinType = joinType;
            this.IsListInDirectory = isListInDirectory;
            this.IsGroupAlreadyExisted = isGroupAlreadyExisted;
        }

        /// <summary>
        /// Gets or Sets NameOrId
        /// </summary>
        [DataMember(Name = "nameOrId", EmitDefaultValue = true)]
        public string NameOrId { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets IsListInDirectory
        /// </summary>
        [DataMember(Name = "isListInDirectory", EmitDefaultValue = false)]
        public bool IsListInDirectory { get; set; }

        /// <summary>
        /// Gets or Sets IsGroupAlreadyExisted
        /// </summary>
        [DataMember(Name = "isGroupAlreadyExisted", EmitDefaultValue = false)]
        public bool IsGroupAlreadyExisted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class YammerGroupRequestSettings {\n");
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
            return this.Equals(input as YammerGroupRequestSettings);
        }

        /// <summary>
        /// Returns true if YammerGroupRequestSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of YammerGroupRequestSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(YammerGroupRequestSettings input)
        {
            if (input == null)
                return false;

            return 
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
