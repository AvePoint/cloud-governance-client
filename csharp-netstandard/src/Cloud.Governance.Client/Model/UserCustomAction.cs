

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
    /// Represents a custom action associated with a Web site, or subsite.
    /// </summary>
    [DataContract(Name = "UserCustomAction")]
    public partial class UserCustomAction : IEquatable<UserCustomAction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCustomAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserCustomAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCustomAction" /> class.
        /// </summary>
        /// <param name="webFullUrl">The target subsite or site&#39;s root web url which the user custom actions added to. (required).</param>
        /// <param name="title">The display title of the custom action..</param>
        /// <param name="sequence">An implementation-specific value that determines the order of the custom action that appears on the page. (default to 0).</param>
        /// <param name="scriptSrc">The URI of a file which contains the ECMAScript to execute on the page..</param>
        /// <param name="scriptBlock">the ECMAScript to be executed when the custom action is performed..</param>
        /// <param name="name">The name of the custom action. (required).</param>
        /// <param name="url">The URL, URI, or ECMAScript (JScript, JavaScript) function associated with the action..</param>
        /// <param name="location">The location of the custom action. (required).</param>
        /// <param name="group">An implementation-specific value that determines the position of the custom action in the page.</param>
        /// <param name="imageUrl">The URL of the image associated with the custom action..</param>
        /// <param name="description">The description of the custom action..</param>
        public UserCustomAction(string webFullUrl = default(string), string title = default(string), int sequence = 0, string scriptSrc = default(string), string scriptBlock = default(string), string name = default(string), string url = default(string), string location = default(string), string group = default(string), string imageUrl = default(string), string description = default(string))
        {
            // to ensure "webFullUrl" is required (not null)
            this.WebFullUrl = webFullUrl ?? throw new ArgumentNullException("webFullUrl is a required property for UserCustomAction and cannot be null");
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for UserCustomAction and cannot be null");
            // to ensure "location" is required (not null)
            this.Location = location ?? throw new ArgumentNullException("location is a required property for UserCustomAction and cannot be null");
            this.Title = title;
            this.Sequence = sequence;
            this.ScriptSrc = scriptSrc;
            this.ScriptBlock = scriptBlock;
            this.Url = url;
            this.Group = group;
            this.ImageUrl = imageUrl;
            this.Description = description;
        }

        /// <summary>
        /// The target subsite or site&#39;s root web url which the user custom actions added to.
        /// </summary>
        /// <value>The target subsite or site&#39;s root web url which the user custom actions added to.</value>
        [DataMember(Name = "webFullUrl", IsRequired = true, EmitDefaultValue = false)]
        public string WebFullUrl { get; set; }

        /// <summary>
        /// The display title of the custom action.
        /// </summary>
        /// <value>The display title of the custom action.</value>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// An implementation-specific value that determines the order of the custom action that appears on the page.
        /// </summary>
        /// <value>An implementation-specific value that determines the order of the custom action that appears on the page.</value>
        [DataMember(Name = "sequence", EmitDefaultValue = false)]
        public int Sequence { get; set; }

        /// <summary>
        /// The URI of a file which contains the ECMAScript to execute on the page.
        /// </summary>
        /// <value>The URI of a file which contains the ECMAScript to execute on the page.</value>
        [DataMember(Name = "scriptSrc", EmitDefaultValue = true)]
        public string ScriptSrc { get; set; }

        /// <summary>
        /// the ECMAScript to be executed when the custom action is performed.
        /// </summary>
        /// <value>the ECMAScript to be executed when the custom action is performed.</value>
        [DataMember(Name = "scriptBlock", EmitDefaultValue = true)]
        public string ScriptBlock { get; set; }

        /// <summary>
        /// The name of the custom action.
        /// </summary>
        /// <value>The name of the custom action.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The URL, URI, or ECMAScript (JScript, JavaScript) function associated with the action.
        /// </summary>
        /// <value>The URL, URI, or ECMAScript (JScript, JavaScript) function associated with the action.</value>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The location of the custom action.
        /// </summary>
        /// <value>The location of the custom action.</value>
        [DataMember(Name = "location", IsRequired = true, EmitDefaultValue = false)]
        public string Location { get; set; }

        /// <summary>
        /// An implementation-specific value that determines the position of the custom action in the page
        /// </summary>
        /// <value>An implementation-specific value that determines the position of the custom action in the page</value>
        [DataMember(Name = "group", EmitDefaultValue = true)]
        public string Group { get; set; }

        /// <summary>
        /// The URL of the image associated with the custom action.
        /// </summary>
        /// <value>The URL of the image associated with the custom action.</value>
        [DataMember(Name = "imageUrl", EmitDefaultValue = true)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// The description of the custom action.
        /// </summary>
        /// <value>The description of the custom action.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserCustomAction {\n");
            sb.Append("  WebFullUrl: ").Append(WebFullUrl).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
            sb.Append("  ScriptSrc: ").Append(ScriptSrc).Append("\n");
            sb.Append("  ScriptBlock: ").Append(ScriptBlock).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as UserCustomAction);
        }

        /// <summary>
        /// Returns true if UserCustomAction instances are equal
        /// </summary>
        /// <param name="input">Instance of UserCustomAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserCustomAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WebFullUrl == input.WebFullUrl ||
                    (this.WebFullUrl != null &&
                    this.WebFullUrl.Equals(input.WebFullUrl))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Sequence == input.Sequence ||
                    this.Sequence.Equals(input.Sequence)
                ) && 
                (
                    this.ScriptSrc == input.ScriptSrc ||
                    (this.ScriptSrc != null &&
                    this.ScriptSrc.Equals(input.ScriptSrc))
                ) && 
                (
                    this.ScriptBlock == input.ScriptBlock ||
                    (this.ScriptBlock != null &&
                    this.ScriptBlock.Equals(input.ScriptBlock))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.WebFullUrl != null)
                    hashCode = hashCode * 59 + this.WebFullUrl.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                if (this.ScriptSrc != null)
                    hashCode = hashCode * 59 + this.ScriptSrc.GetHashCode();
                if (this.ScriptBlock != null)
                    hashCode = hashCode * 59 + this.ScriptBlock.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
