# ReminderModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**EmailTemplate** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Interval** | **Int32** |  | [optional] [default to null]
**IntervalType** | [**ReminderDurationType**](ReminderDurationType.md) |  | [optional] [default to null]
**EnableRecurrentReminder** | **Boolean** |  | [optional] [default to null]
**RecurrentInterval** | **Int32** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientReminderModel  -Id null `
 -Name null `
 -Description null `
 -EmailTemplate null `
 -Interval null `
 -IntervalType null `
 -EnableRecurrentReminder null `
 -RecurrentInterval null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

