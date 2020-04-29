# ApprovalProcessStageDurationSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsDurationEnabled** | **Boolean** |  | [optional] [default to null]
**Reassigner** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**EscalationUsers** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]
**IsEnableDureationReminder** | **Boolean** |  | [optional] [default to null]
**Duration** | **Int32** |  | [optional] [default to null]
**ReassignTemplateId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**AutoRejectTemplateId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**NotifyTemplateId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**DurationReminderProfileId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**DurationType** | [**DurationType**](DurationType.md) |  | [optional] [default to null]
**EscalationType** | [**EscalationType**](EscalationType.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientApprovalProcessStageDurationSetting  -IsDurationEnabled null `
 -Reassigner null `
 -EscalationUsers null `
 -IsEnableDureationReminder null `
 -Duration null `
 -ReassignTemplateId null `
 -AutoRejectTemplateId null `
 -NotifyTemplateId null `
 -DurationReminderProfileId null `
 -DurationType null `
 -EscalationType null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

