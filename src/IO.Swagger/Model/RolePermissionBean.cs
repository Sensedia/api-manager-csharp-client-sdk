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
    /// RolePermissionBean
    /// </summary>
    [DataContract]
    public partial class RolePermissionBean :  IEquatable<RolePermissionBean>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Permission
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PermissionEnum
        {
            
            /// <summary>
            /// Enum DASHBOARD for "DASHBOARD"
            /// </summary>
            [EnumMember(Value = "DASHBOARD")]
            DASHBOARD,
            
            /// <summary>
            /// Enum ANALYTICS for "ANALYTICS"
            /// </summary>
            [EnumMember(Value = "ANALYTICS")]
            ANALYTICS,
            
            /// <summary>
            /// Enum APISHEALTH for "APIS_HEALTH"
            /// </summary>
            [EnumMember(Value = "APIS_HEALTH")]
            APISHEALTH,
            
            /// <summary>
            /// Enum APIS for "APIS"
            /// </summary>
            [EnumMember(Value = "APIS")]
            APIS,
            
            /// <summary>
            /// Enum BAAS for "BAAS"
            /// </summary>
            [EnumMember(Value = "BAAS")]
            BAAS,
            
            /// <summary>
            /// Enum NOTIFICATIONS for "NOTIFICATIONS"
            /// </summary>
            [EnumMember(Value = "NOTIFICATIONS")]
            NOTIFICATIONS,
            
            /// <summary>
            /// Enum PLANS for "PLANS"
            /// </summary>
            [EnumMember(Value = "PLANS")]
            PLANS,
            
            /// <summary>
            /// Enum APPS for "APPS"
            /// </summary>
            [EnumMember(Value = "APPS")]
            APPS,
            
            /// <summary>
            /// Enum ACCESSTOKENS for "ACCESS_TOKENS"
            /// </summary>
            [EnumMember(Value = "ACCESS_TOKENS")]
            ACCESSTOKENS,
            
            /// <summary>
            /// Enum SECRETS for "SECRETS"
            /// </summary>
            [EnumMember(Value = "SECRETS")]
            SECRETS,
            
            /// <summary>
            /// Enum DEVELOPERS for "DEVELOPERS"
            /// </summary>
            [EnumMember(Value = "DEVELOPERS")]
            DEVELOPERS,
            
            /// <summary>
            /// Enum TRACE for "TRACE"
            /// </summary>
            [EnumMember(Value = "TRACE")]
            TRACE,
            
            /// <summary>
            /// Enum ENVIRONMENTS for "ENVIRONMENTS"
            /// </summary>
            [EnumMember(Value = "ENVIRONMENTS")]
            ENVIRONMENTS,
            
            /// <summary>
            /// Enum CALLBACKS for "CALLBACKS"
            /// </summary>
            [EnumMember(Value = "CALLBACKS")]
            CALLBACKS,
            
            /// <summary>
            /// Enum HEALTHCHECKS for "HEALTH_CHECKS"
            /// </summary>
            [EnumMember(Value = "HEALTH_CHECKS")]
            HEALTHCHECKS,
            
            /// <summary>
            /// Enum USERS for "USERS"
            /// </summary>
            [EnumMember(Value = "USERS")]
            USERS,
            
            /// <summary>
            /// Enum ROLES for "ROLES"
            /// </summary>
            [EnumMember(Value = "ROLES")]
            ROLES,
            
            /// <summary>
            /// Enum TEAMS for "TEAMS"
            /// </summary>
            [EnumMember(Value = "TEAMS")]
            TEAMS,
            
            /// <summary>
            /// Enum AUDIT for "AUDIT"
            /// </summary>
            [EnumMember(Value = "AUDIT")]
            AUDIT,
            
            /// <summary>
            /// Enum OAUTH for "OAUTH"
            /// </summary>
            [EnumMember(Value = "OAUTH")]
            OAUTH,
            
            /// <summary>
            /// Enum LDAP for "LDAP"
            /// </summary>
            [EnumMember(Value = "LDAP")]
            LDAP,
            
            /// <summary>
            /// Enum ROOT for "ROOT"
            /// </summary>
            [EnumMember(Value = "ROOT")]
            ROOT,
            
            /// <summary>
            /// Enum NONE for "NONE"
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE,
            
            /// <summary>
            /// Enum ALERT for "ALERT"
            /// </summary>
            [EnumMember(Value = "ALERT")]
            ALERT,
            
            /// <summary>
            /// Enum MAILSETTINGS for "MAIL_SETTINGS"
            /// </summary>
            [EnumMember(Value = "MAIL_SETTINGS")]
            MAILSETTINGS
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum VIEW for "VIEW"
            /// </summary>
            [EnumMember(Value = "VIEW")]
            VIEW,
            
            /// <summary>
            /// Enum EDIT for "EDIT"
            /// </summary>
            [EnumMember(Value = "EDIT")]
            EDIT
        }

        /// <summary>
        /// Gets or Sets Permission
        /// </summary>
        [DataMember(Name="permission", EmitDefaultValue=false)]
        public PermissionEnum? Permission { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RolePermissionBean" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Permission">Permission.</param>
        /// <param name="Type">Type.</param>
        public RolePermissionBean(long? Id = default(long?), PermissionEnum? Permission = default(PermissionEnum?), TypeEnum? Type = default(TypeEnum?))
        {
            this.Id = Id;
            this.Permission = Permission;
            this.Type = Type;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RolePermissionBean {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as RolePermissionBean);
        }

        /// <summary>
        /// Returns true if RolePermissionBean instances are equal
        /// </summary>
        /// <param name="other">Instance of RolePermissionBean to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RolePermissionBean other)
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
                    this.Permission == other.Permission ||
                    this.Permission != null &&
                    this.Permission.Equals(other.Permission)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.Permission != null)
                    hash = hash * 59 + this.Permission.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
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
