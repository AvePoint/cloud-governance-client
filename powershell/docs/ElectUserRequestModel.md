# ElectUserRequestModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **String** |  | [optional] [default to null]
**ExcludeUsers** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]
**EnableNotifyTask** | **Boolean** |  | [optional] [default to null]
**TaskEmailTemplateId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**EnableNotifyPrimaryContact** | **Boolean** |  | [optional] [default to null]
**NotifyPrimaryContactTemplateId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**EnableNotifySecondaryContact** | **Boolean** |  | [optional] [default to null]
**NotifySecondaryContactTemplateId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Duration** | **Int32** |  | [optional] [default to null]
**DurationType** | [**ElectionDurationType**](ElectionDurationType.md) |  | [optional] [default to null]
**IsEnableTaskReminder** | **Boolean** |  | [optional] [default to null]
**TaskReminderProfileId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**SelectedSiteIds** | **String[]** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientElectUserRequestModel  -Title null `
 -ExcludeUsers null `
 -EnableNotifyTask null `
 -TaskEmailTemplateId null `
 -EnableNotifyPrimaryContact null `
 -NotifyPrimaryContactTemplateId null `
 -EnableNotifySecondaryContact null `
 -NotifySecondaryContactTemplateId null `
 -Duration null `
 -DurationType null `
 -IsEnableTaskReminder null `
 -TaskReminderProfileId null `
 -SelectedSiteIds null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

