

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
    /// TaskComment
    /// </summary>
    [DataContract(Name = "TaskComment")]
    public partial class TaskComment : IEquatable<TaskComment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskComment" /> class.
        /// </summary>
        /// <param name="assigneeDisplayName">assigneeDisplayName.</param>
        /// <param name="commentTime">commentTime.</param>
        /// <param name="content">content.</param>
        public TaskComment(string assigneeDisplayName = default(string), DateTime commentTime = default(DateTime), string content = default(string))
        {
            this.AssigneeDisplayName = assigneeDisplayName;
            this.CommentTime = commentTime;
            this.Content = content;
        }

        /// <summary>
        /// Gets or Sets AssigneeDisplayName
        /// </summary>
        [DataMember(Name = "assigneeDisplayName", EmitDefaultValue = true)]
        public string AssigneeDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets CommentTime
        /// </summary>
        [DataMember(Name = "commentTime", EmitDefaultValue = false)]
        public DateTime CommentTime { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "content", EmitDefaultValue = true)]
        public string Content { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskComment {\n");
            sb.Append("  AssigneeDisplayName: ").Append(AssigneeDisplayName).Append("\n");
            sb.Append("  CommentTime: ").Append(CommentTime).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
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
            return this.Equals(input as TaskComment);
        }

        /// <summary>
        /// Returns true if TaskComment instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskComment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskComment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssigneeDisplayName == input.AssigneeDisplayName ||
                    (this.AssigneeDisplayName != null &&
                    this.AssigneeDisplayName.Equals(input.AssigneeDisplayName))
                ) && 
                (
                    this.CommentTime == input.CommentTime ||
                    (this.CommentTime != null &&
                    this.CommentTime.Equals(input.CommentTime))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
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
                if (this.AssigneeDisplayName != null)
                    hashCode = hashCode * 59 + this.AssigneeDisplayName.GetHashCode();
                if (this.CommentTime != null)
                    hashCode = hashCode * 59 + this.CommentTime.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
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
