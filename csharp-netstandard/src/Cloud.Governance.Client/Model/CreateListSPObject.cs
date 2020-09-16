

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
    /// CreateListSPObject
    /// </summary>
    [DataContract(Name = "CreateListSPObject")]
    public partial class CreateListSPObject : IEquatable<CreateListSPObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateListSPObject" /> class.
        /// </summary>
        /// <param name="parentUrl">parentUrl.</param>
        /// <param name="siteUrl">siteUrl.</param>
        /// <param name="siteId">siteId.</param>
        public CreateListSPObject(string parentUrl = default(string), string siteUrl = default(string), Guid siteId = default(Guid))
        {
            this.ParentUrl = parentUrl;
            this.SiteUrl = siteUrl;
            this.SiteId = siteId;
        }

        /// <summary>
        /// Gets or Sets ParentUrl
        /// </summary>
        [DataMember(Name = "parentUrl", EmitDefaultValue = true)]
        public string ParentUrl { get; set; }

        /// <summary>
        /// Gets or Sets SiteUrl
        /// </summary>
        [DataMember(Name = "siteUrl", EmitDefaultValue = true)]
        public string SiteUrl { get; set; }

        /// <summary>
        /// Gets or Sets SiteId
        /// </summary>
        [DataMember(Name = "siteId", EmitDefaultValue = false)]
        public Guid SiteId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateListSPObject {\n");
            sb.Append("  ParentUrl: ").Append(ParentUrl).Append("\n");
            sb.Append("  SiteUrl: ").Append(SiteUrl).Append("\n");
            sb.Append("  SiteId: ").Append(SiteId).Append("\n");
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
            return this.Equals(input as CreateListSPObject);
        }

        /// <summary>
        /// Returns true if CreateListSPObject instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateListSPObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateListSPObject input)
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
                    this.SiteUrl == input.SiteUrl ||
                    (this.SiteUrl != null &&
                    this.SiteUrl.Equals(input.SiteUrl))
                ) && 
                (
                    this.SiteId == input.SiteId ||
                    (this.SiteId != null &&
                    this.SiteId.Equals(input.SiteId))
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
                if (this.SiteUrl != null)
                    hashCode = hashCode * 59 + this.SiteUrl.GetHashCode();
                if (this.SiteId != null)
                    hashCode = hashCode * 59 + this.SiteId.GetHashCode();
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
