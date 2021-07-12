

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
    /// Site Collection lease period request settings model
    /// </summary>
    [DataContract(Name = "SiteLeasePeriodRequestSettings")]
    public partial class SiteLeasePeriodRequestSettings : IEquatable<SiteLeasePeriodRequestSettings>, IValidatableObject
    {
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
        /// Initializes a new instance of the <see cref="SiteLeasePeriodRequestSettings" /> class.
        /// </summary>
        /// <param name="leaseInterval">Site Collection lease period (default to 0).</param>
        /// <param name="leaseDurationType">Duration type of the site collection lease period.</param>
        /// <param name="leaseWarningInterval">Site collection lease expiration warning interval (default to 0).</param>
        /// <param name="leaseWarningDurationType">Duration type of the site collection lease expiration warning interval.</param>
        public SiteLeasePeriodRequestSettings(int leaseInterval = 0, ApiDurationType? leaseDurationType = default(ApiDurationType?), int leaseWarningInterval = 0, ApiDurationType? leaseWarningDurationType = default(ApiDurationType?))
        {
            this.LeaseInterval = leaseInterval;
            this.LeaseDurationType = leaseDurationType;
            this.LeaseWarningInterval = leaseWarningInterval;
            this.LeaseWarningDurationType = leaseWarningDurationType;
        }

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
            sb.Append("class SiteLeasePeriodRequestSettings {\n");
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
            return this.Equals(input as SiteLeasePeriodRequestSettings);
        }

        /// <summary>
        /// Returns true if SiteLeasePeriodRequestSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of SiteLeasePeriodRequestSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SiteLeasePeriodRequestSettings input)
        {
            if (input == null)
                return false;

            return 
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
