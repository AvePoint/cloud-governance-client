# AdministratorNotificationViewModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReminderProfiles** | [**GuidModel[]**](GuidModel.md) |  | [optional] [default to null]
**NotificationEmailTemplates** | [**GuidModel[]**](GuidModel.md) |  | [optional] [default to null]
**EscalationEmailTemplates** | [**GuidModel[]**](GuidModel.md) |  | [optional] [default to null]
**ReassignEmailTemplates** | [**GuidModel[]**](GuidModel.md) |  | [optional] [default to null]
**AdministratorContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**EmailSettings** | [**GuidSettingModel**](GuidSettingModel.md) |  | [optional] [default to null]
**EscalationSettings** | [**AdminNotificationEscalationModel**](AdminNotificationEscalationModel.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientAdministratorNotificationViewModel  -ReminderProfiles null `
 -NotificationEmailTemplates null `
 -EscalationEmailTemplates null `
 -ReassignEmailTemplates null `
 -AdministratorContact null `
 -EmailSettings null `
 -EscalationSettings null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

