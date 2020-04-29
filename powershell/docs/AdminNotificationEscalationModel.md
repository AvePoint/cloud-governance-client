# AdminNotificationEscalationModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsEnabled** | **Boolean** |  | [optional] [default to null]
**Interval** | **Int32** |  | [optional] [default to null]
**IntervalType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] [default to null]
**ReminderSetting** | [**GuidSettingModel**](GuidSettingModel.md) |  | [optional] [default to null]
**EscalationType** | [**ApiEscalationType**](ApiEscalationType.md) |  | [optional] [default to null]
**EscalationUser** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**EscalationEmailTemplate** | [**UUID**](UUID.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientAdminNotificationEscalationModel  -IsEnabled null `
 -Interval null `
 -IntervalType null `
 -ReminderSetting null `
 -EscalationType null `
 -EscalationUser null `
 -EscalationEmailTemplate null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

