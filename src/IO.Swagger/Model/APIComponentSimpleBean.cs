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
    /// APIComponentSimpleBean
    /// </summary>
    [DataContract]
    public partial class APIComponentSimpleBean :  IEquatable<APIComponentSimpleBean>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIComponentSimpleBean" /> class.
        /// </summary>
        /// <param name="ApiBroken">ApiBroken.</param>
        /// <param name="Id">Id.</param>
        /// <param name="PlanBroken">PlanBroken.</param>
        public APIComponentSimpleBean(bool? ApiBroken = default(bool?), long? Id = default(long?), bool? PlanBroken = default(bool?))
        {
            this.ApiBroken = ApiBroken;
            this.Id = Id;
            this.PlanBroken = PlanBroken;
        }
        
        /// <summary>
        /// Gets or Sets ApiBroken
        /// </summary>
        [DataMember(Name="apiBroken", EmitDefaultValue=false)]
        public bool? ApiBroken { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets PlanBroken
        /// </summary>
        [DataMember(Name="planBroken", EmitDefaultValue=false)]
        public bool? PlanBroken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class APIComponentSimpleBean {\n");
            sb.Append("  ApiBroken: ").Append(ApiBroken).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PlanBroken: ").Append(PlanBroken).Append("\n");
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
            return this.Equals(obj as APIComponentSimpleBean);
        }

        /// <summary>
        /// Returns true if APIComponentSimpleBean instances are equal
        /// </summary>
        /// <param name="other">Instance of APIComponentSimpleBean to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APIComponentSimpleBean other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApiBroken == other.ApiBroken ||
                    this.ApiBroken != null &&
                    this.ApiBroken.Equals(other.ApiBroken)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.PlanBroken == other.PlanBroken ||
                    this.PlanBroken != null &&
                    this.PlanBroken.Equals(other.PlanBroken)
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
                if (this.ApiBroken != null)
                    hash = hash * 59 + this.ApiBroken.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.PlanBroken != null)
                    hash = hash * 59 + this.PlanBroken.GetHashCode();
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
