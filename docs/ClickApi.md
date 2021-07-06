# ElementsSDK.Api.ClickApi

All URIs are relative to *https://elements.local*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AbortClickUpload**](ClickApi.md#abortclickupload) | **DELETE** /api/2/click/uploads/{upload_id} | 
[**ContinueClickUploadInBackground**](ClickApi.md#continueclickuploadinbackground) | **POST** /api/2/click/uploads/{upload_id}/background | 
[**CreateClickGallery**](ClickApi.md#createclickgallery) | **POST** /api/2/click/connections/{connection_id}/galleries | 
[**CreateClickGalleryLink**](ClickApi.md#createclickgallerylink) | **POST** /api/2/click/connections/{connection_id}/gallery-links | 
[**DeleteClickGalleryLink**](ClickApi.md#deleteclickgallerylink) | **DELETE** /api/2/click/connections/{connection_id}/gallery-links/{id} | 
[**GetAllClickGalleries**](ClickApi.md#getallclickgalleries) | **GET** /api/2/click/connections/{connection_id}/galleries | 
[**GetAllClickGalleryLinks**](ClickApi.md#getallclickgallerylinks) | **GET** /api/2/click/connections/{connection_id}/gallery-links | 
[**GetClickGallery**](ClickApi.md#getclickgallery) | **GET** /api/2/click/connections/{connection_id}/galleries/{id} | 
[**GetClickGalleryLink**](ClickApi.md#getclickgallerylink) | **GET** /api/2/click/connections/{connection_id}/gallery-links/{id} | 
[**PatchClickGallery**](ClickApi.md#patchclickgallery) | **PATCH** /api/2/click/connections/{connection_id}/galleries/{id} | 
[**SendClickGalleryLinkEmail**](ClickApi.md#sendclickgallerylinkemail) | **POST** /api/2/click/connections/{connection_id}/gallery-links/{link_id}/send | 
[**StartClickUpload**](ClickApi.md#startclickupload) | **POST** /api/2/click/uploads | 
[**UpdateClickGallery**](ClickApi.md#updateclickgallery) | **PUT** /api/2/click/connections/{connection_id}/galleries/{id} | 


<a name="abortclickupload"></a>
# **AbortClickUpload**
> void AbortClickUpload (string uploadId)



### Required permissions    * User account permission: `cloud:access` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class AbortClickUploadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClickApi(config);
            var uploadId = uploadId_example;  // string | 

            try
            {
                apiInstance.AbortClickUpload(uploadId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClickApi.AbortClickUpload: " + e.Message );
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
 **uploadId** | **string**|  | 

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

<a name="continueclickuploadinbackground"></a>
# **ContinueClickUploadInBackground**
> void ContinueClickUploadInBackground (string uploadId, ClickBackgroundUploadEndpointRequest clickBackgroundUploadEndpointRequest)



### Required permissions    * User account permission: `cloud:access` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class ContinueClickUploadInBackgroundExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClickApi(config);
            var uploadId = uploadId_example;  // string | 
            var clickBackgroundUploadEndpointRequest = new ClickBackgroundUploadEndpointRequest(); // ClickBackgroundUploadEndpointRequest | 

            try
            {
                apiInstance.ContinueClickUploadInBackground(uploadId, clickBackgroundUploadEndpointRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClickApi.ContinueClickUploadInBackground: " + e.Message );
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
 **uploadId** | **string**|  | 
 **clickBackgroundUploadEndpointRequest** | [**ClickBackgroundUploadEndpointRequest**](ClickBackgroundUploadEndpointRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | No body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createclickgallery"></a>
# **CreateClickGallery**
> ClickGallery CreateClickGallery (string connectionId, ClickGallery clickGallery)



### Required permissions    * User account permission: `cloud:access` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateClickGalleryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClickApi(config);
            var connectionId = connectionId_example;  // string | 
            var clickGallery = new ClickGallery(); // ClickGallery | 

            try
            {
                ClickGallery result = apiInstance.CreateClickGallery(connectionId, clickGallery);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClickApi.CreateClickGallery: " + e.Message );
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
 **connectionId** | **string**|  | 
 **clickGallery** | [**ClickGallery**](ClickGallery.md)|  | 

### Return type

[**ClickGallery**](ClickGallery.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createclickgallerylink"></a>
# **CreateClickGalleryLink**
> ClickGalleryLink CreateClickGalleryLink (string connectionId, ClickGalleryLink clickGalleryLink)



### Required permissions    * User account permission: `cloud:access` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateClickGalleryLinkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClickApi(config);
            var connectionId = connectionId_example;  // string | 
            var clickGalleryLink = new ClickGalleryLink(); // ClickGalleryLink | 

            try
            {
                ClickGalleryLink result = apiInstance.CreateClickGalleryLink(connectionId, clickGalleryLink);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClickApi.CreateClickGalleryLink: " + e.Message );
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
 **connectionId** | **string**|  | 
 **clickGalleryLink** | [**ClickGalleryLink**](ClickGalleryLink.md)|  | 

### Return type

[**ClickGalleryLink**](ClickGalleryLink.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteclickgallerylink"></a>
# **DeleteClickGalleryLink**
> void DeleteClickGalleryLink (string connectionId, string id)



### Required permissions    * User account permission: `cloud:access` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteClickGalleryLinkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClickApi(config);
            var connectionId = connectionId_example;  // string | 
            var id = id_example;  // string | 

            try
            {
                apiInstance.DeleteClickGalleryLink(connectionId, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClickApi.DeleteClickGalleryLink: " + e.Message );
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
 **connectionId** | **string**|  | 
 **id** | **string**|  | 

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
| **204** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallclickgalleries"></a>
# **GetAllClickGalleries**
> InlineResponse200 GetAllClickGalleries (string connectionId, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `cloud:access` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllClickGalleriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClickApi(config);
            var connectionId = connectionId_example;  // string | 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                InlineResponse200 result = apiInstance.GetAllClickGalleries(connectionId, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClickApi.GetAllClickGalleries: " + e.Message );
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
 **connectionId** | **string**|  | 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

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

<a name="getallclickgallerylinks"></a>
# **GetAllClickGalleryLinks**
> InlineResponse2001 GetAllClickGalleryLinks (string connectionId, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `cloud:access` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllClickGalleryLinksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClickApi(config);
            var connectionId = connectionId_example;  // string | 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                InlineResponse2001 result = apiInstance.GetAllClickGalleryLinks(connectionId, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClickApi.GetAllClickGalleryLinks: " + e.Message );
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
 **connectionId** | **string**|  | 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

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

<a name="getclickgallery"></a>
# **GetClickGallery**
> ClickGallery GetClickGallery (string connectionId, string id)



### Required permissions    * User account permission: `cloud:access` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetClickGalleryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClickApi(config);
            var connectionId = connectionId_example;  // string | 
            var id = id_example;  // string | 

            try
            {
                ClickGallery result = apiInstance.GetClickGallery(connectionId, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClickApi.GetClickGallery: " + e.Message );
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
 **connectionId** | **string**|  | 
 **id** | **string**|  | 

### Return type

[**ClickGallery**](ClickGallery.md)

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

<a name="getclickgallerylink"></a>
# **GetClickGalleryLink**
> ClickGalleryLink GetClickGalleryLink (string connectionId, string id)



### Required permissions    * User account permission: `cloud:access` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetClickGalleryLinkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClickApi(config);
            var connectionId = connectionId_example;  // string | 
            var id = id_example;  // string | 

            try
            {
                ClickGalleryLink result = apiInstance.GetClickGalleryLink(connectionId, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClickApi.GetClickGalleryLink: " + e.Message );
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
 **connectionId** | **string**|  | 
 **id** | **string**|  | 

### Return type

[**ClickGalleryLink**](ClickGalleryLink.md)

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

<a name="patchclickgallery"></a>
# **PatchClickGallery**
> ClickGallery PatchClickGallery (string connectionId, string id, ClickGallery clickGallery)



### Required permissions    * User account permission: `cloud:access` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchClickGalleryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClickApi(config);
            var connectionId = connectionId_example;  // string | 
            var id = id_example;  // string | 
            var clickGallery = new ClickGallery(); // ClickGallery | 

            try
            {
                ClickGallery result = apiInstance.PatchClickGallery(connectionId, id, clickGallery);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClickApi.PatchClickGallery: " + e.Message );
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
 **connectionId** | **string**|  | 
 **id** | **string**|  | 
 **clickGallery** | [**ClickGallery**](ClickGallery.md)|  | 

### Return type

[**ClickGallery**](ClickGallery.md)

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

<a name="sendclickgallerylinkemail"></a>
# **SendClickGalleryLinkEmail**
> void SendClickGalleryLinkEmail (string connectionId, string linkId)



### Required permissions    * User account permission: `cloud:access` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class SendClickGalleryLinkEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClickApi(config);
            var connectionId = connectionId_example;  // string | 
            var linkId = linkId_example;  // string | 

            try
            {
                apiInstance.SendClickGalleryLinkEmail(connectionId, linkId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClickApi.SendClickGalleryLinkEmail: " + e.Message );
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
 **connectionId** | **string**|  | 
 **linkId** | **string**|  | 

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

<a name="startclickupload"></a>
# **StartClickUpload**
> TaskInfo StartClickUpload (ClickStartUploadEndpointRequest clickStartUploadEndpointRequest)



### Required permissions    * User account permission: `cloud:access` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class StartClickUploadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClickApi(config);
            var clickStartUploadEndpointRequest = new ClickStartUploadEndpointRequest(); // ClickStartUploadEndpointRequest | 

            try
            {
                TaskInfo result = apiInstance.StartClickUpload(clickStartUploadEndpointRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClickApi.StartClickUpload: " + e.Message );
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
 **clickStartUploadEndpointRequest** | [**ClickStartUploadEndpointRequest**](ClickStartUploadEndpointRequest.md)|  | 

### Return type

[**TaskInfo**](TaskInfo.md)

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

<a name="updateclickgallery"></a>
# **UpdateClickGallery**
> AddAssetsToClickGallery UpdateClickGallery (string connectionId, string id, AddAssetsToClickGallery addAssetsToClickGallery)



### Required permissions    * User account permission: `cloud:access` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateClickGalleryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClickApi(config);
            var connectionId = connectionId_example;  // string | 
            var id = id_example;  // string | 
            var addAssetsToClickGallery = new AddAssetsToClickGallery(); // AddAssetsToClickGallery | 

            try
            {
                AddAssetsToClickGallery result = apiInstance.UpdateClickGallery(connectionId, id, addAssetsToClickGallery);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClickApi.UpdateClickGallery: " + e.Message );
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
 **connectionId** | **string**|  | 
 **id** | **string**|  | 
 **addAssetsToClickGallery** | [**AddAssetsToClickGallery**](AddAssetsToClickGallery.md)|  | 

### Return type

[**AddAssetsToClickGallery**](AddAssetsToClickGallery.md)

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

