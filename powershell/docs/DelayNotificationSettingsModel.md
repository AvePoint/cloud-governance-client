# DelayNotificationSettingsModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsEnabled** | **Boolean** |  | [optional] [default to null]
**DelayHours** | **Int32** |  | [optional] [default to null]
**EmailThreshold** | **Int32** |  | [optional] [default to null]
**NotifyUsers** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientDelayNotificationSettingsModel  -IsEnabled null `
 -DelayHours null `
 -EmailThreshold null `
 -NotifyUsers null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

