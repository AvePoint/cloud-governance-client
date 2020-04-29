# ObjectContactModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**SecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientObjectContactModel  -PrimaryContact null `
 -SecondaryContact null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

