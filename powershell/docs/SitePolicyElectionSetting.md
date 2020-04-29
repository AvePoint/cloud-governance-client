# SitePolicyElectionSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsEnabled** | **Boolean** |  | [optional] [default to null]
**EnableOnlyOtherContactElection** | **Boolean** |  | [optional] [default to null]
**ExcludeUsers** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]
**IsNotifyTaskEnabled** | **Boolean** |  | [optional] [default to null]
**TaskEmailTemplate** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]
**IsNotifyPrimaryContactEnabled** | **Boolean** |  | [optional] [default to null]
**NotifyPrimaryContactTemplate** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]
**IsNotifySecondaryContactEnabled** | **Boolean** |  | [optional] [default to null]
**NotifySecondaryContactTemplate** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]
**Duration** | **Int32** |  | [optional] [default to null]
**DurationType** | **Int32** |  | [optional] [default to null]
**IsReminderEnabled** | **Boolean** |  | [optional] [default to null]
**ReminderProfile** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSitePolicyElectionSetting  -IsEnabled null `
 -EnableOnlyOtherContactElection null `
 -ExcludeUsers null `
 -IsNotifyTaskEnabled null `
 -TaskEmailTemplate null `
 -IsNotifyPrimaryContactEnabled null `
 -NotifyPrimaryContactTemplate null `
 -IsNotifySecondaryContactEnabled null `
 -NotifySecondaryContactTemplate null `
 -Duration null `
 -DurationType null `
 -IsReminderEnabled null `
 -ReminderProfile null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

