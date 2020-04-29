# InviteSupportModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Services** | [**ApiFeedbackServiceType[]**](ApiFeedbackServiceType.md) |  | [optional] [default to null]
**IssueType** | [**IssueType**](IssueType.md) |  | [optional] [default to null]
**Severity** | [**Severity**](Severity.md) |  | [optional] [default to null]
**Detail** | **String** |  | [optional] [default to null]
**RelatedServiceName** | **String** |  | [optional] [default to null]
**FileName** | **String** |  | [optional] [default to null]
**ContactName** | **String** |  | [optional] [default to null]
**ContactOption** | [**ContactOption**](ContactOption.md) |  | [optional] [default to null]
**ContactDetail** | **String** |  | [optional] [default to null]
**ContactCC** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientInviteSupportModel  -Services null `
 -IssueType null `
 -Severity null `
 -Detail null `
 -RelatedServiceName null `
 -FileName null `
 -ContactName null `
 -ContactOption null `
 -ContactDetail null `
 -ContactCC null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

