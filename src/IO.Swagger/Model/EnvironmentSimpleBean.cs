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
    /// EnvironmentSimpleBean
    /// </summary>
    [DataContract]
    public partial class EnvironmentSimpleBean :  IEquatable<EnvironmentSimpleBean>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets VisibilityType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VisibilityTypeEnum
        {
            
            /// <summary>
            /// Enum ORGANIZATION for "ORGANIZATION"
            /// </summary>
            [EnumMember(Value = "ORGANIZATION")]
            ORGANIZATION,
            
            /// <summary>
            /// Enum TEAM for "TEAM"
            /// </summary>
            [EnumMember(Value = "TEAM")]
            TEAM,
            
            /// <summary>
            /// Enum ME for "ME"
            /// </summary>
            [EnumMember(Value = "ME")]
            ME
        }

        /// <summary>
        /// Gets or Sets VisibilityType
        /// </summary>
        [DataMember(Name="visibilityType", EmitDefaultValue=false)]
        public VisibilityTypeEnum? VisibilityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentSimpleBean" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="InboundUrl">InboundUrl.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Owner">Owner.</param>
        /// <param name="RevisionDeployed">RevisionDeployed.</param>
        /// <param name="TeamVisibility">TeamVisibility.</param>
        /// <param name="Users">Users.</param>
        /// <param name="VisibilityType">VisibilityType.</param>
        public EnvironmentSimpleBean(long? Id = default(long?), string InboundUrl = default(string), string Name = default(string), UserBean Owner = default(UserBean), DeploymentSimpleBean RevisionDeployed = default(DeploymentSimpleBean), TeamBean TeamVisibility = default(TeamBean), List<EvironmentUserBean> Users = default(List<EvironmentUserBean>), VisibilityTypeEnum? VisibilityType = default(VisibilityTypeEnum?))
        {
            this.Id = Id;
            this.InboundUrl = InboundUrl;
            this.Name = Name;
            this.Owner = Owner;
            this.RevisionDeployed = RevisionDeployed;
            this.TeamVisibility = TeamVisibility;
            this.Users = Users;
            this.VisibilityType = VisibilityType;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets InboundUrl
        /// </summary>
        [DataMember(Name="inboundUrl", EmitDefaultValue=false)]
        public string InboundUrl { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public UserBean Owner { get; set; }

        /// <summary>
        /// Gets or Sets RevisionDeployed
        /// </summary>
        [DataMember(Name="revisionDeployed", EmitDefaultValue=false)]
        public DeploymentSimpleBean RevisionDeployed { get; set; }

        /// <summary>
        /// Gets or Sets TeamVisibility
        /// </summary>
        [DataMember(Name="teamVisibility", EmitDefaultValue=false)]
        public TeamBean TeamVisibility { get; set; }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<EvironmentUserBean> Users { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvironmentSimpleBean {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InboundUrl: ").Append(InboundUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  RevisionDeployed: ").Append(RevisionDeployed).Append("\n");
            sb.Append("  TeamVisibility: ").Append(TeamVisibility).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  VisibilityType: ").Append(VisibilityType).Append("\n");
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
            return this.Equals(obj as EnvironmentSimpleBean);
        }

        /// <summary>
        /// Returns true if EnvironmentSimpleBean instances are equal
        /// </summary>
        /// <param name="other">Instance of EnvironmentSimpleBean to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvironmentSimpleBean other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.InboundUrl == other.InboundUrl ||
                    this.InboundUrl != null &&
                    this.InboundUrl.Equals(other.InboundUrl)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Owner == other.Owner ||
                    this.Owner != null &&
                    this.Owner.Equals(other.Owner)
                ) && 
                (
                    this.RevisionDeployed == other.RevisionDeployed ||
                    this.RevisionDeployed != null &&
                    this.RevisionDeployed.Equals(other.RevisionDeployed)
                ) && 
                (
                    this.TeamVisibility == other.TeamVisibility ||
                    this.TeamVisibility != null &&
                    this.TeamVisibility.Equals(other.TeamVisibility)
                ) && 
                (
                    this.Users == other.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(other.Users)
                ) && 
                (
                    this.VisibilityType == other.VisibilityType ||
                    this.VisibilityType != null &&
                    this.VisibilityType.Equals(other.VisibilityType)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.InboundUrl != null)
                    hash = hash * 59 + this.InboundUrl.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();
                if (this.RevisionDeployed != null)
                    hash = hash * 59 + this.RevisionDeployed.GetHashCode();
                if (this.TeamVisibility != null)
                    hash = hash * 59 + this.TeamVisibility.GetHashCode();
                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();
                if (this.VisibilityType != null)
                    hash = hash * 59 + this.VisibilityType.GetHashCode();
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
