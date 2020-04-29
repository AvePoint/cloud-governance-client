# GroupThresholdSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** |  | [optional] [default to null]
**Duration** | **Int32** |  | [optional] [default to null]
**DurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] [default to null]
**ThresholdApprovalProcess** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]
**EnableWarning** | **Boolean** |  | [optional] [default to null]
**WarningProfile** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]
**EnableAdditionalAction** | **Boolean** |  | [optional] [default to null]
**AdditionalActionType** | [**AdditionalActionType**](AdditionalActionType.md) |  | [optional] [default to null]
**DeleteGroupDuration** | **Int32** |  | [optional] [default to null]
**DeleteDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] [default to null]
**EnableDeleteRemind** | **Boolean** |  | [optional] [default to null]
**DeleteGroupReminder** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]
**EnableDeleteNotify** | **Boolean** |  | [optional] [default to null]
**DeleteNotifyUsers** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]
**DeleteNotifyEmail** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]
**ArchiveGroupDuration** | **Int32** |  | [optional] [default to null]
**ArchiveGroupDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] [default to null]
**EnableArchiveRemind** | **Boolean** |  | [optional] [default to null]
**ArchiveGroupReminder** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]
**EnableArchiveNotify** | **Boolean** |  | [optional] [default to null]
**ArchiveNotifyUsers** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]
**ArchiveNotifyEmail** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientGroupThresholdSetting  -Enabled null `
 -Duration null `
 -DurationType null `
 -ThresholdApprovalProcess null `
 -EnableWarning null `
 -WarningProfile null `
 -EnableAdditionalAction null `
 -AdditionalActionType null `
 -DeleteGroupDuration null `
 -DeleteDurationType null `
 -EnableDeleteRemind null `
 -DeleteGroupReminder null `
 -EnableDeleteNotify null `
 -DeleteNotifyUsers null `
 -DeleteNotifyEmail null `
 -ArchiveGroupDuration null `
 -ArchiveGroupDurationType null `
 -EnableArchiveRemind null `
 -ArchiveGroupReminder null `
 -EnableArchiveNotify null `
 -ArchiveNotifyUsers null `
 -ArchiveNotifyEmail null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

