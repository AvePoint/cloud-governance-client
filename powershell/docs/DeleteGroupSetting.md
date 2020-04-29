# DeleteGroupSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableNotify** | **Boolean** |  | [optional] [default to null]
**NotifyUsers** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]
**EmailTemplate** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]
**Enabled** | **Boolean** |  | [optional] [default to null]
**ApprovalProcess** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]
**IsUsedDefaultProcess** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientDeleteGroupSetting  -EnableNotify null `
 -NotifyUsers null `
 -EmailTemplate null `
 -Enabled null `
 -ApprovalProcess null `
 -IsUsedDefaultProcess null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

