# IO.Swagger.Api.DevelopersApi

All URIs are relative to *https://localhost/api-manager/api/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CountUsingGET12**](DevelopersApi.md#countusingget12) | **GET** /developers/count | Retrieve developers total
[**CreateOrUpdateDeveloper1**](DevelopersApi.md#createorupdatedeveloper1) | **PUT** /developers/{login} | Create or update developer
[**RemoveUserAccountUsingDELETE1**](DevelopersApi.md#removeuseraccountusingdelete1) | **DELETE** /developers/{login} | Delete developer
[**RetieveUserAccountUsingGET1**](DevelopersApi.md#retieveuseraccountusingget1) | **GET** /developers/{login} | Retrive developer per Login
[**RetrieveAccountChangeLogUsingGET1**](DevelopersApi.md#retrieveaccountchangelogusingget1) | **GET** /developers/{username}/changelog | Retrive audit developer per username
[**RetrieveUserAccountsUsingGET1**](DevelopersApi.md#retrieveuseraccountsusingget1) | **GET** /developers | Retrive developers


<a name="countusingget12"></a>
# **CountUsingGET12**
> long? CountUsingGET12 (string sensediaAuth = null)

Retrieve developers total

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CountUsingGET12Example
    {
        public void main()
        {
            var apiInstance = new DevelopersApi();
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Retrieve developers total
                long? result = apiInstance.CountUsingGET12(sensediaAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevelopersApi.CountUsingGET12: " + e.Message );
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

<a name="createorupdatedeveloper1"></a>
# **CreateOrUpdateDeveloper1**
> Developer CreateOrUpdateDeveloper1 (string login, Developer bean, string sensediaAuth = null)

Create or update developer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateOrUpdateDeveloper1Example
    {
        public void main()
        {
            var apiInstance = new DevelopersApi();
            var login = login_example;  // string | Developer Login
            var bean = new Developer(); // Developer | bean
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Create or update developer
                Developer result = apiInstance.CreateOrUpdateDeveloper1(login, bean, sensediaAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevelopersApi.CreateOrUpdateDeveloper1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **login** | **string**| Developer Login | 
 **bean** | [**Developer**](Developer.md)| bean | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 

### Return type

[**Developer**](Developer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeuseraccountusingdelete1"></a>
# **RemoveUserAccountUsingDELETE1**
> void RemoveUserAccountUsingDELETE1 (string login, string sensediaAuth = null)

Delete developer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveUserAccountUsingDELETE1Example
    {
        public void main()
        {
            var apiInstance = new DevelopersApi();
            var login = login_example;  // string | Developer Login
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Delete developer
                apiInstance.RemoveUserAccountUsingDELETE1(login, sensediaAuth);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevelopersApi.RemoveUserAccountUsingDELETE1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **login** | **string**| Developer Login | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retieveuseraccountusingget1"></a>
# **RetieveUserAccountUsingGET1**
> Developer RetieveUserAccountUsingGET1 (string login, string sensediaAuth = null)

Retrive developer per Login

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetieveUserAccountUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new DevelopersApi();
            var login = login_example;  // string | Developer Login
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Retrive developer per Login
                Developer result = apiInstance.RetieveUserAccountUsingGET1(login, sensediaAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevelopersApi.RetieveUserAccountUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **login** | **string**| Developer Login | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 

### Return type

[**Developer**](Developer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrieveaccountchangelogusingget1"></a>
# **RetrieveAccountChangeLogUsingGET1**
> List<ChangeLogBean> RetrieveAccountChangeLogUsingGET1 (string username, string sensediaAuth = null)

Retrive audit developer per username

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveAccountChangeLogUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new DevelopersApi();
            var username = username_example;  // string | Developer username
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Retrive audit developer per username
                List&lt;ChangeLogBean&gt; result = apiInstance.RetrieveAccountChangeLogUsingGET1(username, sensediaAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevelopersApi.RetrieveAccountChangeLogUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| Developer username | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 

### Return type

[**List<ChangeLogBean>**](ChangeLogBean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrieveuseraccountsusingget1"></a>
# **RetrieveUserAccountsUsingGET1**
> List<Developer> RetrieveUserAccountsUsingGET1 (string sensediaAuth = null, string loginOrEmail = null, string name = null, string email = null, int? actualPage = null, int? pageSize = null)

Retrive developers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveUserAccountsUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new DevelopersApi();
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var loginOrEmail = loginOrEmail_example;  // string | Login or E-mail (optional) 
            var name = name_example;  // string | Developer Name (optional) 
            var email = email_example;  // string | Developer E-mail (optional) 
            var actualPage = 56;  // int? | Number of the page in pagination. The starting page number is zero. (optional) 
            var pageSize = 56;  // int? | Define the size of the returned list of developers. (optional) 

            try
            {
                // Retrive developers
                List&lt;Developer&gt; result = apiInstance.RetrieveUserAccountsUsingGET1(sensediaAuth, loginOrEmail, name, email, actualPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevelopersApi.RetrieveUserAccountsUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **loginOrEmail** | **string**| Login or E-mail | [optional] 
 **name** | **string**| Developer Name | [optional] 
 **email** | **string**| Developer E-mail | [optional] 
 **actualPage** | **int?**| Number of the page in pagination. The starting page number is zero. | [optional] 
 **pageSize** | **int?**| Define the size of the returned list of developers. | [optional] 

### Return type

[**List<Developer>**](Developer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

