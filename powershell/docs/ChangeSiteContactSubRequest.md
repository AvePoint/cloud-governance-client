# ChangeSiteContactSubRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**AssignTo** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]
**Reason** | **String** |  | [optional] [default to null]
**Status** | **Int32** |  | [optional] [readonly] [default to null]
**StatusDescription** | **String** |  | [optional] [readonly] [default to null]
**AdminContactSettings** | [**ChangeContactByUrlSetting**](ChangeContactByUrlSetting.md) |  | [optional] [default to null]
**ProgressStatus** | [**ApiRequestProgressStatus**](ApiRequestProgressStatus.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientChangeSiteContactSubRequest  -Id null `
 -AssignTo null `
 -Reason null `
 -Status null `
 -StatusDescription null `
 -AdminContactSettings null `
 -ProgressStatus null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

