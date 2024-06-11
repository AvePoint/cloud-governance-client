# ManualImportGroupJobModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectType** | [**ImportObjectType**](ImportObjectType.md) |  | [optional] 
**InactiveJobTimeBaseType** | [**LifecycleJobTimeBaseType**](LifecycleJobTimeBaseType.md) |  | [optional] 
**Workspaces** | [**ImportGroupModel[]**](ImportGroupModel.md) |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**FileName** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ManualImportGroupJobModel = New-Cloud.Governance.ClientManualImportGroupJobModel  -ObjectType null `
 -InactiveJobTimeBaseType null `
 -Workspaces null `
 -Name null `
 -Description null `
 -FileName null
```

- Convert the resource to JSON
```powershell
$ManualImportGroupJobModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

