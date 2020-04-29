# ApprovalProcessStageInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApproveUser** | [**UserInfo**](UserInfo.md) |  | [optional] [default to null]
**EscalationUser** | [**UserInfo**](UserInfo.md) |  | [optional] [default to null]
**EditPermissionReport** | **Boolean** |  | [optional] [default to null]
**NotifyApproverWhenExpired** | **Boolean** |  | [optional] [default to null]
**NotifyApproverWhenExpiredEmailTemplateID** | [**UUID**](UUID.md) |  | [optional] [default to null]
**WarnApproverbeforeExpired** | **Boolean** |  | [optional] [default to null]
**WarnApproverbeforeExpiredEmailTemplateID** | [**UUID**](UUID.md) |  | [optional] [default to null]
**IsDurationEnabled** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientApprovalProcessStageInfo  -ApproveUser null `
 -EscalationUser null `
 -EditPermissionReport null `
 -NotifyApproverWhenExpired null `
 -NotifyApproverWhenExpiredEmailTemplateID null `
 -WarnApproverbeforeExpired null `
 -WarnApproverbeforeExpiredEmailTemplateID null `
 -IsDurationEnabled null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

