# ConfirmInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SecondaryContact** | **String** |  | [optional] [default to null]
**PolicyId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Department** | **String** |  | [optional] [default to null]
**Metadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientConfirmInformation  -SecondaryContact null `
 -PolicyId null `
 -Department null `
 -Metadatas null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

