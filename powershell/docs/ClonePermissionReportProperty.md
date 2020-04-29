# ClonePermissionReportProperty
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaskTitle** | **String** |  | [optional] [default to null]
**IsAllowedReassign** | **Boolean** |  | [optional] [default to null]
**ReportGeneratedTime** | **System.DateTime** |  | [optional] [default to null]
**TargetUser** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientClonePermissionReportProperty  -TaskTitle null `
 -IsAllowedReassign null `
 -ReportGeneratedTime null `
 -TargetUser null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

