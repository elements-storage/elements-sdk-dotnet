# ElementsSDK.Api.AuthApi

All URIs are relative to *https://elements.local*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckAuthTicket**](AuthApi.md#checkauthticket) | **POST** /api/2/auth/ticket/check | 
[**CreateAuthTicket**](AuthApi.md#createauthticket) | **POST** /api/2/auth/ticket | 
[**DeleteAccessToken**](AuthApi.md#deleteaccesstoken) | **DELETE** /api/2/auth/access-tokens/{id} | 
[**GeneratePassword**](AuthApi.md#generatepassword) | **POST** /api/2/auth/generate-password | 
[**GetAccessToken**](AuthApi.md#getaccesstoken) | **GET** /api/2/auth/access-tokens/{id} | 
[**GetAllAccessTokens**](AuthApi.md#getallaccesstokens) | **GET** /api/2/auth/access-tokens | 
[**Login**](AuthApi.md#login) | **POST** /api/2/auth/login | 
[**Logout**](AuthApi.md#logout) | **POST** /api/2/auth/logout | 
[**ResetPassword**](AuthApi.md#resetpassword) | **POST** /api/2/auth/reset-password | 
[**SendAccessTokenEmailNotification**](AuthApi.md#sendaccesstokenemailnotification) | **POST** /api/2/auth/access-tokens/{id}/email | 
[**StartImpersonation**](AuthApi.md#startimpersonation) | **POST** /api/2/auth/impersonation | 
[**StopImpersonation**](AuthApi.md#stopimpersonation) | **POST** /api/2/auth/impersonation/stop | 


<a name="checkauthticket"></a>
# **CheckAuthTicket**
> ElementsUserDetail CheckAuthTicket (Ticket ticket)



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
    public class CheckAuthTicketExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthApi(config);
            var ticket = new Ticket(); // Ticket | 

            try
            {
                ElementsUserDetail result = apiInstance.CheckAuthTicket(ticket);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.CheckAuthTicket: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ticket** | [**Ticket**](Ticket.md)|  | 

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

<a name="createauthticket"></a>
# **CreateAuthTicket**
> Ticket CreateAuthTicket ()



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
    public class CreateAuthTicketExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthApi(config);

            try
            {
                Ticket result = apiInstance.CreateAuthTicket();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.CreateAuthTicket: " + e.Message );
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

[**Ticket**](Ticket.md)

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

<a name="deleteaccesstoken"></a>
# **DeleteAccessToken**
> void DeleteAccessToken (int id)



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
    public class DeleteAccessTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthApi(config);
            var id = 56;  // int | A unique integer value identifying this one time access token.

            try
            {
                apiInstance.DeleteAccessToken(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.DeleteAccessToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this one time access token. | 

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

<a name="generatepassword"></a>
# **GeneratePassword**
> GeneratePasswordEndpointResponse GeneratePassword ()



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
    public class GeneratePasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthApi(config);

            try
            {
                GeneratePasswordEndpointResponse result = apiInstance.GeneratePassword();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GeneratePassword: " + e.Message );
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

[**GeneratePasswordEndpointResponse**](GeneratePasswordEndpointResponse.md)

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

<a name="getaccesstoken"></a>
# **GetAccessToken**
> OneTimeAccessToken GetAccessToken (int id)



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
    public class GetAccessTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthApi(config);
            var id = 56;  // int | A unique integer value identifying this one time access token.

            try
            {
                OneTimeAccessToken result = apiInstance.GetAccessToken(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAccessToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this one time access token. | 

### Return type

[**OneTimeAccessToken**](OneTimeAccessToken.md)

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

<a name="getallaccesstokens"></a>
# **GetAllAccessTokens**
> List&lt;OneTimeAccessToken&gt; GetAllAccessTokens (string sharedBundles = null, string sharedDirectories = null, string sharedBundlesAsset = null, string user = null, string createdBy = null, string ordering = null, int? limit = null, int? offset = null)



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
    public class GetAllAccessTokensExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthApi(config);
            var sharedBundles = sharedBundles_example;  // string | Filter the returned list by `shared_bundles`. (optional) 
            var sharedDirectories = sharedDirectories_example;  // string | Filter the returned list by `shared_directories`. (optional) 
            var sharedBundlesAsset = sharedBundlesAsset_example;  // string | Filter the returned list by `shared_bundles__asset`. (optional) 
            var user = user_example;  // string | Filter the returned list by `user`. (optional) 
            var createdBy = createdBy_example;  // string | Filter the returned list by `created_by`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<OneTimeAccessToken> result = apiInstance.GetAllAccessTokens(sharedBundles, sharedDirectories, sharedBundlesAsset, user, createdBy, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.GetAllAccessTokens: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sharedBundles** | **string**| Filter the returned list by &#x60;shared_bundles&#x60;. | [optional] 
 **sharedDirectories** | **string**| Filter the returned list by &#x60;shared_directories&#x60;. | [optional] 
 **sharedBundlesAsset** | **string**| Filter the returned list by &#x60;shared_bundles__asset&#x60;. | [optional] 
 **user** | **string**| Filter the returned list by &#x60;user&#x60;. | [optional] 
 **createdBy** | **string**| Filter the returned list by &#x60;created_by&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;OneTimeAccessToken&gt;**](OneTimeAccessToken.md)

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

<a name="login"></a>
# **Login**
> AuthLoginEndpointResponse Login (AuthLoginEndpointRequest authLoginEndpointRequest)



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
    public class LoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthApi(config);
            var authLoginEndpointRequest = new AuthLoginEndpointRequest(); // AuthLoginEndpointRequest | 

            try
            {
                AuthLoginEndpointResponse result = apiInstance.Login(authLoginEndpointRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.Login: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authLoginEndpointRequest** | [**AuthLoginEndpointRequest**](AuthLoginEndpointRequest.md)|  | 

### Return type

[**AuthLoginEndpointResponse**](AuthLoginEndpointResponse.md)

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

<a name="logout"></a>
# **Logout**
> void Logout ()



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
    public class LogoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthApi(config);

            try
            {
                apiInstance.Logout();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.Logout: " + e.Message );
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

<a name="resetpassword"></a>
# **ResetPassword**
> void ResetPassword (PasswordResetEndpointRequest passwordResetEndpointRequest)



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
    public class ResetPasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthApi(config);
            var passwordResetEndpointRequest = new PasswordResetEndpointRequest(); // PasswordResetEndpointRequest | 

            try
            {
                apiInstance.ResetPassword(passwordResetEndpointRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.ResetPassword: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **passwordResetEndpointRequest** | [**PasswordResetEndpointRequest**](PasswordResetEndpointRequest.md)|  | 

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

<a name="sendaccesstokenemailnotification"></a>
# **SendAccessTokenEmailNotification**
> void SendAccessTokenEmailNotification (int id, SendLinkEmailRequest sendLinkEmailRequest)



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
    public class SendAccessTokenEmailNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthApi(config);
            var id = 56;  // int | A unique integer value identifying this one time access token.
            var sendLinkEmailRequest = new SendLinkEmailRequest(); // SendLinkEmailRequest | 

            try
            {
                apiInstance.SendAccessTokenEmailNotification(id, sendLinkEmailRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.SendAccessTokenEmailNotification: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this one time access token. | 
 **sendLinkEmailRequest** | [**SendLinkEmailRequest**](SendLinkEmailRequest.md)|  | 

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

<a name="startimpersonation"></a>
# **StartImpersonation**
> void StartImpersonation (ImpersonationEndpointRequest impersonationEndpointRequest)



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
    public class StartImpersonationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthApi(config);
            var impersonationEndpointRequest = new ImpersonationEndpointRequest(); // ImpersonationEndpointRequest | 

            try
            {
                apiInstance.StartImpersonation(impersonationEndpointRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.StartImpersonation: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **impersonationEndpointRequest** | [**ImpersonationEndpointRequest**](ImpersonationEndpointRequest.md)|  | 

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

<a name="stopimpersonation"></a>
# **StopImpersonation**
> void StopImpersonation ()



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
    public class StopImpersonationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthApi(config);

            try
            {
                apiInstance.StopImpersonation();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.StopImpersonation: " + e.Message );
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

