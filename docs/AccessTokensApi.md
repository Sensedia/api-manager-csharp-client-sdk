# IO.Swagger.Api.AccessTokensApi

All URIs are relative to *https://localhost/api-manager/api/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CountUsingGET10**](AccessTokensApi.md#countusingget10) | **GET** /access-tokens/count | Retrieve access token total
[**RemoveAuthTokenUsingDELETE1**](AccessTokensApi.md#removeauthtokenusingdelete1) | **DELETE** /access-tokens/{id} | Remove a access token
[**RetrieveAuthTokenChangeLogUsingGET1**](AccessTokensApi.md#retrieveauthtokenchangelogusingget1) | **GET** /access-tokens/{id}/changelog | Retrive changelog per access token id
[**RetriveAuthTokenByCodeUsingGET1**](AccessTokensApi.md#retriveauthtokenbycodeusingget1) | **GET** /access-tokens/{code} | Find access token by code
[**RetriveAuthTokenUsingGET1**](AccessTokensApi.md#retriveauthtokenusingget1) | **GET** /access-tokens | Find access token list by filters
[**SaveAuthTokenUsingPOST1**](AccessTokensApi.md#saveauthtokenusingpost1) | **POST** /access-tokens | Create a new access token
[**UpdateAuthTokenUsingPUT1**](AccessTokensApi.md#updateauthtokenusingput1) | **PUT** /access-tokens/{id} | Update a access token
[**ValidatePartialAccessTokenUsingPOST1**](AccessTokensApi.md#validatepartialaccesstokenusingpost1) | **POST** /access-tokens/validate | Validate partial access token


<a name="countusingget10"></a>
# **CountUsingGET10**
> long? CountUsingGET10 (string sensediaAuth = null)

Retrieve access token total

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CountUsingGET10Example
    {
        public void main()
        {
            var apiInstance = new AccessTokensApi();
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Retrieve access token total
                long? result = apiInstance.CountUsingGET10(sensediaAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessTokensApi.CountUsingGET10: " + e.Message );
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

<a name="removeauthtokenusingdelete1"></a>
# **RemoveAuthTokenUsingDELETE1**
> void RemoveAuthTokenUsingDELETE1 (string id, string sensediaAuth = null)

Remove a access token

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveAuthTokenUsingDELETE1Example
    {
        public void main()
        {
            var apiInstance = new AccessTokensApi();
            var id = id_example;  // string | App id
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Remove a access token
                apiInstance.RemoveAuthTokenUsingDELETE1(id, sensediaAuth);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessTokensApi.RemoveAuthTokenUsingDELETE1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| App id | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrieveauthtokenchangelogusingget1"></a>
# **RetrieveAuthTokenChangeLogUsingGET1**
> List<ChangeLogBean> RetrieveAuthTokenChangeLogUsingGET1 (long? id, string sensediaAuth = null)

Retrive changelog per access token id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveAuthTokenChangeLogUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new AccessTokensApi();
            var id = 789;  // long? | Access token id
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Retrive changelog per access token id
                List&lt;ChangeLogBean&gt; result = apiInstance.RetrieveAuthTokenChangeLogUsingGET1(id, sensediaAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessTokensApi.RetrieveAuthTokenChangeLogUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Access token id | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 

### Return type

[**List<ChangeLogBean>**](ChangeLogBean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retriveauthtokenbycodeusingget1"></a>
# **RetriveAuthTokenByCodeUsingGET1**
> AccessToken RetriveAuthTokenByCodeUsingGET1 (string code, string sensediaAuth = null)

Find access token by code

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetriveAuthTokenByCodeUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new AccessTokensApi();
            var code = code_example;  // string | Code
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Find access token by code
                AccessToken result = apiInstance.RetriveAuthTokenByCodeUsingGET1(code, sensediaAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessTokensApi.RetriveAuthTokenByCodeUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| Code | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 

### Return type

[**AccessToken**](AccessToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retriveauthtokenusingget1"></a>
# **RetriveAuthTokenUsingGET1**
> List<AccessToken> RetriveAuthTokenUsingGET1 (string sensediaAuth = null, string code = null, string owner = null, string status = null, long? expiresIn = null, string refreshToken = null, string scope = null, string keyword = null, int? actualPage = null, int? pageSize = null, string authIds = null, string beginDate = null, string endDate = null, string extraFields = null)

Find access token list by filters

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetriveAuthTokenUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new AccessTokensApi();
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var code = code_example;  // string | code (optional) 
            var owner = owner_example;  // string | owner (optional) 
            var status = status_example;  // string | staus(ACTIVE, REVOKED, EXPIRED) (optional) 
            var expiresIn = 789;  // long? | Expires in millisecond (optional) 
            var refreshToken = refreshToken_example;  // string | Refresh code (optional) 
            var scope = scope_example;  // string | Scope (optional) 
            var keyword = keyword_example;  // string | Keyword to find between code or owner (optional) 
            var actualPage = 56;  // int? | Number of the page in pagination. The starting page number is zero. (optional) 
            var pageSize = 56;  // int? | Define the size of the returned list of developers. (optional) 
            var authIds = authIds_example;  // string | Id access token separated by space. Ex:(1 3 6 8) (optional) 
            var beginDate = beginDate_example;  // string | Begin date (optional) 
            var endDate = endDate_example;  // string | End date (optional) 
            var extraFields = extraFields_example;  // string | Extra field separated by comma (optional) 

            try
            {
                // Find access token list by filters
                List&lt;AccessToken&gt; result = apiInstance.RetriveAuthTokenUsingGET1(sensediaAuth, code, owner, status, expiresIn, refreshToken, scope, keyword, actualPage, pageSize, authIds, beginDate, endDate, extraFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessTokensApi.RetriveAuthTokenUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **code** | **string**| code | [optional] 
 **owner** | **string**| owner | [optional] 
 **status** | **string**| staus(ACTIVE, REVOKED, EXPIRED) | [optional] 
 **expiresIn** | **long?**| Expires in millisecond | [optional] 
 **refreshToken** | **string**| Refresh code | [optional] 
 **scope** | **string**| Scope | [optional] 
 **keyword** | **string**| Keyword to find between code or owner | [optional] 
 **actualPage** | **int?**| Number of the page in pagination. The starting page number is zero. | [optional] 
 **pageSize** | **int?**| Define the size of the returned list of developers. | [optional] 
 **authIds** | **string**| Id access token separated by space. Ex:(1 3 6 8) | [optional] 
 **beginDate** | **string**| Begin date | [optional] 
 **endDate** | **string**| End date | [optional] 
 **extraFields** | **string**| Extra field separated by comma | [optional] 

### Return type

[**List<AccessToken>**](AccessToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="saveauthtokenusingpost1"></a>
# **SaveAuthTokenUsingPOST1**
> AccessToken SaveAuthTokenUsingPOST1 (string sensediaAuth = null, AccessToken bean = null)

Create a new access token

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SaveAuthTokenUsingPOST1Example
    {
        public void main()
        {
            var apiInstance = new AccessTokensApi();
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var bean = new AccessToken(); // AccessToken | Access token json to create a new access token. (optional) 

            try
            {
                // Create a new access token
                AccessToken result = apiInstance.SaveAuthTokenUsingPOST1(sensediaAuth, bean);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessTokensApi.SaveAuthTokenUsingPOST1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **bean** | [**AccessToken**](AccessToken.md)| Access token json to create a new access token. | [optional] 

### Return type

[**AccessToken**](AccessToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateauthtokenusingput1"></a>
# **UpdateAuthTokenUsingPUT1**
> AccessTokenResponse UpdateAuthTokenUsingPUT1 (string id, string sensediaAuth = null, AccessToken bean = null)

Update a access token

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateAuthTokenUsingPUT1Example
    {
        public void main()
        {
            var apiInstance = new AccessTokensApi();
            var id = id_example;  // string | Access token id
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var bean = new AccessToken(); // AccessToken | Access token json to update a access token. (optional) 

            try
            {
                // Update a access token
                AccessTokenResponse result = apiInstance.UpdateAuthTokenUsingPUT1(id, sensediaAuth, bean);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessTokensApi.UpdateAuthTokenUsingPUT1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Access token id | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **bean** | [**AccessToken**](AccessToken.md)| Access token json to update a access token. | [optional] 

### Return type

[**AccessTokenResponse**](AccessTokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatepartialaccesstokenusingpost1"></a>
# **ValidatePartialAccessTokenUsingPOST1**
> Object ValidatePartialAccessTokenUsingPOST1 (string sensediaAuth = null, AccessToken bean = null)

Validate partial access token

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ValidatePartialAccessTokenUsingPOST1Example
    {
        public void main()
        {
            var apiInstance = new AccessTokensApi();
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var bean = new AccessToken(); // AccessToken | Access token json to validate a access token. (optional) 

            try
            {
                // Validate partial access token
                Object result = apiInstance.ValidatePartialAccessTokenUsingPOST1(sensediaAuth, bean);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessTokensApi.ValidatePartialAccessTokenUsingPOST1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **bean** | [**AccessToken**](AccessToken.md)| Access token json to validate a access token. | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

