# ApiUserChangedProperty
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChangeValue** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**OriginalValue** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 

## Examples

- Prepare the resource
```powershell
$ApiUserChangedProperty = New-Cloud.Governance.ClientApiUserChangedProperty  -ChangeValue null `
 -OriginalValue null
```

- Convert the resource to JSON
```powershell
$ApiUserChangedProperty | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

