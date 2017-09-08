# IO.Swagger.Api.APIsApi

All URIs are relative to *https://localhost/api-manager/api/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CloneApiUsingPOST1**](APIsApi.md#cloneapiusingpost1) | **POST** /apis/{id}/clone | Clone a API
[**CreateAPIUsingPOST1**](APIsApi.md#createapiusingpost1) | **POST** /apis | Create a new API
[**DeleteAPIUsingDELETE1**](APIsApi.md#deleteapiusingdelete1) | **DELETE** /apis/{id} | Delete a API
[**FindLastRevisionUsingGET1**](APIsApi.md#findlastrevisionusingget1) | **GET** /apis/{id}/revisions | Find last revision by API id
[**FindVersionsByAPIUsingGET1**](APIsApi.md#findversionsbyapiusingget1) | **GET** /apis/{id}/versions | Find version by API id
[**GetAPIByIdUsingGET1**](APIsApi.md#getapibyidusingget1) | **GET** /apis/{apiId} | Find API by id
[**GetAPIChangeLogUsingGET1**](APIsApi.md#getapichangelogusingget1) | **GET** /apis/{id}/changelog | Retrive changelog per API id
[**GetAPIsUsingGET1**](APIsApi.md#getapisusingget1) | **GET** /apis | Return all APIs
[**NewVersionAPIUsingPOST1**](APIsApi.md#newversionapiusingpost1) | **POST** /apis/{id}/versions | Create new version
[**RemoveEnvironmentUsingDELETE1**](APIsApi.md#removeenvironmentusingdelete1) | **DELETE** /apis/{id}/environments/{environmentId} | Delete environment link with API
[**UpdateAPIUsingPUT1**](APIsApi.md#updateapiusingput1) | **PUT** /apis/{id} | Update a API
[**ValidatePartialAPIUsingPOST1**](APIsApi.md#validatepartialapiusingpost1) | **POST** /apis/validate | Validate partial a API


<a name="cloneapiusingpost1"></a>
# **CloneApiUsingPOST1**
> APIResponse CloneApiUsingPOST1 (string id, string sensediaAuth = null, API apiBean = null)

Clone a API

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CloneApiUsingPOST1Example
    {
        public void main()
        {
            var apiInstance = new APIsApi();
            var id = id_example;  // string | API id
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var apiBean = new API(); // API | API json to update a api (optional) 

            try
            {
                // Clone a API
                APIResponse result = apiInstance.CloneApiUsingPOST1(id, sensediaAuth, apiBean);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIsApi.CloneApiUsingPOST1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| API id | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **apiBean** | [**API**](API.md)| API json to update a api | [optional] 

### Return type

[**APIResponse**](APIResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createapiusingpost1"></a>
# **CreateAPIUsingPOST1**
> APIResponse CreateAPIUsingPOST1 (string sensediaAuth = null, APICreateBean bean = null)

Create a new API

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateAPIUsingPOST1Example
    {
        public void main()
        {
            var apiInstance = new APIsApi();
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var bean = new APICreateBean(); // APICreateBean | API json to create a API (optional) 

            try
            {
                // Create a new API
                APIResponse result = apiInstance.CreateAPIUsingPOST1(sensediaAuth, bean);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIsApi.CreateAPIUsingPOST1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **bean** | [**APICreateBean**](APICreateBean.md)| API json to create a API | [optional] 

### Return type

[**APIResponse**](APIResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteapiusingdelete1"></a>
# **DeleteAPIUsingDELETE1**
> ResponseEntity DeleteAPIUsingDELETE1 (string id, string sensediaAuth = null)

Delete a API

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAPIUsingDELETE1Example
    {
        public void main()
        {
            var apiInstance = new APIsApi();
            var id = id_example;  // string | API id
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Delete a API
                ResponseEntity result = apiInstance.DeleteAPIUsingDELETE1(id, sensediaAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIsApi.DeleteAPIUsingDELETE1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| API id | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findlastrevisionusingget1"></a>
# **FindLastRevisionUsingGET1**
> RevisionBean FindLastRevisionUsingGET1 (long? id, string sensediaAuth = null)

Find last revision by API id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FindLastRevisionUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new APIsApi();
            var id = 789;  // long? | id
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Find last revision by API id
                RevisionBean result = apiInstance.FindLastRevisionUsingGET1(id, sensediaAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIsApi.FindLastRevisionUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| id | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 

### Return type

[**RevisionBean**](RevisionBean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findversionsbyapiusingget1"></a>
# **FindVersionsByAPIUsingGET1**
> List<API> FindVersionsByAPIUsingGET1 (string id, string sensediaAuth = null)

Find version by API id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FindVersionsByAPIUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new APIsApi();
            var id = id_example;  // string | API id
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Find version by API id
                List&lt;API&gt; result = apiInstance.FindVersionsByAPIUsingGET1(id, sensediaAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIsApi.FindVersionsByAPIUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| API id | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 

### Return type

[**List<API>**](API.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapibyidusingget1"></a>
# **GetAPIByIdUsingGET1**
> API GetAPIByIdUsingGET1 (string apiId, string sensediaAuth = null, string filter = null)

Find API by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAPIByIdUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new APIsApi();
            var apiId = apiId_example;  // string | API id
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var filter = filter_example;  // string | Filter type searched (optional) 

            try
            {
                // Find API by id
                API result = apiInstance.GetAPIByIdUsingGET1(apiId, sensediaAuth, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIsApi.GetAPIByIdUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiId** | **string**| API id | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **filter** | **string**| Filter type searched | [optional] 

### Return type

[**API**](API.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapichangelogusingget1"></a>
# **GetAPIChangeLogUsingGET1**
> List<ChangeLog> GetAPIChangeLogUsingGET1 (long? id, string sensediaAuth = null)

Retrive changelog per API id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAPIChangeLogUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new APIsApi();
            var id = 789;  // long? | API id
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Retrive changelog per API id
                List&lt;ChangeLog&gt; result = apiInstance.GetAPIChangeLogUsingGET1(id, sensediaAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIsApi.GetAPIChangeLogUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| API id | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 

### Return type

[**List<ChangeLog>**](ChangeLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapisusingget1"></a>
# **GetAPIsUsingGET1**
> List<API> GetAPIsUsingGET1 (string sensediaAuth = null, bool? privateAPI = null, string filter = null)

Return all APIs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAPIsUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new APIsApi();
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var privateAPI = true;  // bool? | Private API (optional) 
            var filter = filter_example;  // string | Filter type searched (optional) 

            try
            {
                // Return all APIs
                List&lt;API&gt; result = apiInstance.GetAPIsUsingGET1(sensediaAuth, privateAPI, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIsApi.GetAPIsUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **privateAPI** | **bool?**| Private API | [optional] 
 **filter** | **string**| Filter type searched | [optional] 

### Return type

[**List<API>**](API.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="newversionapiusingpost1"></a>
# **NewVersionAPIUsingPOST1**
> APIResponse NewVersionAPIUsingPOST1 (string id, string sensediaAuth = null, API apiBean = null)

Create new version

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class NewVersionAPIUsingPOST1Example
    {
        public void main()
        {
            var apiInstance = new APIsApi();
            var id = id_example;  // string | API id
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var apiBean = new API(); // API | API json to update a api (optional) 

            try
            {
                // Create new version
                APIResponse result = apiInstance.NewVersionAPIUsingPOST1(id, sensediaAuth, apiBean);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIsApi.NewVersionAPIUsingPOST1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| API id | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **apiBean** | [**API**](API.md)| API json to update a api | [optional] 

### Return type

[**APIResponse**](APIResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeenvironmentusingdelete1"></a>
# **RemoveEnvironmentUsingDELETE1**
> ResponseEntity RemoveEnvironmentUsingDELETE1 (string id, string environmentId, string sensediaAuth = null)

Delete environment link with API

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveEnvironmentUsingDELETE1Example
    {
        public void main()
        {
            var apiInstance = new APIsApi();
            var id = id_example;  // string | id
            var environmentId = environmentId_example;  // string | environmentId
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Delete environment link with API
                ResponseEntity result = apiInstance.RemoveEnvironmentUsingDELETE1(id, environmentId, sensediaAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIsApi.RemoveEnvironmentUsingDELETE1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id | 
 **environmentId** | **string**| environmentId | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateapiusingput1"></a>
# **UpdateAPIUsingPUT1**
> APIResponse UpdateAPIUsingPUT1 (string id, string sensediaAuth = null, API apiBean = null)

Update a API

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateAPIUsingPUT1Example
    {
        public void main()
        {
            var apiInstance = new APIsApi();
            var id = id_example;  // string | API id
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var apiBean = new API(); // API | API json to update a api (optional) 

            try
            {
                // Update a API
                APIResponse result = apiInstance.UpdateAPIUsingPUT1(id, sensediaAuth, apiBean);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIsApi.UpdateAPIUsingPUT1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| API id | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **apiBean** | [**API**](API.md)| API json to update a api | [optional] 

### Return type

[**APIResponse**](APIResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatepartialapiusingpost1"></a>
# **ValidatePartialAPIUsingPOST1**
> ResponseEntity ValidatePartialAPIUsingPOST1 (string sensediaAuth = null, API bean = null)

Validate partial a API

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ValidatePartialAPIUsingPOST1Example
    {
        public void main()
        {
            var apiInstance = new APIsApi();
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var bean = new API(); // API | API json to validate a API (optional) 

            try
            {
                // Validate partial a API
                ResponseEntity result = apiInstance.ValidatePartialAPIUsingPOST1(sensediaAuth, bean);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling APIsApi.ValidatePartialAPIUsingPOST1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **bean** | [**API**](API.md)| API json to validate a API | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

