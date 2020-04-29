# ApprovalProcessStageCollection
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UniqueId** | **String** |  | [optional] [default to null]
**StageCount** | **Int32** |  | [optional] [default to null]
**StageOne** | [**ApprovalProcessStageInfo**](ApprovalProcessStageInfo.md) |  | [optional] [default to null]
**StageTwo** | [**ApprovalProcessStageInfo**](ApprovalProcessStageInfo.md) |  | [optional] [default to null]
**StageThree** | [**ApprovalProcessStageInfo**](ApprovalProcessStageInfo.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientApprovalProcessStageCollection  -UniqueId null `
 -StageCount null `
 -StageOne null `
 -StageTwo null `
 -StageThree null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

