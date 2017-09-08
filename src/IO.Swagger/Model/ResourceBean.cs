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
    /// ResourceBean
    /// </summary>
    [DataContract]
    public partial class ResourceBean :  IEquatable<ResourceBean>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceBean" /> class.
        /// </summary>
        /// <param name="ApiBroken">ApiBroken.</param>
        /// <param name="Config">Config.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Destination">Destination.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Interceptors">Interceptors.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Operations">Operations.</param>
        /// <param name="Timeout">Timeout.</param>
        public ResourceBean(bool? ApiBroken = default(bool?), Object Config = default(Object), string Description = default(string), string Destination = default(string), long? Id = default(long?), List<InterceptorBean> Interceptors = default(List<InterceptorBean>), string Name = default(string), List<OperationBean> Operations = default(List<OperationBean>), string Timeout = default(string))
        {
            this.ApiBroken = ApiBroken;
            this.Config = Config;
            this.Description = Description;
            this.Destination = Destination;
            this.Id = Id;
            this.Interceptors = Interceptors;
            this.Name = Name;
            this.Operations = Operations;
            this.Timeout = Timeout;
        }
        
        /// <summary>
        /// Gets or Sets ApiBroken
        /// </summary>
        [DataMember(Name="apiBroken", EmitDefaultValue=false)]
        public bool? ApiBroken { get; set; }

        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name="config", EmitDefaultValue=false)]
        public Object Config { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Destination
        /// </summary>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public string Destination { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Interceptors
        /// </summary>
        [DataMember(Name="interceptors", EmitDefaultValue=false)]
        public List<InterceptorBean> Interceptors { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Operations
        /// </summary>
        [DataMember(Name="operations", EmitDefaultValue=false)]
        public List<OperationBean> Operations { get; set; }

        /// <summary>
        /// Gets or Sets Timeout
        /// </summary>
        [DataMember(Name="timeout", EmitDefaultValue=false)]
        public string Timeout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceBean {\n");
            sb.Append("  ApiBroken: ").Append(ApiBroken).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Interceptors: ").Append(Interceptors).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Operations: ").Append(Operations).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
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
            return this.Equals(obj as ResourceBean);
        }

        /// <summary>
        /// Returns true if ResourceBean instances are equal
        /// </summary>
        /// <param name="other">Instance of ResourceBean to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceBean other)
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
                    this.Config == other.Config ||
                    this.Config != null &&
                    this.Config.Equals(other.Config)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Destination == other.Destination ||
                    this.Destination != null &&
                    this.Destination.Equals(other.Destination)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Interceptors == other.Interceptors ||
                    this.Interceptors != null &&
                    this.Interceptors.SequenceEqual(other.Interceptors)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Operations == other.Operations ||
                    this.Operations != null &&
                    this.Operations.SequenceEqual(other.Operations)
                ) && 
                (
                    this.Timeout == other.Timeout ||
                    this.Timeout != null &&
                    this.Timeout.Equals(other.Timeout)
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
                if (this.Config != null)
                    hash = hash * 59 + this.Config.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Destination != null)
                    hash = hash * 59 + this.Destination.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Interceptors != null)
                    hash = hash * 59 + this.Interceptors.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Operations != null)
                    hash = hash * 59 + this.Operations.GetHashCode();
                if (this.Timeout != null)
                    hash = hash * 59 + this.Timeout.GetHashCode();
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
