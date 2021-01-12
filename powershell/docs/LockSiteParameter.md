# LockSiteParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LockType** | [**LockSiteCollectionType**](LockSiteCollectionType.md) |  | [optional] 
**Workspace** | [**WorkspaceIdTypeModel[]**](WorkspaceIdTypeModel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$LockSiteParameter = New-Cloud.Governance.ClientLockSiteParameter  -LockType null `
 -Workspace null
```

- Convert the resource to JSON
```powershell
$LockSiteParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

