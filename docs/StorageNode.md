# ElementsSDK.Model.StorageNode

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [optional] [readonly] 
**Name** | **string** |  | [optional] 
**Address** | **string** | For communication between nodes only | [optional] 
**AddressOverride** | **string** | Enforces mounting from a specific address/hostname instead of the available interfaces | [optional] 
**Backend** | [**Backend**](Backend.md) |  | [optional] 
**Type** | **int** |  | [optional] 
**Ipmi** | **int** |  | [optional] 
**Interfaces** | [**List&lt;Interface&gt;**](Interface.md) |  | [optional] [readonly] 
**Status** | [**StorageNodeStatus**](StorageNodeStatus.md) |  | [optional] 
**IsLogAggregator** | **bool** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

