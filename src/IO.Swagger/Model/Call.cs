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
    /// Call
    /// </summary>
    [DataContract]
    public partial class Call :  IEquatable<Call>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets TypeError
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeErrorEnum
        {
            
            /// <summary>
            /// Enum Client for "client"
            /// </summary>
            [EnumMember(Value = "client")]
            Client,
            
            /// <summary>
            /// Enum Server for "server"
            /// </summary>
            [EnumMember(Value = "server")]
            Server,
            
            /// <summary>
            /// Enum Blocked for "blocked"
            /// </summary>
            [EnumMember(Value = "blocked")]
            Blocked
        }

        /// <summary>
        /// Gets or Sets TypeStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeStatusEnum
        {
            
            /// <summary>
            /// Enum Success for "success"
            /// </summary>
            [EnumMember(Value = "success")]
            Success,
            
            /// <summary>
            /// Enum Error for "error"
            /// </summary>
            [EnumMember(Value = "error")]
            Error
        }

        /// <summary>
        /// Gets or Sets TypeError
        /// </summary>
        [DataMember(Name="typeError", EmitDefaultValue=false)]
        public TypeErrorEnum? TypeError { get; set; }
        /// <summary>
        /// Gets or Sets TypeStatus
        /// </summary>
        [DataMember(Name="typeStatus", EmitDefaultValue=false)]
        public TypeStatusEnum? TypeStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Call" /> class.
        /// </summary>
        /// <param name="AccessToken">AccessToken.</param>
        /// <param name="AccessTokenOwner">AccessTokenOwner.</param>
        /// <param name="AdditionalData">AdditionalData.</param>
        /// <param name="ApiComponentType">ApiComponentType.</param>
        /// <param name="ApiId">ApiId.</param>
        /// <param name="ApiName">ApiName.</param>
        /// <param name="AppDeveloper">AppDeveloper.</param>
        /// <param name="AppName">AppName.</param>
        /// <param name="AppToken">AppToken.</param>
        /// <param name="AuthOwner">AuthOwner.</param>
        /// <param name="BaseUrl">BaseUrl.</param>
        /// <param name="Billing">Billing.</param>
        /// <param name="Cache">Cache.</param>
        /// <param name="CallDate">CallDate.</param>
        /// <param name="CallerAddress">CallerAddress.</param>
        /// <param name="ClientId">ClientId.</param>
        /// <param name="CompleteUrl">CompleteUrl.</param>
        /// <param name="Duration">Duration.</param>
        /// <param name="DurationMillis">DurationMillis.</param>
        /// <param name="EnvironmentId">EnvironmentId.</param>
        /// <param name="EnvironmentName">EnvironmentName.</param>
        /// <param name="GatewayDurationMillis">GatewayDurationMillis.</param>
        /// <param name="HttpStatus">HttpStatus.</param>
        /// <param name="Id">Id.</param>
        /// <param name="InsertedOnDate">InsertedOnDate.</param>
        /// <param name="Method">Method.</param>
        /// <param name="OperationId">OperationId.</param>
        /// <param name="OperationName">OperationName.</param>
        /// <param name="ReceivedFromAddress">ReceivedFromAddress.</param>
        /// <param name="ReceivedOn">ReceivedOn.</param>
        /// <param name="ReceivedOnDate">ReceivedOnDate.</param>
        /// <param name="Redis">Redis.</param>
        /// <param name="RequestHeaders">RequestHeaders.</param>
        /// <param name="RequestID">RequestID.</param>
        /// <param name="RequestPayload">RequestPayload.</param>
        /// <param name="ResourceId">ResourceId.</param>
        /// <param name="ResourceName">ResourceName.</param>
        /// <param name="ResponseHeaders">ResponseHeaders.</param>
        /// <param name="ResponsePayload">ResponsePayload.</param>
        /// <param name="ResultStatus">ResultStatus.</param>
        /// <param name="RevisionId">RevisionId.</param>
        /// <param name="Trace">Trace.</param>
        /// <param name="TransactionID">TransactionID.</param>
        /// <param name="TypeError">TypeError.</param>
        /// <param name="TypeStatus">TypeStatus.</param>
        /// <param name="Uri">Uri.</param>
        /// <param name="Url">Url.</param>
        /// <param name="YearMonth">YearMonth.</param>
        public Call(string AccessToken = default(string), string AccessTokenOwner = default(string), string AdditionalData = default(string), string ApiComponentType = default(string), long? ApiId = default(long?), string ApiName = default(string), string AppDeveloper = default(string), string AppName = default(string), string AppToken = default(string), string AuthOwner = default(string), string BaseUrl = default(string), bool? Billing = default(bool?), bool? Cache = default(bool?), DateTime? CallDate = default(DateTime?), string CallerAddress = default(string), string ClientId = default(string), string CompleteUrl = default(string), int? Duration = default(int?), long? DurationMillis = default(long?), long? EnvironmentId = default(long?), string EnvironmentName = default(string), long? GatewayDurationMillis = default(long?), string HttpStatus = default(string), string Id = default(string), string InsertedOnDate = default(string), string Method = default(string), long? OperationId = default(long?), string OperationName = default(string), string ReceivedFromAddress = default(string), long? ReceivedOn = default(long?), string ReceivedOnDate = default(string), bool? Redis = default(bool?), string RequestHeaders = default(string), string RequestID = default(string), long? RequestPayload = default(long?), long? ResourceId = default(long?), string ResourceName = default(string), string ResponseHeaders = default(string), long? ResponsePayload = default(long?), int? ResultStatus = default(int?), long? RevisionId = default(long?), string Trace = default(string), string TransactionID = default(string), TypeErrorEnum? TypeError = default(TypeErrorEnum?), TypeStatusEnum? TypeStatus = default(TypeStatusEnum?), string Uri = default(string), string Url = default(string), string YearMonth = default(string))
        {
            this.AccessToken = AccessToken;
            this.AccessTokenOwner = AccessTokenOwner;
            this.AdditionalData = AdditionalData;
            this.ApiComponentType = ApiComponentType;
            this.ApiId = ApiId;
            this.ApiName = ApiName;
            this.AppDeveloper = AppDeveloper;
            this.AppName = AppName;
            this.AppToken = AppToken;
            this.AuthOwner = AuthOwner;
            this.BaseUrl = BaseUrl;
            this.Billing = Billing;
            this.Cache = Cache;
            this.CallDate = CallDate;
            this.CallerAddress = CallerAddress;
            this.ClientId = ClientId;
            this.CompleteUrl = CompleteUrl;
            this.Duration = Duration;
            this.DurationMillis = DurationMillis;
            this.EnvironmentId = EnvironmentId;
            this.EnvironmentName = EnvironmentName;
            this.GatewayDurationMillis = GatewayDurationMillis;
            this.HttpStatus = HttpStatus;
            this.Id = Id;
            this.InsertedOnDate = InsertedOnDate;
            this.Method = Method;
            this.OperationId = OperationId;
            this.OperationName = OperationName;
            this.ReceivedFromAddress = ReceivedFromAddress;
            this.ReceivedOn = ReceivedOn;
            this.ReceivedOnDate = ReceivedOnDate;
            this.Redis = Redis;
            this.RequestHeaders = RequestHeaders;
            this.RequestID = RequestID;
            this.RequestPayload = RequestPayload;
            this.ResourceId = ResourceId;
            this.ResourceName = ResourceName;
            this.ResponseHeaders = ResponseHeaders;
            this.ResponsePayload = ResponsePayload;
            this.ResultStatus = ResultStatus;
            this.RevisionId = RevisionId;
            this.Trace = Trace;
            this.TransactionID = TransactionID;
            this.TypeError = TypeError;
            this.TypeStatus = TypeStatus;
            this.Uri = Uri;
            this.Url = Url;
            this.YearMonth = YearMonth;
        }
        
        /// <summary>
        /// Gets or Sets AccessToken
        /// </summary>
        [DataMember(Name="accessToken", EmitDefaultValue=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or Sets AccessTokenOwner
        /// </summary>
        [DataMember(Name="accessTokenOwner", EmitDefaultValue=false)]
        public string AccessTokenOwner { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalData
        /// </summary>
        [DataMember(Name="additionalData", EmitDefaultValue=false)]
        public string AdditionalData { get; set; }

        /// <summary>
        /// Gets or Sets ApiComponentType
        /// </summary>
        [DataMember(Name="apiComponentType", EmitDefaultValue=false)]
        public string ApiComponentType { get; set; }

        /// <summary>
        /// Gets or Sets ApiId
        /// </summary>
        [DataMember(Name="apiId", EmitDefaultValue=false)]
        public long? ApiId { get; set; }

        /// <summary>
        /// Gets or Sets ApiName
        /// </summary>
        [DataMember(Name="apiName", EmitDefaultValue=false)]
        public string ApiName { get; set; }

        /// <summary>
        /// Gets or Sets AppDeveloper
        /// </summary>
        [DataMember(Name="appDeveloper", EmitDefaultValue=false)]
        public string AppDeveloper { get; set; }

        /// <summary>
        /// Gets or Sets AppName
        /// </summary>
        [DataMember(Name="appName", EmitDefaultValue=false)]
        public string AppName { get; set; }

        /// <summary>
        /// Gets or Sets AppToken
        /// </summary>
        [DataMember(Name="appToken", EmitDefaultValue=false)]
        public string AppToken { get; set; }

        /// <summary>
        /// Gets or Sets AuthOwner
        /// </summary>
        [DataMember(Name="authOwner", EmitDefaultValue=false)]
        public string AuthOwner { get; set; }

        /// <summary>
        /// Gets or Sets BaseUrl
        /// </summary>
        [DataMember(Name="baseUrl", EmitDefaultValue=false)]
        public string BaseUrl { get; set; }

        /// <summary>
        /// Gets or Sets Billing
        /// </summary>
        [DataMember(Name="billing", EmitDefaultValue=false)]
        public bool? Billing { get; set; }

        /// <summary>
        /// Gets or Sets Cache
        /// </summary>
        [DataMember(Name="cache", EmitDefaultValue=false)]
        public bool? Cache { get; set; }

        /// <summary>
        /// Gets or Sets CallDate
        /// </summary>
        [DataMember(Name="callDate", EmitDefaultValue=false)]
        public DateTime? CallDate { get; set; }

        /// <summary>
        /// Gets or Sets CallerAddress
        /// </summary>
        [DataMember(Name="callerAddress", EmitDefaultValue=false)]
        public string CallerAddress { get; set; }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets CompleteUrl
        /// </summary>
        [DataMember(Name="completeUrl", EmitDefaultValue=false)]
        public string CompleteUrl { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// Gets or Sets DurationMillis
        /// </summary>
        [DataMember(Name="durationMillis", EmitDefaultValue=false)]
        public long? DurationMillis { get; set; }

        /// <summary>
        /// Gets or Sets EnvironmentId
        /// </summary>
        [DataMember(Name="environmentId", EmitDefaultValue=false)]
        public long? EnvironmentId { get; set; }

        /// <summary>
        /// Gets or Sets EnvironmentName
        /// </summary>
        [DataMember(Name="environmentName", EmitDefaultValue=false)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// Gets or Sets GatewayDurationMillis
        /// </summary>
        [DataMember(Name="gatewayDurationMillis", EmitDefaultValue=false)]
        public long? GatewayDurationMillis { get; set; }

        /// <summary>
        /// Gets or Sets HttpStatus
        /// </summary>
        [DataMember(Name="httpStatus", EmitDefaultValue=false)]
        public string HttpStatus { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets InsertedOnDate
        /// </summary>
        [DataMember(Name="insertedOnDate", EmitDefaultValue=false)]
        public string InsertedOnDate { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public string Method { get; set; }

        /// <summary>
        /// Gets or Sets OperationId
        /// </summary>
        [DataMember(Name="operationId", EmitDefaultValue=false)]
        public long? OperationId { get; set; }

        /// <summary>
        /// Gets or Sets OperationName
        /// </summary>
        [DataMember(Name="operationName", EmitDefaultValue=false)]
        public string OperationName { get; set; }

        /// <summary>
        /// Gets or Sets ReceivedFromAddress
        /// </summary>
        [DataMember(Name="receivedFromAddress", EmitDefaultValue=false)]
        public string ReceivedFromAddress { get; set; }

        /// <summary>
        /// Gets or Sets ReceivedOn
        /// </summary>
        [DataMember(Name="receivedOn", EmitDefaultValue=false)]
        public long? ReceivedOn { get; set; }

        /// <summary>
        /// Gets or Sets ReceivedOnDate
        /// </summary>
        [DataMember(Name="receivedOnDate", EmitDefaultValue=false)]
        public string ReceivedOnDate { get; set; }

        /// <summary>
        /// Gets or Sets Redis
        /// </summary>
        [DataMember(Name="redis", EmitDefaultValue=false)]
        public bool? Redis { get; set; }

        /// <summary>
        /// Gets or Sets RequestHeaders
        /// </summary>
        [DataMember(Name="requestHeaders", EmitDefaultValue=false)]
        public string RequestHeaders { get; set; }

        /// <summary>
        /// Gets or Sets RequestID
        /// </summary>
        [DataMember(Name="requestID", EmitDefaultValue=false)]
        public string RequestID { get; set; }

        /// <summary>
        /// Gets or Sets RequestPayload
        /// </summary>
        [DataMember(Name="requestPayload", EmitDefaultValue=false)]
        public long? RequestPayload { get; set; }

        /// <summary>
        /// Gets or Sets ResourceId
        /// </summary>
        [DataMember(Name="resourceId", EmitDefaultValue=false)]
        public long? ResourceId { get; set; }

        /// <summary>
        /// Gets or Sets ResourceName
        /// </summary>
        [DataMember(Name="resourceName", EmitDefaultValue=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// Gets or Sets ResponseHeaders
        /// </summary>
        [DataMember(Name="responseHeaders", EmitDefaultValue=false)]
        public string ResponseHeaders { get; set; }

        /// <summary>
        /// Gets or Sets ResponsePayload
        /// </summary>
        [DataMember(Name="responsePayload", EmitDefaultValue=false)]
        public long? ResponsePayload { get; set; }

        /// <summary>
        /// Gets or Sets ResultStatus
        /// </summary>
        [DataMember(Name="resultStatus", EmitDefaultValue=false)]
        public int? ResultStatus { get; set; }

        /// <summary>
        /// Gets or Sets RevisionId
        /// </summary>
        [DataMember(Name="revisionId", EmitDefaultValue=false)]
        public long? RevisionId { get; set; }

        /// <summary>
        /// Gets or Sets Trace
        /// </summary>
        [DataMember(Name="trace", EmitDefaultValue=false)]
        public string Trace { get; set; }

        /// <summary>
        /// Gets or Sets TransactionID
        /// </summary>
        [DataMember(Name="transactionID", EmitDefaultValue=false)]
        public string TransactionID { get; set; }



        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets YearMonth
        /// </summary>
        [DataMember(Name="yearMonth", EmitDefaultValue=false)]
        public string YearMonth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Call {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  AccessTokenOwner: ").Append(AccessTokenOwner).Append("\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  ApiComponentType: ").Append(ApiComponentType).Append("\n");
            sb.Append("  ApiId: ").Append(ApiId).Append("\n");
            sb.Append("  ApiName: ").Append(ApiName).Append("\n");
            sb.Append("  AppDeveloper: ").Append(AppDeveloper).Append("\n");
            sb.Append("  AppName: ").Append(AppName).Append("\n");
            sb.Append("  AppToken: ").Append(AppToken).Append("\n");
            sb.Append("  AuthOwner: ").Append(AuthOwner).Append("\n");
            sb.Append("  BaseUrl: ").Append(BaseUrl).Append("\n");
            sb.Append("  Billing: ").Append(Billing).Append("\n");
            sb.Append("  Cache: ").Append(Cache).Append("\n");
            sb.Append("  CallDate: ").Append(CallDate).Append("\n");
            sb.Append("  CallerAddress: ").Append(CallerAddress).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  CompleteUrl: ").Append(CompleteUrl).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  DurationMillis: ").Append(DurationMillis).Append("\n");
            sb.Append("  EnvironmentId: ").Append(EnvironmentId).Append("\n");
            sb.Append("  EnvironmentName: ").Append(EnvironmentName).Append("\n");
            sb.Append("  GatewayDurationMillis: ").Append(GatewayDurationMillis).Append("\n");
            sb.Append("  HttpStatus: ").Append(HttpStatus).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InsertedOnDate: ").Append(InsertedOnDate).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  OperationName: ").Append(OperationName).Append("\n");
            sb.Append("  ReceivedFromAddress: ").Append(ReceivedFromAddress).Append("\n");
            sb.Append("  ReceivedOn: ").Append(ReceivedOn).Append("\n");
            sb.Append("  ReceivedOnDate: ").Append(ReceivedOnDate).Append("\n");
            sb.Append("  Redis: ").Append(Redis).Append("\n");
            sb.Append("  RequestHeaders: ").Append(RequestHeaders).Append("\n");
            sb.Append("  RequestID: ").Append(RequestID).Append("\n");
            sb.Append("  RequestPayload: ").Append(RequestPayload).Append("\n");
            sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  ResourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  ResponseHeaders: ").Append(ResponseHeaders).Append("\n");
            sb.Append("  ResponsePayload: ").Append(ResponsePayload).Append("\n");
            sb.Append("  ResultStatus: ").Append(ResultStatus).Append("\n");
            sb.Append("  RevisionId: ").Append(RevisionId).Append("\n");
            sb.Append("  Trace: ").Append(Trace).Append("\n");
            sb.Append("  TransactionID: ").Append(TransactionID).Append("\n");
            sb.Append("  TypeError: ").Append(TypeError).Append("\n");
            sb.Append("  TypeStatus: ").Append(TypeStatus).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  YearMonth: ").Append(YearMonth).Append("\n");
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
            return this.Equals(obj as Call);
        }

        /// <summary>
        /// Returns true if Call instances are equal
        /// </summary>
        /// <param name="other">Instance of Call to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Call other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccessToken == other.AccessToken ||
                    this.AccessToken != null &&
                    this.AccessToken.Equals(other.AccessToken)
                ) && 
                (
                    this.AccessTokenOwner == other.AccessTokenOwner ||
                    this.AccessTokenOwner != null &&
                    this.AccessTokenOwner.Equals(other.AccessTokenOwner)
                ) && 
                (
                    this.AdditionalData == other.AdditionalData ||
                    this.AdditionalData != null &&
                    this.AdditionalData.Equals(other.AdditionalData)
                ) && 
                (
                    this.ApiComponentType == other.ApiComponentType ||
                    this.ApiComponentType != null &&
                    this.ApiComponentType.Equals(other.ApiComponentType)
                ) && 
                (
                    this.ApiId == other.ApiId ||
                    this.ApiId != null &&
                    this.ApiId.Equals(other.ApiId)
                ) && 
                (
                    this.ApiName == other.ApiName ||
                    this.ApiName != null &&
                    this.ApiName.Equals(other.ApiName)
                ) && 
                (
                    this.AppDeveloper == other.AppDeveloper ||
                    this.AppDeveloper != null &&
                    this.AppDeveloper.Equals(other.AppDeveloper)
                ) && 
                (
                    this.AppName == other.AppName ||
                    this.AppName != null &&
                    this.AppName.Equals(other.AppName)
                ) && 
                (
                    this.AppToken == other.AppToken ||
                    this.AppToken != null &&
                    this.AppToken.Equals(other.AppToken)
                ) && 
                (
                    this.AuthOwner == other.AuthOwner ||
                    this.AuthOwner != null &&
                    this.AuthOwner.Equals(other.AuthOwner)
                ) && 
                (
                    this.BaseUrl == other.BaseUrl ||
                    this.BaseUrl != null &&
                    this.BaseUrl.Equals(other.BaseUrl)
                ) && 
                (
                    this.Billing == other.Billing ||
                    this.Billing != null &&
                    this.Billing.Equals(other.Billing)
                ) && 
                (
                    this.Cache == other.Cache ||
                    this.Cache != null &&
                    this.Cache.Equals(other.Cache)
                ) && 
                (
                    this.CallDate == other.CallDate ||
                    this.CallDate != null &&
                    this.CallDate.Equals(other.CallDate)
                ) && 
                (
                    this.CallerAddress == other.CallerAddress ||
                    this.CallerAddress != null &&
                    this.CallerAddress.Equals(other.CallerAddress)
                ) && 
                (
                    this.ClientId == other.ClientId ||
                    this.ClientId != null &&
                    this.ClientId.Equals(other.ClientId)
                ) && 
                (
                    this.CompleteUrl == other.CompleteUrl ||
                    this.CompleteUrl != null &&
                    this.CompleteUrl.Equals(other.CompleteUrl)
                ) && 
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
                ) && 
                (
                    this.DurationMillis == other.DurationMillis ||
                    this.DurationMillis != null &&
                    this.DurationMillis.Equals(other.DurationMillis)
                ) && 
                (
                    this.EnvironmentId == other.EnvironmentId ||
                    this.EnvironmentId != null &&
                    this.EnvironmentId.Equals(other.EnvironmentId)
                ) && 
                (
                    this.EnvironmentName == other.EnvironmentName ||
                    this.EnvironmentName != null &&
                    this.EnvironmentName.Equals(other.EnvironmentName)
                ) && 
                (
                    this.GatewayDurationMillis == other.GatewayDurationMillis ||
                    this.GatewayDurationMillis != null &&
                    this.GatewayDurationMillis.Equals(other.GatewayDurationMillis)
                ) && 
                (
                    this.HttpStatus == other.HttpStatus ||
                    this.HttpStatus != null &&
                    this.HttpStatus.Equals(other.HttpStatus)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.InsertedOnDate == other.InsertedOnDate ||
                    this.InsertedOnDate != null &&
                    this.InsertedOnDate.Equals(other.InsertedOnDate)
                ) && 
                (
                    this.Method == other.Method ||
                    this.Method != null &&
                    this.Method.Equals(other.Method)
                ) && 
                (
                    this.OperationId == other.OperationId ||
                    this.OperationId != null &&
                    this.OperationId.Equals(other.OperationId)
                ) && 
                (
                    this.OperationName == other.OperationName ||
                    this.OperationName != null &&
                    this.OperationName.Equals(other.OperationName)
                ) && 
                (
                    this.ReceivedFromAddress == other.ReceivedFromAddress ||
                    this.ReceivedFromAddress != null &&
                    this.ReceivedFromAddress.Equals(other.ReceivedFromAddress)
                ) && 
                (
                    this.ReceivedOn == other.ReceivedOn ||
                    this.ReceivedOn != null &&
                    this.ReceivedOn.Equals(other.ReceivedOn)
                ) && 
                (
                    this.ReceivedOnDate == other.ReceivedOnDate ||
                    this.ReceivedOnDate != null &&
                    this.ReceivedOnDate.Equals(other.ReceivedOnDate)
                ) && 
                (
                    this.Redis == other.Redis ||
                    this.Redis != null &&
                    this.Redis.Equals(other.Redis)
                ) && 
                (
                    this.RequestHeaders == other.RequestHeaders ||
                    this.RequestHeaders != null &&
                    this.RequestHeaders.Equals(other.RequestHeaders)
                ) && 
                (
                    this.RequestID == other.RequestID ||
                    this.RequestID != null &&
                    this.RequestID.Equals(other.RequestID)
                ) && 
                (
                    this.RequestPayload == other.RequestPayload ||
                    this.RequestPayload != null &&
                    this.RequestPayload.Equals(other.RequestPayload)
                ) && 
                (
                    this.ResourceId == other.ResourceId ||
                    this.ResourceId != null &&
                    this.ResourceId.Equals(other.ResourceId)
                ) && 
                (
                    this.ResourceName == other.ResourceName ||
                    this.ResourceName != null &&
                    this.ResourceName.Equals(other.ResourceName)
                ) && 
                (
                    this.ResponseHeaders == other.ResponseHeaders ||
                    this.ResponseHeaders != null &&
                    this.ResponseHeaders.Equals(other.ResponseHeaders)
                ) && 
                (
                    this.ResponsePayload == other.ResponsePayload ||
                    this.ResponsePayload != null &&
                    this.ResponsePayload.Equals(other.ResponsePayload)
                ) && 
                (
                    this.ResultStatus == other.ResultStatus ||
                    this.ResultStatus != null &&
                    this.ResultStatus.Equals(other.ResultStatus)
                ) && 
                (
                    this.RevisionId == other.RevisionId ||
                    this.RevisionId != null &&
                    this.RevisionId.Equals(other.RevisionId)
                ) && 
                (
                    this.Trace == other.Trace ||
                    this.Trace != null &&
                    this.Trace.Equals(other.Trace)
                ) && 
                (
                    this.TransactionID == other.TransactionID ||
                    this.TransactionID != null &&
                    this.TransactionID.Equals(other.TransactionID)
                ) && 
                (
                    this.TypeError == other.TypeError ||
                    this.TypeError != null &&
                    this.TypeError.Equals(other.TypeError)
                ) && 
                (
                    this.TypeStatus == other.TypeStatus ||
                    this.TypeStatus != null &&
                    this.TypeStatus.Equals(other.TypeStatus)
                ) && 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.YearMonth == other.YearMonth ||
                    this.YearMonth != null &&
                    this.YearMonth.Equals(other.YearMonth)
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
                if (this.AccessToken != null)
                    hash = hash * 59 + this.AccessToken.GetHashCode();
                if (this.AccessTokenOwner != null)
                    hash = hash * 59 + this.AccessTokenOwner.GetHashCode();
                if (this.AdditionalData != null)
                    hash = hash * 59 + this.AdditionalData.GetHashCode();
                if (this.ApiComponentType != null)
                    hash = hash * 59 + this.ApiComponentType.GetHashCode();
                if (this.ApiId != null)
                    hash = hash * 59 + this.ApiId.GetHashCode();
                if (this.ApiName != null)
                    hash = hash * 59 + this.ApiName.GetHashCode();
                if (this.AppDeveloper != null)
                    hash = hash * 59 + this.AppDeveloper.GetHashCode();
                if (this.AppName != null)
                    hash = hash * 59 + this.AppName.GetHashCode();
                if (this.AppToken != null)
                    hash = hash * 59 + this.AppToken.GetHashCode();
                if (this.AuthOwner != null)
                    hash = hash * 59 + this.AuthOwner.GetHashCode();
                if (this.BaseUrl != null)
                    hash = hash * 59 + this.BaseUrl.GetHashCode();
                if (this.Billing != null)
                    hash = hash * 59 + this.Billing.GetHashCode();
                if (this.Cache != null)
                    hash = hash * 59 + this.Cache.GetHashCode();
                if (this.CallDate != null)
                    hash = hash * 59 + this.CallDate.GetHashCode();
                if (this.CallerAddress != null)
                    hash = hash * 59 + this.CallerAddress.GetHashCode();
                if (this.ClientId != null)
                    hash = hash * 59 + this.ClientId.GetHashCode();
                if (this.CompleteUrl != null)
                    hash = hash * 59 + this.CompleteUrl.GetHashCode();
                if (this.Duration != null)
                    hash = hash * 59 + this.Duration.GetHashCode();
                if (this.DurationMillis != null)
                    hash = hash * 59 + this.DurationMillis.GetHashCode();
                if (this.EnvironmentId != null)
                    hash = hash * 59 + this.EnvironmentId.GetHashCode();
                if (this.EnvironmentName != null)
                    hash = hash * 59 + this.EnvironmentName.GetHashCode();
                if (this.GatewayDurationMillis != null)
                    hash = hash * 59 + this.GatewayDurationMillis.GetHashCode();
                if (this.HttpStatus != null)
                    hash = hash * 59 + this.HttpStatus.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.InsertedOnDate != null)
                    hash = hash * 59 + this.InsertedOnDate.GetHashCode();
                if (this.Method != null)
                    hash = hash * 59 + this.Method.GetHashCode();
                if (this.OperationId != null)
                    hash = hash * 59 + this.OperationId.GetHashCode();
                if (this.OperationName != null)
                    hash = hash * 59 + this.OperationName.GetHashCode();
                if (this.ReceivedFromAddress != null)
                    hash = hash * 59 + this.ReceivedFromAddress.GetHashCode();
                if (this.ReceivedOn != null)
                    hash = hash * 59 + this.ReceivedOn.GetHashCode();
                if (this.ReceivedOnDate != null)
                    hash = hash * 59 + this.ReceivedOnDate.GetHashCode();
                if (this.Redis != null)
                    hash = hash * 59 + this.Redis.GetHashCode();
                if (this.RequestHeaders != null)
                    hash = hash * 59 + this.RequestHeaders.GetHashCode();
                if (this.RequestID != null)
                    hash = hash * 59 + this.RequestID.GetHashCode();
                if (this.RequestPayload != null)
                    hash = hash * 59 + this.RequestPayload.GetHashCode();
                if (this.ResourceId != null)
                    hash = hash * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceName != null)
                    hash = hash * 59 + this.ResourceName.GetHashCode();
                if (this.ResponseHeaders != null)
                    hash = hash * 59 + this.ResponseHeaders.GetHashCode();
                if (this.ResponsePayload != null)
                    hash = hash * 59 + this.ResponsePayload.GetHashCode();
                if (this.ResultStatus != null)
                    hash = hash * 59 + this.ResultStatus.GetHashCode();
                if (this.RevisionId != null)
                    hash = hash * 59 + this.RevisionId.GetHashCode();
                if (this.Trace != null)
                    hash = hash * 59 + this.Trace.GetHashCode();
                if (this.TransactionID != null)
                    hash = hash * 59 + this.TransactionID.GetHashCode();
                if (this.TypeError != null)
                    hash = hash * 59 + this.TypeError.GetHashCode();
                if (this.TypeStatus != null)
                    hash = hash * 59 + this.TypeStatus.GetHashCode();
                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                if (this.YearMonth != null)
                    hash = hash * 59 + this.YearMonth.GetHashCode();
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
