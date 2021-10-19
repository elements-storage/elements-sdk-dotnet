# ElementsSDK.Api.MediaLibraryApi

All URIs are relative to *https://elements.local*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BookmarkMediaDirectory**](MediaLibraryApi.md#bookmarkmediadirectory) | **POST** /api/2/media/files/{id}/bookmark | 
[**ClearSubclipClipboard**](MediaLibraryApi.md#clearsubclipclipboard) | **DELETE** /api/2/media/subclips/clipboard/clear | 
[**CombineAssetsIntoSet**](MediaLibraryApi.md#combineassetsintoset) | **POST** /api/2/media/assets/combine | 
[**CreateAsset**](MediaLibraryApi.md#createasset) | **POST** /api/2/media/assets | 
[**CreateAssetRating**](MediaLibraryApi.md#createassetrating) | **POST** /api/2/media/ratings | 
[**CreateComment**](MediaLibraryApi.md#createcomment) | **POST** /api/2/media/comments | 
[**CreateCustomField**](MediaLibraryApi.md#createcustomfield) | **POST** /api/2/media/custom-fields | 
[**CreateEditorProject**](MediaLibraryApi.md#createeditorproject) | **POST** /api/2/media/editor | 
[**CreateExternalTranscoder**](MediaLibraryApi.md#createexternaltranscoder) | **POST** /api/2/media/external-transcoders | 
[**CreateMarker**](MediaLibraryApi.md#createmarker) | **POST** /api/2/media/markers | 
[**CreateMediaFileTemplate**](MediaLibraryApi.md#createmediafiletemplate) | **POST** /api/2/media/files/templates | 
[**CreateMediaRoot**](MediaLibraryApi.md#createmediaroot) | **POST** /api/2/media/roots | 
[**CreateMediaRootPermission**](MediaLibraryApi.md#createmediarootpermission) | **POST** /api/2/media/root-permissions | 
[**CreateMediaTag**](MediaLibraryApi.md#createmediatag) | **POST** /api/2/media/tags | 
[**CreateProxyProfile**](MediaLibraryApi.md#createproxyprofile) | **POST** /api/2/media/proxy-profiles | 
[**CreateSubclip**](MediaLibraryApi.md#createsubclip) | **POST** /api/2/media/subclips | 
[**CreateSubclipClipboardEntry**](MediaLibraryApi.md#createsubclipclipboardentry) | **POST** /api/2/media/subclips/clipboard | 
[**DeleteAsset**](MediaLibraryApi.md#deleteasset) | **DELETE** /api/2/media/assets/{id} | 
[**DeleteAssetRating**](MediaLibraryApi.md#deleteassetrating) | **DELETE** /api/2/media/ratings/{id} | 
[**DeleteComment**](MediaLibraryApi.md#deletecomment) | **DELETE** /api/2/media/comments/{id} | 
[**DeleteCustomField**](MediaLibraryApi.md#deletecustomfield) | **DELETE** /api/2/media/custom-fields/{id} | 
[**DeleteEasySharingTokenForBundle**](MediaLibraryApi.md#deleteeasysharingtokenforbundle) | **DELETE** /api/2/media/bundles/{id}/easy-sharing-token | 
[**DeleteEasySharingTokenForDirectory**](MediaLibraryApi.md#deleteeasysharingtokenfordirectory) | **DELETE** /api/2/media/files/{id}/easy-sharing-token | 
[**DeleteExternalTranscoder**](MediaLibraryApi.md#deleteexternaltranscoder) | **DELETE** /api/2/media/external-transcoders/{id} | 
[**DeleteMarker**](MediaLibraryApi.md#deletemarker) | **DELETE** /api/2/media/markers/{id} | 
[**DeleteMediaFileTemplate**](MediaLibraryApi.md#deletemediafiletemplate) | **DELETE** /api/2/media/files/templates/{id} | 
[**DeleteMediaLibraryObjects**](MediaLibraryApi.md#deletemedialibraryobjects) | **POST** /api/2/media/delete | 
[**DeleteMediaRoot**](MediaLibraryApi.md#deletemediaroot) | **DELETE** /api/2/media/roots/{id} | 
[**DeleteMediaRootPermission**](MediaLibraryApi.md#deletemediarootpermission) | **DELETE** /api/2/media/root-permissions/{id} | 
[**DeleteMediaTag**](MediaLibraryApi.md#deletemediatag) | **DELETE** /api/2/media/tags/{id} | 
[**DeleteMediaUpdate**](MediaLibraryApi.md#deletemediaupdate) | **DELETE** /api/2/media/updates/{id} | 
[**DeleteProxy**](MediaLibraryApi.md#deleteproxy) | **DELETE** /api/2/media/proxies/{id} | 
[**DeleteProxyProfile**](MediaLibraryApi.md#deleteproxyprofile) | **DELETE** /api/2/media/proxy-profiles/{id} | 
[**DeleteSubclip**](MediaLibraryApi.md#deletesubclip) | **DELETE** /api/2/media/subclips/{id} | 
[**DeleteSubclipClipboardEntry**](MediaLibraryApi.md#deletesubclipclipboardentry) | **DELETE** /api/2/media/subclips/clipboard/{id} | 
[**DiscoverMedia**](MediaLibraryApi.md#discovermedia) | **POST** /api/2/scanner/discover | 
[**DownloadAssetProxyFile**](MediaLibraryApi.md#downloadassetproxyfile) | **GET** /api/2/media/assets/{id}/proxy-files/{filename} | 
[**DownloadMediaFile**](MediaLibraryApi.md#downloadmediafile) | **GET** /api/2/media/files/{id}/download | 
[**DownloadProxy**](MediaLibraryApi.md#downloadproxy) | **GET** /api/2/media/proxies/{id}/download | 
[**EditorExportXMLForAssset**](MediaLibraryApi.md#editorexportxmlforassset) | **GET** /api/2/media/editor/asset/{asset_ids}/xml-export | 
[**EditorExportXMLForBundle**](MediaLibraryApi.md#editorexportxmlforbundle) | **GET** /api/2/media/editor/bundle/{bundle_ids}/xml-export | 
[**EditorExportXMLForProject**](MediaLibraryApi.md#editorexportxmlforproject) | **GET** /api/2/media/editor/{id}/xml-export | 
[**ExportCommentsForAvid**](MediaLibraryApi.md#exportcommentsforavid) | **GET** /api/2/media/editor/asset/{asset_id}/{export_format}-export/avid-comments | 
[**ExportEditorTimeline**](MediaLibraryApi.md#exporteditortimeline) | **POST** /api/2/media/editor/timeline-export | 
[**ForgetDeletedMediaFiles**](MediaLibraryApi.md#forgetdeletedmediafiles) | **POST** /api/2/media/files/{id}/forget-deleted | 
[**GenerateProxies**](MediaLibraryApi.md#generateproxies) | **POST** /api/2/media/proxies | 
[**GetAllAssetProjectLinks**](MediaLibraryApi.md#getallassetprojectlinks) | **GET** /api/2/media/assets/project-links | 
[**GetAllAssetRatings**](MediaLibraryApi.md#getallassetratings) | **GET** /api/2/media/ratings | 
[**GetAllAssetTapeBackups**](MediaLibraryApi.md#getallassettapebackups) | **GET** /api/2/media/backups | 
[**GetAllAssets**](MediaLibraryApi.md#getallassets) | **GET** /api/2/media/assets | 
[**GetAllBundlesForMediaRoot**](MediaLibraryApi.md#getallbundlesformediaroot) | **GET** /api/2/media/bundles/flat/{root} | 
[**GetAllClickLinks**](MediaLibraryApi.md#getallclicklinks) | **GET** /api/2/media/assets/click-links | 
[**GetAllComments**](MediaLibraryApi.md#getallcomments) | **GET** /api/2/media/comments | 
[**GetAllCustomFields**](MediaLibraryApi.md#getallcustomfields) | **GET** /api/2/media/custom-fields | 
[**GetAllExternalTranscoders**](MediaLibraryApi.md#getallexternaltranscoders) | **GET** /api/2/media/external-transcoders | 
[**GetAllMarkers**](MediaLibraryApi.md#getallmarkers) | **GET** /api/2/media/markers | 
[**GetAllMediaFileBundles**](MediaLibraryApi.md#getallmediafilebundles) | **GET** /api/2/media/bundles | 
[**GetAllMediaFileTemplates**](MediaLibraryApi.md#getallmediafiletemplates) | **GET** /api/2/media/files/templates | 
[**GetAllMediaFiles**](MediaLibraryApi.md#getallmediafiles) | **GET** /api/2/media/files | 
[**GetAllMediaFilesForBundles**](MediaLibraryApi.md#getallmediafilesforbundles) | **POST** /api/2/media/files/for-bundles | 
[**GetAllMediaFilesForMediaRoot**](MediaLibraryApi.md#getallmediafilesformediaroot) | **GET** /api/2/media/files/flat/{root} | 
[**GetAllMediaRootPermissions**](MediaLibraryApi.md#getallmediarootpermissions) | **GET** /api/2/media/root-permissions | 
[**GetAllMediaRoots**](MediaLibraryApi.md#getallmediaroots) | **GET** /api/2/media/roots | 
[**GetAllMediaTags**](MediaLibraryApi.md#getallmediatags) | **GET** /api/2/media/tags | 
[**GetAllMediaUpdates**](MediaLibraryApi.md#getallmediaupdates) | **GET** /api/2/media/updates | 
[**GetAllProxyGenerators**](MediaLibraryApi.md#getallproxygenerators) | **GET** /api/2/media/proxy-generators | 
[**GetAllProxyProfiles**](MediaLibraryApi.md#getallproxyprofiles) | **GET** /api/2/media/proxy-profiles | 
[**GetAllSubclipClipboardEntries**](MediaLibraryApi.md#getallsubclipclipboardentries) | **GET** /api/2/media/subclips/clipboard | 
[**GetAllSubclips**](MediaLibraryApi.md#getallsubclips) | **GET** /api/2/media/subclips | 
[**GetAllTranscoderProfiles**](MediaLibraryApi.md#getalltranscoderprofiles) | **GET** /api/2/transcoder-profiles | 
[**GetAsset**](MediaLibraryApi.md#getasset) | **GET** /api/2/media/assets/{id} | 
[**GetAssetRating**](MediaLibraryApi.md#getassetrating) | **GET** /api/2/media/ratings/{id} | 
[**GetBookmarkedMediaFilesDirectories**](MediaLibraryApi.md#getbookmarkedmediafilesdirectories) | **GET** /api/2/media/files/bookmarks | 
[**GetComment**](MediaLibraryApi.md#getcomment) | **GET** /api/2/media/comments/{id} | 
[**GetCustomField**](MediaLibraryApi.md#getcustomfield) | **GET** /api/2/media/custom-fields/{id} | 
[**GetEasySharingTokenForBundle**](MediaLibraryApi.md#geteasysharingtokenforbundle) | **GET** /api/2/media/bundles/{id}/easy-sharing-token | 
[**GetEasySharingTokenForDirectory**](MediaLibraryApi.md#geteasysharingtokenfordirectory) | **GET** /api/2/media/files/{id}/easy-sharing-token | 
[**GetEditorProject**](MediaLibraryApi.md#geteditorproject) | **GET** /api/2/media/editor/{id} | 
[**GetExternalTranscoder**](MediaLibraryApi.md#getexternaltranscoder) | **GET** /api/2/media/external-transcoders/{id} | 
[**GetFrame**](MediaLibraryApi.md#getframe) | **GET** /api/2/media/assets/{id}/frames/{frame} | 
[**GetLatestMediaUpdate**](MediaLibraryApi.md#getlatestmediaupdate) | **GET** /api/2/media/updates/latest | 
[**GetMarker**](MediaLibraryApi.md#getmarker) | **GET** /api/2/media/markers/{id} | 
[**GetMediaFile**](MediaLibraryApi.md#getmediafile) | **GET** /api/2/media/files/{id} | 
[**GetMediaFileBundle**](MediaLibraryApi.md#getmediafilebundle) | **GET** /api/2/media/bundles/{id} | 
[**GetMediaFileContents**](MediaLibraryApi.md#getmediafilecontents) | **GET** /api/2/media/files/{id}/contents | 
[**GetMediaFileTemplate**](MediaLibraryApi.md#getmediafiletemplate) | **GET** /api/2/media/files/templates/{id} | 
[**GetMediaRoot**](MediaLibraryApi.md#getmediaroot) | **GET** /api/2/media/roots/{id} | 
[**GetMediaRootPermission**](MediaLibraryApi.md#getmediarootpermission) | **GET** /api/2/media/root-permissions/{id} | 
[**GetMediaTag**](MediaLibraryApi.md#getmediatag) | **GET** /api/2/media/tags/{id} | 
[**GetMultipleAssets**](MediaLibraryApi.md#getmultipleassets) | **POST** /api/2/media/assets/multiple | 
[**GetMultipleBundles**](MediaLibraryApi.md#getmultiplebundles) | **POST** /api/2/media/bundles/multiple | 
[**GetMultipleFiles**](MediaLibraryApi.md#getmultiplefiles) | **POST** /api/2/media/files/multiple | 
[**GetMyMediaRootPermissions**](MediaLibraryApi.md#getmymediarootpermissions) | **GET** /api/2/media/root-permissions/mine | 
[**GetMyResolvedMediaRootPermissions**](MediaLibraryApi.md#getmyresolvedmediarootpermissions) | **GET** /api/2/media/root-permissions/mine/resolved | 
[**GetProxy**](MediaLibraryApi.md#getproxy) | **GET** /api/2/media/proxies/{id} | 
[**GetProxyGenerator**](MediaLibraryApi.md#getproxygenerator) | **GET** /api/2/media/proxy-generators/{id} | 
[**GetProxyProfile**](MediaLibraryApi.md#getproxyprofile) | **GET** /api/2/media/proxy-profiles/{id} | 
[**GetProxyProfileProxyCount**](MediaLibraryApi.md#getproxyprofileproxycount) | **GET** /api/2/media/proxy-profiles/{id}/proxy-count | 
[**GetSubclip**](MediaLibraryApi.md#getsubclip) | **GET** /api/2/media/subclips/{id} | 
[**GetTranscoderProfile**](MediaLibraryApi.md#gettranscoderprofile) | **GET** /api/2/transcoder-profiles/{id} | 
[**GetVantageWorkflows**](MediaLibraryApi.md#getvantageworkflows) | **GET** /api/2/media/external-transcoders/{id}/workflows | 
[**InstantiateMediaFileTemplate**](MediaLibraryApi.md#instantiatemediafiletemplate) | **POST** /api/2/media/files/templates/{id}/instantiate | 
[**LocateEditorProjectPaths**](MediaLibraryApi.md#locateeditorprojectpaths) | **GET** /api/2/media/editor/{id}/locate-paths | 
[**MarkMediaDirectoryAsShowroom**](MediaLibraryApi.md#markmediadirectoryasshowroom) | **POST** /api/2/media/files/{id}/showroom | 
[**PatchAsset**](MediaLibraryApi.md#patchasset) | **PATCH** /api/2/media/assets/{id} | 
[**PatchAssetRating**](MediaLibraryApi.md#patchassetrating) | **PATCH** /api/2/media/ratings/{id} | 
[**PatchComment**](MediaLibraryApi.md#patchcomment) | **PATCH** /api/2/media/comments/{id} | 
[**PatchCustomField**](MediaLibraryApi.md#patchcustomfield) | **PATCH** /api/2/media/custom-fields/{id} | 
[**PatchEditorProject**](MediaLibraryApi.md#patcheditorproject) | **PATCH** /api/2/media/editor/{id} | 
[**PatchExternalTranscoder**](MediaLibraryApi.md#patchexternaltranscoder) | **PATCH** /api/2/media/external-transcoders/{id} | 
[**PatchMarker**](MediaLibraryApi.md#patchmarker) | **PATCH** /api/2/media/markers/{id} | 
[**PatchMediaFile**](MediaLibraryApi.md#patchmediafile) | **PATCH** /api/2/media/files/{id} | 
[**PatchMediaFileTemplate**](MediaLibraryApi.md#patchmediafiletemplate) | **PATCH** /api/2/media/files/templates/{id} | 
[**PatchMediaRoot**](MediaLibraryApi.md#patchmediaroot) | **PATCH** /api/2/media/roots/{id} | 
[**PatchMediaRootPermission**](MediaLibraryApi.md#patchmediarootpermission) | **PATCH** /api/2/media/root-permissions/{id} | 
[**PatchMediaTag**](MediaLibraryApi.md#patchmediatag) | **PATCH** /api/2/media/tags/{id} | 
[**PatchProxyProfile**](MediaLibraryApi.md#patchproxyprofile) | **PATCH** /api/2/media/proxy-profiles/{id} | 
[**PatchSubclip**](MediaLibraryApi.md#patchsubclip) | **PATCH** /api/2/media/subclips/{id} | 
[**RecursivelyTagMediaDirectory**](MediaLibraryApi.md#recursivelytagmediadirectory) | **POST** /api/2/media/files/{id}/tag | 
[**ReindexMediaDirectory**](MediaLibraryApi.md#reindexmediadirectory) | **POST** /api/2/media/files/{id}/search-reindex | 
[**RenameCustomField**](MediaLibraryApi.md#renamecustomfield) | **POST** /api/2/media/custom-fields/{id}/rename | 
[**RenderSequence**](MediaLibraryApi.md#rendersequence) | **POST** /api/2/media/editor/render | 
[**RenderSubclip**](MediaLibraryApi.md#rendersubclip) | **POST** /api/2/media/subclips/{id}/render | 
[**RequestMediaScan**](MediaLibraryApi.md#requestmediascan) | **POST** /api/2/scanner/scan | 
[**ResolveComment**](MediaLibraryApi.md#resolvecomment) | **POST** /api/2/media/comments/{id}/resolve | 
[**ShareMediaLibraryObjects**](MediaLibraryApi.md#sharemedialibraryobjects) | **POST** /api/2/media/share | 
[**TestExternalTranscoderConnection**](MediaLibraryApi.md#testexternaltranscoderconnection) | **POST** /api/2/media/external-transcoders/test-connection | 
[**TransitionWorkflow**](MediaLibraryApi.md#transitionworkflow) | **POST** /api/2/media/workflow/transition | 
[**UnbookmarkMediaDirectory**](MediaLibraryApi.md#unbookmarkmediadirectory) | **DELETE** /api/2/media/files/{id}/bookmark | 
[**UnmarkMediaDirectoryAsShowroom**](MediaLibraryApi.md#unmarkmediadirectoryasshowroom) | **DELETE** /api/2/media/files/{id}/showroom | 
[**UnresolveComment**](MediaLibraryApi.md#unresolvecomment) | **POST** /api/2/media/comments/{id}/unresolve | 
[**UpdateAsset**](MediaLibraryApi.md#updateasset) | **PUT** /api/2/media/assets/{id} | 
[**UpdateAssetRating**](MediaLibraryApi.md#updateassetrating) | **PUT** /api/2/media/ratings/{id} | 
[**UpdateComment**](MediaLibraryApi.md#updatecomment) | **PUT** /api/2/media/comments/{id} | 
[**UpdateCustomField**](MediaLibraryApi.md#updatecustomfield) | **PUT** /api/2/media/custom-fields/{id} | 
[**UpdateEditorProject**](MediaLibraryApi.md#updateeditorproject) | **PUT** /api/2/media/editor/{id} | 
[**UpdateExternalTranscoder**](MediaLibraryApi.md#updateexternaltranscoder) | **PUT** /api/2/media/external-transcoders/{id} | 
[**UpdateMarker**](MediaLibraryApi.md#updatemarker) | **PUT** /api/2/media/markers/{id} | 
[**UpdateMediaFile**](MediaLibraryApi.md#updatemediafile) | **PUT** /api/2/media/files/{id} | 
[**UpdateMediaFileTemplate**](MediaLibraryApi.md#updatemediafiletemplate) | **PUT** /api/2/media/files/templates/{id} | 
[**UpdateMediaRoot**](MediaLibraryApi.md#updatemediaroot) | **PUT** /api/2/media/roots/{id} | 
[**UpdateMediaRootPermission**](MediaLibraryApi.md#updatemediarootpermission) | **PUT** /api/2/media/root-permissions/{id} | 
[**UpdateMediaTag**](MediaLibraryApi.md#updatemediatag) | **PUT** /api/2/media/tags/{id} | 
[**UpdateProxyProfile**](MediaLibraryApi.md#updateproxyprofile) | **PUT** /api/2/media/proxy-profiles/{id} | 
[**UpdateSubclip**](MediaLibraryApi.md#updatesubclip) | **PUT** /api/2/media/subclips/{id} | 


<a name="bookmarkmediadirectory"></a>
# **BookmarkMediaDirectory**
> void BookmarkMediaDirectory (int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class BookmarkMediaDirectoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this File.

            try
            {
                apiInstance.BookmarkMediaDirectory(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.BookmarkMediaDirectory: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this File. | 

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

<a name="clearsubclipclipboard"></a>
# **ClearSubclipClipboard**
> void ClearSubclipClipboard ()



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class ClearSubclipClipboardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);

            try
            {
                apiInstance.ClearSubclipClipboard();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.ClearSubclipClipboard: " + e.Message );
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

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | No body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="combineassetsintoset"></a>
# **CombineAssetsIntoSet**
> void CombineAssetsIntoSet (MultipleAssetsRequest multipleAssetsRequest)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CombineAssetsIntoSetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var multipleAssetsRequest = new MultipleAssetsRequest(); // MultipleAssetsRequest | 

            try
            {
                apiInstance.CombineAssetsIntoSet(multipleAssetsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.CombineAssetsIntoSet: " + e.Message );
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
 **multipleAssetsRequest** | [**MultipleAssetsRequest**](MultipleAssetsRequest.md)|  | 

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

<a name="createasset"></a>
# **CreateAsset**
> Asset CreateAsset (Asset asset)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var asset = new Asset(); // Asset | 

            try
            {
                Asset result = apiInstance.CreateAsset(asset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.CreateAsset: " + e.Message );
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
 **asset** | [**Asset**](Asset.md)|  | 

### Return type

[**Asset**](Asset.md)

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

<a name="createassetrating"></a>
# **CreateAssetRating**
> AssetRating CreateAssetRating (AssetRating assetRating)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateAssetRatingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var assetRating = new AssetRating(); // AssetRating | 

            try
            {
                AssetRating result = apiInstance.CreateAssetRating(assetRating);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.CreateAssetRating: " + e.Message );
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
 **assetRating** | [**AssetRating**](AssetRating.md)|  | 

### Return type

[**AssetRating**](AssetRating.md)

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

<a name="createcomment"></a>
# **CreateComment**
> Comment CreateComment (Comment comment)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var comment = new Comment(); // Comment | 

            try
            {
                Comment result = apiInstance.CreateComment(comment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.CreateComment: " + e.Message );
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
 **comment** | [**Comment**](Comment.md)|  | 

### Return type

[**Comment**](Comment.md)

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

<a name="createcustomfield"></a>
# **CreateCustomField**
> CustomField CreateCustomField (CustomField customField)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateCustomFieldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var customField = new CustomField(); // CustomField | 

            try
            {
                CustomField result = apiInstance.CreateCustomField(customField);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.CreateCustomField: " + e.Message );
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
 **customField** | [**CustomField**](CustomField.md)|  | 

### Return type

[**CustomField**](CustomField.md)

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

<a name="createeditorproject"></a>
# **CreateEditorProject**
> EditorProject CreateEditorProject (EditorProject editorProject)



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
    public class CreateEditorProjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var editorProject = new EditorProject(); // EditorProject | 

            try
            {
                EditorProject result = apiInstance.CreateEditorProject(editorProject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.CreateEditorProject: " + e.Message );
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
 **editorProject** | [**EditorProject**](EditorProject.md)|  | 

### Return type

[**EditorProject**](EditorProject.md)

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

<a name="createexternaltranscoder"></a>
# **CreateExternalTranscoder**
> ExternalTranscoder CreateExternalTranscoder (ExternalTranscoder externalTranscoder)



### Required permissions    * User account permission: `media:access` (read) / `system:admin-access` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateExternalTranscoderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var externalTranscoder = new ExternalTranscoder(); // ExternalTranscoder | 

            try
            {
                ExternalTranscoder result = apiInstance.CreateExternalTranscoder(externalTranscoder);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.CreateExternalTranscoder: " + e.Message );
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
 **externalTranscoder** | [**ExternalTranscoder**](ExternalTranscoder.md)|  | 

### Return type

[**ExternalTranscoder**](ExternalTranscoder.md)

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

<a name="createmarker"></a>
# **CreateMarker**
> Marker CreateMarker (Marker marker)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateMarkerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var marker = new Marker(); // Marker | 

            try
            {
                Marker result = apiInstance.CreateMarker(marker);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.CreateMarker: " + e.Message );
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
 **marker** | [**Marker**](Marker.md)|  | 

### Return type

[**Marker**](Marker.md)

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

<a name="createmediafiletemplate"></a>
# **CreateMediaFileTemplate**
> MediaFileTemplate CreateMediaFileTemplate (MediaFileTemplate mediaFileTemplate)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateMediaFileTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var mediaFileTemplate = new MediaFileTemplate(); // MediaFileTemplate | 

            try
            {
                MediaFileTemplate result = apiInstance.CreateMediaFileTemplate(mediaFileTemplate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.CreateMediaFileTemplate: " + e.Message );
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
 **mediaFileTemplate** | [**MediaFileTemplate**](MediaFileTemplate.md)|  | 

### Return type

[**MediaFileTemplate**](MediaFileTemplate.md)

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

<a name="createmediaroot"></a>
# **CreateMediaRoot**
> MediaRoot CreateMediaRoot (MediaRoot mediaRoot)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateMediaRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var mediaRoot = new MediaRoot(); // MediaRoot | 

            try
            {
                MediaRoot result = apiInstance.CreateMediaRoot(mediaRoot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.CreateMediaRoot: " + e.Message );
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
 **mediaRoot** | [**MediaRoot**](MediaRoot.md)|  | 

### Return type

[**MediaRoot**](MediaRoot.md)

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

<a name="createmediarootpermission"></a>
# **CreateMediaRootPermission**
> MediaRootPermission CreateMediaRootPermission (MediaRootPermission mediaRootPermission)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateMediaRootPermissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var mediaRootPermission = new MediaRootPermission(); // MediaRootPermission | 

            try
            {
                MediaRootPermission result = apiInstance.CreateMediaRootPermission(mediaRootPermission);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.CreateMediaRootPermission: " + e.Message );
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
 **mediaRootPermission** | [**MediaRootPermission**](MediaRootPermission.md)|  | 

### Return type

[**MediaRootPermission**](MediaRootPermission.md)

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

<a name="createmediatag"></a>
# **CreateMediaTag**
> UnfilteredTag CreateMediaTag (UnfilteredTag unfilteredTag)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateMediaTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var unfilteredTag = new UnfilteredTag(); // UnfilteredTag | 

            try
            {
                UnfilteredTag result = apiInstance.CreateMediaTag(unfilteredTag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.CreateMediaTag: " + e.Message );
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
 **unfilteredTag** | [**UnfilteredTag**](UnfilteredTag.md)|  | 

### Return type

[**UnfilteredTag**](UnfilteredTag.md)

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

<a name="createproxyprofile"></a>
# **CreateProxyProfile**
> ProxyProfile CreateProxyProfile (ProxyProfile proxyProfile)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateProxyProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var proxyProfile = new ProxyProfile(); // ProxyProfile | 

            try
            {
                ProxyProfile result = apiInstance.CreateProxyProfile(proxyProfile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.CreateProxyProfile: " + e.Message );
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
 **proxyProfile** | [**ProxyProfile**](ProxyProfile.md)|  | 

### Return type

[**ProxyProfile**](ProxyProfile.md)

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

<a name="createsubclip"></a>
# **CreateSubclip**
> Subclip CreateSubclip (Subclip subclip)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateSubclipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var subclip = new Subclip(); // Subclip | 

            try
            {
                Subclip result = apiInstance.CreateSubclip(subclip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.CreateSubclip: " + e.Message );
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
 **subclip** | [**Subclip**](Subclip.md)|  | 

### Return type

[**Subclip**](Subclip.md)

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

<a name="createsubclipclipboardentry"></a>
# **CreateSubclipClipboardEntry**
> SubclipClipboardEntry CreateSubclipClipboardEntry (SubclipClipboardEntry subclipClipboardEntry)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateSubclipClipboardEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var subclipClipboardEntry = new SubclipClipboardEntry(); // SubclipClipboardEntry | 

            try
            {
                SubclipClipboardEntry result = apiInstance.CreateSubclipClipboardEntry(subclipClipboardEntry);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.CreateSubclipClipboardEntry: " + e.Message );
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
 **subclipClipboardEntry** | [**SubclipClipboardEntry**](SubclipClipboardEntry.md)|  | 

### Return type

[**SubclipClipboardEntry**](SubclipClipboardEntry.md)

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

<a name="deleteasset"></a>
# **DeleteAsset**
> void DeleteAsset (int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Asset.

            try
            {
                apiInstance.DeleteAsset(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.DeleteAsset: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Asset. | 

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

<a name="deleteassetrating"></a>
# **DeleteAssetRating**
> void DeleteAssetRating (int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteAssetRatingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Rating.

            try
            {
                apiInstance.DeleteAssetRating(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.DeleteAssetRating: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Rating. | 

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

<a name="deletecomment"></a>
# **DeleteComment**
> void DeleteComment (int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Comment.

            try
            {
                apiInstance.DeleteComment(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.DeleteComment: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Comment. | 

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

<a name="deletecustomfield"></a>
# **DeleteCustomField**
> void DeleteCustomField (int id)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteCustomFieldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Custom field.

            try
            {
                apiInstance.DeleteCustomField(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.DeleteCustomField: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Custom field. | 

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

<a name="deleteeasysharingtokenforbundle"></a>
# **DeleteEasySharingTokenForBundle**
> void DeleteEasySharingTokenForBundle (int id)



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
    public class DeleteEasySharingTokenForBundleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Bundle.

            try
            {
                apiInstance.DeleteEasySharingTokenForBundle(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.DeleteEasySharingTokenForBundle: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Bundle. | 

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

<a name="deleteeasysharingtokenfordirectory"></a>
# **DeleteEasySharingTokenForDirectory**
> void DeleteEasySharingTokenForDirectory (int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteEasySharingTokenForDirectoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this File.

            try
            {
                apiInstance.DeleteEasySharingTokenForDirectory(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.DeleteEasySharingTokenForDirectory: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this File. | 

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

<a name="deleteexternaltranscoder"></a>
# **DeleteExternalTranscoder**
> void DeleteExternalTranscoder (int id)



### Required permissions    * User account permission: `media:access` (read) / `system:admin-access` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteExternalTranscoderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this external transcoder.

            try
            {
                apiInstance.DeleteExternalTranscoder(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.DeleteExternalTranscoder: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this external transcoder. | 

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

<a name="deletemarker"></a>
# **DeleteMarker**
> void DeleteMarker (int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteMarkerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this marker.

            try
            {
                apiInstance.DeleteMarker(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.DeleteMarker: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this marker. | 

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

<a name="deletemediafiletemplate"></a>
# **DeleteMediaFileTemplate**
> void DeleteMediaFileTemplate (int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteMediaFileTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Template.

            try
            {
                apiInstance.DeleteMediaFileTemplate(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.DeleteMediaFileTemplate: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Template. | 

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

<a name="deletemedialibraryobjects"></a>
# **DeleteMediaLibraryObjects**
> List&lt;TaskInfo&gt; DeleteMediaLibraryObjects (MediaLibraryDeleteRequest mediaLibraryDeleteRequest)



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
    public class DeleteMediaLibraryObjectsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var mediaLibraryDeleteRequest = new MediaLibraryDeleteRequest(); // MediaLibraryDeleteRequest | 

            try
            {
                List<TaskInfo> result = apiInstance.DeleteMediaLibraryObjects(mediaLibraryDeleteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.DeleteMediaLibraryObjects: " + e.Message );
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
 **mediaLibraryDeleteRequest** | [**MediaLibraryDeleteRequest**](MediaLibraryDeleteRequest.md)|  | 

### Return type

[**List&lt;TaskInfo&gt;**](TaskInfo.md)

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

<a name="deletemediaroot"></a>
# **DeleteMediaRoot**
> void DeleteMediaRoot (int id)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteMediaRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this media root.

            try
            {
                apiInstance.DeleteMediaRoot(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.DeleteMediaRoot: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this media root. | 

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

<a name="deletemediarootpermission"></a>
# **DeleteMediaRootPermission**
> void DeleteMediaRootPermission (int id)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteMediaRootPermissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Media Root Permission.

            try
            {
                apiInstance.DeleteMediaRootPermission(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.DeleteMediaRootPermission: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Media Root Permission. | 

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

<a name="deletemediatag"></a>
# **DeleteMediaTag**
> void DeleteMediaTag (int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteMediaTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Tag.

            try
            {
                apiInstance.DeleteMediaTag(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.DeleteMediaTag: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Tag. | 

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

<a name="deletemediaupdate"></a>
# **DeleteMediaUpdate**
> void DeleteMediaUpdate (int id)



### Required permissions    * User account permission: `media:access` (read) / `media:updates:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteMediaUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Update.

            try
            {
                apiInstance.DeleteMediaUpdate(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.DeleteMediaUpdate: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Update. | 

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

<a name="deleteproxy"></a>
# **DeleteProxy**
> void DeleteProxy (int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteProxyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this proxy.

            try
            {
                apiInstance.DeleteProxy(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.DeleteProxy: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this proxy. | 

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

<a name="deleteproxyprofile"></a>
# **DeleteProxyProfile**
> void DeleteProxyProfile (int id)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteProxyProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this proxy profile.

            try
            {
                apiInstance.DeleteProxyProfile(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.DeleteProxyProfile: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this proxy profile. | 

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

<a name="deletesubclip"></a>
# **DeleteSubclip**
> void DeleteSubclip (int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteSubclipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this subclip.

            try
            {
                apiInstance.DeleteSubclip(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.DeleteSubclip: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this subclip. | 

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

<a name="deletesubclipclipboardentry"></a>
# **DeleteSubclipClipboardEntry**
> void DeleteSubclipClipboardEntry (int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteSubclipClipboardEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this subclip clipboard entry.

            try
            {
                apiInstance.DeleteSubclipClipboardEntry(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.DeleteSubclipClipboardEntry: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this subclip clipboard entry. | 

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

<a name="discovermedia"></a>
# **DiscoverMedia**
> MediaFile DiscoverMedia (ScannerDiscoverEndpointRequest scannerDiscoverEndpointRequest)



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
    public class DiscoverMediaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var scannerDiscoverEndpointRequest = new ScannerDiscoverEndpointRequest(); // ScannerDiscoverEndpointRequest | 

            try
            {
                MediaFile result = apiInstance.DiscoverMedia(scannerDiscoverEndpointRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.DiscoverMedia: " + e.Message );
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
 **scannerDiscoverEndpointRequest** | [**ScannerDiscoverEndpointRequest**](ScannerDiscoverEndpointRequest.md)|  | 

### Return type

[**MediaFile**](MediaFile.md)

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

<a name="downloadassetproxyfile"></a>
# **DownloadAssetProxyFile**
> void DownloadAssetProxyFile (string filename, int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DownloadAssetProxyFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var filename = filename_example;  // string | 
            var id = 56;  // int | A unique integer value identifying this Asset.

            try
            {
                apiInstance.DownloadAssetProxyFile(filename, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.DownloadAssetProxyFile: " + e.Message );
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
 **filename** | **string**|  | 
 **id** | **int**| A unique integer value identifying this Asset. | 

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

<a name="downloadmediafile"></a>
# **DownloadMediaFile**
> void DownloadMediaFile (int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DownloadMediaFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this File.

            try
            {
                apiInstance.DownloadMediaFile(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.DownloadMediaFile: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this File. | 

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

<a name="downloadproxy"></a>
# **DownloadProxy**
> void DownloadProxy (int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DownloadProxyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this proxy.

            try
            {
                apiInstance.DownloadProxy(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.DownloadProxy: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this proxy. | 

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

<a name="editorexportxmlforassset"></a>
# **EditorExportXMLForAssset**
> void EditorExportXMLForAssset (string assetIds, string ordering = null, int? limit = null, int? offset = null)



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
    public class EditorExportXMLForAsssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var assetIds = assetIds_example;  // string | 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                apiInstance.EditorExportXMLForAssset(assetIds, ordering, limit, offset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.EditorExportXMLForAssset: " + e.Message );
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
 **assetIds** | **string**|  | 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

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

<a name="editorexportxmlforbundle"></a>
# **EditorExportXMLForBundle**
> void EditorExportXMLForBundle (string bundleIds, string ordering = null, int? limit = null, int? offset = null)



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
    public class EditorExportXMLForBundleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var bundleIds = bundleIds_example;  // string | 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                apiInstance.EditorExportXMLForBundle(bundleIds, ordering, limit, offset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.EditorExportXMLForBundle: " + e.Message );
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
 **bundleIds** | **string**|  | 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

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

<a name="editorexportxmlforproject"></a>
# **EditorExportXMLForProject**
> void EditorExportXMLForProject (int id)



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
    public class EditorExportXMLForProjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this File.

            try
            {
                apiInstance.EditorExportXMLForProject(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.EditorExportXMLForProject: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this File. | 

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

<a name="exportcommentsforavid"></a>
# **ExportCommentsForAvid**
> void ExportCommentsForAvid (string assetId, string exportFormat, string ordering = null, int? limit = null, int? offset = null)



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
    public class ExportCommentsForAvidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var assetId = assetId_example;  // string | 
            var exportFormat = exportFormat_example;  // string | 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                apiInstance.ExportCommentsForAvid(assetId, exportFormat, ordering, limit, offset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.ExportCommentsForAvid: " + e.Message );
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
 **assetId** | **string**|  | 
 **exportFormat** | **string**|  | 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

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

<a name="exporteditortimeline"></a>
# **ExportEditorTimeline**
> void ExportEditorTimeline (TimelineExportRequest timelineExportRequest)



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
    public class ExportEditorTimelineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var timelineExportRequest = new TimelineExportRequest(); // TimelineExportRequest | 

            try
            {
                apiInstance.ExportEditorTimeline(timelineExportRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.ExportEditorTimeline: " + e.Message );
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
 **timelineExportRequest** | [**TimelineExportRequest**](TimelineExportRequest.md)|  | 

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

<a name="forgetdeletedmediafiles"></a>
# **ForgetDeletedMediaFiles**
> void ForgetDeletedMediaFiles (int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class ForgetDeletedMediaFilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this File.

            try
            {
                apiInstance.ForgetDeletedMediaFiles(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.ForgetDeletedMediaFiles: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this File. | 

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

<a name="generateproxies"></a>
# **GenerateProxies**
> List&lt;TaskInfo&gt; GenerateProxies (GenerateProxiesRequest generateProxiesRequest)



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
    public class GenerateProxiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var generateProxiesRequest = new GenerateProxiesRequest(); // GenerateProxiesRequest | 

            try
            {
                List<TaskInfo> result = apiInstance.GenerateProxies(generateProxiesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GenerateProxies: " + e.Message );
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
 **generateProxiesRequest** | [**GenerateProxiesRequest**](GenerateProxiesRequest.md)|  | 

### Return type

[**List&lt;TaskInfo&gt;**](TaskInfo.md)

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

<a name="getallassetprojectlinks"></a>
# **GetAllAssetProjectLinks**
> List&lt;AssetProjectLink&gt; GetAllAssetProjectLinks (string asset = null, string project = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllAssetProjectLinksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var asset = asset_example;  // string | Filter the returned list by `asset`. (optional) 
            var project = project_example;  // string | Filter the returned list by `project`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<AssetProjectLink> result = apiInstance.GetAllAssetProjectLinks(asset, project, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetAllAssetProjectLinks: " + e.Message );
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
 **asset** | **string**| Filter the returned list by &#x60;asset&#x60;. | [optional] 
 **project** | **string**| Filter the returned list by &#x60;project&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;AssetProjectLink&gt;**](AssetProjectLink.md)

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

<a name="getallassetratings"></a>
# **GetAllAssetRatings**
> List&lt;AssetRating&gt; GetAllAssetRatings (string user = null, string asset = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllAssetRatingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var user = user_example;  // string | Filter the returned list by `user`. (optional) 
            var asset = asset_example;  // string | Filter the returned list by `asset`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<AssetRating> result = apiInstance.GetAllAssetRatings(user, asset, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetAllAssetRatings: " + e.Message );
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
 **user** | **string**| Filter the returned list by &#x60;user&#x60;. | [optional] 
 **asset** | **string**| Filter the returned list by &#x60;asset&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;AssetRating&gt;**](AssetRating.md)

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

<a name="getallassettapebackups"></a>
# **GetAllAssetTapeBackups**
> List&lt;AssetBackup&gt; GetAllAssetTapeBackups (string asset = null, string ordering = null, int? limit = null, int? offset = null, bool? includeAsset = null, string advancedSearch = null)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllAssetTapeBackupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var asset = asset_example;  // string | Filter the returned list by `asset`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 
            var includeAsset = true;  // bool? |  (optional) 
            var advancedSearch = advancedSearch_example;  // string |  (optional) 

            try
            {
                List<AssetBackup> result = apiInstance.GetAllAssetTapeBackups(asset, ordering, limit, offset, includeAsset, advancedSearch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetAllAssetTapeBackups: " + e.Message );
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
 **asset** | **string**| Filter the returned list by &#x60;asset&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 
 **includeAsset** | **bool?**|  | [optional] 
 **advancedSearch** | **string**|  | [optional] 

### Return type

[**List&lt;AssetBackup&gt;**](AssetBackup.md)

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

<a name="getallassets"></a>
# **GetAllAssets**
> List&lt;Asset&gt; GetAllAssets (string syncId = null, string displayName = null, string set = null, string ordering = null, int? limit = null, int? offset = null, bool? includeProxies = null, bool? includeModifiedBy = null, bool? resolveAssetPermission = null, int? forRoot = null)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var syncId = syncId_example;  // string | Filter the returned list by `sync_id`. (optional) 
            var displayName = displayName_example;  // string | Filter the returned list by `display_name`. (optional) 
            var set = set_example;  // string | Filter the returned list by `set`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 
            var includeProxies = true;  // bool? |  (optional) 
            var includeModifiedBy = true;  // bool? |  (optional) 
            var resolveAssetPermission = true;  // bool? |  (optional) 
            var forRoot = 56;  // int? |  (optional) 

            try
            {
                List<Asset> result = apiInstance.GetAllAssets(syncId, displayName, set, ordering, limit, offset, includeProxies, includeModifiedBy, resolveAssetPermission, forRoot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetAllAssets: " + e.Message );
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
 **syncId** | **string**| Filter the returned list by &#x60;sync_id&#x60;. | [optional] 
 **displayName** | **string**| Filter the returned list by &#x60;display_name&#x60;. | [optional] 
 **set** | **string**| Filter the returned list by &#x60;set&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 
 **includeProxies** | **bool?**|  | [optional] 
 **includeModifiedBy** | **bool?**|  | [optional] 
 **resolveAssetPermission** | **bool?**|  | [optional] 
 **forRoot** | **int?**|  | [optional] 

### Return type

[**List&lt;Asset&gt;**](Asset.md)

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

<a name="getallbundlesformediaroot"></a>
# **GetAllBundlesForMediaRoot**
> List&lt;MediaFileBundle&gt; GetAllBundlesForMediaRoot (string root, string asset = null, string location = null, string sharedViaTokens = null, string sharedViaTokensToken = null, string name = null, string ordering = null, int? limit = null, int? offset = null)



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
    public class GetAllBundlesForMediaRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var root = root_example;  // string | 
            var asset = asset_example;  // string | Filter the returned list by `asset`. (optional) 
            var location = location_example;  // string | Filter the returned list by `location`. (optional) 
            var sharedViaTokens = sharedViaTokens_example;  // string | Filter the returned list by `shared_via_tokens`. (optional) 
            var sharedViaTokensToken = sharedViaTokensToken_example;  // string | Filter the returned list by `shared_via_tokens__token`. (optional) 
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<MediaFileBundle> result = apiInstance.GetAllBundlesForMediaRoot(root, asset, location, sharedViaTokens, sharedViaTokensToken, name, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetAllBundlesForMediaRoot: " + e.Message );
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
 **root** | **string**|  | 
 **asset** | **string**| Filter the returned list by &#x60;asset&#x60;. | [optional] 
 **location** | **string**| Filter the returned list by &#x60;location&#x60;. | [optional] 
 **sharedViaTokens** | **string**| Filter the returned list by &#x60;shared_via_tokens&#x60;. | [optional] 
 **sharedViaTokensToken** | **string**| Filter the returned list by &#x60;shared_via_tokens__token&#x60;. | [optional] 
 **name** | **string**| Filter the returned list by &#x60;name&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;MediaFileBundle&gt;**](MediaFileBundle.md)

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

<a name="getallclicklinks"></a>
# **GetAllClickLinks**
> List&lt;AssetCloudLink&gt; GetAllClickLinks (string asset = null, string connection = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllClickLinksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var asset = asset_example;  // string | Filter the returned list by `asset`. (optional) 
            var connection = connection_example;  // string | Filter the returned list by `connection`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<AssetCloudLink> result = apiInstance.GetAllClickLinks(asset, connection, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetAllClickLinks: " + e.Message );
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
 **asset** | **string**| Filter the returned list by &#x60;asset&#x60;. | [optional] 
 **connection** | **string**| Filter the returned list by &#x60;connection&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;AssetCloudLink&gt;**](AssetCloudLink.md)

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

<a name="getallcomments"></a>
# **GetAllComments**
> List&lt;Comment&gt; GetAllComments (string asset = null, string root = null, string user = null, string ordering = null, int? limit = null, int? offset = null, int? forRoot = null, int? tasksForUser = null, bool? includeFullAsset = null, string advancedSearch = null)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllCommentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var asset = asset_example;  // string | Filter the returned list by `asset`. (optional) 
            var root = root_example;  // string | Filter the returned list by `root`. (optional) 
            var user = user_example;  // string | Filter the returned list by `user`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 
            var forRoot = 56;  // int? |  (optional) 
            var tasksForUser = 56;  // int? |  (optional) 
            var includeFullAsset = true;  // bool? |  (optional) 
            var advancedSearch = advancedSearch_example;  // string |  (optional) 

            try
            {
                List<Comment> result = apiInstance.GetAllComments(asset, root, user, ordering, limit, offset, forRoot, tasksForUser, includeFullAsset, advancedSearch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetAllComments: " + e.Message );
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
 **asset** | **string**| Filter the returned list by &#x60;asset&#x60;. | [optional] 
 **root** | **string**| Filter the returned list by &#x60;root&#x60;. | [optional] 
 **user** | **string**| Filter the returned list by &#x60;user&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 
 **forRoot** | **int?**|  | [optional] 
 **tasksForUser** | **int?**|  | [optional] 
 **includeFullAsset** | **bool?**|  | [optional] 
 **advancedSearch** | **string**|  | [optional] 

### Return type

[**List&lt;Comment&gt;**](Comment.md)

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

<a name="getallcustomfields"></a>
# **GetAllCustomFields**
> List&lt;CustomField&gt; GetAllCustomFields (string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllCustomFieldsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<CustomField> result = apiInstance.GetAllCustomFields(ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetAllCustomFields: " + e.Message );
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

[**List&lt;CustomField&gt;**](CustomField.md)

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

<a name="getallexternaltranscoders"></a>
# **GetAllExternalTranscoders**
> List&lt;ExternalTranscoder&gt; GetAllExternalTranscoders (string name = null, decimal? id = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `media:access` (read) / `system:admin-access` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllExternalTranscodersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var id = 8.14;  // decimal? | Filter the returned list by `id`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<ExternalTranscoder> result = apiInstance.GetAllExternalTranscoders(name, id, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetAllExternalTranscoders: " + e.Message );
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

[**List&lt;ExternalTranscoder&gt;**](ExternalTranscoder.md)

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

<a name="getallmarkers"></a>
# **GetAllMarkers**
> List&lt;Marker&gt; GetAllMarkers (string asset = null, string user = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllMarkersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var asset = asset_example;  // string | Filter the returned list by `asset`. (optional) 
            var user = user_example;  // string | Filter the returned list by `user`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<Marker> result = apiInstance.GetAllMarkers(asset, user, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetAllMarkers: " + e.Message );
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
 **asset** | **string**| Filter the returned list by &#x60;asset&#x60;. | [optional] 
 **user** | **string**| Filter the returned list by &#x60;user&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;Marker&gt;**](Marker.md)

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

<a name="getallmediafilebundles"></a>
# **GetAllMediaFileBundles**
> List&lt;MediaFileBundle&gt; GetAllMediaFileBundles (string asset = null, string location = null, string sharedViaTokens = null, string sharedViaTokensToken = null, string name = null, string ordering = null, int? limit = null, int? offset = null, bool? excludeDeleted = null, bool? excludeUnrecognized = null, bool? includeProxies = null, bool? includeParents = null, string advancedSearch = null)



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
    public class GetAllMediaFileBundlesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var asset = asset_example;  // string | Filter the returned list by `asset`. (optional) 
            var location = location_example;  // string | Filter the returned list by `location`. (optional) 
            var sharedViaTokens = sharedViaTokens_example;  // string | Filter the returned list by `shared_via_tokens`. (optional) 
            var sharedViaTokensToken = sharedViaTokensToken_example;  // string | Filter the returned list by `shared_via_tokens__token`. (optional) 
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 
            var excludeDeleted = true;  // bool? |  (optional) 
            var excludeUnrecognized = true;  // bool? |  (optional) 
            var includeProxies = true;  // bool? |  (optional) 
            var includeParents = true;  // bool? |  (optional) 
            var advancedSearch = advancedSearch_example;  // string |  (optional) 

            try
            {
                List<MediaFileBundle> result = apiInstance.GetAllMediaFileBundles(asset, location, sharedViaTokens, sharedViaTokensToken, name, ordering, limit, offset, excludeDeleted, excludeUnrecognized, includeProxies, includeParents, advancedSearch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetAllMediaFileBundles: " + e.Message );
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
 **asset** | **string**| Filter the returned list by &#x60;asset&#x60;. | [optional] 
 **location** | **string**| Filter the returned list by &#x60;location&#x60;. | [optional] 
 **sharedViaTokens** | **string**| Filter the returned list by &#x60;shared_via_tokens&#x60;. | [optional] 
 **sharedViaTokensToken** | **string**| Filter the returned list by &#x60;shared_via_tokens__token&#x60;. | [optional] 
 **name** | **string**| Filter the returned list by &#x60;name&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**|  | [optional] 
 **offset** | **int?**|  | [optional] 
 **excludeDeleted** | **bool?**|  | [optional] 
 **excludeUnrecognized** | **bool?**|  | [optional] 
 **includeProxies** | **bool?**|  | [optional] 
 **includeParents** | **bool?**|  | [optional] 
 **advancedSearch** | **string**|  | [optional] 

### Return type

[**List&lt;MediaFileBundle&gt;**](MediaFileBundle.md)

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

<a name="getallmediafiletemplates"></a>
# **GetAllMediaFileTemplates**
> List&lt;MediaFileTemplate&gt; GetAllMediaFileTemplates (string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllMediaFileTemplatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<MediaFileTemplate> result = apiInstance.GetAllMediaFileTemplates(ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetAllMediaFileTemplates: " + e.Message );
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

[**List&lt;MediaFileTemplate&gt;**](MediaFileTemplate.md)

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

<a name="getallmediafiles"></a>
# **GetAllMediaFiles**
> List&lt;MediaFile&gt; GetAllMediaFiles (string bundle = null, string bundleIn = null, string parent = null, string path = null, string name = null, string isDir = null, string isShowroom = null, string present = null, string volume = null, string sharedViaTokens = null, string sharedViaTokensToken = null, string ordering = null, int? limit = null, int? offset = null, bool? resolveFilePermission = null, bool? includeModifiedBy = null, bool? includeEffectiveCustomFields = null, bool? includeRoot = null, bool? includeParents = null, string advancedSearch = null)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllMediaFilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var bundle = bundle_example;  // string | Filter the returned list by `bundle`. (optional) 
            var bundleIn = bundleIn_example;  // string | Multiple values may be separated by commas. (optional) 
            var parent = parent_example;  // string | Filter the returned list by `parent`. (optional) 
            var path = path_example;  // string | Filter the returned list by `path`. (optional) 
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var isDir = isDir_example;  // string | Filter the returned list by `is_dir`. (optional) 
            var isShowroom = isShowroom_example;  // string | Filter the returned list by `is_showroom`. (optional) 
            var present = present_example;  // string | Filter the returned list by `present`. (optional) 
            var volume = volume_example;  // string | Filter the returned list by `volume`. (optional) 
            var sharedViaTokens = sharedViaTokens_example;  // string | Filter the returned list by `shared_via_tokens`. (optional) 
            var sharedViaTokensToken = sharedViaTokensToken_example;  // string | Filter the returned list by `shared_via_tokens__token`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 
            var resolveFilePermission = true;  // bool? |  (optional) 
            var includeModifiedBy = true;  // bool? |  (optional) 
            var includeEffectiveCustomFields = true;  // bool? |  (optional) 
            var includeRoot = true;  // bool? |  (optional) 
            var includeParents = true;  // bool? |  (optional) 
            var advancedSearch = advancedSearch_example;  // string |  (optional) 

            try
            {
                List<MediaFile> result = apiInstance.GetAllMediaFiles(bundle, bundleIn, parent, path, name, isDir, isShowroom, present, volume, sharedViaTokens, sharedViaTokensToken, ordering, limit, offset, resolveFilePermission, includeModifiedBy, includeEffectiveCustomFields, includeRoot, includeParents, advancedSearch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetAllMediaFiles: " + e.Message );
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
 **bundle** | **string**| Filter the returned list by &#x60;bundle&#x60;. | [optional] 
 **bundleIn** | **string**| Multiple values may be separated by commas. | [optional] 
 **parent** | **string**| Filter the returned list by &#x60;parent&#x60;. | [optional] 
 **path** | **string**| Filter the returned list by &#x60;path&#x60;. | [optional] 
 **name** | **string**| Filter the returned list by &#x60;name&#x60;. | [optional] 
 **isDir** | **string**| Filter the returned list by &#x60;is_dir&#x60;. | [optional] 
 **isShowroom** | **string**| Filter the returned list by &#x60;is_showroom&#x60;. | [optional] 
 **present** | **string**| Filter the returned list by &#x60;present&#x60;. | [optional] 
 **volume** | **string**| Filter the returned list by &#x60;volume&#x60;. | [optional] 
 **sharedViaTokens** | **string**| Filter the returned list by &#x60;shared_via_tokens&#x60;. | [optional] 
 **sharedViaTokensToken** | **string**| Filter the returned list by &#x60;shared_via_tokens__token&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 
 **resolveFilePermission** | **bool?**|  | [optional] 
 **includeModifiedBy** | **bool?**|  | [optional] 
 **includeEffectiveCustomFields** | **bool?**|  | [optional] 
 **includeRoot** | **bool?**|  | [optional] 
 **includeParents** | **bool?**|  | [optional] 
 **advancedSearch** | **string**|  | [optional] 

### Return type

[**List&lt;MediaFile&gt;**](MediaFile.md)

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

<a name="getallmediafilesforbundles"></a>
# **GetAllMediaFilesForBundles**
> List&lt;MediaFile&gt; GetAllMediaFilesForBundles (AllMediaFilesForBundlesRequest allMediaFilesForBundlesRequest)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllMediaFilesForBundlesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var allMediaFilesForBundlesRequest = new AllMediaFilesForBundlesRequest(); // AllMediaFilesForBundlesRequest | 

            try
            {
                List<MediaFile> result = apiInstance.GetAllMediaFilesForBundles(allMediaFilesForBundlesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetAllMediaFilesForBundles: " + e.Message );
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
 **allMediaFilesForBundlesRequest** | [**AllMediaFilesForBundlesRequest**](AllMediaFilesForBundlesRequest.md)|  | 

### Return type

[**List&lt;MediaFile&gt;**](MediaFile.md)

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

<a name="getallmediafilesformediaroot"></a>
# **GetAllMediaFilesForMediaRoot**
> List&lt;MediaFile&gt; GetAllMediaFilesForMediaRoot (string root, string bundle = null, string bundleIn = null, string parent = null, string path = null, string name = null, string isDir = null, string isShowroom = null, string present = null, string volume = null, string sharedViaTokens = null, string sharedViaTokensToken = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllMediaFilesForMediaRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var root = root_example;  // string | 
            var bundle = bundle_example;  // string | Filter the returned list by `bundle`. (optional) 
            var bundleIn = bundleIn_example;  // string | Multiple values may be separated by commas. (optional) 
            var parent = parent_example;  // string | Filter the returned list by `parent`. (optional) 
            var path = path_example;  // string | Filter the returned list by `path`. (optional) 
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var isDir = isDir_example;  // string | Filter the returned list by `is_dir`. (optional) 
            var isShowroom = isShowroom_example;  // string | Filter the returned list by `is_showroom`. (optional) 
            var present = present_example;  // string | Filter the returned list by `present`. (optional) 
            var volume = volume_example;  // string | Filter the returned list by `volume`. (optional) 
            var sharedViaTokens = sharedViaTokens_example;  // string | Filter the returned list by `shared_via_tokens`. (optional) 
            var sharedViaTokensToken = sharedViaTokensToken_example;  // string | Filter the returned list by `shared_via_tokens__token`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<MediaFile> result = apiInstance.GetAllMediaFilesForMediaRoot(root, bundle, bundleIn, parent, path, name, isDir, isShowroom, present, volume, sharedViaTokens, sharedViaTokensToken, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetAllMediaFilesForMediaRoot: " + e.Message );
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
 **root** | **string**|  | 
 **bundle** | **string**| Filter the returned list by &#x60;bundle&#x60;. | [optional] 
 **bundleIn** | **string**| Multiple values may be separated by commas. | [optional] 
 **parent** | **string**| Filter the returned list by &#x60;parent&#x60;. | [optional] 
 **path** | **string**| Filter the returned list by &#x60;path&#x60;. | [optional] 
 **name** | **string**| Filter the returned list by &#x60;name&#x60;. | [optional] 
 **isDir** | **string**| Filter the returned list by &#x60;is_dir&#x60;. | [optional] 
 **isShowroom** | **string**| Filter the returned list by &#x60;is_showroom&#x60;. | [optional] 
 **present** | **string**| Filter the returned list by &#x60;present&#x60;. | [optional] 
 **volume** | **string**| Filter the returned list by &#x60;volume&#x60;. | [optional] 
 **sharedViaTokens** | **string**| Filter the returned list by &#x60;shared_via_tokens&#x60;. | [optional] 
 **sharedViaTokensToken** | **string**| Filter the returned list by &#x60;shared_via_tokens__token&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;MediaFile&gt;**](MediaFile.md)

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

<a name="getallmediarootpermissions"></a>
# **GetAllMediaRootPermissions**
> List&lt;MediaRootPermission&gt; GetAllMediaRootPermissions (string root = null, decimal? id = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllMediaRootPermissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var root = root_example;  // string | Filter the returned list by `root`. (optional) 
            var id = 8.14;  // decimal? | Filter the returned list by `id`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<MediaRootPermission> result = apiInstance.GetAllMediaRootPermissions(root, id, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetAllMediaRootPermissions: " + e.Message );
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
 **root** | **string**| Filter the returned list by &#x60;root&#x60;. | [optional] 
 **id** | **decimal?**| Filter the returned list by &#x60;id&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;MediaRootPermission&gt;**](MediaRootPermission.md)

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

<a name="getallmediaroots"></a>
# **GetAllMediaRoots**
> List&lt;MediaRoot&gt; GetAllMediaRoots (string path = null, string volume = null, string name = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllMediaRootsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var path = path_example;  // string | Filter the returned list by `path`. (optional) 
            var volume = volume_example;  // string | Filter the returned list by `volume`. (optional) 
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<MediaRoot> result = apiInstance.GetAllMediaRoots(path, volume, name, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetAllMediaRoots: " + e.Message );
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
 **path** | **string**| Filter the returned list by &#x60;path&#x60;. | [optional] 
 **volume** | **string**| Filter the returned list by &#x60;volume&#x60;. | [optional] 
 **name** | **string**| Filter the returned list by &#x60;name&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;MediaRoot&gt;**](MediaRoot.md)

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

<a name="getallmediatags"></a>
# **GetAllMediaTags**
> List&lt;UnfilteredTag&gt; GetAllMediaTags (string name = null, string nameIcontains = null, string roots = null, string rootsIsnull = null, string shared = null, string ordering = null, int? limit = null, int? offset = null, int? forRoot = null)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllMediaTagsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var nameIcontains = nameIcontains_example;  // string | Filter the returned list by `name__icontains`. (optional) 
            var roots = roots_example;  // string | Filter the returned list by `roots`. (optional) 
            var rootsIsnull = rootsIsnull_example;  // string | Filter the returned list by `roots__isnull`. (optional) 
            var shared = shared_example;  // string | Filter the returned list by `shared`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 
            var forRoot = 56;  // int? |  (optional) 

            try
            {
                List<UnfilteredTag> result = apiInstance.GetAllMediaTags(name, nameIcontains, roots, rootsIsnull, shared, ordering, limit, offset, forRoot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetAllMediaTags: " + e.Message );
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
 **nameIcontains** | **string**| Filter the returned list by &#x60;name__icontains&#x60;. | [optional] 
 **roots** | **string**| Filter the returned list by &#x60;roots&#x60;. | [optional] 
 **rootsIsnull** | **string**| Filter the returned list by &#x60;roots__isnull&#x60;. | [optional] 
 **shared** | **string**| Filter the returned list by &#x60;shared&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 
 **forRoot** | **int?**|  | [optional] 

### Return type

[**List&lt;UnfilteredTag&gt;**](UnfilteredTag.md)

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

<a name="getallmediaupdates"></a>
# **GetAllMediaUpdates**
> List&lt;MediaUpdate&gt; GetAllMediaUpdates (string asset = null, string user = null, string root = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `media:access` (read) / `media:updates:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllMediaUpdatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var asset = asset_example;  // string | Filter the returned list by `asset`. (optional) 
            var user = user_example;  // string | Filter the returned list by `user`. (optional) 
            var root = root_example;  // string | Filter the returned list by `root`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<MediaUpdate> result = apiInstance.GetAllMediaUpdates(asset, user, root, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetAllMediaUpdates: " + e.Message );
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
 **asset** | **string**| Filter the returned list by &#x60;asset&#x60;. | [optional] 
 **user** | **string**| Filter the returned list by &#x60;user&#x60;. | [optional] 
 **root** | **string**| Filter the returned list by &#x60;root&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;MediaUpdate&gt;**](MediaUpdate.md)

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

<a name="getallproxygenerators"></a>
# **GetAllProxyGenerators**
> List&lt;ProxyGenerator&gt; GetAllProxyGenerators (string ordering = null, int? limit = null, int? offset = null)



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
    public class GetAllProxyGeneratorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<ProxyGenerator> result = apiInstance.GetAllProxyGenerators(ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetAllProxyGenerators: " + e.Message );
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

[**List&lt;ProxyGenerator&gt;**](ProxyGenerator.md)

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

<a name="getallproxyprofiles"></a>
# **GetAllProxyProfiles**
> List&lt;ProxyProfile&gt; GetAllProxyProfiles (string name = null, string ordering = null, int? limit = null, int? offset = null, int? forRoot = null)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllProxyProfilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 
            var forRoot = 56;  // int? |  (optional) 

            try
            {
                List<ProxyProfile> result = apiInstance.GetAllProxyProfiles(name, ordering, limit, offset, forRoot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetAllProxyProfiles: " + e.Message );
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
 **forRoot** | **int?**|  | [optional] 

### Return type

[**List&lt;ProxyProfile&gt;**](ProxyProfile.md)

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

<a name="getallsubclipclipboardentries"></a>
# **GetAllSubclipClipboardEntries**
> List&lt;SubclipClipboardEntry&gt; GetAllSubclipClipboardEntries (string cut = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllSubclipClipboardEntriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var cut = cut_example;  // string | Filter the returned list by `cut`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<SubclipClipboardEntry> result = apiInstance.GetAllSubclipClipboardEntries(cut, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetAllSubclipClipboardEntries: " + e.Message );
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
 **cut** | **string**| Filter the returned list by &#x60;cut&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;SubclipClipboardEntry&gt;**](SubclipClipboardEntry.md)

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

<a name="getallsubclips"></a>
# **GetAllSubclips**
> List&lt;Subclip&gt; GetAllSubclips (string asset = null, string assetIn = null, string root = null, string name = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllSubclipsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var asset = asset_example;  // string | Filter the returned list by `asset`. (optional) 
            var assetIn = assetIn_example;  // string | Multiple values may be separated by commas. (optional) 
            var root = root_example;  // string | Filter the returned list by `root`. (optional) 
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<Subclip> result = apiInstance.GetAllSubclips(asset, assetIn, root, name, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetAllSubclips: " + e.Message );
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
 **asset** | **string**| Filter the returned list by &#x60;asset&#x60;. | [optional] 
 **assetIn** | **string**| Multiple values may be separated by commas. | [optional] 
 **root** | **string**| Filter the returned list by &#x60;root&#x60;. | [optional] 
 **name** | **string**| Filter the returned list by &#x60;name&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;Subclip&gt;**](Subclip.md)

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

<a name="getalltranscoderprofiles"></a>
# **GetAllTranscoderProfiles**
> List&lt;TranscoderProfile&gt; GetAllTranscoderProfiles (string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `tasks:view` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllTranscoderProfilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<TranscoderProfile> result = apiInstance.GetAllTranscoderProfiles(ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetAllTranscoderProfiles: " + e.Message );
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

[**List&lt;TranscoderProfile&gt;**](TranscoderProfile.md)

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

<a name="getasset"></a>
# **GetAsset**
> Asset GetAsset (int id, bool? includeProxies = null, bool? includeModifiedBy = null, bool? resolveAssetPermission = null, int? forRoot = null)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Asset.
            var includeProxies = true;  // bool? |  (optional) 
            var includeModifiedBy = true;  // bool? |  (optional) 
            var resolveAssetPermission = true;  // bool? |  (optional) 
            var forRoot = 56;  // int? |  (optional) 

            try
            {
                Asset result = apiInstance.GetAsset(id, includeProxies, includeModifiedBy, resolveAssetPermission, forRoot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetAsset: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Asset. | 
 **includeProxies** | **bool?**|  | [optional] 
 **includeModifiedBy** | **bool?**|  | [optional] 
 **resolveAssetPermission** | **bool?**|  | [optional] 
 **forRoot** | **int?**|  | [optional] 

### Return type

[**Asset**](Asset.md)

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

<a name="getassetrating"></a>
# **GetAssetRating**
> AssetRating GetAssetRating (int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAssetRatingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Rating.

            try
            {
                AssetRating result = apiInstance.GetAssetRating(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetAssetRating: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Rating. | 

### Return type

[**AssetRating**](AssetRating.md)

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

<a name="getbookmarkedmediafilesdirectories"></a>
# **GetBookmarkedMediaFilesDirectories**
> List&lt;MediaFile&gt; GetBookmarkedMediaFilesDirectories (string bundle = null, string bundleIn = null, string parent = null, string path = null, string name = null, string isDir = null, string isShowroom = null, string present = null, string volume = null, string sharedViaTokens = null, string sharedViaTokensToken = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetBookmarkedMediaFilesDirectoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var bundle = bundle_example;  // string | Filter the returned list by `bundle`. (optional) 
            var bundleIn = bundleIn_example;  // string | Multiple values may be separated by commas. (optional) 
            var parent = parent_example;  // string | Filter the returned list by `parent`. (optional) 
            var path = path_example;  // string | Filter the returned list by `path`. (optional) 
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var isDir = isDir_example;  // string | Filter the returned list by `is_dir`. (optional) 
            var isShowroom = isShowroom_example;  // string | Filter the returned list by `is_showroom`. (optional) 
            var present = present_example;  // string | Filter the returned list by `present`. (optional) 
            var volume = volume_example;  // string | Filter the returned list by `volume`. (optional) 
            var sharedViaTokens = sharedViaTokens_example;  // string | Filter the returned list by `shared_via_tokens`. (optional) 
            var sharedViaTokensToken = sharedViaTokensToken_example;  // string | Filter the returned list by `shared_via_tokens__token`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<MediaFile> result = apiInstance.GetBookmarkedMediaFilesDirectories(bundle, bundleIn, parent, path, name, isDir, isShowroom, present, volume, sharedViaTokens, sharedViaTokensToken, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetBookmarkedMediaFilesDirectories: " + e.Message );
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
 **bundle** | **string**| Filter the returned list by &#x60;bundle&#x60;. | [optional] 
 **bundleIn** | **string**| Multiple values may be separated by commas. | [optional] 
 **parent** | **string**| Filter the returned list by &#x60;parent&#x60;. | [optional] 
 **path** | **string**| Filter the returned list by &#x60;path&#x60;. | [optional] 
 **name** | **string**| Filter the returned list by &#x60;name&#x60;. | [optional] 
 **isDir** | **string**| Filter the returned list by &#x60;is_dir&#x60;. | [optional] 
 **isShowroom** | **string**| Filter the returned list by &#x60;is_showroom&#x60;. | [optional] 
 **present** | **string**| Filter the returned list by &#x60;present&#x60;. | [optional] 
 **volume** | **string**| Filter the returned list by &#x60;volume&#x60;. | [optional] 
 **sharedViaTokens** | **string**| Filter the returned list by &#x60;shared_via_tokens&#x60;. | [optional] 
 **sharedViaTokensToken** | **string**| Filter the returned list by &#x60;shared_via_tokens__token&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;MediaFile&gt;**](MediaFile.md)

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

<a name="getcomment"></a>
# **GetComment**
> Comment GetComment (int id, int? forRoot = null, int? tasksForUser = null, bool? includeFullAsset = null, string advancedSearch = null)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Comment.
            var forRoot = 56;  // int? |  (optional) 
            var tasksForUser = 56;  // int? |  (optional) 
            var includeFullAsset = true;  // bool? |  (optional) 
            var advancedSearch = advancedSearch_example;  // string |  (optional) 

            try
            {
                Comment result = apiInstance.GetComment(id, forRoot, tasksForUser, includeFullAsset, advancedSearch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetComment: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Comment. | 
 **forRoot** | **int?**|  | [optional] 
 **tasksForUser** | **int?**|  | [optional] 
 **includeFullAsset** | **bool?**|  | [optional] 
 **advancedSearch** | **string**|  | [optional] 

### Return type

[**Comment**](Comment.md)

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

<a name="getcustomfield"></a>
# **GetCustomField**
> CustomField GetCustomField (int id)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetCustomFieldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Custom field.

            try
            {
                CustomField result = apiInstance.GetCustomField(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetCustomField: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Custom field. | 

### Return type

[**CustomField**](CustomField.md)

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

<a name="geteasysharingtokenforbundle"></a>
# **GetEasySharingTokenForBundle**
> OneTimeAccessToken GetEasySharingTokenForBundle (int id)



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
    public class GetEasySharingTokenForBundleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Bundle.

            try
            {
                OneTimeAccessToken result = apiInstance.GetEasySharingTokenForBundle(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetEasySharingTokenForBundle: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Bundle. | 

### Return type

[**OneTimeAccessToken**](OneTimeAccessToken.md)

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

<a name="geteasysharingtokenfordirectory"></a>
# **GetEasySharingTokenForDirectory**
> OneTimeAccessToken GetEasySharingTokenForDirectory (int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetEasySharingTokenForDirectoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this File.

            try
            {
                OneTimeAccessToken result = apiInstance.GetEasySharingTokenForDirectory(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetEasySharingTokenForDirectory: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this File. | 

### Return type

[**OneTimeAccessToken**](OneTimeAccessToken.md)

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

<a name="geteditorproject"></a>
# **GetEditorProject**
> EditorProject GetEditorProject (int id)



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
    public class GetEditorProjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this File.

            try
            {
                EditorProject result = apiInstance.GetEditorProject(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetEditorProject: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this File. | 

### Return type

[**EditorProject**](EditorProject.md)

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

<a name="getexternaltranscoder"></a>
# **GetExternalTranscoder**
> ExternalTranscoder GetExternalTranscoder (int id)



### Required permissions    * User account permission: `media:access` (read) / `system:admin-access` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetExternalTranscoderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this external transcoder.

            try
            {
                ExternalTranscoder result = apiInstance.GetExternalTranscoder(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetExternalTranscoder: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this external transcoder. | 

### Return type

[**ExternalTranscoder**](ExternalTranscoder.md)

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

<a name="getframe"></a>
# **GetFrame**
> void GetFrame (string frame, int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetFrameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var frame = frame_example;  // string | 
            var id = 56;  // int | A unique integer value identifying this Asset.

            try
            {
                apiInstance.GetFrame(frame, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetFrame: " + e.Message );
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
 **frame** | **string**|  | 
 **id** | **int**| A unique integer value identifying this Asset. | 

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

<a name="getlatestmediaupdate"></a>
# **GetLatestMediaUpdate**
> MediaUpdate GetLatestMediaUpdate (string asset = null, string user = null, string root = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `media:access` (read) / `media:updates:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetLatestMediaUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var asset = asset_example;  // string | Filter the returned list by `asset`. (optional) 
            var user = user_example;  // string | Filter the returned list by `user`. (optional) 
            var root = root_example;  // string | Filter the returned list by `root`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                MediaUpdate result = apiInstance.GetLatestMediaUpdate(asset, user, root, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetLatestMediaUpdate: " + e.Message );
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
 **asset** | **string**| Filter the returned list by &#x60;asset&#x60;. | [optional] 
 **user** | **string**| Filter the returned list by &#x60;user&#x60;. | [optional] 
 **root** | **string**| Filter the returned list by &#x60;root&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**MediaUpdate**](MediaUpdate.md)

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

<a name="getmarker"></a>
# **GetMarker**
> Marker GetMarker (int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetMarkerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this marker.

            try
            {
                Marker result = apiInstance.GetMarker(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetMarker: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this marker. | 

### Return type

[**Marker**](Marker.md)

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

<a name="getmediafile"></a>
# **GetMediaFile**
> MediaFile GetMediaFile (int id, bool? resolveFilePermission = null, bool? includeModifiedBy = null, bool? includeEffectiveCustomFields = null, bool? includeRoot = null, bool? includeParents = null, string advancedSearch = null)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetMediaFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this File.
            var resolveFilePermission = true;  // bool? |  (optional) 
            var includeModifiedBy = true;  // bool? |  (optional) 
            var includeEffectiveCustomFields = true;  // bool? |  (optional) 
            var includeRoot = true;  // bool? |  (optional) 
            var includeParents = true;  // bool? |  (optional) 
            var advancedSearch = advancedSearch_example;  // string |  (optional) 

            try
            {
                MediaFile result = apiInstance.GetMediaFile(id, resolveFilePermission, includeModifiedBy, includeEffectiveCustomFields, includeRoot, includeParents, advancedSearch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetMediaFile: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this File. | 
 **resolveFilePermission** | **bool?**|  | [optional] 
 **includeModifiedBy** | **bool?**|  | [optional] 
 **includeEffectiveCustomFields** | **bool?**|  | [optional] 
 **includeRoot** | **bool?**|  | [optional] 
 **includeParents** | **bool?**|  | [optional] 
 **advancedSearch** | **string**|  | [optional] 

### Return type

[**MediaFile**](MediaFile.md)

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

<a name="getmediafilebundle"></a>
# **GetMediaFileBundle**
> MediaFileBundle GetMediaFileBundle (int id, bool? excludeDeleted = null, bool? excludeUnrecognized = null, bool? includeProxies = null, bool? includeParents = null, int? offset = null, int? limit = null, string advancedSearch = null)



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
    public class GetMediaFileBundleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Bundle.
            var excludeDeleted = true;  // bool? |  (optional) 
            var excludeUnrecognized = true;  // bool? |  (optional) 
            var includeProxies = true;  // bool? |  (optional) 
            var includeParents = true;  // bool? |  (optional) 
            var offset = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var advancedSearch = advancedSearch_example;  // string |  (optional) 

            try
            {
                MediaFileBundle result = apiInstance.GetMediaFileBundle(id, excludeDeleted, excludeUnrecognized, includeProxies, includeParents, offset, limit, advancedSearch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetMediaFileBundle: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Bundle. | 
 **excludeDeleted** | **bool?**|  | [optional] 
 **excludeUnrecognized** | **bool?**|  | [optional] 
 **includeProxies** | **bool?**|  | [optional] 
 **includeParents** | **bool?**|  | [optional] 
 **offset** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **advancedSearch** | **string**|  | [optional] 

### Return type

[**MediaFileBundle**](MediaFileBundle.md)

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

<a name="getmediafilecontents"></a>
# **GetMediaFileContents**
> MediaFileContents GetMediaFileContents (int id, bool? excludeDeleted = null, bool? excludeUnrecognized = null, int? offset = null, int? limit = null)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetMediaFileContentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this File.
            var excludeDeleted = true;  // bool? |  (optional) 
            var excludeUnrecognized = true;  // bool? |  (optional) 
            var offset = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                MediaFileContents result = apiInstance.GetMediaFileContents(id, excludeDeleted, excludeUnrecognized, offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetMediaFileContents: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this File. | 
 **excludeDeleted** | **bool?**|  | [optional] 
 **excludeUnrecognized** | **bool?**|  | [optional] 
 **offset** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**MediaFileContents**](MediaFileContents.md)

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

<a name="getmediafiletemplate"></a>
# **GetMediaFileTemplate**
> MediaFileTemplate GetMediaFileTemplate (int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetMediaFileTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Template.

            try
            {
                MediaFileTemplate result = apiInstance.GetMediaFileTemplate(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetMediaFileTemplate: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Template. | 

### Return type

[**MediaFileTemplate**](MediaFileTemplate.md)

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

<a name="getmediaroot"></a>
# **GetMediaRoot**
> MediaRoot GetMediaRoot (int id)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetMediaRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this media root.

            try
            {
                MediaRoot result = apiInstance.GetMediaRoot(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetMediaRoot: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this media root. | 

### Return type

[**MediaRoot**](MediaRoot.md)

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

<a name="getmediarootpermission"></a>
# **GetMediaRootPermission**
> MediaRootPermission GetMediaRootPermission (int id)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetMediaRootPermissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Media Root Permission.

            try
            {
                MediaRootPermission result = apiInstance.GetMediaRootPermission(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetMediaRootPermission: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Media Root Permission. | 

### Return type

[**MediaRootPermission**](MediaRootPermission.md)

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

<a name="getmediatag"></a>
# **GetMediaTag**
> UnfilteredTag GetMediaTag (int id, int? forRoot = null)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetMediaTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Tag.
            var forRoot = 56;  // int? |  (optional) 

            try
            {
                UnfilteredTag result = apiInstance.GetMediaTag(id, forRoot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetMediaTag: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Tag. | 
 **forRoot** | **int?**|  | [optional] 

### Return type

[**UnfilteredTag**](UnfilteredTag.md)

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

<a name="getmultipleassets"></a>
# **GetMultipleAssets**
> List&lt;Asset&gt; GetMultipleAssets (MultipleAssetsRequest multipleAssetsRequest)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetMultipleAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var multipleAssetsRequest = new MultipleAssetsRequest(); // MultipleAssetsRequest | 

            try
            {
                List<Asset> result = apiInstance.GetMultipleAssets(multipleAssetsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetMultipleAssets: " + e.Message );
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
 **multipleAssetsRequest** | [**MultipleAssetsRequest**](MultipleAssetsRequest.md)|  | 

### Return type

[**List&lt;Asset&gt;**](Asset.md)

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

<a name="getmultiplebundles"></a>
# **GetMultipleBundles**
> List&lt;MediaFileBundle&gt; GetMultipleBundles (GetMultipleBundlesRequest getMultipleBundlesRequest)



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
    public class GetMultipleBundlesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var getMultipleBundlesRequest = new GetMultipleBundlesRequest(); // GetMultipleBundlesRequest | 

            try
            {
                List<MediaFileBundle> result = apiInstance.GetMultipleBundles(getMultipleBundlesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetMultipleBundles: " + e.Message );
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
 **getMultipleBundlesRequest** | [**GetMultipleBundlesRequest**](GetMultipleBundlesRequest.md)|  | 

### Return type

[**List&lt;MediaFileBundle&gt;**](MediaFileBundle.md)

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

<a name="getmultiplefiles"></a>
# **GetMultipleFiles**
> List&lt;MediaFile&gt; GetMultipleFiles (GetMultipleFilesRequest getMultipleFilesRequest)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetMultipleFilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var getMultipleFilesRequest = new GetMultipleFilesRequest(); // GetMultipleFilesRequest | 

            try
            {
                List<MediaFile> result = apiInstance.GetMultipleFiles(getMultipleFilesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetMultipleFiles: " + e.Message );
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
 **getMultipleFilesRequest** | [**GetMultipleFilesRequest**](GetMultipleFilesRequest.md)|  | 

### Return type

[**List&lt;MediaFile&gt;**](MediaFile.md)

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

<a name="getmymediarootpermissions"></a>
# **GetMyMediaRootPermissions**
> List&lt;MediaRootPermission&gt; GetMyMediaRootPermissions (string root = null, decimal? id = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetMyMediaRootPermissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var root = root_example;  // string | Filter the returned list by `root`. (optional) 
            var id = 8.14;  // decimal? | Filter the returned list by `id`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<MediaRootPermission> result = apiInstance.GetMyMediaRootPermissions(root, id, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetMyMediaRootPermissions: " + e.Message );
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
 **root** | **string**| Filter the returned list by &#x60;root&#x60;. | [optional] 
 **id** | **decimal?**| Filter the returned list by &#x60;id&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;MediaRootPermission&gt;**](MediaRootPermission.md)

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

<a name="getmyresolvedmediarootpermissions"></a>
# **GetMyResolvedMediaRootPermissions**
> List&lt;MediaRootPermission&gt; GetMyResolvedMediaRootPermissions (string root = null, decimal? id = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetMyResolvedMediaRootPermissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var root = root_example;  // string | Filter the returned list by `root`. (optional) 
            var id = 8.14;  // decimal? | Filter the returned list by `id`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<MediaRootPermission> result = apiInstance.GetMyResolvedMediaRootPermissions(root, id, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetMyResolvedMediaRootPermissions: " + e.Message );
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
 **root** | **string**| Filter the returned list by &#x60;root&#x60;. | [optional] 
 **id** | **decimal?**| Filter the returned list by &#x60;id&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;MediaRootPermission&gt;**](MediaRootPermission.md)

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

<a name="getproxy"></a>
# **GetProxy**
> Proxy GetProxy (int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetProxyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this proxy.

            try
            {
                Proxy result = apiInstance.GetProxy(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetProxy: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this proxy. | 

### Return type

[**Proxy**](Proxy.md)

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

<a name="getproxygenerator"></a>
# **GetProxyGenerator**
> ProxyGenerator GetProxyGenerator (string id)



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
    public class GetProxyGeneratorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = id_example;  // string | 

            try
            {
                ProxyGenerator result = apiInstance.GetProxyGenerator(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetProxyGenerator: " + e.Message );
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

[**ProxyGenerator**](ProxyGenerator.md)

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

<a name="getproxyprofile"></a>
# **GetProxyProfile**
> ProxyProfile GetProxyProfile (int id, int? forRoot = null)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetProxyProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this proxy profile.
            var forRoot = 56;  // int? |  (optional) 

            try
            {
                ProxyProfile result = apiInstance.GetProxyProfile(id, forRoot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetProxyProfile: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this proxy profile. | 
 **forRoot** | **int?**|  | [optional] 

### Return type

[**ProxyProfile**](ProxyProfile.md)

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

<a name="getproxyprofileproxycount"></a>
# **GetProxyProfileProxyCount**
> ProxyCount GetProxyProfileProxyCount (int id)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetProxyProfileProxyCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this proxy profile.

            try
            {
                ProxyCount result = apiInstance.GetProxyProfileProxyCount(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetProxyProfileProxyCount: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this proxy profile. | 

### Return type

[**ProxyCount**](ProxyCount.md)

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

<a name="getsubclip"></a>
# **GetSubclip**
> Subclip GetSubclip (int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetSubclipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this subclip.

            try
            {
                Subclip result = apiInstance.GetSubclip(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetSubclip: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this subclip. | 

### Return type

[**Subclip**](Subclip.md)

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

<a name="gettranscoderprofile"></a>
# **GetTranscoderProfile**
> TranscoderProfile GetTranscoderProfile (int id)



### Required permissions    * User account permission: `tasks:view` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetTranscoderProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this transcoder profile.

            try
            {
                TranscoderProfile result = apiInstance.GetTranscoderProfile(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetTranscoderProfile: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this transcoder profile. | 

### Return type

[**TranscoderProfile**](TranscoderProfile.md)

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

<a name="getvantageworkflows"></a>
# **GetVantageWorkflows**
> VantageWorkflows GetVantageWorkflows (int id)



### Required permissions    * User account permission: `media:access` (read) / `system:admin-access` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetVantageWorkflowsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this external transcoder.

            try
            {
                VantageWorkflows result = apiInstance.GetVantageWorkflows(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.GetVantageWorkflows: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this external transcoder. | 

### Return type

[**VantageWorkflows**](VantageWorkflows.md)

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

<a name="instantiatemediafiletemplate"></a>
# **InstantiateMediaFileTemplate**
> void InstantiateMediaFileTemplate (int id, InstantiateFileTemplateRequest instantiateFileTemplateRequest)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class InstantiateMediaFileTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Template.
            var instantiateFileTemplateRequest = new InstantiateFileTemplateRequest(); // InstantiateFileTemplateRequest | 

            try
            {
                apiInstance.InstantiateMediaFileTemplate(id, instantiateFileTemplateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.InstantiateMediaFileTemplate: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Template. | 
 **instantiateFileTemplateRequest** | [**InstantiateFileTemplateRequest**](InstantiateFileTemplateRequest.md)|  | 

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

<a name="locateeditorprojectpaths"></a>
# **LocateEditorProjectPaths**
> List&lt;LocateResult&gt; LocateEditorProjectPaths (int id)



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
    public class LocateEditorProjectPathsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this File.

            try
            {
                List<LocateResult> result = apiInstance.LocateEditorProjectPaths(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.LocateEditorProjectPaths: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this File. | 

### Return type

[**List&lt;LocateResult&gt;**](LocateResult.md)

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

<a name="markmediadirectoryasshowroom"></a>
# **MarkMediaDirectoryAsShowroom**
> void MarkMediaDirectoryAsShowroom (int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class MarkMediaDirectoryAsShowroomExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this File.

            try
            {
                apiInstance.MarkMediaDirectoryAsShowroom(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.MarkMediaDirectoryAsShowroom: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this File. | 

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

<a name="patchasset"></a>
# **PatchAsset**
> Asset PatchAsset (int id, AssetPartialUpdate assetPartialUpdate)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Asset.
            var assetPartialUpdate = new AssetPartialUpdate(); // AssetPartialUpdate | 

            try
            {
                Asset result = apiInstance.PatchAsset(id, assetPartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.PatchAsset: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Asset. | 
 **assetPartialUpdate** | [**AssetPartialUpdate**](AssetPartialUpdate.md)|  | 

### Return type

[**Asset**](Asset.md)

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

<a name="patchassetrating"></a>
# **PatchAssetRating**
> AssetRating PatchAssetRating (int id, AssetRatingPartialUpdate assetRatingPartialUpdate)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchAssetRatingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Rating.
            var assetRatingPartialUpdate = new AssetRatingPartialUpdate(); // AssetRatingPartialUpdate | 

            try
            {
                AssetRating result = apiInstance.PatchAssetRating(id, assetRatingPartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.PatchAssetRating: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Rating. | 
 **assetRatingPartialUpdate** | [**AssetRatingPartialUpdate**](AssetRatingPartialUpdate.md)|  | 

### Return type

[**AssetRating**](AssetRating.md)

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

<a name="patchcomment"></a>
# **PatchComment**
> Comment PatchComment (int id, CommentPartialUpdate commentPartialUpdate)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Comment.
            var commentPartialUpdate = new CommentPartialUpdate(); // CommentPartialUpdate | 

            try
            {
                Comment result = apiInstance.PatchComment(id, commentPartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.PatchComment: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Comment. | 
 **commentPartialUpdate** | [**CommentPartialUpdate**](CommentPartialUpdate.md)|  | 

### Return type

[**Comment**](Comment.md)

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

<a name="patchcustomfield"></a>
# **PatchCustomField**
> CustomField PatchCustomField (int id, CustomFieldPartialUpdate customFieldPartialUpdate)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchCustomFieldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Custom field.
            var customFieldPartialUpdate = new CustomFieldPartialUpdate(); // CustomFieldPartialUpdate | 

            try
            {
                CustomField result = apiInstance.PatchCustomField(id, customFieldPartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.PatchCustomField: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Custom field. | 
 **customFieldPartialUpdate** | [**CustomFieldPartialUpdate**](CustomFieldPartialUpdate.md)|  | 

### Return type

[**CustomField**](CustomField.md)

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

<a name="patcheditorproject"></a>
# **PatchEditorProject**
> EditorProject PatchEditorProject (int id, EditorProjectPartialUpdate editorProjectPartialUpdate)



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
    public class PatchEditorProjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this File.
            var editorProjectPartialUpdate = new EditorProjectPartialUpdate(); // EditorProjectPartialUpdate | 

            try
            {
                EditorProject result = apiInstance.PatchEditorProject(id, editorProjectPartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.PatchEditorProject: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this File. | 
 **editorProjectPartialUpdate** | [**EditorProjectPartialUpdate**](EditorProjectPartialUpdate.md)|  | 

### Return type

[**EditorProject**](EditorProject.md)

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

<a name="patchexternaltranscoder"></a>
# **PatchExternalTranscoder**
> ExternalTranscoder PatchExternalTranscoder (int id, ExternalTranscoderPartialUpdate externalTranscoderPartialUpdate)



### Required permissions    * User account permission: `media:access` (read) / `system:admin-access` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchExternalTranscoderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this external transcoder.
            var externalTranscoderPartialUpdate = new ExternalTranscoderPartialUpdate(); // ExternalTranscoderPartialUpdate | 

            try
            {
                ExternalTranscoder result = apiInstance.PatchExternalTranscoder(id, externalTranscoderPartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.PatchExternalTranscoder: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this external transcoder. | 
 **externalTranscoderPartialUpdate** | [**ExternalTranscoderPartialUpdate**](ExternalTranscoderPartialUpdate.md)|  | 

### Return type

[**ExternalTranscoder**](ExternalTranscoder.md)

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

<a name="patchmarker"></a>
# **PatchMarker**
> Marker PatchMarker (int id, MarkerPartialUpdate markerPartialUpdate)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchMarkerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this marker.
            var markerPartialUpdate = new MarkerPartialUpdate(); // MarkerPartialUpdate | 

            try
            {
                Marker result = apiInstance.PatchMarker(id, markerPartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.PatchMarker: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this marker. | 
 **markerPartialUpdate** | [**MarkerPartialUpdate**](MarkerPartialUpdate.md)|  | 

### Return type

[**Marker**](Marker.md)

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

<a name="patchmediafile"></a>
# **PatchMediaFile**
> MediaFile PatchMediaFile (int id, MediaFilePartialUpdate mediaFilePartialUpdate)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchMediaFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this File.
            var mediaFilePartialUpdate = new MediaFilePartialUpdate(); // MediaFilePartialUpdate | 

            try
            {
                MediaFile result = apiInstance.PatchMediaFile(id, mediaFilePartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.PatchMediaFile: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this File. | 
 **mediaFilePartialUpdate** | [**MediaFilePartialUpdate**](MediaFilePartialUpdate.md)|  | 

### Return type

[**MediaFile**](MediaFile.md)

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

<a name="patchmediafiletemplate"></a>
# **PatchMediaFileTemplate**
> MediaFileTemplate PatchMediaFileTemplate (int id, MediaFileTemplatePartialUpdate mediaFileTemplatePartialUpdate)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchMediaFileTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Template.
            var mediaFileTemplatePartialUpdate = new MediaFileTemplatePartialUpdate(); // MediaFileTemplatePartialUpdate | 

            try
            {
                MediaFileTemplate result = apiInstance.PatchMediaFileTemplate(id, mediaFileTemplatePartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.PatchMediaFileTemplate: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Template. | 
 **mediaFileTemplatePartialUpdate** | [**MediaFileTemplatePartialUpdate**](MediaFileTemplatePartialUpdate.md)|  | 

### Return type

[**MediaFileTemplate**](MediaFileTemplate.md)

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

<a name="patchmediaroot"></a>
# **PatchMediaRoot**
> MediaRoot PatchMediaRoot (int id, MediaRootPartialUpdate mediaRootPartialUpdate)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchMediaRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this media root.
            var mediaRootPartialUpdate = new MediaRootPartialUpdate(); // MediaRootPartialUpdate | 

            try
            {
                MediaRoot result = apiInstance.PatchMediaRoot(id, mediaRootPartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.PatchMediaRoot: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this media root. | 
 **mediaRootPartialUpdate** | [**MediaRootPartialUpdate**](MediaRootPartialUpdate.md)|  | 

### Return type

[**MediaRoot**](MediaRoot.md)

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

<a name="patchmediarootpermission"></a>
# **PatchMediaRootPermission**
> MediaRootPermission PatchMediaRootPermission (int id, MediaRootPermissionPartialUpdate mediaRootPermissionPartialUpdate)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchMediaRootPermissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Media Root Permission.
            var mediaRootPermissionPartialUpdate = new MediaRootPermissionPartialUpdate(); // MediaRootPermissionPartialUpdate | 

            try
            {
                MediaRootPermission result = apiInstance.PatchMediaRootPermission(id, mediaRootPermissionPartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.PatchMediaRootPermission: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Media Root Permission. | 
 **mediaRootPermissionPartialUpdate** | [**MediaRootPermissionPartialUpdate**](MediaRootPermissionPartialUpdate.md)|  | 

### Return type

[**MediaRootPermission**](MediaRootPermission.md)

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

<a name="patchmediatag"></a>
# **PatchMediaTag**
> UnfilteredTag PatchMediaTag (int id, UnfilteredTagPartialUpdate unfilteredTagPartialUpdate)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchMediaTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Tag.
            var unfilteredTagPartialUpdate = new UnfilteredTagPartialUpdate(); // UnfilteredTagPartialUpdate | 

            try
            {
                UnfilteredTag result = apiInstance.PatchMediaTag(id, unfilteredTagPartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.PatchMediaTag: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Tag. | 
 **unfilteredTagPartialUpdate** | [**UnfilteredTagPartialUpdate**](UnfilteredTagPartialUpdate.md)|  | 

### Return type

[**UnfilteredTag**](UnfilteredTag.md)

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

<a name="patchproxyprofile"></a>
# **PatchProxyProfile**
> ProxyProfile PatchProxyProfile (int id, ProxyProfilePartialUpdate proxyProfilePartialUpdate)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchProxyProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this proxy profile.
            var proxyProfilePartialUpdate = new ProxyProfilePartialUpdate(); // ProxyProfilePartialUpdate | 

            try
            {
                ProxyProfile result = apiInstance.PatchProxyProfile(id, proxyProfilePartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.PatchProxyProfile: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this proxy profile. | 
 **proxyProfilePartialUpdate** | [**ProxyProfilePartialUpdate**](ProxyProfilePartialUpdate.md)|  | 

### Return type

[**ProxyProfile**](ProxyProfile.md)

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

<a name="patchsubclip"></a>
# **PatchSubclip**
> Subclip PatchSubclip (int id, SubclipPartialUpdate subclipPartialUpdate)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchSubclipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this subclip.
            var subclipPartialUpdate = new SubclipPartialUpdate(); // SubclipPartialUpdate | 

            try
            {
                Subclip result = apiInstance.PatchSubclip(id, subclipPartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.PatchSubclip: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this subclip. | 
 **subclipPartialUpdate** | [**SubclipPartialUpdate**](SubclipPartialUpdate.md)|  | 

### Return type

[**Subclip**](Subclip.md)

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

<a name="recursivelytagmediadirectory"></a>
# **RecursivelyTagMediaDirectory**
> void RecursivelyTagMediaDirectory (int id, TagMediaDirectoryRequest tagMediaDirectoryRequest)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class RecursivelyTagMediaDirectoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this File.
            var tagMediaDirectoryRequest = new TagMediaDirectoryRequest(); // TagMediaDirectoryRequest | 

            try
            {
                apiInstance.RecursivelyTagMediaDirectory(id, tagMediaDirectoryRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.RecursivelyTagMediaDirectory: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this File. | 
 **tagMediaDirectoryRequest** | [**TagMediaDirectoryRequest**](TagMediaDirectoryRequest.md)|  | 

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

<a name="reindexmediadirectory"></a>
# **ReindexMediaDirectory**
> void ReindexMediaDirectory (int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class ReindexMediaDirectoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this File.

            try
            {
                apiInstance.ReindexMediaDirectory(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.ReindexMediaDirectory: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this File. | 

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

<a name="renamecustomfield"></a>
# **RenameCustomField**
> TaskInfo RenameCustomField (int id, RenameCustomFieldRequest renameCustomFieldRequest)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class RenameCustomFieldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Custom field.
            var renameCustomFieldRequest = new RenameCustomFieldRequest(); // RenameCustomFieldRequest | 

            try
            {
                TaskInfo result = apiInstance.RenameCustomField(id, renameCustomFieldRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.RenameCustomField: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Custom field. | 
 **renameCustomFieldRequest** | [**RenameCustomFieldRequest**](RenameCustomFieldRequest.md)|  | 

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

<a name="rendersequence"></a>
# **RenderSequence**
> TaskInfo RenderSequence (RenderEndpointRequest renderEndpointRequest)



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
    public class RenderSequenceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var renderEndpointRequest = new RenderEndpointRequest(); // RenderEndpointRequest | 

            try
            {
                TaskInfo result = apiInstance.RenderSequence(renderEndpointRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.RenderSequence: " + e.Message );
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
 **renderEndpointRequest** | [**RenderEndpointRequest**](RenderEndpointRequest.md)|  | 

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

<a name="rendersubclip"></a>
# **RenderSubclip**
> TaskInfo RenderSubclip (int id, RenderRequest renderRequest)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class RenderSubclipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this subclip.
            var renderRequest = new RenderRequest(); // RenderRequest | 

            try
            {
                TaskInfo result = apiInstance.RenderSubclip(id, renderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.RenderSubclip: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this subclip. | 
 **renderRequest** | [**RenderRequest**](RenderRequest.md)|  | 

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

<a name="requestmediascan"></a>
# **RequestMediaScan**
> void RequestMediaScan (ScannerScanEndpointRequest scannerScanEndpointRequest)



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
    public class RequestMediaScanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var scannerScanEndpointRequest = new ScannerScanEndpointRequest(); // ScannerScanEndpointRequest | 

            try
            {
                apiInstance.RequestMediaScan(scannerScanEndpointRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.RequestMediaScan: " + e.Message );
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
 **scannerScanEndpointRequest** | [**ScannerScanEndpointRequest**](ScannerScanEndpointRequest.md)|  | 

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

<a name="resolvecomment"></a>
# **ResolveComment**
> Comment ResolveComment (int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class ResolveCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Comment.

            try
            {
                Comment result = apiInstance.ResolveComment(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.ResolveComment: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Comment. | 

### Return type

[**Comment**](Comment.md)

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

<a name="sharemedialibraryobjects"></a>
# **ShareMediaLibraryObjects**
> OneTimeAccessToken ShareMediaLibraryObjects (MediaLibraryShareRequest mediaLibraryShareRequest)



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
    public class ShareMediaLibraryObjectsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var mediaLibraryShareRequest = new MediaLibraryShareRequest(); // MediaLibraryShareRequest | 

            try
            {
                OneTimeAccessToken result = apiInstance.ShareMediaLibraryObjects(mediaLibraryShareRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.ShareMediaLibraryObjects: " + e.Message );
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
 **mediaLibraryShareRequest** | [**MediaLibraryShareRequest**](MediaLibraryShareRequest.md)|  | 

### Return type

[**OneTimeAccessToken**](OneTimeAccessToken.md)

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

<a name="testexternaltranscoderconnection"></a>
# **TestExternalTranscoderConnection**
> TestExternalTranscoderConnectionResponse TestExternalTranscoderConnection (TestExternalTranscoderConnectionRequest testExternalTranscoderConnectionRequest)



### Required permissions    * User account permission: `media:access` (read) / `system:admin-access` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class TestExternalTranscoderConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var testExternalTranscoderConnectionRequest = new TestExternalTranscoderConnectionRequest(); // TestExternalTranscoderConnectionRequest | 

            try
            {
                TestExternalTranscoderConnectionResponse result = apiInstance.TestExternalTranscoderConnection(testExternalTranscoderConnectionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.TestExternalTranscoderConnection: " + e.Message );
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
 **testExternalTranscoderConnectionRequest** | [**TestExternalTranscoderConnectionRequest**](TestExternalTranscoderConnectionRequest.md)|  | 

### Return type

[**TestExternalTranscoderConnectionResponse**](TestExternalTranscoderConnectionResponse.md)

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

<a name="transitionworkflow"></a>
# **TransitionWorkflow**
> WorkflowTransitionResponse TransitionWorkflow (WorkflowTransitionRequest workflowTransitionRequest)



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
    public class TransitionWorkflowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var workflowTransitionRequest = new WorkflowTransitionRequest(); // WorkflowTransitionRequest | 

            try
            {
                WorkflowTransitionResponse result = apiInstance.TransitionWorkflow(workflowTransitionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.TransitionWorkflow: " + e.Message );
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
 **workflowTransitionRequest** | [**WorkflowTransitionRequest**](WorkflowTransitionRequest.md)|  | 

### Return type

[**WorkflowTransitionResponse**](WorkflowTransitionResponse.md)

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

<a name="unbookmarkmediadirectory"></a>
# **UnbookmarkMediaDirectory**
> void UnbookmarkMediaDirectory (int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UnbookmarkMediaDirectoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this File.

            try
            {
                apiInstance.UnbookmarkMediaDirectory(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.UnbookmarkMediaDirectory: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this File. | 

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

<a name="unmarkmediadirectoryasshowroom"></a>
# **UnmarkMediaDirectoryAsShowroom**
> void UnmarkMediaDirectoryAsShowroom (int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UnmarkMediaDirectoryAsShowroomExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this File.

            try
            {
                apiInstance.UnmarkMediaDirectoryAsShowroom(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.UnmarkMediaDirectoryAsShowroom: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this File. | 

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

<a name="unresolvecomment"></a>
# **UnresolveComment**
> Comment UnresolveComment (int id)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UnresolveCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Comment.

            try
            {
                Comment result = apiInstance.UnresolveComment(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.UnresolveComment: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Comment. | 

### Return type

[**Comment**](Comment.md)

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

<a name="updateasset"></a>
# **UpdateAsset**
> Asset UpdateAsset (int id, Asset asset)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Asset.
            var asset = new Asset(); // Asset | 

            try
            {
                Asset result = apiInstance.UpdateAsset(id, asset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.UpdateAsset: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Asset. | 
 **asset** | [**Asset**](Asset.md)|  | 

### Return type

[**Asset**](Asset.md)

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

<a name="updateassetrating"></a>
# **UpdateAssetRating**
> AssetRating UpdateAssetRating (int id, AssetRating assetRating)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateAssetRatingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Rating.
            var assetRating = new AssetRating(); // AssetRating | 

            try
            {
                AssetRating result = apiInstance.UpdateAssetRating(id, assetRating);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.UpdateAssetRating: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Rating. | 
 **assetRating** | [**AssetRating**](AssetRating.md)|  | 

### Return type

[**AssetRating**](AssetRating.md)

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

<a name="updatecomment"></a>
# **UpdateComment**
> Comment UpdateComment (int id, Comment comment)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Comment.
            var comment = new Comment(); // Comment | 

            try
            {
                Comment result = apiInstance.UpdateComment(id, comment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.UpdateComment: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Comment. | 
 **comment** | [**Comment**](Comment.md)|  | 

### Return type

[**Comment**](Comment.md)

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

<a name="updatecustomfield"></a>
# **UpdateCustomField**
> CustomField UpdateCustomField (int id, CustomField customField)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateCustomFieldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Custom field.
            var customField = new CustomField(); // CustomField | 

            try
            {
                CustomField result = apiInstance.UpdateCustomField(id, customField);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.UpdateCustomField: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Custom field. | 
 **customField** | [**CustomField**](CustomField.md)|  | 

### Return type

[**CustomField**](CustomField.md)

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

<a name="updateeditorproject"></a>
# **UpdateEditorProject**
> EditorProject UpdateEditorProject (int id, EditorProject editorProject)



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
    public class UpdateEditorProjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this File.
            var editorProject = new EditorProject(); // EditorProject | 

            try
            {
                EditorProject result = apiInstance.UpdateEditorProject(id, editorProject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.UpdateEditorProject: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this File. | 
 **editorProject** | [**EditorProject**](EditorProject.md)|  | 

### Return type

[**EditorProject**](EditorProject.md)

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

<a name="updateexternaltranscoder"></a>
# **UpdateExternalTranscoder**
> ExternalTranscoder UpdateExternalTranscoder (int id, ExternalTranscoder externalTranscoder)



### Required permissions    * User account permission: `media:access` (read) / `system:admin-access` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateExternalTranscoderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this external transcoder.
            var externalTranscoder = new ExternalTranscoder(); // ExternalTranscoder | 

            try
            {
                ExternalTranscoder result = apiInstance.UpdateExternalTranscoder(id, externalTranscoder);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.UpdateExternalTranscoder: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this external transcoder. | 
 **externalTranscoder** | [**ExternalTranscoder**](ExternalTranscoder.md)|  | 

### Return type

[**ExternalTranscoder**](ExternalTranscoder.md)

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

<a name="updatemarker"></a>
# **UpdateMarker**
> Marker UpdateMarker (int id, Marker marker)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateMarkerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this marker.
            var marker = new Marker(); // Marker | 

            try
            {
                Marker result = apiInstance.UpdateMarker(id, marker);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.UpdateMarker: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this marker. | 
 **marker** | [**Marker**](Marker.md)|  | 

### Return type

[**Marker**](Marker.md)

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

<a name="updatemediafile"></a>
# **UpdateMediaFile**
> MediaFile UpdateMediaFile (int id, MediaFile mediaFile)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateMediaFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this File.
            var mediaFile = new MediaFile(); // MediaFile | 

            try
            {
                MediaFile result = apiInstance.UpdateMediaFile(id, mediaFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.UpdateMediaFile: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this File. | 
 **mediaFile** | [**MediaFile**](MediaFile.md)|  | 

### Return type

[**MediaFile**](MediaFile.md)

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

<a name="updatemediafiletemplate"></a>
# **UpdateMediaFileTemplate**
> MediaFileTemplate UpdateMediaFileTemplate (int id, MediaFileTemplate mediaFileTemplate)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateMediaFileTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Template.
            var mediaFileTemplate = new MediaFileTemplate(); // MediaFileTemplate | 

            try
            {
                MediaFileTemplate result = apiInstance.UpdateMediaFileTemplate(id, mediaFileTemplate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.UpdateMediaFileTemplate: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Template. | 
 **mediaFileTemplate** | [**MediaFileTemplate**](MediaFileTemplate.md)|  | 

### Return type

[**MediaFileTemplate**](MediaFileTemplate.md)

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

<a name="updatemediaroot"></a>
# **UpdateMediaRoot**
> MediaRoot UpdateMediaRoot (int id, MediaRoot mediaRoot)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateMediaRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this media root.
            var mediaRoot = new MediaRoot(); // MediaRoot | 

            try
            {
                MediaRoot result = apiInstance.UpdateMediaRoot(id, mediaRoot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.UpdateMediaRoot: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this media root. | 
 **mediaRoot** | [**MediaRoot**](MediaRoot.md)|  | 

### Return type

[**MediaRoot**](MediaRoot.md)

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

<a name="updatemediarootpermission"></a>
# **UpdateMediaRootPermission**
> MediaRootPermission UpdateMediaRootPermission (int id, MediaRootPermission mediaRootPermission)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateMediaRootPermissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Media Root Permission.
            var mediaRootPermission = new MediaRootPermission(); // MediaRootPermission | 

            try
            {
                MediaRootPermission result = apiInstance.UpdateMediaRootPermission(id, mediaRootPermission);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.UpdateMediaRootPermission: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Media Root Permission. | 
 **mediaRootPermission** | [**MediaRootPermission**](MediaRootPermission.md)|  | 

### Return type

[**MediaRootPermission**](MediaRootPermission.md)

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

<a name="updatemediatag"></a>
# **UpdateMediaTag**
> UnfilteredTag UpdateMediaTag (int id, UnfilteredTag unfilteredTag)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateMediaTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this Tag.
            var unfilteredTag = new UnfilteredTag(); // UnfilteredTag | 

            try
            {
                UnfilteredTag result = apiInstance.UpdateMediaTag(id, unfilteredTag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.UpdateMediaTag: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this Tag. | 
 **unfilteredTag** | [**UnfilteredTag**](UnfilteredTag.md)|  | 

### Return type

[**UnfilteredTag**](UnfilteredTag.md)

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

<a name="updateproxyprofile"></a>
# **UpdateProxyProfile**
> ProxyProfile UpdateProxyProfile (int id, ProxyProfile proxyProfile)



### Required permissions    * User account permission: `media:access` (read) / `media:roots:manage` (write)   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateProxyProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this proxy profile.
            var proxyProfile = new ProxyProfile(); // ProxyProfile | 

            try
            {
                ProxyProfile result = apiInstance.UpdateProxyProfile(id, proxyProfile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.UpdateProxyProfile: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this proxy profile. | 
 **proxyProfile** | [**ProxyProfile**](ProxyProfile.md)|  | 

### Return type

[**ProxyProfile**](ProxyProfile.md)

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

<a name="updatesubclip"></a>
# **UpdateSubclip**
> Subclip UpdateSubclip (int id, Subclip subclip)



### Required permissions    * User account permission: `media:access`   * License component: media 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateSubclipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaLibraryApi(config);
            var id = 56;  // int | A unique integer value identifying this subclip.
            var subclip = new Subclip(); // Subclip | 

            try
            {
                Subclip result = apiInstance.UpdateSubclip(id, subclip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MediaLibraryApi.UpdateSubclip: " + e.Message );
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
 **id** | **int**| A unique integer value identifying this subclip. | 
 **subclip** | [**Subclip**](Subclip.md)|  | 

### Return type

[**Subclip**](Subclip.md)

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

