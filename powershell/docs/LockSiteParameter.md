# LockSiteParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LockType** | [**LockSiteCollectionType**](LockSiteCollectionType.md) |  | [optional] 
**IsSendCancelEmail** | **Boolean** |  | [optional] [default to $false]
**CancelEmailTemplateId** | **String** |  | [optional] 
**Workspace** | [**WorkspaceIdTypeModel[]**](WorkspaceIdTypeModel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$LockSiteParameter = New-Cloud.Governance.ClientLockSiteParameter  -LockType null `
 -IsSendCancelEmail null `
 -CancelEmailTemplateId null `
 -Workspace null
```

- Convert the resource to JSON
```powershell
$LockSiteParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

