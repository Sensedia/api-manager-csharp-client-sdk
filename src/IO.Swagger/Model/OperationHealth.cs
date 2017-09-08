/* 
 * API Manager Portal
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// OperationHealth
    /// </summary>
    [DataContract]
    public partial class OperationHealth :  IEquatable<OperationHealth>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationHealth" /> class.
        /// </summary>
        /// <param name="Last24Hours">Last24Hours.</param>
        /// <param name="LastHour">LastHour.</param>
        /// <param name="LastMonth">LastMonth.</param>
        /// <param name="LastWeek">LastWeek.</param>
        /// <param name="Operation">Operation.</param>
        public OperationHealth(double? Last24Hours = default(double?), double? LastHour = default(double?), double? LastMonth = default(double?), double? LastWeek = default(double?), string Operation = default(string))
        {
            this.Last24Hours = Last24Hours;
            this.LastHour = LastHour;
            this.LastMonth = LastMonth;
            this.LastWeek = LastWeek;
            this.Operation = Operation;
        }
        
        /// <summary>
        /// Gets or Sets Last24Hours
        /// </summary>
        [DataMember(Name="last24Hours", EmitDefaultValue=false)]
        public double? Last24Hours { get; set; }

        /// <summary>
        /// Gets or Sets LastHour
        /// </summary>
        [DataMember(Name="lastHour", EmitDefaultValue=false)]
        public double? LastHour { get; set; }

        /// <summary>
        /// Gets or Sets LastMonth
        /// </summary>
        [DataMember(Name="lastMonth", EmitDefaultValue=false)]
        public double? LastMonth { get; set; }

        /// <summary>
        /// Gets or Sets LastWeek
        /// </summary>
        [DataMember(Name="lastWeek", EmitDefaultValue=false)]
        public double? LastWeek { get; set; }

        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [DataMember(Name="operation", EmitDefaultValue=false)]
        public string Operation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationHealth {\n");
            sb.Append("  Last24Hours: ").Append(Last24Hours).Append("\n");
            sb.Append("  LastHour: ").Append(LastHour).Append("\n");
            sb.Append("  LastMonth: ").Append(LastMonth).Append("\n");
            sb.Append("  LastWeek: ").Append(LastWeek).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as OperationHealth);
        }

        /// <summary>
        /// Returns true if OperationHealth instances are equal
        /// </summary>
        /// <param name="other">Instance of OperationHealth to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperationHealth other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Last24Hours == other.Last24Hours ||
                    this.Last24Hours != null &&
                    this.Last24Hours.Equals(other.Last24Hours)
                ) && 
                (
                    this.LastHour == other.LastHour ||
                    this.LastHour != null &&
                    this.LastHour.Equals(other.LastHour)
                ) && 
                (
                    this.LastMonth == other.LastMonth ||
                    this.LastMonth != null &&
                    this.LastMonth.Equals(other.LastMonth)
                ) && 
                (
                    this.LastWeek == other.LastWeek ||
                    this.LastWeek != null &&
                    this.LastWeek.Equals(other.LastWeek)
                ) && 
                (
                    this.Operation == other.Operation ||
                    this.Operation != null &&
                    this.Operation.Equals(other.Operation)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Last24Hours != null)
                    hash = hash * 59 + this.Last24Hours.GetHashCode();
                if (this.LastHour != null)
                    hash = hash * 59 + this.LastHour.GetHashCode();
                if (this.LastMonth != null)
                    hash = hash * 59 + this.LastMonth.GetHashCode();
                if (this.LastWeek != null)
                    hash = hash * 59 + this.LastWeek.GetHashCode();
                if (this.Operation != null)
                    hash = hash * 59 + this.Operation.GetHashCode();
                return hash;
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