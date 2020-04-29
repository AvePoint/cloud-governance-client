# AdministratorNotificationModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdministratorContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**EmailSettings** | [**GuidSettingModel**](GuidSettingModel.md) |  | [optional] [default to null]
**EscalationSettings** | [**AdminNotificationEscalationModel**](AdminNotificationEscalationModel.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientAdministratorNotificationModel  -AdministratorContact null `
 -EmailSettings null `
 -EscalationSettings null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

