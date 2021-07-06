# ElementsSDK.Api.AutomationApi

All URIs are relative to *https://elements.local*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AbortTask**](AutomationApi.md#aborttask) | **POST** /api/2/tasks/{id}/abort | 
[**CreateJob**](AutomationApi.md#createjob) | **POST** /api/2/jobs | 
[**CreateSchedule**](AutomationApi.md#createschedule) | **POST** /api/2/schedules | 
[**CreateSubtask**](AutomationApi.md#createsubtask) | **POST** /api/2/subtasks | 
[**DeleteFinishedTasks**](AutomationApi.md#deletefinishedtasks) | **DELETE** /api/2/tasks/finished | 
[**DeleteJob**](AutomationApi.md#deletejob) | **DELETE** /api/2/jobs/{id} | 
[**DeleteSchedule**](AutomationApi.md#deleteschedule) | **DELETE** /api/2/schedules/{id} | 
[**DeleteSubtask**](AutomationApi.md#deletesubtask) | **DELETE** /api/2/subtasks/{id} | 
[**DeleteTask**](AutomationApi.md#deletetask) | **DELETE** /api/2/tasks/{id} | 
[**DownloadAllTaskLogs**](AutomationApi.md#downloadalltasklogs) | **GET** /api/2/tasks/logs/download | 
[**DownloadTaskLog**](AutomationApi.md#downloadtasklog) | **GET** /api/2/tasks/{id}/log/download | 
[**GetAllEvents**](AutomationApi.md#getallevents) | **GET** /api/2/events | 
[**GetAllJobs**](AutomationApi.md#getalljobs) | **GET** /api/2/jobs | 
[**GetAllSchedules**](AutomationApi.md#getallschedules) | **GET** /api/2/schedules | 
[**GetAllSubtasks**](AutomationApi.md#getallsubtasks) | **GET** /api/2/subtasks | 
[**GetAllTaskQueues**](AutomationApi.md#getalltaskqueues) | **GET** /api/2/tasks/queues | 
[**GetAllTaskTypes**](AutomationApi.md#getalltasktypes) | **GET** /api/2/tasks/types | 
[**GetAllTasks**](AutomationApi.md#getalltasks) | **GET** /api/2/tasks | 
[**GetEvent**](AutomationApi.md#getevent) | **GET** /api/2/events/{id} | 
[**GetFinishedTasks**](AutomationApi.md#getfinishedtasks) | **GET** /api/2/tasks/finished | 
[**GetJob**](AutomationApi.md#getjob) | **GET** /api/2/jobs/{id} | 
[**GetPendingTasks**](AutomationApi.md#getpendingtasks) | **GET** /api/2/tasks/pending | 
[**GetPythonEnvironments**](AutomationApi.md#getpythonenvironments) | **GET** /api/2/python/environments | 
[**GetSchedule**](AutomationApi.md#getschedule) | **GET** /api/2/schedules/{id} | 
[**GetSubtask**](AutomationApi.md#getsubtask) | **GET** /api/2/subtasks/{id} | 
[**GetTask**](AutomationApi.md#gettask) | **GET** /api/2/tasks/{id} | 
[**GetTaskLog**](AutomationApi.md#gettasklog) | **GET** /api/2/tasks/{id}/log | 
[**GetTaskType**](AutomationApi.md#gettasktype) | **GET** /api/2/tasks/types/{type} | 
[**GetTasksSummary**](AutomationApi.md#gettaskssummary) | **GET** /api/2/tasks/summary | 
[**KillAllPendingTasks**](AutomationApi.md#killallpendingtasks) | **DELETE** /api/2/tasks/pending | 
[**KillTask**](AutomationApi.md#killtask) | **POST** /api/2/tasks/{id}/kill | 
[**PatchJob**](AutomationApi.md#patchjob) | **PATCH** /api/2/jobs/{id} | 
[**PatchSchedule**](AutomationApi.md#patchschedule) | **PATCH** /api/2/schedules/{id} | 
[**PatchSubtask**](AutomationApi.md#patchsubtask) | **PATCH** /api/2/subtasks/{id} | 
[**RestartTask**](AutomationApi.md#restarttask) | **POST** /api/2/tasks/{id}/restart | 
[**StartJob**](AutomationApi.md#startjob) | **POST** /api/2/jobs/{id}/start | 
[**StartTask**](AutomationApi.md#starttask) | **POST** /api/2/tasks/start | 
[**UpdateJob**](AutomationApi.md#updatejob) | **PUT** /api/2/jobs/{id} | 
[**UpdateSchedule**](AutomationApi.md#updateschedule) | **PUT** /api/2/schedules/{id} | 
[**UpdateSubtask**](AutomationApi.md#updatesubtask) | **PUT** /api/2/subtasks/{id} | 


<a name="aborttask"></a>
# **AbortTask**
> void AbortTask (string id)



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
    public class AbortTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var id = id_example;  // string | A unique value identifying this task info.

            try
            {
                apiInstance.AbortTask(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.AbortTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A unique value identifying this task info. | 

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

<a name="createjob"></a>
# **CreateJob**
> Job CreateJob (Job job)



### Required permissions    * User account permission: `None` (read) / `tasks:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var job = new Job(); // Job | 

            try
            {
                Job result = apiInstance.CreateJob(job);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.CreateJob: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **job** | [**Job**](Job.md)|  | 

### Return type

[**Job**](Job.md)

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

<a name="createschedule"></a>
# **CreateSchedule**
> Schedule CreateSchedule (Schedule schedule)



### Required permissions    * User account permission: `tasks:view` (read) / `tasks:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateScheduleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var schedule = new Schedule(); // Schedule | 

            try
            {
                Schedule result = apiInstance.CreateSchedule(schedule);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.CreateSchedule: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **schedule** | [**Schedule**](Schedule.md)|  | 

### Return type

[**Schedule**](Schedule.md)

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

<a name="createsubtask"></a>
# **CreateSubtask**
> Subtask CreateSubtask (Subtask subtask)



### Required permissions    * User account permission: `tasks:view` (read) / `tasks:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class CreateSubtaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var subtask = new Subtask(); // Subtask | 

            try
            {
                Subtask result = apiInstance.CreateSubtask(subtask);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.CreateSubtask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subtask** | [**Subtask**](Subtask.md)|  | 

### Return type

[**Subtask**](Subtask.md)

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

<a name="deletefinishedtasks"></a>
# **DeleteFinishedTasks**
> void DeleteFinishedTasks ()



### Required permissions    * User account permission: `None` (read) / `tasks:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteFinishedTasksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);

            try
            {
                apiInstance.DeleteFinishedTasks();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.DeleteFinishedTasks: " + e.Message );
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

<a name="deletejob"></a>
# **DeleteJob**
> void DeleteJob (int id)



### Required permissions    * User account permission: `None` (read) / `tasks:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var id = 56;  // int | A unique integer value identifying this job.

            try
            {
                apiInstance.DeleteJob(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.DeleteJob: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this job. | 

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

<a name="deleteschedule"></a>
# **DeleteSchedule**
> void DeleteSchedule (int id)



### Required permissions    * User account permission: `tasks:view` (read) / `tasks:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteScheduleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var id = 56;  // int | A unique integer value identifying this schedule.

            try
            {
                apiInstance.DeleteSchedule(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.DeleteSchedule: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this schedule. | 

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

<a name="deletesubtask"></a>
# **DeleteSubtask**
> void DeleteSubtask (int id)



### Required permissions    * User account permission: `tasks:view` (read) / `tasks:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteSubtaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var id = 56;  // int | A unique integer value identifying this subtask.

            try
            {
                apiInstance.DeleteSubtask(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.DeleteSubtask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this subtask. | 

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

<a name="deletetask"></a>
# **DeleteTask**
> void DeleteTask (string id)



### Required permissions    * User account permission: `None` (read) / `tasks:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class DeleteTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var id = id_example;  // string | A unique value identifying this task info.

            try
            {
                apiInstance.DeleteTask(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.DeleteTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A unique value identifying this task info. | 

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

<a name="downloadalltasklogs"></a>
# **DownloadAllTaskLogs**
> void DownloadAllTaskLogs (string jobInstance = null, string jobInstanceIn = null, string subtask = null, string state = null, decimal? stateIn = null, string id = null, string idIn = null, string name = null, string taskName = null, string ordering = null, int? limit = null, int? offset = null)



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
    public class DownloadAllTaskLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var jobInstance = jobInstance_example;  // string | Filter the returned list by `job_instance`. (optional) 
            var jobInstanceIn = jobInstanceIn_example;  // string | Multiple values may be separated by commas. (optional) 
            var subtask = subtask_example;  // string | Filter the returned list by `subtask`. (optional) 
            var state = state_example;  // string | Filter the returned list by `state`. (optional) 
            var stateIn = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var id = id_example;  // string | Filter the returned list by `id`. (optional) 
            var idIn = idIn_example;  // string | Multiple values may be separated by commas. (optional) 
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var taskName = taskName_example;  // string | Filter the returned list by `task_name`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                apiInstance.DownloadAllTaskLogs(jobInstance, jobInstanceIn, subtask, state, stateIn, id, idIn, name, taskName, ordering, limit, offset);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.DownloadAllTaskLogs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobInstance** | **string**| Filter the returned list by &#x60;job_instance&#x60;. | [optional] 
 **jobInstanceIn** | **string**| Multiple values may be separated by commas. | [optional] 
 **subtask** | **string**| Filter the returned list by &#x60;subtask&#x60;. | [optional] 
 **state** | **string**| Filter the returned list by &#x60;state&#x60;. | [optional] 
 **stateIn** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **id** | **string**| Filter the returned list by &#x60;id&#x60;. | [optional] 
 **idIn** | **string**| Multiple values may be separated by commas. | [optional] 
 **name** | **string**| Filter the returned list by &#x60;name&#x60;. | [optional] 
 **taskName** | **string**| Filter the returned list by &#x60;task_name&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

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

<a name="downloadtasklog"></a>
# **DownloadTaskLog**
> void DownloadTaskLog (string id)



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
    public class DownloadTaskLogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var id = id_example;  // string | A unique value identifying this task info.

            try
            {
                apiInstance.DownloadTaskLog(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.DownloadTaskLog: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A unique value identifying this task info. | 

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

<a name="getallevents"></a>
# **GetAllEvents**
> InlineResponse2002 GetAllEvents (string ordering = null, int? limit = null, int? offset = null)



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
    public class GetAllEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                InlineResponse2002 result = apiInstance.GetAllEvents(ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.GetAllEvents: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

[**InlineResponse2002**](InlineResponse2002.md)

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

<a name="getalljobs"></a>
# **GetAllJobs**
> List&lt;Job&gt; GetAllJobs (string specialType = null, string specialTypeIsnull = null, string hook = null, string name = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `None` (read) / `tasks:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllJobsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var specialType = specialType_example;  // string | Filter the returned list by `special_type`. (optional) 
            var specialTypeIsnull = specialTypeIsnull_example;  // string | Filter the returned list by `special_type__isnull`. (optional) 
            var hook = hook_example;  // string | Filter the returned list by `hook`. (optional) 
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<Job> result = apiInstance.GetAllJobs(specialType, specialTypeIsnull, hook, name, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.GetAllJobs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **specialType** | **string**| Filter the returned list by &#x60;special_type&#x60;. | [optional] 
 **specialTypeIsnull** | **string**| Filter the returned list by &#x60;special_type__isnull&#x60;. | [optional] 
 **hook** | **string**| Filter the returned list by &#x60;hook&#x60;. | [optional] 
 **name** | **string**| Filter the returned list by &#x60;name&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;Job&gt;**](Job.md)

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

<a name="getallschedules"></a>
# **GetAllSchedules**
> List&lt;Schedule&gt; GetAllSchedules (string job = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `tasks:view` (read) / `tasks:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllSchedulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var job = job_example;  // string | Filter the returned list by `job`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<Schedule> result = apiInstance.GetAllSchedules(job, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.GetAllSchedules: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **job** | **string**| Filter the returned list by &#x60;job&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;Schedule&gt;**](Schedule.md)

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

<a name="getallsubtasks"></a>
# **GetAllSubtasks**
> List&lt;Subtask&gt; GetAllSubtasks (string parent = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `tasks:view` (read) / `tasks:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllSubtasksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var parent = parent_example;  // string | Filter the returned list by `parent`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<Subtask> result = apiInstance.GetAllSubtasks(parent, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.GetAllSubtasks: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parent** | **string**| Filter the returned list by &#x60;parent&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;Subtask&gt;**](Subtask.md)

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

<a name="getalltaskqueues"></a>
# **GetAllTaskQueues**
> InlineResponse2003 GetAllTaskQueues (string ordering = null, int? limit = null, int? offset = null)



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
    public class GetAllTaskQueuesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                InlineResponse2003 result = apiInstance.GetAllTaskQueues(ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.GetAllTaskQueues: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

[**InlineResponse2003**](InlineResponse2003.md)

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

<a name="getalltasktypes"></a>
# **GetAllTaskTypes**
> InlineResponse2004 GetAllTaskTypes (string ordering = null, int? limit = null, int? offset = null)



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
    public class GetAllTaskTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                InlineResponse2004 result = apiInstance.GetAllTaskTypes(ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.GetAllTaskTypes: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

[**InlineResponse2004**](InlineResponse2004.md)

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

<a name="getalltasks"></a>
# **GetAllTasks**
> List&lt;TaskInfo&gt; GetAllTasks (string jobInstance = null, string jobInstanceIn = null, string subtask = null, string state = null, decimal? stateIn = null, string id = null, string idIn = null, string name = null, string taskName = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `None` (read) / `tasks:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetAllTasksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var jobInstance = jobInstance_example;  // string | Filter the returned list by `job_instance`. (optional) 
            var jobInstanceIn = jobInstanceIn_example;  // string | Multiple values may be separated by commas. (optional) 
            var subtask = subtask_example;  // string | Filter the returned list by `subtask`. (optional) 
            var state = state_example;  // string | Filter the returned list by `state`. (optional) 
            var stateIn = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var id = id_example;  // string | Filter the returned list by `id`. (optional) 
            var idIn = idIn_example;  // string | Multiple values may be separated by commas. (optional) 
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var taskName = taskName_example;  // string | Filter the returned list by `task_name`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<TaskInfo> result = apiInstance.GetAllTasks(jobInstance, jobInstanceIn, subtask, state, stateIn, id, idIn, name, taskName, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.GetAllTasks: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobInstance** | **string**| Filter the returned list by &#x60;job_instance&#x60;. | [optional] 
 **jobInstanceIn** | **string**| Multiple values may be separated by commas. | [optional] 
 **subtask** | **string**| Filter the returned list by &#x60;subtask&#x60;. | [optional] 
 **state** | **string**| Filter the returned list by &#x60;state&#x60;. | [optional] 
 **stateIn** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **id** | **string**| Filter the returned list by &#x60;id&#x60;. | [optional] 
 **idIn** | **string**| Multiple values may be separated by commas. | [optional] 
 **name** | **string**| Filter the returned list by &#x60;name&#x60;. | [optional] 
 **taskName** | **string**| Filter the returned list by &#x60;task_name&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;TaskInfo&gt;**](TaskInfo.md)

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

<a name="getevent"></a>
# **GetEvent**
> Event GetEvent (string id)



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
    public class GetEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var id = id_example;  // string | 

            try
            {
                Event result = apiInstance.GetEvent(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.GetEvent: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
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

[**Event**](Event.md)

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

<a name="getfinishedtasks"></a>
# **GetFinishedTasks**
> List&lt;TaskInfo&gt; GetFinishedTasks (string jobInstance = null, string jobInstanceIn = null, string subtask = null, string state = null, decimal? stateIn = null, string id = null, string idIn = null, string name = null, string taskName = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `None` (read) / `tasks:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetFinishedTasksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var jobInstance = jobInstance_example;  // string | Filter the returned list by `job_instance`. (optional) 
            var jobInstanceIn = jobInstanceIn_example;  // string | Multiple values may be separated by commas. (optional) 
            var subtask = subtask_example;  // string | Filter the returned list by `subtask`. (optional) 
            var state = state_example;  // string | Filter the returned list by `state`. (optional) 
            var stateIn = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var id = id_example;  // string | Filter the returned list by `id`. (optional) 
            var idIn = idIn_example;  // string | Multiple values may be separated by commas. (optional) 
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var taskName = taskName_example;  // string | Filter the returned list by `task_name`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<TaskInfo> result = apiInstance.GetFinishedTasks(jobInstance, jobInstanceIn, subtask, state, stateIn, id, idIn, name, taskName, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.GetFinishedTasks: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobInstance** | **string**| Filter the returned list by &#x60;job_instance&#x60;. | [optional] 
 **jobInstanceIn** | **string**| Multiple values may be separated by commas. | [optional] 
 **subtask** | **string**| Filter the returned list by &#x60;subtask&#x60;. | [optional] 
 **state** | **string**| Filter the returned list by &#x60;state&#x60;. | [optional] 
 **stateIn** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **id** | **string**| Filter the returned list by &#x60;id&#x60;. | [optional] 
 **idIn** | **string**| Multiple values may be separated by commas. | [optional] 
 **name** | **string**| Filter the returned list by &#x60;name&#x60;. | [optional] 
 **taskName** | **string**| Filter the returned list by &#x60;task_name&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;TaskInfo&gt;**](TaskInfo.md)

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

<a name="getjob"></a>
# **GetJob**
> Job GetJob (int id)



### Required permissions    * User account permission: `None` (read) / `tasks:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var id = 56;  // int | A unique integer value identifying this job.

            try
            {
                Job result = apiInstance.GetJob(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.GetJob: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this job. | 

### Return type

[**Job**](Job.md)

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

<a name="getpendingtasks"></a>
# **GetPendingTasks**
> List&lt;TaskInfo&gt; GetPendingTasks (string jobInstance = null, string jobInstanceIn = null, string subtask = null, string state = null, decimal? stateIn = null, string id = null, string idIn = null, string name = null, string taskName = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `None` (read) / `tasks:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetPendingTasksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var jobInstance = jobInstance_example;  // string | Filter the returned list by `job_instance`. (optional) 
            var jobInstanceIn = jobInstanceIn_example;  // string | Multiple values may be separated by commas. (optional) 
            var subtask = subtask_example;  // string | Filter the returned list by `subtask`. (optional) 
            var state = state_example;  // string | Filter the returned list by `state`. (optional) 
            var stateIn = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var id = id_example;  // string | Filter the returned list by `id`. (optional) 
            var idIn = idIn_example;  // string | Multiple values may be separated by commas. (optional) 
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var taskName = taskName_example;  // string | Filter the returned list by `task_name`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                List<TaskInfo> result = apiInstance.GetPendingTasks(jobInstance, jobInstanceIn, subtask, state, stateIn, id, idIn, name, taskName, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.GetPendingTasks: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobInstance** | **string**| Filter the returned list by &#x60;job_instance&#x60;. | [optional] 
 **jobInstanceIn** | **string**| Multiple values may be separated by commas. | [optional] 
 **subtask** | **string**| Filter the returned list by &#x60;subtask&#x60;. | [optional] 
 **state** | **string**| Filter the returned list by &#x60;state&#x60;. | [optional] 
 **stateIn** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **id** | **string**| Filter the returned list by &#x60;id&#x60;. | [optional] 
 **idIn** | **string**| Multiple values may be separated by commas. | [optional] 
 **name** | **string**| Filter the returned list by &#x60;name&#x60;. | [optional] 
 **taskName** | **string**| Filter the returned list by &#x60;task_name&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**List&lt;TaskInfo&gt;**](TaskInfo.md)

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

<a name="getpythonenvironments"></a>
# **GetPythonEnvironments**
> List&lt;PythonEnvironment&gt; GetPythonEnvironments ()



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
    public class GetPythonEnvironmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);

            try
            {
                List<PythonEnvironment> result = apiInstance.GetPythonEnvironments();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.GetPythonEnvironments: " + e.Message );
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

[**List&lt;PythonEnvironment&gt;**](PythonEnvironment.md)

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

<a name="getschedule"></a>
# **GetSchedule**
> Schedule GetSchedule (int id)



### Required permissions    * User account permission: `tasks:view` (read) / `tasks:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetScheduleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var id = 56;  // int | A unique integer value identifying this schedule.

            try
            {
                Schedule result = apiInstance.GetSchedule(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.GetSchedule: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this schedule. | 

### Return type

[**Schedule**](Schedule.md)

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

<a name="getsubtask"></a>
# **GetSubtask**
> Subtask GetSubtask (int id)



### Required permissions    * User account permission: `tasks:view` (read) / `tasks:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetSubtaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var id = 56;  // int | A unique integer value identifying this subtask.

            try
            {
                Subtask result = apiInstance.GetSubtask(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.GetSubtask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this subtask. | 

### Return type

[**Subtask**](Subtask.md)

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

<a name="gettask"></a>
# **GetTask**
> TaskInfo GetTask (string id)



### Required permissions    * User account permission: `None` (read) / `tasks:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var id = id_example;  // string | A unique value identifying this task info.

            try
            {
                TaskInfo result = apiInstance.GetTask(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.GetTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A unique value identifying this task info. | 

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

<a name="gettasklog"></a>
# **GetTaskLog**
> TaskLog GetTaskLog (string id)



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
    public class GetTaskLogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var id = id_example;  // string | A unique value identifying this task info.

            try
            {
                TaskLog result = apiInstance.GetTaskLog(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.GetTaskLog: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A unique value identifying this task info. | 

### Return type

[**TaskLog**](TaskLog.md)

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

<a name="gettasktype"></a>
# **GetTaskType**
> TaskType GetTaskType (string type)



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
    public class GetTaskTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var type = type_example;  // string | 

            try
            {
                TaskType result = apiInstance.GetTaskType(type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.GetTaskType: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**|  | 

### Return type

[**TaskType**](TaskType.md)

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

<a name="gettaskssummary"></a>
# **GetTasksSummary**
> TasksSummary GetTasksSummary (string jobInstance = null, string jobInstanceIn = null, string subtask = null, string state = null, decimal? stateIn = null, string id = null, string idIn = null, string name = null, string taskName = null, string ordering = null, int? limit = null, int? offset = null)



### Required permissions    * User account permission: `None` (read) / `tasks:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class GetTasksSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var jobInstance = jobInstance_example;  // string | Filter the returned list by `job_instance`. (optional) 
            var jobInstanceIn = jobInstanceIn_example;  // string | Multiple values may be separated by commas. (optional) 
            var subtask = subtask_example;  // string | Filter the returned list by `subtask`. (optional) 
            var state = state_example;  // string | Filter the returned list by `state`. (optional) 
            var stateIn = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var id = id_example;  // string | Filter the returned list by `id`. (optional) 
            var idIn = idIn_example;  // string | Multiple values may be separated by commas. (optional) 
            var name = name_example;  // string | Filter the returned list by `name`. (optional) 
            var taskName = taskName_example;  // string | Filter the returned list by `task_name`. (optional) 
            var ordering = ordering_example;  // string | Which field to use when ordering the results. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                TasksSummary result = apiInstance.GetTasksSummary(jobInstance, jobInstanceIn, subtask, state, stateIn, id, idIn, name, taskName, ordering, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.GetTasksSummary: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobInstance** | **string**| Filter the returned list by &#x60;job_instance&#x60;. | [optional] 
 **jobInstanceIn** | **string**| Multiple values may be separated by commas. | [optional] 
 **subtask** | **string**| Filter the returned list by &#x60;subtask&#x60;. | [optional] 
 **state** | **string**| Filter the returned list by &#x60;state&#x60;. | [optional] 
 **stateIn** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **id** | **string**| Filter the returned list by &#x60;id&#x60;. | [optional] 
 **idIn** | **string**| Multiple values may be separated by commas. | [optional] 
 **name** | **string**| Filter the returned list by &#x60;name&#x60;. | [optional] 
 **taskName** | **string**| Filter the returned list by &#x60;task_name&#x60;. | [optional] 
 **ordering** | **string**| Which field to use when ordering the results. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**TasksSummary**](TasksSummary.md)

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

<a name="killallpendingtasks"></a>
# **KillAllPendingTasks**
> void KillAllPendingTasks ()



### Required permissions    * User account permission: `None` (read) / `tasks:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class KillAllPendingTasksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);

            try
            {
                apiInstance.KillAllPendingTasks();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.KillAllPendingTasks: " + e.Message );
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

<a name="killtask"></a>
# **KillTask**
> void KillTask (string id)



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
    public class KillTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var id = id_example;  // string | A unique value identifying this task info.

            try
            {
                apiInstance.KillTask(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.KillTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A unique value identifying this task info. | 

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

<a name="patchjob"></a>
# **PatchJob**
> Job PatchJob (int id, JobPartialUpdate jobPartialUpdate)



### Required permissions    * User account permission: `None` (read) / `tasks:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var id = 56;  // int | A unique integer value identifying this job.
            var jobPartialUpdate = new JobPartialUpdate(); // JobPartialUpdate | 

            try
            {
                Job result = apiInstance.PatchJob(id, jobPartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.PatchJob: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this job. | 
 **jobPartialUpdate** | [**JobPartialUpdate**](JobPartialUpdate.md)|  | 

### Return type

[**Job**](Job.md)

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

<a name="patchschedule"></a>
# **PatchSchedule**
> Schedule PatchSchedule (int id, SchedulePartialUpdate schedulePartialUpdate)



### Required permissions    * User account permission: `tasks:view` (read) / `tasks:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchScheduleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var id = 56;  // int | A unique integer value identifying this schedule.
            var schedulePartialUpdate = new SchedulePartialUpdate(); // SchedulePartialUpdate | 

            try
            {
                Schedule result = apiInstance.PatchSchedule(id, schedulePartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.PatchSchedule: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this schedule. | 
 **schedulePartialUpdate** | [**SchedulePartialUpdate**](SchedulePartialUpdate.md)|  | 

### Return type

[**Schedule**](Schedule.md)

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

<a name="patchsubtask"></a>
# **PatchSubtask**
> Subtask PatchSubtask (int id, SubtaskPartialUpdate subtaskPartialUpdate)



### Required permissions    * User account permission: `tasks:view` (read) / `tasks:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class PatchSubtaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var id = 56;  // int | A unique integer value identifying this subtask.
            var subtaskPartialUpdate = new SubtaskPartialUpdate(); // SubtaskPartialUpdate | 

            try
            {
                Subtask result = apiInstance.PatchSubtask(id, subtaskPartialUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.PatchSubtask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this subtask. | 
 **subtaskPartialUpdate** | [**SubtaskPartialUpdate**](SubtaskPartialUpdate.md)|  | 

### Return type

[**Subtask**](Subtask.md)

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

<a name="restarttask"></a>
# **RestartTask**
> TaskInfo RestartTask (string id)



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
    public class RestartTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var id = id_example;  // string | A unique value identifying this task info.

            try
            {
                TaskInfo result = apiInstance.RestartTask(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.RestartTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A unique value identifying this task info. | 

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

<a name="startjob"></a>
# **StartJob**
> List&lt;TaskInfo&gt; StartJob (int id, StartJobRequest startJobRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class StartJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var id = 56;  // int | A unique integer value identifying this job.
            var startJobRequest = new StartJobRequest(); // StartJobRequest | 

            try
            {
                List<TaskInfo> result = apiInstance.StartJob(id, startJobRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.StartJob: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this job. | 
 **startJobRequest** | [**StartJobRequest**](StartJobRequest.md)|  | 

### Return type

[**List&lt;TaskInfo&gt;**](TaskInfo.md)

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

<a name="starttask"></a>
# **StartTask**
> TaskInfo StartTask (StartTaskRequest startTaskRequest)



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
    public class StartTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var startTaskRequest = new StartTaskRequest(); // StartTaskRequest | 

            try
            {
                TaskInfo result = apiInstance.StartTask(startTaskRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.StartTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startTaskRequest** | [**StartTaskRequest**](StartTaskRequest.md)|  | 

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

<a name="updatejob"></a>
# **UpdateJob**
> Job UpdateJob (int id, Job job)



### Required permissions    * User account permission: `None` (read) / `tasks:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var id = 56;  // int | A unique integer value identifying this job.
            var job = new Job(); // Job | 

            try
            {
                Job result = apiInstance.UpdateJob(id, job);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.UpdateJob: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this job. | 
 **job** | [**Job**](Job.md)|  | 

### Return type

[**Job**](Job.md)

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

<a name="updateschedule"></a>
# **UpdateSchedule**
> Schedule UpdateSchedule (int id, Schedule schedule)



### Required permissions    * User account permission: `tasks:view` (read) / `tasks:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateScheduleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var id = 56;  // int | A unique integer value identifying this schedule.
            var schedule = new Schedule(); // Schedule | 

            try
            {
                Schedule result = apiInstance.UpdateSchedule(id, schedule);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.UpdateSchedule: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this schedule. | 
 **schedule** | [**Schedule**](Schedule.md)|  | 

### Return type

[**Schedule**](Schedule.md)

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

<a name="updatesubtask"></a>
# **UpdateSubtask**
> Subtask UpdateSubtask (int id, Subtask subtask)



### Required permissions    * User account permission: `tasks:view` (read) / `tasks:manage` (write) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ElementsSDK.Api;
using ElementsSDK.Client;
using ElementsSDK.Model;

namespace Example
{
    public class UpdateSubtaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://elements.local";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutomationApi(config);
            var id = 56;  // int | A unique integer value identifying this subtask.
            var subtask = new Subtask(); // Subtask | 

            try
            {
                Subtask result = apiInstance.UpdateSubtask(id, subtask);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutomationApi.UpdateSubtask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| A unique integer value identifying this subtask. | 
 **subtask** | [**Subtask**](Subtask.md)|  | 

### Return type

[**Subtask**](Subtask.md)

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

