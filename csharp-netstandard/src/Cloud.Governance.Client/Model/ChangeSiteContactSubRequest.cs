

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
    /// ChangeSiteContactSubRequest
    /// </summary>
    [DataContract(Name = "ChangeSiteContactSubRequest")]
    public partial class ChangeSiteContactSubRequest : IEquatable<ChangeSiteContactSubRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ProgressStatus
        /// </summary>
        [DataMember(Name = "progressStatus", EmitDefaultValue = false)]
        public ApiRequestProgressStatus? ProgressStatus { get; set; }

        /// <summary>
        /// Returns false as ProgressStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProgressStatus()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeSiteContactSubRequest" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="assignTo">assignTo.</param>
        /// <param name="reason">reason.</param>
        /// <param name="adminContactSettings">adminContactSettings.</param>
        public ChangeSiteContactSubRequest(Guid id = default(Guid), List<ApiUser> assignTo = default(List<ApiUser>), string reason = default(string), ChangeContactByUrlSetting adminContactSettings = default(ChangeContactByUrlSetting))
        {
            this.Id = id;
            this.AssignTo = assignTo;
            this.Reason = reason;
            this.AdminContactSettings = adminContactSettings;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets AssignTo
        /// </summary>
        [DataMember(Name = "assignTo", EmitDefaultValue = true)]
        public List<ApiUser> AssignTo { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name = "reason", EmitDefaultValue = true)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public int Status { get; private set; }

        /// <summary>
        /// Returns false as Status should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStatus()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets StatusDescription
        /// </summary>
        [DataMember(Name = "statusDescription", EmitDefaultValue = true)]
        public string StatusDescription { get; private set; }

        /// <summary>
        /// Returns false as StatusDescription should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStatusDescription()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets AdminContactSettings
        /// </summary>
        [DataMember(Name = "adminContactSettings", EmitDefaultValue = true)]
        public ChangeContactByUrlSetting AdminContactSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeSiteContactSubRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AssignTo: ").Append(AssignTo).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  AdminContactSettings: ").Append(AdminContactSettings).Append("\n");
            sb.Append("  ProgressStatus: ").Append(ProgressStatus).Append("\n");
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
            return this.Equals(input as ChangeSiteContactSubRequest);
        }

        /// <summary>
        /// Returns true if ChangeSiteContactSubRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeSiteContactSubRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeSiteContactSubRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.AssignTo == input.AssignTo ||
                    this.AssignTo != null &&
                    input.AssignTo != null &&
                    this.AssignTo.SequenceEqual(input.AssignTo)
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.StatusDescription == input.StatusDescription ||
                    (this.StatusDescription != null &&
                    this.StatusDescription.Equals(input.StatusDescription))
                ) && 
                (
                    this.AdminContactSettings == input.AdminContactSettings ||
                    (this.AdminContactSettings != null &&
                    this.AdminContactSettings.Equals(input.AdminContactSettings))
                ) && 
                (
                    this.ProgressStatus == input.ProgressStatus ||
                    this.ProgressStatus.Equals(input.ProgressStatus)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AssignTo != null)
                    hashCode = hashCode * 59 + this.AssignTo.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusDescription != null)
                    hashCode = hashCode * 59 + this.StatusDescription.GetHashCode();
                if (this.AdminContactSettings != null)
                    hashCode = hashCode * 59 + this.AdminContactSettings.GetHashCode();
                hashCode = hashCode * 59 + this.ProgressStatus.GetHashCode();
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
