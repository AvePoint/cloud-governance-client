

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
    /// ListTemplate
    /// </summary>
    [DataContract(Name = "ListTemplate")]
    public partial class ListTemplate : IEquatable<ListTemplate>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public SPListTemplateType? Type { get; set; }
        /// <summary>
        /// Gets or Sets BaseType
        /// </summary>
        [DataMember(Name = "baseType", EmitDefaultValue = false)]
        public SPBaseType? BaseType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListTemplate" /> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="description">description.</param>
        /// <param name="type">type.</param>
        /// <param name="baseType">baseType.</param>
        /// <param name="name">name.</param>
        /// <param name="isCustomTemplate">isCustomTemplate (default to false).</param>
        public ListTemplate(string title = default(string), string description = default(string), SPListTemplateType? type = default(SPListTemplateType?), SPBaseType? baseType = default(SPBaseType?), string name = default(string), bool isCustomTemplate = false)
        {
            this.Title = title;
            this.Description = description;
            this.Type = type;
            this.BaseType = baseType;
            this.Name = name;
            this.IsCustomTemplate = isCustomTemplate;
        }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets IsCustomTemplate
        /// </summary>
        [DataMember(Name = "isCustomTemplate", EmitDefaultValue = false)]
        public bool IsCustomTemplate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTemplate {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  BaseType: ").Append(BaseType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsCustomTemplate: ").Append(IsCustomTemplate).Append("\n");
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
            return this.Equals(input as ListTemplate);
        }

        /// <summary>
        /// Returns true if ListTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of ListTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListTemplate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                    this.BaseType == input.BaseType ||
                    this.BaseType.Equals(input.BaseType)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IsCustomTemplate == input.IsCustomTemplate ||
                    this.IsCustomTemplate.Equals(input.IsCustomTemplate)
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.BaseType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.IsCustomTemplate.GetHashCode();
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
