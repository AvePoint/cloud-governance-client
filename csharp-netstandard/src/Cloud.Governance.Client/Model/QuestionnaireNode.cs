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
    /// QuestionnaireNode
    /// </summary>
    [DataContract]
    public partial class QuestionnaireNode :  IEquatable<QuestionnaireNode>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public QuestionnaireNodeType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionnaireNode" /> class.
        /// </summary>
        /// <param name="objectIds">objectIds.</param>
        /// <param name="type">type.</param>
        /// <param name="joints">joints.</param>
        /// <param name="msg">msg.</param>
        public QuestionnaireNode(List<Guid> objectIds = default(List<Guid>), QuestionnaireNodeType type = default(QuestionnaireNodeType), List<JointNode> joints = default(List<JointNode>), string msg = default(string))
        {
            this.ObjectIds = objectIds;
            this.Type = type;
            this.Joints = joints;
            this.Msg = msg;
        }
        
        /// <summary>
        /// Gets or Sets ObjectIds
        /// </summary>
        [DataMember(Name="objectIds", EmitDefaultValue=true)]
        public List<Guid> ObjectIds { get; set; }

        /// <summary>
        /// Gets or Sets Joints
        /// </summary>
        [DataMember(Name="joints", EmitDefaultValue=true)]
        public List<JointNode> Joints { get; set; }

        /// <summary>
        /// Gets or Sets Msg
        /// </summary>
        [DataMember(Name="msg", EmitDefaultValue=true)]
        public string Msg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuestionnaireNode {\n");
            sb.Append("  ObjectIds: ").Append(ObjectIds).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Joints: ").Append(Joints).Append("\n");
            sb.Append("  Msg: ").Append(Msg).Append("\n");
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
            return this.Equals(input as QuestionnaireNode);
        }

        /// <summary>
        /// Returns true if QuestionnaireNode instances are equal
        /// </summary>
        /// <param name="input">Instance of QuestionnaireNode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuestionnaireNode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectIds == input.ObjectIds ||
                    this.ObjectIds != null &&
                    input.ObjectIds != null &&
                    this.ObjectIds.SequenceEqual(input.ObjectIds)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Joints == input.Joints ||
                    this.Joints != null &&
                    input.Joints != null &&
                    this.Joints.SequenceEqual(input.Joints)
                ) && 
                (
                    this.Msg == input.Msg ||
                    (this.Msg != null &&
                    this.Msg.Equals(input.Msg))
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
                if (this.ObjectIds != null)
                    hashCode = hashCode * 59 + this.ObjectIds.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Joints != null)
                    hashCode = hashCode * 59 + this.Joints.GetHashCode();
                if (this.Msg != null)
                    hashCode = hashCode * 59 + this.Msg.GetHashCode();
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
