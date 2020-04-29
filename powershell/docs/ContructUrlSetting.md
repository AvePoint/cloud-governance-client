# ContructUrlSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Rules** | **String[]** |  | [optional] [default to null]
**Suffix** | **String** |  | [optional] [default to null]
**Connection** | **String** |  | [optional] [default to null]
**ContructUrlAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientContructUrlSetting  -Rules null `
 -Suffix null `
 -Connection null `
 -ContructUrlAssignBy null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

