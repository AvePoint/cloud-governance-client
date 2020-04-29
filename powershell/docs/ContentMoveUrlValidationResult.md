# ContentMoveUrlValidationResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | [**ContentMoveSPObject**](ContentMoveSPObject.md) |  | [optional] [default to null]
**ListBaseType** | **String** |  | [optional] [default to null]
**IsValid** | **Boolean** |  | [optional] [readonly] [default to null]
**ErrorMessage** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientContentMoveUrlValidationResult  -Object null `
 -ListBaseType null `
 -IsValid null `
 -ErrorMessage null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

