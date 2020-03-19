/* 
 * Cloud Governance Api
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Cloud.Governance.Client.Client.OpenAPIDateConverter;

namespace Cloud.Governance.Client.Model
{
    /// <summary>
    /// SitePolicySharingSetting
    /// </summary>
    [DataContract]
    public partial class SitePolicySharingSetting :  IEquatable<SitePolicySharingSetting>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets SharingCapabilities
        /// </summary>
        [DataMember(Name="sharingCapabilities", EmitDefaultValue=false)]
        public SharingCapabilities? SharingCapabilities { get; set; }
        /// <summary>
        /// Gets or Sets AccessRequestType
        /// </summary>
        [DataMember(Name="accessRequestType", EmitDefaultValue=false)]
        public AccessRequestType? AccessRequestType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SitePolicySharingSetting" /> class.
        /// </summary>
        /// <param name="isEnabled">isEnabled.</param>
        /// <param name="sharingCapabilities">sharingCapabilities.</param>
        /// <param name="membersCanShare">membersCanShare.</param>
        /// <param name="allowMembersEditMembership">allowMembersEditMembership.</param>
        /// <param name="allowAccessRequests">allowAccessRequests.</param>
        /// <param name="requestAccessEmail">requestAccessEmail.</param>
        /// <param name="accessRequestType">accessRequestType.</param>
        /// <param name="accessRequestMessage">accessRequestMessage.</param>
        public SitePolicySharingSetting(bool isEnabled = default(bool), SharingCapabilities sharingCapabilities = default(SharingCapabilities), bool membersCanShare = default(bool), bool allowMembersEditMembership = default(bool), bool allowAccessRequests = default(bool), string requestAccessEmail = default(string), AccessRequestType accessRequestType = default(AccessRequestType), string accessRequestMessage = default(string))
        {
            this.IsEnabled = isEnabled;
            this.SharingCapabilities = sharingCapabilities;
            this.MembersCanShare = membersCanShare;
            this.AllowMembersEditMembership = allowMembersEditMembership;
            this.AllowAccessRequests = allowAccessRequests;
            this.RequestAccessEmail = requestAccessEmail;
            this.AccessRequestType = accessRequestType;
            this.AccessRequestMessage = accessRequestMessage;
        }
        
        /// <summary>
        /// Gets or Sets IsEnabled
        /// </summary>
        [DataMember(Name="isEnabled", EmitDefaultValue=false)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets MembersCanShare
        /// </summary>
        [DataMember(Name="membersCanShare", EmitDefaultValue=false)]
        public bool MembersCanShare { get; set; }

        /// <summary>
        /// Gets or Sets AllowMembersEditMembership
        /// </summary>
        [DataMember(Name="allowMembersEditMembership", EmitDefaultValue=false)]
        public bool AllowMembersEditMembership { get; set; }

        /// <summary>
        /// Gets or Sets AllowAccessRequests
        /// </summary>
        [DataMember(Name="allowAccessRequests", EmitDefaultValue=false)]
        public bool AllowAccessRequests { get; set; }

        /// <summary>
        /// Gets or Sets RequestAccessEmail
        /// </summary>
        [DataMember(Name="requestAccessEmail", EmitDefaultValue=true)]
        public string RequestAccessEmail { get; set; }

        /// <summary>
        /// Gets or Sets AccessRequestMessage
        /// </summary>
        [DataMember(Name="accessRequestMessage", EmitDefaultValue=true)]
        public string AccessRequestMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SitePolicySharingSetting {\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  SharingCapabilities: ").Append(SharingCapabilities).Append("\n");
            sb.Append("  MembersCanShare: ").Append(MembersCanShare).Append("\n");
            sb.Append("  AllowMembersEditMembership: ").Append(AllowMembersEditMembership).Append("\n");
            sb.Append("  AllowAccessRequests: ").Append(AllowAccessRequests).Append("\n");
            sb.Append("  RequestAccessEmail: ").Append(RequestAccessEmail).Append("\n");
            sb.Append("  AccessRequestType: ").Append(AccessRequestType).Append("\n");
            sb.Append("  AccessRequestMessage: ").Append(AccessRequestMessage).Append("\n");
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
            return this.Equals(input as SitePolicySharingSetting);
        }

        /// <summary>
        /// Returns true if SitePolicySharingSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of SitePolicySharingSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SitePolicySharingSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsEnabled == input.IsEnabled ||
                    this.IsEnabled.Equals(input.IsEnabled)
                ) && 
                (
                    this.SharingCapabilities == input.SharingCapabilities ||
                    this.SharingCapabilities.Equals(input.SharingCapabilities)
                ) && 
                (
                    this.MembersCanShare == input.MembersCanShare ||
                    this.MembersCanShare.Equals(input.MembersCanShare)
                ) && 
                (
                    this.AllowMembersEditMembership == input.AllowMembersEditMembership ||
                    this.AllowMembersEditMembership.Equals(input.AllowMembersEditMembership)
                ) && 
                (
                    this.AllowAccessRequests == input.AllowAccessRequests ||
                    this.AllowAccessRequests.Equals(input.AllowAccessRequests)
                ) && 
                (
                    this.RequestAccessEmail == input.RequestAccessEmail ||
                    (this.RequestAccessEmail != null &&
                    this.RequestAccessEmail.Equals(input.RequestAccessEmail))
                ) && 
                (
                    this.AccessRequestType == input.AccessRequestType ||
                    this.AccessRequestType.Equals(input.AccessRequestType)
                ) && 
                (
                    this.AccessRequestMessage == input.AccessRequestMessage ||
                    (this.AccessRequestMessage != null &&
                    this.AccessRequestMessage.Equals(input.AccessRequestMessage))
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
                hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                hashCode = hashCode * 59 + this.SharingCapabilities.GetHashCode();
                hashCode = hashCode * 59 + this.MembersCanShare.GetHashCode();
                hashCode = hashCode * 59 + this.AllowMembersEditMembership.GetHashCode();
                hashCode = hashCode * 59 + this.AllowAccessRequests.GetHashCode();
                if (this.RequestAccessEmail != null)
                    hashCode = hashCode * 59 + this.RequestAccessEmail.GetHashCode();
                hashCode = hashCode * 59 + this.AccessRequestType.GetHashCode();
                if (this.AccessRequestMessage != null)
                    hashCode = hashCode * 59 + this.AccessRequestMessage.GetHashCode();
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
