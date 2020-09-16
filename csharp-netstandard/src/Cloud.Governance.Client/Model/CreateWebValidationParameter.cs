

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
    /// CreateWebValidationParameter
    /// </summary>
    [DataContract(Name = "CreateWebValidationParameter")]
    public partial class CreateWebValidationParameter : IEquatable<CreateWebValidationParameter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebValidationParameter" /> class.
        /// </summary>
        /// <param name="parentUrl">parentUrl.</param>
        /// <param name="uri">uri.</param>
        /// <param name="ignoreLock">ignoreLock.</param>
        /// <param name="isEditTask">isEditTask.</param>
        /// <param name="isFromQuestionnaire">isFromQuestionnaire.</param>
        public CreateWebValidationParameter(string parentUrl = default(string), string uri = default(string), bool ignoreLock = default(bool), bool isEditTask = default(bool), bool isFromQuestionnaire = default(bool))
        {
            this.ParentUrl = parentUrl;
            this.Uri = uri;
            this.IgnoreLock = ignoreLock;
            this.IsEditTask = isEditTask;
            this.IsFromQuestionnaire = isFromQuestionnaire;
        }

        /// <summary>
        /// Gets or Sets ParentUrl
        /// </summary>
        [DataMember(Name = "parentUrl", EmitDefaultValue = true)]
        public string ParentUrl { get; set; }

        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name = "uri", EmitDefaultValue = true)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or Sets IgnoreLock
        /// </summary>
        [DataMember(Name = "ignoreLock", EmitDefaultValue = false)]
        public bool IgnoreLock { get; set; }

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
            sb.Append("class CreateWebValidationParameter {\n");
            sb.Append("  ParentUrl: ").Append(ParentUrl).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  IgnoreLock: ").Append(IgnoreLock).Append("\n");
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
            return this.Equals(input as CreateWebValidationParameter);
        }

        /// <summary>
        /// Returns true if CreateWebValidationParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateWebValidationParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateWebValidationParameter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ParentUrl == input.ParentUrl ||
                    (this.ParentUrl != null &&
                    this.ParentUrl.Equals(input.ParentUrl))
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.IgnoreLock == input.IgnoreLock ||
                    this.IgnoreLock.Equals(input.IgnoreLock)
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
                if (this.ParentUrl != null)
                    hashCode = hashCode * 59 + this.ParentUrl.GetHashCode();
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                hashCode = hashCode * 59 + this.IgnoreLock.GetHashCode();
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
