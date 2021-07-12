

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
    /// Site collection url model
    /// </summary>
    [DataContract(Name = "SiteUrl")]
    public partial class SiteUrl : IEquatable<SiteUrl>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SiteUrl" /> class.
        /// </summary>
        /// <param name="root">Site collection root site url.</param>
        /// <param name="managedPath">Managed path.</param>
        /// <param name="name">Site collection name.</param>
        public SiteUrl(string root = default(string), string managedPath = default(string), string name = default(string))
        {
            this.Root = root;
            this.ManagedPath = managedPath;
            this.Name = name;
        }

        /// <summary>
        /// Site collection root site url
        /// </summary>
        /// <value>Site collection root site url</value>
        [DataMember(Name = "root", EmitDefaultValue = true)]
        public string Root { get; set; }

        /// <summary>
        /// Managed path
        /// </summary>
        /// <value>Managed path</value>
        [DataMember(Name = "managedPath", EmitDefaultValue = true)]
        public string ManagedPath { get; set; }

        /// <summary>
        /// Site collection name
        /// </summary>
        /// <value>Site collection name</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SiteUrl {\n");
            sb.Append("  Root: ").Append(Root).Append("\n");
            sb.Append("  ManagedPath: ").Append(ManagedPath).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as SiteUrl);
        }

        /// <summary>
        /// Returns true if SiteUrl instances are equal
        /// </summary>
        /// <param name="input">Instance of SiteUrl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SiteUrl input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Root == input.Root ||
                    (this.Root != null &&
                    this.Root.Equals(input.Root))
                ) && 
                (
                    this.ManagedPath == input.ManagedPath ||
                    (this.ManagedPath != null &&
                    this.ManagedPath.Equals(input.ManagedPath))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Root != null)
                    hashCode = hashCode * 59 + this.Root.GetHashCode();
                if (this.ManagedPath != null)
                    hashCode = hashCode * 59 + this.ManagedPath.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
