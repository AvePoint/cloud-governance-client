

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
    /// QuestionAnswerResponse
    /// </summary>
    [DataContract(Name = "QuestionAnswerResponse")]
    public partial class QuestionAnswerResponse : IEquatable<QuestionAnswerResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionAnswerResponse" /> class.
        /// </summary>
        /// <param name="question">question.</param>
        /// <param name="value">value.</param>
        public QuestionAnswerResponse(string question = default(string), string value = default(string))
        {
            this.Question = question;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets Question
        /// </summary>
        [DataMember(Name = "question", EmitDefaultValue = true)]
        public string Question { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuestionAnswerResponse {\n");
            sb.Append("  Question: ").Append(Question).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as QuestionAnswerResponse);
        }

        /// <summary>
        /// Returns true if QuestionAnswerResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of QuestionAnswerResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuestionAnswerResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Question == input.Question ||
                    (this.Question != null &&
                    this.Question.Equals(input.Question))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Question != null)
                    hashCode = hashCode * 59 + this.Question.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
