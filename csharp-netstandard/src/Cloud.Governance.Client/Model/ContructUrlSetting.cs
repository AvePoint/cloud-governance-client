

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
    /// ContructUrlSetting
    /// </summary>
    [DataContract(Name = "ContructUrlSetting")]
    public partial class ContructUrlSetting : IEquatable<ContructUrlSetting>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ContructUrlAssignBy
        /// </summary>
        [DataMember(Name = "contructUrlAssignBy", EmitDefaultValue = false)]
        public AssignBy? ContructUrlAssignBy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContructUrlSetting" /> class.
        /// </summary>
        /// <param name="rules">rules.</param>
        /// <param name="suffix">suffix.</param>
        /// <param name="connection">connection.</param>
        /// <param name="contructUrlAssignBy">contructUrlAssignBy.</param>
        public ContructUrlSetting(List<string> rules = default(List<string>), string suffix = default(string), string connection = default(string), AssignBy? contructUrlAssignBy = default(AssignBy?))
        {
            this.Rules = rules;
            this.Suffix = suffix;
            this.Connection = connection;
            this.ContructUrlAssignBy = contructUrlAssignBy;
        }

        /// <summary>
        /// Gets or Sets Rules
        /// </summary>
        [DataMember(Name = "rules", EmitDefaultValue = true)]
        public List<string> Rules { get; set; }

        /// <summary>
        /// Gets or Sets Suffix
        /// </summary>
        [DataMember(Name = "suffix", EmitDefaultValue = true)]
        public string Suffix { get; set; }

        /// <summary>
        /// Gets or Sets Connection
        /// </summary>
        [DataMember(Name = "connection", EmitDefaultValue = true)]
        public string Connection { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContructUrlSetting {\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
            sb.Append("  Suffix: ").Append(Suffix).Append("\n");
            sb.Append("  Connection: ").Append(Connection).Append("\n");
            sb.Append("  ContructUrlAssignBy: ").Append(ContructUrlAssignBy).Append("\n");
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
            return this.Equals(input as ContructUrlSetting);
        }

        /// <summary>
        /// Returns true if ContructUrlSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of ContructUrlSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContructUrlSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Rules == input.Rules ||
                    this.Rules != null &&
                    input.Rules != null &&
                    this.Rules.SequenceEqual(input.Rules)
                ) && 
                (
                    this.Suffix == input.Suffix ||
                    (this.Suffix != null &&
                    this.Suffix.Equals(input.Suffix))
                ) && 
                (
                    this.Connection == input.Connection ||
                    (this.Connection != null &&
                    this.Connection.Equals(input.Connection))
                ) && 
                (
                    this.ContructUrlAssignBy == input.ContructUrlAssignBy ||
                    this.ContructUrlAssignBy.Equals(input.ContructUrlAssignBy)
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
                if (this.Rules != null)
                    hashCode = hashCode * 59 + this.Rules.GetHashCode();
                if (this.Suffix != null)
                    hashCode = hashCode * 59 + this.Suffix.GetHashCode();
                if (this.Connection != null)
                    hashCode = hashCode * 59 + this.Connection.GetHashCode();
                hashCode = hashCode * 59 + this.ContructUrlAssignBy.GetHashCode();
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
