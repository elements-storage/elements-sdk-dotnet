# ElementsSDK.Api.MainApi

All URIs are relative to *https://elements.local*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplyConfiguration**](MainApi.md#applyconfiguration) | **POST** /api/2/configuration/apply | 
[**Beep**](MainApi.md#beep) | **POST** /api/2/system/beep | 
[**CheckCertificate**](MainApi.md#checkcertificate) | **POST** /api/2/system/certificate/check | 
[**CheckChunkUploaded**](MainApi.md#checkchunkuploaded) | **GET** /api/2/uploads/chunk | 
[**CheckInternetConnectivity**](MainApi.md#checkinternetconnectivity) | **POST** /api/2/system/check-connectivity | 
[**CheckStorNextLicense**](MainApi.md#checkstornextlicense) | **POST** /api/2/stornext-license/check | 
[**CollectDiagnostics**](MainApi.md#collectdiagnostics) | **POST** /api/2/system/collect-diagnostics | 
[**CreateArchive**](MainApi.md#createarchive) | **POST** /api/2/download-archive/create | 
[**CreateGroup**](MainApi.md#creategroup) | **POST** /api/2/groups | 
[**CreateHomeWorkspace**](MainApi.md#createhomeworkspace) | **POST** /api/2/users/{id}/home | 
[**CreateNTPServer**](MainApi.md#createntpserver) | **POST** /api/2/system/time/servers | 
[**CreateUser**](MainApi.md#createuser) | **POST** /api/2/users | 
[**CreateWorkstation**](MainApi.md#createworkstation) | **POST** /api/2/workstations | 
[**DeleteDownloadArchive**](MainApi.md#deletedownloadarchive) | **DELETE** /api/2/download-archive/{id} | 
[**DeleteGroup**](MainApi.md#deletegroup) | **DELETE** /api/2/groups/{id} | 
[**DeleteHomeWorkspace**](MainApi.md#deletehomeworkspace) | **DELETE** /api/2/users/{id}/home | 
[**DeleteNTPServer**](MainApi.md#deletentpserver) | **DELETE** /api/2/system/time/servers/{id} | 
[**DeleteUser**](MainApi.md#deleteuser) | **DELETE** /api/2/users/{id} | 
[**DeleteWorkstation**](MainApi.md#deleteworkstation) | **DELETE** /api/2/workstations/{id} | 
[**DisableUserTOTP**](MainApi.md#disableusertotp) | **DELETE** /api/2/users/{id}/totp | 
[**EnableUserTOTP**](MainApi.md#enableusertotp) | **POST** /api/2/users/{id}/totp | 
[**FinishUpload**](MainApi.md#finishupload) | **POST** /api/2/uploads/finish | 
[**FixLDAPGroupMemberships**](MainApi.md#fixldapgroupmemberships) | **POST** /api/2/ldap-servers/{id}/fix-memberships | 
[**GetAllDownloadArchives**](MainApi.md#getalldownloadarchives) | **GET** /api/2/download-archive | 
[**GetAllDownloads**](MainApi.md#getalldownloads) | **GET** /api/2/downloads | 
[**GetAllGroups**](MainApi.md#getallgroups) | **GET** /api/2/groups | 
[**GetAllLDAPServers**](MainApi.md#getallldapservers) | **GET** /api/2/ldap-servers | 
[**GetAllNTPServers**](MainApi.md#getallntpservers) | **GET** /api/2/system/time/servers | 
[**GetAllStorageNodes**](MainApi.md#getallstoragenodes) | **GET** /api/2/nodes | 
[**GetAllUsers**](MainApi.md#getallusers) | **GET** /api/2/users | 
[**GetAllWorkstations**](MainApi.md#getallworkstations) | **GET** /api/2/workstations | 
[**GetCertificateConfiguration**](MainApi.md#getcertificateconfiguration) | **GET** /api/2/system/certificate | 
[**GetClientDownloadFile**](MainApi.md#getclientdownloadfile) | **GET** /api/2/downloads/clients/{file} | 
[**GetClientDownloads**](MainApi.md#getclientdownloads) | **GET** /api/2/downloads/clients | 
[**GetCurrentWorkstation**](MainApi.md#getcurrentworkstation) | **GET** /api/2/workstations/current | 
[**GetDownload**](MainApi.md#getdownload) | **GET** /api/2/downloads/{id} | 
[**GetDownloadArchive**](MainApi.md#getdownloadarchive) | **GET** /api/2/download-archive/{id} | 
[**GetDownloadArchiveFile**](MainApi.md#getdownloadarchivefile) | **GET** /api/2/download-archive/{id}/download | 
[**GetDownloadFile**](MainApi.md#getdownloadfile) | **GET** /api/2/downloads/{id}/download | 
[**GetDownloadIcon**](MainApi.md#getdownloadicon) | **GET** /api/2/downloads/{id}/icon | 
[**GetGroup**](MainApi.md#getgroup) | **GET** /api/2/groups/{id} | 
[**GetHomeWorkspace**](MainApi.md#gethomeworkspace) | **GET** /api/2/users/{id}/home | 
[**GetIPMIConfiguration**](MainApi.md#getipmiconfiguration) | **GET** /api/2/nodes/{id}/ipmi | 
[**GetLDAPServer**](MainApi.md#getldapserver) | **GET** /api/2/ldap-servers/{id} | 
[**GetLDAPServerGroups**](MainApi.md#getldapservergroups) | **GET** /api/2/ldap-servers/{id}/groups | 
[**GetLDAPServerUsers**](MainApi.md#getldapserverusers) | **GET** /api/2/ldap-servers/{id}/users | 
[**GetLicense**](MainApi.md#getlicense) | **GET** /api/2/license | 
[**GetLocalTime**](MainApi.md#getlocaltime) | **GET** /api/2/system/time | 
[**GetLog**](MainApi.md#getlog) | **GET** /api/2/system/log/{path} | 
[**GetNTPServer**](MainApi.md#getntpserver) | **GET** /api/2/system/time/servers/{id} | 
[**GetNodeIPMISensors**](MainApi.md#getnodeipmisensors) | **GET** /api/2/nodes/{id}/sensors | 
[**GetNodeStats**](MainApi.md#getnodestats) | **GET** /api/2/nodes/{id}/stats | 
[**GetParameters**](MainApi.md#getparameters) | **GET** /api/2/parameters | 
[**GetProfile**](MainApi.md#getprofile) | **GET** /api/2/users/me | 
[**GetReleaseNotes**](MainApi.md#getreleasenotes) | **GET** /api/2/release-notes | 
[**GetSMTPConfiguration**](MainApi.md#getsmtpconfiguration) | **GET** /api/2/system/smtp | 
[**GetServiceStatus**](MainApi.md#getservicestatus) | **GET** /api/2/nodes/{id}/services/{service} | 
[**GetStorNextLicense**](MainApi.md#getstornextlicense) | **GET** /api/2/stornext-license | 
[**GetStorageNode**](MainApi.md#getstoragenode) | **GET** /api/2/nodes/{id} | 
[**GetSystemInfo**](MainApi.md#getsysteminfo) | **GET** /api/2/system/info | 
[**GetUser**](MainApi.md#getuser) | **GET** /api/2/users/{id} | 
[**GetWorkstation**](MainApi.md#getworkstation) | **GET** /api/2/workstations/{id} | 
[**InstallStorNextLicense**](MainApi.md#installstornextlicense) | **POST** /api/2/stornext-license | 
[**PatchCurrentWorkstation**](MainApi.md#patchcurrentworkstation) | **PATCH** /api/2/workstations/current | 
[**PatchDownloadArchive**](MainApi.md#patchdownloadarchive) | **PATCH** /api/2/download-archive/{id} | 
[**PatchGroup**](MainApi.md#patchgroup) | **PATCH** /api/2/groups/{id} | 
[**PatchNTPServer**](MainApi.md#patchntpserver) | **PATCH** /api/2/system/time/servers/{id} | 
[**PatchProfile**](MainApi.md#patchprofile) | **PATCH** /api/2/users/me | 
[**PatchUser**](MainApi.md#patchuser) | **PATCH** /api/2/users/{id} | 
[**PatchWorkstation**](MainApi.md#patchworkstation) | **PATCH** /api/2/workstations/{id} | 
[**PreviewUser**](MainApi.md#previewuser) | **POST** /api/2/users/preview | 
[**Reboot**](MainApi.md#reboot) | **POST** /api/2/system/reboot | 
[**RegisterUpload**](MainApi.md#registerupload) | **POST** /api/2/uploads/register | 
[**RegisterUploadMetadata**](MainApi.md#registeruploadmetadata) | **POST** /api/2/uploads/metadata | 
[**RenderEmailTemplatePreview**](MainApi.md#renderemailtemplatepreview) | **POST** /api/2/system/smtp/preview | 
[**ResetUserPassword**](MainApi.md#resetuserpassword) | **POST** /api/2/users/{id}/password/reset | 
[**RunServiceOperation**](MainApi.md#runserviceoperation) | **POST** /api/2/nodes/{id}/services/{service}/{operation} | 
[**SetIPMIConfiguration**](MainApi.md#setipmiconfiguration) | **PUT** /api/2/nodes/{id}/ipmi | 
[**SetLocalTime**](MainApi.md#setlocaltime) | **POST** /api/2/system/time | 
[**SetMyPassword**](MainApi.md#setmypassword) | **POST** /api/2/users/me/password | 
[**SetUserPassword**](MainApi.md#setuserpassword) | **POST** /api/2/users/{id}/password | 
[**Shutdown**](MainApi.md#shutdown) | **POST** /api/2/system/shutdown | 
[**StartSolrReindex**](MainApi.md#startsolrreindex) | **POST** /api/2/system/solr/reindex | 
[**StartSupportSession**](MainApi.md#startsupportsession) | **POST** /api/2/system/support-session/start | 
[**StartSystemBackup**](MainApi.md#startsystembackup) | **POST** /api/2/system/backup/start | 
[**SyncLDAPGroup**](MainApi.md#syncldapgroup) | **POST** /api/2/groups/{id}/ldap-sync | 
[**SyncLDAPUsers**](MainApi.md#syncldapusers) | **POST** /api/2/ldap-servers/{id}/sync-users | 
[**SyncTime**](MainApi.md#synctime) | **POST** /api/2/system/time/sync | 
[**SyncUserTOTP**](MainApi.md#syncusertotp) | **PUT** /api/2/users/{id}/totp | 
[**TestSMTPConfiguration**](MainApi.md#testsmtpconfiguration) | **POST** /api/2/system/smtp/test | 
[**UpdateCertificateConfiguration**](MainApi.md#updatecertificateconfiguration) | **PUT** /api/2/system/certificate | 
[**UpdateCurrentWorkstation**](MainApi.md#updatecurrentworkstation) | **PUT** /api/2/workstations/current | 
[**UpdateDownloadArchive**](MainApi.md#updatedownloadarchive) | **PUT** /api/2/download-archive/{id} | 
[**UpdateGroup**](MainApi.md#updategroup) | **PUT** /api/2/groups/{id} | 
[**UpdateNTPServer**](MainApi.md#updatentpserver) | **PUT** /api/2/system/time/servers/{id} | 
[**UpdateParameters**](MainApi.md#updateparameters) | **PUT** /api/2/parameters | 
[**UpdateProfile**](MainApi.md#updateprofile) | **PUT** /api/2/users/me | 
[**UpdateSMTPConfiguration**](MainApi.md#updatesmtpconfiguration) | **PUT** /api/2/system/smtp | 
[**UpdateUser**](MainApi.md#updateuser) | **PUT** /api/2/users/{id} | 
[**UpdateWorkstation**](MainApi.md#updateworkstation) | **PUT** /api/2/workstations/{id} | 
[**UploadChunk**](MainApi.md#uploadchunk) | **POST** /api/2/uploads/chunk | 


<a name="applyconfiguration"></a>
# **ApplyConfiguration**
> void ApplyConfiguration ()



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
    public class ApplyConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);

            try
            {
                apiInstance.ApplyConfiguration();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.ApplyConfiguration: " + e.Message );
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

<a name="beep"></a>
# **Beep**
> void Beep ()



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
    public class BeepExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);

            try
            {
                apiInstance.Beep();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.Beep: " + e.Message );
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

<a name="checkcertificate"></a>
# **CheckCertificate**
> void CheckCertificate (Certificate certificate)



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
    public class CheckCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var certificate = new Certificate(); // Certificate | 

            try
            {
                apiInstance.CheckCertificate(certificate);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.CheckCertificate: " + e.Message );
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
 **certificate** | [**Certificate**](Certificate.md)|  | 

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

<a name="checkchunkuploaded"></a>
# **CheckChunkUploaded**
> void CheckChunkUploaded (string uploadId = null, string chunkNumber = null)



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
    public class CheckChunkUploadedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var uploadId = uploadId_example;  // string |  (optional) 
            var chunkNumber = chunkNumber_example;  // string |  (optional) 

            try
            {
                apiInstance.CheckChunkUploaded(uploadId, chunkNumber);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.CheckChunkUploaded: " + e.Message );
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
 **uploadId** | **string**|  | [optional] 
 **chunkNumber** | **string**|  | [optional] 

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

<a name="checkinternetconnectivity"></a>
# **CheckInternetConnectivity**
> CheckConnectivityEndpointResponse CheckInternetConnectivity ()



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
    public class CheckInternetConnectivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);

            try
            {
                CheckConnectivityEndpointResponse result = apiInstance.CheckInternetConnectivity();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.CheckInternetConnectivity: " + e.Message );
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

[**CheckConnectivityEndpointResponse**](CheckConnectivityEndpointResponse.md)

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

<a name="checkstornextlicense"></a>
# **CheckStorNextLicense**
> List&lt;StorNextLicenseCheckEndpointResponse&gt; CheckStorNextLicense (StornextLicense stornextLicense)



### Required permissions    * User account permission: `system:admin-access`   * License component: stornext_mdc 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CheckStorNextLicenseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var stornextLicense = new StornextLicense(); // StornextLicense | 

            try
            {
                List<StorNextLicenseCheckEndpointResponse> result = apiInstance.CheckStorNextLicense(stornextLicense);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.CheckStorNextLicense: " + e.Message );
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
 **stornextLicense** | [**StornextLicense**](StornextLicense.md)|  | 

### Return type

[**List&lt;StorNextLicenseCheckEndpointResponse&gt;**](StorNextLicenseCheckEndpointResponse.md)

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

<a name="collectdiagnostics"></a>
# **CollectDiagnostics**
> DownloadArchive CollectDiagnostics ()



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
    public class CollectDiagnosticsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);

            try
            {
                DownloadArchive result = apiInstance.CollectDiagnostics();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.CollectDiagnostics: " + e.Message );
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

[**DownloadArchive**](DownloadArchive.md)

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

<a name="createarchive"></a>
# **CreateArchive**
> DownloadArchive CreateArchive (CreateDownloadArchive createDownloadArchive)



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
    public class CreateArchiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var createDownloadArchive = new CreateDownloadArchive(); // CreateDownloadArchive | 

            try
            {
                DownloadArchive result = apiInstance.CreateArchive(createDownloadArchive);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.CreateArchive: " + e.Message );
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
 **createDownloadArchive** | [**CreateDownloadArchive**](CreateDownloadArchive.md)|  | 

### Return type

[**DownloadArchive**](DownloadArchive.md)

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

<a name="creategroup"></a>
# **CreateGroup**
> ElementsGroupDetail CreateGroup (ElementsGroupDetail elementsGroupDetail)



### Required permissions    * User account permission: `users:view` (read) / `users:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var elementsGroupDetail = new ElementsGroupDetail(); // ElementsGroupDetail | 

            try
            {
                ElementsGroupDetail result = apiInstance.CreateGroup(elementsGroupDetail);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.CreateGroup: " + e.Message );
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
 **elementsGroupDetail** | [**ElementsGroupDetail**](ElementsGroupDetail.md)|  | 

### Return type

[**ElementsGroupDetail**](ElementsGroupDetail.md)

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

<a name="createhomeworkspace"></a>
# **CreateHomeWorkspace**
> Workspace CreateHomeWorkspace (int id, CreateHomeWorkspaceRequest createHomeWorkspaceRequest)



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
    public class CreateHomeWorkspaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this User.
            var createHomeWorkspaceRequest = new CreateHomeWorkspaceRequest(); // CreateHomeWorkspaceRequest | 

            try
            {
                Workspace result = apiInstance.CreateHomeWorkspace(id, createHomeWorkspaceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.CreateHomeWorkspace: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this User. | 
 **createHomeWorkspaceRequest** | [**CreateHomeWorkspaceRequest**](CreateHomeWorkspaceRequest.md)|  | 

### Return type

[**Workspace**](Workspace.md)

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

<a name="createntpserver"></a>
# **CreateNTPServer**
> NTPServer CreateNTPServer (NTPServer nTPServer)



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
    public class CreateNTPServerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var nTPServer = new NTPServer(); // NTPServer | 

            try
            {
                NTPServer result = apiInstance.CreateNTPServer(nTPServer);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.CreateNTPServer: " + e.Message );
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
 **nTPServer** | [**NTPServer**](NTPServer.md)|  | 

### Return type

[**NTPServer**](NTPServer.md)

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

<a name="createuser"></a>
# **CreateUser**
> ElementsUserDetail CreateUser (ElementsUserDetail elementsUserDetail)



### Required permissions    * User account permission: `None` (read) / `users:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var elementsUserDetail = new ElementsUserDetail(); // ElementsUserDetail | 

            try
            {
                ElementsUserDetail result = apiInstance.CreateUser(elementsUserDetail);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.CreateUser: " + e.Message );
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
 **elementsUserDetail** | [**ElementsUserDetail**](ElementsUserDetail.md)|  | 

### Return type

[**ElementsUserDetail**](ElementsUserDetail.md)

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

<a name="createworkstation"></a>
# **CreateWorkstation**
> Workstation CreateWorkstation (Workstation workstation)



### Required permissions    * Authenticated user   * Own workstation or User account permission: `workstations:view` (read) / `workstations:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateWorkstationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var workstation = new Workstation(); // Workstation | 

            try
            {
                Workstation result = apiInstance.CreateWorkstation(workstation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.CreateWorkstation: " + e.Message );
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
 **workstation** | [**Workstation**](Workstation.md)|  | 

### Return type

[**Workstation**](Workstation.md)

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

<a name="deletedownloadarchive"></a>
# **DeleteDownloadArchive**
> void DeleteDownloadArchive (Guid id)



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
    public class DeleteDownloadArchiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = new Guid(); // Guid | A UUID string identifying this download archive.

            try
            {
                apiInstance.DeleteDownloadArchive(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.DeleteDownloadArchive: " + e.Message );
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
 **id** | [**Guid**](Guid.md)| A UUID string identifying this download archive. | 

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

<a name="deletegroup"></a>
# **DeleteGroup**
> void DeleteGroup (int id)



### Required permissions    * User account permission: `users:view` (read) / `users:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this Group.

            try
            {
                apiInstance.DeleteGroup(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.DeleteGroup: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Group. | 

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

<a name="deletehomeworkspace"></a>
# **DeleteHomeWorkspace**
> void DeleteHomeWorkspace (int id)



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
    public class DeleteHomeWorkspaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this User.

            try
            {
                apiInstance.DeleteHomeWorkspace(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.DeleteHomeWorkspace: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this User. | 

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

<a name="deletentpserver"></a>
# **DeleteNTPServer**
> void DeleteNTPServer (int id)



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
    public class DeleteNTPServerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this NTP Server.

            try
            {
                apiInstance.DeleteNTPServer(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.DeleteNTPServer: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this NTP Server. | 

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

<a name="deleteuser"></a>
# **DeleteUser**
> void DeleteUser (int id)



### Required permissions    * User account permission: `None` (read) / `users:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this User.

            try
            {
                apiInstance.DeleteUser(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.DeleteUser: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this User. | 

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

<a name="deleteworkstation"></a>
# **DeleteWorkstation**
> void DeleteWorkstation (string id)



### Required permissions    * Authenticated user   * Own workstation or User account permission: `workstations:view` (read) / `workstations:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteWorkstationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = id_example;  // string | A unique value identifying this workstation.

            try
            {
                apiInstance.DeleteWorkstation(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.DeleteWorkstation: " + e.Message );
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
 **id** | **string**| A unique value identifying this workstation. | 

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

<a name="disableusertotp"></a>
# **DisableUserTOTP**
> void DisableUserTOTP (int id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DisableUserTOTPExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this User.

            try
            {
                apiInstance.DisableUserTOTP(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.DisableUserTOTP: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this User. | 

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

<a name="enableusertotp"></a>
# **EnableUserTOTP**
> void EnableUserTOTP (int id, EnableTOTPRequest enableTOTPRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class EnableUserTOTPExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this User.
            var enableTOTPRequest = new EnableTOTPRequest(); // EnableTOTPRequest | 

            try
            {
                apiInstance.EnableUserTOTP(id, enableTOTPRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.EnableUserTOTP: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this User. | 
 **enableTOTPRequest** | [**EnableTOTPRequest**](EnableTOTPRequest.md)|  | 

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

<a name="finishupload"></a>
# **FinishUpload**
> void FinishUpload (FinishUploadEndpointRequest finishUploadEndpointRequest)



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
    public class FinishUploadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var finishUploadEndpointRequest = new FinishUploadEndpointRequest(); // FinishUploadEndpointRequest | 

            try
            {
                apiInstance.FinishUpload(finishUploadEndpointRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.FinishUpload: " + e.Message );
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
 **finishUploadEndpointRequest** | [**FinishUploadEndpointRequest**](FinishUploadEndpointRequest.md)|  | 

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

<a name="fixldapgroupmemberships"></a>
# **FixLDAPGroupMemberships**
> void FixLDAPGroupMemberships (int id)



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
    public class FixLDAPGroupMembershipsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this LDAP Server.

            try
            {
                apiInstance.FixLDAPGroupMemberships(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.FixLDAPGroupMemberships: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this LDAP Server. | 

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

<a name="getalldownloadarchives"></a>
# **GetAllDownloadArchives**
> List&lt;DownloadArchive&gt; GetAllDownloadArchives (string ordering = null, int? limit = null, int? offset = null)



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
    public class GetAllDownloadArchivesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<DownloadArchive> result = apiInstance.GetAllDownloadArchives(ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetAllDownloadArchives: " + e.Message );
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

[**List&lt;DownloadArchive&gt;**](DownloadArchive.md)

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

<a name="getalldownloads"></a>
# **GetAllDownloads**
> List&lt;Download&gt; GetAllDownloads (string name = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `downloads:view` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllDownloadsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<Download> result = apiInstance.GetAllDownloads(name, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetAllDownloads: " + e.Message );
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
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;Download&gt;**](Download.md)

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

<a name="getallgroups"></a>
# **GetAllGroups**
> List&lt;ElementsGroup&gt; GetAllGroups (string name = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `users:view` (read) / `users:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<ElementsGroup> result = apiInstance.GetAllGroups(name, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetAllGroups: " + e.Message );
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
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;ElementsGroup&gt;**](ElementsGroup.md)

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

<a name="getallldapservers"></a>
# **GetAllLDAPServers**
> List&lt;LDAPServer&gt; GetAllLDAPServers (string ordering = null, int? limit = null, int? offset = null)



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
    public class GetAllLDAPServersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<LDAPServer> result = apiInstance.GetAllLDAPServers(ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetAllLDAPServers: " + e.Message );
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

[**List&lt;LDAPServer&gt;**](LDAPServer.md)

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

<a name="getallntpservers"></a>
# **GetAllNTPServers**
> List&lt;NTPServer&gt; GetAllNTPServers (string address = null, string ordering = null, int? limit = null, int? offset = null)



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
    public class GetAllNTPServersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var address = address_example;  // string | Filter the returned list by `address`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<NTPServer> result = apiInstance.GetAllNTPServers(address, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetAllNTPServers: " + e.Message );
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
 **address** | **string**| Filter the returned list by &#x60;address&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;NTPServer&gt;**](NTPServer.md)

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

<a name="getallstoragenodes"></a>
# **GetAllStorageNodes**
> List&lt;StorageNode&gt; GetAllStorageNodes (string type = null, string backend = null, string name = null, string address = null, string ordering = null, int? limit = null, int? offset = null, bool? includeStatus = null)



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
    public class GetAllStorageNodesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var type = type_example;  // string | Filter the returned list by `type`. (optional) 
            var backend = backend_example;  // string | Filter the returned list by `backend`. (optional) 
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var address = address_example;  // string | Filter the returned list by `address`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 
            var includeStatus = true;  // bool? |  (optional) 

            try
            {
                List<StorageNode> result = apiInstance.GetAllStorageNodes(type, backend, name, address, ordering, limit, offset, includeStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetAllStorageNodes: " + e.Message );
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
 **type** | **string**| Filter the returned list by &#x60;type&#x60;. | [optional] 
 **backend** | **string**| Filter the returned list by &#x60;backend&#x60;. | [optional] 
 **name** | **string**| Filter the returned list by &#x60;name&#x60;. | [optional] 
 **address** | **string**| Filter the returned list by &#x60;address&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 
 **includeStatus** | **bool?**|  | [optional] 

### Return type

[**List&lt;StorageNode&gt;**](StorageNode.md)

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

<a name="getallusers"></a>
# **GetAllUsers**
> List&lt;ElementsUser&gt; GetAllUsers (string username = null, string home = null, string fullName = null, string ordering = null, int? limit = null, int? offset = null, bool? includeAllowedFsPaths = null, bool? includeClientSessions = null)



### Required permissions    * User account permission: `None` (read) / `users:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var username = username_example;  // string | Filter the returned list by `username`. (optional) 
            var home = home_example;  // string | Filter the returned list by `home`. (optional) 
            var fullName = fullName_example;  // string | Filter the returned list by `full_name`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 
            var includeAllowedFsPaths = true;  // bool? |  (optional) 
            var includeClientSessions = true;  // bool? |  (optional) 

            try
            {
                List<ElementsUser> result = apiInstance.GetAllUsers(username, home, fullName, ordering, limit, offset, includeAllowedFsPaths, includeClientSessions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetAllUsers: " + e.Message );
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
 **username** | **string**| Filter the returned list by &#x60;username&#x60;. | [optional] 
 **home** | **string**| Filter the returned list by &#x60;home&#x60;. | [optional] 
 **fullName** | **string**| Filter the returned list by &#x60;full_name&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 
 **includeAllowedFsPaths** | **bool?**|  | [optional] 
 **includeClientSessions** | **bool?**|  | [optional] 

### Return type

[**List&lt;ElementsUser&gt;**](ElementsUser.md)

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

<a name="getallworkstations"></a>
# **GetAllWorkstations**
> List&lt;Workstation&gt; GetAllWorkstations (string hostname = null, string name = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * Authenticated user   * Own workstation or User account permission: `workstations:view` (read) / `workstations:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllWorkstationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var hostname = hostname_example;  // string | Filter the returned list by `hostname`. (optional) 
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<Workstation> result = apiInstance.GetAllWorkstations(hostname, name, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetAllWorkstations: " + e.Message );
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
 **hostname** | **string**| Filter the returned list by &#x60;hostname&#x60;. | [optional] 
 **name** | **string**| Filter the returned list by &#x60;name&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;Workstation&gt;**](Workstation.md)

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

<a name="getcertificateconfiguration"></a>
# **GetCertificateConfiguration**
> Certificate GetCertificateConfiguration ()



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
    public class GetCertificateConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);

            try
            {
                Certificate result = apiInstance.GetCertificateConfiguration();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetCertificateConfiguration: " + e.Message );
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

[**Certificate**](Certificate.md)

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

<a name="getclientdownloadfile"></a>
# **GetClientDownloadFile**
> void GetClientDownloadFile (string file)



### Required permissions    * <class 'rest_framework.permissions.AllowAny'> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetClientDownloadFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var file = file_example;  // string | 

            try
            {
                apiInstance.GetClientDownloadFile(file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetClientDownloadFile: " + e.Message );
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
 **file** | **string**|  | 

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

<a name="getclientdownloads"></a>
# **GetClientDownloads**
> List&lt;ClientsEndpointResponse&gt; GetClientDownloads ()



### Required permissions    * <class 'rest_framework.permissions.AllowAny'> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetClientDownloadsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);

            try
            {
                List<ClientsEndpointResponse> result = apiInstance.GetClientDownloads();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetClientDownloads: " + e.Message );
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

[**List&lt;ClientsEndpointResponse&gt;**](ClientsEndpointResponse.md)

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

<a name="getcurrentworkstation"></a>
# **GetCurrentWorkstation**
> Workstation GetCurrentWorkstation (string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * <class 'rest_framework.permissions.AllowAny'> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetCurrentWorkstationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                Workstation result = apiInstance.GetCurrentWorkstation(ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetCurrentWorkstation: " + e.Message );
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

[**Workstation**](Workstation.md)

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

<a name="getdownload"></a>
# **GetDownload**
> Download GetDownload (int id)



### Required permissions    * User account permission: `downloads:view` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetDownloadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this download.

            try
            {
                Download result = apiInstance.GetDownload(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetDownload: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this download. | 

### Return type

[**Download**](Download.md)

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

<a name="getdownloadarchive"></a>
# **GetDownloadArchive**
> DownloadArchive GetDownloadArchive (Guid id)



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
    public class GetDownloadArchiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = new Guid(); // Guid | A UUID string identifying this download archive.

            try
            {
                DownloadArchive result = apiInstance.GetDownloadArchive(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetDownloadArchive: " + e.Message );
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
 **id** | [**Guid**](Guid.md)| A UUID string identifying this download archive. | 

### Return type

[**DownloadArchive**](DownloadArchive.md)

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

<a name="getdownloadarchivefile"></a>
# **GetDownloadArchiveFile**
> void GetDownloadArchiveFile (Guid id)



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
    public class GetDownloadArchiveFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = new Guid(); // Guid | A UUID string identifying this download archive.

            try
            {
                apiInstance.GetDownloadArchiveFile(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetDownloadArchiveFile: " + e.Message );
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
 **id** | [**Guid**](Guid.md)| A UUID string identifying this download archive. | 

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

<a name="getdownloadfile"></a>
# **GetDownloadFile**
> void GetDownloadFile (int id)



### Required permissions    * User account permission: `downloads:view` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetDownloadFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this download.

            try
            {
                apiInstance.GetDownloadFile(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetDownloadFile: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this download. | 

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

<a name="getdownloadicon"></a>
# **GetDownloadIcon**
> void GetDownloadIcon (int id)



### Required permissions    * User account permission: `downloads:view` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetDownloadIconExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this download.

            try
            {
                apiInstance.GetDownloadIcon(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetDownloadIcon: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this download. | 

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

<a name="getgroup"></a>
# **GetGroup**
> ElementsGroupDetail GetGroup (int id)



### Required permissions    * User account permission: `users:view` (read) / `users:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this Group.

            try
            {
                ElementsGroupDetail result = apiInstance.GetGroup(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetGroup: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Group. | 

### Return type

[**ElementsGroupDetail**](ElementsGroupDetail.md)

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

<a name="gethomeworkspace"></a>
# **GetHomeWorkspace**
> Workspace GetHomeWorkspace (int id)



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
    public class GetHomeWorkspaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this User.

            try
            {
                Workspace result = apiInstance.GetHomeWorkspace(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetHomeWorkspace: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this User. | 

### Return type

[**Workspace**](Workspace.md)

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

<a name="getipmiconfiguration"></a>
# **GetIPMIConfiguration**
> Ipmi GetIPMIConfiguration (int id)



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
    public class GetIPMIConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this Storage Node.

            try
            {
                Ipmi result = apiInstance.GetIPMIConfiguration(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetIPMIConfiguration: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Storage Node. | 

### Return type

[**Ipmi**](Ipmi.md)

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

<a name="getldapserver"></a>
# **GetLDAPServer**
> LDAPServer GetLDAPServer (int id)



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
    public class GetLDAPServerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this LDAP Server.

            try
            {
                LDAPServer result = apiInstance.GetLDAPServer(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetLDAPServer: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this LDAP Server. | 

### Return type

[**LDAPServer**](LDAPServer.md)

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

<a name="getldapservergroups"></a>
# **GetLDAPServerGroups**
> LDAPServerGroups GetLDAPServerGroups (int id)



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
    public class GetLDAPServerGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this LDAP Server.

            try
            {
                LDAPServerGroups result = apiInstance.GetLDAPServerGroups(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetLDAPServerGroups: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this LDAP Server. | 

### Return type

[**LDAPServerGroups**](LDAPServerGroups.md)

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

<a name="getldapserverusers"></a>
# **GetLDAPServerUsers**
> LDAPServerUsers GetLDAPServerUsers (int id)



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
    public class GetLDAPServerUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this LDAP Server.

            try
            {
                LDAPServerUsers result = apiInstance.GetLDAPServerUsers(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetLDAPServerUsers: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this LDAP Server. | 

### Return type

[**LDAPServerUsers**](LDAPServerUsers.md)

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

<a name="getlicense"></a>
# **GetLicense**
> License GetLicense ()



### Required permissions    * <class 'rest_framework.permissions.AllowAny'> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetLicenseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);

            try
            {
                License result = apiInstance.GetLicense();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetLicense: " + e.Message );
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

[**License**](License.md)

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

<a name="getlocaltime"></a>
# **GetLocalTime**
> TimeEndpointResponse GetLocalTime ()



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
    public class GetLocalTimeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);

            try
            {
                TimeEndpointResponse result = apiInstance.GetLocalTime();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetLocalTime: " + e.Message );
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

[**TimeEndpointResponse**](TimeEndpointResponse.md)

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

<a name="getlog"></a>
# **GetLog**
> void GetLog (string path, int? offset = null)



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
    public class GetLogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var path = path_example;  // string | 
            var offset = 56;  // int? |  (optional) 

            try
            {
                apiInstance.GetLog(path, offset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetLog: " + e.Message );
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
 **offset** | **int?**|  | [optional] 

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

<a name="getntpserver"></a>
# **GetNTPServer**
> NTPServer GetNTPServer (int id)



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
    public class GetNTPServerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this NTP Server.

            try
            {
                NTPServer result = apiInstance.GetNTPServer(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetNTPServer: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this NTP Server. | 

### Return type

[**NTPServer**](NTPServer.md)

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

<a name="getnodeipmisensors"></a>
# **GetNodeIPMISensors**
> Sensors GetNodeIPMISensors (int id)



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
    public class GetNodeIPMISensorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this Storage Node.

            try
            {
                Sensors result = apiInstance.GetNodeIPMISensors(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetNodeIPMISensors: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Storage Node. | 

### Return type

[**Sensors**](Sensors.md)

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

<a name="getnodestats"></a>
# **GetNodeStats**
> Stats GetNodeStats (int id)



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
    public class GetNodeStatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this Storage Node.

            try
            {
                Stats result = apiInstance.GetNodeStats(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetNodeStats: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Storage Node. | 

### Return type

[**Stats**](Stats.md)

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

<a name="getparameters"></a>
# **GetParameters**
> Parameters GetParameters (string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * <class 'rest_framework.permissions.AllowAny'> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetParametersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                Parameters result = apiInstance.GetParameters(ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetParameters: " + e.Message );
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

[**Parameters**](Parameters.md)

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

<a name="getprofile"></a>
# **GetProfile**
> ElementsUserProfile GetProfile (string ordering = null, int? limit = null, int? offset = null)



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
    public class GetProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                ElementsUserProfile result = apiInstance.GetProfile(ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetProfile: " + e.Message );
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

[**ElementsUserProfile**](ElementsUserProfile.md)

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

<a name="getreleasenotes"></a>
# **GetReleaseNotes**
> List&lt;ReleaseNotesEndpointResponse&gt; GetReleaseNotes ()



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
    public class GetReleaseNotesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);

            try
            {
                List<ReleaseNotesEndpointResponse> result = apiInstance.GetReleaseNotes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetReleaseNotes: " + e.Message );
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

[**List&lt;ReleaseNotesEndpointResponse&gt;**](ReleaseNotesEndpointResponse.md)

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

<a name="getsmtpconfiguration"></a>
# **GetSMTPConfiguration**
> SMTPConfiguration GetSMTPConfiguration ()



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
    public class GetSMTPConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);

            try
            {
                SMTPConfiguration result = apiInstance.GetSMTPConfiguration();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetSMTPConfiguration: " + e.Message );
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

[**SMTPConfiguration**](SMTPConfiguration.md)

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

<a name="getservicestatus"></a>
# **GetServiceStatus**
> ServiceStatus GetServiceStatus (int id, string service)



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
    public class GetServiceStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this Storage Node.
            var service = service_example;  // string | 

            try
            {
                ServiceStatus result = apiInstance.GetServiceStatus(id, service);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetServiceStatus: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Storage Node. | 
 **service** | **string**|  | 

### Return type

[**ServiceStatus**](ServiceStatus.md)

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

<a name="getstornextlicense"></a>
# **GetStorNextLicense**
> StorNextLicenseEndpointResponse GetStorNextLicense ()



### Required permissions    * User account permission: `system:admin-access`   * License component: stornext_mdc 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetStorNextLicenseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);

            try
            {
                StorNextLicenseEndpointResponse result = apiInstance.GetStorNextLicense();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetStorNextLicense: " + e.Message );
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

[**StorNextLicenseEndpointResponse**](StorNextLicenseEndpointResponse.md)

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

<a name="getstoragenode"></a>
# **GetStorageNode**
> StorageNode GetStorageNode (int id, bool? includeStatus = null)



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
    public class GetStorageNodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this Storage Node.
            var includeStatus = true;  // bool? |  (optional) 

            try
            {
                StorageNode result = apiInstance.GetStorageNode(id, includeStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetStorageNode: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Storage Node. | 
 **includeStatus** | **bool?**|  | [optional] 

### Return type

[**StorageNode**](StorageNode.md)

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

<a name="getsysteminfo"></a>
# **GetSystemInfo**
> SystemInfoEndpointResponse GetSystemInfo ()



### Required permissions    * <class 'rest_framework.permissions.AllowAny'> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetSystemInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);

            try
            {
                SystemInfoEndpointResponse result = apiInstance.GetSystemInfo();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetSystemInfo: " + e.Message );
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

[**SystemInfoEndpointResponse**](SystemInfoEndpointResponse.md)

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

<a name="getuser"></a>
# **GetUser**
> ElementsUserDetail GetUser (int id)



### Required permissions    * User account permission: `None` (read) / `users:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this User.

            try
            {
                ElementsUserDetail result = apiInstance.GetUser(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetUser: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this User. | 

### Return type

[**ElementsUserDetail**](ElementsUserDetail.md)

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

<a name="getworkstation"></a>
# **GetWorkstation**
> Workstation GetWorkstation (string id)



### Required permissions    * Authenticated user   * Own workstation or User account permission: `workstations:view` (read) / `workstations:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetWorkstationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = id_example;  // string | A unique value identifying this workstation.

            try
            {
                Workstation result = apiInstance.GetWorkstation(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.GetWorkstation: " + e.Message );
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
 **id** | **string**| A unique value identifying this workstation. | 

### Return type

[**Workstation**](Workstation.md)

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

<a name="installstornextlicense"></a>
# **InstallStorNextLicense**
> StorNextLicenseEndpointResponse InstallStorNextLicense (StornextLicense stornextLicense)



### Required permissions    * User account permission: `system:admin-access`   * License component: stornext_mdc 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class InstallStorNextLicenseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var stornextLicense = new StornextLicense(); // StornextLicense | 

            try
            {
                StorNextLicenseEndpointResponse result = apiInstance.InstallStorNextLicense(stornextLicense);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.InstallStorNextLicense: " + e.Message );
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
 **stornextLicense** | [**StornextLicense**](StornextLicense.md)|  | 

### Return type

[**StorNextLicenseEndpointResponse**](StorNextLicenseEndpointResponse.md)

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

<a name="patchcurrentworkstation"></a>
# **PatchCurrentWorkstation**
> Workstation PatchCurrentWorkstation (WorkstationPartialUpdate workstationPartialUpdate)



### Required permissions    * <class 'rest_framework.permissions.AllowAny'> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchCurrentWorkstationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var workstationPartialUpdate = new WorkstationPartialUpdate(); // WorkstationPartialUpdate | 

            try
            {
                Workstation result = apiInstance.PatchCurrentWorkstation(workstationPartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.PatchCurrentWorkstation: " + e.Message );
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
 **workstationPartialUpdate** | [**WorkstationPartialUpdate**](WorkstationPartialUpdate.md)|  | 

### Return type

[**Workstation**](Workstation.md)

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

<a name="patchdownloadarchive"></a>
# **PatchDownloadArchive**
> DownloadArchive PatchDownloadArchive (Guid id, DownloadArchivePartialUpdate downloadArchivePartialUpdate)



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
    public class PatchDownloadArchiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = new Guid(); // Guid | A UUID string identifying this download archive.
            var downloadArchivePartialUpdate = new DownloadArchivePartialUpdate(); // DownloadArchivePartialUpdate | 

            try
            {
                DownloadArchive result = apiInstance.PatchDownloadArchive(id, downloadArchivePartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.PatchDownloadArchive: " + e.Message );
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
 **id** | [**Guid**](Guid.md)| A UUID string identifying this download archive. | 
 **downloadArchivePartialUpdate** | [**DownloadArchivePartialUpdate**](DownloadArchivePartialUpdate.md)|  | 

### Return type

[**DownloadArchive**](DownloadArchive.md)

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

<a name="patchgroup"></a>
# **PatchGroup**
> ElementsGroupDetail PatchGroup (int id, ElementsGroupDetailPartialUpdate elementsGroupDetailPartialUpdate)



### Required permissions    * User account permission: `users:view` (read) / `users:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this Group.
            var elementsGroupDetailPartialUpdate = new ElementsGroupDetailPartialUpdate(); // ElementsGroupDetailPartialUpdate | 

            try
            {
                ElementsGroupDetail result = apiInstance.PatchGroup(id, elementsGroupDetailPartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.PatchGroup: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Group. | 
 **elementsGroupDetailPartialUpdate** | [**ElementsGroupDetailPartialUpdate**](ElementsGroupDetailPartialUpdate.md)|  | 

### Return type

[**ElementsGroupDetail**](ElementsGroupDetail.md)

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

<a name="patchntpserver"></a>
# **PatchNTPServer**
> NTPServer PatchNTPServer (int id, NTPServerPartialUpdate nTPServerPartialUpdate)



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
    public class PatchNTPServerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this NTP Server.
            var nTPServerPartialUpdate = new NTPServerPartialUpdate(); // NTPServerPartialUpdate | 

            try
            {
                NTPServer result = apiInstance.PatchNTPServer(id, nTPServerPartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.PatchNTPServer: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this NTP Server. | 
 **nTPServerPartialUpdate** | [**NTPServerPartialUpdate**](NTPServerPartialUpdate.md)|  | 

### Return type

[**NTPServer**](NTPServer.md)

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

<a name="patchprofile"></a>
# **PatchProfile**
> ElementsUserProfile PatchProfile (ElementsUserProfilePartialUpdate elementsUserProfilePartialUpdate)



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
    public class PatchProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var elementsUserProfilePartialUpdate = new ElementsUserProfilePartialUpdate(); // ElementsUserProfilePartialUpdate | 

            try
            {
                ElementsUserProfile result = apiInstance.PatchProfile(elementsUserProfilePartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.PatchProfile: " + e.Message );
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
 **elementsUserProfilePartialUpdate** | [**ElementsUserProfilePartialUpdate**](ElementsUserProfilePartialUpdate.md)|  | 

### Return type

[**ElementsUserProfile**](ElementsUserProfile.md)

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

<a name="patchuser"></a>
# **PatchUser**
> ElementsUserDetail PatchUser (int id, ElementsUserDetailPartialUpdate elementsUserDetailPartialUpdate)



### Required permissions    * User account permission: `None` (read) / `users:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this User.
            var elementsUserDetailPartialUpdate = new ElementsUserDetailPartialUpdate(); // ElementsUserDetailPartialUpdate | 

            try
            {
                ElementsUserDetail result = apiInstance.PatchUser(id, elementsUserDetailPartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.PatchUser: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this User. | 
 **elementsUserDetailPartialUpdate** | [**ElementsUserDetailPartialUpdate**](ElementsUserDetailPartialUpdate.md)|  | 

### Return type

[**ElementsUserDetail**](ElementsUserDetail.md)

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

<a name="patchworkstation"></a>
# **PatchWorkstation**
> Workstation PatchWorkstation (string id, WorkstationPartialUpdate workstationPartialUpdate)



### Required permissions    * Authenticated user   * Own workstation or User account permission: `workstations:view` (read) / `workstations:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchWorkstationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = id_example;  // string | A unique value identifying this workstation.
            var workstationPartialUpdate = new WorkstationPartialUpdate(); // WorkstationPartialUpdate | 

            try
            {
                Workstation result = apiInstance.PatchWorkstation(id, workstationPartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.PatchWorkstation: " + e.Message );
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
 **id** | **string**| A unique value identifying this workstation. | 
 **workstationPartialUpdate** | [**WorkstationPartialUpdate**](WorkstationPartialUpdate.md)|  | 

### Return type

[**Workstation**](Workstation.md)

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

<a name="previewuser"></a>
# **PreviewUser**
> UserPreviewResponse PreviewUser (UserPreviewRequest userPreviewRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PreviewUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var userPreviewRequest = new UserPreviewRequest(); // UserPreviewRequest | 

            try
            {
                UserPreviewResponse result = apiInstance.PreviewUser(userPreviewRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.PreviewUser: " + e.Message );
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
 **userPreviewRequest** | [**UserPreviewRequest**](UserPreviewRequest.md)|  | 

### Return type

[**UserPreviewResponse**](UserPreviewResponse.md)

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

<a name="reboot"></a>
# **Reboot**
> void Reboot ()



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
    public class RebootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);

            try
            {
                apiInstance.Reboot();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.Reboot: " + e.Message );
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

<a name="registerupload"></a>
# **RegisterUpload**
> void RegisterUpload (RegisterUploadEndpointRequest registerUploadEndpointRequest)



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
    public class RegisterUploadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var registerUploadEndpointRequest = new RegisterUploadEndpointRequest(); // RegisterUploadEndpointRequest | 

            try
            {
                apiInstance.RegisterUpload(registerUploadEndpointRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.RegisterUpload: " + e.Message );
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
 **registerUploadEndpointRequest** | [**RegisterUploadEndpointRequest**](RegisterUploadEndpointRequest.md)|  | 

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

<a name="registeruploadmetadata"></a>
# **RegisterUploadMetadata**
> void RegisterUploadMetadata (RegisterUploadMetadataEndpointRequest registerUploadMetadataEndpointRequest)



### Required permissions    * User account permission: `media:access` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class RegisterUploadMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var registerUploadMetadataEndpointRequest = new RegisterUploadMetadataEndpointRequest(); // RegisterUploadMetadataEndpointRequest | 

            try
            {
                apiInstance.RegisterUploadMetadata(registerUploadMetadataEndpointRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.RegisterUploadMetadata: " + e.Message );
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
 **registerUploadMetadataEndpointRequest** | [**RegisterUploadMetadataEndpointRequest**](RegisterUploadMetadataEndpointRequest.md)|  | 

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

<a name="renderemailtemplatepreview"></a>
# **RenderEmailTemplatePreview**
> void RenderEmailTemplatePreview (EmailPreview emailPreview)



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
    public class RenderEmailTemplatePreviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var emailPreview = new EmailPreview(); // EmailPreview | 

            try
            {
                apiInstance.RenderEmailTemplatePreview(emailPreview);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.RenderEmailTemplatePreview: " + e.Message );
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
 **emailPreview** | [**EmailPreview**](EmailPreview.md)|  | 

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

<a name="resetuserpassword"></a>
# **ResetUserPassword**
> void ResetUserPassword (int id)



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
    public class ResetUserPasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this User.

            try
            {
                apiInstance.ResetUserPassword(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.ResetUserPassword: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this User. | 

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

<a name="runserviceoperation"></a>
# **RunServiceOperation**
> void RunServiceOperation (int id, string operation, string service)



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
    public class RunServiceOperationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this Storage Node.
            var operation = operation_example;  // string | 
            var service = service_example;  // string | 

            try
            {
                apiInstance.RunServiceOperation(id, operation, service);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.RunServiceOperation: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Storage Node. | 
 **operation** | **string**|  | 
 **service** | **string**|  | 

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

<a name="setipmiconfiguration"></a>
# **SetIPMIConfiguration**
> Ipmi SetIPMIConfiguration (int id, Ipmi ipmi)



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
    public class SetIPMIConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this Storage Node.
            var ipmi = new Ipmi(); // Ipmi | 

            try
            {
                Ipmi result = apiInstance.SetIPMIConfiguration(id, ipmi);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.SetIPMIConfiguration: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Storage Node. | 
 **ipmi** | [**Ipmi**](Ipmi.md)|  | 

### Return type

[**Ipmi**](Ipmi.md)

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

<a name="setlocaltime"></a>
# **SetLocalTime**
> TimeEndpointResponse SetLocalTime (TimeEndpointRequest timeEndpointRequest)



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
    public class SetLocalTimeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var timeEndpointRequest = new TimeEndpointRequest(); // TimeEndpointRequest | 

            try
            {
                TimeEndpointResponse result = apiInstance.SetLocalTime(timeEndpointRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.SetLocalTime: " + e.Message );
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
 **timeEndpointRequest** | [**TimeEndpointRequest**](TimeEndpointRequest.md)|  | 

### Return type

[**TimeEndpointResponse**](TimeEndpointResponse.md)

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

<a name="setmypassword"></a>
# **SetMyPassword**
> void SetMyPassword (ChangeOwnPasswordRequest changeOwnPasswordRequest)



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
    public class SetMyPasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var changeOwnPasswordRequest = new ChangeOwnPasswordRequest(); // ChangeOwnPasswordRequest | 

            try
            {
                apiInstance.SetMyPassword(changeOwnPasswordRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.SetMyPassword: " + e.Message );
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
 **changeOwnPasswordRequest** | [**ChangeOwnPasswordRequest**](ChangeOwnPasswordRequest.md)|  | 

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

<a name="setuserpassword"></a>
# **SetUserPassword**
> void SetUserPassword (int id, ChangePasswordRequest changePasswordRequest)



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
    public class SetUserPasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this User.
            var changePasswordRequest = new ChangePasswordRequest(); // ChangePasswordRequest | 

            try
            {
                apiInstance.SetUserPassword(id, changePasswordRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.SetUserPassword: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this User. | 
 **changePasswordRequest** | [**ChangePasswordRequest**](ChangePasswordRequest.md)|  | 

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

<a name="shutdown"></a>
# **Shutdown**
> void Shutdown ()



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
    public class ShutdownExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);

            try
            {
                apiInstance.Shutdown();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.Shutdown: " + e.Message );
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

<a name="startsolrreindex"></a>
# **StartSolrReindex**
> SolrReindexEndpointResponse StartSolrReindex ()



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
    public class StartSolrReindexExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);

            try
            {
                SolrReindexEndpointResponse result = apiInstance.StartSolrReindex();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.StartSolrReindex: " + e.Message );
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

[**SolrReindexEndpointResponse**](SolrReindexEndpointResponse.md)

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

<a name="startsupportsession"></a>
# **StartSupportSession**
> TaskInfo StartSupportSession ()



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
    public class StartSupportSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);

            try
            {
                TaskInfo result = apiInstance.StartSupportSession();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.StartSupportSession: " + e.Message );
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

<a name="startsystembackup"></a>
# **StartSystemBackup**
> TaskInfo StartSystemBackup (Path path)



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
    public class StartSystemBackupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var path = new Path(); // Path | 

            try
            {
                TaskInfo result = apiInstance.StartSystemBackup(path);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.StartSystemBackup: " + e.Message );
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
 **path** | [**Path**](Path.md)|  | 

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

<a name="syncldapgroup"></a>
# **SyncLDAPGroup**
> void SyncLDAPGroup (int id)



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
    public class SyncLDAPGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this Group.

            try
            {
                apiInstance.SyncLDAPGroup(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.SyncLDAPGroup: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Group. | 

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

<a name="syncldapusers"></a>
# **SyncLDAPUsers**
> void SyncLDAPUsers (int id)



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
    public class SyncLDAPUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this LDAP Server.

            try
            {
                apiInstance.SyncLDAPUsers(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.SyncLDAPUsers: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this LDAP Server. | 

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

<a name="synctime"></a>
# **SyncTime**
> TimeSyncEndpointResponse SyncTime (TimeSyncEndpointRequest timeSyncEndpointRequest)



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
    public class SyncTimeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var timeSyncEndpointRequest = new TimeSyncEndpointRequest(); // TimeSyncEndpointRequest | 

            try
            {
                TimeSyncEndpointResponse result = apiInstance.SyncTime(timeSyncEndpointRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.SyncTime: " + e.Message );
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
 **timeSyncEndpointRequest** | [**TimeSyncEndpointRequest**](TimeSyncEndpointRequest.md)|  | 

### Return type

[**TimeSyncEndpointResponse**](TimeSyncEndpointResponse.md)

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

<a name="syncusertotp"></a>
# **SyncUserTOTP**
> SyncTOTP SyncUserTOTP (int id, SyncTOTPRequest syncTOTPRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class SyncUserTOTPExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this User.
            var syncTOTPRequest = new SyncTOTPRequest(); // SyncTOTPRequest | 

            try
            {
                SyncTOTP result = apiInstance.SyncUserTOTP(id, syncTOTPRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.SyncUserTOTP: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this User. | 
 **syncTOTPRequest** | [**SyncTOTPRequest**](SyncTOTPRequest.md)|  | 

### Return type

[**SyncTOTP**](SyncTOTP.md)

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

<a name="testsmtpconfiguration"></a>
# **TestSMTPConfiguration**
> void TestSMTPConfiguration (TestSMTP testSMTP)



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
    public class TestSMTPConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var testSMTP = new TestSMTP(); // TestSMTP | 

            try
            {
                apiInstance.TestSMTPConfiguration(testSMTP);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.TestSMTPConfiguration: " + e.Message );
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
 **testSMTP** | [**TestSMTP**](TestSMTP.md)|  | 

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

<a name="updatecertificateconfiguration"></a>
# **UpdateCertificateConfiguration**
> Certificate UpdateCertificateConfiguration (Certificate certificate)



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
    public class UpdateCertificateConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var certificate = new Certificate(); // Certificate | 

            try
            {
                Certificate result = apiInstance.UpdateCertificateConfiguration(certificate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.UpdateCertificateConfiguration: " + e.Message );
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
 **certificate** | [**Certificate**](Certificate.md)|  | 

### Return type

[**Certificate**](Certificate.md)

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

<a name="updatecurrentworkstation"></a>
# **UpdateCurrentWorkstation**
> Workstation UpdateCurrentWorkstation (Workstation workstation)



### Required permissions    * <class 'rest_framework.permissions.AllowAny'> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateCurrentWorkstationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var workstation = new Workstation(); // Workstation | 

            try
            {
                Workstation result = apiInstance.UpdateCurrentWorkstation(workstation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.UpdateCurrentWorkstation: " + e.Message );
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
 **workstation** | [**Workstation**](Workstation.md)|  | 

### Return type

[**Workstation**](Workstation.md)

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

<a name="updatedownloadarchive"></a>
# **UpdateDownloadArchive**
> DownloadArchive UpdateDownloadArchive (Guid id, DownloadArchive downloadArchive)



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
    public class UpdateDownloadArchiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = new Guid(); // Guid | A UUID string identifying this download archive.
            var downloadArchive = new DownloadArchive(); // DownloadArchive | 

            try
            {
                DownloadArchive result = apiInstance.UpdateDownloadArchive(id, downloadArchive);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.UpdateDownloadArchive: " + e.Message );
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
 **id** | [**Guid**](Guid.md)| A UUID string identifying this download archive. | 
 **downloadArchive** | [**DownloadArchive**](DownloadArchive.md)|  | 

### Return type

[**DownloadArchive**](DownloadArchive.md)

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

<a name="updategroup"></a>
# **UpdateGroup**
> ElementsGroupDetail UpdateGroup (int id, ElementsGroupDetail elementsGroupDetail)



### Required permissions    * User account permission: `users:view` (read) / `users:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this Group.
            var elementsGroupDetail = new ElementsGroupDetail(); // ElementsGroupDetail | 

            try
            {
                ElementsGroupDetail result = apiInstance.UpdateGroup(id, elementsGroupDetail);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.UpdateGroup: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Group. | 
 **elementsGroupDetail** | [**ElementsGroupDetail**](ElementsGroupDetail.md)|  | 

### Return type

[**ElementsGroupDetail**](ElementsGroupDetail.md)

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

<a name="updatentpserver"></a>
# **UpdateNTPServer**
> NTPServer UpdateNTPServer (int id, NTPServer nTPServer)



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
    public class UpdateNTPServerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this NTP Server.
            var nTPServer = new NTPServer(); // NTPServer | 

            try
            {
                NTPServer result = apiInstance.UpdateNTPServer(id, nTPServer);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.UpdateNTPServer: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this NTP Server. | 
 **nTPServer** | [**NTPServer**](NTPServer.md)|  | 

### Return type

[**NTPServer**](NTPServer.md)

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

<a name="updateparameters"></a>
# **UpdateParameters**
> Parameters UpdateParameters (Parameters parameters)



### Required permissions    * <class 'rest_framework.permissions.AllowAny'> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateParametersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var parameters = new Parameters(); // Parameters | 

            try
            {
                Parameters result = apiInstance.UpdateParameters(parameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.UpdateParameters: " + e.Message );
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
 **parameters** | [**Parameters**](Parameters.md)|  | 

### Return type

[**Parameters**](Parameters.md)

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

<a name="updateprofile"></a>
# **UpdateProfile**
> ElementsUserProfile UpdateProfile (ElementsUserProfile elementsUserProfile)



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
    public class UpdateProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var elementsUserProfile = new ElementsUserProfile(); // ElementsUserProfile | 

            try
            {
                ElementsUserProfile result = apiInstance.UpdateProfile(elementsUserProfile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.UpdateProfile: " + e.Message );
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
 **elementsUserProfile** | [**ElementsUserProfile**](ElementsUserProfile.md)|  | 

### Return type

[**ElementsUserProfile**](ElementsUserProfile.md)

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

<a name="updatesmtpconfiguration"></a>
# **UpdateSMTPConfiguration**
> SMTPConfiguration UpdateSMTPConfiguration (SMTPConfiguration sMTPConfiguration)



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
    public class UpdateSMTPConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var sMTPConfiguration = new SMTPConfiguration(); // SMTPConfiguration | 

            try
            {
                SMTPConfiguration result = apiInstance.UpdateSMTPConfiguration(sMTPConfiguration);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.UpdateSMTPConfiguration: " + e.Message );
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
 **sMTPConfiguration** | [**SMTPConfiguration**](SMTPConfiguration.md)|  | 

### Return type

[**SMTPConfiguration**](SMTPConfiguration.md)

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

<a name="updateuser"></a>
# **UpdateUser**
> ElementsUserDetail UpdateUser (int id, ElementsUserDetail elementsUserDetail)



### Required permissions    * User account permission: `None` (read) / `users:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = 56;  // int | A unique integer value identifying this User.
            var elementsUserDetail = new ElementsUserDetail(); // ElementsUserDetail | 

            try
            {
                ElementsUserDetail result = apiInstance.UpdateUser(id, elementsUserDetail);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.UpdateUser: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this User. | 
 **elementsUserDetail** | [**ElementsUserDetail**](ElementsUserDetail.md)|  | 

### Return type

[**ElementsUserDetail**](ElementsUserDetail.md)

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

<a name="updateworkstation"></a>
# **UpdateWorkstation**
> Workstation UpdateWorkstation (string id, Workstation workstation)



### Required permissions    * Authenticated user   * Own workstation or User account permission: `workstations:view` (read) / `workstations:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateWorkstationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var id = id_example;  // string | A unique value identifying this workstation.
            var workstation = new Workstation(); // Workstation | 

            try
            {
                Workstation result = apiInstance.UpdateWorkstation(id, workstation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.UpdateWorkstation: " + e.Message );
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
 **id** | **string**| A unique value identifying this workstation. | 
 **workstation** | [**Workstation**](Workstation.md)|  | 

### Return type

[**Workstation**](Workstation.md)

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

<a name="uploadchunk"></a>
# **UploadChunk**
> void UploadChunk (UploadChunkEndpointRequest uploadChunkEndpointRequest)



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
    public class UploadChunkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MainApi(config);
            var uploadChunkEndpointRequest = new UploadChunkEndpointRequest(); // UploadChunkEndpointRequest | 

            try
            {
                apiInstance.UploadChunk(uploadChunkEndpointRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MainApi.UploadChunk: " + e.Message );
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
 **uploadChunkEndpointRequest** | [**UploadChunkEndpointRequest**](UploadChunkEndpointRequest.md)|  | 

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

