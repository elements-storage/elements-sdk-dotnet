# ElementsSDK.Model.TaskInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**DisplayName** | **string** |  | [optional] [readonly] 
**Kwargs** | **Dictionary&lt;string, string&gt;** |  | 
**Subtask** | [**Subtask**](Subtask.md) |  | [optional] 
**Worker** | [**StorageNodeMini**](StorageNodeMini.md) |  | [optional] 
**User** | [**ElementsUserMini**](ElementsUserMini.md) |  | [optional] 
**Workstation** | [**Workstation**](Workstation.md) |  | [optional] 
**Progress** | [**TaskProgress**](TaskProgress.md) |  | [optional] 
**LogPath** | **string** |  | [optional] [readonly] 
**Name** | **string** |  | [optional] 
**TaskName** | **string** |  | [optional] 
**WorkerName** | **string** |  | [optional] 
**Queue** | **string** |  | [optional] 
**State** | **int** |  | [optional] 
**StateText** | **string** |  | [optional] 
**JobInstance** | **Guid?** |  | [optional] 
**Started** | **DateTime** |  | [optional] [readonly] 
**Finished** | **DateTime** |  | [optional] [readonly] 
**Exception** | **string** |  | [optional] 
**Traceback** | **string** |  | [optional] 
**Schedule** | **int?** |  | [optional] 

[[Back to Model list]](../#documentation-for-models) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to README]](../)

