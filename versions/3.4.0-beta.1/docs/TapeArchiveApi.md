# ElementsSDK.Api.TapeArchiveApi

All URIs are relative to *https://elements.local*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ArchiveToTape**](TapeArchiveApi.md#archivetotape) | **POST** /api/2/archive/tape/archive | 
[**CancelAllTapeArchiveJobs**](TapeArchiveApi.md#cancelalltapearchivejobs) | **POST** /api/2/archive/tape/jobs/cancel-all | 
[**CheckTape**](TapeArchiveApi.md#checktape) | **POST** /api/2/archive/tape/library/check | 
[**CreateTape**](TapeArchiveApi.md#createtape) | **POST** /api/2/archive/tape/tapes | 
[**CreateTapeGroup**](TapeArchiveApi.md#createtapegroup) | **POST** /api/2/archive/tape/groups | 
[**DeleteTape**](TapeArchiveApi.md#deletetape) | **DELETE** /api/2/archive/tape/tapes/{id} | 
[**DeleteTapeArchiveJob**](TapeArchiveApi.md#deletetapearchivejob) | **DELETE** /api/2/archive/tape/jobs/{id} | 
[**DeleteTapeGroup**](TapeArchiveApi.md#deletetapegroup) | **DELETE** /api/2/archive/tape/groups/{id} | 
[**FormatTape**](TapeArchiveApi.md#formattape) | **POST** /api/2/archive/tape/library/format | 
[**GetAllArchivedFileEntries**](TapeArchiveApi.md#getallarchivedfileentries) | **GET** /api/2/archive/tape/files | 
[**GetAllTapeArchiveJobs**](TapeArchiveApi.md#getalltapearchivejobs) | **GET** /api/2/archive/tape/jobs | 
[**GetAllTapeGroups**](TapeArchiveApi.md#getalltapegroups) | **GET** /api/2/archive/tape/groups | 
[**GetAllTapes**](TapeArchiveApi.md#getalltapes) | **GET** /api/2/archive/tape/tapes | 
[**GetArchivedFileEntry**](TapeArchiveApi.md#getarchivedfileentry) | **GET** /api/2/archive/tape/files/{id} | 
[**GetTape**](TapeArchiveApi.md#gettape) | **GET** /api/2/archive/tape/tapes/{id} | 
[**GetTapeArchiveJob**](TapeArchiveApi.md#gettapearchivejob) | **GET** /api/2/archive/tape/jobs/{id} | 
[**GetTapeArchiveJobSources**](TapeArchiveApi.md#gettapearchivejobsources) | **GET** /api/2/archive/tape/jobs/{id}/sources | 
[**GetTapeGroup**](TapeArchiveApi.md#gettapegroup) | **GET** /api/2/archive/tape/groups/{id} | 
[**GetTapeLibraryState**](TapeArchiveApi.md#gettapelibrarystate) | **GET** /api/2/archive/tape/library | 
[**LoadTape**](TapeArchiveApi.md#loadtape) | **POST** /api/2/archive/tape/library/load | 
[**MoveTape**](TapeArchiveApi.md#movetape) | **POST** /api/2/archive/tape/library/move | 
[**PatchTape**](TapeArchiveApi.md#patchtape) | **PATCH** /api/2/archive/tape/tapes/{id} | 
[**PatchTapeGroup**](TapeArchiveApi.md#patchtapegroup) | **PATCH** /api/2/archive/tape/groups/{id} | 
[**PauseTapeArchiveJob**](TapeArchiveApi.md#pausetapearchivejob) | **POST** /api/2/archive/tape/jobs/{id}/pause | 
[**RefreshTapeLibraryState**](TapeArchiveApi.md#refreshtapelibrarystate) | **POST** /api/2/archive/tape/library/refresh | 
[**ReindexTape**](TapeArchiveApi.md#reindextape) | **POST** /api/2/archive/tape/library/reindex | 
[**RemoveFinishedTapeArchiveJobs**](TapeArchiveApi.md#removefinishedtapearchivejobs) | **POST** /api/2/archive/tape/jobs/remove-finished | 
[**RestartTapeArchiveJob**](TapeArchiveApi.md#restarttapearchivejob) | **POST** /api/2/archive/tape/jobs/{id}/restart | 
[**RestoreFromTape**](TapeArchiveApi.md#restorefromtape) | **POST** /api/2/archive/tape/restore | 
[**ResumeTapeArchiveJob**](TapeArchiveApi.md#resumetapearchivejob) | **POST** /api/2/archive/tape/jobs/{id}/resume | 
[**SearchTapeArchive**](TapeArchiveApi.md#searchtapearchive) | **POST** /api/2/archive/tape/search | 
[**UnloadTape**](TapeArchiveApi.md#unloadtape) | **POST** /api/2/archive/tape/library/unload | 
[**UpdateTape**](TapeArchiveApi.md#updatetape) | **PUT** /api/2/archive/tape/tapes/{id} | 
[**UpdateTapeGroup**](TapeArchiveApi.md#updatetapegroup) | **PUT** /api/2/archive/tape/groups/{id} | 


<a name="archivetotape"></a>
# **ArchiveToTape**
> List&lt;TapeJob&gt; ArchiveToTape (ArchiveEndpointRequest archiveEndpointRequest)



### Required permissions    * User account permission: `ltfs:backup`   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class ArchiveToTapeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var archiveEndpointRequest = new ArchiveEndpointRequest(); // ArchiveEndpointRequest | 

            try
            {
                List<TapeJob> result = apiInstance.ArchiveToTape(archiveEndpointRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.ArchiveToTape: " + e.Message );
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
 **archiveEndpointRequest** | [**ArchiveEndpointRequest**](ArchiveEndpointRequest.md)|  | 

### Return type

[**List&lt;TapeJob&gt;**](TapeJob.md)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="cancelalltapearchivejobs"></a>
# **CancelAllTapeArchiveJobs**
> void CancelAllTapeArchiveJobs ()



### Required permissions    * User account permission: `None` (read) / `ltfs:manage` (write)   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CancelAllTapeArchiveJobsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);

            try
            {
                apiInstance.CancelAllTapeArchiveJobs();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.CancelAllTapeArchiveJobs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | No body |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="checktape"></a>
# **CheckTape**
> void CheckTape (TapeLibraryFsckEndpointRequest tapeLibraryFsckEndpointRequest)



### Required permissions    * User account permission: `ltfs:manage`   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CheckTapeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var tapeLibraryFsckEndpointRequest = new TapeLibraryFsckEndpointRequest(); // TapeLibraryFsckEndpointRequest | 

            try
            {
                apiInstance.CheckTape(tapeLibraryFsckEndpointRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.CheckTape: " + e.Message );
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
 **tapeLibraryFsckEndpointRequest** | [**TapeLibraryFsckEndpointRequest**](TapeLibraryFsckEndpointRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | No body |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="createtape"></a>
# **CreateTape**
> Tape CreateTape (Tape tape)



### Required permissions    * User account permission: `None` (read) / `ltfs:tapegroups:manage` (write)   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateTapeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var tape = new Tape(); // Tape | 

            try
            {
                Tape result = apiInstance.CreateTape(tape);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.CreateTape: " + e.Message );
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
 **tape** | [**Tape**](Tape.md)|  | 

### Return type

[**Tape**](Tape.md)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="createtapegroup"></a>
# **CreateTapeGroup**
> TapeGroup CreateTapeGroup (TapeGroup tapeGroup)



### Required permissions    * User account permission: `None` (read) / `ltfs:tapegroups:manage` (write)   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateTapeGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var tapeGroup = new TapeGroup(); // TapeGroup | 

            try
            {
                TapeGroup result = apiInstance.CreateTapeGroup(tapeGroup);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.CreateTapeGroup: " + e.Message );
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
 **tapeGroup** | [**TapeGroup**](TapeGroup.md)|  | 

### Return type

[**TapeGroup**](TapeGroup.md)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="deletetape"></a>
# **DeleteTape**
> void DeleteTape (int id)



### Required permissions    * User account permission: `None` (read) / `ltfs:tapegroups:manage` (write)   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteTapeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var id = 56;  // int | A unique integer value identifying this tape.

            try
            {
                apiInstance.DeleteTape(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.DeleteTape: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this tape. | 

### Return type

void (empty response body)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | No body |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="deletetapearchivejob"></a>
# **DeleteTapeArchiveJob**
> void DeleteTapeArchiveJob (string id)



### Required permissions    * User account permission: `None` (read) / `ltfs:manage` (write)   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteTapeArchiveJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var id = id_example;  // string | 

            try
            {
                apiInstance.DeleteTapeArchiveJob(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.DeleteTapeArchiveJob: " + e.Message );
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
 **id** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | No body |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="deletetapegroup"></a>
# **DeleteTapeGroup**
> void DeleteTapeGroup (int id)



### Required permissions    * User account permission: `None` (read) / `ltfs:tapegroups:manage` (write)   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteTapeGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var id = 56;  // int | A unique integer value identifying this tape group.

            try
            {
                apiInstance.DeleteTapeGroup(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.DeleteTapeGroup: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this tape group. | 

### Return type

void (empty response body)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | No body |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="formattape"></a>
# **FormatTape**
> void FormatTape (TapeLibraryFormatEndpointRequest tapeLibraryFormatEndpointRequest)



### Required permissions    * User account permission: `ltfs:manage`   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class FormatTapeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var tapeLibraryFormatEndpointRequest = new TapeLibraryFormatEndpointRequest(); // TapeLibraryFormatEndpointRequest | 

            try
            {
                apiInstance.FormatTape(tapeLibraryFormatEndpointRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.FormatTape: " + e.Message );
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
 **tapeLibraryFormatEndpointRequest** | [**TapeLibraryFormatEndpointRequest**](TapeLibraryFormatEndpointRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | No body |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="getallarchivedfileentries"></a>
# **GetAllArchivedFileEntries**
> List&lt;TapeFile&gt; GetAllArchivedFileEntries (decimal? id = null, string isDir = null, string name = null, string fullpath = null, string parent = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `ltfs:search` (read) / `ltfs:manage` (write)   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllArchivedFileEntriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var id = 8.14;  // decimal? | Filter the returned list by `id`. (optional) 
            var isDir = isDir_example;  // string | Filter the returned list by `is_dir`. (optional) 
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var fullpath = fullpath_example;  // string | Filter the returned list by `fullpath`. (optional) 
            var parent = parent_example;  // string | Filter the returned list by `parent`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<TapeFile> result = apiInstance.GetAllArchivedFileEntries(id, isDir, name, fullpath, parent, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.GetAllArchivedFileEntries: " + e.Message );
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
 **id** | **decimal?**| Filter the returned list by &#x60;id&#x60;. | [optional] 
 **isDir** | **string**| Filter the returned list by &#x60;is_dir&#x60;. | [optional] 
 **name** | **string**| Filter the returned list by &#x60;name&#x60;. | [optional] 
 **fullpath** | **string**| Filter the returned list by &#x60;fullpath&#x60;. | [optional] 
 **parent** | **string**| Filter the returned list by &#x60;parent&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;TapeFile&gt;**](TapeFile.md)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="getalltapearchivejobs"></a>
# **GetAllTapeArchiveJobs**
> List&lt;TapeJob&gt; GetAllTapeArchiveJobs (string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `None` (read) / `ltfs:manage` (write)   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllTapeArchiveJobsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<TapeJob> result = apiInstance.GetAllTapeArchiveJobs(ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.GetAllTapeArchiveJobs: " + e.Message );
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
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;TapeJob&gt;**](TapeJob.md)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="getalltapegroups"></a>
# **GetAllTapeGroups**
> List&lt;TapeGroup&gt; GetAllTapeGroups (decimal? id = null, string name = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `None` (read) / `ltfs:tapegroups:manage` (write)   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllTapeGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var id = 8.14;  // decimal? | Filter the returned list by `id`. (optional) 
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<TapeGroup> result = apiInstance.GetAllTapeGroups(id, name, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.GetAllTapeGroups: " + e.Message );
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
 **id** | **decimal?**| Filter the returned list by &#x60;id&#x60;. | [optional] 
 **name** | **string**| Filter the returned list by &#x60;name&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;TapeGroup&gt;**](TapeGroup.md)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="getalltapes"></a>
# **GetAllTapes**
> List&lt;Tape&gt; GetAllTapes (decimal? id = null, string name = null, string group = null, string groupIsnull = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `None` (read) / `ltfs:tapegroups:manage` (write)   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllTapesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var id = 8.14;  // decimal? | Filter the returned list by `id`. (optional) 
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var group = group_example;  // string | Filter the returned list by `group`. (optional) 
            var groupIsnull = groupIsnull_example;  // string | Filter the returned list by `group__isnull`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<Tape> result = apiInstance.GetAllTapes(id, name, group, groupIsnull, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.GetAllTapes: " + e.Message );
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
 **id** | **decimal?**| Filter the returned list by &#x60;id&#x60;. | [optional] 
 **name** | **string**| Filter the returned list by &#x60;name&#x60;. | [optional] 
 **group** | **string**| Filter the returned list by &#x60;group&#x60;. | [optional] 
 **groupIsnull** | **string**| Filter the returned list by &#x60;group__isnull&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;Tape&gt;**](Tape.md)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="getarchivedfileentry"></a>
# **GetArchivedFileEntry**
> TapeFile GetArchivedFileEntry (int id)



### Required permissions    * User account permission: `ltfs:search` (read) / `ltfs:manage` (write)   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetArchivedFileEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var id = 56;  // int | A unique integer value identifying this Archived file entry.

            try
            {
                TapeFile result = apiInstance.GetArchivedFileEntry(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.GetArchivedFileEntry: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Archived file entry. | 

### Return type

[**TapeFile**](TapeFile.md)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="gettape"></a>
# **GetTape**
> Tape GetTape (int id)



### Required permissions    * User account permission: `None` (read) / `ltfs:tapegroups:manage` (write)   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetTapeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var id = 56;  // int | A unique integer value identifying this tape.

            try
            {
                Tape result = apiInstance.GetTape(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.GetTape: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this tape. | 

### Return type

[**Tape**](Tape.md)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="gettapearchivejob"></a>
# **GetTapeArchiveJob**
> TapeJob GetTapeArchiveJob (string id)



### Required permissions    * User account permission: `None` (read) / `ltfs:manage` (write)   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetTapeArchiveJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var id = id_example;  // string | 

            try
            {
                TapeJob result = apiInstance.GetTapeArchiveJob(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.GetTapeArchiveJob: " + e.Message );
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
 **id** | **string**|  | 

### Return type

[**TapeJob**](TapeJob.md)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="gettapearchivejobsources"></a>
# **GetTapeArchiveJobSources**
> List&lt;TapeJobSource&gt; GetTapeArchiveJobSources (string id)



### Required permissions    * User account permission: `None` (read) / `ltfs:manage` (write)   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetTapeArchiveJobSourcesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var id = id_example;  // string | 

            try
            {
                List<TapeJobSource> result = apiInstance.GetTapeArchiveJobSources(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.GetTapeArchiveJobSources: " + e.Message );
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
 **id** | **string**|  | 

### Return type

[**List&lt;TapeJobSource&gt;**](TapeJobSource.md)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="gettapegroup"></a>
# **GetTapeGroup**
> TapeGroup GetTapeGroup (int id)



### Required permissions    * User account permission: `None` (read) / `ltfs:tapegroups:manage` (write)   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetTapeGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var id = 56;  // int | A unique integer value identifying this tape group.

            try
            {
                TapeGroup result = apiInstance.GetTapeGroup(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.GetTapeGroup: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this tape group. | 

### Return type

[**TapeGroup**](TapeGroup.md)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="gettapelibrarystate"></a>
# **GetTapeLibraryState**
> TapeLibraryEndpointResponse GetTapeLibraryState ()



### Required permissions    * User account permission: `ltfs:manage`   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetTapeLibraryStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);

            try
            {
                TapeLibraryEndpointResponse result = apiInstance.GetTapeLibraryState();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.GetTapeLibraryState: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TapeLibraryEndpointResponse**](TapeLibraryEndpointResponse.md)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="loadtape"></a>
# **LoadTape**
> void LoadTape (TapeLibraryLoadEndpointRequest tapeLibraryLoadEndpointRequest)



### Required permissions    * User account permission: `ltfs:manage`   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class LoadTapeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var tapeLibraryLoadEndpointRequest = new TapeLibraryLoadEndpointRequest(); // TapeLibraryLoadEndpointRequest | 

            try
            {
                apiInstance.LoadTape(tapeLibraryLoadEndpointRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.LoadTape: " + e.Message );
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
 **tapeLibraryLoadEndpointRequest** | [**TapeLibraryLoadEndpointRequest**](TapeLibraryLoadEndpointRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | No body |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="movetape"></a>
# **MoveTape**
> void MoveTape (TapeLibraryMoveEndpointRequest tapeLibraryMoveEndpointRequest)



### Required permissions    * User account permission: `ltfs:manage`   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class MoveTapeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var tapeLibraryMoveEndpointRequest = new TapeLibraryMoveEndpointRequest(); // TapeLibraryMoveEndpointRequest | 

            try
            {
                apiInstance.MoveTape(tapeLibraryMoveEndpointRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.MoveTape: " + e.Message );
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
 **tapeLibraryMoveEndpointRequest** | [**TapeLibraryMoveEndpointRequest**](TapeLibraryMoveEndpointRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | No body |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="patchtape"></a>
# **PatchTape**
> Tape PatchTape (int id, TapePartialUpdate tapePartialUpdate)



### Required permissions    * User account permission: `None` (read) / `ltfs:tapegroups:manage` (write)   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchTapeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var id = 56;  // int | A unique integer value identifying this tape.
            var tapePartialUpdate = new TapePartialUpdate(); // TapePartialUpdate | 

            try
            {
                Tape result = apiInstance.PatchTape(id, tapePartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.PatchTape: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this tape. | 
 **tapePartialUpdate** | [**TapePartialUpdate**](TapePartialUpdate.md)|  | 

### Return type

[**Tape**](Tape.md)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="patchtapegroup"></a>
# **PatchTapeGroup**
> TapeGroup PatchTapeGroup (int id, TapeGroupPartialUpdate tapeGroupPartialUpdate)



### Required permissions    * User account permission: `None` (read) / `ltfs:tapegroups:manage` (write)   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchTapeGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var id = 56;  // int | A unique integer value identifying this tape group.
            var tapeGroupPartialUpdate = new TapeGroupPartialUpdate(); // TapeGroupPartialUpdate | 

            try
            {
                TapeGroup result = apiInstance.PatchTapeGroup(id, tapeGroupPartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.PatchTapeGroup: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this tape group. | 
 **tapeGroupPartialUpdate** | [**TapeGroupPartialUpdate**](TapeGroupPartialUpdate.md)|  | 

### Return type

[**TapeGroup**](TapeGroup.md)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="pausetapearchivejob"></a>
# **PauseTapeArchiveJob**
> void PauseTapeArchiveJob (string id)



### Required permissions    * User account permission: `None` (read) / `ltfs:manage` (write)   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PauseTapeArchiveJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var id = id_example;  // string | 

            try
            {
                apiInstance.PauseTapeArchiveJob(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.PauseTapeArchiveJob: " + e.Message );
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
 **id** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | No body |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="refreshtapelibrarystate"></a>
# **RefreshTapeLibraryState**
> void RefreshTapeLibraryState ()



### Required permissions    * User account permission: `ltfs:manage`   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class RefreshTapeLibraryStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);

            try
            {
                apiInstance.RefreshTapeLibraryState();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.RefreshTapeLibraryState: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | No body |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="reindextape"></a>
# **ReindexTape**
> void ReindexTape (TapeLibraryReindexEndpointRequest tapeLibraryReindexEndpointRequest)



### Required permissions    * User account permission: `ltfs:manage`   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class ReindexTapeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var tapeLibraryReindexEndpointRequest = new TapeLibraryReindexEndpointRequest(); // TapeLibraryReindexEndpointRequest | 

            try
            {
                apiInstance.ReindexTape(tapeLibraryReindexEndpointRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.ReindexTape: " + e.Message );
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
 **tapeLibraryReindexEndpointRequest** | [**TapeLibraryReindexEndpointRequest**](TapeLibraryReindexEndpointRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | No body |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="removefinishedtapearchivejobs"></a>
# **RemoveFinishedTapeArchiveJobs**
> void RemoveFinishedTapeArchiveJobs ()



### Required permissions    * User account permission: `None` (read) / `ltfs:manage` (write)   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class RemoveFinishedTapeArchiveJobsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);

            try
            {
                apiInstance.RemoveFinishedTapeArchiveJobs();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.RemoveFinishedTapeArchiveJobs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | No body |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="restarttapearchivejob"></a>
# **RestartTapeArchiveJob**
> void RestartTapeArchiveJob (string id)



### Required permissions    * User account permission: `None` (read) / `ltfs:manage` (write)   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class RestartTapeArchiveJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var id = id_example;  // string | 

            try
            {
                apiInstance.RestartTapeArchiveJob(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.RestartTapeArchiveJob: " + e.Message );
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
 **id** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | No body |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="restorefromtape"></a>
# **RestoreFromTape**
> TapeJob RestoreFromTape (RestoreEndpointRequest restoreEndpointRequest)



### Required permissions    * User account permission: `ltfs:restore`   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class RestoreFromTapeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var restoreEndpointRequest = new RestoreEndpointRequest(); // RestoreEndpointRequest | 

            try
            {
                TapeJob result = apiInstance.RestoreFromTape(restoreEndpointRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.RestoreFromTape: " + e.Message );
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
 **restoreEndpointRequest** | [**RestoreEndpointRequest**](RestoreEndpointRequest.md)|  | 

### Return type

[**TapeJob**](TapeJob.md)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="resumetapearchivejob"></a>
# **ResumeTapeArchiveJob**
> void ResumeTapeArchiveJob (string id)



### Required permissions    * User account permission: `None` (read) / `ltfs:manage` (write)   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class ResumeTapeArchiveJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var id = id_example;  // string | 

            try
            {
                apiInstance.ResumeTapeArchiveJob(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.ResumeTapeArchiveJob: " + e.Message );
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
 **id** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | No body |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="searchtapearchive"></a>
# **SearchTapeArchive**
> SearchEndpointResponse SearchTapeArchive (SearchEndpointRequest searchEndpointRequest)



### Required permissions    * User account permission: `ltfs:search`   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class SearchTapeArchiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var searchEndpointRequest = new SearchEndpointRequest(); // SearchEndpointRequest | 

            try
            {
                SearchEndpointResponse result = apiInstance.SearchTapeArchive(searchEndpointRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.SearchTapeArchive: " + e.Message );
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
 **searchEndpointRequest** | [**SearchEndpointRequest**](SearchEndpointRequest.md)|  | 

### Return type

[**SearchEndpointResponse**](SearchEndpointResponse.md)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="unloadtape"></a>
# **UnloadTape**
> void UnloadTape (TapeLibraryUnloadEndpointRequest tapeLibraryUnloadEndpointRequest)



### Required permissions    * User account permission: `ltfs:manage`   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UnloadTapeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var tapeLibraryUnloadEndpointRequest = new TapeLibraryUnloadEndpointRequest(); // TapeLibraryUnloadEndpointRequest | 

            try
            {
                apiInstance.UnloadTape(tapeLibraryUnloadEndpointRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.UnloadTape: " + e.Message );
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
 **tapeLibraryUnloadEndpointRequest** | [**TapeLibraryUnloadEndpointRequest**](TapeLibraryUnloadEndpointRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | No body |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="updatetape"></a>
# **UpdateTape**
> Tape UpdateTape (int id, Tape tape)



### Required permissions    * User account permission: `None` (read) / `ltfs:tapegroups:manage` (write)   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateTapeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var id = 56;  // int | A unique integer value identifying this tape.
            var tape = new Tape(); // Tape | 

            try
            {
                Tape result = apiInstance.UpdateTape(id, tape);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.UpdateTape: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this tape. | 
 **tape** | [**Tape**](Tape.md)|  | 

### Return type

[**Tape**](Tape.md)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="updatetapegroup"></a>
# **UpdateTapeGroup**
> TapeGroup UpdateTapeGroup (int id, TapeGroup tapeGroup)



### Required permissions    * User account permission: `None` (read) / `ltfs:tapegroups:manage` (write)   * License component: ltfs 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateTapeGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TapeArchiveApi(config);
            var id = 56;  // int | A unique integer value identifying this tape group.
            var tapeGroup = new TapeGroup(); // TapeGroup | 

            try
            {
                TapeGroup result = apiInstance.UpdateTapeGroup(id, tapeGroup);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeArchiveApi.UpdateTapeGroup: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this tape group. | 
 **tapeGroup** | [**TapeGroup**](TapeGroup.md)|  | 

### Return type

[**TapeGroup**](TapeGroup.md)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

