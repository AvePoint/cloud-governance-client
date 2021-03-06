

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
    /// SiteLeasePeriodServiceSettings
    /// </summary>
    [DataContract(Name = "SiteLeasePeriodServiceSettings")]
    public partial class SiteLeasePeriodServiceSettings : IEquatable<SiteLeasePeriodServiceSettings>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets LeasePeriodAssignBy
        /// </summary>
        [DataMember(Name = "leasePeriodAssignBy", EmitDefaultValue = false)]
        public AssignBy? LeasePeriodAssignBy { get; set; }
        /// <summary>
        /// Gets or Sets LeaseWarningAssignBy
        /// </summary>
        [DataMember(Name = "leaseWarningAssignBy", EmitDefaultValue = false)]
        public AssignBy? LeaseWarningAssignBy { get; set; }
        /// <summary>
        /// Duration type of the site collection lease period
        /// </summary>
        /// <value>Duration type of the site collection lease period</value>
        [DataMember(Name = "leaseDurationType", EmitDefaultValue = false)]
        public ApiDurationType? LeaseDurationType { get; set; }
        /// <summary>
        /// Duration type of the site collection lease expiration warning interval
        /// </summary>
        /// <value>Duration type of the site collection lease expiration warning interval</value>
        [DataMember(Name = "leaseWarningDurationType", EmitDefaultValue = false)]
        public ApiDurationType? LeaseWarningDurationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SiteLeasePeriodServiceSettings" /> class.
        /// </summary>
        /// <param name="leasePeriodAssignBy">leasePeriodAssignBy.</param>
        /// <param name="leaseWarningAssignBy">leaseWarningAssignBy.</param>
        /// <param name="leaseEnabled">leaseEnabled (default to false).</param>
        /// <param name="leaseWarningEnabled">leaseWarningEnabled (default to false).</param>
        /// <param name="approvalProcessId">approvalProcessId.</param>
        /// <param name="leaseInterval">Site Collection lease period (default to 0).</param>
        /// <param name="leaseDurationType">Duration type of the site collection lease period.</param>
        /// <param name="leaseWarningInterval">Site collection lease expiration warning interval (default to 0).</param>
        /// <param name="leaseWarningDurationType">Duration type of the site collection lease expiration warning interval.</param>
        public SiteLeasePeriodServiceSettings(AssignBy? leasePeriodAssignBy = default(AssignBy?), AssignBy? leaseWarningAssignBy = default(AssignBy?), bool leaseEnabled = false, bool leaseWarningEnabled = false, Guid? approvalProcessId = default(Guid?), int leaseInterval = 0, ApiDurationType? leaseDurationType = default(ApiDurationType?), int leaseWarningInterval = 0, ApiDurationType? leaseWarningDurationType = default(ApiDurationType?))
        {
            this.LeasePeriodAssignBy = leasePeriodAssignBy;
            this.LeaseWarningAssignBy = leaseWarningAssignBy;
            this.LeaseEnabled = leaseEnabled;
            this.LeaseWarningEnabled = leaseWarningEnabled;
            this.ApprovalProcessId = approvalProcessId;
            this.LeaseInterval = leaseInterval;
            this.LeaseDurationType = leaseDurationType;
            this.LeaseWarningInterval = leaseWarningInterval;
            this.LeaseWarningDurationType = leaseWarningDurationType;
        }

        /// <summary>
        /// Gets or Sets LeaseEnabled
        /// </summary>
        [DataMember(Name = "leaseEnabled", EmitDefaultValue = false)]
        public bool LeaseEnabled { get; set; }

        /// <summary>
        /// Gets or Sets LeaseWarningEnabled
        /// </summary>
        [DataMember(Name = "leaseWarningEnabled", EmitDefaultValue = false)]
        public bool LeaseWarningEnabled { get; set; }

        /// <summary>
        /// Gets or Sets ApprovalProcessId
        /// </summary>
        [DataMember(Name = "approvalProcessId", EmitDefaultValue = true)]
        public Guid? ApprovalProcessId { get; set; }

        /// <summary>
        /// Site Collection lease period
        /// </summary>
        /// <value>Site Collection lease period</value>
        [DataMember(Name = "leaseInterval", EmitDefaultValue = false)]
        public int LeaseInterval { get; set; }

        /// <summary>
        /// Site collection lease expiration warning interval
        /// </summary>
        /// <value>Site collection lease expiration warning interval</value>
        [DataMember(Name = "leaseWarningInterval", EmitDefaultValue = false)]
        public int LeaseWarningInterval { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SiteLeasePeriodServiceSettings {\n");
            sb.Append("  LeasePeriodAssignBy: ").Append(LeasePeriodAssignBy).Append("\n");
            sb.Append("  LeaseWarningAssignBy: ").Append(LeaseWarningAssignBy).Append("\n");
            sb.Append("  LeaseEnabled: ").Append(LeaseEnabled).Append("\n");
            sb.Append("  LeaseWarningEnabled: ").Append(LeaseWarningEnabled).Append("\n");
            sb.Append("  ApprovalProcessId: ").Append(ApprovalProcessId).Append("\n");
            sb.Append("  LeaseInterval: ").Append(LeaseInterval).Append("\n");
            sb.Append("  LeaseDurationType: ").Append(LeaseDurationType).Append("\n");
            sb.Append("  LeaseWarningInterval: ").Append(LeaseWarningInterval).Append("\n");
            sb.Append("  LeaseWarningDurationType: ").Append(LeaseWarningDurationType).Append("\n");
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
            return this.Equals(input as SiteLeasePeriodServiceSettings);
        }

        /// <summary>
        /// Returns true if SiteLeasePeriodServiceSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of SiteLeasePeriodServiceSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SiteLeasePeriodServiceSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LeasePeriodAssignBy == input.LeasePeriodAssignBy ||
                    this.LeasePeriodAssignBy.Equals(input.LeasePeriodAssignBy)
                ) && 
                (
                    this.LeaseWarningAssignBy == input.LeaseWarningAssignBy ||
                    this.LeaseWarningAssignBy.Equals(input.LeaseWarningAssignBy)
                ) && 
                (
                    this.LeaseEnabled == input.LeaseEnabled ||
                    this.LeaseEnabled.Equals(input.LeaseEnabled)
                ) && 
                (
                    this.LeaseWarningEnabled == input.LeaseWarningEnabled ||
                    this.LeaseWarningEnabled.Equals(input.LeaseWarningEnabled)
                ) && 
                (
                    this.ApprovalProcessId == input.ApprovalProcessId ||
                    (this.ApprovalProcessId != null &&
                    this.ApprovalProcessId.Equals(input.ApprovalProcessId))
                ) && 
                (
                    this.LeaseInterval == input.LeaseInterval ||
                    this.LeaseInterval.Equals(input.LeaseInterval)
                ) && 
                (
                    this.LeaseDurationType == input.LeaseDurationType ||
                    this.LeaseDurationType.Equals(input.LeaseDurationType)
                ) && 
                (
                    this.LeaseWarningInterval == input.LeaseWarningInterval ||
                    this.LeaseWarningInterval.Equals(input.LeaseWarningInterval)
                ) && 
                (
                    this.LeaseWarningDurationType == input.LeaseWarningDurationType ||
                    this.LeaseWarningDurationType.Equals(input.LeaseWarningDurationType)
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
                hashCode = hashCode * 59 + this.LeasePeriodAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.LeaseWarningAssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.LeaseEnabled.GetHashCode();
                hashCode = hashCode * 59 + this.LeaseWarningEnabled.GetHashCode();
                if (this.ApprovalProcessId != null)
                    hashCode = hashCode * 59 + this.ApprovalProcessId.GetHashCode();
                hashCode = hashCode * 59 + this.LeaseInterval.GetHashCode();
                hashCode = hashCode * 59 + this.LeaseDurationType.GetHashCode();
                hashCode = hashCode * 59 + this.LeaseWarningInterval.GetHashCode();
                hashCode = hashCode * 59 + this.LeaseWarningDurationType.GetHashCode();
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
