

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
    /// ReportActionResult
    /// </summary>
    [DataContract(Name = "ReportActionResult")]
    public partial class ReportActionResult : IEquatable<ReportActionResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportActionResult" /> class.
        /// </summary>
        /// <param name="reason">reason.</param>
        /// <param name="urlOrEmail">urlOrEmail.</param>
        /// <param name="title">title.</param>
        public ReportActionResult(string reason = default(string), string urlOrEmail = default(string), string title = default(string))
        {
            this.Reason = reason;
            this.UrlOrEmail = urlOrEmail;
            this.Title = title;
        }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name = "reason", EmitDefaultValue = true)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets UrlOrEmail
        /// </summary>
        [DataMember(Name = "urlOrEmail", EmitDefaultValue = true)]
        public string UrlOrEmail { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportActionResult {\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  UrlOrEmail: ").Append(UrlOrEmail).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as ReportActionResult);
        }

        /// <summary>
        /// Returns true if ReportActionResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportActionResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportActionResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.UrlOrEmail == input.UrlOrEmail ||
                    (this.UrlOrEmail != null &&
                    this.UrlOrEmail.Equals(input.UrlOrEmail))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.UrlOrEmail != null)
                    hashCode = hashCode * 59 + this.UrlOrEmail.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
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
