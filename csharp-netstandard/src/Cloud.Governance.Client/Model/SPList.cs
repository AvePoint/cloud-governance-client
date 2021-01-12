

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
    /// SPList
    /// </summary>
    [DataContract(Name = "SPList")]
    public partial class SPList : IEquatable<SPList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SPList" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="title">title.</param>
        /// <param name="url">url.</param>
        /// <param name="description">description.</param>
        /// <param name="isLibrary">isLibrary.</param>
        /// <param name="isOnQuickLaunch">isOnQuickLaunch.</param>
        /// <param name="isEnableModeration">isEnableModeration.</param>
        /// <param name="isEnableVersioning">isEnableVersioning.</param>
        /// <param name="isEnableMinorVersion">isEnableMinorVersion.</param>
        /// <param name="majorVersionLimit">majorVersionLimit.</param>
        /// <param name="majorWithMinorVersionsLimit">majorWithMinorVersionsLimit.</param>
        public SPList(Guid id = default(Guid), string title = default(string), string url = default(string), string description = default(string), bool isLibrary = default(bool), bool isOnQuickLaunch = default(bool), bool isEnableModeration = default(bool), bool isEnableVersioning = default(bool), bool isEnableMinorVersion = default(bool), int majorVersionLimit = default(int), int majorWithMinorVersionsLimit = default(int))
        {
            this.Id = id;
            this.Title = title;
            this.Url = url;
            this.Description = description;
            this.IsLibrary = isLibrary;
            this.IsOnQuickLaunch = isOnQuickLaunch;
            this.IsEnableModeration = isEnableModeration;
            this.IsEnableVersioning = isEnableVersioning;
            this.IsEnableMinorVersion = isEnableMinorVersion;
            this.MajorVersionLimit = majorVersionLimit;
            this.MajorWithMinorVersionsLimit = majorWithMinorVersionsLimit;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets IsLibrary
        /// </summary>
        [DataMember(Name = "isLibrary", EmitDefaultValue = false)]
        public bool IsLibrary { get; set; }

        /// <summary>
        /// Gets or Sets IsOnQuickLaunch
        /// </summary>
        [DataMember(Name = "isOnQuickLaunch", EmitDefaultValue = false)]
        public bool IsOnQuickLaunch { get; set; }

        /// <summary>
        /// Gets or Sets IsEnableModeration
        /// </summary>
        [DataMember(Name = "isEnableModeration", EmitDefaultValue = false)]
        public bool IsEnableModeration { get; set; }

        /// <summary>
        /// Gets or Sets IsEnableVersioning
        /// </summary>
        [DataMember(Name = "isEnableVersioning", EmitDefaultValue = false)]
        public bool IsEnableVersioning { get; set; }

        /// <summary>
        /// Gets or Sets IsEnableMinorVersion
        /// </summary>
        [DataMember(Name = "isEnableMinorVersion", EmitDefaultValue = false)]
        public bool IsEnableMinorVersion { get; set; }

        /// <summary>
        /// Gets or Sets MajorVersionLimit
        /// </summary>
        [DataMember(Name = "majorVersionLimit", EmitDefaultValue = false)]
        public int MajorVersionLimit { get; set; }

        /// <summary>
        /// Gets or Sets MajorWithMinorVersionsLimit
        /// </summary>
        [DataMember(Name = "majorWithMinorVersionsLimit", EmitDefaultValue = false)]
        public int MajorWithMinorVersionsLimit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SPList {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsLibrary: ").Append(IsLibrary).Append("\n");
            sb.Append("  IsOnQuickLaunch: ").Append(IsOnQuickLaunch).Append("\n");
            sb.Append("  IsEnableModeration: ").Append(IsEnableModeration).Append("\n");
            sb.Append("  IsEnableVersioning: ").Append(IsEnableVersioning).Append("\n");
            sb.Append("  IsEnableMinorVersion: ").Append(IsEnableMinorVersion).Append("\n");
            sb.Append("  MajorVersionLimit: ").Append(MajorVersionLimit).Append("\n");
            sb.Append("  MajorWithMinorVersionsLimit: ").Append(MajorWithMinorVersionsLimit).Append("\n");
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
            return this.Equals(input as SPList);
        }

        /// <summary>
        /// Returns true if SPList instances are equal
        /// </summary>
        /// <param name="input">Instance of SPList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SPList input)
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
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IsLibrary == input.IsLibrary ||
                    this.IsLibrary.Equals(input.IsLibrary)
                ) && 
                (
                    this.IsOnQuickLaunch == input.IsOnQuickLaunch ||
                    this.IsOnQuickLaunch.Equals(input.IsOnQuickLaunch)
                ) && 
                (
                    this.IsEnableModeration == input.IsEnableModeration ||
                    this.IsEnableModeration.Equals(input.IsEnableModeration)
                ) && 
                (
                    this.IsEnableVersioning == input.IsEnableVersioning ||
                    this.IsEnableVersioning.Equals(input.IsEnableVersioning)
                ) && 
                (
                    this.IsEnableMinorVersion == input.IsEnableMinorVersion ||
                    this.IsEnableMinorVersion.Equals(input.IsEnableMinorVersion)
                ) && 
                (
                    this.MajorVersionLimit == input.MajorVersionLimit ||
                    this.MajorVersionLimit.Equals(input.MajorVersionLimit)
                ) && 
                (
                    this.MajorWithMinorVersionsLimit == input.MajorWithMinorVersionsLimit ||
                    this.MajorWithMinorVersionsLimit.Equals(input.MajorWithMinorVersionsLimit)
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.IsLibrary.GetHashCode();
                hashCode = hashCode * 59 + this.IsOnQuickLaunch.GetHashCode();
                hashCode = hashCode * 59 + this.IsEnableModeration.GetHashCode();
                hashCode = hashCode * 59 + this.IsEnableVersioning.GetHashCode();
                hashCode = hashCode * 59 + this.IsEnableMinorVersion.GetHashCode();
                hashCode = hashCode * 59 + this.MajorVersionLimit.GetHashCode();
                hashCode = hashCode * 59 + this.MajorWithMinorVersionsLimit.GetHashCode();
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
