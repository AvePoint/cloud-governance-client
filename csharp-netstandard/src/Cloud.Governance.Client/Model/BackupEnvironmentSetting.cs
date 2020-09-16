

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
    /// BackupEnvironmentSetting
    /// </summary>
    [DataContract(Name = "BackupEnvironmentSetting")]
    public partial class BackupEnvironmentSetting : IEquatable<BackupEnvironmentSetting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupEnvironmentSetting" /> class.
        /// </summary>
        /// <param name="isBackupSource">isBackupSource.</param>
        /// <param name="isBackupDestination">isBackupDestination.</param>
        /// <param name="storagePolicy">storagePolicy.</param>
        public BackupEnvironmentSetting(bool isBackupSource = default(bool), bool isBackupDestination = default(bool), GuidModel storagePolicy = default(GuidModel))
        {
            this.IsBackupSource = isBackupSource;
            this.IsBackupDestination = isBackupDestination;
            this.StoragePolicy = storagePolicy;
        }

        /// <summary>
        /// Gets or Sets IsBackupSource
        /// </summary>
        [DataMember(Name = "isBackupSource", EmitDefaultValue = false)]
        public bool IsBackupSource { get; set; }

        /// <summary>
        /// Gets or Sets IsBackupDestination
        /// </summary>
        [DataMember(Name = "isBackupDestination", EmitDefaultValue = false)]
        public bool IsBackupDestination { get; set; }

        /// <summary>
        /// Gets or Sets StoragePolicy
        /// </summary>
        [DataMember(Name = "storagePolicy", EmitDefaultValue = false)]
        public GuidModel StoragePolicy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupEnvironmentSetting {\n");
            sb.Append("  IsBackupSource: ").Append(IsBackupSource).Append("\n");
            sb.Append("  IsBackupDestination: ").Append(IsBackupDestination).Append("\n");
            sb.Append("  StoragePolicy: ").Append(StoragePolicy).Append("\n");
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
            return this.Equals(input as BackupEnvironmentSetting);
        }

        /// <summary>
        /// Returns true if BackupEnvironmentSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of BackupEnvironmentSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackupEnvironmentSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsBackupSource == input.IsBackupSource ||
                    this.IsBackupSource.Equals(input.IsBackupSource)
                ) && 
                (
                    this.IsBackupDestination == input.IsBackupDestination ||
                    this.IsBackupDestination.Equals(input.IsBackupDestination)
                ) && 
                (
                    this.StoragePolicy == input.StoragePolicy ||
                    (this.StoragePolicy != null &&
                    this.StoragePolicy.Equals(input.StoragePolicy))
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
                hashCode = hashCode * 59 + this.IsBackupSource.GetHashCode();
                hashCode = hashCode * 59 + this.IsBackupDestination.GetHashCode();
                if (this.StoragePolicy != null)
                    hashCode = hashCode * 59 + this.StoragePolicy.GetHashCode();
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
