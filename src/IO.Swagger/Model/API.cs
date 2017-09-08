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
    /// API Model
    /// </summary>
    [DataContract]
    public partial class API :  IEquatable<API>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="API" /> class.
        /// </summary>
        /// <param name="AccessTokenExpiresIn">AccessTokenExpiresIn.</param>
        /// <param name="AppsCount">AppsCount.</param>
        /// <param name="BasePath">BasePath.</param>
        /// <param name="CreationDate">CreationDate.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Environments">Environments.</param>
        /// <param name="Icon">Icon.</param>
        /// <param name="Id">Id.</param>
        /// <param name="LastRevision">LastRevision.</param>
        /// <param name="LastVersion">LastVersion.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Owner">Owner.</param>
        /// <param name="ParentId">ParentId.</param>
        /// <param name="Plans">Plans.</param>
        /// <param name="PrivateAPI">PrivateAPI.</param>
        /// <param name="ReleaseNotes">ReleaseNotes.</param>
        /// <param name="Revisions">Revisions.</param>
        /// <param name="TeamVisibility">TeamVisibility.</param>
        /// <param name="Users">Users.</param>
        /// <param name="Version">Version.</param>
        /// <param name="VisibilityType">VisibilityType.</param>
        public API(long? AccessTokenExpiresIn = default(long?), long? AppsCount = default(long?), string BasePath = default(string), DateTime? CreationDate = default(DateTime?), string Description = default(string), List<EnvironmentSimpleBean> Environments = default(List<EnvironmentSimpleBean>), string Icon = default(string), long? Id = default(long?), RevisionSimpleBean LastRevision = default(RevisionSimpleBean), bool? LastVersion = default(bool?), string Name = default(string), UserBean Owner = default(UserBean), long? ParentId = default(long?), List<PlanSimpleBean> Plans = default(List<PlanSimpleBean>), bool? PrivateAPI = default(bool?), string ReleaseNotes = default(string), List<RevisionSimpleBean> Revisions = default(List<RevisionSimpleBean>), TeamBean TeamVisibility = default(TeamBean), List<APIUserBean> Users = default(List<APIUserBean>), string Version = default(string), VisibilityTypeEnum? VisibilityType = default(VisibilityTypeEnum?))
        {
            this.AccessTokenExpiresIn = AccessTokenExpiresIn;
            this.AppsCount = AppsCount;
            this.BasePath = BasePath;
            this.CreationDate = CreationDate;
            this.Description = Description;
            this.Environments = Environments;
            this.Icon = Icon;
            this.Id = Id;
            this.LastRevision = LastRevision;
            this.LastVersion = LastVersion;
            this.Name = Name;
            this.Owner = Owner;
            this.ParentId = ParentId;
            this.Plans = Plans;
            this.PrivateAPI = PrivateAPI;
            this.ReleaseNotes = ReleaseNotes;
            this.Revisions = Revisions;
            this.TeamVisibility = TeamVisibility;
            this.Users = Users;
            this.Version = Version;
            this.VisibilityType = VisibilityType;
        }
        
        /// <summary>
        /// Gets or Sets AccessTokenExpiresIn
        /// </summary>
        [DataMember(Name="accessTokenExpiresIn", EmitDefaultValue=false)]
        public long? AccessTokenExpiresIn { get; set; }

        /// <summary>
        /// Gets or Sets AppsCount
        /// </summary>
        [DataMember(Name="appsCount", EmitDefaultValue=false)]
        public long? AppsCount { get; set; }

        /// <summary>
        /// Gets or Sets BasePath
        /// </summary>
        [DataMember(Name="basePath", EmitDefaultValue=false)]
        public string BasePath { get; set; }

        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Environments
        /// </summary>
        [DataMember(Name="environments", EmitDefaultValue=false)]
        public List<EnvironmentSimpleBean> Environments { get; set; }

        /// <summary>
        /// Gets or Sets Icon
        /// </summary>
        [DataMember(Name="icon", EmitDefaultValue=false)]
        public string Icon { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets LastRevision
        /// </summary>
        [DataMember(Name="lastRevision", EmitDefaultValue=false)]
        public RevisionSimpleBean LastRevision { get; set; }

        /// <summary>
        /// Gets or Sets LastVersion
        /// </summary>
        [DataMember(Name="lastVersion", EmitDefaultValue=false)]
        public bool? LastVersion { get; set; }

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
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name="parentId", EmitDefaultValue=false)]
        public long? ParentId { get; set; }

        /// <summary>
        /// Gets or Sets Plans
        /// </summary>
        [DataMember(Name="plans", EmitDefaultValue=false)]
        public List<PlanSimpleBean> Plans { get; set; }

        /// <summary>
        /// Gets or Sets PrivateAPI
        /// </summary>
        [DataMember(Name="privateAPI", EmitDefaultValue=false)]
        public bool? PrivateAPI { get; set; }

        /// <summary>
        /// Gets or Sets ReleaseNotes
        /// </summary>
        [DataMember(Name="releaseNotes", EmitDefaultValue=false)]
        public string ReleaseNotes { get; set; }

        /// <summary>
        /// Gets or Sets Revisions
        /// </summary>
        [DataMember(Name="revisions", EmitDefaultValue=false)]
        public List<RevisionSimpleBean> Revisions { get; set; }

        /// <summary>
        /// Gets or Sets TeamVisibility
        /// </summary>
        [DataMember(Name="teamVisibility", EmitDefaultValue=false)]
        public TeamBean TeamVisibility { get; set; }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<APIUserBean> Users { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class API {\n");
            sb.Append("  AccessTokenExpiresIn: ").Append(AccessTokenExpiresIn).Append("\n");
            sb.Append("  AppsCount: ").Append(AppsCount).Append("\n");
            sb.Append("  BasePath: ").Append(BasePath).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Environments: ").Append(Environments).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastRevision: ").Append(LastRevision).Append("\n");
            sb.Append("  LastVersion: ").Append(LastVersion).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  Plans: ").Append(Plans).Append("\n");
            sb.Append("  PrivateAPI: ").Append(PrivateAPI).Append("\n");
            sb.Append("  ReleaseNotes: ").Append(ReleaseNotes).Append("\n");
            sb.Append("  Revisions: ").Append(Revisions).Append("\n");
            sb.Append("  TeamVisibility: ").Append(TeamVisibility).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(obj as API);
        }

        /// <summary>
        /// Returns true if API instances are equal
        /// </summary>
        /// <param name="other">Instance of API to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(API other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccessTokenExpiresIn == other.AccessTokenExpiresIn ||
                    this.AccessTokenExpiresIn != null &&
                    this.AccessTokenExpiresIn.Equals(other.AccessTokenExpiresIn)
                ) && 
                (
                    this.AppsCount == other.AppsCount ||
                    this.AppsCount != null &&
                    this.AppsCount.Equals(other.AppsCount)
                ) && 
                (
                    this.BasePath == other.BasePath ||
                    this.BasePath != null &&
                    this.BasePath.Equals(other.BasePath)
                ) && 
                (
                    this.CreationDate == other.CreationDate ||
                    this.CreationDate != null &&
                    this.CreationDate.Equals(other.CreationDate)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Environments == other.Environments ||
                    this.Environments != null &&
                    this.Environments.SequenceEqual(other.Environments)
                ) && 
                (
                    this.Icon == other.Icon ||
                    this.Icon != null &&
                    this.Icon.Equals(other.Icon)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LastRevision == other.LastRevision ||
                    this.LastRevision != null &&
                    this.LastRevision.Equals(other.LastRevision)
                ) && 
                (
                    this.LastVersion == other.LastVersion ||
                    this.LastVersion != null &&
                    this.LastVersion.Equals(other.LastVersion)
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
                    this.ParentId == other.ParentId ||
                    this.ParentId != null &&
                    this.ParentId.Equals(other.ParentId)
                ) && 
                (
                    this.Plans == other.Plans ||
                    this.Plans != null &&
                    this.Plans.SequenceEqual(other.Plans)
                ) && 
                (
                    this.PrivateAPI == other.PrivateAPI ||
                    this.PrivateAPI != null &&
                    this.PrivateAPI.Equals(other.PrivateAPI)
                ) && 
                (
                    this.ReleaseNotes == other.ReleaseNotes ||
                    this.ReleaseNotes != null &&
                    this.ReleaseNotes.Equals(other.ReleaseNotes)
                ) && 
                (
                    this.Revisions == other.Revisions ||
                    this.Revisions != null &&
                    this.Revisions.SequenceEqual(other.Revisions)
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
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.AccessTokenExpiresIn != null)
                    hash = hash * 59 + this.AccessTokenExpiresIn.GetHashCode();
                if (this.AppsCount != null)
                    hash = hash * 59 + this.AppsCount.GetHashCode();
                if (this.BasePath != null)
                    hash = hash * 59 + this.BasePath.GetHashCode();
                if (this.CreationDate != null)
                    hash = hash * 59 + this.CreationDate.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Environments != null)
                    hash = hash * 59 + this.Environments.GetHashCode();
                if (this.Icon != null)
                    hash = hash * 59 + this.Icon.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LastRevision != null)
                    hash = hash * 59 + this.LastRevision.GetHashCode();
                if (this.LastVersion != null)
                    hash = hash * 59 + this.LastVersion.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();
                if (this.ParentId != null)
                    hash = hash * 59 + this.ParentId.GetHashCode();
                if (this.Plans != null)
                    hash = hash * 59 + this.Plans.GetHashCode();
                if (this.PrivateAPI != null)
                    hash = hash * 59 + this.PrivateAPI.GetHashCode();
                if (this.ReleaseNotes != null)
                    hash = hash * 59 + this.ReleaseNotes.GetHashCode();
                if (this.Revisions != null)
                    hash = hash * 59 + this.Revisions.GetHashCode();
                if (this.TeamVisibility != null)
                    hash = hash * 59 + this.TeamVisibility.GetHashCode();
                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
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
