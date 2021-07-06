# ElementsSDK.Model.Job

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [optional] [readonly] 
**Subtasks** | [**List&lt;SubtaskReference&gt;**](SubtaskReference.md) |  | [optional] 
**Schedules** | [**List&lt;ScheduleReference&gt;**](ScheduleReference.md) |  | [optional] 
**AllowUsers** | [**List&lt;ElementsUserReference&gt;**](ElementsUserReference.md) |  | [optional] 
**AllowGroups** | [**List&lt;ElementsGroupReference&gt;**](ElementsGroupReference.md) |  | [optional] 
**Startable** | **bool** |  | [optional] [readonly] 
**VariableDefinitions** | **List&lt;string&gt;** |  | [optional] 
**MediaRoots** | **List&lt;int&gt;** |  | [optional] 
**WebhookUrl** | **string** |  | [optional] [readonly] 
**SpecialType** | **int?** |  | [optional] 
**Name** | **string** |  | 
**Enabled** | **bool** |  | [optional] 
**AllowOthersToStart** | **bool** |  | [optional] 
**AllowClientToStart** | **bool** |  | [optional] 
**ShowAsButton** | **bool** |  | [optional] 
**InputType** | **string** |  | [optional] 
**Hook** | **string** |  | [optional] 
**WebhookSecret** | **string** |  | [optional] 
**SecurityContext** | **int?** |  | [optional] 
**PartOfWorkflowFor** | **int?** |  | [optional] 

[[Back to Model list]](../#documentation-for-models) [[Back to API list]](../#documentation-for-api-endpoints) [[Back to README]](../)

