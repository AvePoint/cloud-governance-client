# SpecifyContactParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PrimaryContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**SecondaryContact** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**PrimaryContactNotifiedEmail** | **String** |  | [optional] 
**SecondaryContactNotifiedEmail** | **String** |  | [optional] 
**IsRemoveSecondaryContact** | **Boolean** |  | [optional] [default to $false]
**Workspace** | [**WorkspaceIdTypeModel[]**](WorkspaceIdTypeModel.md) |  | [optional] 
**IsSelectAllWorkspace** | **Boolean** |  | [optional] [default to $false]
**Type** | [**WorkspaceType**](WorkspaceType.md) |  | [optional] 
**IsConfirmed** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$SpecifyContactParameter = New-Cloud.Governance.ClientSpecifyContactParameter  -PrimaryContact null `
 -SecondaryContact null `
 -PrimaryContactNotifiedEmail null `
 -SecondaryContactNotifiedEmail null `
 -IsRemoveSecondaryContact null `
 -Workspace null `
 -IsSelectAllWorkspace null `
 -Type null `
 -IsConfirmed null
```

- Convert the resource to JSON
```powershell
$SpecifyContactParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

