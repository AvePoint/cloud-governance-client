# GroupRecertificationJobTrigger
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**JobType** | [**GroupRecertificationType**](GroupRecertificationType.md) |  | [optional] [default to null]
**GroupNameOrId** | **String** |  | [optional] [default to null]
**IsEnabled** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientGroupRecertificationJobTrigger  -JobType null `
 -GroupNameOrId null `
 -IsEnabled null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

