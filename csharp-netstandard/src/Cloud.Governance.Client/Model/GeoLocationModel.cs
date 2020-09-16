

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
    /// GeoLocationModel
    /// </summary>
    [DataContract(Name = "GeoLocationModel")]
    public partial class GeoLocationModel : IEquatable<GeoLocationModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeoLocationModel" /> class.
        /// </summary>
        /// <param name="rootSiteUrl">rootSiteUrl.</param>
        /// <param name="tenantAdminUrl">tenantAdminUrl.</param>
        /// <param name="name">name.</param>
        /// <param name="displayName">displayName.</param>
        public GeoLocationModel(string rootSiteUrl = default(string), string tenantAdminUrl = default(string), string name = default(string), string displayName = default(string))
        {
            this.RootSiteUrl = rootSiteUrl;
            this.TenantAdminUrl = tenantAdminUrl;
            this.Name = name;
            this.DisplayName = displayName;
        }

        /// <summary>
        /// Gets or Sets RootSiteUrl
        /// </summary>
        [DataMember(Name = "rootSiteUrl", EmitDefaultValue = true)]
        public string RootSiteUrl { get; set; }

        /// <summary>
        /// Gets or Sets TenantAdminUrl
        /// </summary>
        [DataMember(Name = "tenantAdminUrl", EmitDefaultValue = true)]
        public string TenantAdminUrl { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeoLocationModel {\n");
            sb.Append("  RootSiteUrl: ").Append(RootSiteUrl).Append("\n");
            sb.Append("  TenantAdminUrl: ").Append(TenantAdminUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
            return this.Equals(input as GeoLocationModel);
        }

        /// <summary>
        /// Returns true if GeoLocationModel instances are equal
        /// </summary>
        /// <param name="input">Instance of GeoLocationModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeoLocationModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RootSiteUrl == input.RootSiteUrl ||
                    (this.RootSiteUrl != null &&
                    this.RootSiteUrl.Equals(input.RootSiteUrl))
                ) && 
                (
                    this.TenantAdminUrl == input.TenantAdminUrl ||
                    (this.TenantAdminUrl != null &&
                    this.TenantAdminUrl.Equals(input.TenantAdminUrl))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
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
                if (this.RootSiteUrl != null)
                    hashCode = hashCode * 59 + this.RootSiteUrl.GetHashCode();
                if (this.TenantAdminUrl != null)
                    hashCode = hashCode * 59 + this.TenantAdminUrl.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
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
