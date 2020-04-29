# LookupValue
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tenant** | **String** |  | [optional] [readonly] [default to null]
**Property** | **String** |  | [optional] [readonly] [default to null]
**TargetUser** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**UserPropertyValue** | **String** |  | [optional] [default to null]
**UserPropertyDisplayValue** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientLookupValue  -Tenant null `
 -Property null `
 -TargetUser null `
 -UserPropertyValue null `
 -UserPropertyDisplayValue null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

