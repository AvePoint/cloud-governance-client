

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
    /// SPNode
    /// </summary>
    [DataContract(Name = "SPNode")]
    public partial class SPNode : IEquatable<SPNode>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public NodeType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SPNode" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="fullUrl">fullUrl.</param>
        /// <param name="type">type.</param>
        /// <param name="name">name.</param>
        /// <param name="title">title.</param>
        /// <param name="isSelected">isSelected.</param>
        public SPNode(Guid id = default(Guid), string fullUrl = default(string), NodeType? type = default(NodeType?), string name = default(string), string title = default(string), bool isSelected = default(bool))
        {
            this.Id = id;
            this.FullUrl = fullUrl;
            this.Type = type;
            this.Name = name;
            this.Title = title;
            this.IsSelected = isSelected;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets FullUrl
        /// </summary>
        [DataMember(Name = "fullUrl", EmitDefaultValue = true)]
        public string FullUrl { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets IsSelected
        /// </summary>
        [DataMember(Name = "isSelected", EmitDefaultValue = false)]
        public bool IsSelected { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SPNode {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FullUrl: ").Append(FullUrl).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  IsSelected: ").Append(IsSelected).Append("\n");
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
            return this.Equals(input as SPNode);
        }

        /// <summary>
        /// Returns true if SPNode instances are equal
        /// </summary>
        /// <param name="input">Instance of SPNode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SPNode input)
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
                    this.FullUrl == input.FullUrl ||
                    (this.FullUrl != null &&
                    this.FullUrl.Equals(input.FullUrl))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.IsSelected == input.IsSelected ||
                    this.IsSelected.Equals(input.IsSelected)
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
                if (this.FullUrl != null)
                    hashCode = hashCode * 59 + this.FullUrl.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                hashCode = hashCode * 59 + this.IsSelected.GetHashCode();
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
