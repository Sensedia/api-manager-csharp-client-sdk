# IO.Swagger.Api.CallsApi

All URIs are relative to *https://localhost/api-manager/api/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RetrieveCallByIdUsingGET1**](CallsApi.md#retrievecallbyidusingget1) | **GET** /calls/{id} | Retrive call by id
[**RetrieveCallsWithFiltersUsingGET1**](CallsApi.md#retrievecallswithfiltersusingget1) | **GET** /calls | Retrive calls with filters
[**RetrieveTotalCallsByDateUsingGET1**](CallsApi.md#retrievetotalcallsbydateusingget1) | **GET** /calls/count/{date} | Retrive calls total by date


<a name="retrievecallbyidusingget1"></a>
# **RetrieveCallByIdUsingGET1**
> Call RetrieveCallByIdUsingGET1 (string id, string sensediaAuth = null)

Retrive call by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveCallByIdUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new CallsApi();
            var id = id_example;  // string | Call id
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Retrive call by id
                Call result = apiInstance.RetrieveCallByIdUsingGET1(id, sensediaAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CallsApi.RetrieveCallByIdUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Call id | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 

### Return type

[**Call**](Call.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrievecallswithfiltersusingget1"></a>
# **RetrieveCallsWithFiltersUsingGET1**
> CallResponse RetrieveCallsWithFiltersUsingGET1 (string sensediaAuth = null, int? actualPage = null, string baseUris = null, string appTokenCode = null, int? pageSize = null, string appTokenName = null, string authTokenOwner = null, long? apiId = null, long? operationId = null, long? resourceId = null, long? environmentId = null, long? revisionId = null, string uri = null, string customSearch = null, string method = null, int? httpStatusFrom = null, int? httpStatusTo = null, string beginDate = null, string endDate = null, string appDeveloper = null, string forceDownload = null)

Retrive calls with filters

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveCallsWithFiltersUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new CallsApi();
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var actualPage = 56;  // int? | Number of the page in pagination. The starting page number is zero. (optional) 
            var baseUris = baseUris_example;  // string | Base uris (optional) 
            var appTokenCode = appTokenCode_example;  // string | Code app token (optional) 
            var pageSize = 56;  // int? | Define the size of the returned list of developers. (optional) 
            var appTokenName = appTokenName_example;  // string | Name app token (optional) 
            var authTokenOwner = authTokenOwner_example;  // string | Owner auth token (optional) 
            var apiId = 789;  // long? | API id (optional) 
            var operationId = 789;  // long? | Operation id (optional) 
            var resourceId = 789;  // long? | Resource id (optional) 
            var environmentId = 789;  // long? | Environment id (optional) 
            var revisionId = 789;  // long? | Revision id (optional) 
            var uri = uri_example;  // string | URI (optional) 
            var customSearch = customSearch_example;  // string | Custom search (optional) 
            var method = method_example;  // string | HTTP Method (GET, POST, PUT, DELETE, PATCH, OPTIONS, HEAD) (optional) 
            var httpStatusFrom = 56;  // int? | HTTP status from (optional) 
            var httpStatusTo = 56;  // int? | HTTP status to (optional) 
            var beginDate = beginDate_example;  // string | Begin date (optional) 
            var endDate = endDate_example;  // string | End date (optional) 
            var appDeveloper = appDeveloper_example;  // string | APP Developer (optional) 
            var forceDownload = forceDownload_example;  // string | Force archive download (optional) 

            try
            {
                // Retrive calls with filters
                CallResponse result = apiInstance.RetrieveCallsWithFiltersUsingGET1(sensediaAuth, actualPage, baseUris, appTokenCode, pageSize, appTokenName, authTokenOwner, apiId, operationId, resourceId, environmentId, revisionId, uri, customSearch, method, httpStatusFrom, httpStatusTo, beginDate, endDate, appDeveloper, forceDownload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CallsApi.RetrieveCallsWithFiltersUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **actualPage** | **int?**| Number of the page in pagination. The starting page number is zero. | [optional] 
 **baseUris** | **string**| Base uris | [optional] 
 **appTokenCode** | **string**| Code app token | [optional] 
 **pageSize** | **int?**| Define the size of the returned list of developers. | [optional] 
 **appTokenName** | **string**| Name app token | [optional] 
 **authTokenOwner** | **string**| Owner auth token | [optional] 
 **apiId** | **long?**| API id | [optional] 
 **operationId** | **long?**| Operation id | [optional] 
 **resourceId** | **long?**| Resource id | [optional] 
 **environmentId** | **long?**| Environment id | [optional] 
 **revisionId** | **long?**| Revision id | [optional] 
 **uri** | **string**| URI | [optional] 
 **customSearch** | **string**| Custom search | [optional] 
 **method** | **string**| HTTP Method (GET, POST, PUT, DELETE, PATCH, OPTIONS, HEAD) | [optional] 
 **httpStatusFrom** | **int?**| HTTP status from | [optional] 
 **httpStatusTo** | **int?**| HTTP status to | [optional] 
 **beginDate** | **string**| Begin date | [optional] 
 **endDate** | **string**| End date | [optional] 
 **appDeveloper** | **string**| APP Developer | [optional] 
 **forceDownload** | **string**| Force archive download | [optional] 

### Return type

[**CallResponse**](CallResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrievetotalcallsbydateusingget1"></a>
# **RetrieveTotalCallsByDateUsingGET1**
> long? RetrieveTotalCallsByDateUsingGET1 (string date, string sensediaAuth = null, long? apiId = null)

Retrive calls total by date

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveTotalCallsByDateUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new CallsApi();
            var date = date_example;  // string | Date searched
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var apiId = 789;  // long? | API id (optional) 

            try
            {
                // Retrive calls total by date
                long? result = apiInstance.RetrieveTotalCallsByDateUsingGET1(date, sensediaAuth, apiId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CallsApi.RetrieveTotalCallsByDateUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **string**| Date searched | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **apiId** | **long?**| API id | [optional] 

### Return type

**long?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

