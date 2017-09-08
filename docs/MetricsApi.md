# IO.Swagger.Api.MetricsApi

All URIs are relative to *https://localhost/api-manager/api/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FindHealthUsingGET1**](MetricsApi.md#findhealthusingget1) | **GET** /metrics/health | Find Health
[**FindTopAccessTokensUsingGET1**](MetricsApi.md#findtopaccesstokensusingget1) | **GET** /metrics/top-access-tokens/{howMany} | Find top access token
[**FindTopAppsUsingGET1**](MetricsApi.md#findtopappsusingget1) | **GET** /metrics/top-apps/{howMany} | Find top apps
[**GetAccessTokensByMonthUsingGET1**](MetricsApi.md#getaccesstokensbymonthusingget1) | **GET** /metrics/access-tokens | Find access token consolited by month
[**GetAppsByMonthUsingGET1**](MetricsApi.md#getappsbymonthusingget1) | **GET** /metrics/apps | Find apps consolited by month
[**GetCacheLatencyUsingGET1**](MetricsApi.md#getcachelatencyusingget1) | **GET** /metrics/cache/latency | Find cache latency
[**GetCacheSizeUsingGET1**](MetricsApi.md#getcachesizeusingget1) | **GET** /metrics/cache/size | Retrive cache size
[**GetCacheUsingGET1**](MetricsApi.md#getcacheusingget1) | **GET** /metrics/cache | Find cache
[**GetCallsByMonthUsingGET1**](MetricsApi.md#getcallsbymonthusingget1) | **GET** /metrics/calls | Find calls by month
[**GetLatencyByMonthUsingGET1**](MetricsApi.md#getlatencybymonthusingget1) | **GET** /metrics/latency | Find latency by month
[**GetStatusErrorUsingGET1**](MetricsApi.md#getstatuserrorusingget1) | **GET** /metrics/statusError | Retrive Status Error


<a name="findhealthusingget1"></a>
# **FindHealthUsingGET1**
> List<OperationHealth> FindHealthUsingGET1 (string sensediaAuth = null, bool? healthPortal = null)

Find Health

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FindHealthUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new MetricsApi();
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var healthPortal = true;  // bool? | Health Portal (optional) 

            try
            {
                // Find Health
                List&lt;OperationHealth&gt; result = apiInstance.FindHealthUsingGET1(sensediaAuth, healthPortal);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetricsApi.FindHealthUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **healthPortal** | **bool?**| Health Portal | [optional] 

### Return type

[**List<OperationHealth>**](OperationHealth.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findtopaccesstokensusingget1"></a>
# **FindTopAccessTokensUsingGET1**
> List<TopAccessToken> FindTopAccessTokensUsingGET1 (int? howMany, string sensediaAuth = null, string beginDate = null, string endDate = null, string status = null, string resolution = null)

Find top access token

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FindTopAccessTokensUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new MetricsApi();
            var howMany = 56;  // int? | How many
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var beginDate = beginDate_example;  // string | Begin date (optional) 
            var endDate = endDate_example;  // string | End date (optional) 
            var status = status_example;  // string | Metric status (optional) 
            var resolution = resolution_example;  // string | Metric resolution (optional) 

            try
            {
                // Find top access token
                List&lt;TopAccessToken&gt; result = apiInstance.FindTopAccessTokensUsingGET1(howMany, sensediaAuth, beginDate, endDate, status, resolution);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetricsApi.FindTopAccessTokensUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **howMany** | **int?**| How many | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **beginDate** | **string**| Begin date | [optional] 
 **endDate** | **string**| End date | [optional] 
 **status** | **string**| Metric status | [optional] 
 **resolution** | **string**| Metric resolution | [optional] 

### Return type

[**List<TopAccessToken>**](TopAccessToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findtopappsusingget1"></a>
# **FindTopAppsUsingGET1**
> List<TopApp> FindTopAppsUsingGET1 (int? howMany, string sensediaAuth = null, string beginDate = null, string endDate = null, string status = null, string resolution = null)

Find top apps

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FindTopAppsUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new MetricsApi();
            var howMany = 56;  // int? | How many
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var beginDate = beginDate_example;  // string | Begin date (optional) 
            var endDate = endDate_example;  // string | End date (optional) 
            var status = status_example;  // string | Metric status (optional) 
            var resolution = resolution_example;  // string | Metric resolution (optional) 

            try
            {
                // Find top apps
                List&lt;TopApp&gt; result = apiInstance.FindTopAppsUsingGET1(howMany, sensediaAuth, beginDate, endDate, status, resolution);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetricsApi.FindTopAppsUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **howMany** | **int?**| How many | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **beginDate** | **string**| Begin date | [optional] 
 **endDate** | **string**| End date | [optional] 
 **status** | **string**| Metric status | [optional] 
 **resolution** | **string**| Metric resolution | [optional] 

### Return type

[**List<TopApp>**](TopApp.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccesstokensbymonthusingget1"></a>
# **GetAccessTokensByMonthUsingGET1**
> List<TokensMetric> GetAccessTokensByMonthUsingGET1 (string sensediaAuth = null, string beginDate = null, string endDate = null, string resolution = null)

Find access token consolited by month

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAccessTokensByMonthUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new MetricsApi();
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var beginDate = beginDate_example;  // string | Begin date (optional) 
            var endDate = endDate_example;  // string | End date (optional) 
            var resolution = resolution_example;  // string | Metric resolution (optional) 

            try
            {
                // Find access token consolited by month
                List&lt;TokensMetric&gt; result = apiInstance.GetAccessTokensByMonthUsingGET1(sensediaAuth, beginDate, endDate, resolution);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetricsApi.GetAccessTokensByMonthUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **beginDate** | **string**| Begin date | [optional] 
 **endDate** | **string**| End date | [optional] 
 **resolution** | **string**| Metric resolution | [optional] 

### Return type

[**List<TokensMetric>**](TokensMetric.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getappsbymonthusingget1"></a>
# **GetAppsByMonthUsingGET1**
> List<TokensMetric> GetAppsByMonthUsingGET1 (string sensediaAuth = null, string beginDate = null, string endDate = null, string resolution = null)

Find apps consolited by month

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAppsByMonthUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new MetricsApi();
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var beginDate = beginDate_example;  // string | Begin date (optional) 
            var endDate = endDate_example;  // string | End date (optional) 
            var resolution = resolution_example;  // string | Metric resolution (optional) 

            try
            {
                // Find apps consolited by month
                List&lt;TokensMetric&gt; result = apiInstance.GetAppsByMonthUsingGET1(sensediaAuth, beginDate, endDate, resolution);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetricsApi.GetAppsByMonthUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **beginDate** | **string**| Begin date | [optional] 
 **endDate** | **string**| End date | [optional] 
 **resolution** | **string**| Metric resolution | [optional] 

### Return type

[**List<TokensMetric>**](TokensMetric.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcachelatencyusingget1"></a>
# **GetCacheLatencyUsingGET1**
> List<OperationMetric> GetCacheLatencyUsingGET1 (string sensediaAuth = null, long? apiId = null, long? revisionId = null, long? operationId = null, long? environmentId = null, string beginDate = null, string endDate = null, string resolution = null)

Find cache latency

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCacheLatencyUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new MetricsApi();
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var apiId = 789;  // long? | API id (optional) 
            var revisionId = 789;  // long? | Revision id (optional) 
            var operationId = 789;  // long? | Operation id (optional) 
            var environmentId = 789;  // long? | Environment id (optional) 
            var beginDate = beginDate_example;  // string | Begin date (optional) 
            var endDate = endDate_example;  // string | End date (optional) 
            var resolution = resolution_example;  // string | Metric resolution (optional) 

            try
            {
                // Find cache latency
                List&lt;OperationMetric&gt; result = apiInstance.GetCacheLatencyUsingGET1(sensediaAuth, apiId, revisionId, operationId, environmentId, beginDate, endDate, resolution);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetricsApi.GetCacheLatencyUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **apiId** | **long?**| API id | [optional] 
 **revisionId** | **long?**| Revision id | [optional] 
 **operationId** | **long?**| Operation id | [optional] 
 **environmentId** | **long?**| Environment id | [optional] 
 **beginDate** | **string**| Begin date | [optional] 
 **endDate** | **string**| End date | [optional] 
 **resolution** | **string**| Metric resolution | [optional] 

### Return type

[**List<OperationMetric>**](OperationMetric.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcachesizeusingget1"></a>
# **GetCacheSizeUsingGET1**
> CacheMetric GetCacheSizeUsingGET1 (string sensediaAuth = null, long? apiId = null, long? revisionId = null, long? operationId = null, long? environmentId = null)

Retrive cache size

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCacheSizeUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new MetricsApi();
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var apiId = 789;  // long? | API id (optional) 
            var revisionId = 789;  // long? | Revision id (optional) 
            var operationId = 789;  // long? | Operation id (optional) 
            var environmentId = 789;  // long? | Environment id (optional) 

            try
            {
                // Retrive cache size
                CacheMetric result = apiInstance.GetCacheSizeUsingGET1(sensediaAuth, apiId, revisionId, operationId, environmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetricsApi.GetCacheSizeUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **apiId** | **long?**| API id | [optional] 
 **revisionId** | **long?**| Revision id | [optional] 
 **operationId** | **long?**| Operation id | [optional] 
 **environmentId** | **long?**| Environment id | [optional] 

### Return type

[**CacheMetric**](CacheMetric.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcacheusingget1"></a>
# **GetCacheUsingGET1**
> List<OperationMetric> GetCacheUsingGET1 (string sensediaAuth = null, long? apiId = null, long? revisionId = null, long? operationId = null, long? environmentId = null, string beginDate = null, string endDate = null, string resolution = null)

Find cache

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCacheUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new MetricsApi();
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var apiId = 789;  // long? | API id (optional) 
            var revisionId = 789;  // long? | Revision id (optional) 
            var operationId = 789;  // long? | Operation id (optional) 
            var environmentId = 789;  // long? | Environment id (optional) 
            var beginDate = beginDate_example;  // string | Begin date (optional) 
            var endDate = endDate_example;  // string | End date (optional) 
            var resolution = resolution_example;  // string | Metric resolution (optional) 

            try
            {
                // Find cache
                List&lt;OperationMetric&gt; result = apiInstance.GetCacheUsingGET1(sensediaAuth, apiId, revisionId, operationId, environmentId, beginDate, endDate, resolution);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetricsApi.GetCacheUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **apiId** | **long?**| API id | [optional] 
 **revisionId** | **long?**| Revision id | [optional] 
 **operationId** | **long?**| Operation id | [optional] 
 **environmentId** | **long?**| Environment id | [optional] 
 **beginDate** | **string**| Begin date | [optional] 
 **endDate** | **string**| End date | [optional] 
 **resolution** | **string**| Metric resolution | [optional] 

### Return type

[**List<OperationMetric>**](OperationMetric.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcallsbymonthusingget1"></a>
# **GetCallsByMonthUsingGET1**
> List<CallsMetric> GetCallsByMonthUsingGET1 (string sensediaAuth = null, string beginDate = null, string endDate = null, string resolution = null, long? environmentId = null, long? apiId = null, long? revisionId = null)

Find calls by month

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCallsByMonthUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new MetricsApi();
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var beginDate = beginDate_example;  // string | Begin date (optional) 
            var endDate = endDate_example;  // string | End date (optional) 
            var resolution = resolution_example;  // string | Metric resolution (optional) 
            var environmentId = 789;  // long? | Environment id (optional) 
            var apiId = 789;  // long? | API id (optional) 
            var revisionId = 789;  // long? | Revision id (optional) 

            try
            {
                // Find calls by month
                List&lt;CallsMetric&gt; result = apiInstance.GetCallsByMonthUsingGET1(sensediaAuth, beginDate, endDate, resolution, environmentId, apiId, revisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetricsApi.GetCallsByMonthUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **beginDate** | **string**| Begin date | [optional] 
 **endDate** | **string**| End date | [optional] 
 **resolution** | **string**| Metric resolution | [optional] 
 **environmentId** | **long?**| Environment id | [optional] 
 **apiId** | **long?**| API id | [optional] 
 **revisionId** | **long?**| Revision id | [optional] 

### Return type

[**List<CallsMetric>**](CallsMetric.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlatencybymonthusingget1"></a>
# **GetLatencyByMonthUsingGET1**
> List<LatencyMetric> GetLatencyByMonthUsingGET1 (string sensediaAuth = null, string beginDate = null, string endDate = null, string resolution = null)

Find latency by month

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLatencyByMonthUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new MetricsApi();
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var beginDate = beginDate_example;  // string | Begin date (optional) 
            var endDate = endDate_example;  // string | End date (optional) 
            var resolution = resolution_example;  // string | Metric resolution (optional) 

            try
            {
                // Find latency by month
                List&lt;LatencyMetric&gt; result = apiInstance.GetLatencyByMonthUsingGET1(sensediaAuth, beginDate, endDate, resolution);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetricsApi.GetLatencyByMonthUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **beginDate** | **string**| Begin date | [optional] 
 **endDate** | **string**| End date | [optional] 
 **resolution** | **string**| Metric resolution | [optional] 

### Return type

[**List<LatencyMetric>**](LatencyMetric.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstatuserrorusingget1"></a>
# **GetStatusErrorUsingGET1**
> int? GetStatusErrorUsingGET1 (string sensediaAuth = null)

Retrive Status Error

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStatusErrorUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new MetricsApi();
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Retrive Status Error
                int? result = apiInstance.GetStatusErrorUsingGET1(sensediaAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetricsApi.GetStatusErrorUsingGET1: " + e.Message );
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

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

