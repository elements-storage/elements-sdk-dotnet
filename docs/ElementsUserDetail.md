# ElementsSDK.Model.ElementsUserDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [optional] [readonly] 
**AllowChangingPassword** | **bool** |  | [optional] 
**AllowWanLogin** | **bool** |  | [optional] 
**AllowedFsPaths** | **List&lt;string&gt;** |  | [optional] [readonly] 
**AllowedFsWritePaths** | **List&lt;string&gt;** |  | [optional] [readonly] 
**Avatar** | **string** |  | [optional] 
**ClientSessions** | [**List&lt;ClientSession&gt;**](ClientSession.md) |  | [optional] [readonly] 
**DefaultPage** | **string** |  | [optional] 
**DisplayName** | **string** |  | [optional] [readonly] 
**EffectivePermissions** | **List&lt;string&gt;** |  | [optional] [readonly] 
**Email** | **string** |  | [optional] 
**Expiry** | **DateTime?** |  | [optional] 
**AncillaryPathReadOnly** | **bool** |  | [optional] 
**AncillaryPath** | **string** |  | [optional] 
**FmBookmarks** | **List&lt;string&gt;** |  | [optional] 
**FullName** | **string** |  | [optional] 
**Gid** | **int?** |  | [optional] 
**GroupPermissions** | **List&lt;string&gt;** |  | [optional] [readonly] 
**HasPassword** | **bool** |  | [optional] [readonly] 
**Home** | **int?** |  | [optional] 
**IsExternal** | **bool** |  | [optional] 
**IsCloud** | **bool** |  | [optional] 
**IsCloudDefault** | **bool** |  | [optional] 
**IsEnabled** | **bool** |  | [optional] 
**Language** | **string** |  | [optional] 
**LastSeen** | **DateTime?** |  | [optional] 
**Ldap** | [**LDAPServerReference**](LDAPServerReference.md) |  | [optional] 
**LdapDn** | **string** |  | [optional] 
**PasswordChangeRequired** | **bool** |  | [optional] 
**Permissions** | **List&lt;string&gt;** |  | 
**ShaperCeiling** | **int?** |  | [optional] 
**ShaperRate** | **int?** |  | [optional] 
**SyncId** | **Guid** |  | [optional] [readonly] 
**TotpEnabled** | **bool** |  | [optional] 
**Uid** | **int?** |  | [optional] 
**UnixUsername** | **string** |  | [optional] 
**Username** | **string** |  | 
**Groups** | **List&lt;int&gt;** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

