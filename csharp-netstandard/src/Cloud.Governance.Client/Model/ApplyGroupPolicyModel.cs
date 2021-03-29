

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
    /// ApplyGroupPolicyModel
    /// </summary>
    [DataContract(Name = "ApplyGroupPolicyModel")]
    public partial class ApplyGroupPolicyModel : IEquatable<ApplyGroupPolicyModel>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets SubType
        /// </summary>
        [DataMember(Name = "subType", EmitDefaultValue = false)]
        public GroupPolicySubType? SubType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyGroupPolicyModel" /> class.
        /// </summary>
        /// <param name="subType">subType.</param>
        /// <param name="policyId">policyId.</param>
        /// <param name="isApplyAllSetting">isApplyAllSetting (default to false).</param>
        /// <param name="isApplyQuota">isApplyQuota (default to false).</param>
        /// <param name="isApplySharing">isApplySharing (default to false).</param>
        /// <param name="isApplyQuotaThreshold">isApplyQuotaThreshold (default to false).</param>
        /// <param name="isApplyDeactivatedElection">isApplyDeactivatedElection (default to false).</param>
        /// <param name="isApplyLifecycle">isApplyLifecycle (default to false).</param>
        /// <param name="lifecycleRenewalSetting">lifecycleRenewalSetting.</param>
        /// <param name="filter">filter.</param>
        /// <param name="selectedObjects">selectedObjects.</param>
        /// <param name="hasOngoingTasks">hasOngoingTasks (default to false).</param>
        public ApplyGroupPolicyModel(GroupPolicySubType? subType = default(GroupPolicySubType?), Guid policyId = default(Guid), bool isApplyAllSetting = false, bool isApplyQuota = false, bool isApplySharing = false, bool isApplyQuotaThreshold = false, bool isApplyDeactivatedElection = false, bool isApplyLifecycle = false, LifecycleRenewalSetting lifecycleRenewalSetting = default(LifecycleRenewalSetting), string filter = default(string), List<string> selectedObjects = default(List<string>), bool hasOngoingTasks = false)
        {
            this.SubType = subType;
            this.PolicyId = policyId;
            this.IsApplyAllSetting = isApplyAllSetting;
            this.IsApplyQuota = isApplyQuota;
            this.IsApplySharing = isApplySharing;
            this.IsApplyQuotaThreshold = isApplyQuotaThreshold;
            this.IsApplyDeactivatedElection = isApplyDeactivatedElection;
            this.IsApplyLifecycle = isApplyLifecycle;
            this.LifecycleRenewalSetting = lifecycleRenewalSetting;
            this.Filter = filter;
            this.SelectedObjects = selectedObjects;
            this.HasOngoingTasks = hasOngoingTasks;
        }

        /// <summary>
        /// Gets or Sets PolicyId
        /// </summary>
        [DataMember(Name = "policyId", EmitDefaultValue = false)]
        public Guid PolicyId { get; set; }

        /// <summary>
        /// Gets or Sets IsApplyAllSetting
        /// </summary>
        [DataMember(Name = "isApplyAllSetting", EmitDefaultValue = false)]
        public bool IsApplyAllSetting { get; set; }

        /// <summary>
        /// Gets or Sets IsApplyQuota
        /// </summary>
        [DataMember(Name = "isApplyQuota", EmitDefaultValue = false)]
        public bool IsApplyQuota { get; set; }

        /// <summary>
        /// Gets or Sets IsApplySharing
        /// </summary>
        [DataMember(Name = "isApplySharing", EmitDefaultValue = false)]
        public bool IsApplySharing { get; set; }

        /// <summary>
        /// Gets or Sets IsApplyQuotaThreshold
        /// </summary>
        [DataMember(Name = "isApplyQuotaThreshold", EmitDefaultValue = false)]
        public bool IsApplyQuotaThreshold { get; set; }

        /// <summary>
        /// Gets or Sets IsApplyDeactivatedElection
        /// </summary>
        [DataMember(Name = "isApplyDeactivatedElection", EmitDefaultValue = false)]
        public bool IsApplyDeactivatedElection { get; set; }

        /// <summary>
        /// Gets or Sets IsApplyLifecycle
        /// </summary>
        [DataMember(Name = "isApplyLifecycle", EmitDefaultValue = false)]
        public bool IsApplyLifecycle { get; set; }

        /// <summary>
        /// Gets or Sets LifecycleRenewalSetting
        /// </summary>
        [DataMember(Name = "lifecycleRenewalSetting", EmitDefaultValue = true)]
        public LifecycleRenewalSetting LifecycleRenewalSetting { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = true)]
        public string Filter { get; set; }

        /// <summary>
        /// Gets or Sets SelectedObjects
        /// </summary>
        [DataMember(Name = "selectedObjects", EmitDefaultValue = true)]
        public List<string> SelectedObjects { get; set; }

        /// <summary>
        /// Gets or Sets HasOngoingTasks
        /// </summary>
        [DataMember(Name = "hasOngoingTasks", EmitDefaultValue = false)]
        public bool HasOngoingTasks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplyGroupPolicyModel {\n");
            sb.Append("  SubType: ").Append(SubType).Append("\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
            sb.Append("  IsApplyAllSetting: ").Append(IsApplyAllSetting).Append("\n");
            sb.Append("  IsApplyQuota: ").Append(IsApplyQuota).Append("\n");
            sb.Append("  IsApplySharing: ").Append(IsApplySharing).Append("\n");
            sb.Append("  IsApplyQuotaThreshold: ").Append(IsApplyQuotaThreshold).Append("\n");
            sb.Append("  IsApplyDeactivatedElection: ").Append(IsApplyDeactivatedElection).Append("\n");
            sb.Append("  IsApplyLifecycle: ").Append(IsApplyLifecycle).Append("\n");
            sb.Append("  LifecycleRenewalSetting: ").Append(LifecycleRenewalSetting).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  SelectedObjects: ").Append(SelectedObjects).Append("\n");
            sb.Append("  HasOngoingTasks: ").Append(HasOngoingTasks).Append("\n");
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
            return this.Equals(input as ApplyGroupPolicyModel);
        }

        /// <summary>
        /// Returns true if ApplyGroupPolicyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplyGroupPolicyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplyGroupPolicyModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SubType == input.SubType ||
                    this.SubType.Equals(input.SubType)
                ) && 
                (
                    this.PolicyId == input.PolicyId ||
                    (this.PolicyId != null &&
                    this.PolicyId.Equals(input.PolicyId))
                ) && 
                (
                    this.IsApplyAllSetting == input.IsApplyAllSetting ||
                    this.IsApplyAllSetting.Equals(input.IsApplyAllSetting)
                ) && 
                (
                    this.IsApplyQuota == input.IsApplyQuota ||
                    this.IsApplyQuota.Equals(input.IsApplyQuota)
                ) && 
                (
                    this.IsApplySharing == input.IsApplySharing ||
                    this.IsApplySharing.Equals(input.IsApplySharing)
                ) && 
                (
                    this.IsApplyQuotaThreshold == input.IsApplyQuotaThreshold ||
                    this.IsApplyQuotaThreshold.Equals(input.IsApplyQuotaThreshold)
                ) && 
                (
                    this.IsApplyDeactivatedElection == input.IsApplyDeactivatedElection ||
                    this.IsApplyDeactivatedElection.Equals(input.IsApplyDeactivatedElection)
                ) && 
                (
                    this.IsApplyLifecycle == input.IsApplyLifecycle ||
                    this.IsApplyLifecycle.Equals(input.IsApplyLifecycle)
                ) && 
                (
                    this.LifecycleRenewalSetting == input.LifecycleRenewalSetting ||
                    (this.LifecycleRenewalSetting != null &&
                    this.LifecycleRenewalSetting.Equals(input.LifecycleRenewalSetting))
                ) && 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.SelectedObjects == input.SelectedObjects ||
                    this.SelectedObjects != null &&
                    input.SelectedObjects != null &&
                    this.SelectedObjects.SequenceEqual(input.SelectedObjects)
                ) && 
                (
                    this.HasOngoingTasks == input.HasOngoingTasks ||
                    this.HasOngoingTasks.Equals(input.HasOngoingTasks)
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
                hashCode = hashCode * 59 + this.SubType.GetHashCode();
                if (this.PolicyId != null)
                    hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
                hashCode = hashCode * 59 + this.IsApplyAllSetting.GetHashCode();
                hashCode = hashCode * 59 + this.IsApplyQuota.GetHashCode();
                hashCode = hashCode * 59 + this.IsApplySharing.GetHashCode();
                hashCode = hashCode * 59 + this.IsApplyQuotaThreshold.GetHashCode();
                hashCode = hashCode * 59 + this.IsApplyDeactivatedElection.GetHashCode();
                hashCode = hashCode * 59 + this.IsApplyLifecycle.GetHashCode();
                if (this.LifecycleRenewalSetting != null)
                    hashCode = hashCode * 59 + this.LifecycleRenewalSetting.GetHashCode();
                if (this.Filter != null)
                    hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.SelectedObjects != null)
                    hashCode = hashCode * 59 + this.SelectedObjects.GetHashCode();
                hashCode = hashCode * 59 + this.HasOngoingTasks.GetHashCode();
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
