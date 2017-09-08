# IO.Swagger.Api.PlansApi

All URIs are relative to *https://localhost/api-manager/api/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ClonePlanUsingPOST1**](PlansApi.md#cloneplanusingpost1) | **POST** /plans/{id}/clone | Clone a plan
[**CountUsingGET13**](PlansApi.md#countusingget13) | **GET** /plans/count | Retrieve plan total
[**DeletePlanUsingDELETE1**](PlansApi.md#deleteplanusingdelete1) | **DELETE** /plans/{id} | Delete a plan
[**GetPlanChangeLogUsingGET3**](PlansApi.md#getplanchangelogusingget3) | **GET** /plans/{id}/changelog | Retrive changelog per plan id
[**GetPlanDefaultByApiUsingGET1**](PlansApi.md#getplandefaultbyapiusingget1) | **GET** /plans/{id}/defaultPlan | Find default plan by api id
[**GetPlanUsingGET2**](PlansApi.md#getplanusingget2) | **GET** /plans/{id} | Find plan by id
[**GetPlanUsingGET3**](PlansApi.md#getplanusingget3) | **GET** /plans | Return all plan
[**PostPlanUsingPOST1**](PlansApi.md#postplanusingpost1) | **POST** /plans | Create a new plan
[**PutPlanUsingPUT1**](PlansApi.md#putplanusingput1) | **PUT** /plans/{id} | Update a plan
[**ValidatePartialPlanUsingPOST1**](PlansApi.md#validatepartialplanusingpost1) | **POST** /plans/validate | Validate partial a plan


<a name="cloneplanusingpost1"></a>
# **ClonePlanUsingPOST1**
> PlanResponse ClonePlanUsingPOST1 (string id, string sensediaAuth = null)

Clone a plan

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ClonePlanUsingPOST1Example
    {
        public void main()
        {
            var apiInstance = new PlansApi();
            var id = id_example;  // string | Plan id
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Clone a plan
                PlanResponse result = apiInstance.ClonePlanUsingPOST1(id, sensediaAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlansApi.ClonePlanUsingPOST1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Plan id | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 

### Return type

[**PlanResponse**](PlanResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="countusingget13"></a>
# **CountUsingGET13**
> long? CountUsingGET13 (string sensediaAuth = null)

Retrieve plan total

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CountUsingGET13Example
    {
        public void main()
        {
            var apiInstance = new PlansApi();
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Retrieve plan total
                long? result = apiInstance.CountUsingGET13(sensediaAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlansApi.CountUsingGET13: " + e.Message );
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

<a name="deleteplanusingdelete1"></a>
# **DeletePlanUsingDELETE1**
> ResponseEntity DeletePlanUsingDELETE1 (string id, string sensediaAuth = null)

Delete a plan

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeletePlanUsingDELETE1Example
    {
        public void main()
        {
            var apiInstance = new PlansApi();
            var id = id_example;  // string | Plan id
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Delete a plan
                ResponseEntity result = apiInstance.DeletePlanUsingDELETE1(id, sensediaAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlansApi.DeletePlanUsingDELETE1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Plan id | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplanchangelogusingget3"></a>
# **GetPlanChangeLogUsingGET3**
> List<ChangeLogBean> GetPlanChangeLogUsingGET3 (long? id, string sensediaAuth = null)

Retrive changelog per plan id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPlanChangeLogUsingGET3Example
    {
        public void main()
        {
            var apiInstance = new PlansApi();
            var id = 789;  // long? | id
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Retrive changelog per plan id
                List&lt;ChangeLogBean&gt; result = apiInstance.GetPlanChangeLogUsingGET3(id, sensediaAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlansApi.GetPlanChangeLogUsingGET3: " + e.Message );
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

<a name="getplandefaultbyapiusingget1"></a>
# **GetPlanDefaultByApiUsingGET1**
> PlanResponse GetPlanDefaultByApiUsingGET1 (string id, string sensediaAuth = null)

Find default plan by api id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPlanDefaultByApiUsingGET1Example
    {
        public void main()
        {
            var apiInstance = new PlansApi();
            var id = id_example;  // string | Api id
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Find default plan by api id
                PlanResponse result = apiInstance.GetPlanDefaultByApiUsingGET1(id, sensediaAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlansApi.GetPlanDefaultByApiUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Api id | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 

### Return type

[**PlanResponse**](PlanResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplanusingget2"></a>
# **GetPlanUsingGET2**
> PlanResponse GetPlanUsingGET2 (string id, string sensediaAuth = null)

Find plan by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPlanUsingGET2Example
    {
        public void main()
        {
            var apiInstance = new PlansApi();
            var id = id_example;  // string | id
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Find plan by id
                PlanResponse result = apiInstance.GetPlanUsingGET2(id, sensediaAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlansApi.GetPlanUsingGET2: " + e.Message );
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

[**PlanResponse**](PlanResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplanusingget3"></a>
# **GetPlanUsingGET3**
> List<PlanResponse> GetPlanUsingGET3 (string sensediaAuth = null)

Return all plan

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPlanUsingGET3Example
    {
        public void main()
        {
            var apiInstance = new PlansApi();
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Return all plan
                List&lt;PlanResponse&gt; result = apiInstance.GetPlanUsingGET3(sensediaAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlansApi.GetPlanUsingGET3: " + e.Message );
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

[**List<PlanResponse>**](PlanResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postplanusingpost1"></a>
# **PostPlanUsingPOST1**
> PlanResponse PostPlanUsingPOST1 (PlanResponse planBean, string sensediaAuth = null)

Create a new plan

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostPlanUsingPOST1Example
    {
        public void main()
        {
            var apiInstance = new PlansApi();
            var planBean = new PlanResponse(); // PlanResponse | planBean
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 

            try
            {
                // Create a new plan
                PlanResponse result = apiInstance.PostPlanUsingPOST1(planBean, sensediaAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlansApi.PostPlanUsingPOST1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **planBean** | [**PlanResponse**](PlanResponse.md)| planBean | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 

### Return type

[**PlanResponse**](PlanResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putplanusingput1"></a>
# **PutPlanUsingPUT1**
> PlanResponse PutPlanUsingPUT1 (string id, string sensediaAuth = null, PlanResponse planBean = null)

Update a plan

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutPlanUsingPUT1Example
    {
        public void main()
        {
            var apiInstance = new PlansApi();
            var id = id_example;  // string | Plan id
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var planBean = new PlanResponse(); // PlanResponse | Plan json to update a plan (optional) 

            try
            {
                // Update a plan
                PlanResponse result = apiInstance.PutPlanUsingPUT1(id, sensediaAuth, planBean);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlansApi.PutPlanUsingPUT1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Plan id | 
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **planBean** | [**PlanResponse**](PlanResponse.md)| Plan json to update a plan | [optional] 

### Return type

[**PlanResponse**](PlanResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatepartialplanusingpost1"></a>
# **ValidatePartialPlanUsingPOST1**
> ResponseEntity ValidatePartialPlanUsingPOST1 (string sensediaAuth = null, PlanResponse planBean = null)

Validate partial a plan

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ValidatePartialPlanUsingPOST1Example
    {
        public void main()
        {
            var apiInstance = new PlansApi();
            var sensediaAuth = sensediaAuth_example;  // string | Sensedia-Auth (optional) 
            var planBean = new PlanResponse(); // PlanResponse | Plan json to validate a plan (optional) 

            try
            {
                // Validate partial a plan
                ResponseEntity result = apiInstance.ValidatePartialPlanUsingPOST1(sensediaAuth, planBean);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlansApi.ValidatePartialPlanUsingPOST1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sensediaAuth** | **string**| Sensedia-Auth | [optional] 
 **planBean** | [**PlanResponse**](PlanResponse.md)| Plan json to validate a plan | [optional] 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

