# ManualImportSiteJobModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectType** | [**ImportObjectType**](ImportObjectType.md) |  | [optional] 
**InactiveJobTimeBaseType** | [**LifecycleJobTimeBaseType**](LifecycleJobTimeBaseType.md) |  | [optional] 
**Workspaces** | [**ImportSiteModel[]**](ImportSiteModel.md) |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**FileName** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ManualImportSiteJobModel = New-Cloud.Governance.ClientManualImportSiteJobModel  -ObjectType null `
 -InactiveJobTimeBaseType null `
 -Workspaces null `
 -Name null `
 -Description null `
 -FileName null
```

- Convert the resource to JSON
```powershell
$ManualImportSiteJobModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

