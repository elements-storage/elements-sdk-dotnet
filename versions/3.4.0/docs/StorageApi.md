# ElementsSDK.Api.StorageApi

All URIs are relative to *https://elements.local*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplyWorkspaceAffinity**](StorageApi.md#applyworkspaceaffinity) | **POST** /api/2/workspaces/{id}/apply-affinity | 
[**BookmarkWorkspace**](StorageApi.md#bookmarkworkspace) | **POST** /api/2/workspaces/{id}/bookmark | 
[**CalculateDirectorySize**](StorageApi.md#calculatedirectorysize) | **POST** /api/2/filesystem/calculate-directory-size | 
[**CheckInIntoWorkspace**](StorageApi.md#checkinintoworkspace) | **POST** /api/2/workspaces/{id}/check-in | 
[**CheckOutOfWorkspace**](StorageApi.md#checkoutofworkspace) | **POST** /api/2/workspaces/{id}/check-out | 
[**CopyFiles**](StorageApi.md#copyfiles) | **POST** /api/2/filesystem/copy | 
[**CreateFile**](StorageApi.md#createfile) | **POST** /api/2/files | 
[**CreatePathQuota**](StorageApi.md#createpathquota) | **POST** /api/2/volumes/{id}/quotas/path/{relative_path} | 
[**CreateProduction**](StorageApi.md#createproduction) | **POST** /api/2/productions | 
[**CreateShare**](StorageApi.md#createshare) | **POST** /api/2/shares | 
[**CreateSnapshot**](StorageApi.md#createsnapshot) | **POST** /api/2/snapshots | 
[**CreateTemplateFolder**](StorageApi.md#createtemplatefolder) | **POST** /api/2/private/create-template-folder | 
[**CreateWorkspace**](StorageApi.md#createworkspace) | **POST** /api/2/workspaces | 
[**CreateWorkspacePermission**](StorageApi.md#createworkspacepermission) | **POST** /api/2/workspace-permissions | 
[**DeleteFile**](StorageApi.md#deletefile) | **DELETE** /api/2/files/{path} | 
[**DeleteFiles**](StorageApi.md#deletefiles) | **POST** /api/2/filesystem/delete | 
[**DeletePathQuota**](StorageApi.md#deletepathquota) | **DELETE** /api/2/volumes/{id}/quotas/path/{relative_path} | 
[**DeleteProduction**](StorageApi.md#deleteproduction) | **DELETE** /api/2/productions/{id} | 
[**DeleteShare**](StorageApi.md#deleteshare) | **DELETE** /api/2/shares/{id} | 
[**DeleteSnapshot**](StorageApi.md#deletesnapshot) | **DELETE** /api/2/snapshots/{id} | 
[**DeleteWorkspace**](StorageApi.md#deleteworkspace) | **DELETE** /api/2/workspaces/{id} | 
[**DeleteWorkspacePermission**](StorageApi.md#deleteworkspacepermission) | **DELETE** /api/2/workspace-permissions/{id} | 
[**GetAllDeletedWorkspaces**](StorageApi.md#getalldeletedworkspaces) | **GET** /api/2/workspaces/deleted | 
[**GetAllProductions**](StorageApi.md#getallproductions) | **GET** /api/2/productions | 
[**GetAllShares**](StorageApi.md#getallshares) | **GET** /api/2/shares | 
[**GetAllSnapshots**](StorageApi.md#getallsnapshots) | **GET** /api/2/snapshots | 
[**GetAllVolumes**](StorageApi.md#getallvolumes) | **GET** /api/2/volumes | 
[**GetAllWorkspacePermissions**](StorageApi.md#getallworkspacepermissions) | **GET** /api/2/workspace-permissions | 
[**GetAllWorkspaces**](StorageApi.md#getallworkspaces) | **GET** /api/2/workspaces | 
[**GetFile**](StorageApi.md#getfile) | **GET** /api/2/files/{path} | 
[**GetGroupQuota**](StorageApi.md#getgroupquota) | **GET** /api/2/volumes/{id}/quotas/group/{group_id} | 
[**GetMyWorkspaces**](StorageApi.md#getmyworkspaces) | **GET** /api/2/workspaces/mine | 
[**GetPathQuota**](StorageApi.md#getpathquota) | **GET** /api/2/volumes/{id}/quotas/path/{relative_path} | 
[**GetProduction**](StorageApi.md#getproduction) | **GET** /api/2/productions/{id} | 
[**GetRootDirectory**](StorageApi.md#getrootdirectory) | **GET** /api/2/files | 
[**GetSambaDfreeString**](StorageApi.md#getsambadfreestring) | **POST** /api/2/private/dfree | 
[**GetShare**](StorageApi.md#getshare) | **GET** /api/2/shares/{id} | 
[**GetSnapshot**](StorageApi.md#getsnapshot) | **GET** /api/2/snapshots/{id} | 
[**GetUserQuota**](StorageApi.md#getuserquota) | **GET** /api/2/volumes/{id}/quotas/user/{user_id} | 
[**GetVolume**](StorageApi.md#getvolume) | **GET** /api/2/volumes/{id} | 
[**GetVolumeActiveConnections**](StorageApi.md#getvolumeactiveconnections) | **GET** /api/2/volumes/{id}/connections | 
[**GetVolumeFileSizeDistribution**](StorageApi.md#getvolumefilesizedistribution) | **GET** /api/2/volumes/{id}/file-size-distribution | 
[**GetVolumeStats**](StorageApi.md#getvolumestats) | **GET** /api/2/volumes/{id}/stats | 
[**GetWorkspace**](StorageApi.md#getworkspace) | **GET** /api/2/workspaces/{id} | 
[**GetWorkspacePermission**](StorageApi.md#getworkspacepermission) | **GET** /api/2/workspace-permissions/{id} | 
[**MoveFiles**](StorageApi.md#movefiles) | **POST** /api/2/filesystem/move | 
[**MoveWorkspace**](StorageApi.md#moveworkspace) | **POST** /api/2/workspaces/{id}/move | 
[**MoveWorkspaceToProduction**](StorageApi.md#moveworkspacetoproduction) | **POST** /api/2/workspaces/{id}/move-to | 
[**PatchFile**](StorageApi.md#patchfile) | **PATCH** /api/2/files/{path} | 
[**PatchProduction**](StorageApi.md#patchproduction) | **PATCH** /api/2/productions/{id} | 
[**PatchShare**](StorageApi.md#patchshare) | **PATCH** /api/2/shares/{id} | 
[**PatchSnapshot**](StorageApi.md#patchsnapshot) | **PATCH** /api/2/snapshots/{id} | 
[**PatchVolume**](StorageApi.md#patchvolume) | **PATCH** /api/2/volumes/{id} | 
[**PatchWorkspace**](StorageApi.md#patchworkspace) | **PATCH** /api/2/workspaces/{id} | 
[**PatchWorkspacePermission**](StorageApi.md#patchworkspacepermission) | **PATCH** /api/2/workspace-permissions/{id} | 
[**RecordStorageTrace**](StorageApi.md#recordstoragetrace) | **POST** /api/2/filesystem/trace | 
[**RepairWorkspacePermissions**](StorageApi.md#repairworkspacepermissions) | **POST** /api/2/workspaces/{id}/repair-permissions | 
[**ShareToHomeWorkspace**](StorageApi.md#sharetohomeworkspace) | **POST** /api/2/share-to-home-workspace | 
[**UnbookmarkWorkspace**](StorageApi.md#unbookmarkworkspace) | **DELETE** /api/2/workspaces/{id}/bookmark | 
[**UnzipFile**](StorageApi.md#unzipfile) | **POST** /api/2/filesystem/unzip | 
[**UpdateGroupQuota**](StorageApi.md#updategroupquota) | **PUT** /api/2/volumes/{id}/quotas/group/{group_id} | 
[**UpdatePathQuota**](StorageApi.md#updatepathquota) | **PUT** /api/2/volumes/{id}/quotas/path/{relative_path} | 
[**UpdateProduction**](StorageApi.md#updateproduction) | **PUT** /api/2/productions/{id} | 
[**UpdateShare**](StorageApi.md#updateshare) | **PUT** /api/2/shares/{id} | 
[**UpdateSnapshot**](StorageApi.md#updatesnapshot) | **PUT** /api/2/snapshots/{id} | 
[**UpdateUserQuota**](StorageApi.md#updateuserquota) | **PUT** /api/2/volumes/{id}/quotas/user/{user_id} | 
[**UpdateVolume**](StorageApi.md#updatevolume) | **PUT** /api/2/volumes/{id} | 
[**UpdateWorkspace**](StorageApi.md#updateworkspace) | **PUT** /api/2/workspaces/{id} | 
[**UpdateWorkspacePermission**](StorageApi.md#updateworkspacepermission) | **PUT** /api/2/workspace-permissions/{id} | 
[**ZipFiles**](StorageApi.md#zipfiles) | **POST** /api/2/filesystem/zip | 


<a name="applyworkspaceaffinity"></a>
# **ApplyWorkspaceAffinity**
> void ApplyWorkspaceAffinity (int id)



### Required permissions    * User account permission: `projects:manage` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class ApplyWorkspaceAffinityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this workspace.

            try
            {
                apiInstance.ApplyWorkspaceAffinity(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.ApplyWorkspaceAffinity: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this workspace. | 

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

<a name="bookmarkworkspace"></a>
# **BookmarkWorkspace**
> void BookmarkWorkspace (int id)



### Required permissions    * Authenticated user 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class BookmarkWorkspaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this workspace.

            try
            {
                apiInstance.BookmarkWorkspace(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.BookmarkWorkspace: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this workspace. | 

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

<a name="calculatedirectorysize"></a>
# **CalculateDirectorySize**
> FileSizeEndpointResponse CalculateDirectorySize (PathInput pathInput)



### Required permissions    * Authenticated user 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CalculateDirectorySizeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var pathInput = new PathInput(); // PathInput | 

            try
            {
                FileSizeEndpointResponse result = apiInstance.CalculateDirectorySize(pathInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.CalculateDirectorySize: " + e.Message );
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
 **pathInput** | [**PathInput**](PathInput.md)|  | 

### Return type

[**FileSizeEndpointResponse**](FileSizeEndpointResponse.md)

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

<a name="checkinintoworkspace"></a>
# **CheckInIntoWorkspace**
> void CheckInIntoWorkspace (int id, WorkspaceCheckIn workspaceCheckIn)



### Required permissions    * Authenticated user 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CheckInIntoWorkspaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this workspace.
            var workspaceCheckIn = new WorkspaceCheckIn(); // WorkspaceCheckIn | 

            try
            {
                apiInstance.CheckInIntoWorkspace(id, workspaceCheckIn);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.CheckInIntoWorkspace: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this workspace. | 
 **workspaceCheckIn** | [**WorkspaceCheckIn**](WorkspaceCheckIn.md)|  | 

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

<a name="checkoutofworkspace"></a>
# **CheckOutOfWorkspace**
> void CheckOutOfWorkspace (int id)



### Required permissions    * Authenticated user 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CheckOutOfWorkspaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this workspace.

            try
            {
                apiInstance.CheckOutOfWorkspace(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.CheckOutOfWorkspace: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this workspace. | 

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

<a name="copyfiles"></a>
# **CopyFiles**
> TaskInfo CopyFiles (FileCopyEndpointRequest fileCopyEndpointRequest)



### Required permissions    * Authenticated user 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CopyFilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var fileCopyEndpointRequest = new FileCopyEndpointRequest(); // FileCopyEndpointRequest | 

            try
            {
                TaskInfo result = apiInstance.CopyFiles(fileCopyEndpointRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.CopyFiles: " + e.Message );
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
 **fileCopyEndpointRequest** | [**FileCopyEndpointRequest**](FileCopyEndpointRequest.md)|  | 

### Return type

[**TaskInfo**](TaskInfo.md)

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

<a name="createfile"></a>
# **CreateFile**
> FilesystemFile CreateFile (FilesystemFile filesystemFile)



### Required permissions    * Authenticated user 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var filesystemFile = new FilesystemFile(); // FilesystemFile | 

            try
            {
                FilesystemFile result = apiInstance.CreateFile(filesystemFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.CreateFile: " + e.Message );
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
 **filesystemFile** | [**FilesystemFile**](FilesystemFile.md)|  | 

### Return type

[**FilesystemFile**](FilesystemFile.md)

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

<a name="createpathquota"></a>
# **CreatePathQuota**
> void CreatePathQuota (int id, string relativePath, CreatePathQuotaRequest createPathQuotaRequest)



### Required permissions    * Authenticated user 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreatePathQuotaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this volume.
            var relativePath = relativePath_example;  // string | 
            var createPathQuotaRequest = new CreatePathQuotaRequest(); // CreatePathQuotaRequest | 

            try
            {
                apiInstance.CreatePathQuota(id, relativePath, createPathQuotaRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.CreatePathQuota: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this volume. | 
 **relativePath** | **string**|  | 
 **createPathQuotaRequest** | [**CreatePathQuotaRequest**](CreatePathQuotaRequest.md)|  | 

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

<a name="createproduction"></a>
# **CreateProduction**
> Production CreateProduction (Production production)



### Required permissions    * User account permission: `projects:view` (read) / `projects:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateProductionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var production = new Production(); // Production | 

            try
            {
                Production result = apiInstance.CreateProduction(production);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.CreateProduction: " + e.Message );
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
 **production** | [**Production**](Production.md)|  | 

### Return type

[**Production**](Production.md)

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

<a name="createshare"></a>
# **CreateShare**
> Share CreateShare (Share share)



### Required permissions    * User account permission: `shares:view` (read) / `shares:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateShareExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var share = new Share(); // Share | 

            try
            {
                Share result = apiInstance.CreateShare(share);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.CreateShare: " + e.Message );
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
 **share** | [**Share**](Share.md)|  | 

### Return type

[**Share**](Share.md)

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

<a name="createsnapshot"></a>
# **CreateSnapshot**
> Snapshot CreateSnapshot (Snapshot snapshot)



### Required permissions    * User account permission: `projects:view` (read) / `projects:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var snapshot = new Snapshot(); // Snapshot | 

            try
            {
                Snapshot result = apiInstance.CreateSnapshot(snapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.CreateSnapshot: " + e.Message );
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
 **snapshot** | [**Snapshot**](Snapshot.md)|  | 

### Return type

[**Snapshot**](Snapshot.md)

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

<a name="createtemplatefolder"></a>
# **CreateTemplateFolder**
> void CreateTemplateFolder (CreateTemplateFolderEndpointRequest createTemplateFolderEndpointRequest)



### Required permissions    * User account permission: `folder_templates:manage` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateTemplateFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var createTemplateFolderEndpointRequest = new CreateTemplateFolderEndpointRequest(); // CreateTemplateFolderEndpointRequest | 

            try
            {
                apiInstance.CreateTemplateFolder(createTemplateFolderEndpointRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.CreateTemplateFolder: " + e.Message );
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
 **createTemplateFolderEndpointRequest** | [**CreateTemplateFolderEndpointRequest**](CreateTemplateFolderEndpointRequest.md)|  | 

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

<a name="createworkspace"></a>
# **CreateWorkspace**
> WorkspaceDetail CreateWorkspace (WorkspaceDetail workspaceDetail)



### Required permissions    * User account permission: `None` (read) / `projects:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateWorkspaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var workspaceDetail = new WorkspaceDetail(); // WorkspaceDetail | 

            try
            {
                WorkspaceDetail result = apiInstance.CreateWorkspace(workspaceDetail);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.CreateWorkspace: " + e.Message );
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
 **workspaceDetail** | [**WorkspaceDetail**](WorkspaceDetail.md)|  | 

### Return type

[**WorkspaceDetail**](WorkspaceDetail.md)

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

<a name="createworkspacepermission"></a>
# **CreateWorkspacePermission**
> WorkspacePermission CreateWorkspacePermission (WorkspacePermission workspacePermission)



### Required permissions    * User account permission: `projects:view` (read) / `projects:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateWorkspacePermissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var workspacePermission = new WorkspacePermission(); // WorkspacePermission | 

            try
            {
                WorkspacePermission result = apiInstance.CreateWorkspacePermission(workspacePermission);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.CreateWorkspacePermission: " + e.Message );
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
 **workspacePermission** | [**WorkspacePermission**](WorkspacePermission.md)|  | 

### Return type

[**WorkspacePermission**](WorkspacePermission.md)

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

<a name="deletefile"></a>
# **DeleteFile**
> void DeleteFile (string path)



### Required permissions    * Authenticated user 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var path = path_example;  // string | 

            try
            {
                apiInstance.DeleteFile(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.DeleteFile: " + e.Message );
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
 **path** | **string**|  | 

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

<a name="deletefiles"></a>
# **DeleteFiles**
> TaskInfo DeleteFiles (FileDeleteEndpointRequest fileDeleteEndpointRequest)



### Required permissions    * Authenticated user 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteFilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var fileDeleteEndpointRequest = new FileDeleteEndpointRequest(); // FileDeleteEndpointRequest | 

            try
            {
                TaskInfo result = apiInstance.DeleteFiles(fileDeleteEndpointRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.DeleteFiles: " + e.Message );
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
 **fileDeleteEndpointRequest** | [**FileDeleteEndpointRequest**](FileDeleteEndpointRequest.md)|  | 

### Return type

[**TaskInfo**](TaskInfo.md)

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

<a name="deletepathquota"></a>
# **DeletePathQuota**
> void DeletePathQuota (int id, string relativePath)



### Required permissions    * Authenticated user 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeletePathQuotaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this volume.
            var relativePath = relativePath_example;  // string | 

            try
            {
                apiInstance.DeletePathQuota(id, relativePath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.DeletePathQuota: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this volume. | 
 **relativePath** | **string**|  | 

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

<a name="deleteproduction"></a>
# **DeleteProduction**
> void DeleteProduction (int id)



### Required permissions    * User account permission: `projects:view` (read) / `projects:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteProductionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this production.

            try
            {
                apiInstance.DeleteProduction(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.DeleteProduction: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this production. | 

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

<a name="deleteshare"></a>
# **DeleteShare**
> void DeleteShare (int id)



### Required permissions    * User account permission: `shares:view` (read) / `shares:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteShareExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this share.

            try
            {
                apiInstance.DeleteShare(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.DeleteShare: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this share. | 

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

<a name="deletesnapshot"></a>
# **DeleteSnapshot**
> void DeleteSnapshot (int id)



### Required permissions    * User account permission: `projects:view` (read) / `projects:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this snapshot.

            try
            {
                apiInstance.DeleteSnapshot(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.DeleteSnapshot: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this snapshot. | 

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

<a name="deleteworkspace"></a>
# **DeleteWorkspace**
> void DeleteWorkspace (int id)



### Required permissions    * User account permission: `None` (read) / `projects:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteWorkspaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this workspace.

            try
            {
                apiInstance.DeleteWorkspace(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.DeleteWorkspace: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this workspace. | 

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

<a name="deleteworkspacepermission"></a>
# **DeleteWorkspacePermission**
> void DeleteWorkspacePermission (int id)



### Required permissions    * User account permission: `projects:view` (read) / `projects:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteWorkspacePermissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this workspace permission.

            try
            {
                apiInstance.DeleteWorkspacePermission(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.DeleteWorkspacePermission: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this workspace permission. | 

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

<a name="getalldeletedworkspaces"></a>
# **GetAllDeletedWorkspaces**
> List&lt;DeletedWorkspace&gt; GetAllDeletedWorkspaces (string isTemplate = null, string production = null, string volume = null, string homeFor = null, string volumeType = null, string productionName = null, string productionActive = null, string name = null, string isExternal = null, string active = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `projects:view` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllDeletedWorkspacesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var isTemplate = isTemplate_example;  // string | Filter the returned list by `is_template`. (optional) 
            var production = production_example;  // string | Filter the returned list by `production`. (optional) 
            var volume = volume_example;  // string | Filter the returned list by `volume`. (optional) 
            var homeFor = homeFor_example;  // string | Filter the returned list by `home_for`. (optional) 
            var volumeType = volumeType_example;  // string | Filter the returned list by `volume__type`. (optional) 
            var productionName = productionName_example;  // string | Filter the returned list by `production__name`. (optional) 
            var productionActive = productionActive_example;  // string | Filter the returned list by `production__active`. (optional) 
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var isExternal = isExternal_example;  // string | Filter the returned list by `is_external`. (optional) 
            var active = active_example;  // string | Filter the returned list by `active`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<DeletedWorkspace> result = apiInstance.GetAllDeletedWorkspaces(isTemplate, production, volume, homeFor, volumeType, productionName, productionActive, name, isExternal, active, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.GetAllDeletedWorkspaces: " + e.Message );
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
 **isTemplate** | **string**| Filter the returned list by &#x60;is_template&#x60;. | [optional] 
 **production** | **string**| Filter the returned list by &#x60;production&#x60;. | [optional] 
 **volume** | **string**| Filter the returned list by &#x60;volume&#x60;. | [optional] 
 **homeFor** | **string**| Filter the returned list by &#x60;home_for&#x60;. | [optional] 
 **volumeType** | **string**| Filter the returned list by &#x60;volume__type&#x60;. | [optional] 
 **productionName** | **string**| Filter the returned list by &#x60;production__name&#x60;. | [optional] 
 **productionActive** | **string**| Filter the returned list by &#x60;production__active&#x60;. | [optional] 
 **name** | **string**| Filter the returned list by &#x60;name&#x60;. | [optional] 
 **isExternal** | **string**| Filter the returned list by &#x60;is_external&#x60;. | [optional] 
 **active** | **string**| Filter the returned list by &#x60;active&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;DeletedWorkspace&gt;**](DeletedWorkspace.md)

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

<a name="getallproductions"></a>
# **GetAllProductions**
> List&lt;Production&gt; GetAllProductions (string active = null, string name = null, string ordering = null, int? limit = null, int? offset = null, bool? copyTemplateContent = null, bool? includeTotalSize = null)



### Required permissions    * User account permission: `projects:view` (read) / `projects:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllProductionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var active = active_example;  // string | Filter the returned list by `active`. (optional) 
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 
            var copyTemplateContent = true;  // bool? |  (optional) 
            var includeTotalSize = true;  // bool? |  (optional) 

            try
            {
                List<Production> result = apiInstance.GetAllProductions(active, name, ordering, limit, offset, copyTemplateContent, includeTotalSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.GetAllProductions: " + e.Message );
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
 **active** | **string**| Filter the returned list by &#x60;active&#x60;. | [optional] 
 **name** | **string**| Filter the returned list by &#x60;name&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 
 **copyTemplateContent** | **bool?**|  | [optional] 
 **includeTotalSize** | **bool?**|  | [optional] 

### Return type

[**List&lt;Production&gt;**](Production.md)

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

<a name="getallshares"></a>
# **GetAllShares**
> List&lt;Share&gt; GetAllShares (string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `shares:view` (read) / `shares:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllSharesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<Share> result = apiInstance.GetAllShares(ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.GetAllShares: " + e.Message );
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

[**List&lt;Share&gt;**](Share.md)

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

<a name="getallsnapshots"></a>
# **GetAllSnapshots**
> List&lt;Snapshot&gt; GetAllSnapshots (string workspace = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `projects:view` (read) / `projects:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllSnapshotsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var workspace = workspace_example;  // string | Filter the returned list by `workspace`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<Snapshot> result = apiInstance.GetAllSnapshots(workspace, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.GetAllSnapshots: " + e.Message );
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
 **workspace** | **string**| Filter the returned list by &#x60;workspace&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;Snapshot&gt;**](Snapshot.md)

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

<a name="getallvolumes"></a>
# **GetAllVolumes**
> List&lt;Volume&gt; GetAllVolumes (string isDefault = null, string type = null, string useForHomes = null, string useForWorkspaces = null, string name = null, string displayName = null, string visualTag = null, string ordering = null, int? limit = null, int? offset = null, bool? includeStatus = null)



### Required permissions    * User account permission: `None` (read) / `system:admin-access` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllVolumesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var isDefault = isDefault_example;  // string | Filter the returned list by `is_default`. (optional) 
            var type = type_example;  // string | Filter the returned list by `type`. (optional) 
            var useForHomes = useForHomes_example;  // string | Filter the returned list by `use_for_homes`. (optional) 
            var useForWorkspaces = useForWorkspaces_example;  // string | Filter the returned list by `use_for_workspaces`. (optional) 
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var displayName = displayName_example;  // string | Filter the returned list by `display_name`. (optional) 
            var visualTag = visualTag_example;  // string | Filter the returned list by `visual_tag`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 
            var includeStatus = true;  // bool? |  (optional) 

            try
            {
                List<Volume> result = apiInstance.GetAllVolumes(isDefault, type, useForHomes, useForWorkspaces, name, displayName, visualTag, ordering, limit, offset, includeStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.GetAllVolumes: " + e.Message );
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
 **isDefault** | **string**| Filter the returned list by &#x60;is_default&#x60;. | [optional] 
 **type** | **string**| Filter the returned list by &#x60;type&#x60;. | [optional] 
 **useForHomes** | **string**| Filter the returned list by &#x60;use_for_homes&#x60;. | [optional] 
 **useForWorkspaces** | **string**| Filter the returned list by &#x60;use_for_workspaces&#x60;. | [optional] 
 **name** | **string**| Filter the returned list by &#x60;name&#x60;. | [optional] 
 **displayName** | **string**| Filter the returned list by &#x60;display_name&#x60;. | [optional] 
 **visualTag** | **string**| Filter the returned list by &#x60;visual_tag&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 
 **includeStatus** | **bool?**|  | [optional] 

### Return type

[**List&lt;Volume&gt;**](Volume.md)

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

<a name="getallworkspacepermissions"></a>
# **GetAllWorkspacePermissions**
> List&lt;WorkspacePermission&gt; GetAllWorkspacePermissions (string workspace = null, string user = null, string group = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `projects:view` (read) / `projects:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllWorkspacePermissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var workspace = workspace_example;  // string | Filter the returned list by `workspace`. (optional) 
            var user = user_example;  // string | Filter the returned list by `user`. (optional) 
            var group = group_example;  // string | Filter the returned list by `group`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<WorkspacePermission> result = apiInstance.GetAllWorkspacePermissions(workspace, user, group, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.GetAllWorkspacePermissions: " + e.Message );
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
 **workspace** | **string**| Filter the returned list by &#x60;workspace&#x60;. | [optional] 
 **user** | **string**| Filter the returned list by &#x60;user&#x60;. | [optional] 
 **group** | **string**| Filter the returned list by &#x60;group&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;WorkspacePermission&gt;**](WorkspacePermission.md)

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

<a name="getallworkspaces"></a>
# **GetAllWorkspaces**
> List&lt;Workspace&gt; GetAllWorkspaces (string isTemplate = null, string production = null, string volume = null, string homeFor = null, string volumeType = null, string productionName = null, string productionActive = null, string name = null, string isExternal = null, string active = null, string ordering = null, int? limit = null, int? offset = null, int? resolveAccessFor = null, bool? includeEndpoints = null, bool? includeQuotas = null)



### Required permissions    * User account permission: `None` (read) / `projects:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllWorkspacesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var isTemplate = isTemplate_example;  // string | Filter the returned list by `is_template`. (optional) 
            var production = production_example;  // string | Filter the returned list by `production`. (optional) 
            var volume = volume_example;  // string | Filter the returned list by `volume`. (optional) 
            var homeFor = homeFor_example;  // string | Filter the returned list by `home_for`. (optional) 
            var volumeType = volumeType_example;  // string | Filter the returned list by `volume__type`. (optional) 
            var productionName = productionName_example;  // string | Filter the returned list by `production__name`. (optional) 
            var productionActive = productionActive_example;  // string | Filter the returned list by `production__active`. (optional) 
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var isExternal = isExternal_example;  // string | Filter the returned list by `is_external`. (optional) 
            var active = active_example;  // string | Filter the returned list by `active`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 
            var resolveAccessFor = 56;  // int? |  (optional) 
            var includeEndpoints = true;  // bool? |  (optional) 
            var includeQuotas = true;  // bool? |  (optional) 

            try
            {
                List<Workspace> result = apiInstance.GetAllWorkspaces(isTemplate, production, volume, homeFor, volumeType, productionName, productionActive, name, isExternal, active, ordering, limit, offset, resolveAccessFor, includeEndpoints, includeQuotas);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.GetAllWorkspaces: " + e.Message );
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
 **isTemplate** | **string**| Filter the returned list by &#x60;is_template&#x60;. | [optional] 
 **production** | **string**| Filter the returned list by &#x60;production&#x60;. | [optional] 
 **volume** | **string**| Filter the returned list by &#x60;volume&#x60;. | [optional] 
 **homeFor** | **string**| Filter the returned list by &#x60;home_for&#x60;. | [optional] 
 **volumeType** | **string**| Filter the returned list by &#x60;volume__type&#x60;. | [optional] 
 **productionName** | **string**| Filter the returned list by &#x60;production__name&#x60;. | [optional] 
 **productionActive** | **string**| Filter the returned list by &#x60;production__active&#x60;. | [optional] 
 **name** | **string**| Filter the returned list by &#x60;name&#x60;. | [optional] 
 **isExternal** | **string**| Filter the returned list by &#x60;is_external&#x60;. | [optional] 
 **active** | **string**| Filter the returned list by &#x60;active&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 
 **resolveAccessFor** | **int?**|  | [optional] 
 **includeEndpoints** | **bool?**|  | [optional] 
 **includeQuotas** | **bool?**|  | [optional] 

### Return type

[**List&lt;Workspace&gt;**](Workspace.md)

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

<a name="getfile"></a>
# **GetFile**
> FilesystemFile GetFile (string path, int? maxDepth = null, bool? bundle = null)



### Required permissions    * Authenticated user 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var path = path_example;  // string | 
            var maxDepth = 56;  // int? |  (optional) 
            var bundle = true;  // bool? |  (optional) 

            try
            {
                FilesystemFile result = apiInstance.GetFile(path, maxDepth, bundle);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.GetFile: " + e.Message );
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
 **path** | **string**|  | 
 **maxDepth** | **int?**|  | [optional] 
 **bundle** | **bool?**|  | [optional] 

### Return type

[**FilesystemFile**](FilesystemFile.md)

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

<a name="getgroupquota"></a>
# **GetGroupQuota**
> Quota GetGroupQuota (string groupId, int id)



### Required permissions    * User account permission: `users:manage` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetGroupQuotaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var groupId = groupId_example;  // string | 
            var id = 56;  // int | A unique integer value identifying this volume.

            try
            {
                Quota result = apiInstance.GetGroupQuota(groupId, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.GetGroupQuota: " + e.Message );
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
 **groupId** | **string**|  | 
 **id** | **int**| A unique integer value identifying this volume. | 

### Return type

[**Quota**](Quota.md)

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

<a name="getmyworkspaces"></a>
# **GetMyWorkspaces**
> List&lt;Workspace&gt; GetMyWorkspaces (string isTemplate = null, string production = null, string volume = null, string homeFor = null, string volumeType = null, string productionName = null, string productionActive = null, string name = null, string isExternal = null, string active = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `None` (read) / `projects:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetMyWorkspacesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var isTemplate = isTemplate_example;  // string | Filter the returned list by `is_template`. (optional) 
            var production = production_example;  // string | Filter the returned list by `production`. (optional) 
            var volume = volume_example;  // string | Filter the returned list by `volume`. (optional) 
            var homeFor = homeFor_example;  // string | Filter the returned list by `home_for`. (optional) 
            var volumeType = volumeType_example;  // string | Filter the returned list by `volume__type`. (optional) 
            var productionName = productionName_example;  // string | Filter the returned list by `production__name`. (optional) 
            var productionActive = productionActive_example;  // string | Filter the returned list by `production__active`. (optional) 
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var isExternal = isExternal_example;  // string | Filter the returned list by `is_external`. (optional) 
            var active = active_example;  // string | Filter the returned list by `active`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<Workspace> result = apiInstance.GetMyWorkspaces(isTemplate, production, volume, homeFor, volumeType, productionName, productionActive, name, isExternal, active, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.GetMyWorkspaces: " + e.Message );
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
 **isTemplate** | **string**| Filter the returned list by &#x60;is_template&#x60;. | [optional] 
 **production** | **string**| Filter the returned list by &#x60;production&#x60;. | [optional] 
 **volume** | **string**| Filter the returned list by &#x60;volume&#x60;. | [optional] 
 **homeFor** | **string**| Filter the returned list by &#x60;home_for&#x60;. | [optional] 
 **volumeType** | **string**| Filter the returned list by &#x60;volume__type&#x60;. | [optional] 
 **productionName** | **string**| Filter the returned list by &#x60;production__name&#x60;. | [optional] 
 **productionActive** | **string**| Filter the returned list by &#x60;production__active&#x60;. | [optional] 
 **name** | **string**| Filter the returned list by &#x60;name&#x60;. | [optional] 
 **isExternal** | **string**| Filter the returned list by &#x60;is_external&#x60;. | [optional] 
 **active** | **string**| Filter the returned list by &#x60;active&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;Workspace&gt;**](Workspace.md)

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

<a name="getpathquota"></a>
# **GetPathQuota**
> Quota GetPathQuota (int id, string relativePath)



### Required permissions    * Authenticated user 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetPathQuotaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this volume.
            var relativePath = relativePath_example;  // string | 

            try
            {
                Quota result = apiInstance.GetPathQuota(id, relativePath);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.GetPathQuota: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this volume. | 
 **relativePath** | **string**|  | 

### Return type

[**Quota**](Quota.md)

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

<a name="getproduction"></a>
# **GetProduction**
> Production GetProduction (int id, bool? copyTemplateContent = null, bool? includeTotalSize = null)



### Required permissions    * User account permission: `projects:view` (read) / `projects:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetProductionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this production.
            var copyTemplateContent = true;  // bool? |  (optional) 
            var includeTotalSize = true;  // bool? |  (optional) 

            try
            {
                Production result = apiInstance.GetProduction(id, copyTemplateContent, includeTotalSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.GetProduction: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this production. | 
 **copyTemplateContent** | **bool?**|  | [optional] 
 **includeTotalSize** | **bool?**|  | [optional] 

### Return type

[**Production**](Production.md)

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

<a name="getrootdirectory"></a>
# **GetRootDirectory**
> void GetRootDirectory (string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * Authenticated user 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetRootDirectoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                apiInstance.GetRootDirectory(ordering, limit, offset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.GetRootDirectory: " + e.Message );
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

void (empty response body)

### Authorization

[Bearer](../#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **301** | Redirects to root file |  -  |

[[Back to top]](#) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to Model list]](../#documentation-for-models) [[Back to README]](../)

<a name="getsambadfreestring"></a>
# **GetSambaDfreeString**
> void GetSambaDfreeString ()



### Required permissions    * localhost only 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetSambaDfreeStringExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);

            try
            {
                apiInstance.GetSambaDfreeString();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.GetSambaDfreeString: " + e.Message );
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

<a name="getshare"></a>
# **GetShare**
> Share GetShare (int id)



### Required permissions    * User account permission: `shares:view` (read) / `shares:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetShareExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this share.

            try
            {
                Share result = apiInstance.GetShare(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.GetShare: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this share. | 

### Return type

[**Share**](Share.md)

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

<a name="getsnapshot"></a>
# **GetSnapshot**
> Snapshot GetSnapshot (int id)



### Required permissions    * User account permission: `projects:view` (read) / `projects:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this snapshot.

            try
            {
                Snapshot result = apiInstance.GetSnapshot(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.GetSnapshot: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this snapshot. | 

### Return type

[**Snapshot**](Snapshot.md)

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

<a name="getuserquota"></a>
# **GetUserQuota**
> Quota GetUserQuota (int id, string userId)



### Required permissions    * User account permission: `users:manage` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetUserQuotaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this volume.
            var userId = userId_example;  // string | 

            try
            {
                Quota result = apiInstance.GetUserQuota(id, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.GetUserQuota: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this volume. | 
 **userId** | **string**|  | 

### Return type

[**Quota**](Quota.md)

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

<a name="getvolume"></a>
# **GetVolume**
> Volume GetVolume (int id, bool? includeStatus = null)



### Required permissions    * User account permission: `None` (read) / `system:admin-access` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetVolumeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this volume.
            var includeStatus = true;  // bool? |  (optional) 

            try
            {
                Volume result = apiInstance.GetVolume(id, includeStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.GetVolume: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this volume. | 
 **includeStatus** | **bool?**|  | [optional] 

### Return type

[**Volume**](Volume.md)

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

<a name="getvolumeactiveconnections"></a>
# **GetVolumeActiveConnections**
> StorNextConnections GetVolumeActiveConnections (int id)



### Required permissions    * User account permission: `system:status:view` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetVolumeActiveConnectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this volume.

            try
            {
                StorNextConnections result = apiInstance.GetVolumeActiveConnections(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.GetVolumeActiveConnections: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this volume. | 

### Return type

[**StorNextConnections**](StorNextConnections.md)

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

<a name="getvolumefilesizedistribution"></a>
# **GetVolumeFileSizeDistribution**
> FileSizeDistribution GetVolumeFileSizeDistribution (int id)



### Required permissions    * User account permission: `system:status:view` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetVolumeFileSizeDistributionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this volume.

            try
            {
                FileSizeDistribution result = apiInstance.GetVolumeFileSizeDistribution(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.GetVolumeFileSizeDistribution: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this volume. | 

### Return type

[**FileSizeDistribution**](FileSizeDistribution.md)

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

<a name="getvolumestats"></a>
# **GetVolumeStats**
> VolumeStats GetVolumeStats (int id)



### Required permissions    * User account permission: `system:status:view` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetVolumeStatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this volume.

            try
            {
                VolumeStats result = apiInstance.GetVolumeStats(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.GetVolumeStats: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this volume. | 

### Return type

[**VolumeStats**](VolumeStats.md)

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

<a name="getworkspace"></a>
# **GetWorkspace**
> WorkspaceDetail GetWorkspace (int id)



### Required permissions    * User account permission: `None` (read) / `projects:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetWorkspaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this workspace.

            try
            {
                WorkspaceDetail result = apiInstance.GetWorkspace(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.GetWorkspace: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this workspace. | 

### Return type

[**WorkspaceDetail**](WorkspaceDetail.md)

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

<a name="getworkspacepermission"></a>
# **GetWorkspacePermission**
> WorkspacePermission GetWorkspacePermission (int id)



### Required permissions    * User account permission: `projects:view` (read) / `projects:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetWorkspacePermissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this workspace permission.

            try
            {
                WorkspacePermission result = apiInstance.GetWorkspacePermission(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.GetWorkspacePermission: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this workspace permission. | 

### Return type

[**WorkspacePermission**](WorkspacePermission.md)

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

<a name="movefiles"></a>
# **MoveFiles**
> TaskInfo MoveFiles (FileMoveEndpointRequest fileMoveEndpointRequest)



### Required permissions    * Authenticated user 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class MoveFilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var fileMoveEndpointRequest = new FileMoveEndpointRequest(); // FileMoveEndpointRequest | 

            try
            {
                TaskInfo result = apiInstance.MoveFiles(fileMoveEndpointRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.MoveFiles: " + e.Message );
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
 **fileMoveEndpointRequest** | [**FileMoveEndpointRequest**](FileMoveEndpointRequest.md)|  | 

### Return type

[**TaskInfo**](TaskInfo.md)

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

<a name="moveworkspace"></a>
# **MoveWorkspace**
> TaskInfo MoveWorkspace (int id, MoveWorkspaceRequest moveWorkspaceRequest)



### Required permissions    * User account permission: `projects:manage` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class MoveWorkspaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this workspace.
            var moveWorkspaceRequest = new MoveWorkspaceRequest(); // MoveWorkspaceRequest | 

            try
            {
                TaskInfo result = apiInstance.MoveWorkspace(id, moveWorkspaceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.MoveWorkspace: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this workspace. | 
 **moveWorkspaceRequest** | [**MoveWorkspaceRequest**](MoveWorkspaceRequest.md)|  | 

### Return type

[**TaskInfo**](TaskInfo.md)

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

<a name="moveworkspacetoproduction"></a>
# **MoveWorkspaceToProduction**
> void MoveWorkspaceToProduction (int id, WorkspaceMoveToRequest workspaceMoveToRequest)



### Required permissions    * User account permission: `projects:manage` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class MoveWorkspaceToProductionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this workspace.
            var workspaceMoveToRequest = new WorkspaceMoveToRequest(); // WorkspaceMoveToRequest | 

            try
            {
                apiInstance.MoveWorkspaceToProduction(id, workspaceMoveToRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.MoveWorkspaceToProduction: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this workspace. | 
 **workspaceMoveToRequest** | [**WorkspaceMoveToRequest**](WorkspaceMoveToRequest.md)|  | 

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

<a name="patchfile"></a>
# **PatchFile**
> FilesystemFile PatchFile (string path, FilePartialUpdate filePartialUpdate, int? maxDepth = null, bool? bundle = null)



### Required permissions    * Authenticated user 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var path = path_example;  // string | 
            var filePartialUpdate = new FilePartialUpdate(); // FilePartialUpdate | 
            var maxDepth = 56;  // int? |  (optional) 
            var bundle = true;  // bool? |  (optional) 

            try
            {
                FilesystemFile result = apiInstance.PatchFile(path, filePartialUpdate, maxDepth, bundle);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.PatchFile: " + e.Message );
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
 **path** | **string**|  | 
 **filePartialUpdate** | [**FilePartialUpdate**](FilePartialUpdate.md)|  | 
 **maxDepth** | **int?**|  | [optional] 
 **bundle** | **bool?**|  | [optional] 

### Return type

[**FilesystemFile**](FilesystemFile.md)

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

<a name="patchproduction"></a>
# **PatchProduction**
> Production PatchProduction (int id, ProductionPartialUpdate productionPartialUpdate)



### Required permissions    * User account permission: `projects:view` (read) / `projects:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchProductionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this production.
            var productionPartialUpdate = new ProductionPartialUpdate(); // ProductionPartialUpdate | 

            try
            {
                Production result = apiInstance.PatchProduction(id, productionPartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.PatchProduction: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this production. | 
 **productionPartialUpdate** | [**ProductionPartialUpdate**](ProductionPartialUpdate.md)|  | 

### Return type

[**Production**](Production.md)

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

<a name="patchshare"></a>
# **PatchShare**
> Share PatchShare (int id, SharePartialUpdate sharePartialUpdate)



### Required permissions    * User account permission: `shares:view` (read) / `shares:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchShareExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this share.
            var sharePartialUpdate = new SharePartialUpdate(); // SharePartialUpdate | 

            try
            {
                Share result = apiInstance.PatchShare(id, sharePartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.PatchShare: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this share. | 
 **sharePartialUpdate** | [**SharePartialUpdate**](SharePartialUpdate.md)|  | 

### Return type

[**Share**](Share.md)

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

<a name="patchsnapshot"></a>
# **PatchSnapshot**
> Snapshot PatchSnapshot (int id, SnapshotPartialUpdate snapshotPartialUpdate)



### Required permissions    * User account permission: `projects:view` (read) / `projects:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this snapshot.
            var snapshotPartialUpdate = new SnapshotPartialUpdate(); // SnapshotPartialUpdate | 

            try
            {
                Snapshot result = apiInstance.PatchSnapshot(id, snapshotPartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.PatchSnapshot: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this snapshot. | 
 **snapshotPartialUpdate** | [**SnapshotPartialUpdate**](SnapshotPartialUpdate.md)|  | 

### Return type

[**Snapshot**](Snapshot.md)

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

<a name="patchvolume"></a>
# **PatchVolume**
> Volume PatchVolume (int id, VolumePartialUpdate volumePartialUpdate)



### Required permissions    * User account permission: `None` (read) / `system:admin-access` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchVolumeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this volume.
            var volumePartialUpdate = new VolumePartialUpdate(); // VolumePartialUpdate | 

            try
            {
                Volume result = apiInstance.PatchVolume(id, volumePartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.PatchVolume: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this volume. | 
 **volumePartialUpdate** | [**VolumePartialUpdate**](VolumePartialUpdate.md)|  | 

### Return type

[**Volume**](Volume.md)

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

<a name="patchworkspace"></a>
# **PatchWorkspace**
> WorkspaceDetail PatchWorkspace (int id, WorkspaceDetailPartialUpdate workspaceDetailPartialUpdate)



### Required permissions    * User account permission: `None` (read) / `projects:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchWorkspaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this workspace.
            var workspaceDetailPartialUpdate = new WorkspaceDetailPartialUpdate(); // WorkspaceDetailPartialUpdate | 

            try
            {
                WorkspaceDetail result = apiInstance.PatchWorkspace(id, workspaceDetailPartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.PatchWorkspace: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this workspace. | 
 **workspaceDetailPartialUpdate** | [**WorkspaceDetailPartialUpdate**](WorkspaceDetailPartialUpdate.md)|  | 

### Return type

[**WorkspaceDetail**](WorkspaceDetail.md)

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

<a name="patchworkspacepermission"></a>
# **PatchWorkspacePermission**
> WorkspacePermission PatchWorkspacePermission (int id, WorkspacePermissionPartialUpdate workspacePermissionPartialUpdate)



### Required permissions    * User account permission: `projects:view` (read) / `projects:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchWorkspacePermissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this workspace permission.
            var workspacePermissionPartialUpdate = new WorkspacePermissionPartialUpdate(); // WorkspacePermissionPartialUpdate | 

            try
            {
                WorkspacePermission result = apiInstance.PatchWorkspacePermission(id, workspacePermissionPartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.PatchWorkspacePermission: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this workspace permission. | 
 **workspacePermissionPartialUpdate** | [**WorkspacePermissionPartialUpdate**](WorkspacePermissionPartialUpdate.md)|  | 

### Return type

[**WorkspacePermission**](WorkspacePermission.md)

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

<a name="recordstoragetrace"></a>
# **RecordStorageTrace**
> FilesystemTraceEndpointResponse RecordStorageTrace (FilesystemTraceEndpointRequest filesystemTraceEndpointRequest)



### Required permissions    * User account permission: `system:admin-access` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class RecordStorageTraceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var filesystemTraceEndpointRequest = new FilesystemTraceEndpointRequest(); // FilesystemTraceEndpointRequest | 

            try
            {
                FilesystemTraceEndpointResponse result = apiInstance.RecordStorageTrace(filesystemTraceEndpointRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.RecordStorageTrace: " + e.Message );
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
 **filesystemTraceEndpointRequest** | [**FilesystemTraceEndpointRequest**](FilesystemTraceEndpointRequest.md)|  | 

### Return type

[**FilesystemTraceEndpointResponse**](FilesystemTraceEndpointResponse.md)

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

<a name="repairworkspacepermissions"></a>
# **RepairWorkspacePermissions**
> TaskInfo RepairWorkspacePermissions (int id)



### Required permissions    * User account permission: `projects:manage` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class RepairWorkspacePermissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this workspace.

            try
            {
                TaskInfo result = apiInstance.RepairWorkspacePermissions(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.RepairWorkspacePermissions: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this workspace. | 

### Return type

[**TaskInfo**](TaskInfo.md)

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

<a name="sharetohomeworkspace"></a>
# **ShareToHomeWorkspace**
> void ShareToHomeWorkspace (ShareToHomeWorkspaceEndpointRequest shareToHomeWorkspaceEndpointRequest)



### Required permissions    * Authenticated user 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class ShareToHomeWorkspaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var shareToHomeWorkspaceEndpointRequest = new ShareToHomeWorkspaceEndpointRequest(); // ShareToHomeWorkspaceEndpointRequest | 

            try
            {
                apiInstance.ShareToHomeWorkspace(shareToHomeWorkspaceEndpointRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.ShareToHomeWorkspace: " + e.Message );
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
 **shareToHomeWorkspaceEndpointRequest** | [**ShareToHomeWorkspaceEndpointRequest**](ShareToHomeWorkspaceEndpointRequest.md)|  | 

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

<a name="unbookmarkworkspace"></a>
# **UnbookmarkWorkspace**
> void UnbookmarkWorkspace (int id)



### Required permissions    * Authenticated user 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UnbookmarkWorkspaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this workspace.

            try
            {
                apiInstance.UnbookmarkWorkspace(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.UnbookmarkWorkspace: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this workspace. | 

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

<a name="unzipfile"></a>
# **UnzipFile**
> TaskInfo UnzipFile (FileUnzipEndpointRequest fileUnzipEndpointRequest)



### Required permissions    * Authenticated user 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UnzipFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var fileUnzipEndpointRequest = new FileUnzipEndpointRequest(); // FileUnzipEndpointRequest | 

            try
            {
                TaskInfo result = apiInstance.UnzipFile(fileUnzipEndpointRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.UnzipFile: " + e.Message );
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
 **fileUnzipEndpointRequest** | [**FileUnzipEndpointRequest**](FileUnzipEndpointRequest.md)|  | 

### Return type

[**TaskInfo**](TaskInfo.md)

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

<a name="updategroupquota"></a>
# **UpdateGroupQuota**
> void UpdateGroupQuota (string groupId, int id, UpdateQuotaRequest updateQuotaRequest)



### Required permissions    * User account permission: `users:manage` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateGroupQuotaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var groupId = groupId_example;  // string | 
            var id = 56;  // int | A unique integer value identifying this volume.
            var updateQuotaRequest = new UpdateQuotaRequest(); // UpdateQuotaRequest | 

            try
            {
                apiInstance.UpdateGroupQuota(groupId, id, updateQuotaRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.UpdateGroupQuota: " + e.Message );
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
 **groupId** | **string**|  | 
 **id** | **int**| A unique integer value identifying this volume. | 
 **updateQuotaRequest** | [**UpdateQuotaRequest**](UpdateQuotaRequest.md)|  | 

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

<a name="updatepathquota"></a>
# **UpdatePathQuota**
> void UpdatePathQuota (int id, string relativePath, UpdateQuotaRequest updateQuotaRequest)



### Required permissions    * Authenticated user 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdatePathQuotaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this volume.
            var relativePath = relativePath_example;  // string | 
            var updateQuotaRequest = new UpdateQuotaRequest(); // UpdateQuotaRequest | 

            try
            {
                apiInstance.UpdatePathQuota(id, relativePath, updateQuotaRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.UpdatePathQuota: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this volume. | 
 **relativePath** | **string**|  | 
 **updateQuotaRequest** | [**UpdateQuotaRequest**](UpdateQuotaRequest.md)|  | 

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

<a name="updateproduction"></a>
# **UpdateProduction**
> Production UpdateProduction (int id, Production production)



### Required permissions    * User account permission: `projects:view` (read) / `projects:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateProductionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this production.
            var production = new Production(); // Production | 

            try
            {
                Production result = apiInstance.UpdateProduction(id, production);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.UpdateProduction: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this production. | 
 **production** | [**Production**](Production.md)|  | 

### Return type

[**Production**](Production.md)

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

<a name="updateshare"></a>
# **UpdateShare**
> Share UpdateShare (int id, Share share)



### Required permissions    * User account permission: `shares:view` (read) / `shares:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateShareExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this share.
            var share = new Share(); // Share | 

            try
            {
                Share result = apiInstance.UpdateShare(id, share);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.UpdateShare: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this share. | 
 **share** | [**Share**](Share.md)|  | 

### Return type

[**Share**](Share.md)

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

<a name="updatesnapshot"></a>
# **UpdateSnapshot**
> Snapshot UpdateSnapshot (int id, Snapshot snapshot)



### Required permissions    * User account permission: `projects:view` (read) / `projects:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this snapshot.
            var snapshot = new Snapshot(); // Snapshot | 

            try
            {
                Snapshot result = apiInstance.UpdateSnapshot(id, snapshot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.UpdateSnapshot: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this snapshot. | 
 **snapshot** | [**Snapshot**](Snapshot.md)|  | 

### Return type

[**Snapshot**](Snapshot.md)

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

<a name="updateuserquota"></a>
# **UpdateUserQuota**
> void UpdateUserQuota (int id, string userId, UpdateQuotaRequest updateQuotaRequest)



### Required permissions    * User account permission: `users:manage` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateUserQuotaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this volume.
            var userId = userId_example;  // string | 
            var updateQuotaRequest = new UpdateQuotaRequest(); // UpdateQuotaRequest | 

            try
            {
                apiInstance.UpdateUserQuota(id, userId, updateQuotaRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.UpdateUserQuota: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this volume. | 
 **userId** | **string**|  | 
 **updateQuotaRequest** | [**UpdateQuotaRequest**](UpdateQuotaRequest.md)|  | 

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

<a name="updatevolume"></a>
# **UpdateVolume**
> Volume UpdateVolume (int id, Volume volume)



### Required permissions    * User account permission: `None` (read) / `system:admin-access` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateVolumeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this volume.
            var volume = new Volume(); // Volume | 

            try
            {
                Volume result = apiInstance.UpdateVolume(id, volume);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.UpdateVolume: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this volume. | 
 **volume** | [**Volume**](Volume.md)|  | 

### Return type

[**Volume**](Volume.md)

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

<a name="updateworkspace"></a>
# **UpdateWorkspace**
> WorkspaceDetail UpdateWorkspace (int id, WorkspaceDetail workspaceDetail)



### Required permissions    * User account permission: `None` (read) / `projects:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateWorkspaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this workspace.
            var workspaceDetail = new WorkspaceDetail(); // WorkspaceDetail | 

            try
            {
                WorkspaceDetail result = apiInstance.UpdateWorkspace(id, workspaceDetail);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.UpdateWorkspace: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this workspace. | 
 **workspaceDetail** | [**WorkspaceDetail**](WorkspaceDetail.md)|  | 

### Return type

[**WorkspaceDetail**](WorkspaceDetail.md)

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

<a name="updateworkspacepermission"></a>
# **UpdateWorkspacePermission**
> WorkspacePermission UpdateWorkspacePermission (int id, WorkspacePermission workspacePermission)



### Required permissions    * User account permission: `projects:view` (read) / `projects:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateWorkspacePermissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var id = 56;  // int | A unique integer value identifying this workspace permission.
            var workspacePermission = new WorkspacePermission(); // WorkspacePermission | 

            try
            {
                WorkspacePermission result = apiInstance.UpdateWorkspacePermission(id, workspacePermission);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.UpdateWorkspacePermission: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this workspace permission. | 
 **workspacePermission** | [**WorkspacePermission**](WorkspacePermission.md)|  | 

### Return type

[**WorkspacePermission**](WorkspacePermission.md)

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

<a name="zipfiles"></a>
# **ZipFiles**
> TaskInfo ZipFiles (FileZipEndpointRequest fileZipEndpointRequest)



### Required permissions    * Authenticated user 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class ZipFilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var fileZipEndpointRequest = new FileZipEndpointRequest(); // FileZipEndpointRequest | 

            try
            {
                TaskInfo result = apiInstance.ZipFiles(fileZipEndpointRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.ZipFiles: " + e.Message );
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
 **fileZipEndpointRequest** | [**FileZipEndpointRequest**](FileZipEndpointRequest.md)|  | 

### Return type

[**TaskInfo**](TaskInfo.md)

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

