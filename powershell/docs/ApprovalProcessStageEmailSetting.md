# ApprovalProcessStageEmailSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NotifyApproverWhenAssigned** | **Boolean** |  | [optional] [default to null]
**NotifyApproverEmailTemplateId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**NotifyReuqesterWhenApproved** | **Boolean** |  | [optional] [default to null]
**NotifyReuqesterEmailTemplateApprovedId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**NotifyReuqesterWhenRejected** | **Boolean** |  | [optional] [default to null]
**NotifyReuqesterEmailTemplateRejectedId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**WarnApproverbeforeExpired** | **Boolean** |  | [optional] [default to null]
**WarnApproverbeforeExpiredEmailTemplateId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**NotifyApproverWhenExpired** | **Boolean** |  | [optional] [default to null]
**NotifyApproverWhenExpiredEmailTemplateId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**NotifyApproverWhenCancelled** | **Boolean** |  | [optional] [default to null]
**NotifyApproverCancelledEmailTemplateId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**NotifyApproverWhenRejected** | **Boolean** |  | [optional] [default to null]
**NotifyApproverRejectedEmailTemplateId** | [**UUID**](UUID.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientApprovalProcessStageEmailSetting  -NotifyApproverWhenAssigned null `
 -NotifyApproverEmailTemplateId null `
 -NotifyReuqesterWhenApproved null `
 -NotifyReuqesterEmailTemplateApprovedId null `
 -NotifyReuqesterWhenRejected null `
 -NotifyReuqesterEmailTemplateRejectedId null `
 -WarnApproverbeforeExpired null `
 -WarnApproverbeforeExpiredEmailTemplateId null `
 -NotifyApproverWhenExpired null `
 -NotifyApproverWhenExpiredEmailTemplateId null `
 -NotifyApproverWhenCancelled null `
 -NotifyApproverCancelledEmailTemplateId null `
 -NotifyApproverWhenRejected null `
 -NotifyApproverRejectedEmailTemplateId null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

