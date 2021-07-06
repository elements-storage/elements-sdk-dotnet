# ElementsSDK.Api.IntegrationsApi

All URIs are relative to *https://elements.local*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteSlackConnection**](IntegrationsApi.md#deleteslackconnection) | **DELETE** /api/2/integrations/slack/{id} | 
[**DeleteTeamsConnection**](IntegrationsApi.md#deleteteamsconnection) | **DELETE** /api/2/integrations/teams/{id} | 
[**GetAllSlackConnections**](IntegrationsApi.md#getallslackconnections) | **GET** /api/2/integrations/slack | 
[**GetAllTeamsConnections**](IntegrationsApi.md#getallteamsconnections) | **GET** /api/2/integrations/teams | 
[**GetSlackChannels**](IntegrationsApi.md#getslackchannels) | **GET** /api/2/integrations/slack/{id}/channels | 
[**GetSlackConnection**](IntegrationsApi.md#getslackconnection) | **GET** /api/2/integrations/slack/{id} | 
[**GetSlackEmoji**](IntegrationsApi.md#getslackemoji) | **GET** /api/2/integrations/slack/{id}/emoji | 
[**GetSlackUsers**](IntegrationsApi.md#getslackusers) | **GET** /api/2/integrations/slack/{id}/users | 
[**GetTeamsChannels**](IntegrationsApi.md#getteamschannels) | **GET** /api/2/integrations/teams/{id}/channels | 
[**GetTeamsConnection**](IntegrationsApi.md#getteamsconnection) | **GET** /api/2/integrations/teams/{id} | 
[**GetTeamsUsers**](IntegrationsApi.md#getteamsusers) | **GET** /api/2/integrations/teams/{id}/users | 
[**PatchSlackConnection**](IntegrationsApi.md#patchslackconnection) | **PATCH** /api/2/integrations/slack/{id} | 
[**PatchTeamsConnection**](IntegrationsApi.md#patchteamsconnection) | **PATCH** /api/2/integrations/teams/{id} | 
[**SendSlackMessage**](IntegrationsApi.md#sendslackmessage) | **POST** /api/2/integrations/slack/{id}/message | 
[**SendTeamsMessage**](IntegrationsApi.md#sendteamsmessage) | **POST** /api/2/integrations/teams/{id}/send-message | 
[**StartSlackConnectionFlow**](IntegrationsApi.md#startslackconnectionflow) | **GET** /api/2/integrations/slack/connect | 
[**StartSlackConnectionTokenRefreshFlow**](IntegrationsApi.md#startslackconnectiontokenrefreshflow) | **GET** /api/2/integrations/slack/{id}/refresh-token | 
[**StartTeamsConnectionFlow**](IntegrationsApi.md#startteamsconnectionflow) | **GET** /api/2/integrations/teams/connect | 
[**StartTeamsConnectionTokenRefreshFlow**](IntegrationsApi.md#startteamsconnectiontokenrefreshflow) | **GET** /api/2/integrations/teams/{id}/refresh-token | 
[**UpdateSlackConnection**](IntegrationsApi.md#updateslackconnection) | **PUT** /api/2/integrations/slack/{id} | 
[**UpdateTeamsConnection**](IntegrationsApi.md#updateteamsconnection) | **PUT** /api/2/integrations/teams/{id} | 


<a name="deleteslackconnection"></a>
# **DeleteSlackConnection**
> void DeleteSlackConnection (int id)



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
    public class DeleteSlackConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationsApi(config);
            var id = 56;  // int | A unique integer value identifying this Slack connection.

            try
            {
                apiInstance.DeleteSlackConnection(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.DeleteSlackConnection: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this Slack connection. | 

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

<a name="deleteteamsconnection"></a>
# **DeleteTeamsConnection**
> void DeleteTeamsConnection (int id)



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
    public class DeleteTeamsConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationsApi(config);
            var id = 56;  // int | A unique integer value identifying this Teams connection.

            try
            {
                apiInstance.DeleteTeamsConnection(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.DeleteTeamsConnection: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this Teams connection. | 

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

<a name="getallslackconnections"></a>
# **GetAllSlackConnections**
> List&lt;SlackConnection&gt; GetAllSlackConnections (string ordering = null, int? limit = null, int? offset = null)



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
    public class GetAllSlackConnectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationsApi(config);
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<SlackConnection> result = apiInstance.GetAllSlackConnections(ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetAllSlackConnections: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

[**List&lt;SlackConnection&gt;**](SlackConnection.md)

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

<a name="getallteamsconnections"></a>
# **GetAllTeamsConnections**
> List&lt;TeamsConnection&gt; GetAllTeamsConnections (string ordering = null, int? limit = null, int? offset = null)



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
    public class GetAllTeamsConnectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationsApi(config);
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<TeamsConnection> result = apiInstance.GetAllTeamsConnections(ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetAllTeamsConnections: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

[**List&lt;TeamsConnection&gt;**](TeamsConnection.md)

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

<a name="getslackchannels"></a>
# **GetSlackChannels**
> List&lt;SlackChannel&gt; GetSlackChannels (int id)



### Required permissions    * User account permission: `tasks:manage` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetSlackChannelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationsApi(config);
            var id = 56;  // int | A unique integer value identifying this Slack connection.

            try
            {
                List<SlackChannel> result = apiInstance.GetSlackChannels(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetSlackChannels: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this Slack connection. | 

### Return type

[**List&lt;SlackChannel&gt;**](SlackChannel.md)

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

<a name="getslackconnection"></a>
# **GetSlackConnection**
> SlackConnection GetSlackConnection (int id)



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
    public class GetSlackConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationsApi(config);
            var id = 56;  // int | A unique integer value identifying this Slack connection.

            try
            {
                SlackConnection result = apiInstance.GetSlackConnection(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetSlackConnection: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this Slack connection. | 

### Return type

[**SlackConnection**](SlackConnection.md)

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

<a name="getslackemoji"></a>
# **GetSlackEmoji**
> List&lt;SlackEmoji&gt; GetSlackEmoji (int id)



### Required permissions    * User account permission: `tasks:manage` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetSlackEmojiExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationsApi(config);
            var id = 56;  // int | A unique integer value identifying this Slack connection.

            try
            {
                List<SlackEmoji> result = apiInstance.GetSlackEmoji(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetSlackEmoji: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this Slack connection. | 

### Return type

[**List&lt;SlackEmoji&gt;**](SlackEmoji.md)

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

<a name="getslackusers"></a>
# **GetSlackUsers**
> List&lt;SlackUser&gt; GetSlackUsers (int id)



### Required permissions    * User account permission: `tasks:manage` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetSlackUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationsApi(config);
            var id = 56;  // int | A unique integer value identifying this Slack connection.

            try
            {
                List<SlackUser> result = apiInstance.GetSlackUsers(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetSlackUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this Slack connection. | 

### Return type

[**List&lt;SlackUser&gt;**](SlackUser.md)

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

<a name="getteamschannels"></a>
# **GetTeamsChannels**
> List&lt;TeamsRecipient&gt; GetTeamsChannels (int id)



### Required permissions    * User account permission: `tasks:manage` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetTeamsChannelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationsApi(config);
            var id = 56;  // int | A unique integer value identifying this Teams connection.

            try
            {
                List<TeamsRecipient> result = apiInstance.GetTeamsChannels(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetTeamsChannels: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this Teams connection. | 

### Return type

[**List&lt;TeamsRecipient&gt;**](TeamsRecipient.md)

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

<a name="getteamsconnection"></a>
# **GetTeamsConnection**
> TeamsConnection GetTeamsConnection (int id)



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
    public class GetTeamsConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationsApi(config);
            var id = 56;  // int | A unique integer value identifying this Teams connection.

            try
            {
                TeamsConnection result = apiInstance.GetTeamsConnection(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetTeamsConnection: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this Teams connection. | 

### Return type

[**TeamsConnection**](TeamsConnection.md)

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

<a name="getteamsusers"></a>
# **GetTeamsUsers**
> List&lt;TeamsRecipient&gt; GetTeamsUsers (int id)



### Required permissions    * User account permission: `tasks:manage` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetTeamsUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationsApi(config);
            var id = 56;  // int | A unique integer value identifying this Teams connection.

            try
            {
                List<TeamsRecipient> result = apiInstance.GetTeamsUsers(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.GetTeamsUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this Teams connection. | 

### Return type

[**List&lt;TeamsRecipient&gt;**](TeamsRecipient.md)

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

<a name="patchslackconnection"></a>
# **PatchSlackConnection**
> SlackConnection PatchSlackConnection (int id, SlackConnectionPartialUpdate slackConnectionPartialUpdate)



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
    public class PatchSlackConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationsApi(config);
            var id = 56;  // int | A unique integer value identifying this Slack connection.
            var slackConnectionPartialUpdate = new SlackConnectionPartialUpdate(); // SlackConnectionPartialUpdate | 

            try
            {
                SlackConnection result = apiInstance.PatchSlackConnection(id, slackConnectionPartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PatchSlackConnection: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this Slack connection. | 
 **slackConnectionPartialUpdate** | [**SlackConnectionPartialUpdate**](SlackConnectionPartialUpdate.md)|  | 

### Return type

[**SlackConnection**](SlackConnection.md)

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

<a name="patchteamsconnection"></a>
# **PatchTeamsConnection**
> TeamsConnection PatchTeamsConnection (int id, TeamsConnectionPartialUpdate teamsConnectionPartialUpdate)



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
    public class PatchTeamsConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationsApi(config);
            var id = 56;  // int | A unique integer value identifying this Teams connection.
            var teamsConnectionPartialUpdate = new TeamsConnectionPartialUpdate(); // TeamsConnectionPartialUpdate | 

            try
            {
                TeamsConnection result = apiInstance.PatchTeamsConnection(id, teamsConnectionPartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.PatchTeamsConnection: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this Teams connection. | 
 **teamsConnectionPartialUpdate** | [**TeamsConnectionPartialUpdate**](TeamsConnectionPartialUpdate.md)|  | 

### Return type

[**TeamsConnection**](TeamsConnection.md)

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

<a name="sendslackmessage"></a>
# **SendSlackMessage**
> void SendSlackMessage (int id, SlackMessage slackMessage)



### Required permissions    * User account permission: `tasks:manage` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class SendSlackMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationsApi(config);
            var id = 56;  // int | A unique integer value identifying this Slack connection.
            var slackMessage = new SlackMessage(); // SlackMessage | 

            try
            {
                apiInstance.SendSlackMessage(id, slackMessage);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.SendSlackMessage: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this Slack connection. | 
 **slackMessage** | [**SlackMessage**](SlackMessage.md)|  | 

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

<a name="sendteamsmessage"></a>
# **SendTeamsMessage**
> void SendTeamsMessage (int id, TeamsMessage teamsMessage)



### Required permissions    * User account permission: `tasks:manage` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class SendTeamsMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationsApi(config);
            var id = 56;  // int | A unique integer value identifying this Teams connection.
            var teamsMessage = new TeamsMessage(); // TeamsMessage | 

            try
            {
                apiInstance.SendTeamsMessage(id, teamsMessage);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.SendTeamsMessage: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this Teams connection. | 
 **teamsMessage** | [**TeamsMessage**](TeamsMessage.md)|  | 

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

<a name="startslackconnectionflow"></a>
# **StartSlackConnectionFlow**
> void StartSlackConnectionFlow (string ordering = null, int? limit = null, int? offset = null)



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
    public class StartSlackConnectionFlowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationsApi(config);
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                apiInstance.StartSlackConnectionFlow(ordering, limit, offset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.StartSlackConnectionFlow: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | No body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="startslackconnectiontokenrefreshflow"></a>
# **StartSlackConnectionTokenRefreshFlow**
> void StartSlackConnectionTokenRefreshFlow (int id)



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
    public class StartSlackConnectionTokenRefreshFlowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationsApi(config);
            var id = 56;  // int | A unique integer value identifying this Slack connection.

            try
            {
                apiInstance.StartSlackConnectionTokenRefreshFlow(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.StartSlackConnectionTokenRefreshFlow: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this Slack connection. | 

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

<a name="startteamsconnectionflow"></a>
# **StartTeamsConnectionFlow**
> void StartTeamsConnectionFlow (string ordering = null, int? limit = null, int? offset = null, string team = null)



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
    public class StartTeamsConnectionFlowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationsApi(config);
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 
            var team = team_example;  // string |  (optional) 

            try
            {
                apiInstance.StartTeamsConnectionFlow(ordering, limit, offset, team);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.StartTeamsConnectionFlow: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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
 **team** | **string**|  | [optional] 

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
| **301** | Redirects to setup page |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="startteamsconnectiontokenrefreshflow"></a>
# **StartTeamsConnectionTokenRefreshFlow**
> void StartTeamsConnectionTokenRefreshFlow (int id, string team = null)



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
    public class StartTeamsConnectionTokenRefreshFlowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationsApi(config);
            var id = 56;  // int | A unique integer value identifying this Teams connection.
            var team = team_example;  // string |  (optional) 

            try
            {
                apiInstance.StartTeamsConnectionTokenRefreshFlow(id, team);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.StartTeamsConnectionTokenRefreshFlow: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this Teams connection. | 
 **team** | **string**|  | [optional] 

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
| **301** | Redirects to setup page |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateslackconnection"></a>
# **UpdateSlackConnection**
> SlackConnection UpdateSlackConnection (int id, SlackConnection slackConnection)



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
    public class UpdateSlackConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationsApi(config);
            var id = 56;  // int | A unique integer value identifying this Slack connection.
            var slackConnection = new SlackConnection(); // SlackConnection | 

            try
            {
                SlackConnection result = apiInstance.UpdateSlackConnection(id, slackConnection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.UpdateSlackConnection: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this Slack connection. | 
 **slackConnection** | [**SlackConnection**](SlackConnection.md)|  | 

### Return type

[**SlackConnection**](SlackConnection.md)

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

<a name="updateteamsconnection"></a>
# **UpdateTeamsConnection**
> TeamsConnection UpdateTeamsConnection (int id, TeamsConnection teamsConnection)



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
    public class UpdateTeamsConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IntegrationsApi(config);
            var id = 56;  // int | A unique integer value identifying this Teams connection.
            var teamsConnection = new TeamsConnection(); // TeamsConnection | 

            try
            {
                TeamsConnection result = apiInstance.UpdateTeamsConnection(id, teamsConnection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntegrationsApi.UpdateTeamsConnection: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this Teams connection. | 
 **teamsConnection** | [**TeamsConnection**](TeamsConnection.md)|  | 

### Return type

[**TeamsConnection**](TeamsConnection.md)

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

