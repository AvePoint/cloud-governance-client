

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
    /// MultiGeoSetting
    /// </summary>
    [DataContract(Name = "MultiGeoSetting")]
    public partial class MultiGeoSetting : IEquatable<MultiGeoSetting>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ControlMode
        /// </summary>
        [DataMember(Name = "controlMode", EmitDefaultValue = false)]
        public MultiGeoControlMode? ControlMode { get; set; }
        /// <summary>
        /// Gets or Sets LocationAssignBy
        /// </summary>
        [DataMember(Name = "locationAssignBy", EmitDefaultValue = false)]
        public AssignBy? LocationAssignBy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiGeoSetting" /> class.
        /// </summary>
        /// <param name="isEnabled">isEnabled (default to false).</param>
        /// <param name="controlMode">controlMode.</param>
        /// <param name="defaultLocation">defaultLocation.</param>
        /// <param name="selectedLocations">selectedLocations.</param>
        /// <param name="locationAssignBy">locationAssignBy.</param>
        /// <param name="userRoleForLocation">userRoleForLocation.</param>
        /// <param name="allLocations">allLocations.</param>
        public MultiGeoSetting(bool isEnabled = false, MultiGeoControlMode? controlMode = default(MultiGeoControlMode?), GeoLocationBase defaultLocation = default(GeoLocationBase), List<GeoLocationBase> selectedLocations = default(List<GeoLocationBase>), AssignBy? locationAssignBy = default(AssignBy?), string userRoleForLocation = default(string), List<GeoLocationBase> allLocations = default(List<GeoLocationBase>))
        {
            this.IsEnabled = isEnabled;
            this.ControlMode = controlMode;
            this.DefaultLocation = defaultLocation;
            this.SelectedLocations = selectedLocations;
            this.LocationAssignBy = locationAssignBy;
            this.UserRoleForLocation = userRoleForLocation;
            this.AllLocations = allLocations;
        }

        /// <summary>
        /// Gets or Sets IsEnabled
        /// </summary>
        [DataMember(Name = "isEnabled", EmitDefaultValue = false)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets DefaultLocation
        /// </summary>
        [DataMember(Name = "defaultLocation", EmitDefaultValue = true)]
        public GeoLocationBase DefaultLocation { get; set; }

        /// <summary>
        /// Gets or Sets SelectedLocations
        /// </summary>
        [DataMember(Name = "selectedLocations", EmitDefaultValue = true)]
        public List<GeoLocationBase> SelectedLocations { get; set; }

        /// <summary>
        /// Gets or Sets UserRoleForLocation
        /// </summary>
        [DataMember(Name = "userRoleForLocation", EmitDefaultValue = true)]
        public string UserRoleForLocation { get; set; }

        /// <summary>
        /// Gets or Sets AllLocations
        /// </summary>
        [DataMember(Name = "allLocations", EmitDefaultValue = true)]
        public List<GeoLocationBase> AllLocations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultiGeoSetting {\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  ControlMode: ").Append(ControlMode).Append("\n");
            sb.Append("  DefaultLocation: ").Append(DefaultLocation).Append("\n");
            sb.Append("  SelectedLocations: ").Append(SelectedLocations).Append("\n");
            sb.Append("  LocationAssignBy: ").Append(LocationAssignBy).Append("\n");
            sb.Append("  UserRoleForLocation: ").Append(UserRoleForLocation).Append("\n");
            sb.Append("  AllLocations: ").Append(AllLocations).Append("\n");
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
            return this.Equals(input as MultiGeoSetting);
        }

        /// <summary>
        /// Returns true if MultiGeoSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of MultiGeoSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultiGeoSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsEnabled == input.IsEnabled ||
                    this.IsEnabled.Equals(input.IsEnabled)
                ) && 
                (
                    this.ControlMode == input.ControlMode ||
                    this.ControlMode.Equals(input.ControlMode)
                ) && 
                (
                    this.DefaultLocation == input.DefaultLocation ||
                    (this.DefaultLocation != null &&
                    this.DefaultLocation.Equals(input.DefaultLocation))
                ) && 
                (
                    this.SelectedLocations == input.SelectedLocations ||
                    this.SelectedLocations != null &&
                    input.SelectedLocations != null &&
                    this.SelectedLocations.SequenceEqual(input.SelectedLocations)
                ) && 
                (
                    this.LocationAssignBy == input.LocationAssignBy ||
                    this.LocationAssignBy.Equals(input.LocationAssignBy)
                ) && 
                (
                    this.UserRoleForLocation == input.UserRoleForLocation ||
                    (this.UserRoleForLocation != null &&
                    this.UserRoleForLocation.Equals(input.UserRoleForLocation))
                ) && 
                (
                    this.AllLocations == input.AllLocations ||
                    this.AllLocations != null &&
                    input.AllLocations != null &&
                    this.AllLocations.SequenceEqual(input.AllLocations)
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
                hashCode = hashCode * 59 + this.ControlMode.GetHashCode();
                if (this.DefaultLocation != null)
                    hashCode = hashCode * 59 + this.DefaultLocation.GetHashCode();
                if (this.SelectedLocations != null)
                    hashCode = hashCode * 59 + this.SelectedLocations.GetHashCode();
                hashCode = hashCode * 59 + this.LocationAssignBy.GetHashCode();
                if (this.UserRoleForLocation != null)
                    hashCode = hashCode * 59 + this.UserRoleForLocation.GetHashCode();
                if (this.AllLocations != null)
                    hashCode = hashCode * 59 + this.AllLocations.GetHashCode();
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
