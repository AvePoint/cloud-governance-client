# ApprovalProcessStageModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApproveOrder** | [**ApproveOrder**](ApproveOrder.md) |  | [optional] [default to null]
**Approvers** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**IsAllowAutocrat** | **Boolean** |  | [optional] [default to null]
**IsAllowReassign** | **Boolean** |  | [optional] [default to null]
**DurationSetting** | [**ApprovalProcessStageDurationSetting**](ApprovalProcessStageDurationSetting.md) |  | [optional] [default to null]
**EmailSetting** | [**ApprovalProcessStageEmailSetting**](ApprovalProcessStageEmailSetting.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientApprovalProcessStageModel  -ApproveOrder null `
 -Approvers null `
 -Description null `
 -Name null `
 -IsAllowAutocrat null `
 -IsAllowReassign null `
 -DurationSetting null `
 -EmailSetting null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

