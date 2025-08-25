# ManualImportSharedMailboxJobModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectType** | [**ImportObjectType**](ImportObjectType.md) |  | [optional] 
**Workspaces** | [**ImportSharedMailboxModel[]**](ImportSharedMailboxModel.md) |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**FileName** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ManualImportSharedMailboxJobModel = New-Cloud.Governance.ClientManualImportSharedMailboxJobModel  -ObjectType null `
 -Workspaces null `
 -Name null `
 -Description null `
 -FileName null
```

- Convert the resource to JSON
```powershell
$ManualImportSharedMailboxJobModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

