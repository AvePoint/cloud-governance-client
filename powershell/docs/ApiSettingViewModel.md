# ApiSettingViewModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**Secret** | **String** |  | [optional] [default to null]
**SecretDuration** | **String** |  | [optional] [default to null]
**Expiration** | **System.DateTime** |  | [optional] [default to null]
**ApiEndpoint** | **String** |  | [optional] [default to null]
**ClientId** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientApiSettingViewModel  -Id null `
 -Name null `
 -Secret null `
 -SecretDuration null `
 -Expiration null `
 -ApiEndpoint null `
 -ClientId null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

