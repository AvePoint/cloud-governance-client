# RecertificationTaskGridModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Summary** | **String** |  | [optional] [default to null]
**Comments** | **String** |  | [optional] [default to null]
**Modified** | **System.DateTime** |  | [optional] [default to null]
**AssignTo** | **String** |  | [optional] [default to null]
**AssignToDisplayName** | **String** |  | [optional] [default to null]
**ObjectUrl** | **String** |  | [optional] [default to null]
**CreatedTime** | **String** |  | [optional] [default to null]
**TaskStatus** | [**TaskResult**](TaskResult.md) |  | [optional] [default to null]
**TaskStatusDescription** | **String** |  | [optional] [readonly] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientRecertificationTaskGridModel  -Summary null `
 -Comments null `
 -Modified null `
 -AssignTo null `
 -AssignToDisplayName null `
 -ObjectUrl null `
 -CreatedTime null `
 -TaskStatus null `
 -TaskStatusDescription null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

