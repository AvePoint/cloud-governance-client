

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
    /// CreatePrivateChannelValidationParameter
    /// </summary>
    [DataContract(Name = "CreatePrivateChannelValidationParameter")]
    public partial class CreatePrivateChannelValidationParameter : IEquatable<CreatePrivateChannelValidationParameter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePrivateChannelValidationParameter" /> class.
        /// </summary>
        /// <param name="teamObjectId">teamObjectId.</param>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="isEditTask">isEditTask (default to false).</param>
        /// <param name="isFromQuestionnaire">isFromQuestionnaire (default to false).</param>
        public CreatePrivateChannelValidationParameter(Guid teamObjectId = default(Guid), Guid tenantId = default(Guid), bool isEditTask = false, bool isFromQuestionnaire = false)
        {
            this.TeamObjectId = teamObjectId;
            this.TenantId = tenantId;
            this.IsEditTask = isEditTask;
            this.IsFromQuestionnaire = isFromQuestionnaire;
        }

        /// <summary>
        /// Gets or Sets TeamObjectId
        /// </summary>
        [DataMember(Name = "teamObjectId", EmitDefaultValue = false)]
        public Guid TeamObjectId { get; set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public Guid TenantId { get; set; }

        /// <summary>
        /// Gets or Sets IsEditTask
        /// </summary>
        [DataMember(Name = "isEditTask", EmitDefaultValue = false)]
        public bool IsEditTask { get; set; }

        /// <summary>
        /// Gets or Sets IsFromQuestionnaire
        /// </summary>
        [DataMember(Name = "isFromQuestionnaire", EmitDefaultValue = false)]
        public bool IsFromQuestionnaire { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePrivateChannelValidationParameter {\n");
            sb.Append("  TeamObjectId: ").Append(TeamObjectId).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  IsEditTask: ").Append(IsEditTask).Append("\n");
            sb.Append("  IsFromQuestionnaire: ").Append(IsFromQuestionnaire).Append("\n");
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
            return this.Equals(input as CreatePrivateChannelValidationParameter);
        }

        /// <summary>
        /// Returns true if CreatePrivateChannelValidationParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatePrivateChannelValidationParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePrivateChannelValidationParameter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TeamObjectId == input.TeamObjectId ||
                    (this.TeamObjectId != null &&
                    this.TeamObjectId.Equals(input.TeamObjectId))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.IsEditTask == input.IsEditTask ||
                    this.IsEditTask.Equals(input.IsEditTask)
                ) && 
                (
                    this.IsFromQuestionnaire == input.IsFromQuestionnaire ||
                    this.IsFromQuestionnaire.Equals(input.IsFromQuestionnaire)
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
                if (this.TeamObjectId != null)
                    hashCode = hashCode * 59 + this.TeamObjectId.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                hashCode = hashCode * 59 + this.IsEditTask.GetHashCode();
                hashCode = hashCode * 59 + this.IsFromQuestionnaire.GetHashCode();
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
