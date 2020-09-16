

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
    /// ChangeListSettingObjectInfo
    /// </summary>
    [DataContract(Name = "ChangeListSettingObjectInfo")]
    public partial class ChangeListSettingObjectInfo : IEquatable<ChangeListSettingObjectInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeListSettingObjectInfo" /> class.
        /// </summary>
        /// <param name="siteUrl">siteUrl.</param>
        /// <param name="webId">webId.</param>
        /// <param name="webUrl">webUrl.</param>
        /// <param name="siteId">siteId.</param>
        /// <param name="objectUrl">objectUrl.</param>
        /// <param name="objectTitle">objectTitle.</param>
        public ChangeListSettingObjectInfo(string siteUrl = default(string), Guid webId = default(Guid), string webUrl = default(string), Guid siteId = default(Guid), string objectUrl = default(string), string objectTitle = default(string))
        {
            this.SiteUrl = siteUrl;
            this.WebId = webId;
            this.WebUrl = webUrl;
            this.SiteId = siteId;
            this.ObjectUrl = objectUrl;
            this.ObjectTitle = objectTitle;
        }

        /// <summary>
        /// Gets or Sets SiteUrl
        /// </summary>
        [DataMember(Name = "siteUrl", EmitDefaultValue = true)]
        public string SiteUrl { get; set; }

        /// <summary>
        /// Gets or Sets WebId
        /// </summary>
        [DataMember(Name = "webId", EmitDefaultValue = false)]
        public Guid WebId { get; set; }

        /// <summary>
        /// Gets or Sets WebUrl
        /// </summary>
        [DataMember(Name = "webUrl", EmitDefaultValue = true)]
        public string WebUrl { get; set; }

        /// <summary>
        /// Gets or Sets SiteId
        /// </summary>
        [DataMember(Name = "siteId", EmitDefaultValue = false)]
        public Guid SiteId { get; set; }

        /// <summary>
        /// Gets or Sets ObjectUrl
        /// </summary>
        [DataMember(Name = "objectUrl", EmitDefaultValue = true)]
        public string ObjectUrl { get; set; }

        /// <summary>
        /// Gets or Sets ObjectTitle
        /// </summary>
        [DataMember(Name = "objectTitle", EmitDefaultValue = true)]
        public string ObjectTitle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeListSettingObjectInfo {\n");
            sb.Append("  SiteUrl: ").Append(SiteUrl).Append("\n");
            sb.Append("  WebId: ").Append(WebId).Append("\n");
            sb.Append("  WebUrl: ").Append(WebUrl).Append("\n");
            sb.Append("  SiteId: ").Append(SiteId).Append("\n");
            sb.Append("  ObjectUrl: ").Append(ObjectUrl).Append("\n");
            sb.Append("  ObjectTitle: ").Append(ObjectTitle).Append("\n");
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
            return this.Equals(input as ChangeListSettingObjectInfo);
        }

        /// <summary>
        /// Returns true if ChangeListSettingObjectInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeListSettingObjectInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeListSettingObjectInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SiteUrl == input.SiteUrl ||
                    (this.SiteUrl != null &&
                    this.SiteUrl.Equals(input.SiteUrl))
                ) && 
                (
                    this.WebId == input.WebId ||
                    (this.WebId != null &&
                    this.WebId.Equals(input.WebId))
                ) && 
                (
                    this.WebUrl == input.WebUrl ||
                    (this.WebUrl != null &&
                    this.WebUrl.Equals(input.WebUrl))
                ) && 
                (
                    this.SiteId == input.SiteId ||
                    (this.SiteId != null &&
                    this.SiteId.Equals(input.SiteId))
                ) && 
                (
                    this.ObjectUrl == input.ObjectUrl ||
                    (this.ObjectUrl != null &&
                    this.ObjectUrl.Equals(input.ObjectUrl))
                ) && 
                (
                    this.ObjectTitle == input.ObjectTitle ||
                    (this.ObjectTitle != null &&
                    this.ObjectTitle.Equals(input.ObjectTitle))
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
                if (this.SiteUrl != null)
                    hashCode = hashCode * 59 + this.SiteUrl.GetHashCode();
                if (this.WebId != null)
                    hashCode = hashCode * 59 + this.WebId.GetHashCode();
                if (this.WebUrl != null)
                    hashCode = hashCode * 59 + this.WebUrl.GetHashCode();
                if (this.SiteId != null)
                    hashCode = hashCode * 59 + this.SiteId.GetHashCode();
                if (this.ObjectUrl != null)
                    hashCode = hashCode * 59 + this.ObjectUrl.GetHashCode();
                if (this.ObjectTitle != null)
                    hashCode = hashCode * 59 + this.ObjectTitle.GetHashCode();
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
