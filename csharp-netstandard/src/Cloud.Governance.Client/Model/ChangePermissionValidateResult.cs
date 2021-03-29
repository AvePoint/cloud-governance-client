

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
    /// ChangePermissionValidateResult
    /// </summary>
    [DataContract(Name = "ChangePermissionValidateResult")]
    public partial class ChangePermissionValidateResult : IEquatable<ChangePermissionValidateResult>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets InheritNodeType
        /// </summary>
        [DataMember(Name = "inheritNodeType", EmitDefaultValue = false)]
        public NodeType? InheritNodeType { get; set; }
        /// <summary>
        /// Gets or Sets CheckType
        /// </summary>
        [DataMember(Name = "checkType", EmitDefaultValue = false)]
        public NodeType? CheckType { get; set; }
        /// <summary>
        /// Gets or Sets MessageCode
        /// </summary>
        [DataMember(Name = "messageCode", EmitDefaultValue = false)]
        public MessageCode? MessageCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePermissionValidateResult" /> class.
        /// </summary>
        /// <param name="siteId">siteId.</param>
        /// <param name="siteUrl">siteUrl.</param>
        /// <param name="webId">webId.</param>
        /// <param name="webServerRelativeUrl">webServerRelativeUrl.</param>
        /// <param name="listTitle">listTitle.</param>
        /// <param name="objectUrl">objectUrl.</param>
        /// <param name="isInherit">isInherit (default to false).</param>
        /// <param name="inheritNodeType">inheritNodeType.</param>
        /// <param name="topInheritUrl">topInheritUrl.</param>
        /// <param name="checkType">checkType.</param>
        /// <param name="userMetadata">userMetadata.</param>
        /// <param name="isValid">isValid (default to false).</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="messageCode">messageCode.</param>
        public ChangePermissionValidateResult(Guid siteId = default(Guid), string siteUrl = default(string), Guid webId = default(Guid), string webServerRelativeUrl = default(string), string listTitle = default(string), string objectUrl = default(string), bool isInherit = false, NodeType? inheritNodeType = default(NodeType?), string topInheritUrl = default(string), NodeType? checkType = default(NodeType?), Dictionary<string, UserInfo> userMetadata = default(Dictionary<string, UserInfo>), bool isValid = false, string errorMessage = default(string), MessageCode? messageCode = default(MessageCode?))
        {
            this.SiteId = siteId;
            this.SiteUrl = siteUrl;
            this.WebId = webId;
            this.WebServerRelativeUrl = webServerRelativeUrl;
            this.ListTitle = listTitle;
            this.ObjectUrl = objectUrl;
            this.IsInherit = isInherit;
            this.InheritNodeType = inheritNodeType;
            this.TopInheritUrl = topInheritUrl;
            this.CheckType = checkType;
            this.UserMetadata = userMetadata;
            this.IsValid = isValid;
            this.ErrorMessage = errorMessage;
            this.MessageCode = messageCode;
        }

        /// <summary>
        /// Gets or Sets SiteId
        /// </summary>
        [DataMember(Name = "siteId", EmitDefaultValue = false)]
        public Guid SiteId { get; set; }

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
        /// Gets or Sets WebServerRelativeUrl
        /// </summary>
        [DataMember(Name = "webServerRelativeUrl", EmitDefaultValue = true)]
        public string WebServerRelativeUrl { get; set; }

        /// <summary>
        /// Gets or Sets ListTitle
        /// </summary>
        [DataMember(Name = "listTitle", EmitDefaultValue = true)]
        public string ListTitle { get; set; }

        /// <summary>
        /// Gets or Sets ObjectUrl
        /// </summary>
        [DataMember(Name = "objectUrl", EmitDefaultValue = true)]
        public string ObjectUrl { get; set; }

        /// <summary>
        /// Gets or Sets IsInherit
        /// </summary>
        [DataMember(Name = "isInherit", EmitDefaultValue = false)]
        public bool IsInherit { get; set; }

        /// <summary>
        /// Gets or Sets TopInheritUrl
        /// </summary>
        [DataMember(Name = "topInheritUrl", EmitDefaultValue = true)]
        public string TopInheritUrl { get; set; }

        /// <summary>
        /// Gets or Sets UserMetadata
        /// </summary>
        [DataMember(Name = "userMetadata", EmitDefaultValue = true)]
        public Dictionary<string, UserInfo> UserMetadata { get; set; }

        /// <summary>
        /// Gets or Sets IsValid
        /// </summary>
        [DataMember(Name = "isValid", EmitDefaultValue = false)]
        public bool IsValid { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name = "errorMessage", EmitDefaultValue = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangePermissionValidateResult {\n");
            sb.Append("  SiteId: ").Append(SiteId).Append("\n");
            sb.Append("  SiteUrl: ").Append(SiteUrl).Append("\n");
            sb.Append("  WebId: ").Append(WebId).Append("\n");
            sb.Append("  WebServerRelativeUrl: ").Append(WebServerRelativeUrl).Append("\n");
            sb.Append("  ListTitle: ").Append(ListTitle).Append("\n");
            sb.Append("  ObjectUrl: ").Append(ObjectUrl).Append("\n");
            sb.Append("  IsInherit: ").Append(IsInherit).Append("\n");
            sb.Append("  InheritNodeType: ").Append(InheritNodeType).Append("\n");
            sb.Append("  TopInheritUrl: ").Append(TopInheritUrl).Append("\n");
            sb.Append("  CheckType: ").Append(CheckType).Append("\n");
            sb.Append("  UserMetadata: ").Append(UserMetadata).Append("\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  MessageCode: ").Append(MessageCode).Append("\n");
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
            return this.Equals(input as ChangePermissionValidateResult);
        }

        /// <summary>
        /// Returns true if ChangePermissionValidateResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangePermissionValidateResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangePermissionValidateResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SiteId == input.SiteId ||
                    (this.SiteId != null &&
                    this.SiteId.Equals(input.SiteId))
                ) && 
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
                    this.WebServerRelativeUrl == input.WebServerRelativeUrl ||
                    (this.WebServerRelativeUrl != null &&
                    this.WebServerRelativeUrl.Equals(input.WebServerRelativeUrl))
                ) && 
                (
                    this.ListTitle == input.ListTitle ||
                    (this.ListTitle != null &&
                    this.ListTitle.Equals(input.ListTitle))
                ) && 
                (
                    this.ObjectUrl == input.ObjectUrl ||
                    (this.ObjectUrl != null &&
                    this.ObjectUrl.Equals(input.ObjectUrl))
                ) && 
                (
                    this.IsInherit == input.IsInherit ||
                    this.IsInherit.Equals(input.IsInherit)
                ) && 
                (
                    this.InheritNodeType == input.InheritNodeType ||
                    this.InheritNodeType.Equals(input.InheritNodeType)
                ) && 
                (
                    this.TopInheritUrl == input.TopInheritUrl ||
                    (this.TopInheritUrl != null &&
                    this.TopInheritUrl.Equals(input.TopInheritUrl))
                ) && 
                (
                    this.CheckType == input.CheckType ||
                    this.CheckType.Equals(input.CheckType)
                ) && 
                (
                    this.UserMetadata == input.UserMetadata ||
                    this.UserMetadata != null &&
                    input.UserMetadata != null &&
                    this.UserMetadata.SequenceEqual(input.UserMetadata)
                ) && 
                (
                    this.IsValid == input.IsValid ||
                    this.IsValid.Equals(input.IsValid)
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.MessageCode == input.MessageCode ||
                    this.MessageCode.Equals(input.MessageCode)
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
                if (this.SiteId != null)
                    hashCode = hashCode * 59 + this.SiteId.GetHashCode();
                if (this.SiteUrl != null)
                    hashCode = hashCode * 59 + this.SiteUrl.GetHashCode();
                if (this.WebId != null)
                    hashCode = hashCode * 59 + this.WebId.GetHashCode();
                if (this.WebServerRelativeUrl != null)
                    hashCode = hashCode * 59 + this.WebServerRelativeUrl.GetHashCode();
                if (this.ListTitle != null)
                    hashCode = hashCode * 59 + this.ListTitle.GetHashCode();
                if (this.ObjectUrl != null)
                    hashCode = hashCode * 59 + this.ObjectUrl.GetHashCode();
                hashCode = hashCode * 59 + this.IsInherit.GetHashCode();
                hashCode = hashCode * 59 + this.InheritNodeType.GetHashCode();
                if (this.TopInheritUrl != null)
                    hashCode = hashCode * 59 + this.TopInheritUrl.GetHashCode();
                hashCode = hashCode * 59 + this.CheckType.GetHashCode();
                if (this.UserMetadata != null)
                    hashCode = hashCode * 59 + this.UserMetadata.GetHashCode();
                hashCode = hashCode * 59 + this.IsValid.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                hashCode = hashCode * 59 + this.MessageCode.GetHashCode();
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
