# IO.Swagger.Api.AppsApi

All URIs are relative to *https://localhost/api-manager/api/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CountUsingGET11**](AppsApi.md#countusingget11) | **GET** /apps/count | Retrieve App total
[**DeleteAppTokenUsingDELETE1**](AppsApi.md#deleteapptokenusingdelete1) | **DELETE** /apps/{code} | Delete a app
[**GetAppTokenByAppGalleryUsingGET1**](AppsApi.md#getapptokenbyappgalleryusingget1) | **GET** /apps/gallery | Return all apps
[**GetAppTokenByFilterUsingGET1**](AppsApi.md#getapptokenbyfilterusingget1) | **GET** /apps | Find app list by filters
[**GetAppTokenByIdUsingGET1**](AppsApi.md#getapptokenbyidusingget1) | **GET** /apps/{code} | Find app by code
[**GetAppTokenChangeLogUsingGET1**](AppsApi.md#getapptokenchangelogusingget1) | **GET** /apps/{code}/changelog | Retrive changelog per app id
[**PostAppTokenUsingPOST1**](AppsApi.md#postapptokenusingpost1) | **POST** /apps | Create a new app
[**PutAppTokenUsingPUT1**](AppsApi.md#putapptokenusingput1) | **PUT** /apps/{id} | Update a app
[**ValidatePartialAppUsingPOST1**](AppsApi.md#validatepartialappusingpost1) | **POST** /apps/validate | Validate partial app


<a name="countusingget11"></a>
# **CountUsingGET11**
> long? CountUsingGET11 (string sensediaAuth = null)

Retrieve App total

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CountUsingGET11Example
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Retrieve App total
                long? result = apiInstance.CountUsingGET11(sensediaAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.CountUsingGET11: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 

### Return type

**long?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteapptokenusingdelete1"></a>
# **DeleteAppTokenUsingDELETE1**
> void DeleteAppTokenUsingDELETE1 (string id, string sensediaAuth = null)

Delete a app

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAppTokenUsingDELETE1Example
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var id = id_example;  // string | id
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Delete a app
                apiInstance.DeleteAppTokenUsingDELETE1(id, sensediaAuth);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.DeleteAppTokenUsingDELETE1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapptokenbyappgalleryusingget1"></a>
# **GetAppTokenByAppGalleryUsingGET1**
> List<APP> GetAppTokenByAppGalleryUsingGET1 (string sensediaAuth = null)

Return all apps

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAppTokenByAppGalleryUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Return all apps
                List&lt;APP&gt; result = apiInstance.GetAppTokenByAppGalleryUsingGET1(sensediaAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.GetAppTokenByAppGalleryUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 

### Return type

[**List<APP>**](APP.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapptokenbyfilterusingget1"></a>
# **GetAppTokenByFilterUsingGET1**
> List<APP> GetAppTokenByFilterUsingGET1 (string sensediaAuth = null, string clientId = null, string name = null, string keyword = null, string status = null, string developer = null, int? actualPage = null, int? pageSize = null, string appIds = null, string beginDate = null, string endDate = null, string extraFields = null)

Find app list by filters

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAppTokenByFilterUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var clientId = clientId_example;  // string | clientId (optional) 
            var name = name_example;  // string | name (optional) 
            var keyword = keyword_example;  // string | keyword (optional) 
            var status = status_example;  // string | status (optional) 
            var developer = developer_example;  // string | developer (optional) 
            var actualPage = 56;  // int? | actualPage (optional) 
            var pageSize = 56;  // int? | pageSize (optional) 
            var appIds = appIds_example;  // string | appIds (optional) 
            var beginDate = beginDate_example;  // string | beginDate (optional) 
            var endDate = endDate_example;  // string | endDate (optional) 
            var extraFields = extraFields_example;  // string | extraFields (optional) 

            try
            {
                // Find app list by filters
                List&lt;APP&gt; result = apiInstance.GetAppTokenByFilterUsingGET1(sensediaAuth, clientId, name, keyword, status, developer, actualPage, pageSize, appIds, beginDate, endDate, extraFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.GetAppTokenByFilterUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **clientId** | **string**| clientId | [optional] 
 **name** | **string**| name | [optional] 
 **keyword** | **string**| keyword | [optional] 
 **status** | **string**| status | [optional] 
 **developer** | **string**| developer | [optional] 
 **actualPage** | **int?**| actualPage | [optional] 
 **pageSize** | **int?**| pageSize | [optional] 
 **appIds** | **string**| appIds | [optional] 
 **beginDate** | **string**| beginDate | [optional] 
 **endDate** | **string**| endDate | [optional] 
 **extraFields** | **string**| extraFields | [optional] 

### Return type

[**List<APP>**](APP.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapptokenbyidusingget1"></a>
# **GetAppTokenByIdUsingGET1**
> APP GetAppTokenByIdUsingGET1 (string code, string sensediaAuth = null, int? limitAccessTokens = null, string codeAccessTokens = null, bool? filterAccessTokens = null)

Find app by code

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAppTokenByIdUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var code = code_example;  // string | Client ID
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var limitAccessTokens = 56;  // int? | Limit the access token return (optional) 
            var codeAccessTokens = codeAccessTokens_example;  // string | Code access token (optional) 
            var filterAccessTokens = true;  // bool? | Filter access tokens (optional) 

            try
            {
                // Find app by code
                APP result = apiInstance.GetAppTokenByIdUsingGET1(code, sensediaAuth, limitAccessTokens, codeAccessTokens, filterAccessTokens);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.GetAppTokenByIdUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| Client ID | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **limitAccessTokens** | **int?**| Limit the access token return | [optional] 
 **codeAccessTokens** | **string**| Code access token | [optional] 
 **filterAccessTokens** | **bool?**| Filter access tokens | [optional] 

### Return type

[**APP**](APP.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapptokenchangelogusingget1"></a>
# **GetAppTokenChangeLogUsingGET1**
> List<ChangeLogBean> GetAppTokenChangeLogUsingGET1 (long? id, string sensediaAuth = null)

Retrive changelog per app id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAppTokenChangeLogUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var id = 789;  // long? | id
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Retrive changelog per app id
                List&lt;ChangeLogBean&gt; result = apiInstance.GetAppTokenChangeLogUsingGET1(id, sensediaAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.GetAppTokenChangeLogUsingGET1: " + e.Message );
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

[**List<ChangeLogBean>**](ChangeLogBean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postapptokenusingpost1"></a>
# **PostAppTokenUsingPOST1**
> APPResponse PostAppTokenUsingPOST1 (string sensediaAuth = null, APP appTokenBean = null)

Create a new app

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostAppTokenUsingPOST1Example
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var appTokenBean = new APP(); // APP | App json to create a new app. (optional) 

            try
            {
                // Create a new app
                APPResponse result = apiInstance.PostAppTokenUsingPOST1(sensediaAuth, appTokenBean);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.PostAppTokenUsingPOST1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **appTokenBean** | [**APP**](APP.md)| App json to create a new app. | [optional] 

### Return type

[**APPResponse**](APPResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putapptokenusingput1"></a>
# **PutAppTokenUsingPUT1**
> APPResponse PutAppTokenUsingPUT1 (string id, APP appTokenBean, string sensediaAuth = null)

Update a app

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutAppTokenUsingPUT1Example
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var id = id_example;  // string | App json to update a app.
            var appTokenBean = new APP(); // APP | appTokenBean
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Update a app
                APPResponse result = apiInstance.PutAppTokenUsingPUT1(id, appTokenBean, sensediaAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.PutAppTokenUsingPUT1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| App json to update a app. | 
 **appTokenBean** | [**APP**](APP.md)| appTokenBean | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 

### Return type

[**APPResponse**](APPResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatepartialappusingpost1"></a>
# **ValidatePartialAppUsingPOST1**
> Object ValidatePartialAppUsingPOST1 (string sensediaAuth = null, APP appTokenBean = null)

Validate partial app

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ValidatePartialAppUsingPOST1Example
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var appTokenBean = new APP(); // APP | App json to validate app (optional) 

            try
            {
                // Validate partial app
                Object result = apiInstance.ValidatePartialAppUsingPOST1(sensediaAuth, appTokenBean);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.ValidatePartialAppUsingPOST1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **appTokenBean** | [**APP**](APP.md)| App json to validate app | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

