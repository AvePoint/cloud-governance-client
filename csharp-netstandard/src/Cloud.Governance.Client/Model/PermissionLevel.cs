

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
    /// PermissionLevel
    /// </summary>
    [DataContract(Name = "PermissionLevel")]
    public partial class PermissionLevel : IEquatable<PermissionLevel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionLevel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="idInSharePoint">idInSharePoint.</param>
        /// <param name="name">name.</param>
        public PermissionLevel(Guid id = default(Guid), int idInSharePoint = default(int), string name = default(string))
        {
            this.Id = id;
            this.IdInSharePoint = idInSharePoint;
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets IdInSharePoint
        /// </summary>
        [DataMember(Name = "idInSharePoint", EmitDefaultValue = false)]
        public int IdInSharePoint { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; private set; }

        /// <summary>
        /// Returns false as Description should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDescription()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets IsExcluded
        /// </summary>
        [DataMember(Name = "isExcluded", EmitDefaultValue = false)]
        public bool IsExcluded { get; private set; }

        /// <summary>
        /// Returns false as IsExcluded should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsExcluded()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public int Type { get; private set; }

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
        {
            return false;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermissionLevel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdInSharePoint: ").Append(IdInSharePoint).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsExcluded: ").Append(IsExcluded).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as PermissionLevel);
        }

        /// <summary>
        /// Returns true if PermissionLevel instances are equal
        /// </summary>
        /// <param name="input">Instance of PermissionLevel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PermissionLevel input)
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
                    this.IdInSharePoint == input.IdInSharePoint ||
                    this.IdInSharePoint.Equals(input.IdInSharePoint)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IsExcluded == input.IsExcluded ||
                    this.IsExcluded.Equals(input.IsExcluded)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                hashCode = hashCode * 59 + this.IdInSharePoint.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.IsExcluded.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
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
