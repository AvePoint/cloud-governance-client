# ChangeExchangeResourceSettingsGroupModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupId** | **String** |  | [optional] 
**OfficeTenantId** | **String** |  | [optional] 
**GroupName** | **String** |  | [optional] 
**Email** | **String** |  | [optional] 
**WorkspaceType** | [**WorkspaceType**](WorkspaceType.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeExchangeResourceSettingsGroupModel = New-Cloud.Governance.ClientChangeExchangeResourceSettingsGroupModel  -GroupId null `
 -OfficeTenantId null `
 -GroupName null `
 -Email null `
 -WorkspaceType null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$ChangeExchangeResourceSettingsGroupModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

