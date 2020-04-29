# ApprovalProcessModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompletionTemplateId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**StageOne** | [**ApprovalProcessStageModel**](ApprovalProcessStageModel.md) |  | [optional] [default to null]
**StageTwo** | [**ApprovalProcessStageModel**](ApprovalProcessStageModel.md) |  | [optional] [default to null]
**StageThree** | [**ApprovalProcessStageModel**](ApprovalProcessStageModel.md) |  | [optional] [default to null]
**StageSettings** | [**ApprovalProcessStageSettings**](ApprovalProcessStageSettings.md) |  | [optional] [default to null]
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**Status** | [**CommonStatus**](CommonStatus.md) |  | [optional] [default to null]
**Category** | **String** |  | [optional] [default to null]
**Cc** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientApprovalProcessModel  -CompletionTemplateId null `
 -StageOne null `
 -StageTwo null `
 -StageThree null `
 -StageSettings null `
 -Id null `
 -Name null `
 -Description null `
 -Status null `
 -Category null `
 -Cc null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

