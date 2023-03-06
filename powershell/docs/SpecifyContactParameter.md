# SpecifyContactParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PrimaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**PrimaryContactNotifiedEmail** | **String** |  | [optional] 
**SecondaryContactNotifiedEmail** | **String** |  | [optional] 
**Workspace** | [**WorkspaceIdTypeModel[]**](WorkspaceIdTypeModel.md) |  | [optional] 
**IsSelectAllWorkspace** | **Boolean** |  | [optional] [default to $false]
**Type** | [**WorkspaceType**](WorkspaceType.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SpecifyContactParameter = New-Cloud.Governance.ClientSpecifyContactParameter  -PrimaryContact null `
 -SecondaryContact null `
 -PrimaryContactNotifiedEmail null `
 -SecondaryContactNotifiedEmail null `
 -Workspace null `
 -IsSelectAllWorkspace null `
 -Type null
```

- Convert the resource to JSON
```powershell
$SpecifyContactParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

