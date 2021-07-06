# ElementsSDK.Api.AWSApi

All URIs are relative to *https://elements.local*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAWSAccount**](AWSApi.md#createawsaccount) | **POST** /api/2/aws-accounts | 
[**DeleteAWSAccount**](AWSApi.md#deleteawsaccount) | **DELETE** /api/2/aws-accounts/{id} | 
[**GetAWSAccount**](AWSApi.md#getawsaccount) | **GET** /api/2/aws-accounts/{id} | 
[**GetAWSAccountBuckets**](AWSApi.md#getawsaccountbuckets) | **GET** /api/2/aws-accounts/{id}/buckets | 
[**GetAWSAccountSNSTopics**](AWSApi.md#getawsaccountsnstopics) | **GET** /api/2/aws-accounts/{id}/sns/topics | 
[**GetAllAWSAccounts**](AWSApi.md#getallawsaccounts) | **GET** /api/2/aws-accounts | 
[**PatchAWSAccount**](AWSApi.md#patchawsaccount) | **PATCH** /api/2/aws-accounts/{id} | 
[**TestAWSAccountCredentials**](AWSApi.md#testawsaccountcredentials) | **POST** /api/2/aws-accounts/test-credentials | 
[**UpdateAWSAccount**](AWSApi.md#updateawsaccount) | **PUT** /api/2/aws-accounts/{id} | 


<a name="createawsaccount"></a>
# **CreateAWSAccount**
> AWSAccount CreateAWSAccount (AWSAccount aWSAccount)



### Required permissions    * User account permission: `tasks:manage` (read) / `system:admin-access` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateAWSAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AWSApi(config);
            var aWSAccount = new AWSAccount(); // AWSAccount | 

            try
            {
                AWSAccount result = apiInstance.CreateAWSAccount(aWSAccount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AWSApi.CreateAWSAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **aWSAccount** | [**AWSAccount**](AWSAccount.md)|  | 

### Return type

[**AWSAccount**](AWSAccount.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteawsaccount"></a>
# **DeleteAWSAccount**
> void DeleteAWSAccount (int id)



### Required permissions    * User account permission: `tasks:manage` (read) / `system:admin-access` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteAWSAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AWSApi(config);
            var id = 56;  // int | A unique integer value identifying this AWS Account.

            try
            {
                apiInstance.DeleteAWSAccount(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AWSApi.DeleteAWSAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this AWS Account. | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | No body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getawsaccount"></a>
# **GetAWSAccount**
> AWSAccount GetAWSAccount (int id)



### Required permissions    * User account permission: `tasks:manage` (read) / `system:admin-access` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAWSAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AWSApi(config);
            var id = 56;  // int | A unique integer value identifying this AWS Account.

            try
            {
                AWSAccount result = apiInstance.GetAWSAccount(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AWSApi.GetAWSAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this AWS Account. | 

### Return type

[**AWSAccount**](AWSAccount.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getawsaccountbuckets"></a>
# **GetAWSAccountBuckets**
> ListBuckets GetAWSAccountBuckets (int id)



### Required permissions    * User account permission: `tasks:manage` (read) / `system:admin-access` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAWSAccountBucketsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AWSApi(config);
            var id = 56;  // int | A unique integer value identifying this AWS Account.

            try
            {
                ListBuckets result = apiInstance.GetAWSAccountBuckets(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AWSApi.GetAWSAccountBuckets: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this AWS Account. | 

### Return type

[**ListBuckets**](ListBuckets.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getawsaccountsnstopics"></a>
# **GetAWSAccountSNSTopics**
> ListTopics GetAWSAccountSNSTopics (int id)



### Required permissions    * User account permission: `tasks:manage` (read) / `system:admin-access` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAWSAccountSNSTopicsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AWSApi(config);
            var id = 56;  // int | A unique integer value identifying this AWS Account.

            try
            {
                ListTopics result = apiInstance.GetAWSAccountSNSTopics(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AWSApi.GetAWSAccountSNSTopics: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this AWS Account. | 

### Return type

[**ListTopics**](ListTopics.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallawsaccounts"></a>
# **GetAllAWSAccounts**
> List&lt;AWSAccount&gt; GetAllAWSAccounts (string name = null, decimal? id = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `tasks:manage` (read) / `system:admin-access` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllAWSAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AWSApi(config);
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var id = 8.14;  // decimal? | Filter the returned list by `id`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<AWSAccount> result = apiInstance.GetAllAWSAccounts(name, id, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AWSApi.GetAllAWSAccounts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filter the returned list by &#x60;name&#x60;. | [optional] 
 **id** | **decimal?**| Filter the returned list by &#x60;id&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;AWSAccount&gt;**](AWSAccount.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchawsaccount"></a>
# **PatchAWSAccount**
> AWSAccount PatchAWSAccount (int id, AWSAccountPartialUpdate aWSAccountPartialUpdate)



### Required permissions    * User account permission: `tasks:manage` (read) / `system:admin-access` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchAWSAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AWSApi(config);
            var id = 56;  // int | A unique integer value identifying this AWS Account.
            var aWSAccountPartialUpdate = new AWSAccountPartialUpdate(); // AWSAccountPartialUpdate | 

            try
            {
                AWSAccount result = apiInstance.PatchAWSAccount(id, aWSAccountPartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AWSApi.PatchAWSAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this AWS Account. | 
 **aWSAccountPartialUpdate** | [**AWSAccountPartialUpdate**](AWSAccountPartialUpdate.md)|  | 

### Return type

[**AWSAccount**](AWSAccount.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testawsaccountcredentials"></a>
# **TestAWSAccountCredentials**
> TestAWSCredentialsResponse TestAWSAccountCredentials (TestAWSCredentialsRequest testAWSCredentialsRequest)



### Required permissions    * User account permission: `tasks:manage` (read) / `system:admin-access` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class TestAWSAccountCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AWSApi(config);
            var testAWSCredentialsRequest = new TestAWSCredentialsRequest(); // TestAWSCredentialsRequest | 

            try
            {
                TestAWSCredentialsResponse result = apiInstance.TestAWSAccountCredentials(testAWSCredentialsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AWSApi.TestAWSAccountCredentials: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **testAWSCredentialsRequest** | [**TestAWSCredentialsRequest**](TestAWSCredentialsRequest.md)|  | 

### Return type

[**TestAWSCredentialsResponse**](TestAWSCredentialsResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateawsaccount"></a>
# **UpdateAWSAccount**
> AWSAccount UpdateAWSAccount (int id, AWSAccount aWSAccount)



### Required permissions    * User account permission: `tasks:manage` (read) / `system:admin-access` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateAWSAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AWSApi(config);
            var id = 56;  // int | A unique integer value identifying this AWS Account.
            var aWSAccount = new AWSAccount(); // AWSAccount | 

            try
            {
                AWSAccount result = apiInstance.UpdateAWSAccount(id, aWSAccount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AWSApi.UpdateAWSAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this AWS Account. | 
 **aWSAccount** | [**AWSAccount**](AWSAccount.md)|  | 

### Return type

[**AWSAccount**](AWSAccount.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

