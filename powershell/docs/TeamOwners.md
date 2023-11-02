# TeamOwners
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Owners** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**PredefinedOwners** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$TeamOwners = New-Cloud.Governance.ClientTeamOwners  -Owners null `
 -PredefinedOwners null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$TeamOwners | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

